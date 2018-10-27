using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV.UI;

namespace FaceRecognizerProject
{
    public enum ControlTyte {Button,PictureBox,ImageBox,Panel,GroupBox }
    public partial class Grid : UserControl
    {
        //there will be a m by n grid so we will have a m and n from user
        int maxM=5, maxN=5;
        int n, m;
        int maxControlWidth, maxControlHeight;
        List<Control> controlsList;
        public List<Control> ControlsList { get => controlsList;protected set => controlsList = value; }

        public Grid()
        {
            InitializeComponent();
            controlsList = new List<Control>();
        }
        public Grid(int _n,int _m,ControlTyte controlTyte)
        {
            InitializeComponent();
            controlsList = new List<Control>();

            if (_n<=maxN && _m<=maxM)
            {
                n = _n;
                m = _m;
            }
            else
            {
                m = maxM;
                n = maxN;
                MessageBox.Show("You can not add this many cells to grid. This is a " + n + " by "+ m + "grid.");
            }
            maxControlWidth = Width / m;
            maxControlHeight = Height / n;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    CreateControls(controlTyte);
                    Control control = controlsList[j + m * i];
                    control.Width = maxControlWidth;
                    control.Height = maxControlHeight;
                    control.Location = new Point(j * control.Width, i * control.Height) ;
                    control.Name = controlTyte.ToString() + (j + m * i);
                    Controls.Add(control);
                }
            }
        }

        
        private void CreateControls(ControlTyte controlTyte)
        {
            Control control=null;
            switch (controlTyte)
            {
                case ControlTyte.Button:
                    control = new Button();
                    
                    break;
                case ControlTyte.PictureBox:
                    control = new PictureBox();
                    break;
                case ControlTyte.ImageBox:
                    control = new ImageBox();
                    (control as ImageBox).SizeMode = PictureBoxSizeMode.Zoom;
                    (control as ImageBox).FunctionalMode = ImageBox.FunctionalModeOption.Minimum;
                    break;
                case ControlTyte.Panel:
                    control = new Panel();
                    break;
                case ControlTyte.GroupBox:
                    control = new GroupBox();
                    break;
                default:
                    break;
            }
            controlsList.Add(control);
        }
        
    }
}
