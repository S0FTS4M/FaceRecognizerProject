#define Eigen
#undef N
#define LBPH
#undef LBPH
#define Fisher
#undef Fisher
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
using Emgu.CV.UI;
using AForge.Video;
using System.Linq;

using AForge.Video.DirectShow;


namespace FaceRecognizerProject
{
    public partial class frmfacerec : Form
    {
        #region Variables
        string namesPath = "trained/listofNames.txt";
        string trainingFilePath = "trained/trainedData.xml";

        int fontOffsetY = 35, fontOffsetX = 4;

        string classifierPath = @"cascades/haarcascade_frontalface_alt.xml";

        Dictionary<MJPEGStream, Cell> mJpegStreamToCell;
        Cell webcamCell;

        List<CameraInfo> camInfos;
        

        double scaleFactor = 1.3;
        int minNeighbours = 5;
        Size minSize = new Size(64, 64);
        Size maxSize = new Size(256, 256);

        List<MJPEGStream> jPEGStreamList;
        //Capture will access the camera and reads the stream
        private static List<CascadeClassifier> classifiers;

        //Recognizer Algorithm
        //new LBPHFaceRecognizer(1, 8, 8, 8, 100.0);
        //new FisherFaceRecognizer(10, 10.0);
        FaceRecognizer faceRecognizer = null;

        //The text font that we write the person name
        MCvFont mCvFont = new MCvFont(FONT.CV_FONT_HERSHEY_TRIPLEX, 1.5, 1.5);

        ImageBox webcamImageBox;
        private static CascadeClassifier cascadeClassifierWebCam;
        //random numbers for file names
        Random random = new Random();

        //FPS Counter
        Stopwatch stopwatch = new Stopwatch();
        int fps = 0;

        /// <summary>
        /// Capture Vars
        /// </summary>
        //gets camera stream as images
        //there will be a capture list because we will have a list of cameras but for now we are not worried about this
        //we just need to access only 1 camera
        Capture capture;

        Image<Bgr, byte> capturedImageForSaving = null;
        //capturing info
        Color foreColor;
        string info = "";
        //if you dont want to try catching everytime your face detected you an enable auto capture
        bool autoCapture = false;
        //there will be a limit of time that you  can auto capture otherwise you will have a large amount of same face
        //long elapsedTimeforAutoCapture = 0;
        //all settings are ready for capturing face? like does this person have a name
        private bool canCapture = false;

        //bool ipCamActive = false;
        //bool isAnyCamActive = false;
        //if image comes with different rotation
        bool rotateActive = false;
        RotateFlipType rotateType = RotateFlipType.RotateNoneFlipNone;

        //training phase
        //TODO: Save these names with recognizer and load after
        List<string> listOfFileNames = new List<string>();
        bool modeltrained = false;

        Grid grid;
        #endregion
        //Properties
        public bool Modeltrained
        {
            get { return modeltrained; }
            set
            {
                gruopTrained.Enabled = value;
                modeltrained = value;
            }
        }

        public frmfacerec()
        {
            InitializeComponent();

            classifiers = new List<CascadeClassifier>();

            grid = new Grid(ControlType.ImageBox);
            Controls.Add(grid);

            mJpegStreamToCell = new Dictionary<MJPEGStream, Cell>();
            jPEGStreamList = new List<MJPEGStream>();

            ofdFaceDetTraining.InitialDirectory = Application.StartupPath;

            cmbRecognizer.SelectedIndex = 0;
            camInfos = new List<CameraInfo>();
        }
        private void timerCameraFramer_Tick(object sender, EventArgs e)
        {
            //The original image we read from cam
            Image<Bgr, byte> capturedImage = null;
            //reset canCapture every frame
            canCapture = false;
            ///FPS counter start
            fps++;
            if (stopwatch.ElapsedMilliseconds >= 1000)
            {
                //elapsedTimeforAutoCapture += stopwatch.ElapsedMilliseconds;
                label1.Text = "FPS: " + fps.ToString();
                fps = 0;
                stopwatch.Restart();
            }
            label3.Text = "Cell count in grid now:" + grid.CellList.Count.ToString();
            ///fps counter end

            capturedImage = capture.QueryFrame();
            capturedImageForSaving = capturedImage.Clone();
            if (webcamCell.RotateType != RotateFlipType.RotateNoneFlipNone)
            {
                Bitmap bmp = capturedImage.Bitmap;
                bmp.RotateFlip(webcamCell.RotateType);
                capturedImage = new Image<Bgr, byte>(bmp);
            }
            if (capturedImage == null || webcamImageBox == null)
                return;
            DetectGuessShow(capturedImage, webcamImageBox, cascadeClassifierWebCam);

        }
        public void DetectGuessShow(Image<Bgr, byte> _capturedImage, ImageBox imageBox, CascadeClassifier cascadeClassifier)
        {
            //if we didnt train the model we just can detect the face
            if (Modeltrained == false)
            {
                //get Detected face and detected face rectangle
                Tuple<Image<Bgr, byte>, Image<Gray, byte>> faceRectandGrayFace = DetectedFace(_capturedImage.Clone(), cascadeClassifier);
                Image<Bgr, byte> foundFaceRect = faceRectandGrayFace.Item1;
                Image<Gray, byte> foundFace = faceRectandGrayFace.Item2;

                //did we captured successfully or not
                info = "";
                if (autoCapture && txtpersonname.Text != string.Empty)
                {
                    //save captured image
                    if (canCapture && foundFace != null)
                    {
                        Image<Gray, byte> flippedImage = foundFace.Flip(FLIP.HORIZONTAL);

                        //save image with name and 3 other random numbers
                        List<Image<Gray, byte>> preProcessedImages = PreProcessingImages(foundFace, flippedImage);
                        foreach (Image<Gray, byte> currImage in preProcessedImages)
                        {
                            Image<Gray, byte> im = currImage.Resize(128, 128, INTER.CV_INTER_CUBIC);
                            SaveImage(im, txtpersonname.Text + random.Next(0, 9).ToString() + random.Next(0, 9).ToString() + random.Next(0, 9).ToString());
                        }


                        //reset elapsed time
                        // elapsedTimeforAutoCapture = 0;
                        //saving is successfull
                        info = "Image Captured";
                        foreColor = Color.Green;
                        //make white all the pixels for flash light :D

                    }
                    else
                    {
                        //if we are here we couldnt capture the image so we dont want to wait another X ms
                        //so we can go 100ms back
                        // elapsedTimeforAutoCapture -= 100;
                        //saving is failed
                        info = "Image could not captured";
                        foreColor = Color.Red;
                    }
                }
                //if we can capture but there is no person name we fail saving the faces
                else if (canCapture && txtpersonname.Text == string.Empty)
                {
                    // elapsedTimeforAutoCapture -= 100;
                    info = "Image could not captured";
                    foreColor = Color.Red;
                }
                ////show capturing info
                //lblCapturingInfo.Text = info;
                //lblCapturingInfo.ForeColor = foreColor;



                imageBox.Image = foundFaceRect;
            }
            //if model trained then we need to predict who is it
            if (Modeltrained == true)
            {
                Guess(_capturedImage, imageBox, cascadeClassifier);
            }
        }
        private List<Image<Gray, byte>> PreProcessingImages(params Image<Gray, byte>[] _images)
        {
            List<Image<Gray, byte>> preProccessedImages = new List<Image<Gray, byte>>();
            for (int i = 0; i < _images.Length; i++)
            {

                //try
                //{
                _images[i]._EqualizeHist();
                //}
                //catch
                //{
                //    MessageBox.Show("hata");
                //}

                //  _images[i] = _images[i].SmoothGaussian(3);
                _images[i] = _images[i].SmoothBilatral(9, 75, 75);
                preProccessedImages.Add(_images[i]);

            }
            return preProccessedImages;
        }
        private void Guess(Image<Bgr, byte> capturedImage, ImageBox imageBox, CascadeClassifier cascadeClassifier)
        {
            //we need the gray scale image so we apply convert to gray
            Image<Gray, byte> grayImage = capturedImage.Copy().Convert<Gray, byte>();

            //detects every face in an image
            var faces = cascadeClassifier.DetectMultiScale(
                grayImage,
                scaleFactor,
                minNeighbours,
                minSize,
                maxSize);
            //  lblCapturingInfo.Text = "undefind";
            //for every rectangle that we found from classifier.DetectMultiScale we need to make a guess
            foreach (var rect in faces)
            {

                PredictionResult result = new PredictionResult();
                try
                {
                    Image<Gray, byte> currentPreProccessedFace = PreProcessingImages(grayImage.Copy(rect))[0];
                    currentPreProccessedFace = currentPreProccessedFace.Resize(128, 128, INTER.CV_INTER_CUBIC);
                    result = faceRecognizer.Predict(currentPreProccessedFace);

                }
                catch
                {
                    //if any exception happens we dont want to use this so we give it a -1 label
                    result.Label = -1;
                }
                if (result.Label >= 0)
                {
                    // lblCapturingInfo.Text = listOfFileNames[result.Label];
                    //draw the face rectangle
                    capturedImage.Draw(rect, new Bgr(Color.Yellow), 3);
                    //draw the filled rectangle under the face rectangle
                    // capturedImage.Draw(new Rectangle(new Point(rect.X, rect.Y + rect.Height), new Size(rect.Width - 2, 20)), new Bgr(Color.Green), 20);
                    //draw prediction result over filled rectangle

                    capturedImage.Draw(listOfFileNames[result.Label], ref mCvFont, new Point(rect.X + fontOffsetX, rect.Y + rect.Height + fontOffsetY), new Bgr(Color.Yellow));
                }
                else
                {
                    capturedImage.Draw(rect, new Bgr(Color.Red), 3);
                    //draw the filled rectangle under the face rectangle
                    //capturedImage.Draw(new Rectangle(new Point(rect.X, rect.Y + rect.Height), new Size(rect.Width - 2, 20)), new Bgr(Color.Red), 20);
                    capturedImage.Draw("Unknown", ref mCvFont, new Point(rect.X + fontOffsetX, rect.Y + rect.Height + fontOffsetY), new Bgr(Color.Red));
                }
            }

            imageBox.Image = capturedImage;

        }
        private Tuple<Image<Bgr, byte>, Image<Gray, byte>> DetectedFace(Image<Bgr, byte> _image, CascadeClassifier cascadeClassifier)
        {
            if (_image == null)
                return null;

            //convert image to gray scale
            Image<Gray, byte> grayImage = _image.Convert<Gray, byte>();
            Image<Gray, byte> face = null;
            //grayImage = PreProcessingImages(grayImage)[0];
            //detect faces 
            var faces = cascadeClassifier.DetectMultiScale(
                grayImage,
                scaleFactor,
                minNeighbours,
                minSize,
                maxSize
                );
            //draw rectangles for every face
            foreach (var rect in faces)
            {
                _image.Draw(rect, new Bgr(Color.Green), 3);

                canCapture = true;
                face = grayImage.Copy(rect);
            }
            //return rectabgled image and gray scaled face image
            return new Tuple<Image<Bgr, byte>, Image<Gray, byte>>(_image, face);
        }
        private void frmfacerec_Load(object sender, EventArgs e)
        {
        }
        private void btnTrain_Click(object sender, EventArgs e)
        {
            //select a training folder with faces
            DialogResult dialogResult = folderBrowserTraininImages.ShowDialog();
            //list of faces
            List<Image<Gray, byte>> faceImagesList = new List<Image<Gray, byte>>();
            //list of labels
            List<int> labels = new List<int>();
            StreamWriter streamWriter = new StreamWriter(namesPath);
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
                        streamWriter.WriteLine(name);

                    }
                    else
                        labels.Add(lastPersonindex);
                }
                faceRecognizer.Train(faceImagesList.ToArray(), labels.ToArray());
                Modeltrained = true;

                faceRecognizer.Save(trainingFilePath);
                streamWriter.Close();

            }
        }
        private void BtnLoad_Click(object sender, System.EventArgs e)
        {
            if (faceRecognizer == null)
            {
                MessageBox.Show("FaceRecognizer is null???");
                return;
            }
            if (File.Exists(trainingFilePath))
            {
                Modeltrained = true;
                faceRecognizer.Load(trainingFilePath);
                StreamReader streamReader = new StreamReader(namesPath);
                while (!streamReader.EndOfStream)
                {
                    listOfFileNames.Add(streamReader.ReadLine());
                }
                streamReader.Close();
            }
            else
                MessageBox.Show("you didnt train the model. Press train button!");


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
            Image<Bgr, byte> capturedImage = capturedImageForSaving;
            Image<Gray, byte> foundFace = DetectedFace(capturedImage.Clone(), cascadeClassifierWebCam).Item2;
            if (canCapture)
            {
                Image<Gray, byte> flippedImage = foundFace.Clone().Flip(FLIP.HORIZONTAL);

                info = "Image Captured";
                foreColor = Color.Green;
                //save image with name and 3 other random numbers
                List<Image<Gray, byte>> preProcessedImages = PreProcessingImages(foundFace, flippedImage);
                foreach (Image<Gray, byte> currImage in preProcessedImages)
                {
                    SaveImage(currImage, txtpersonname.Text + random.Next(0, 9).ToString() + random.Next(0, 9).ToString() + random.Next(0, 9).ToString());
                }
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
                Modeltrained = true;
            else Modeltrained = false;
        }
        private void tsmiwebcam_Click(object sender, EventArgs e)
        {
            cascadeClassifierWebCam = new CascadeClassifier(classifierPath);
            capture = new Capture(0);

            //initialize video capturers
            grid.AdjustCells(1);
            foreach (Cell cell in grid.CellList)
            {
                ImageBox box = cell.Control as ImageBox;
                if (cell.CellTaken == false)
                {
                    webcamImageBox = box;
                    webcamCell = cell;
                    break;
                }
            }

            camInfos.Add(new CameraInfo() { CameraType = CameraType.WEB_CAM });
            timerCameraFramer.Start();
            //for fps counting
            stopwatch.Start();


        }
        private void tsmiIndex_Click(object sender, EventArgs e)
        {
            CameraSelector cameraSelector = new CameraSelector(CameraType.INDEXED);
            cameraSelector.GetCamInfoEvent += CameraSelectorIndexed_GetCamInfoEvent;
            cameraSelector.ShowDialog();
        }
        private void CameraSelectorIndexed_GetCamInfoEvent(List<CameraInfo> camInfos)
        {
            //Create Capture object and give it the right info
            //we will get only one object here
            //there will be only one cam no need for grid

            capture = new Capture(camInfos[0].camIndex);
            timerCameraFramer.Start();

        }
        private void tsmiaddCamera_Click(object sender, EventArgs e)
        {
            CameraSelector cameraSelector = new CameraSelector(CameraType.IP_CAMERA);
            cameraSelector.GetCamInfoEvent += CameraSelectorIPCam_GetCamInfoEvent;
            cameraSelector.ShowDialog();
        }
        private void CameraSelectorIPCam_GetCamInfoEvent(List<CameraInfo> infoList)
        {
            camInfos.AddRange(infoList.ToArray());

            grid.AdjustCells(infoList.Count);

            for (int i = 0; i <= infoList.Count - 1; i++)
            {
                MJPEGStream jPEGStream = null;
                jPEGStream = new MJPEGStream(infoList[i].IP);
                jPEGStream.Login = infoList[i].UserName;
                jPEGStream.Password = infoList[i].Password;

                jPEGStream.Start();
                jPEGStreamList.Add(jPEGStream);
            }
            int jIndex = 0;
            for (int i = 0; i < camInfos.Count; i++)
            {
                if (camInfos[i].CameraType == CameraType.WEB_CAM || camInfos[i].CameraType == CameraType.INDEXED)
                    continue;
                if (grid.CellList[jIndex].CellTaken == false)
                {
                    if (mJpegStreamToCell.ContainsKey(jPEGStreamList[jIndex]) == false)
                    {
                        //create new classifier for this cell
                        grid.CellList[i].CascadeClassifier = new CascadeClassifier(classifierPath);
                        //add to the dictionary that takes a jpegstream and a cell that stream controls
                        mJpegStreamToCell.Add(jPEGStreamList[jIndex], grid.CellList[i]);
                        grid.CellList[i].MJPEGStream = jPEGStreamList[jIndex];
                        //create the frame that captures frames
                        jPEGStreamList[jIndex].NewFrame += JPEGStream_NewFrame;

                        //assign objects tag as 1 so we can know that we are using this cell
                        grid.CellList[i].CellTaken = true;
                    }
                }
                jIndex++;
            }
        }
        private void JPEGStream_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();

            //if there is no rotation dont need to call rotate method
            if (mJpegStreamToCell[((MJPEGStream)sender)].RotateType != RotateFlipType.RotateNoneFlipNone)
                bitmap.RotateFlip(mJpegStreamToCell[((MJPEGStream)sender)].RotateType);
            //get the control in the cell
            ImageBox _imageBox = (ImageBox)mJpegStreamToCell[((MJPEGStream)sender)].Control;
            //create image from bitmap
            Image<Bgr, byte> capImage = new Image<Bgr, byte>(bitmap);
            //get classifier
            CascadeClassifier cascadeClassifier = mJpegStreamToCell[(MJPEGStream)sender].CascadeClassifier;

            DetectGuessShow(capImage, _imageBox, cascadeClassifier);
        }
        private void frmfacerec_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (var stream in jPEGStreamList)
            {
                if (stream != null)
                    stream.Stop();
            }
        }

        private void cmbRecognizer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRecognizer.SelectedIndex == 0)
            {
                faceRecognizer = new EigenFaceRecognizer(123, double.PositiveInfinity);
            }
            else if (cmbRecognizer.SelectedIndex == 1)
            {
                faceRecognizer = new FisherFaceRecognizer(10, 10.0);
            }
            else if (cmbRecognizer.SelectedIndex == 2)
            {
                faceRecognizer = new LBPHFaceRecognizer(1, 8, 8, 8, 100.0);
            }
        }

        private void tsmitrainingFile_Click(object sender, EventArgs e)
        {
            string filePath = "";
            DialogResult dialogResult = ofdFaceDetTraining.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                filePath = ofdFaceDetTraining.SafeFileName;
                //classifier = new CascadeClassifier(@"cascades/" + filePath);
                classifierPath = @"cascades/" + filePath;
            }
            //we have changed the classifier so make sure every cam has same one
            ///we can make different classifiers for every cam later maybe???
            foreach (Cell cell in grid.CellList)
            {
                cell.CascadeClassifier = new CascadeClassifier(classifierPath);
            }
        }
    }
}
