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

   
    public partial class Grid : UserControl
    {
        //there will be a m by n grid so we will have a m and n from user
        int cellCount = 0;
        int maxC = 3, maxR = 3;
        int r, c;
        int maxCellWidth, maxCellHeight;
        Control contextMenuOwnerControl=null;
        List<Cell> cellList;
        public List<Cell> CellList { get => cellList; protected set => cellList = value; }
        ControlType controlType;

        public Grid()
        {
            InitializeComponent();
            cellList = new List<Cell>();

        }
        public Grid(int control_count, ControlType _controlType)
        {
            cellList = new List<Cell>();
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
            cellList = new List<Cell>();
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
            cellList = new List<Cell>();
            CreateGrid(_r, _c, _controlType);
            controlType = _controlType;
        }

        private void menuItem_Click(object sender, EventArgs e)
        {
            // Try to cast the sender to a ToolStripItem
            ToolStripItem menuItem = sender as ToolStripItem;
            RotateFlipType rotateFlipType = RotateFlipType.RotateNoneFlipNone;
            if(menuItem.Text == "None")
                rotateFlipType = RotateFlipType.RotateNoneFlipNone;
            else if (menuItem.Text == "90 Deg")
                rotateFlipType = RotateFlipType.Rotate90FlipNone;
            else if (menuItem.Text == "180 Deg")
                rotateFlipType = RotateFlipType.Rotate180FlipNone;
            else if (menuItem.Text == "270 Deg")
                rotateFlipType = RotateFlipType.Rotate270FlipNone;
           
         
                if (contextMenuOwnerControl != null)
                {
                 
                    foreach (Cell cell in CellList)
                    {
                        if (contextMenuOwnerControl == cell.Control)
                            cell.RotateType = rotateFlipType;
                    }
                }
            
        }

        private void contextMSCell_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            contextMenuOwnerControl = contextMSCell.SourceControl;
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

            maxCellWidth = Width / c;
            maxCellHeight = Height / r;
            bool newCell = false;
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    newCell = false;
                    if (j + c * i + 1 > CellList.Count || cellList[j + c * i] == null)
                    {
                        CreateCellForGrid(controlType);
                        newCell = true;
                    }
                    Cell cell = cellList[j + c * i];
                    cell.CellWidth = maxCellWidth;
                    cell.CellHeight = maxCellHeight;
                    cell.Control.Location = new Point(j * cell.CellWidth, i * cell.CellHeight);
                    if (newCell)
                    {
                        cell.Control.Name = controlType.ToString() + (j + c * i);
                        Controls.Add(cell.Control);
                    }
                }
            }
        }

        private void CreateCellForGrid(ControlType controlType)
        {
            Cell cell = null;
            switch (controlType)
            {
                case ControlType.Button:
                    cell = new Cell(new Button(),ControlType.Button,contextMSCell);

                    break;
                case ControlType.PictureBox:
                    cell = new Cell(new PictureBox(), ControlType.PictureBox, contextMSCell) ;
                    break;
                case ControlType.ImageBox:
                    ImageBox imageBox = new ImageBox();
                    imageBox.SizeMode = PictureBoxSizeMode.Zoom;
                    imageBox.FunctionalMode = ImageBox.FunctionalModeOption.Minimum;
                    imageBox.Image = new Image<Bgr, Byte>("camWithImage\\nolivecam.png");
                    imageBox.Tag = "0";
                    cell = new Cell(imageBox, ControlType.ImageBox,contextMSCell);
                    break;
                case ControlType.Panel:
                    cell = new Cell(new Panel(), ControlType.Panel, contextMSCell);
                    break;
                case ControlType.GroupBox:
                    cell = new Cell(new GroupBox(),ControlType.GroupBox, contextMSCell);
                    break;
                default:
                    break;
            }
            cellCount++;
            cellList.Add(cell);
        }

        //public void AddCell()
        //{

        //    //CreateControlForGrid(controlType);
        //    //cellCount++;
        //    //AdjustCells();

        //}
        public void AdjustCells(int newControlCount)
        {
            int sumControl = cellList.Count + newControlCount;
            int row =  sumControl / maxR;

            if (row > 0)
            {

                CreateGrid(row + 1, sumControl % maxR == 0? maxC : sumControl % maxR, controlType);
            }
            else
            {
                CreateGrid(1, cellList.Count + newControlCount, controlType);
            }


        }

    }
}
