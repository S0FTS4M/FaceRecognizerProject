using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.UI;

namespace FaceRecognizerProject
{
    public enum ControlType { Button, PictureBox, ImageBox, Panel, GroupBox }

    /// <summary>
    /// Implement Cell Logic so I can handle things easily 
    /// TURKISH INFO
    /// Örnek: Hücreye belli atamalar yaptığımda bunları ana formda tutmama gerek kalmayacak
    /// formda üzerinde işlem yapılan cell tüm gerekli bilgileri tutacak
    /// </summary>
    public class Cell
    {
        Control control;
        int cellWidth;
        int cellHeight;

    }
    public partial class Grid : UserControl
    {
        //there will be a m by n grid so we will have a m and n from user
        int cellCount = 0;
        int maxC = 3, maxR = 3;
        int r, c;
        int maxControlWidth, maxControlHeight;
        List<Control> controlsList;
        public List<Control> ControlsList { get => controlsList; protected set => controlsList = value; }
        ControlType controlType;

        public Grid()
        {
            InitializeComponent();
            controlsList = new List<Control>();

        }
        public Grid(int control_count, ControlType _controlType)
        {
            controlsList = new List<Control>();
            int row = control_count / maxR;
            if (row > 0)
            {

                CreateGrid(row + 1, maxC, _controlType);
            }
            else
            {
                CreateGrid(1, control_count, _controlType);
            }
            controlType = _controlType;

        }
        /// <summary>
        /// creates a 3x3 grid 
        /// </summary>
        /// <param name="_controlType"></param>
        public Grid(ControlType _controlType)
        {
            InitializeComponent();
            controlsList = new List<Control>();
            controlType = _controlType;
        }
        /// <summary>
        /// creates rxc grid
        /// </summary>
        /// <param name="_r"> max r is 3</param>
        /// <param name="_c">max c is 3</param>
        /// <param name="_controlType">Type of the control</param>
        public Grid(int _r, int _c, ControlType _controlType)
        {
            InitializeComponent();
            controlsList = new List<Control>();
            CreateGrid(_r, _c, _controlType);
            controlType = _controlType;
        }
        void CreateGrid(int _r, int _c, ControlType controlType)
        {

            if (_r <= maxR && _c <= maxC)
            {
                r = _r;
                c = _c;
            }
            else
            {
                c = maxC;
                r = maxR;
                MessageBox.Show("You can not add this many cells to grid. This is a " + r + " by " + c + "grid.");
            }

            maxControlWidth = Width / c;
            maxControlHeight = Height / r;
            bool newControl = false;
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    newControl = false;
                    if (j + c * i + 1 >= ControlsList.Count || controlsList[j + c * i] == null)
                    {
                        CreateControlForGrid(controlType);
                        newControl = true;
                    }
                    Control control = controlsList[j + c * i];
                    control.Width = maxControlWidth;
                    control.Height = maxControlHeight;
                    control.Location = new Point(j * control.Width, i * control.Height);
                    if (newControl)
                    {
                        control.Name = controlType.ToString() + (j + c * i);
                        Controls.Add(control);
                    }
                }
            }
        }

        private void CreateControlForGrid(ControlType controlType)
        {
            Control control = null;
            switch (controlType)
            {
                case ControlType.Button:
                    control = new Button();

                    break;
                case ControlType.PictureBox:
                    control = new PictureBox();
                    break;
                case ControlType.ImageBox:
                    control = new ImageBox();
                    (control as ImageBox).SizeMode = PictureBoxSizeMode.Zoom;
                    (control as ImageBox).FunctionalMode = ImageBox.FunctionalModeOption.Minimum;
                    (control as ImageBox).Image = new Image<Bgr, Byte>("camWithImage\\nolivecam.png");
                    (control as ImageBox).Tag = "0";
                    break;
                case ControlType.Panel:
                    control = new Panel();
                    break;
                case ControlType.GroupBox:
                    control = new GroupBox();
                    break;
                default:
                    break;
            }
            cellCount++;
            controlsList.Add(control);
        }

        //public void AddCell()
        //{

        //    //CreateControlForGrid(controlType);
        //    //cellCount++;
        //    //AdjustCells();

        //}
        public void AdjustCells(int newControlCount)
        {
            int sumControl = controlsList.Count + newControlCount;
            int row =  sumControl / maxR;

            if (row > 0)
            {

                CreateGrid(row + 1, sumControl % maxR == 0? maxC : sumControl % maxR, controlType);
            }
            else
            {
                CreateGrid(1, controlsList.Count + newControlCount, controlType);
            }


        }

    }
}
