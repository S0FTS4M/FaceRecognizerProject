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
    public partial class CameraSelector : Form
    {
        public delegate void GetInfoHandler(List<CameraInfo> infoList);
        public event GetInfoHandler GetCamInfoEvent;

        List<CameraInfo> cameraInfos;
        CameraType cameraType;
        public CameraSelector()
        {
            InitializeComponent();
            cameraInfos = new List<CameraInfo>();
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
            if(cameraInfos==null || cameraInfos.Count==0)
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
            cameraInfo.IP = txtIP.Text;
            cameraInfo.UserName = txtUsername.Text;
            cameraInfo.Password = txtpwd.Text;

            cameraInfos.Add(cameraInfo);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //save all list of ip based cameras with all info
            MessageBox.Show("It is not available for Alpha");
        }

        private void btnExampleIP_Click(object sender, EventArgs e)
        {
            txtIP.Text = "http://192.168.1.100:4747/mjpegfeed?640x480";
        }
    }
}
