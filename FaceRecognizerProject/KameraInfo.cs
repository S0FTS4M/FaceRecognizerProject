using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceRecognizerProject
{
   public enum CameraType {WEB_CAM , INDEXED , IP_CAMERA }
  public  class CameraInfo
    {

        public string IP;
        public string UserName;
        public string Password;
        public int camIndex;
        public CameraType CameraType;

        
       
    }
}
