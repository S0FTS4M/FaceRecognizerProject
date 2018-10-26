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
        //gets camera stream as images
        Capture capture;
        //The original image we read from cam
        Image<Bgr, byte> capturedImage = null;
        //Recognizer Algorithm
        FaceRecognizer faceRecognizer = new LBPHFaceRecognizer(1, 8, 8, 8, 100.0);
        //The text font that we write the person name
        MCvFont mCvFont = new MCvFont(FONT.CV_FONT_HERSHEY_TRIPLEX, 1.0, 1.0);
        //if you dont want to try catching everytime your face detected you an enable auto capture
        bool autoCapture = false;
        //there will be a limit of time that you  can auto capture otherwise you will have a large amount of same face
        long elapsedTimeforAutoCapture = 0;
        //all settings are ready for capturing face? like does this person have a name
        private bool canCapture = false;


        Random random = new Random();
        //FPS Counter
        Stopwatch stopwatch = new Stopwatch();
        int fps = 0;


        Color foreColor;
        string info = "";

        List<string> listOfFileNames = new List<string>();
        bool modeltrained = false;
        public frmfacerec()
        {
            InitializeComponent();
            capture = new Capture();
            timerCameraFramer.Start();
            stopwatch.Start();
        }

        private void timerCameraFramer_Tick(object sender, EventArgs e)
        {
            canCapture = false;
            fps++;
            if (stopwatch.ElapsedMilliseconds >= 1000)
            {
                elapsedTimeforAutoCapture += stopwatch.ElapsedMilliseconds;
                label1.Text = "FPS: " + fps.ToString();
                fps = 0;
                stopwatch.Restart();
            }
            capturedImage = capture.QueryFrame();
            if (modeltrained == false)
            {
                Tuple<Image<Bgr, byte>, Image<Gray, byte>> faceRectandGrayFace = DetecetFace(capturedImage.Clone());
                Image<Bgr, byte> foundFaceRect = faceRectandGrayFace.Item1;
                Image<Gray, byte> foundFace = faceRectandGrayFace.Item2;


                info = "";
                if (autoCapture && txtpersonname.Text != string.Empty)
                {
                    if (elapsedTimeforAutoCapture >= numupdautocapturems.Value)
                    {

                        //save captured image
                        if (canCapture)
                        {

                            SaveImage(foundFace, txtpersonname.Text + random.Next(0, 9).ToString() + random.Next(0, 9).ToString() + random.Next(0, 9).ToString());
                            elapsedTimeforAutoCapture = 0;
                            info = "Image Captured";
                            foreColor = Color.Green;
                            //make white all the pixels for flash light :D

                        }
                        else
                        {
                            elapsedTimeforAutoCapture -= 100;
                            info = "Image could not captured";
                            foreColor = Color.Red;
                        }

                    }
                }
                else if (canCapture && txtpersonname.Text == string.Empty)
                {
                    elapsedTimeforAutoCapture -= 100;
                    info = "Image could not captured";
                    foreColor = Color.Red;
                }
                lblCapturingInfo.Text = info;
                lblCapturingInfo.ForeColor = foreColor;

                imageBLiveCamera.Image = foundFaceRect;
            }
            //if model trained then we need to guess
            if (modeltrained == true)
            {
                Guess(capturedImage);
            }
        }

        private void Guess(Image<Bgr, byte> capturedImage)
        {
            Image<Gray, byte> grayImage = capturedImage.Copy().Convert<Gray, byte>();
            var faces = classifier.DetectMultiScale(
                grayImage,
                1.3,
                5,
                new Size(64, 64),
                Size.Empty);
            foreach (var rect in faces)
            {
                PredictionResult result;
                try
                {
                    result = faceRecognizer.Predict(grayImage.Copy(rect));
                }
                catch
                {
                    result.Label = -1;
                }
                if (result.Label >= 0)
                {
                    capturedImage.Draw(rect, new Bgr(Color.OrangeRed), 3);

                    capturedImage.Draw(new Rectangle(new Point(rect.X, rect.Y + rect.Height), new Size(rect.Width - 2, 20)), new Bgr(Color.OrangeRed), 20);
                    capturedImage.Draw(listOfFileNames[result.Label], ref mCvFont, new Point(rect.X + 4, rect.Y + rect.Height + 15), new Bgr(Color.White));
                }
                else
                {
                    capturedImage.Draw(rect, new Bgr(Color.Red), 4);
                    capturedImage.Draw("Unknown", ref mCvFont, new Point(rect.X - 2, rect.Y - 2), new Bgr(Color.White));
                }
            }
            imageBLiveCamera.Image = capturedImage;
        }

        private Tuple<Image<Bgr, byte>, Image<Gray, byte>> DetecetFace(Image<Bgr, byte> _image)
        {
            if (_image == null)
                return null;

            Image<Gray, byte> grayImage = _image.Convert<Gray, byte>();
            Image<Gray, byte> face = null;
            var faces = classifier.DetectMultiScale(
                grayImage,
                1.3,
                5,
                new Size(64, 64),
                Size.Empty
                );
            foreach (var rect in faces)
            {
                _image.Draw(rect, new Bgr(Color.Green), 2);

                canCapture = true;
                face = grayImage.Copy(rect);
            }

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
            DialogResult dialogResult = folderBrowserTraininImages.ShowDialog();
            List<Image<Gray, byte>> images = new List<Image<Gray, byte>>();
            List<int> labels = new List<int>();
            if (dialogResult == DialogResult.OK)
            {
                int i = 0, lastPersonindex = 0;
                foreach (string file in Directory.GetFiles(Application.StartupPath + "\\training\\"))
                {
                    Image<Gray, byte> faceImage = new Image<Gray, byte>(file);
                    images.Add(faceImage);

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
                faceRecognizer.Train(images.ToArray(), labels.ToArray());
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
            
            Image<Bgr, byte> foundFace = DetecetFace(capturedImage.Clone()).Item1;
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
