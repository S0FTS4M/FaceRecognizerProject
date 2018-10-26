using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.Diagnostics;
using System.IO;
using static Emgu.CV.FaceRecognizer;

namespace FaceRecognizerProject
{
    public partial class frmfacerec : Form
    {
        //Capture will access the camera and reads the stream
        private static CascadeClassifier classifier = new CascadeClassifier(@"haarcascade_frontalface_alt_tree.xml");
        
        //Recognizer Algorithm
        FaceRecognizer faceRecognizer = new LBPHFaceRecognizer(1, 8, 8, 8, 100.0);
        //The text font that we write the person name
        MCvFont mCvFont = new MCvFont(FONT.CV_FONT_HERSHEY_TRIPLEX, 1.0, 1.0);
        

        //random numbers for file names
        Random random = new Random();
        
        //FPS Counter
        Stopwatch stopwatch = new Stopwatch();
        int fps = 0;

        /// <summary>
        /// Capture Vars
        /// </summary>
        //gets camera stream as images
        Capture capture;
        //The original image we read from cam
        Image<Bgr, byte> capturedImage = null;
        //capturing info
        Color foreColor;
        string info = "";
        //if you dont want to try catching everytime your face detected you an enable auto capture
        bool autoCapture = false;
        //there will be a limit of time that you  can auto capture otherwise you will have a large amount of same face
        long elapsedTimeforAutoCapture = 0;
        //all settings are ready for capturing face? like does this person have a name
        private bool canCapture = false;

        //training phase
        //TODO: Save these names with recognizer and load after
        List<string> listOfFileNames = new List<string>();
        bool modeltrained = false;
        public frmfacerec()
        {
            InitializeComponent();
            capture = new Capture();
            //start timer and start capturing images
            timerCameraFramer.Start();
            //for fps counting
            stopwatch.Start();
        }

        private void timerCameraFramer_Tick(object sender, EventArgs e)
        {
            //reset canCapture every frame
            canCapture = false;
         ///FPS counter start
            fps++;
            if (stopwatch.ElapsedMilliseconds >= 1000)
            {
                elapsedTimeforAutoCapture += stopwatch.ElapsedMilliseconds;
                label1.Text = "FPS: " + fps.ToString();
                fps = 0;
                stopwatch.Restart();
            }
            ///fps counter end
            
            ///read from cam and get the 3 channel image
            capturedImage = capture.QueryFrame();
            //if we didnt train the model we just can detect the face
            if (modeltrained == false)
            {
                //get Detected face and detected face rectangle
                Tuple<Image<Bgr, byte>, Image<Gray, byte>> faceRectandGrayFace = DetectedFace(capturedImage.Clone());
                Image<Bgr, byte> foundFaceRect = faceRectandGrayFace.Item1;
                Image<Gray, byte> foundFace = faceRectandGrayFace.Item2;

                //did we captured successfully or not
                info = "";
                if (autoCapture && txtpersonname.Text != string.Empty)
                {
                    if (elapsedTimeforAutoCapture >= numupdautocapturems.Value)
                    {

                        //save captured image
                        if (canCapture)
                        {

                            //save image with name and 3 other random numbers
                            SaveImage(foundFace, txtpersonname.Text + random.Next(0, 9).ToString() + random.Next(0, 9).ToString() + random.Next(0, 9).ToString());
                            //reset elapsed time
                            elapsedTimeforAutoCapture = 0;
                            //saving is successfull
                            info = "Image Captured";
                            foreColor = Color.Green;
                            //make white all the pixels for flash light :D

                        }
                        else
                        {
                            //if we are here we couldnt capture the image so we dont want to wait another X ms
                            //so we can go 100ms back
                            elapsedTimeforAutoCapture -= 100;
                            //saving is failed
                            info = "Image could not captured";
                            foreColor = Color.Red;
                        }

                    }
                }
                //if we can capture but there is no person name we fail saving the faces
                else if (canCapture && txtpersonname.Text == string.Empty)
                {
                    elapsedTimeforAutoCapture -= 100;
                    info = "Image could not captured";
                    foreColor = Color.Red;
                }
                //show capturing info
                lblCapturingInfo.Text = info;
                lblCapturingInfo.ForeColor = foreColor;
                
                //show the image with rectangled face on it
                imageBLiveCamera.Image = foundFaceRect;
            }
            //if model trained then we need to predict who is it
            if (modeltrained == true)
            {
                Guess(capturedImage);
            }
        }

        private void Guess(Image<Bgr, byte> capturedImage)
        {
            //we need the gray scale image so we apply convert to gray
            Image<Gray, byte> grayImage = capturedImage.Copy().Convert<Gray, byte>();
            //detects every face in an image
            var faces = classifier.DetectMultiScale(
                grayImage,
                1.3,
                5,
                new Size(64, 64),
                Size.Empty);
            //for every rectangle that we found from classifier.DetectMultiScale we need to make a guess
            foreach (var rect in faces)
            {
                PredictionResult result;
                try
                {
                    result = faceRecognizer.Predict(grayImage.Copy(rect));
                }
                catch
                {
                    //if any exception happens we dont want to use this so we give it a -1 label
                    result.Label = -1;
                }
                if (result.Label >= 0)
                {
                    //draw the face rectangle
                    capturedImage.Draw(rect, new Bgr(Color.OrangeRed), 3);
                    //draw the filled rectangle under the face rectangle
                    capturedImage.Draw(new Rectangle(new Point(rect.X, rect.Y + rect.Height), new Size(rect.Width - 2, 20)), new Bgr(Color.OrangeRed), 20);
                    //draw prediction result over filled rectangle
                    capturedImage.Draw(listOfFileNames[result.Label], ref mCvFont, new Point(rect.X + 4, rect.Y + rect.Height + 15), new Bgr(Color.White));
                }
                else
                {
                    capturedImage.Draw(rect, new Bgr(Color.Red), 3);
                    //draw the filled rectangle under the face rectangle
                    capturedImage.Draw(new Rectangle(new Point(rect.X, rect.Y + rect.Height), new Size(rect.Width - 2, 20)), new Bgr(Color.Red), 20);
                    capturedImage.Draw("Unknown", ref mCvFont, new Point(rect.X + 4, rect.Y + rect.Height + 15), new Bgr(Color.White));
                }
            }
            imageBLiveCamera.Image = capturedImage;
        }

        private Tuple<Image<Bgr, byte>, Image<Gray, byte>> DetectedFace(Image<Bgr, byte> _image)
        {
            if (_image == null)
                return null;

            //convert image to gray scale
            Image<Gray, byte> grayImage = _image.Convert<Gray, byte>();
            Image<Gray, byte> face = null;
            //detect faces 
            var faces = classifier.DetectMultiScale(
                grayImage,
                1.3,
                5,
                new Size(64, 64),
                Size.Empty
                );
            //draw rectangles for every face
            foreach (var rect in faces)
            {
                _image.Draw(rect, new Bgr(Color.Green), 2);

                canCapture = true;
                face = grayImage.Copy(rect);
            }
            //return rectabgled image and gray scaled face image
            return new Tuple<Image<Bgr, byte>, Image<Gray, byte>>(_image, face);
        }

        private void frmfacerec_Load(object sender, EventArgs e)
        {
            #region AppIdle Event 30FPS
            //Stopwatch stopwatch = new Stopwatch();
            //int fps = 0;
            //stopwatch.Start();
            //Application.Idle += new EventHandler(delegate (object senderObj, EventArgs ea)
            //{
            //    fps++;
            //    if (stopwatch.ElapsedMilliseconds >= 1000)
            //    {
            //        label1.Text ="FPS: "+ fps.ToString();
            //        fps = 0;
            //        stopwatch.Restart();
            //    }
            //    capturedImage = capture.QueryFrame();


            //    imageBLiveCamera.Image = DetecetFace(capturedImage);

            //});
            #endregion
        }

        private void btnTrain_Click(object sender, EventArgs e)
        {
            //select a training folder with faces
            DialogResult dialogResult = folderBrowserTraininImages.ShowDialog();
            //list of faces
            List<Image<Gray, byte>> faceImagesList = new List<Image<Gray, byte>>();
            //list of labels
            List<int> labels = new List<int>();
            if (dialogResult == DialogResult.OK)
            {
                //i is the index of the person if we are training with same person so we dont need to increase i
                //so we need another index storage variable
                int i = 0, lastPersonindex = 0;
                //get every file from specified directory if you want to select from folderBrowser
                //folderBrowserTraininImages.SelectedPath add this code inside of GetFiles()
                foreach (string file in Directory.GetFiles(Application.StartupPath + "\\training\\"))
                {
                    Image<Gray, byte> faceImage = new Image<Gray, byte>(file);
                    faceImagesList.Add(faceImage);

                    string name = Path.GetFileName(file).Split('.')[0];
                    name = name.Substring(0, name.Length - 3);

                    if (listOfFileNames.Contains(name) == false)
                    {
                        lastPersonindex = i;
                        labels.Add(i++);
                        listOfFileNames.Add(name);
                    }
                    else
                        labels.Add(lastPersonindex);
                }
                faceRecognizer.Train(faceImagesList.ToArray(), labels.ToArray());
                gruopTrained.Enabled = modeltrained = true;
                listBox1.Items.AddRange(listOfFileNames.ToArray());
            }
        }

        private void chcBautoCapture_CheckedChanged(object sender, EventArgs e)
        {
            autoCapture = grpbAutoCapture.Visible = chcBautoCapture.Checked;
            btnCapture.Enabled = !chcBautoCapture.Checked;

        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            if (txtpersonname.Text == string.Empty)
            {
                MessageBox.Show("there should be a person name");
                return;
            }
            
            Image<Bgr, byte> foundFace = DetectedFace(capturedImage.Clone()).Item1;
            if (canCapture)
            {
                info = "Image Captured";
                foreColor = Color.Green;
                SaveImage(capturedImage,
                txtpersonname.Text + random.Next(0, 9).ToString() + random.Next(0, 9).ToString() + random.Next(0, 9).ToString());
            }
            else
            {

                info = "Image could not captured";
                foreColor = Color.Red;
            }

            lblCapturingInfo.Text = info;
            lblCapturingInfo.ForeColor = foreColor;
        }

        void SaveImage(IImage _image, string name = "", string path = "training\\")
        {
            _image.Save(path + name + ".png");
        }

        void radioButtonTrainedInfo_Checked(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Text == "true")
                modeltrained = true;
        }
    }
}
