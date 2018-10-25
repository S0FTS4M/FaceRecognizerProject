using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.Diagnostics;
using System.IO;
using System.Drawing.Imaging;
using System.Threading;
using static Emgu.CV.FaceRecognizer;

namespace FaceRecognizerProject
{
    public partial class frmfacerec : Form
    {
        //Capture will access the camera and reads the stream
        private static CascadeClassifier classifier = new CascadeClassifier(@"haarcascade_frontalface_alt_tree.xml");
        Capture capture;
        Image<Bgr, byte> capturedImage = null;
        FaceRecognizer faceRecognizer = new EigenFaceRecognizer(80, double.PositiveInfinity);
        MCvFont mCvFont = new MCvFont(FONT.CV_FONT_HERSHEY_TRIPLEX, 1.0, 1.0);

        bool autoCapture = false;
        long elapsedTimeforAutoCapture = 0;
        private bool canCapture = false;


        Random random = new Random();
        //FPS Counter
        Stopwatch stopwatch = new Stopwatch();
        int fps = 0;

        
        Color foreColor;
        string info = "";

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
                Image<Bgr, byte> foundFace = DetecetFace(capturedImage.Clone());
                info = "";
                if (autoCapture && txtpersonname.Text != string.Empty)
                {
                    if (elapsedTimeforAutoCapture >= numupdautocapturems.Value)
                    {

                        //save captured image
                        if (canCapture)
                        {

                            SaveImage(capturedImage, txtpersonname.Text + random.Next(0, 9).ToString() + random.Next(0, 9).ToString() + random.Next(0, 9).ToString());
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
                lblCapturingInfo.Text = info;
                lblCapturingInfo.ForeColor = foreColor;

                imageBLiveCamera.Image = foundFace;
            }
            //if model trained then we need to guess
            if(modeltrained == true)
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
               if(result.Label>=0)
                {
                    capturedImage.Draw(rect, new Bgr(Color.Green), 2);
                    capturedImage.Draw(result.Label.ToString(), ref mCvFont,new Point(rect.X - 2, rect.Y - 2),new Bgr(Color.Green));
                }
               else
                {
                    capturedImage.Draw(rect, new Bgr(Color.Red), 4);
                    capturedImage.Draw("Unknown", ref mCvFont, new Point(rect.X - 2, rect.Y - 2), new Bgr(Color.White));
                }
            }
            imageBLiveCamera.Image = capturedImage;
        }

        Image<Bgr, byte> DetecetFace(Image<Bgr, byte> _image)
        {
            if (_image == null)
                return null;

            Image<Gray, byte> grayImage = _image.Convert<Gray, byte>();

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
            }



            return _image;
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
                int i = 0;
                foreach (var file in Directory.GetFiles(folderBrowserTraininImages.SelectedPath))
                {
                    Image<Bgr, byte> faceImage = DetecetFace(new Image<Bgr, byte>(file));

                    Image<Gray, byte> face = faceImage.Copy(faceImage.ROI).Convert<Gray, byte>();
                    face._EqualizeHist();
                    images.Add(face);
                    labels.Add(i++);
                }
                faceRecognizer.Train(images.ToArray(), labels.ToArray());
                gruopTrained.Enabled = modeltrained = true;
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
          
           
            Image<Bgr, byte> foundFace = DetecetFace(capturedImage.Clone());
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

        void SaveImage(Image<Bgr, byte> _image, string name = "", string path = "training\\")
        {
            _image.Save(path + name + ".png");
        }

        void radioButtonTrainedInfo_Checked(object sender,EventArgs e)
        {
            if (((RadioButton)sender).Text == "true")
                modeltrained = true;
        }
    }
}
