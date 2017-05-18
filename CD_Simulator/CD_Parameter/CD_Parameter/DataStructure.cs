using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Globalization;
using CFigure;

namespace ParameterSetting
{
    [TypeConverter(typeof(CustomPoinDConverter))]
    public class CustomPointD
    {
        public float X { get; set; }
        public float Y { get; set; }

        public CustomPointD(float x, float y)
        {
            this.X = x; this.Y = y;
        }
        public CustomPointD()
        {
            this.X = this.Y = 0;
        }
        public override string ToString()
        {
            return X.ToString() + " , " + Y.ToString();
        }
        public static CustomPointD parsePoint(string strPoint)
        {
            string[] parse = strPoint.Split(',');

            try
            {
                float x = Convert.ToSingle(parse[0]);
                float y = Convert.ToSingle(parse[1]);
                CustomPointD point = new CustomPointD(x, y);
                return point;
            }
            catch (FormatException)
            {
                return null;
            }
        }
        public void SetValue(PointF point)
        {
            this.X = point.X;
            this.Y = point.Y;
        }
        public PointF ToPointF()
        {
            PointF pt = new PointF(this.X, this.Y);
            return pt;
        }
    }

    [TypeConverter(typeof(CustomRectangleDConverter))]
    public class CustomRectangleD
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }

        public CustomRectangleD()
        {
            this.X = this.Y = this.Width = this.Height;
        }
        public CustomRectangleD(float x, float y, float width, float height)
        {
            this.X = x; this.Y = y; this.Width = width; this.Height = height;
        }
        public CustomRectangleD(RectangleF rc)
        {
            this.X = rc.X; this.Y = rc.Y; this.Width = rc.Width; this.Height = rc.Height;
        }
        public override string ToString()
        {
            return this.X.ToString() + " , " + this.Y.ToString() + " , " + this.Width.ToString() + " , " + this.Height.ToString();
        }
        public static CustomRectangleD parseRect(string strPoint)
        {
            string[] parse = strPoint.Split(',');

            try
            {
                float x = Convert.ToSingle(parse[0]);
                float y = Convert.ToSingle(parse[1]);
                float w = Convert.ToSingle(parse[2]);
                float h = Convert.ToSingle(parse[3]);
                CustomRectangleD rect = new CustomRectangleD(x, y, w, h);
                return rect;
            }
            catch (FormatException)
            {
                return null;
            }
        }
        public void SetValue(RectangleF rc)
        {
            this.X = rc.X; this.Y = rc.Y; this.Width = rc.Width; this.Height = rc.Height;
        }
        public RectangleF ToRectangleF()
        {
            RectangleF rect = new RectangleF(this.X, this.Y, this.Width, this.Height);
            return rect;
        }
        
    }

    public class PROPERTY_PairHor
    {
        private CustomPointD ptOrientBase = new CustomPointD();
        private CustomPointD ptOrientCurr = new CustomPointD();

        private CustomRectangleD rcTop = new CustomRectangleD();
        private CustomRectangleD rcBtm = new CustomRectangleD();

        private string measure_TOP;
        private string measure_BTM;

        [CategoryAttribute("00 Nick Name"), DescriptionAttribute("Figure Nick Name"), ReadOnly(true)]
        public string NICKNAME { get; set; }

        [CategoryAttribute("01 Teaching Orientation"), DescriptionAttribute("Point of orientation : Teaching"), ReadOnly(true)]
        public CustomPointD PT_ORIENT_BASE { get { return ptOrientBase; } }
        [CategoryAttribute("02 Matching Orientation"), DescriptionAttribute("Point of orientation : Matching"), ReadOnly(true)]
        public CustomPointD PT_ORIENT_CURR { get { return ptOrientCurr; } }

        [CategoryAttribute("03 TOP Region"), DescriptionAttribute("Region Croodinates"), ReadOnly(true)]
        public CustomRectangleD RC_TOP { get { return rcTop; } }
        [CategoryAttribute("04 BTN region"), DescriptionAttribute("Region Croodinates"), ReadOnly(true)]
        public CustomRectangleD RC_BTM { get { return rcBtm; } }

        [CategoryAttribute("05 Measure Method - TOP"), DescriptionAttribute("Measure Method For TOP Region")]

        [Browsable(true)]
        [TypeConverter(typeof(ConverterMeasureTyes))]
        public string MEASURE_TOP
        {
            get
            {
                string str = "";

                if (measure_TOP != null)
                {
                    str = measure_TOP;
                }
                else
                {
                    str = IFX_MEASURE_TYPE.ToStringType(0);
                }
                return str;
            }

            set { measure_TOP = value; }

        }

        [CategoryAttribute("06 Measure Method - BTM"), DescriptionAttribute("Measure Method For BTM Region")]
        [Browsable(true)]
        [TypeConverter(typeof(ConverterMeasureTyes))]
        public string MEASURE_BTM
        {
            get
            {
                string str = "";

                if (measure_BTM != null)
                {
                    str = measure_BTM;
                }
                else
                {
                    str = IFX_MEASURE_TYPE.ToStringType(0);
                }
                return str;
            }

            set { measure_BTM = value; }

        }

        [CategoryAttribute("07 Searching Direction "), DescriptionAttribute("Only For LoG Based Approach\nSets of Parameters : -1 or 1")]
        public double DIR_TOP { get; set; }

        [CategoryAttribute("08 Searching Direction"), DescriptionAttribute("Only For LoG Based Approach\nSets of Parameters : -1 or 1")]
        public double DIR_BTM { get; set; }

        [CategoryAttribute("09 Zerocrossing Magnification"), DescriptionAttribute("Only For ZeroCrossing Approach\n Set parameters : 0 ~ ∞")]
        public double ZC_MAG { get; set; }

        [CategoryAttribute("10 Show Raw Data"), DescriptionAttribute("True or False")]
        public bool SHOW_RAW_DATA { get; set; }

        public CMeasurePairHor ToFigure()
        {
            CMeasurePairHor single = new CMeasurePairHor();

            single.NICKNAME = NICKNAME;
            single.ptOrientBase = new PointF( ptOrientBase.X, ptOrientBase.Y);
            single.ptOrientCurr = new PointF(ptOrientCurr.X, ptOrientCurr.Y);

            single.measure_TOP = IFX_MEASURE_TYPE.ToNumericType(measure_TOP);
            single.measure_BTM = IFX_MEASURE_TYPE.ToNumericType(measure_BTM);

            single.rc_TOP = RC_TOP.ToRectangleF();
            single.rc_BTM = RC_BTM.ToRectangleF();

            single.DIR_TOP = Convert.ToInt32(DIR_TOP);
            single.DIR_BTM = Convert.ToInt32(DIR_BTM);
            single.ZC_MAG = Convert.ToInt32(ZC_MAG);

            single.SHOW_RAW_DATA = SHOW_RAW_DATA;

            return single;
        }
        public void FromFigure(CMeasurePairHor single)
        {
            this.NICKNAME = single.NICKNAME;
            this.ptOrientBase.SetValue(single.ptOrientBase);
            this.ptOrientCurr.SetValue(single.ptOrientCurr);
            this.RC_TOP.SetValue(single.rc_TOP);
            this.RC_BTM.SetValue(single.rc_BTM);
            this.measure_TOP = IFX_MEASURE_TYPE.ToStringType(single.measure_TOP);
            this.measure_BTM = IFX_MEASURE_TYPE.ToStringType(single.measure_BTM);
            this.DIR_TOP = single.DIR_TOP;
            this.DIR_BTM = single.DIR_BTM;
            this.ZC_MAG = single.ZC_MAG;
            this.SHOW_RAW_DATA = single.SHOW_RAW_DATA;
        }
    }
    public class PROPERTY_PairVer
    {
        private CustomPointD ptOrientBase = new CustomPointD();
        private CustomPointD ptOrientCurr = new CustomPointD();

        private CustomRectangleD rc_LFT = new CustomRectangleD();
        private CustomRectangleD rc_RHT = new CustomRectangleD();
        private string measure_LFT;
        private string measure_RHT;

        [CategoryAttribute("00 Nick Name"), DescriptionAttribute("Figure Nick Name"), ReadOnly(true)]
        public string NICKNAME { get; set; }

        [CategoryAttribute("01 Teaching Orientation"), DescriptionAttribute("Point of orientation : Teaching"), ReadOnly(true)]
        public CustomPointD PT_ORIENT_BASE { get { return ptOrientBase; } }

        [CategoryAttribute("02 Matching Orientation"), DescriptionAttribute("Point of orientation : Matching"), ReadOnly(true)]
        public CustomPointD PT_ORIENT_CURR { get { return ptOrientCurr; } }

        [CategoryAttribute("03 LFT Region"), DescriptionAttribute("Region Croodinates"), ReadOnly(true)]
        public CustomRectangleD RC_LFT
        {
            get { return rc_LFT; }
            set { rc_LFT = value; }
        }

        [CategoryAttribute("04 RHT Region"), DescriptionAttribute("Region Croodinates"), ReadOnly(true)]
        public CustomRectangleD RC_RHT
        {
            get { return rc_RHT; }
            set { rc_RHT = value; }
        }

        [CategoryAttribute("05 Measure Method - LFT"), DescriptionAttribute("Measure Method For LFT Region")]

        [Browsable(true)]
        [TypeConverter(typeof(ConverterMeasureTyes))]

        public string MEASURE_LFT
        {
            get
            {
                string str = "";

                if (measure_LFT != null)
                {
                    str = measure_LFT;
                }
                else
                {
                    str = IFX_MEASURE_TYPE.ToStringType(0);
                }
                return str;
            }

            set { measure_LFT = value; }

        }

        [CategoryAttribute("06 Measure Method - RHT"), DescriptionAttribute("Measure Method For RHT Region")]
        [Browsable(true)]
        [TypeConverter(typeof(ConverterMeasureTyes))]

        public string MEASURE_RHT
        {
            get
            {
                string str = "";

                if (measure_RHT != null)
                {
                    str = measure_RHT;
                }
                else
                {
                    str = IFX_MEASURE_TYPE.ToStringType(0);
                }
                return str;
            }

            set { measure_RHT = value; }

        }
        [CategoryAttribute("07 Searching Direction"), DescriptionAttribute("Only For LoG Based Approach\nSets of Parameters : -1 or 1")]
        public double DIR_LFT { get; set; }

        [CategoryAttribute("08 Searching Direction"), DescriptionAttribute("Only For LoG Based Approach\nSets of Parameters : -1 or 1")]
        public double DIR_RHT { get; set; }

        [CategoryAttribute("09 Zerocrossing Magnification"), DescriptionAttribute("Only For ZeroCrossing Approach\n Set parameters : 0 ~ ∞")]
        public double ZC_MAG { get; set; }

        [CategoryAttribute("10 Show Raw Data"), DescriptionAttribute("True or False")]
        public bool SHOW_RAW_DATA { get; set; }

        public CMeasurePairVer ToFigure()
        {
            CMeasurePairVer single = new CMeasurePairVer();

            single.NICKNAME = NICKNAME;
            single.ptOrientBase = ptOrientBase.ToPointF();
            single.ptOrientCurr = ptOrientCurr.ToPointF();

            single.measure_LFT = IFX_MEASURE_TYPE.ToNumericType(measure_LFT);
            single.measure_RHT = IFX_MEASURE_TYPE.ToNumericType(measure_RHT);

            single.rc_LFT = RC_LFT.ToRectangleF();
            single.rc_RHT = RC_RHT.ToRectangleF();

            single.DIR_LFT = Convert.ToInt32(DIR_LFT);
            single.DIR_RHT = Convert.ToInt32(DIR_RHT);
            single.ZC_MAG = Convert.ToInt32(ZC_MAG);

            single.SHOW_RAW_DATA = this.SHOW_RAW_DATA;

            return single;
        }
        public void FromFigure(CMeasurePairVer single)
        {
            this.NICKNAME = single.NICKNAME;
            this.ptOrientBase.SetValue(single.ptOrientBase);
            this.ptOrientCurr.SetValue(single.ptOrientCurr);
            this.rc_LFT.SetValue(single.rc_LFT);
            this.rc_RHT.SetValue(single.rc_RHT);
            this.measure_LFT = IFX_MEASURE_TYPE.ToStringType(single.measure_LFT);
            this.measure_RHT = IFX_MEASURE_TYPE.ToStringType(single.measure_RHT);
            this.DIR_LFT = single.DIR_LFT;
            this.DIR_RHT = single.DIR_RHT;
            this.ZC_MAG = single.ZC_MAG;
            this.SHOW_RAW_DATA = single.SHOW_RAW_DATA;
        }
    }
    public class PROPERTY_PairDig
    {
        private CustomPointD ptOrientBase = new CustomPointD();
        private CustomPointD ptOrientCurr = new CustomPointD();

        private string measure_FST;
        private string measure_SCD;

        private CustomPointD pt_FST_LT = new CustomPointD();
        private CustomPointD pt_FST_RT = new CustomPointD();
        private CustomPointD pt_FST_LB = new CustomPointD();
        private CustomPointD pt_FST_RB = new CustomPointD();

        private CustomPointD pt_SCD_LT = new CustomPointD();
        private CustomPointD pt_SCD_RT = new CustomPointD();
        private CustomPointD pt_SCD_LB = new CustomPointD();
        private CustomPointD pt_SCD_RB = new CustomPointD();

        [CategoryAttribute("00 Nick Name"), DescriptionAttribute("Figure Nick Name"), ReadOnly(true)]
        public string NICKNAME { get; set; }

        [CategoryAttribute("01 Teaching Orientation"), DescriptionAttribute("Point of orientation : Teaching"), ReadOnly(true)]
        public CustomPointD PT_ORIENT_BASE { get { return ptOrientBase; } }
        [CategoryAttribute("02 Matching Orientation"), DescriptionAttribute("Point of orientation : Matching"), ReadOnly(true)]
        public CustomPointD PT_ORIENT_CURR { get { return ptOrientCurr; } }

        [CategoryAttribute("03 Angle"), DescriptionAttribute("Angle of figures"), ReadOnly(true)]
        public float ANGLE { get; set; }

        [CategoryAttribute("04 First Region - Point LT"), DescriptionAttribute("Region Croodinates For Each Rectagle Points"), ReadOnly(true)]
        public CustomPointD PT_FST_LT { get { return pt_FST_LT; } set { pt_FST_LT = value; } }
        [CategoryAttribute("04 First Region - point RT"), DescriptionAttribute("Region Croodinates For Each Rectangle Points"), ReadOnly(true)]
        public CustomPointD PT_FST_RT { get { return pt_FST_RT; } set { pt_FST_RT = value; } }
        [CategoryAttribute("04 First Region - Point LB"), DescriptionAttribute("Region Croodinates For Each Rectangle Points"), ReadOnly(true)]
        public CustomPointD PT_FST_LB { get { return pt_FST_LB; } set { pt_FST_LB = value; } }
        [CategoryAttribute("04 First Region - Point RB"), DescriptionAttribute("Region Croodinates For Each Rectangle Points"), ReadOnly(true)]
        public CustomPointD PT_FST_RB { get { return pt_FST_RB; } set { pt_FST_RB = value; } }

        [CategoryAttribute("05 Second Region - Point LT"), DescriptionAttribute("Region Croodinates For Each Rectangle Points"), ReadOnly(true)]
        public CustomPointD PT_SCD_LT { get { return pt_SCD_LT; } set { pt_SCD_LT = value; } }
        [CategoryAttribute("05 Second Region - Point RT"), DescriptionAttribute("Region Croodinates For Each Rectangle Points"), ReadOnly(true)]
        public CustomPointD PT_SCD_RT { get { return pt_SCD_RT; } set { pt_SCD_RT = value; } }
        [CategoryAttribute("05 Second Region - Point LB"), DescriptionAttribute("Region Croodinates For Each Rectangle Points"), ReadOnly(true)]
        public CustomPointD PT_SCD_LB { get { return pt_SCD_LB; } set { pt_SCD_LB = value; } }
        [CategoryAttribute("05 Second Region - Point RB"), DescriptionAttribute("Region Croodinates For Each Rectangle Points"), ReadOnly(true)]
        public CustomPointD PT_SCD_RB { get { return pt_SCD_RB; } set { pt_SCD_RB = value; } }

        [CategoryAttribute("06 Measure Method - First"), DescriptionAttribute("Measure Method For First Region")]
        [Browsable(true)]
        [TypeConverter(typeof(ConverterMeasureTyes))]

        public string MEASURE_FST
        {
            get
            {
                string str = "";

                if (measure_FST != null)
                {
                    str = measure_FST;
                }
                else
                {
                    str = IFX_MEASURE_TYPE.ToStringType(0);
                }
                return str;
            }

            set { measure_FST = value; }

        }

        [CategoryAttribute("07 Measure Method - Second"), DescriptionAttribute("Measure Method For Second Region")]
        [Browsable(true)]
        [TypeConverter(typeof(ConverterMeasureTyes))]

        public string MEASURE_SCD
        {
            get
            {
                string str = "";

                if (measure_SCD != null)
                {
                    str = measure_SCD;
                }
                else
                {
                    str = IFX_MEASURE_TYPE.ToStringType(0);
                }
                return str;
            }

            set { measure_SCD = value; }

        }
        [CategoryAttribute("08 Searching Direction"), DescriptionAttribute("Only For LoG Based Approach\nSets of Parameters : -1 or 1")]
        public double DIR_FST { get; set; }
        [CategoryAttribute("09 Searching Direction"), DescriptionAttribute("Only For LoG Based Approach\nSets of Parameters : -1 or 1")]
        public double DIR_SCD { get; set; }
        [CategoryAttribute("10 ZeroCrossing Magnification"), DescriptionAttribute("Only For ZeroCrossing Approach\n Set parameters : 0 ~ ∞")]
        public double ZC_MAG { get; set; }

        [CategoryAttribute("11 Show Raw Data"), DescriptionAttribute("True or False")]
        public bool SHOW_RAW_DATA { get; set; }

        public CMeasurePairDig ToFigure()
        {
            CMeasurePairDig single = new CMeasurePairDig();

            single.NICKNAME = NICKNAME;
            single.ptOrientBase = new PointF(ptOrientBase.X, ptOrientBase.Y);
            single.ptOrientCurr = new PointF(ptOrientCurr.X, ptOrientCurr.Y);

            single.measure_FST = IFX_MEASURE_TYPE.ToNumericType(measure_FST);
            single.measure_SCD = IFX_MEASURE_TYPE.ToNumericType(measure_SCD);

            single.rc_FST.LT = new PointF(PT_FST_LT.X, PT_FST_LT.Y);
            single.rc_FST.RT = new PointF(pt_FST_RT.X, pt_FST_RT.Y);
            single.rc_FST.LB = new PointF(pt_FST_LB.X, pt_FST_LB.Y);
            single.rc_FST.RB = new PointF(PT_FST_RB.X, pt_FST_RB.Y);

            single.rc_SCD.LT = new PointF(PT_SCD_LT.X, PT_SCD_LT.Y);
            single.rc_SCD.RT = new PointF(pt_SCD_RT.X, pt_SCD_RT.Y);
            single.rc_SCD.LB = new PointF(pt_SCD_LB.X, pt_SCD_LB.Y);
            single.rc_SCD.RB = new PointF(pt_SCD_RB.X, pt_SCD_RB.Y);

            single.DIR_FST= Convert.ToInt32(DIR_FST);
            single.DIR_SCD= Convert.ToInt32(DIR_SCD);
            single.ZC_MAG = Convert.ToInt32(ZC_MAG);

            single.SHOW_RAW_DATA = this.SHOW_RAW_DATA;
            return single;
        }
        public void FromFigure(CMeasurePairDig single)
        {
            this.NICKNAME = single.NICKNAME;
            
            this.ptOrientBase.SetValue(single.ptOrientBase);
            this.ptOrientCurr.SetValue(single.ptOrientCurr);

            this.ANGLE = single.angle;

            this.pt_FST_LT.SetValue(single.rc_FST.LT);
            this.pt_FST_RT.SetValue(single.rc_FST.RT);
            this.pt_FST_LB.SetValue(single.rc_FST.LB);
            this.pt_FST_RB.SetValue(single.rc_FST.RB);

            this.pt_SCD_LT.SetValue(single.rc_SCD.LT);
            this.pt_SCD_LB.SetValue(single.rc_SCD.LB);
            this.pt_SCD_RT.SetValue(single.rc_SCD.RT);
            this.pt_SCD_RB.SetValue(single.rc_SCD.RB);

            this.MEASURE_FST = IFX_MEASURE_TYPE.ToStringType(single.measure_FST);
            this.MEASURE_SCD = IFX_MEASURE_TYPE.ToStringType(single.measure_SCD);

            this.DIR_FST = single.DIR_FST;
            this.DIR_SCD = single.DIR_SCD;
            this.ZC_MAG = single.ZC_MAG;
            this.SHOW_RAW_DATA = single.SHOW_RAW_DATA;
        }
    }

    public class PROPERTY_PairOvl
    {
        private CustomPointD ptOrientBase = new CustomPointD();
        private CustomPointD ptOrientCurr = new CustomPointD();

        [CategoryAttribute("00 Nick Name"), DescriptionAttribute("Figure Nick Name"), ReadOnly(true)]
        public string NICKNAME { get; set; }

        [CategoryAttribute("01 Teaching Orientation"), DescriptionAttribute("Point of orientation : Teaching"), ReadOnly(true)]
        public CustomPointD PT_ORIENT_BASE { get { return ptOrientBase; } }
        [CategoryAttribute("02 Matching Orientation"), DescriptionAttribute("Point of orientation : Matching"), ReadOnly(true)]
        public CustomPointD PT_ORIENT_CURR { get { return ptOrientCurr; } }

        private CustomRectangleD rect_HOR_in_lft = new CustomRectangleD();
        private CustomRectangleD rect_HOR_in_rht = new CustomRectangleD();
        private CustomRectangleD rect_HOR_ex_lft = new CustomRectangleD();
        private CustomRectangleD rect_HOR_ex_rht = new CustomRectangleD();

        private CustomRectangleD rect_VER_in_top = new CustomRectangleD();
        private CustomRectangleD rect_VER_in_btm = new CustomRectangleD();
        private CustomRectangleD rect_VER_ex_top = new CustomRectangleD();
        private CustomRectangleD rect_VER_ex_btm = new CustomRectangleD();

        //*****************************************************************************************

        [CategoryAttribute("03 HOR_IN_LFT"), DescriptionAttribute("Region Information"), ReadOnly(true)]
        public CustomRectangleD RC_HOR_IN_LFT{ get { return rect_HOR_in_lft; } set { rect_HOR_in_lft= value; } }

        [CategoryAttribute("04 HOR_IN_RHT"), DescriptionAttribute("Region Information"), ReadOnly(true)]
        public CustomRectangleD RC_HOR_IN_RHT { get { return rect_HOR_in_rht; } set { rect_HOR_in_rht= value; } }

        [CategoryAttribute("07 VER_IN_TOP"), DescriptionAttribute("Region Information"), ReadOnly(true)]
        public CustomRectangleD RC_VER_IN_TOP { get { return rect_VER_in_top; } set { rect_VER_in_top= value; } }

        [CategoryAttribute("08 VER_IN_BTM"), DescriptionAttribute("Region Information"), ReadOnly(true)]
        public CustomRectangleD RC_VER_IN_BTM { get { return rect_VER_in_btm; } set { rect_VER_in_btm = value; } }

        //*****************************************************************************************

        [CategoryAttribute("05 HOR_EX_LFT"), DescriptionAttribute("Region Information"), ReadOnly(true)]
        public CustomRectangleD RC_HOR_EX_LFT { get { return rect_HOR_ex_lft; } set { rect_HOR_ex_lft = value; } }

        [CategoryAttribute("06 HOR_EX_RHT"), DescriptionAttribute("Region Information"), ReadOnly(true)]
        public CustomRectangleD RC_HOR_EX_RHT { get { return rect_HOR_ex_rht; } set { rect_HOR_ex_rht = value; } }


        [CategoryAttribute("09 VER_EX_TOP"), DescriptionAttribute("Region Information"), ReadOnly(true)]
        public CustomRectangleD RC_VER_EX_TOP { get { return rect_VER_ex_top; } set { rect_VER_ex_top = value; } }

        [CategoryAttribute("10 VER_EX_BTM"), DescriptionAttribute("Region Information"), ReadOnly(true)]
        public CustomRectangleD RC_VER_EX_BTM { get { return rect_VER_ex_btm; } set { rect_VER_ex_btm = value; } }

        //*****************************************************************************************

        public string measureHOR_IN_L = string.Empty;
        public string measureHOR_IN_R = string.Empty;
        public string measureHOR_EX_L = string.Empty;
        public string measureHOR_EX_R = string.Empty;

        public string measureVER_IN_T = string.Empty;
        public string measureVER_IN_B = string.Empty;
        public string measureVER_EX_T = string.Empty;
        public string measureVER_EX_B = string.Empty;

        //*****************************************************************************************
        [CategoryAttribute("11 Measure Method"), DescriptionAttribute("Measure Method")]
        [Browsable(true)]
        [TypeConverter(typeof(ConverterMeasureTyes))]
        public string MEASURE_HOR_IN_L
        {
            get
            {
                string str = "";

                if (measureHOR_IN_L != null)
                {
                    str = measureHOR_IN_L;
                }
                else
                {
                    str = IFX_MEASURE_TYPE.ToStringType(0);
                }
                return str;
            }

            set { measureHOR_IN_L = value; }
        }
        [CategoryAttribute("12 Measure Method"), DescriptionAttribute("Measure Method")]
        [Browsable(true)]
        [TypeConverter(typeof(ConverterMeasureTyes))]
        public string MEASURE_HOR_IN_R
        {
            get
            {
                string str = "";

                if (measureHOR_IN_R != null)
                {
                    str = measureHOR_IN_R;
                }
                else
                {
                    str = IFX_MEASURE_TYPE.ToStringType(0);
                }
                return str;
            }

            set { measureHOR_IN_R = value; }
        }

        [CategoryAttribute("13 Measure Method"), DescriptionAttribute("Measure Method")]
        [Browsable(true)]
        [TypeConverter(typeof(ConverterMeasureTyes))]
        public string MEASURE_VER_IN_T
        {
            get
            {
                string str = "";

                if (measureVER_IN_T != null)
                {
                    str = measureVER_IN_T;
                }
                else
                {
                    str = IFX_MEASURE_TYPE.ToStringType(0);
                }
                return str;
            }

            set { measureVER_IN_T = value; }
        }
        [CategoryAttribute("14 Measure Method"), DescriptionAttribute("Measure Method")]
        [Browsable(true)]
        [TypeConverter(typeof(ConverterMeasureTyes))]
        public string MEASURE_VER_IN_B
        {
            get
            {
                string str = "";

                if (measureVER_IN_B != null)
                {
                    str = measureVER_IN_B;
                }
                else
                {
                    str = IFX_MEASURE_TYPE.ToStringType(0);
                }
                return str;
            }

            set { measureVER_IN_B = value; }
        }

        //*****************************************************************************************

        [CategoryAttribute("11 Measure Method"), DescriptionAttribute("Measure Method")]
        [Browsable(true)]
        [TypeConverter(typeof(ConverterMeasureTyes))]
        public string MEASURE_HOR_EX_L
        {
            get
            {
                string str = "";

                if (measureHOR_EX_L != null)
                {
                    str = measureHOR_EX_L;
                }
                else
                {
                    str = IFX_MEASURE_TYPE.ToStringType(0);
                }
                return str;
            }

            set { measureHOR_EX_L = value; }
        }
        [CategoryAttribute("12 Measure Method"), DescriptionAttribute("Measure Method")]
        [Browsable(true)]
        [TypeConverter(typeof(ConverterMeasureTyes))]
        public string MEASURE_HOR_EX_R
        {
            get
            {
                string str = "";

                if (measureHOR_EX_R != null)
                {
                    str = measureHOR_EX_R;
                }
                else
                {
                    str = IFX_MEASURE_TYPE.ToStringType(0);
                }
                return str;
            }

            set { measureHOR_EX_R = value; }
        }
        [CategoryAttribute("13 Measure Method"), DescriptionAttribute("Measure Method")]
        [Browsable(true)]
        [TypeConverter(typeof(ConverterMeasureTyes))]
        public string MEASURE_VER_EX_T
        {
            get
            {
                string str = "";

                if (measureVER_EX_T != null)
                {
                    str = measureVER_EX_T;
                }
                else
                {
                    str = IFX_MEASURE_TYPE.ToStringType(0);
                }
                return str;
            }

            set { measureVER_EX_T = value; }
        }
        [CategoryAttribute("14 Measure Method"), DescriptionAttribute("Measure Method")]
        [Browsable(true)]
        [TypeConverter(typeof(ConverterMeasureTyes))]
        public string MEASURE_VER_EX_B
        {
            get
            {
                string str = "";

                if (measureVER_EX_B != null)
                {
                    str = measureVER_EX_B;
                }
                else
                {
                    str = IFX_MEASURE_TYPE.ToStringType(0);
                }
                return str;
            }

            set { measureVER_EX_B = value; }
        }

        //*****************************************************************************************

        [CategoryAttribute("15 Searching Direction"), DescriptionAttribute("Only For LoG Based Approach\nSets of Parameters : -1 or 1")]
        public double DIR_HOR_IN_L { get; set; }
        [CategoryAttribute("16 Searching Direction"), DescriptionAttribute("Only For LoG Based Approach\nSets of Parameters : -1 or 1")]
        public double DIR_HOR_IN_R { get; set; }
        [CategoryAttribute("17 Searching Direction"), DescriptionAttribute("Only For LoG Based Approach\nSets of Parameters : -1 or 1")]
        public double DIR_VER_IN_T { get; set; }
        [CategoryAttribute("18 Searching Direction"), DescriptionAttribute("Only For LoG Based Approach\nSets of Parameters : -1 or 1")]
        public double DIR_VER_IN_B { get; set; }

        //*****************************************************************************************

        [CategoryAttribute("19 Searching Direction"), DescriptionAttribute("Only For LoG Based Approach\nSets of Parameters : -1 or 1")]
        public double DIR_HOR_EX_L { get; set; }
        [CategoryAttribute("20 Searching Direction"), DescriptionAttribute("Only For LoG Based Approach\nSets of Parameters : -1 or 1")]
        public double DIR_HOR_EX_R { get; set; }
        [CategoryAttribute("21 Searching Direction"), DescriptionAttribute("Only For LoG Based Approach\nSets of Parameters : -1 or 1")]
        public double DIR_VER_EX_T { get; set; }
        [CategoryAttribute("22 Searching Direction"), DescriptionAttribute("Only For LoG Based Approach\nSets of Parameters : -1 or 1")]
        public double DIR_VER_EX_B { get; set; }

        //*****************************************************************************************
        
        [CategoryAttribute("23 ZeroCrossing Magnification"), DescriptionAttribute("Only For ZeroCrossing Approach\n Set parameters : 0 ~ ∞")]
        public double ZC_MAG_HOR_IN_L { get; set; }
        [CategoryAttribute("24 ZeroCrossing Magnification"), DescriptionAttribute("Only For ZeroCrossing Approach\n Set parameters : 0 ~ ∞")]
        public double ZC_MAG_HOR_IN_R { get; set; }
        [CategoryAttribute("27 ZeroCrossing Magnification"), DescriptionAttribute("Only For ZeroCrossing Approach\n Set parameters : 0 ~ ∞")]
        public double ZC_MAG_VER_IN_T { get; set; }
        [CategoryAttribute("28 ZeroCrossing Magnification"), DescriptionAttribute("Only For ZeroCrossing Approach\n Set parameters : 0 ~ ∞")]
        public double ZC_MAG_VER_IN_B { get; set; }

        //*****************************************************************************************

        [CategoryAttribute("25 ZeroCrossing Magnification"), DescriptionAttribute("Only For ZeroCrossing Approach\n Set parameters : 0 ~ ∞")]
        public double ZC_MAG_HOR_EX_L { get; set; }
        [CategoryAttribute("26 ZeroCrossing Magnification"), DescriptionAttribute("Only For ZeroCrossing Approach\n Set parameters : 0 ~ ∞")]
        public double ZC_MAG_HOR_EX_R { get; set; }
        [CategoryAttribute("29 ZeroCrossing Magnification"), DescriptionAttribute("Only For ZeroCrossing Approach\n Set parameters : 0 ~ ∞")]
        public double ZC_MAG_VER_EX_T { get; set; }
        [CategoryAttribute("30 ZeroCrossing Magnification"), DescriptionAttribute("Only For ZeroCrossing Approach\n Set parameters : 0 ~ ∞")]
        public double ZC_MAG_VER_EX_B { get; set; }

        //*****************************************************************************************

        [CategoryAttribute("31 Show Raw Data"), DescriptionAttribute("True or False")]
        public bool SHOW_RAW_DATA { get; set; }

        public CMeasurePairOvl ToFigure()
        {
            CMeasurePairOvl single = new CMeasurePairOvl();

            single.NICKNAME = NICKNAME;
            single.ptOrientBase = new PointF(ptOrientBase.X, ptOrientBase.Y);
            single.ptOrientCurr = new PointF(ptOrientCurr.X, ptOrientCurr.Y);

            single.measureHOR_IN_L = IFX_MEASURE_TYPE.ToNumericType(measureHOR_IN_L);
            single.measureHOR_IN_R = IFX_MEASURE_TYPE.ToNumericType(measureHOR_IN_R);
            single.measureHOR_EX_L = IFX_MEASURE_TYPE.ToNumericType(measureHOR_EX_L);
            single.measureHOR_EX_R = IFX_MEASURE_TYPE.ToNumericType(measureHOR_EX_R);

            single.measureVER_IN_T = IFX_MEASURE_TYPE.ToNumericType(measureVER_IN_T);
            single.measureVER_IN_B = IFX_MEASURE_TYPE.ToNumericType(measureVER_IN_B);
            single.measureVER_EX_T = IFX_MEASURE_TYPE.ToNumericType(measureVER_EX_T);
            single.measureVER_EX_B = IFX_MEASURE_TYPE.ToNumericType(measureVER_EX_B);

            single.RC_HOR_IN.rc_LFT = RC_HOR_IN_LFT.ToRectangleF();
            single.RC_HOR_IN.rc_RHT = RC_HOR_IN_RHT.ToRectangleF();
            single.RC_HOR_EX.rc_LFT = RC_HOR_EX_LFT.ToRectangleF();
            single.RC_HOR_EX.rc_RHT = RC_HOR_EX_RHT.ToRectangleF();

            single.RC_VER_IN.rc_TOP = RC_VER_IN_TOP.ToRectangleF();
            single.RC_VER_IN.rc_BTM = RC_VER_IN_BTM.ToRectangleF();
            single.RC_VER_EX.rc_TOP = RC_VER_EX_TOP.ToRectangleF();
            single.RC_VER_EX.rc_BTM = RC_VER_EX_BTM.ToRectangleF();

            single.DIR_HOR_IN_L = Convert.ToInt32(DIR_HOR_IN_L);
            single.DIR_HOR_IN_R = Convert.ToInt32(DIR_HOR_IN_R);
            single.DIR_HOR_EX_L = Convert.ToInt32(DIR_HOR_EX_L);
            single.DIR_HOR_EX_R = Convert.ToInt32(DIR_HOR_EX_R);

            single.DIR_VER_IN_T = Convert.ToInt32(DIR_VER_IN_T);
            single.DIR_VER_IN_B = Convert.ToInt32(DIR_VER_IN_B);
            single.DIR_VER_EX_T = Convert.ToInt32(DIR_VER_EX_T);
            single.DIR_VER_EX_B = Convert.ToInt32(DIR_VER_EX_B);

            single.ZC_MAG_HOR_IN_L = Convert.ToInt32(ZC_MAG_HOR_IN_L);
            single.ZC_MAG_HOR_IN_R = Convert.ToInt32(ZC_MAG_HOR_IN_R);
            single.ZC_MAG_HOR_EX_L = Convert.ToInt32(ZC_MAG_HOR_EX_L);
            single.ZC_MAG_HOR_EX_R = Convert.ToInt32(ZC_MAG_HOR_EX_R);

            single.ZC_MAG_VER_IN_T = Convert.ToInt32(ZC_MAG_VER_IN_T);
            single.ZC_MAG_VER_IN_B = Convert.ToInt32(ZC_MAG_VER_IN_B);
            single.ZC_MAG_VER_EX_T = Convert.ToInt32(ZC_MAG_VER_EX_T);
            single.ZC_MAG_VER_EX_B = Convert.ToInt32(ZC_MAG_VER_EX_B);

            single.SHOW_RAW_DATA = this.SHOW_RAW_DATA;
            return single;
        }
        public void FromFigure(CMeasurePairOvl single)
        {
            this.NICKNAME = single.NICKNAME;

            this.ptOrientBase.SetValue(single.ptOrientBase);
            this.ptOrientCurr.SetValue(single.ptOrientCurr);

            this.MEASURE_HOR_IN_L = IFX_MEASURE_TYPE.ToStringType(single.measureHOR_IN_L);
            this.MEASURE_HOR_IN_R = IFX_MEASURE_TYPE.ToStringType(single.measureHOR_IN_R);
            this.MEASURE_HOR_EX_L = IFX_MEASURE_TYPE.ToStringType(single.measureHOR_EX_L);
            this.MEASURE_HOR_EX_R = IFX_MEASURE_TYPE.ToStringType(single.measureHOR_EX_R);
            
            this.MEASURE_VER_IN_T = IFX_MEASURE_TYPE.ToStringType(single.measureVER_IN_T);
            this.MEASURE_VER_IN_B = IFX_MEASURE_TYPE.ToStringType(single.measureVER_IN_B);
            this.MEASURE_VER_EX_T = IFX_MEASURE_TYPE.ToStringType(single.measureVER_EX_T);
            this.MEASURE_VER_EX_B = IFX_MEASURE_TYPE.ToStringType(single.measureVER_EX_B);

            this.RC_HOR_IN_LFT = new CustomRectangleD(single.RC_HOR_IN.rc_LFT);
            this.RC_HOR_IN_RHT = new CustomRectangleD(single.RC_HOR_IN.rc_RHT);
            this.RC_HOR_EX_LFT = new CustomRectangleD(single.RC_HOR_EX.rc_LFT);
            this.RC_HOR_EX_RHT = new CustomRectangleD(single.RC_HOR_EX.rc_RHT);

            this.RC_VER_IN_TOP = new CustomRectangleD(single.RC_VER_IN.rc_TOP);
            this.RC_VER_IN_BTM = new CustomRectangleD(single.RC_VER_IN.rc_BTM);
            this.RC_VER_EX_TOP = new CustomRectangleD(single.RC_VER_EX.rc_TOP);
            this.RC_VER_EX_BTM = new CustomRectangleD(single.RC_VER_EX.rc_BTM);

            this.DIR_HOR_IN_L = single.DIR_HOR_IN_L;
            this.DIR_HOR_IN_R = single.DIR_HOR_IN_R;
            this.DIR_HOR_EX_L = single.DIR_HOR_EX_L;
            this.DIR_HOR_EX_R = single.DIR_HOR_EX_R;

            this.DIR_VER_IN_T = single.DIR_VER_IN_T;
            this.DIR_VER_IN_B = single.DIR_VER_IN_B;
            this.DIR_VER_EX_T = single.DIR_VER_EX_T;
            this.DIR_VER_EX_B = single.DIR_VER_EX_B;

            this.ZC_MAG_HOR_IN_L = single.ZC_MAG_HOR_IN_L;
            this.ZC_MAG_HOR_IN_R = single.ZC_MAG_HOR_IN_R;
            this.ZC_MAG_HOR_EX_L = single.ZC_MAG_HOR_EX_L;
            this.ZC_MAG_HOR_EX_R = single.ZC_MAG_HOR_EX_R;

            this.ZC_MAG_VER_IN_T = single.ZC_MAG_VER_IN_T;
            this.ZC_MAG_VER_IN_B = single.ZC_MAG_VER_IN_B;
            this.ZC_MAG_VER_EX_T = single.ZC_MAG_VER_EX_T;
            this.ZC_MAG_VER_EX_B = single.ZC_MAG_VER_EX_B;

            this.SHOW_RAW_DATA = single.SHOW_RAW_DATA;
        }

    }
    public class PROPERTY_PairCir
    {
        private CustomPointD ptOrientBase = new CustomPointD();
        private CustomPointD ptOrientCurr = new CustomPointD();

        private int radius { get; set; }

        private string measureCircle = string.Empty;

        private CustomRectangleD rect_Ex = new CustomRectangleD();
        private CustomRectangleD rect_In = new CustomRectangleD();

        [CategoryAttribute("00 Nick Name"), DescriptionAttribute("Figure Nick Name"), ReadOnly(true)]
        public string NICKNAME { get; set; }

        [CategoryAttribute("01 Teaching Orientation"), DescriptionAttribute("Point of orientation : Teaching"), ReadOnly(true)]
        public CustomPointD PT_ORIENT_BASE { get { return ptOrientBase; } }

        [CategoryAttribute("02 Matching Orientation"), DescriptionAttribute("Point of orientation : Matching"), ReadOnly(true)]
        public CustomPointD PT_ORIENT_CURR { get { return ptOrientCurr; } }

        [CategoryAttribute("03 Outter Circle"), DescriptionAttribute("Region Information"), ReadOnly(true)]
        public CustomRectangleD CIRCLE_EX { get { return rect_Ex; } set { rect_Ex = value; } }

        [CategoryAttribute("04 Inner Circle"), DescriptionAttribute("Region Information"), ReadOnly(true)]
        public CustomRectangleD CIRCLE_IN { get { return rect_In; } set { rect_In = value; } }

        [CategoryAttribute("05 Measure Method"), DescriptionAttribute("Measure Method")]
        [Browsable(true)]
        [TypeConverter(typeof(ConverterMeasureTyes))]

        public string MEASURE_CIRCLE
        {
            get
            {
                string str = "";

                if (measureCircle != null)
                {
                    str = measureCircle;
                }
                else
                {
                    str = IFX_MEASURE_TYPE.ToStringType(0);
                }
                return str;
            }

            set { measureCircle = value; }
        }

        [CategoryAttribute("06 Searching Direction"), DescriptionAttribute("Only For LoG Based Approach\nSets of Parameters : -1 or 1")]
        public double DIR { get; set; }
        [CategoryAttribute("07 ZeroCrossing Magnification"), DescriptionAttribute("Only For ZeroCrossing Approach\n Set parameters : 0 ~ ∞")]
        public double ZC_MAG { get; set; }
        [CategoryAttribute("08 Circle DAM Mag"), DescriptionAttribute("Only For ZeroCrossing Approach\n Set parameters : 0.1 ~ 1")]
        public double DMG_IGNORANCE { get; set; }

        [CategoryAttribute("09 Ellipse Process"), DescriptionAttribute("Treat As Ellipse\nTrue or False")]
        public bool TREAT_AS_ELLIPSE { get; set; }
        [CategoryAttribute("10 Show Raw Data"), DescriptionAttribute("True or False")]
        public bool SHOW_RAW_DATA { get; set; }

        public CMeasurePairCir ToFigure()
        {
            CMeasurePairCir single = new CMeasurePairCir();

            single.NICKNAME = NICKNAME;
            single.ptOrientBase = ptOrientBase.ToPointF();
            single.ptOrientCurr = ptOrientCurr.ToPointF();

            single.measure_CIR = IFX_MEASURE_TYPE.ToNumericType(measureCircle);

            single.rc_EX = rect_Ex.ToRectangleF();
            single.rc_IN = rect_In.ToRectangleF();

            single.DIR = Convert.ToInt32(DIR);
            single.ZC_MAG= Convert.ToInt32(ZC_MAG);
            single.DMG_IGNORANCE = this.DMG_IGNORANCE;
            single.bTreatAsEllipse = this.TREAT_AS_ELLIPSE ;
            single.SHOW_RAW_DATA = this.SHOW_RAW_DATA;
            return single;
        }
        public void FromFigure(CMeasurePairCir single)
        {
            this.NICKNAME = single.NICKNAME;
            
            this.ptOrientBase.SetValue(single.ptOrientBase);
            this.ptOrientCurr.SetValue(single.ptOrientCurr);

            this.measureCircle = IFX_MEASURE_TYPE.ToStringType(single.measure_CIR);

            this.rect_Ex.SetValue(single.rc_EX);
            this.rect_In.SetValue(single.rc_IN);

            this.DIR = single.DIR;
            this.ZC_MAG = single.ZC_MAG;
            this.DMG_IGNORANCE = single.DMG_IGNORANCE;
            this.TREAT_AS_ELLIPSE = single.bTreatAsEllipse;
            this.SHOW_RAW_DATA = single.SHOW_RAW_DATA;
        }

    }

}
