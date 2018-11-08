using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaceRecognizerProject
{
    public partial class CameraSelector : Form
    {
        public delegate void GetInfoHandler(List<CameraInfo> infoList);
        public event GetInfoHandler GetCamInfoEvent;

        string ipConfigPath = "trained/ipconfig.txt";
        List<CameraInfo> cameraInfos;
        CameraType cameraType;
        public CameraSelector()
        {
            InitializeComponent();
            cameraInfos = new List<CameraInfo>();
           
        }
        //Moving the form
        Point downPoint = Point.Empty;
        private void Mouse_Down_Event(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                downPoint = e.Location;

            }
        }
        private void Mouse_Move_Event(object sender, MouseEventArgs e)
        {
            if (downPoint == Point.Empty)
            {
                return;
            }
            Point location = new Point(
                this.Left + e.X - downPoint.X,
                this.Top + e.Y - downPoint.Y);
            this.Location = location;
            Cursor.Current = Cursors.SizeAll;
        }
        private void Mouse_Up_Event(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                downPoint = Point.Empty;
                Cursor.Current = Cursors.Arrow;
            }
        }
        public CameraSelector(CameraType _cameraType)
        {
            cameraInfos = new List<CameraInfo>();
            cameraType = _cameraType;

            InitializeComponent();
            switch (_cameraType)
            {
                case CameraType.WEB_CAM:
                    MessageBox.Show("something is not right here");
                    break;
                case CameraType.INDEXED:
                    grpIpCam.Enabled = false;
                    break;
                case CameraType.IP_CAMERA:
                    GrpIndex.Enabled = false;
                    break;
                default:
                    break;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cameraInfos == null || cameraInfos.Count == 0)
            {
                MessageBox.Show("You should add at least one cam.");
                return;
            }
            CameraInfo cameraInfo = new CameraInfo();
            switch (cameraType)
            {
                case CameraType.WEB_CAM:
                    break;
                case CameraType.INDEXED:
                    cameraInfo.camIndex = (int)numupdownIndex.Value;
                    cameraInfo.CameraType = CameraType.INDEXED;
                    cameraInfos.Add(cameraInfo);
                    GetCamInfoEvent?.Invoke(cameraInfos);
                    break;
                case CameraType.IP_CAMERA:


                    GetCamInfoEvent?.Invoke(cameraInfos);
                    break;
                default:
                    break;
            }
            this.Hide();
        }

        private void btnIpCamAddList_Click(object sender, EventArgs e)
        {
            CameraInfo cameraInfo = new CameraInfo();
            cameraInfo.CameraType = CameraType.IP_CAMERA;
            string ipValue = "";
            if (chcbResActive.Checked)
                ipValue = txtIP.Text + cmbresolution.SelectedItem.ToString();
            else
                ipValue = txtIP.Text;

            cameraInfo.IP = ipValue;
            cameraInfo.UserName = txtUsername.Text;
            cameraInfo.Password = txtpwd.Text;

            cameraInfos.Add(cameraInfo);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //save all list of ip based cameras with all info
            StreamWriter streamWriter = new StreamWriter(ipConfigPath);
            streamWriter.WriteLine("IP;"+txtIP.Text);
            streamWriter.WriteLine("Res;"+cmbresolution.SelectedIndex);
            streamWriter.WriteLine("UserName;"+txtUsername.Text);
            streamWriter.WriteLine("Pwd;"+txtpwd.Text);
            streamWriter.Close();
        }
        //I will need a save file method that designs saving file..


        private void btnExampleIP_Click(object sender, EventArgs e)
        {
            StreamReader streamReader = new StreamReader(ipConfigPath);

            chcbResActive.Checked = true;
            while (!streamReader.EndOfStream)
            {
                string[] infos=streamReader.ReadLine().Split(';');
                if (infos[0] == "IP")
                    txtIP.Text = infos[1];
                else if (infos[0] == "UserName")
                    txtUsername.Text = infos[1];
                else if (infos[0] == "Res")
                    cmbresolution.SelectedIndex = int.Parse(infos[1]);
                else if (infos[0] == "Pwd")
                    txtpwd.Text = infos[1];

            }
            streamReader.Close();



            // "http://192.168.137.113:4747/mjpegfeed?";
           // txtUsername.Text = "softsam";
           // txtpwd.Text = "softsam";
           // chcbResActive.Checked = true;
        }

        private void chcshowHide_CheckedChanged(object sender, EventArgs e)
        {
            txtpwd.UseSystemPasswordChar = !chcshowHide.Checked;
        }

        private void CameraSelector_Load(object sender, EventArgs e)
        {
            cmbresolution.SelectedIndex = 1;

            //activate for testing purposes
            //btnExampleIP.PerformClick();
            //btnIpCamAddList.PerformClick();
            //btnAdd.PerformClick();
            //Close();
        }

        private void cmbresolution_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chcbResActive_CheckedChanged(object sender, EventArgs e)
        {
            cmbresolution.Visible = chcbResActive.Checked;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
