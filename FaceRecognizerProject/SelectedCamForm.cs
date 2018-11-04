using AForge.Video;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaceRecognizerProject
{
    public partial class SelectedCamForm : Form
    {
        public SelectedCamForm()
        {
            InitializeComponent();
        }
        Cell cell;
        Action<Image<Bgr, byte>, ImageBox, CascadeClassifier> DetectShowGuess=null;
        public SelectedCamForm(Cell _cell, MJPEGStream mJPEGStream, Action<Image<Bgr, byte>, ImageBox, CascadeClassifier> _DetectShowGuess)
        {
            InitializeComponent();
            DetectShowGuess = _DetectShowGuess;
            cell = _cell;
            grid1.AdjustCells(1);
            mJPEGStream.NewFrame += newFrameEventHandler;
            mJPEGStream.Start();
        }

        private void newFrameEventHandler(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();

            //if there is no rotation dont need to call rotate method
            if (cell.RotateType != RotateFlipType.RotateNoneFlipNone)
                bitmap.RotateFlip(cell.RotateType);

            ImageBox _imageBox = (ImageBox)cell.Control;
            //create image from bitmap
            Image<Bgr, byte> capImage = new Image<Bgr, byte>(bitmap);
            //get classifier
            CascadeClassifier cascadeClassifier = cell.CascadeClassifier;

            DetectShowGuess(capImage, _imageBox, cascadeClassifier);


        }
    }
}
