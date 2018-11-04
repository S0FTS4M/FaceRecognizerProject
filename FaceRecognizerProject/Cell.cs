using AForge.Video;
using Emgu.CV;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaceRecognizerProject
{
    public class Cell
    {
        Control control;
        int cellWidth;
        int cellHeight;
        bool cellTaken;
        RotateFlipType rotateType=RotateFlipType.RotateNoneFlipNone;
        ControlType controlType;
        CascadeClassifier cascadeClassifier;
        MJPEGStream mJPEGStream;
        public Cell(Control _control, ControlType _controlType,ContextMenuStrip contextMenuStrip)
        {
            Control = _control;
            control.ContextMenuStrip=contextMenuStrip;
            
            ControlType = _controlType;
           
        }

      

        public int CellWidth { get { return cellWidth; } set { cellWidth = value; Control.Width = value;  } }
        public int CellHeight { get { return cellHeight; } set { cellHeight = value;control.Height = value; } }

        public Control Control { get => control; set => control = value; }
        public RotateFlipType RotateType { get => rotateType; set => rotateType = value; }
        public ControlType ControlType { get => controlType; set => controlType = value; }
        public CascadeClassifier CascadeClassifier { get => cascadeClassifier; set => cascadeClassifier = value; }
        public bool CellTaken { get => cellTaken; set => cellTaken = value; }
        public MJPEGStream MJPEGStream { get => mJPEGStream; set => mJPEGStream = value; }
    }
}
