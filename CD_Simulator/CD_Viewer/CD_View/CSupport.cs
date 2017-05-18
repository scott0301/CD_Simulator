using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

using CFigure;

namespace CD_View
{
    public static class CSupport
    {
        public static string SelectSaveFile(string strDefaultPath)
        {
            System.Windows.Forms.SaveFileDialog dlg = new System.Windows.Forms.SaveFileDialog();
            dlg.Filter = "Bmp files (*.bmp)|*.*";

            dlg.InitialDirectory = strDefaultPath;

            if (dlg.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return string.Empty;

            string strPath = dlg.FileName.ToUpper();

            if (strPath.Contains(".BMP") == false)
            {
                strPath += ".BMP";
            }
            return strPath;
        }
       
    }
    
}
