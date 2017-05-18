using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.IO;

using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

using CFigure;
using ParameterSetting;
using CD_View;

namespace CD_Simulator
{
    public static class Support
    {
        public static string TIME_GetTimeCode_MD_HMS_MS()
        {
            string strTime = string.Format("[{0:00}{1:00}_{2:00}:{3:00}:{4:00}_{5:00}]", DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second, DateTime.Now.Millisecond);
            return strTime;
        }

        public static void PATH_MakeSureExistance(string strPath)
        {
            if (Directory.Exists(strPath)) return;
            Directory.CreateDirectory(strPath);
        }
       
    }
}
