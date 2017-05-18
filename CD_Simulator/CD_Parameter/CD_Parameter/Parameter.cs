using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CFigure;

namespace ParameterSetting
{
    public partial class Parameter: UserControl
    {
        List<string> listMeasurement = new List<string>();

        public Parameter()
        {
            InitializeComponent();

            listMeasurement = IFX_MEASURE_TYPE.ToList();

        }

        public void SetParam_RC_PAIR_HOR(PROPERTY_PairHor single){property.SelectedObject = single;}
        public void SetParam_RC_PAIR_VER(PROPERTY_PairVer single){property.SelectedObject = single;}
        public void SetParam_RC_PAIR_DIG(PROPERTY_PairDig single){property.SelectedObject = single;}
        public void SetParam_Circle/***/(PROPERTY_PairCir single){property.SelectedObject = single;}
        public void SetParam_Overlay/**/(PROPERTY_PairOvl single) { property.SelectedObject = single; }

        private void property_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            PropertyGrid pg = (PropertyGrid)s;

            object objPrev = property.SelectedObject;
            object objCurr = pg.SelectedObjects[0];

            property.SelectedObject = objCurr;
          

        }
        public object GetCurrentData()
        {
            return property.SelectedObject;
        }

        public void ClearData()
        {
            property.SelectedObject = null;
        }

        
    }
}
