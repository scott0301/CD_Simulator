using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

using System.IO;
using System.Xml.Serialization;

using CMeasure;
using DispObject;

namespace CFigure
{
    public static class DEF_PATH
    {
        public static string PATH_MAIN = "C:\\CD_METER";
        public static string PATH_DUMP = "C:\\CD_METER\\DUMP";
        public static string PATH_RECP = "C:\\CD_METER\\RECP";
        public static string PATH_PTRN = "C:\\CD_METER\\PTRN_TEACHING";
        public static string PATH_IMG  = "C:\\CD_METER\\IMAGE";
        public static string PATH_DCIM = "C:\\CD_METER\\DCIM";
    }

    public static class IFX_DIR
    {
        public static int DIR_LFT = 0;
        public static int DIR_TOP = 1;
        public static int DIR_RHT = 2;
        public static int DIR_BTM = 3;
    }
    public static class IFX_FIGURE
    {
        public static int PAIR_HOR = 0;
        public static int PAIR_VER = 1;
        public static int PAIR_DIG = 2;
        public static int PAIR_CIR = 3;
        public static int PAIR_OVL = 4;
        public static int RECT = 5;
        
        public static int ToNumericType(string strType)
        {
            int nReturn = 0;

            /***/if (strType == "PAIR_HOR"){nReturn = PAIR_HOR;}
            else if (strType == "PAIR_VER"){nReturn = PAIR_VER;}
            else if (strType == "PAIR_DIG"){nReturn = PAIR_DIG;}
            else if (strType == "PAIR_CIR"){nReturn = PAIR_CIR; }
            else if (strType == "PAIR_OVL"){nReturn = PAIR_OVL; }
            else if (strType == "RECT"/**/) {nReturn = RECT; }
            return nReturn;
        }
        public static string ToStringType(int nType)
        {
            string strType = string.Empty;

            /***/if (nType == PAIR_HOR) strType = "PAIR_HOR";
            else if (nType == PAIR_VER) strType = "PAIR_VER";
            else if (nType == PAIR_DIG) strType = "PAIR_DIG";
            else if (nType == PAIR_CIR) strType = "PAIR_CIR";
            else if (nType == PAIR_OVL) strType = "PAIR_OVL";
            else if (nType == RECT/**/) strType = "RECT";
            return strType;
        }
    }

    public static class IFX_ADJ_ACTION
    {
        public static int POS = 0;
        public static int GAP = 1;
        public static int SIZE = 2;
        public static int ASYM = 3;
    }

    public static class IFX_MEASURE_TYPE
    {
        public static int LAPL_GAUSS = 0; 
        public static int DIR_INFALL = 1;      // Direction = To Inside Falling
        public static int DIR_INRISE = 2;      // Direction = to Inside Rising
        public static int DIR_EXFALL = 3;      // Direction = to outside Falling
        public static int DIR_EXRISE = 4;      // direction = to Outside Rising
        public static int ZERO_CROSS = 5;
        public static int PRW_RISING = 6;   // overlay method
        public static int PRW_FALLING = 7;  // overlay method
        public static int TOTAL/***/ = 8;

        public static int ToNumericType(string strType)
        {
            int nReturn = 0;
            /***/if (strType == "PRW_RISING")/****/nReturn = PRW_RISING;
            else if (strType == "PRW_FALLING")/***/nReturn = PRW_FALLING;
            else if (strType == "DIR_INFALL") /***/nReturn = DIR_INFALL;
            else if (strType == "DIR_INRISE") /***/nReturn = DIR_INRISE;
            else if (strType == "DIR_EXFALL") /***/nReturn = DIR_EXFALL;
            else if (strType == "DIR_EXRISE") /***/nReturn = DIR_EXRISE;
            else if (strType == "ZERO_CROSS") /***/nReturn = ZERO_CROSS;
            else if (strType == "LAPL_GAUSS") /***/nReturn = LAPL_GAUSS;
            return nReturn;
        }
        public static string ToStringType(int nType)
        {
            string strType = string.Empty;
            /***/if (nType == PRW_RISING)/****/ strType = "PRW_RISING";
            else if (nType == PRW_FALLING)/***/ strType = "PRW_FALLING";
            else if (nType == DIR_INFALL) /***/ strType = "DIR_INFALL";
            else if (nType == DIR_INRISE) /***/ strType = "DIR_INRISE";
            else if (nType == DIR_EXFALL) /***/ strType = "DIR_EXFALL";
            else if (nType == DIR_EXRISE) /***/ strType = "DIR_EXRISE";
            else if (nType == ZERO_CROSS) /***/ strType = "ZERO_CROSS";
            else if (nType == LAPL_GAUSS) /***/ strType = "LAPL_GAUSS";
            return strType;
        }

        public static string[] ToStringArray()
        {
            List<string> list = new List<string>();

            for (int i = 0; i < TOTAL; i++)
            {
                list.Add( ToStringType(i));
            }
            return list.ToArray();
        }
        public static List<string> ToList()
        {
            List<string> list = new List<string>();

            for (int i = 0; i < TOTAL; i++)
            {
                list.Add(ToStringType(i));
            }
            return list;
        }
    }

    [Serializable]
    public class CFigureManager : ICloneable
    {
        public double PIXEL_RES_X { get; set;}
        public double PIXEL_RES_Y { get; set; }

        public List<CMeasurePairHor>/*******/ list_pair_Hor /***/= new List<CMeasurePairHor>();
        public List<CMeasurePairVer>/*******/ list_pair_Ver /***/= new List<CMeasurePairVer>();
        public List<CMeasurePairDig>/*******/ list_pair_Dig /***/= new List<CMeasurePairDig>();
        public List<CMeasurePairCir> /******/ list_pair_Cir /***/= new List<CMeasurePairCir>();
        public List<CMeasurePairOvl>/********/ list_pair_Ovl /****/= new List<CMeasurePairOvl>();
        public List<RectangleF> /***********/ list_rect /******/= new List<RectangleF>();

        public int COUNT_PAIR_VER { get { return list_pair_Ver.Count; } }
        public int COUNT_PAIR_HOR { get { return list_pair_Hor.Count; } }
        public int COUNT_PAIR_DIG { get { return list_pair_Dig.Count; } }
        public int COUNT_PAIR_CIR { get { return list_pair_Cir.Count; } }
        public int COUNT_PAIR_OVL { get { return list_pair_Ovl.Count; } }
        public int COUNT_RECT { get { return list_rect.Count; } }

        public virtual object Clone() { return new CFigureManager(this); }

        public string PTRN_TEACH_FILE{get;set;}
        public double PTRN_ACCEPT_RATIO = 95;
        public string RECP_FILE { get; set; }

        #region CREATOR
        public CFigureManager()
        {
            this.PIXEL_RES_X = this.PIXEL_RES_Y = 1;
        }
        protected CFigureManager(CFigureManager myself)
        {
            this.PIXEL_RES_X = myself.PIXEL_RES_X;
            this.PIXEL_RES_Y = myself.PIXEL_RES_Y;

            this.list_pair_Hor = myself.list_pair_Hor.ToList();
            this.list_pair_Ver = myself.list_pair_Ver.ToList();
            this.list_pair_Dig = myself.list_pair_Dig.ToList();
            this.list_pair_Cir = myself.list_pair_Cir.ToList();
            this.list_pair_Ovl = myself.list_pair_Ovl.ToList();
            this.list_rect = myself.list_rect.ToList();

            this.PTRN_TEACH_FILE = myself.PTRN_TEACH_FILE;
            this.RECP_FILE = myself.RECP_FILE;
            this.PTRN_ACCEPT_RATIO = myself.PTRN_ACCEPT_RATIO;
            
        }
        #endregion 

        public void SetPixelSize(string strX, string strY)
        {
            this.PIXEL_RES_X = Convert.ToDouble(strX);
            this.PIXEL_RES_Y = Convert.ToDouble(strY);
        }

        #region GET SINGLE ELEMENT FOR EACH FIGURES
        public CMeasurePairHor ElementAt_PairHor(int nIndex)
        {
            CMeasurePairHor single = new CMeasurePairHor();
            if (nIndex <= COUNT_PAIR_HOR && COUNT_PAIR_HOR != 0) { single = list_pair_Hor.ElementAt(nIndex); }
            return single;
        }
        public CMeasurePairVer ElementAt_PairVer(int nIndex)
        {
            CMeasurePairVer single = new CMeasurePairVer();
            if (nIndex <= COUNT_PAIR_VER && COUNT_PAIR_VER != 0) { single = list_pair_Ver.ElementAt(nIndex); }
            return single;
        }
        public CMeasurePairDig ElementAt_PairDig(int nIndex)
        {
            CMeasurePairDig single = new CMeasurePairDig();
            if (nIndex <= COUNT_PAIR_DIG && COUNT_PAIR_DIG != 0) { single = list_pair_Dig.ElementAt(nIndex); }
            return single;
        }
        public CMeasurePairCir ElementAt_PairCir(int nIndex)
        {
            CMeasurePairCir single = new CMeasurePairCir();
            if (nIndex <= COUNT_PAIR_CIR && COUNT_PAIR_CIR != 0) { single = list_pair_Cir.ElementAt(nIndex); }
            return single;
        }
        public CMeasurePairOvl ElementAt_PairOvl(int nIndex)
        {
            CMeasurePairOvl single = new CMeasurePairOvl();
            if (nIndex <= COUNT_PAIR_OVL && COUNT_PAIR_OVL != 0) { single = list_pair_Ovl.ElementAt(nIndex); }
            return single;
        }
        public RectangleF ElementAt_Rectangle(int nIndex)
        {
            RectangleF rc = new RectangleF();

            if (nIndex <= COUNT_RECT && COUNT_RECT != 0)
            {
                rc = list_rect.ElementAt(nIndex);
            }
            return rc;
        }
        public void SetRelativeCroodinate(PointF ptGravity)
        {
            List<CMeasurePairHor> buffHor = new List<CMeasurePairHor>();
            List<CMeasurePairVer> buffVer = new List<CMeasurePairVer>();
            List<CMeasurePairDig> buffDig = new List<CMeasurePairDig>();
            List<CMeasurePairCir> buffCir = new List<CMeasurePairCir>();
            List<CMeasurePairOvl> buffOvl = new List<CMeasurePairOvl>();

            foreach (CMeasurePairHor single in list_pair_Hor)
            {
                single.SetRelativeCroodinates(ptGravity);
                buffHor.Add(single);
            }
            foreach (CMeasurePairVer single in list_pair_Ver)
            {
                single.SetRelativeCroodinates(ptGravity);
                buffVer.Add(single);
            }
            foreach (CMeasurePairDig single in list_pair_Dig)
            {
                single.SetRelativeCroodinates(ptGravity);
                buffDig.Add(single);
            }
            foreach (CMeasurePairCir single in list_pair_Cir)
            {
                single.SetRelativeCroodinates(ptGravity);
                buffCir.Add(single);
            }
            foreach (CMeasurePairOvl single in list_pair_Ovl)
            {
                single.SetRelativeCroodinates(ptGravity);
                buffOvl.Add(single);
            }
            list_pair_Hor.Clear(); list_pair_Hor = buffHor.ToList();
            list_pair_Ver.Clear(); list_pair_Ver = buffVer.ToList();
            list_pair_Dig.Clear(); list_pair_Dig = buffDig.ToList();
            list_pair_Cir.Clear(); list_pair_Cir = buffCir.ToList();
            list_pair_Ovl.Clear(); list_pair_Ovl = buffOvl.ToList();
        }
        public void SetBaseCroodinate(PointF ptBase)
        {
            List<CMeasurePairHor> buffHor = new List<CMeasurePairHor>();
            List<CMeasurePairVer> buffVer = new List<CMeasurePairVer>();
            List<CMeasurePairDig> buffDig = new List<CMeasurePairDig>();
            List<CMeasurePairCir> buffCir = new List<CMeasurePairCir>();
            List<CMeasurePairOvl> buffOvl = new List<CMeasurePairOvl>();

            foreach (CMeasurePairHor single in list_pair_Hor)
            {
                single.ptOrientCurr = ptBase;
                buffHor.Add(single);
            }
            foreach (CMeasurePairVer single in list_pair_Ver)
            {
                single.ptOrientCurr = ptBase;
                buffVer.Add(single);
            }
            foreach (CMeasurePairDig single in list_pair_Dig)
            {
                single.ptOrientCurr = ptBase;
                buffDig.Add(single);
            }
            foreach (CMeasurePairCir single in list_pair_Cir)
            {
                single.ptOrientCurr = ptBase;
                buffCir.Add(single);
            }
            foreach (CMeasurePairOvl single in list_pair_Ovl)
            {
                single.ptOrientCurr = ptBase;
                buffOvl.Add(single);
            }

            list_pair_Hor.Clear(); list_pair_Hor = buffHor.ToList();
            list_pair_Ver.Clear(); list_pair_Ver = buffVer.ToList();
            list_pair_Dig.Clear(); list_pair_Dig = buffDig.ToList();
            list_pair_Cir.Clear(); list_pair_Cir = buffCir.ToList();
            list_pair_Ovl.Clear(); list_pair_Ovl = buffOvl.ToList();
        }
        
        #endregion

        #region FIGURE MANAGEMENT

        public void RemoveAll()
        {
            list_rect.Clear();
            list_pair_Hor.Clear();
            list_pair_Ver.Clear();
            list_pair_Dig.Clear();
            list_pair_Cir.Clear();
            list_pair_Ovl.Clear();
        }
        public void Figure_Remove(int nFigureType, int nIndex)
        {
            /***/if (nFigureType == IFX_FIGURE.PAIR_HOR) { if (COUNT_PAIR_HOR >= nIndex && COUNT_PAIR_HOR != 0)list_pair_Hor.RemoveAt(nIndex); }
            else if (nFigureType == IFX_FIGURE.PAIR_VER) { if (COUNT_PAIR_VER >= nIndex && COUNT_PAIR_VER != 0)list_pair_Ver.RemoveAt(nIndex); }
            else if (nFigureType == IFX_FIGURE.PAIR_DIG) { if (COUNT_PAIR_DIG >= nIndex && COUNT_PAIR_DIG != 0)list_pair_Dig.RemoveAt(nIndex); }
            else if (nFigureType == IFX_FIGURE.PAIR_CIR) { if (COUNT_PAIR_CIR >= nIndex && COUNT_PAIR_CIR != 0)list_pair_Cir.RemoveAt(nIndex); }
            else if (nFigureType == IFX_FIGURE.PAIR_OVL) { if (COUNT_PAIR_OVL >= nIndex && COUNT_PAIR_OVL != 0)list_pair_Ovl.RemoveAt(nIndex); }
        }
        public void Figure_Add(object single)
        {
            /***/if ("CMeasurePairHor" == single.GetType().Name){list_pair_Hor.Add((CMeasurePairHor)single);}
            else if ("CMeasurePairVer" == single.GetType().Name){list_pair_Ver.Add((CMeasurePairVer)single);}
            else if ("CMeasurePairDig" == single.GetType().Name){list_pair_Dig.Add((CMeasurePairDig)single);}
            else if ("CMeasurePairCir" == single.GetType().Name){list_pair_Cir.Add((CMeasurePairCir)single);}
            else if ("CMeasurePairOvl"  == single.GetType().Name){list_pair_Ovl.Add((CMeasurePairOvl)single);}
        }

        public void Figure_Replace(object single)
        {
            string name = single.GetType().Name;
            /***/if (name == "CMeasurePairHor[]"){list_pair_Hor = ((CMeasurePairHor[])single).ToList();}
            else if (name == "CMeasurePairVer[]"){list_pair_Ver = ((CMeasurePairVer[])single).ToList();}
            else if (name == "CMeasurePairDig[]"){list_pair_Dig = ((CMeasurePairDig[])single).ToList();}
            else if (name == "CMeasurePairCir[]"){list_pair_Cir = ((CMeasurePairCir[])single).ToList();}
            else if (name == "CMeasurePairOvl[]"){list_pair_Ovl = ((CMeasurePairOvl[])single).ToList();}
        }
        #endregion  

        #region ToArray()
        public CMeasurePairHor[] ToArray_PairHor() { return list_pair_Hor.ToArray();}
        public CMeasurePairVer[] ToArrya_PairVer() { return list_pair_Ver.ToArray(); }
        public CMeasurePairDig[] ToArray_PairDig() { return list_pair_Dig.ToArray(); }
        public CMeasurePairCir[] ToArray_PairCir() { return list_pair_Cir.ToArray(); }
        public CMeasurePairOvl[] ToArray_PairOvl() { return list_pair_Ovl.ToArray(); }
        #endregion  

        #region SERIALIZATION
        public static void SerializedXml_Save(string strPath, CFigureManager data)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(CFigureManager));
            using (StreamWriter sw = new StreamWriter(strPath))
            {
                xmlSerializer.Serialize(sw, data);
            }      
        }

        public static CFigureManager SerializedXml_Load(string strPath)
        {
            CFigureManager fmTemp = new CFigureManager();

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(CFigureManager));
            using (StreamReader sr = new StreamReader(strPath))
            {
                fmTemp = (CFigureManager)xmlSerializer.Deserialize(sr);
            }

            return fmTemp;
        }
        #endregion
    }

     public sealed class parseRect
     {
        // public PointF ptOrigin = new PointF();

         private PointF pt_lt = new PointF();
         private PointF pt_rt = new PointF();
         private PointF pt_rb = new PointF();
         private PointF pt_lb = new PointF();

         public PointF LT { get { return pt_lt; } set { pt_lt = value; } }
         public PointF RT { get { return pt_rt; } set { pt_rt = value; } }
         public PointF LB { get { return pt_lb; } set { pt_lb = value; } }
         public PointF RB { get { return pt_rb; } set { pt_rb = value; } }

         public float MIN_X { get { return Math.Min(LT.X, LB.X); } }
         public float MAX_X { get { return Math.Max(RT.X, RB.X); } }
         public float MIN_Y { get { return Math.Min(LT.Y, RT.Y); } }
         public float MAX_Y { get { return Math.Max(LB.Y, RB.Y); } }

         public double Width
         {
             get
             {
                 double lt = _length(LT, RT);
                 double lb = _length(LB, RB);
                 return (lt + lb) / 2.0;
             }
         }
         public double Height
         {
             get
             {
                 double ll = _length(LT, LB);
                 double lr = _length(RT, RB);
                 return (ll + lr) / 2.0;
             }
         }

         public void ScaleX(int tx)
         {
             this.RT = new PointF(this.RT.X + tx, this.RT.Y);
             this.RB = new PointF(this.RB.X + tx, this.RB.Y);
         }
         public void ScaleY(int ty)
         {
             this.LB = new PointF(this.LB.X, this.LB.Y + ty);
             this.RB = new PointF(this.RB.X, this.RB.Y + ty);
         }

         public void RotatePoint(PointF ptGravity, double fAngle)
         {
             LT = _RotatePointByGravity(LT, ptGravity, fAngle);
             RT = _RotatePointByGravity(RT, ptGravity, fAngle);
             LB = _RotatePointByGravity(LB, ptGravity, fAngle);
             RB = _RotatePointByGravity(RB, ptGravity, fAngle);
         }

         private PointF _RotatePointByGravity(PointF ptTarget, PointF ptGravity, double fAngle)
         {
             //x' = (x-a) * cosR - (y-b)sinR + a
             //y' = (x-a) * sinR + (y-b)cosR + b
             fAngle = fAngle * Math.PI / 180.0;

             PointF ptRotated = new PointF(0, 0);

             ptRotated.X = (float)(((ptTarget.X - ptGravity.X) * Math.Cos(fAngle) - (ptTarget.Y - ptGravity.Y) * Math.Sin(fAngle)) + ptGravity.X);
             ptRotated.Y = (float)(((ptTarget.X - ptGravity.X) * Math.Sin(fAngle) + (ptTarget.Y - ptGravity.Y) * Math.Cos(fAngle)) + ptGravity.Y);

             return ptRotated;
         }

         private double _length(PointF p1, PointF p2)
         {
             return Math.Sqrt(((p2.X - p1.X) * (p2.X - p1.X)) + ((p2.Y - p1.Y) * (p2.Y - p1.Y)));
         }

         public parseRect() { }
         public parseRect(parseRect rc)
         {
             this.LT = rc.LT;
             this.RT = rc.RT;
             this.LB = rc.LB;
             this.RB = rc.RB;
         }
         public parseRect(float x, float y, float w, float h)
         {
             this.pt_lt = new PointF(x, y);
             this.pt_rt = new PointF(x + w, y);
             this.pt_lb = new PointF(x, y + h);
             this.pt_rb = new PointF(x + w, y + h);
         }
         public List<PointF> ToArray()
         {
             PointF[] arrList = new PointF[4];
             arrList[0] = this.pt_lt;
             arrList[1] = this.pt_rt;
             arrList[2] = this.pt_rb;
             arrList[3] = this.pt_lb;
             return arrList.ToList();
         }
         public void OffsetRect(float tx, float ty)
         {
             this.LT = new PointF(this.LT.X + tx, this.LT.Y + ty);
             this.RT = new PointF(this.RT.X + tx, this.RT.Y + ty);
             this.LB = new PointF(this.LB.X + tx, this.LB.Y + ty);
             this.RB = new PointF(this.RB.X + tx, this.RB.Y + ty);
         }
         public RectangleF GetBoundingRect()
         {
             float minx = this.MIN_X;
             float miny = this.MIN_Y;
             float maxx = this.MAX_X;
             float maxy = this.MAX_Y;

             return new RectangleF(minx, miny, maxx - minx, maxy - miny);
         }
         public parseRect CopyTo()
         {
             parseRect rc = new parseRect();

             rc.LT = this.LT;
             rc.RT = this.RT;
             rc.LB= this.LB;
             rc.RB = this.RB;
             return rc;
         }

     }

    public abstract class CMeasureMotherFucker
    {
        //***************************************************************************
        // Member variables
        //***************************************************************************

        public PointF ptOrientBase = new PointF();
        public PointF ptOrientCurr = new PointF();

        public string NICKNAME { get; set; }
        public bool SHOW_RAW_DATA { get; set; }

        public CMeasureMotherFucker() // common creator 
        {
            NICKNAME = string.Empty;
            SHOW_RAW_DATA = false;
        }

        public /*****/int PARAM_FITTING_THR = 50;
        public bool/****/ PARAM_SAVE_CROPS = false;

        //***************************************************************************
        // Abstract Functions 
        //***************************************************************************

        // figure manpulation fuckers
        public abstract void AdjustGap(int tx, int ty);
        public abstract void AdjustPos(int tx, int ty);
        public abstract void AdjustSize(int tx, int ty);
 
        // mmanager for method branches
        public abstract bool VeryfyMeasurementMatching();
        public abstract string GetMeasurementCategory();

        public abstract void SetRelativeOrigin(PointF ptOrigin);
        
        // measurement method in detail for each fuckers.
        public abstract float rape_Pussy_Overay(byte[] rawImage, int imageW, int imageH, ref List<PointF> listEdgesFirst, ref List<PointF> listEdgesSecon);
        public abstract float rape_Bitch_Direction(byte[] rawImage, int imageW, int imageH, ref List<PointF> listEdgesFirst, ref List<PointF>listEdgesSecon);
        public abstract float rape_idiot_ZeroCross(byte[] rawImage, int imageW, int imageH, ref List<PointF> listEdgesFirst, ref List<PointF> listEdtgesSecon);
        public abstract float rape_asshole_Log(byte[] rawImage, int imageW, int imageH, ref List<PointF> listEdgesFirst, ref List<PointF> listEdgesSecon);

        public abstract float MeasureData(byte[] rawImage, int imageW, int imageH, ref List<PointF> listEdgesFirst, ref List<PointF> listEdgesSecon);

        public abstract void SetRelativeCroodinates(PointF ptGravity);

        //***************************************************************************
        // Realistic Member Functions
        //***************************************************************************

        // for drawing : convert minus relative croodinate to absolute croodinate
        public RectangleF GetCompensatedRect(RectangleF rc)
        {
            RectangleF rcResult = rc;

            // 상대좌표가 들어있으면 상대 출력을 해야지
            if (this.ptOrientBase.X != 0 && this.ptOrientBase.Y != 0)
            {
                rcResult.Offset(this.ptOrientBase);

                // 보상좌표가 있으면 보상을 해야지
                if (this.ptOrientCurr.X != 0 && this.ptOrientCurr.Y != 0)
                {
                    PointF ptRelativeDist = new PointF(ptOrientCurr.X - ptOrientBase.X, ptOrientCurr.Y - ptOrientBase.Y);
                    rcResult.Offset(ptRelativeDist);
                }
                // 보상 좌표가 없으면 할게 없어.
                else if (this.ptOrientCurr.X == 0 && this.ptOrientCurr.Y == 0) { }
            }
            return rcResult;
        }

        //  capsulated Edge detection function for only horizontal and vertical  170412 
        public List<PointF> GetRawPoints_HOR_Prewitt(byte[] rawImage, int imageW, int imageH, RectangleF rc, bool bTarget_TOP, int nDir)
        {
            // get joint points positions
            int sx = (int)rc.X;
            int ex = (int)rc.Width + sx;
            int sy = (int)rc.Y;
            int ey = (int)rc.Height + sy;

            byte[] buffLine = new byte[ey - sy];

            List<PointF> list = new List<PointF>();

            // top side reverse 
            if (bTarget_TOP == true)
            {
                for (int x = sx; x < ex; x++)
                {
                    Array.Clear(buffLine, 0, buffLine.Length);
                    for (int y = sy, nIndex = 0; y < ey; y++)
                    {
                        buffLine[nIndex++] = rawImage[y * imageW + x];
                    }
                    double[] projH = Computer.GetPrewitBuffLine(buffLine, nDir);
                    float yy = (float)Computer.GetNewtonRapRes(projH);

                    list.Add(new PointF(x, (float)(sy + yy)));
                }
            }
            // btm side 
            else if (bTarget_TOP == false)
            {
                for (int x = sx; x < ex; x++)
                {
                    Array.Clear(buffLine, 0, buffLine.Length);
                    for (int y = ey - 1, nIndex = 0; y >= sy; y--)
                    {
                        buffLine[nIndex++] = rawImage[y * imageW + x];
                    }
                    double[] projH = Computer.GetPrewitBuffLine(buffLine, nDir);
                    float yy = (float)Computer.GetNewtonRapRes(projH);

                    list.Add(new PointF(x, (float)(ey + yy)));
                }
            }
            return list;
        }
        public List<PointF> GetRawPoints_VER_Prewitt(byte[] rawImage, int imageW, int imageH, RectangleF rc, bool bTarget_LFT, int nDir)
        {
            // get joint points positions
            int sx = (int)rc.X;
            int ex = (int)rc.Width + sx;
            int sy = (int)rc.Y;
            int ey = (int)rc.Height + sy;

            byte[] buffLine = new byte[ex - sx];

            List<PointF> list = new List<PointF>();

            // top side reverse 
            if (bTarget_LFT == true)
            {

                for (int y = sy; y < ey; y++)
                {
                    Array.Clear(buffLine, 0, buffLine.Length);
                    for (int x = ex - 1, nIndex = 0; x >= sx; x--)
                    {
                        buffLine[nIndex++] = rawImage[y * imageW + x];
                    }
                    double[] projV = Computer.GetPrewitBuffLine(buffLine, nDir);
                    float xx = (float)Computer.GetNewtonRapRes(projV);

                    list.Add(new PointF(ex - xx, y));
                }
            }
            // btm side 
            else if (bTarget_LFT == false)
            {
                for (int y = sy; y < ey; y++)
                {
                    for (int x = sx, nIndex = 0; x < ex; x++)
                    {
                        buffLine[nIndex++] = rawImage[y * imageW + x];
                    }
                    double[] projV = Computer.GetPrewitBuffLine(buffLine, nDir);
                    float xx = (float)Computer.GetNewtonRapRes(projV);

                    list.Add(new PointF(sx + xx, y));
                }
            }
            return list;
        }

        //********************************************************************************************************************************

        // relative function 1: GetPojection[POS]_For[DIR]_Derivative { Get Projection for each direction }
        // relative function 2: ReplaceDerivative_[DIR]_Average  { Replace by representative Position and make point list} 170419 

        public double[]/***/GetProjection_TOP_For_Hor_Derivative(byte[] rawImage, int imageW, int imageH, RectangleF rc, int nDir)
        {
            int sx = (int)rc.X;
            int ex = (int)rc.Width + sx;
            int sy = (int)rc.Y;
            int ey = (int)rc.Height + sy;

            double[] buff_Org = new double[(int)rc.Height + 2];

            if (nDir == IFX_MEASURE_TYPE.DIR_INFALL || nDir == IFX_MEASURE_TYPE.DIR_INRISE)
            {
                for (int y = sy; y < ey + 2; y++)
                {
                    for (int x = sx; x < ex; x++)
                    {
                        buff_Org[y - sy] += rawImage[y * imageW + x];
                    }
                    buff_Org[y - sy] /= (double)rc.Width;
                }
            }
            else if (nDir == IFX_MEASURE_TYPE.DIR_EXFALL || nDir == IFX_MEASURE_TYPE.DIR_EXRISE)
            {
                for (int y = ey - 1, nIndex = 0; y >= sy - 2; y--)
                {
                    for (int x = sx; x < ex; x++)
                    {
                        buff_Org[nIndex] += rawImage[y * imageW + x];
                    }
                    buff_Org[nIndex++] /= (double)rc.Width;
                }
            }

            return Computer.Get2ndDerivativeArray(buff_Org);
        }
        public double[]/***/GetProjection_BTM_For_Hor_Derivative(byte[] rawImage, int imageW, int imageH, RectangleF rc, int nDir)
        {
            int sx = (int)rc.X;
            int ex = (int)rc.Width + sx;
            int sy = (int)rc.Y;
            int ey = (int)rc.Height + sy;

            double[] buff_Org = new double[(int)rc.Height + 2];

            if (nDir == IFX_MEASURE_TYPE.DIR_INFALL || nDir == IFX_MEASURE_TYPE.DIR_INRISE)
            {
                for (int y = ey - 1, nIndex = 0; y >= sy - 2; y--)
                {
                    for (int x = sx; x < ex; x++)
                    {
                        buff_Org[nIndex] += rawImage[y * imageW + x];
                    }
                    buff_Org[nIndex++] /= (double)rc.Width;
                }
            }
            else if (nDir == IFX_MEASURE_TYPE.DIR_EXFALL || nDir == IFX_MEASURE_TYPE.DIR_EXRISE)
            {
                for (int y = sy; y < ey + 2; y++)
                {
                    for (int x = sx; x < ex; x++)
                    {
                        buff_Org[y - sy] += rawImage[y * imageW + x];
                    }
                    buff_Org[y - sy] /= (double)rc.Width;
                }
            }

            return Computer.Get2ndDerivativeArray(buff_Org);
        }

        public double[]/***/GetProjection_LFT_For_VER_Derivative(byte[] rawImage, int imageW, int imageH, RectangleF rc, int nDir)
        {
            int sx = (int)rc.X;
            int ex = (int)rc.Width + sx;
            int sy = (int)rc.Y;
            int ey = (int)rc.Height + sy;

            double[] buff_Org = new double[(int)rc.Width + 2];

            if (nDir == IFX_MEASURE_TYPE.DIR_INFALL || nDir == IFX_MEASURE_TYPE.DIR_INRISE)
            {
                for (int x = sx; x < ex + 2; x++)
                {
                    for (int y = sy; y < ey; y++)
                    {
                        buff_Org[x - sx] += rawImage[y * imageW + x];
                    }
                    buff_Org[x - sx] /= (double)rc.Width;
                }
            }
            else if (nDir == IFX_MEASURE_TYPE.DIR_EXFALL || nDir == IFX_MEASURE_TYPE.DIR_EXRISE)
            {
                for (int x = ex - 1, idx = 0; x >= sx - 2; x--)
                {
                    for (int y = sy; y < ey; y++)
                    {
                        buff_Org[idx] += rawImage[y * imageW + x];
                    }
                    buff_Org[idx++] /= (double)rc.Width;
                }
            }

            return Computer.Get2ndDerivativeArray(buff_Org);
        }
        public double[]/***/GetProjection_RHT_For_VER_Derivative(byte[] rawImage, int imageW, int imageH, RectangleF rc, int nDir)
        {
            int sx = (int)rc.X;
            int ex = (int)rc.Width + sx;
            int sy = (int)rc.Y;
            int ey = (int)rc.Height + sy;

            double[] buff_Org = new double[(int)rc.Width + 2];

            if (nDir == IFX_MEASURE_TYPE.DIR_INFALL || nDir == IFX_MEASURE_TYPE.DIR_INRISE)
            {
                for (int x = ex - 1, idx = 0; x >= sx - 2; x--)
                {
                    for (int y = sy; y < ey; y++)
                    {
                        buff_Org[idx] += rawImage[y * imageW + x];
                    }
                    buff_Org[idx++] /= (double)rc.Width;
                }
            }
            else if (nDir == IFX_MEASURE_TYPE.DIR_EXFALL || nDir == IFX_MEASURE_TYPE.DIR_EXRISE)
            {
                for (int x = sx; x < ex + 2; x++)
                {
                    for (int y = sy; y < ey; y++)
                    {
                        buff_Org[x - sx] += rawImage[y * imageW + x];
                    }
                    buff_Org[x - sx] /= (double)rc.Width;
                }
            }

            return Computer.Get2ndDerivativeArray(buff_Org);
        }

        public List<PointF> ReplacePointList_Derivative_HOR_Average(double[] buff_Line, RectangleF rc, bool bTarget_TOP, int nDir)
        {
            List<PointF> listFiltered = new List<PointF>();

            int posMax = Computer.GetMinElementPosition(buff_Line);
            int posMin = Computer.GetMaxElementPosition(buff_Line);

            // get joint points positions
            int sx = (int)rc.X;
            int ex = (int)rc.Width + sx;
            int sy = (int)rc.Y;
            int ey = (int)rc.Height + sy;

            double fSubPixel = 0.0;

            if (bTarget_TOP == true)
            {
                if (nDir == IFX_MEASURE_TYPE.DIR_INFALL)
                {
                    fSubPixel = Computer.GetSubPixelFromLineBuff(buff_Line, posMin);
                    for (int x = sx; x < ex; x++) { listFiltered.Add(new PointF(x, (float)(sy + posMin + fSubPixel))); }
                }
                else if (nDir == IFX_MEASURE_TYPE.DIR_INRISE)
                {
                    fSubPixel = Computer.GetSubPixelFromLineBuff(buff_Line, posMax);
                    for (int x = sx; x < ex; x++) { listFiltered.Add(new PointF(x, (float)(sy + posMax + fSubPixel))); }
                }
                else if (nDir == IFX_MEASURE_TYPE.DIR_EXRISE)
                {
                    fSubPixel = Computer.GetSubPixelFromLineBuff(buff_Line, posMax);
                    for (int x = sx; x < ex; x++) { listFiltered.Add(new PointF(x, (float)(ey - posMax - fSubPixel))); }
                }
                else if (nDir == IFX_MEASURE_TYPE.DIR_EXFALL)
                {
                    fSubPixel = Computer.GetSubPixelFromLineBuff(buff_Line, posMin);
                    for (int x = sx; x < ex; x++) { listFiltered.Add(new PointF(x, (float)(ey - posMin - fSubPixel))); }
                }
            }
            else if (bTarget_TOP == false)
            {
                if (nDir == IFX_MEASURE_TYPE.DIR_INRISE)
                {
                    fSubPixel = Computer.GetSubPixelFromLineBuff(buff_Line, posMax);
                    for (int x = sx; x < ex; x++) { listFiltered.Add(new PointF(x, (float)(ey - posMax - fSubPixel))); }
                }
                else if (nDir == IFX_MEASURE_TYPE.DIR_INFALL)
                {
                    fSubPixel = Computer.GetSubPixelFromLineBuff(buff_Line, posMin);
                    for (int x = sx; x < ex; x++) { listFiltered.Add(new PointF(x, (float)(ey - posMin - fSubPixel))); }
                }
                else if (nDir == IFX_MEASURE_TYPE.DIR_EXRISE)
                {
                    fSubPixel = Computer.GetSubPixelFromLineBuff(buff_Line, posMax);
                    for (int x = sx; x < ex; x++) { listFiltered.Add(new PointF(x, (float)(sy + posMax + fSubPixel))); }
                }
                else if (nDir == IFX_MEASURE_TYPE.DIR_EXFALL)
                {
                    fSubPixel = Computer.GetSubPixelFromLineBuff(buff_Line, posMin);
                    for (int x = sx; x < ex; x++) { listFiltered.Add(new PointF(x, (float)(sy + posMin + fSubPixel))); }
                }
            }

            return listFiltered;
        }
        public List<PointF> ReplacePointList_Derivative_VER_Average(double[] buff_Line, RectangleF rc, bool bTarget_LFT, int nDir)
        {
            List<PointF> listFiltered = new List<PointF>();

            int posMax = Computer.GetMinElementPosition(buff_Line);
            int posMin = Computer.GetMaxElementPosition(buff_Line);

            // get joint points positions
            int sx = (int)rc.X;
            int ex = (int)rc.Width + sx;
            int sy = (int)rc.Y;
            int ey = (int)rc.Height + sy;

            double fSubPixel = 0.0;

            if (bTarget_LFT == true)
            {
                if (nDir == IFX_MEASURE_TYPE.DIR_INFALL)
                {
                    fSubPixel = Computer.GetSubPixelFromLineBuff(buff_Line, posMin);
                    for (int y = sy; y < ey; y++) { listFiltered.Add(new PointF((float)(sx + posMin + fSubPixel), y)); }
                }
                else if (nDir == IFX_MEASURE_TYPE.DIR_INRISE)
                {
                    fSubPixel = Computer.GetSubPixelFromLineBuff(buff_Line, posMax);
                    for (int y = sy; y < ey; y++) { listFiltered.Add(new PointF((float)(sx + posMax + fSubPixel), y)); }
                }
                else if (nDir == IFX_MEASURE_TYPE.DIR_EXFALL)
                {
                    fSubPixel = Computer.GetSubPixelFromLineBuff(buff_Line, posMin);
                    for (int y = sy; y < ey; y++) { listFiltered.Add(new PointF((float)(ex - posMin - fSubPixel), y)); }
                }
                else if (nDir == IFX_MEASURE_TYPE.DIR_EXRISE)
                {
                    fSubPixel = Computer.GetSubPixelFromLineBuff(buff_Line, posMax);
                    for (int y = sy; y < ey; y++) { listFiltered.Add(new PointF((float)(ex - posMax - fSubPixel), y)); }
                }
            }
            else if (bTarget_LFT == false)
            {
                if (nDir == IFX_MEASURE_TYPE.DIR_INFALL)
                {
                    fSubPixel = Computer.GetSubPixelFromLineBuff(buff_Line, posMin);
                    for (int y = sy; y < ey; y++) { listFiltered.Add(new PointF((float)(ex - posMin - fSubPixel), y)); }
                }
                else if (nDir == IFX_MEASURE_TYPE.DIR_INRISE)
                {
                    fSubPixel = Computer.GetSubPixelFromLineBuff(buff_Line, posMax);
                    for (int y = sy; y < ey; y++) { listFiltered.Add(new PointF((float)(ex - posMax - fSubPixel), y)); }
                }
                else if (nDir == IFX_MEASURE_TYPE.DIR_EXFALL)
                {
                    fSubPixel = Computer.GetSubPixelFromLineBuff(buff_Line, posMin);
                    for (int y = sy; y < ey; y++) { listFiltered.Add(new PointF((float)(sx + posMin + fSubPixel), y)); }
                }
                else if (nDir == IFX_MEASURE_TYPE.DIR_EXRISE)
                {
                    fSubPixel = Computer.GetSubPixelFromLineBuff(buff_Line, posMax);
                    for (int y = sy; y < ey; y++) { listFiltered.Add(new PointF((float)(sx + posMax + fSubPixel), y)); }
                }
            }

            return listFiltered;
        }

        // get the every raw points based on directional 2nd derivative 170419 
        // this functions prepared for the point filtering or fitting which has outliers.
        public List<PointF> GetPointList_Derivative_HOR(byte[] rawImage, int imageW, int imageH, RectangleF rc, bool bTarget_TOP, int nDir)
        {
            List<PointF> list = new List<PointF>();

            // get joint points positions
            int sx = (int)rc.X;
            int ex = (int)rc.Width + sx;
            int sy = (int)rc.Y;
            int ey = (int)rc.Height + sy;

            double fSubPixel = 0.0;

            double[] buff_Org = new double[(int)rc.Height + 2];

            if (bTarget_TOP == true)
            {
                #region FOR TOP REGION : IN-RISE & IN-FALL
                if (nDir == IFX_MEASURE_TYPE.DIR_INFALL || nDir == IFX_MEASURE_TYPE.DIR_INRISE)
                {
                    for (int x = sx; x < ex; x++)
                    {
                        Array.Clear(buff_Org, 0, buff_Org.Length);
                        for (int y = sy, nIndex = 0; y < ey + 2; y++)
                        {
                            buff_Org[nIndex++] = rawImage[y * imageW + x];
                        }
                        double[] buff_2nd = Computer.Get2ndDerivativeArray(buff_Org);

                        if (nDir == IFX_MEASURE_TYPE.DIR_INFALL)
                        {
                            int maxPos = Computer.GetMaxElementPosition(buff_2nd);
                            fSubPixel = Computer.GetSubPixelFromLineBuff(buff_2nd, maxPos);

                            list.Add(new PointF(x, (float)(sy + maxPos + fSubPixel)));
                        }
                        else if (nDir == IFX_MEASURE_TYPE.DIR_INRISE)
                        {
                            int minPos = Computer.GetMinElementPosition(buff_2nd);
                            fSubPixel = Computer.GetSubPixelFromLineBuff(buff_2nd, minPos);

                            list.Add(new PointF(x, (float)(sy + minPos + fSubPixel)));
                        }
                    }
                }
                #endregion

                #region FOR TOP REGION : IN-RISE AND IN-FALL

                else if (nDir == IFX_MEASURE_TYPE.DIR_EXFALL || nDir == IFX_MEASURE_TYPE.DIR_EXRISE)
                {
                    for (int x = sx; x < ex; x++)
                    {
                        Array.Clear(buff_Org, 0, buff_Org.Length);
                        for (int y = ey - 1, nIndex = 0; y >= sy - 2; y--)
                        {
                            buff_Org[nIndex++] = rawImage[y * imageW + x];
                        }
                        double[] buff_Top_2nd = Computer.Get2ndDerivativeArray(buff_Org);

                        if (nDir == IFX_MEASURE_TYPE.DIR_EXFALL)
                        {
                            int maxPos = Computer.GetMaxElementPosition(buff_Top_2nd);
                            fSubPixel = Computer.GetSubPixelFromLineBuff(buff_Top_2nd, maxPos);

                            list.Add(new PointF(x, (float)(ey - maxPos - fSubPixel)));
                        }
                        else if (nDir == IFX_MEASURE_TYPE.DIR_EXRISE)
                        {
                            int minPos = Computer.GetMinElementPosition(buff_Top_2nd);
                            fSubPixel = Computer.GetSubPixelFromLineBuff(buff_Top_2nd, minPos);
                            list.Add(new PointF(x, (float)(ey - minPos - fSubPixel)));
                        }
                    }
                }
                #endregion

            }
            else if (bTarget_TOP == false)
            {
                #region FOR BTM REGION : IN-RISE AND IN-FALL
                if (nDir == IFX_MEASURE_TYPE.DIR_INFALL || nDir == IFX_MEASURE_TYPE.DIR_INRISE)
                {
                    for (int x = sx; x < ex; x++)
                    {
                        Array.Clear(buff_Org, 0, buff_Org.Length);
                        for (int y = ey - 1, nIndex = 0; y >= sy - 2; y--)
                        {
                            buff_Org[nIndex++] = rawImage[y * imageW + x];
                        }
                        double[] buff_2nd = Computer.Get2ndDerivativeArray(buff_Org);

                        if (nDir == IFX_MEASURE_TYPE.DIR_INFALL)
                        {
                            int minPos = Computer.GetMaxElementPosition(buff_2nd);
                            fSubPixel = Computer.GetSubPixelFromLineBuff(buff_2nd, minPos);

                            list.Add(new PointF(x, (float)(ey - minPos - fSubPixel)));

                        }
                        else if (nDir == IFX_MEASURE_TYPE.DIR_INRISE)
                        {
                            int maxPos = Computer.GetMinElementPosition(buff_2nd);
                            fSubPixel = Computer.GetSubPixelFromLineBuff(buff_2nd, maxPos);

                            list.Add(new PointF(x, (float)(ey - maxPos - fSubPixel)));
                        }
                    }
                }
                #endregion

                #region FOR BTM REGION : EX-RISE AND EX-FALL
                else if (nDir == IFX_MEASURE_TYPE.DIR_EXFALL || nDir == IFX_MEASURE_TYPE.DIR_EXRISE)
                {
                    for (int x = sx; x < ex; x++)
                    {
                        Array.Clear(buff_Org, 0, buff_Org.Length);
                        for (int y = sy, nIndex = 0; y < ey + 2; y++)
                        {
                            buff_Org[nIndex++] = rawImage[y * imageW + x];
                        }
                        double[] buff_2nd = Computer.Get2ndDerivativeArray(buff_Org);

                        if (nDir == IFX_MEASURE_TYPE.DIR_EXFALL)
                        {
                            int minPos = Computer.GetMaxElementPosition(buff_2nd);
                            fSubPixel = Computer.GetSubPixelFromLineBuff(buff_2nd, minPos);
                            list.Add(new PointF(x, (float)(sy + minPos + fSubPixel)));

                        }
                        else if (nDir == IFX_MEASURE_TYPE.DIR_EXRISE)
                        {
                            int maxPos = Computer.GetMinElementPosition(buff_2nd);
                            fSubPixel = Computer.GetSubPixelFromLineBuff(buff_2nd, maxPos);
                            list.Add(new PointF(x, (float)(sy + maxPos + fSubPixel)));
                        }
                    }
                }
                #endregion
            }

            return list;
        }
        public List<PointF> GetPointList_Derivative_VER(byte[] rawImage, int imageW, int imageH, RectangleF rc, bool bTarget_LFT, int nDir)
        {
            List<PointF> list = new List<PointF>();

            // get joint points positions
            int sx = (int)rc.X;
            int ex = (int)rc.Width + sx;
            int sy = (int)rc.Y;
            int ey = (int)rc.Height + sy;

            double fSubPixel = 0.0;

            double[] buff_Org = new double[(int)rc.Width + 2];

            if (bTarget_LFT == true)
            {
                #region FOR TOP REGION : IN-RISE & IN-FALL
                if (nDir == IFX_MEASURE_TYPE.DIR_INFALL || nDir == IFX_MEASURE_TYPE.DIR_INRISE)
                {
                    for (int y = sy; y < ey; y++)
                    {
                        Array.Clear(buff_Org, 0, buff_Org.Length);
                        for (int x = sx, nIndex = 0; x < ex + 2; x++)
                        {
                            buff_Org[nIndex++] = rawImage[y * imageW + x];
                        }
                        double[] buff_2nd = Computer.Get2ndDerivativeArray(buff_Org);

                        if (nDir == IFX_MEASURE_TYPE.DIR_INFALL)
                        {
                            int maxPos = Computer.GetMaxElementPosition(buff_2nd);
                            fSubPixel = Computer.GetSubPixelFromLineBuff(buff_2nd, maxPos);
                            list.Add(new PointF((float)(sx + maxPos + fSubPixel), y));
                        }
                        else if (nDir == IFX_MEASURE_TYPE.DIR_INRISE)
                        {
                            int minPos = Computer.GetMinElementPosition(buff_2nd);
                            fSubPixel = Computer.GetSubPixelFromLineBuff(buff_2nd, minPos);
                            list.Add(new PointF((float)(sx + minPos + fSubPixel), y));
                        }
                    }
                }
                #endregion

                #region FOR TOP REGION : IN-RISE AND IN-FALL
                else if (nDir == IFX_MEASURE_TYPE.DIR_EXFALL || nDir == IFX_MEASURE_TYPE.DIR_EXRISE)
                {
                    for (int y = sy; y < ey; y++)
                    {
                        Array.Clear(buff_Org, 0, buff_Org.Length);
                        for (int x = ex - 1, nIndex = 0; x >= sx - 2; x--)
                        {
                            buff_Org[nIndex++] = rawImage[y * imageW + x];
                        }
                        double[] buff_2nd = Computer.Get2ndDerivativeArray(buff_Org);

                        if (nDir == IFX_MEASURE_TYPE.DIR_EXFALL)
                        {
                            int maxPos = Computer.GetMaxElementPosition(buff_2nd);
                            fSubPixel = Computer.GetSubPixelFromLineBuff(buff_2nd, maxPos);
                            list.Add(new PointF((float)(ex - maxPos - fSubPixel), y));
                        }
                        else if (nDir == IFX_MEASURE_TYPE.DIR_EXRISE)
                        {
                            int minPos = Computer.GetMinElementPosition(buff_2nd);
                            fSubPixel = Computer.GetSubPixelFromLineBuff(buff_2nd, minPos);
                            list.Add(new PointF((float)(ex - minPos - fSubPixel), y));
                        }
                    }
                }
                #endregion
            }
            else if (bTarget_LFT == false)
            {
                #region FOR BTM REGION : IN-RISE AND IN-FALL

                if (nDir == IFX_MEASURE_TYPE.DIR_INFALL || nDir == IFX_MEASURE_TYPE.DIR_INRISE)
                {
                    for (int y = sy; y < ey; y++)
                    {
                        Array.Clear(buff_Org, 0, buff_Org.Length);
                        for (int x = ex - 1, nIndex = 0; x >= sx - 2; x--)
                        {
                            buff_Org[nIndex++] = rawImage[y * imageW + x];
                        }
                        double[] buff_RHT_2nd = Computer.Get2ndDerivativeArray(buff_Org);

                        if (nDir == IFX_MEASURE_TYPE.DIR_INFALL)
                        {
                            int maxPos = Computer.GetMaxElementPosition(buff_RHT_2nd);
                            fSubPixel = Computer.GetSubPixelFromLineBuff(buff_RHT_2nd, maxPos);
                            list.Add(new PointF((float)(ex - maxPos - fSubPixel), y));
                        }
                        else if (nDir == IFX_MEASURE_TYPE.DIR_INRISE)
                        {
                            int minPos = Computer.GetMinElementPosition(buff_RHT_2nd);
                            fSubPixel = Computer.GetSubPixelFromLineBuff(buff_RHT_2nd, minPos);
                            list.Add(new PointF((float)(ex - minPos - fSubPixel), y));
                        }
                    }
                }
                #endregion

                #region FOR BTM REGION : EX-RISE AND EX-FALL
                else if (nDir == IFX_MEASURE_TYPE.DIR_EXFALL || nDir == IFX_MEASURE_TYPE.DIR_EXRISE)
                {
                    for (int y = sy; y < ey; y++)
                    {
                        Array.Clear(buff_Org, 0, buff_Org.Length);
                        for (int x = sx, nIndex = 0; x < ex + 2; x++)
                        {
                            buff_Org[nIndex++] = rawImage[y * imageW + x];
                        }
                        double[] buff_2nd = Computer.Get2ndDerivativeArray(buff_Org);
                        if (nDir == IFX_MEASURE_TYPE.DIR_EXFALL)
                        {
                            int maxPos = Computer.GetMaxElementPosition(buff_2nd);
                            fSubPixel = Computer.GetSubPixelFromLineBuff(buff_2nd, maxPos);
                            list.Add(new PointF((float)(sx + maxPos + fSubPixel), y));
                        }
                        else if (nDir == IFX_MEASURE_TYPE.DIR_EXRISE)
                        {
                            int minPos = Computer.GetMinElementPosition(buff_2nd);
                            fSubPixel = Computer.GetSubPixelFromLineBuff(buff_2nd, minPos);

                            list.Add(new PointF((float)(sx + minPos + fSubPixel), y));
                        }
                    }
                }
                #endregion
            }
            return list;
        }

        //********************************************************************************************************************************

        public List<PointF> GetRawPoints_Hor_ZeroCross(byte[] rawImage, int imageW, int imageH, RectangleF rc, bool bTarget_TOP, int nDir, double mag)
        {
            // get joint points positions
            int sx = (int)rc.X;
            int ex = (int)rc.Width + sx;
            int sy = (int)rc.Y;
            int ey = (int)rc.Height + sy;

            byte[] buffLine = new byte[ey - sy];

            List<PointF> list = new List<PointF>();

            // top side reverse 
            if (bTarget_TOP == true)
            {
                for (int x = sx; x < ex; x++)
                {
                    Array.Clear(buffLine, 0, buffLine.Length);
                    for (int y = ey - 1, nIndex = 0; y >= sy; y--)
                    {
                        buffLine[nIndex++] = rawImage[y * imageW + x];
                    }
                    
                    double fSubPos = Computer.GetZeroCrossingPt(buffLine, nDir, mag);
                    list.Add(new PointF(x, ey - (float)fSubPos));
                }
            }
            // btm side 
            else if (bTarget_TOP == false)
            {
                for (int x = sx; x < ex; x++)
                {
                    Array.Clear(buffLine, 0, buffLine.Length);
                    for (int y = sy, nIndex = 0; y < ey; y++)
                    {
                        buffLine[nIndex++] = rawImage[y * imageW + x];
                    }
                    double fSubPos = Computer.GetZeroCrossingPt(buffLine, nDir, mag);
                    list.Add(new PointF(x, sy + (float)fSubPos));
                }
            }
            return list;
        }
        public List<PointF> GetRawPoints_VER_ZeroCross(byte[] rawImage, int imageW, int imageH, RectangleF rc, bool bTarget_LFT, int nDir, double mag)
        {
            // get joint points positions
            int sx = (int)rc.X;
            int ex = (int)rc.Width + sx;
            int sy = (int)rc.Y;
            int ey = (int)rc.Height + sy;

            byte[] buffLine = new byte[ex - sx];

            List<PointF> list = new List<PointF>();

            // top side reverse 
            if (bTarget_LFT == true)
            {
                for (int y = sy; y < ey; y++)
                {
                    Array.Clear(buffLine, 0, buffLine.Length);
                    for (int x = ex - 1, nIndex = 0; x >= sx; x--)
                    {
                        buffLine[nIndex++] = rawImage[y * imageW + x];
                    } 
                    

                    double fSubPos = Computer.GetZeroCrossingPt(buffLine, nDir, mag);
                    list.Add(new PointF(ex - (float)fSubPos, y));
                }
            }
            // btm side 
            else if (bTarget_LFT == false)
            {
                for (int y = sy; y < ey; y++)
                {
                    Array.Clear(buffLine, 0, buffLine.Length);
                    for (int x = sx, nIndex = 0; x < ex; x++)
                    {
                        buffLine[nIndex++] = rawImage[y * imageW + x];
                    }

                    double fSubPos = Computer.GetZeroCrossingPt(buffLine, nDir, mag);
                    list.Add(new PointF(sx + (float)fSubPos, y));
                }
            }
            return list;
        }

        //********************************************************************************************************************************

        public List<PointF> GetRawPoints_HOR_LOG(byte[] rawImage, int imageW, int imageH, RectangleF rc, bool bTarget_TOP, int nDir)
        {
            // get joint points positions
            int sx = (int)rc.X;
            int ex = (int)rc.Width + sx;
            int sy = (int)rc.Y;
            int ey = (int)rc.Height + sy;

            PointF[] buffPoints_IN = new PointF[(int)rc.Height];
            PointF[] buffPoints_EX = new PointF[(int)rc.Height];

            List<PointF> list = new List<PointF>();

            // top side reverse 
            if (bTarget_TOP == true)
            {
                for (int x = sx; x < ex; x++)
                {
                    Array.Clear(buffPoints_IN, 0, buffPoints_IN.Length);
                    for (int y = ey - 1, nIndex = 0; y >= sy; y--)
                    {
                        buffPoints_IN[nIndex++] = new PointF(x, y);
                    }

                    Array.Copy(buffPoints_IN, buffPoints_EX, buffPoints_IN.Length);
                    Array.Reverse(buffPoints_EX);

                    double fSubPosIN = Computer.GetLogPos(rawImage, imageW, imageH, buffPoints_IN, 1);
                    double fSubPosEX = Computer.GetLogPos(rawImage, imageW, imageH, buffPoints_EX, 1);

                    PointF ptIN = new PointF(x, ey - (float)fSubPosIN);
                    PointF ptEX = new PointF(x, sy + (float)fSubPosEX);

                    if (nDir == -1)
                    {
                        list.Add(ptIN);
                    }
                    else if (nDir == 1)
                    {
                        list.Add(ptEX);
                    }
                    else if (nDir == 0)
                    {
                        PointF ptMid = CPoint.GetMidPoint(ptEX, ptIN);
                        list.Add(CPoint.OffsetPoint(ptEX, ptMid));
                    }
                    
                    
                }
            }
            // btm side 
            else if (bTarget_TOP == false)
            {
                for (int x = sx; x < ex; x++)
                {
                    Array.Clear(buffPoints_IN, 0, buffPoints_IN.Length);

                    for (int y = sy, nIndex = 0; y < ey; y++)
                    {
                        buffPoints_IN[nIndex++] = new PointF(x, y);
                    }

                    Array.Copy(buffPoints_IN, buffPoints_EX, buffPoints_IN.Length);
                    Array.Reverse(buffPoints_EX);

                    double fSubPosIN = Computer.GetLogPos(rawImage, imageW, imageH, buffPoints_IN, 1);
                    double fSubPosEX = Computer.GetLogPos(rawImage, imageW, imageH, buffPoints_EX, 1);

                    PointF ptEX = new PointF(x, ey - (float)fSubPosEX);
                    PointF ptIN = new PointF(x, sy + (float)fSubPosIN);

                    if (nDir == -1)
                    {
                        list.Add(ptIN);
                    }
                    else if (nDir == 1)
                    {
                        list.Add(ptEX);
                    }
                    else if (nDir == 0)
                    {
                        PointF ptMid = CPoint.GetMidPoint(ptIN, ptEX);
                        list.Add(CPoint.OffsetPoint(ptIN, ptMid));
                    }

                    
                }

            }
            return list;
        }
        public List<PointF> GetRawPoints_VER_LOG(byte[] rawImage, int imageW, int imageH, RectangleF rc, bool bTarget_LFT, int nDir)
        {
            // get joint points positions
            int sx = (int)rc.X;
            int ex = (int)rc.Width + sx;
            int sy = (int)rc.Y;
            int ey = (int)rc.Height + sy;

            PointF[] buffPointsIN = new PointF[(int)rc.Width];
            PointF[] buffPointsEX = new PointF[(int)rc.Width];

            List<PointF> list = new List<PointF>();
 
            // top side reverse 
            if (bTarget_LFT == true)
            {
                for (int y = sy; y < ey; y++)
                {
                    Array.Clear(buffPointsIN, 0, buffPointsIN.Length);
                    for (int x = ex - 1, nIndex = 0; x >= sx; x--)
                    {
                        buffPointsIN[nIndex++] = new PointF(x, y);
                    }

                    Array.Copy(buffPointsIN, buffPointsEX, buffPointsIN.Length);
                    Array.Reverse(buffPointsEX);
                    
                    double fSubPos_IN = Computer.GetLogPos(rawImage, imageW, imageH, buffPointsIN, 1);
                    double fSubPos_EX = Computer.GetLogPos(rawImage, imageW, imageH, buffPointsEX, 1);

                    PointF ptIN = new PointF(ex - (float)fSubPos_IN, y);
                    PointF ptEX = new PointF(sx + (float)fSubPos_EX, y);

                    if( nDir == -1 )
                    {
                        list.Add(ptIN);
                    }
                    else if( nDir == 1 )
                    {
                        list.Add(ptEX);
                    }
                    else if (nDir == 0)
                    {
                        PointF ptMid = CPoint.GetMidPoint(ptIN, ptEX);
                        list.Add(CPoint.OffsetPoint(ptEX, ptMid));
                    }

                }
            }
            // btm side 
            else if (bTarget_LFT == false)
            {
                for (int y = sy; y < ey; y++)
                {
                    Array.Clear(buffPointsIN, 0, buffPointsIN.Length);
                    for (int x = sx, nIndex = 0; x < ex; x++)
                    {
                        buffPointsIN[nIndex++] = new PointF(x, y);
                    }

                    Array.Copy(buffPointsIN, buffPointsEX, buffPointsIN.Length);
                    Array.Reverse(buffPointsEX);

                    double fSubPosIN = Computer.GetLogPos(rawImage, imageW, imageH, buffPointsIN, 1);
                    double fSubPosEX = Computer.GetLogPos(rawImage, imageW, imageH, buffPointsEX, 1);

                    PointF ptIN = new PointF(sx + (float)fSubPosIN, y);
                    PointF ptEX = new PointF(ex - (float)fSubPosEX, y);

                    if (nDir == -1)
                    {
                        list.Add(ptIN);
                    }
                    else if (nDir == 1)
                    {
                        list.Add(ptEX);
                    }
                    else if (nDir == 0)
                    {
                        PointF ptMid = CPoint.GetMidPoint(ptIN, ptEX);
                        list.Add(CPoint.OffsetPoint(ptIN,ptMid));
                    }
                }
            }
            return list;
        }

        //********************************************************************************************************************************
        // FILTERING FUNCTIONS
        //********************************************************************************************************************************

        // fitering functions for the horizontal and vertical rectangle boundary 170412 
        public List<PointF> GetList_FilteredBy_TY_BY(List<PointF> list, double fTY, double fBY, double fThreshold)
        {
            List<PointF> listBuff = new List<PointF>();

            for (int i = 0; i < list.Count; i++)
            {
                PointF pt = list.ElementAt(i);
                if (Math.Abs(pt.Y - fTY) < fThreshold || Math.Abs(pt.Y - fBY) < fThreshold) continue;
                listBuff.Add(pt);
            }
            return listBuff;
        }
        public List<PointF> GetList_FilteredBy_LX_RX(List<PointF> list, double fLX, double fRX, double fThreshold)
        {
            List<PointF> listBuff = new List<PointF>();

            for (int i = 0; i < list.Count; i++)
            {
                PointF pt = list.ElementAt(i);
                if (Math.Abs(pt.X - fLX) < fThreshold || Math.Abs(pt.X - fRX) < fThreshold) continue;
                listBuff.Add(pt);
            }
            return listBuff;
        }
        public List<PointF> GetList_FilterBy_MajorDistance(List<PointF> list, bool bAxisX, double fDistance)
        {
            List<PointF> listBuff = new List<PointF>();

            PointF [] arrPoints = list.ToArray();

            int nMax = 0;
            int nMaxPos = 0;

            if (bAxisX == true)
            {

                int[] arrX = arrPoints.Select(element => (int)element.X).ToArray();
                nMax = arrX.Max()+1;
                int[] nHisto = new int[nMax];

                for (int i = 0; i < arrX.Length; i++)
                {
                    nHisto[arrX[i]]++;
                }
                nMax = nHisto.Max();
                nMaxPos = Array.IndexOf(nHisto,nMax);

                for (int i = 0; i < list.Count; i++)
                {
                    PointF pt = list.ElementAt(i);
                    if (Math.Abs(pt.X - nMaxPos) < fDistance)
                    {
                        listBuff.Add(pt);
                    }
                    else
                    {
                        listBuff.Add(new PointF(nMaxPos, pt.Y));
                    }
                }
            }
            else if (bAxisX == false)
            {
                int[] arrY = arrPoints.Select(element => (int)element.Y).ToArray();
                nMax = arrY.Max()+1;
                int[] nHisto = new int[nMax];

                for (int i = 0; i < arrY.Length; i++)
                {
                    nHisto[arrY[i]]++;
                }
                nMax = nHisto.Max();
                nMaxPos = Array.IndexOf(nHisto,nMax);

                for (int i = 0; i < list.Count; i++)
                {
                    PointF pt = list.ElementAt(i);
                    if (Math.Abs(pt.Y - nMaxPos) < fDistance)
                    {
                        listBuff.Add(pt);
                    }
                    else
                    {
                        listBuff.Add(new PointF(pt.X, nMaxPos));
                    }
                }
            }
            return listBuff;
        }

        //********************************************************************************************************************************
        // POINT ENFORCING FUNCTIONS 
        //********************************************************************************************************************************
        // croodinate points fixation function for the axis  170412 
        public List<PointF> ReplacePointList_Absolute_X(RectangleF rc, float x)
        {
            List<PointF> list = new List<PointF>();

            int nHead = (int)rc.Y;
            int nTail = (int)rc.Y + (int)rc.Height;

            for (int y = nHead; y < nTail; y++)
            {
                list.Add(new PointF(x, y));
            }
            return list;
        }
        public List<PointF> ReplacePointList_Absolute_Y(RectangleF rc, float y)
        {
            List<PointF> list = new List<PointF>();

            int nHead = (int)rc.X;
            int nTail = (int)rc.X + (int)rc.Width;

            for (int x = nHead; x < nTail; x++)
            {
                list.Add(new PointF(x, y));
            }
            return list;
        }
    }
   
    public sealed class CMeasurePairHor : CMeasureMotherFucker
    {
        public int measure_TOP { get; set; }
        public int measure_BTM { get; set; }

        public RectangleF rc_TOP = new RectangleF();
        public RectangleF rc_BTM = new RectangleF();

        public double DIR_TOP { get; set; }
        public double DIR_BTM { get; set; }
        public double ZC_MAG { get; set; }

        public CMeasurePairHor CopyTo() // in order to avoid Icloneable 
        {
            CMeasurePairHor single = new CMeasurePairHor();

            single.ptOrientBase = this.ptOrientBase;
            single.ptOrientCurr = this.ptOrientCurr;
            single.measure_TOP = this.measure_TOP;
            single.measure_BTM = this.measure_BTM;
            single.rc_TOP = this.rc_TOP;
            single.rc_BTM = this.rc_BTM;
            single.NICKNAME = this.NICKNAME;
            single.DIR_TOP = this.DIR_TOP;
            single.DIR_BTM = this.DIR_BTM;
            single.ZC_MAG = this.ZC_MAG;
            single.SHOW_RAW_DATA = this.SHOW_RAW_DATA;

            return single;
        }

        // creators
        public CMeasurePairHor() { SHOW_RAW_DATA = false; }
        public CMeasurePairHor(RectangleF rc1, RectangleF rc2) { this.rc_TOP = rc1; this.rc_BTM = rc2; SHOW_RAW_DATA = false; }

        # region COMMON OVERRIDINGS - NAVIGATOR FUNCTIONS

        public override void AdjustGap(int tx, int ty)
        {
            this.rc_BTM.Y += ty;
        }
        public override void AdjustPos(int tx, int ty)
        {
            this.rc_TOP.Offset(tx, ty);
            this.rc_BTM.Offset(tx, ty);
        }
        public override void AdjustSize(int tx, int ty)
        {
            this.rc_TOP.Width += tx;
            this.rc_TOP.Height += ty;
            this.rc_BTM.Width += tx;
            this.rc_BTM.Height += ty;
        }
 
        #endregion

        //*****************************************************************************************
        // Internal measurement methods

        #region MEASUREMENT METHOD VERIFIER
        public override bool VeryfyMeasurementMatching()
        {
            // rape techniques have to be same 
            string measT = IFX_MEASURE_TYPE.ToStringType(measure_TOP).Split('_')[0];
            string measB = IFX_MEASURE_TYPE.ToStringType(measure_BTM).Split('_')[0];

            if (measT != measB) return false;
            return true;
        }
        public override string GetMeasurementCategory()
        {
            return IFX_MEASURE_TYPE.ToStringType(measure_TOP).Split('_')[0];
        }
        #endregion

        public override void SetRelativeCroodinates(PointF ptGravity)
        {
            // if preserved value exists --> recover 
            if (this.ptOrientBase.X != 0 && this.ptOrientBase.Y != 0)
            {
                rc_TOP.Offset(ptOrientBase);
                rc_BTM.Offset(ptOrientBase);
            }
            
            // update new original point
            this.ptOrientBase = ptGravity;

            // get relative distance 
            PointF ptDist_TOP = CPoint.GetDistancePoint(rc_TOP.Location, ptGravity);
            PointF ptDist_BTM = CPoint.GetDistancePoint(rc_BTM.Location, ptGravity);

            // set relative distance 

            this.rc_TOP = CRect.ReplaceOrigin(rc_TOP, ptDist_TOP);
            this.rc_BTM = CRect.ReplaceOrigin(rc_BTM, ptDist_BTM);
        }

        public override void SetRelativeOrigin(PointF ptOrigin)
        {
            this.ptOrientCurr = ptOrigin;
        }

        public override float rape_Pussy_Overay(byte[] rawImage, int imageW, int imageH, ref List<PointF> listEdgesTOP, ref List<PointF> listEdgesBTM)
        {
            //*************************************************************************************
            // HORIZONTAL
            //*************************************************************************************

            // recover to absolute croodinate

            RectangleF rcTOP = GetCompensatedRect(this.rc_TOP);
            RectangleF rcBTM = GetCompensatedRect(this.rc_BTM);

            double fDistance = 0;

            listEdgesTOP = GetRawPoints_HOR_Prewitt(rawImage, imageW, imageH, rcTOP, true, (int)this.measure_TOP);
            listEdgesBTM = GetRawPoints_HOR_Prewitt(rawImage, imageW, imageH, rcBTM, false, (int)this.measure_BTM);

            fDistance = Math.Max(listEdgesTOP.ElementAt(0).Y, listEdgesBTM.ElementAt(0).Y) - Math.Min(listEdgesTOP.ElementAt(0).Y, listEdgesBTM.ElementAt(0).Y);

            if (SHOW_RAW_DATA == false)
            {
                listEdgesTOP.Clear();
                listEdgesBTM.Clear();

                double[] accProj_TOP = Computer.GetAccPrewitHor(rawImage, imageW, imageH, rcTOP, this.measure_TOP);
                double[] accProj_BTM = Computer.GetAccPrewitHor(rawImage, imageW, imageH, rcBTM, this.measure_BTM);

                float yy_T = (float)Computer.GetNewtonRapRes(accProj_TOP);
                float yy_B = (float)Computer.GetNewtonRapRes(accProj_BTM);

                for (int x = (int)rcTOP.X; x < (int)rcTOP.X + (int)rcTOP.Width; x++)
                {
                    listEdgesTOP.Add(new PointF(x, (float)(rcTOP.Y + yy_T)));
                }
                for (int x = (int)rcBTM.X; x < (int)rcBTM.X + (int)rcBTM.Width; x++)
                {
                    listEdgesBTM.Add(new PointF(x, (float)(rcBTM.Y + yy_T)));
                }
            }

            return Convert.ToSingle(fDistance);
        }
        public override float rape_Bitch_Direction(byte[] rawImage, int imageW, int imageH, ref List<PointF> listEdgesTOP, ref List<PointF> listEdgesBTM)
        {
            //*************************************************************************************
            // HORIZONTAL
            //*************************************************************************************

            RectangleF rcTOP = GetCompensatedRect(this.rc_TOP);
            RectangleF rcBTM = GetCompensatedRect(this.rc_BTM);

            double[] fKernel = Computer.HC_FILTER_GenerateGaussianFilter(1.0, 3);
            rawImage = Computer.HC_FILTER_ConvolutionWindow(fKernel, rawImage, imageW, imageH, Rectangle.Round(rcTOP));
            rawImage = Computer.HC_FILTER_ConvolutionWindow(fKernel, rawImage, imageW, imageH, Rectangle.Round(rcBTM));

            if (measure_TOP == IFX_MEASURE_TYPE.DIR_INFALL || measure_TOP == IFX_MEASURE_TYPE.DIR_INRISE)
            {
                listEdgesTOP = GetPointList_Derivative_HOR(rawImage, imageW, imageH, rcTOP, true, this.measure_TOP);
            }
            else if (measure_TOP == IFX_MEASURE_TYPE.DIR_EXFALL || measure_TOP == IFX_MEASURE_TYPE.DIR_EXRISE)
            {
                listEdgesTOP = GetPointList_Derivative_HOR(rawImage, imageW, imageH, rcTOP, true, this.measure_TOP);
            }

            if (measure_BTM == IFX_MEASURE_TYPE.DIR_INFALL || measure_BTM == IFX_MEASURE_TYPE.DIR_INRISE)
            {
                listEdgesBTM = GetPointList_Derivative_HOR(rawImage, imageW, imageH, rcBTM, false, this.measure_BTM);
            }
            else if (measure_BTM == IFX_MEASURE_TYPE.DIR_EXFALL || measure_BTM == IFX_MEASURE_TYPE.DIR_EXRISE)
            {
                listEdgesBTM = GetPointList_Derivative_HOR(rawImage, imageW, imageH, rcBTM, false, this.measure_BTM);
            }

            listEdgesTOP = GetList_FilterBy_MajorDistance(listEdgesTOP, false, 5);
            listEdgesBTM = GetList_FilterBy_MajorDistance(listEdgesBTM, false, 5);

            CModelLine model_TOP = new CModelLine();
            CModelLine model_BTM = new CModelLine();

            PARAM_FITTING_THR = 3;
            CRansac.ransac_Line_fitting(listEdgesTOP.ToArray(), ref model_TOP, PARAM_FITTING_THR, listEdgesTOP.Count / 2, listEdgesTOP.Count);
            CRansac.ransac_Line_fitting(listEdgesBTM.ToArray(), ref model_BTM, PARAM_FITTING_THR, listEdgesBTM.Count / 2, listEdgesBTM.Count);

            double fDistance = model_BTM.sy - model_TOP.sy;

            if (SHOW_RAW_DATA == false)
            {
                listEdgesTOP = ReplacePointList_Absolute_Y(rcTOP, (float)model_TOP.sy);
                listEdgesBTM = ReplacePointList_Absolute_Y(rcBTM, (float)model_BTM.sy);
            }
            return Convert.ToSingle(fDistance);
        }
        public override float rape_idiot_ZeroCross(byte[] rawImage, int imageW, int imageH, ref List<PointF> listEdgesTOP, ref List<PointF> listEdgesBTM)
        {
            //*************************************************************************************
            // HORIZONTAL
            //*************************************************************************************

            RectangleF rcTOP = GetCompensatedRect(this.rc_TOP);
            RectangleF rcBTM = GetCompensatedRect(this.rc_BTM);

            double[] fKernel = Computer.HC_FILTER_GenerateGaussianFilter(1.0, 3);
            rawImage = Computer.HC_FILTER_ConvolutionWindow(fKernel, rawImage, imageW, imageH, Rectangle.Round(rcTOP));
            rawImage = Computer.HC_FILTER_ConvolutionWindow(fKernel, rawImage, imageW, imageH, Rectangle.Round(rcBTM));

            listEdgesTOP = GetRawPoints_Hor_ZeroCross(rawImage, imageW, imageH, rcTOP, true, (int)this.DIR_TOP, this.ZC_MAG);
            listEdgesBTM = GetRawPoints_Hor_ZeroCross(rawImage, imageW, imageH, rcBTM, false, (int)this.DIR_BTM, this.ZC_MAG);

            listEdgesTOP = GetList_FilterBy_MajorDistance(listEdgesTOP, false, 3);
            listEdgesBTM = GetList_FilterBy_MajorDistance(listEdgesBTM, false, 3);

            CModelLine model_TOP = new CModelLine();
            CModelLine model_BTM = new CModelLine();

            PARAM_FITTING_THR = 3;
            CRansac.ransac_Line_fitting(listEdgesTOP.ToArray(), ref model_TOP, PARAM_FITTING_THR, listEdgesTOP.Count / 2, listEdgesTOP.Count);
            CRansac.ransac_Line_fitting(listEdgesBTM.ToArray(), ref model_BTM, PARAM_FITTING_THR, listEdgesBTM.Count / 2, listEdgesBTM.Count);

            double fDistance = model_BTM.sy - model_TOP.sy;

            if (SHOW_RAW_DATA == false)
            {
                listEdgesTOP = ReplacePointList_Absolute_Y(rcTOP, (float)model_TOP.sy);
                listEdgesBTM = ReplacePointList_Absolute_Y(rcBTM, (float)model_BTM.sy);
            }

            return Convert.ToSingle(fDistance);
        }
        public override float rape_asshole_Log(byte[] rawImage, int imageW, int imageH, ref List<PointF> listEdgesTOP, ref List<PointF> listEdgesBTM)
        {
            RectangleF rcTOP = GetCompensatedRect(this.rc_TOP);
            RectangleF rcBTM = GetCompensatedRect(this.rc_BTM);

            double[] fKernel = Computer.HC_FILTER_GenerateGaussianFilter(1.0, 3);
            rawImage = Computer.HC_FILTER_ConvolutionWindow(fKernel, rawImage, imageW, imageH, Rectangle.Round(rcTOP));
            rawImage = Computer.HC_FILTER_ConvolutionWindow(fKernel, rawImage, imageW, imageH, Rectangle.Round(rcBTM));

            listEdgesTOP = GetRawPoints_HOR_LOG(rawImage, imageW, imageH, rcTOP, true, (int)this.DIR_TOP);
            listEdgesBTM = GetRawPoints_HOR_LOG(rawImage, imageW, imageH, rcBTM, false,(int) this.DIR_BTM);

            listEdgesTOP = GetList_FilterBy_MajorDistance(listEdgesTOP, false, 5);
            listEdgesBTM = GetList_FilterBy_MajorDistance(listEdgesBTM, false, 5);
           
            CModelLine model_TOP = new CModelLine();
            CModelLine model_BTM = new CModelLine();

            PARAM_FITTING_THR = 3;
            CRansac.ransac_Line_fitting(listEdgesTOP.ToArray(), ref model_TOP, PARAM_FITTING_THR, listEdgesTOP.Count / 2, listEdgesTOP.Count);
            CRansac.ransac_Line_fitting(listEdgesBTM.ToArray(), ref model_BTM, PARAM_FITTING_THR, listEdgesBTM.Count / 2, listEdgesBTM.Count);

            double fDistance = model_BTM.sy - model_TOP.sy;

            if (SHOW_RAW_DATA == false)
            {
                listEdgesTOP = ReplacePointList_Absolute_Y(rcTOP, (float)model_TOP.sy );
                listEdgesBTM = ReplacePointList_Absolute_Y(rcBTM, (float)model_BTM.sy );
            }

            return Convert.ToSingle(fDistance);
        }

        public override float MeasureData(byte[] rawImage, int imageW, int imageH, ref List<PointF> listEdgesFirst, ref List<PointF> listEdgesSecon)
        {
            double fDistance = 0;

            /***/if (this.GetMeasurementCategory() == "PRW") { fDistance = this.rape_Pussy_Overay(rawImage, imageW, imageH, ref listEdgesFirst, ref listEdgesSecon); }
            else if (this.GetMeasurementCategory() == "DIR") { fDistance = this.rape_Bitch_Direction(rawImage, imageW, imageH, ref listEdgesFirst, ref listEdgesSecon); }
            else if (this.GetMeasurementCategory() == "ZERO") { fDistance = this.rape_idiot_ZeroCross(rawImage, imageW, imageH, ref listEdgesFirst, ref listEdgesSecon); }
            else if (this.GetMeasurementCategory() == "LAPL") { fDistance = this.rape_asshole_Log(rawImage, imageW, imageH, ref listEdgesFirst, ref listEdgesSecon); }

            return Convert.ToSingle(fDistance);
        }
    }

    public class CMeasurePairVer : CMeasureMotherFucker
    {
        public int measure_LFT { get; set; }
        public int measure_RHT { get; set; }

        public RectangleF rc_LFT = new RectangleF();
        public RectangleF rc_RHT = new RectangleF();

        public double DIR_LFT { get; set; }
        public double DIR_RHT { get; set; }
        public double ZC_MAG { get; set; }

        public CMeasurePairVer CopyTo() // in order to avoid icloneable
        {
            CMeasurePairVer single = new CMeasurePairVer();
            single.ptOrientBase = this.ptOrientBase;
            single.ptOrientCurr = this.ptOrientCurr;
            single.measure_LFT = this.measure_LFT;
            single.measure_RHT = this.measure_RHT;
            single.rc_LFT = this.rc_LFT;
            single.rc_RHT = this.rc_RHT;
            single.NICKNAME = this.NICKNAME;
            single.DIR_LFT = this.DIR_LFT;
            single.DIR_RHT = this.DIR_RHT;
            single.ZC_MAG = this.ZC_MAG;
            single.SHOW_RAW_DATA = this.SHOW_RAW_DATA;
            return single;
        }

        // creators 
        public CMeasurePairVer() { }
        public CMeasurePairVer(RectangleF rc1, RectangleF rc2) { this.rc_LFT = rc1; this.rc_RHT = rc2; }

        # region COMMON OVERRIDINGS - NAVICATOR FUNCTIONS

        public override void AdjustGap(int tx, int ty)
        {
            this.rc_RHT.X += tx;
        }
        public override void AdjustPos(int tx, int ty)
        {
            this.rc_LFT.Offset(tx, ty);
            this.rc_RHT.Offset(tx, ty);
        }
        public override void AdjustSize(int tx, int ty)
        {
            this.rc_LFT.Width += tx;
            this.rc_LFT.Height += ty;
            this.rc_RHT.Width += tx;
            this.rc_RHT.Height += ty;
        }
         #endregion

        //*****************************************************************************************
        // Internal measurement methods

        #region MEASUREMENT METHOD VERIFIER
        public override bool VeryfyMeasurementMatching()
        {
            // rape techniques have to be same 
            string measL = IFX_MEASURE_TYPE.ToStringType(measure_LFT).Split('_')[0];
            string measR = IFX_MEASURE_TYPE.ToStringType(measure_LFT).Split('_')[0];

            if (measL != measR) return false;
            return true;
        }
        public override string GetMeasurementCategory()
        {
            return IFX_MEASURE_TYPE.ToStringType(measure_LFT).Split('_')[0];
        }
        #endregion
         
        public override void SetRelativeCroodinates(PointF ptGravity)
        {
            // if preserved value exists --> recover 
            if (this.ptOrientBase.X != 0 && this.ptOrientBase.Y != 0)
            {
                this.rc_LFT.Offset(ptOrientBase);
                this.rc_RHT.Offset(ptOrientBase);
            }

            // update new original point
            this.ptOrientBase = ptGravity;

            // get relative distance 
            PointF ptDist_LFT = CPoint.GetDistancePoint(rc_LFT.Location, ptGravity);
            PointF ptDist_RHT = CPoint.GetDistancePoint(rc_RHT.Location, ptGravity);

            // set relative distance 

            this.rc_LFT = CRect.ReplaceOrigin(rc_LFT, ptDist_LFT);
            this.rc_RHT = CRect.ReplaceOrigin(rc_RHT, ptDist_RHT);
        }
        public override void SetRelativeOrigin(PointF ptOrigin)
        {
            this.ptOrientCurr = ptOrigin;
        }
        
        public override float rape_Pussy_Overay(byte[] rawImage, int imageW, int imageH, ref List<PointF>listEdgesLFT, ref List<PointF> listEdgesRHT)
        {
            //*************************************************************************************
            // VERITCAL
            //*************************************************************************************

            RectangleF rcLFT = GetCompensatedRect(this.rc_LFT);
            RectangleF rcRHT = GetCompensatedRect(this.rc_RHT);

            double fDistance = 0;

            listEdgesLFT = GetRawPoints_HOR_Prewitt(rawImage, imageW, imageH, rcLFT, true, (int)this.measure_LFT);
            listEdgesRHT = GetRawPoints_HOR_Prewitt(rawImage, imageW, imageH, rcRHT, false, (int)this.measure_RHT);

            fDistance = Math.Max(listEdgesLFT.ElementAt(0).X, listEdgesRHT.ElementAt(0).X) - Math.Min(listEdgesLFT.ElementAt(0).X, listEdgesRHT.ElementAt(0).X);

            if (SHOW_RAW_DATA == false)
            {
                // newton fucks
                double[] accProj_LFT = Computer.GetAccPrewitVer(rawImage, imageW, imageH, rcLFT, this.measure_LFT);
                double[] accProj_RHT = Computer.GetAccPrewitVer(rawImage, imageW, imageH, rcRHT, this.measure_RHT);

                float xx_L = (float)Computer.GetNewtonRapRes(accProj_LFT);
                float xx_R = (float)Computer.GetNewtonRapRes(accProj_RHT);

                listEdgesLFT.Clear();
                listEdgesRHT.Clear();

                for (int y = (int)rcLFT.Y; y < (int)rcLFT.Y + (int)rcLFT.Height; y++)
                {
                    listEdgesLFT.Add(new PointF(rcLFT.X + xx_L, y));
                }
                for (int y = (int)rcRHT.Y; y < (int)rcRHT.Y + (int)rcRHT.Height; y++)
                {
                    listEdgesRHT.Add(new PointF(rcRHT.X + xx_R, y));
                }
            }

            return Convert.ToSingle(fDistance);
        }
        public override float rape_Bitch_Direction(byte[] rawImage, int imageW, int imageH, ref List<PointF> listEdgesLFT, ref List<PointF>listEdgesRHT)
        {
            //*************************************************************************************
            // VERITCAL
            //*************************************************************************************

            RectangleF rcLFT = GetCompensatedRect(this.rc_LFT);
            RectangleF rcRHT = GetCompensatedRect(this.rc_RHT);

            double[] fKernel = Computer.HC_FILTER_GenerateGaussianFilter(1.0, 3);
            rawImage = Computer.HC_FILTER_ConvolutionWindow(fKernel, rawImage, imageW, imageH, Rectangle.Round(rcLFT));
            rawImage = Computer.HC_FILTER_ConvolutionWindow(fKernel, rawImage, imageW, imageH, Rectangle.Round(rcRHT));

            if (measure_LFT == IFX_MEASURE_TYPE.DIR_INFALL || measure_LFT == IFX_MEASURE_TYPE.DIR_INRISE)
            {
                listEdgesLFT = GetPointList_Derivative_VER(rawImage, imageW, imageH, rcLFT, true, this.measure_LFT);
            }
            else if (measure_LFT == IFX_MEASURE_TYPE.DIR_EXFALL || measure_LFT == IFX_MEASURE_TYPE.DIR_EXRISE)
            {
                listEdgesLFT = GetPointList_Derivative_VER(rawImage, imageW, imageW, rcLFT, true, this.measure_LFT);
            }

            if (measure_RHT == IFX_MEASURE_TYPE.DIR_INFALL || measure_RHT == IFX_MEASURE_TYPE.DIR_INRISE)
            {
                listEdgesRHT = GetPointList_Derivative_VER(rawImage, imageW, imageH, rcRHT, false, this.measure_RHT);
            }
            else if (measure_RHT == IFX_MEASURE_TYPE.DIR_EXFALL || measure_RHT == IFX_MEASURE_TYPE.DIR_EXRISE)
            {
                listEdgesRHT = GetPointList_Derivative_VER(rawImage, imageW, imageH, rcRHT, false, this.measure_RHT);
            }

            listEdgesLFT = GetList_FilterBy_MajorDistance(listEdgesLFT, true, 5);
            listEdgesRHT = GetList_FilterBy_MajorDistance(listEdgesRHT, true, 5);

            CModelLine model_LFT = new CModelLine();
            CModelLine model_RHT = new CModelLine();

            PARAM_FITTING_THR = 3;
            CRansac.ransac_Line_fitting(listEdgesLFT.ToArray(), ref model_LFT, PARAM_FITTING_THR, listEdgesLFT.Count / 2, listEdgesLFT.Count * 2);
            CRansac.ransac_Line_fitting(listEdgesRHT.ToArray(), ref model_RHT, PARAM_FITTING_THR, listEdgesRHT.Count / 2, listEdgesRHT.Count * 2);

            double fDistance = model_RHT.sx - model_LFT.sx;

            if (SHOW_RAW_DATA == false)
            {
                listEdgesLFT = ReplacePointList_Absolute_X(rcLFT, (float)model_LFT.sx);
                listEdgesRHT = ReplacePointList_Absolute_X(rcRHT, (float)model_RHT.sx);
            }
           

            return Convert.ToSingle(fDistance);
        }
        public override float rape_idiot_ZeroCross(byte[] rawImage, int imageW, int imageH, ref List<PointF> listEdgesLFT, ref List<PointF> listEdgesRHT)
        {
            //*************************************************************************************
            // VERITCAL
            //*************************************************************************************

            RectangleF rcLFT = GetCompensatedRect(this.rc_LFT);
            RectangleF rcRHT = GetCompensatedRect(this.rc_RHT);

            double[] fKernel = Computer.HC_FILTER_GenerateGaussianFilter(1.0, 3);
            rawImage = Computer.HC_FILTER_ConvolutionWindow(fKernel, rawImage, imageW, imageH, Rectangle.Round(rcLFT));
            rawImage = Computer.HC_FILTER_ConvolutionWindow(fKernel, rawImage, imageW, imageH, Rectangle.Round(rcRHT));

            listEdgesLFT = GetRawPoints_VER_ZeroCross(rawImage, imageW, imageH, rcLFT, true, (int)this.DIR_LFT, this.ZC_MAG);
            listEdgesRHT = GetRawPoints_VER_ZeroCross(rawImage, imageW, imageH, rcRHT, false, (int)this.DIR_RHT, this.ZC_MAG);

            listEdgesLFT = GetList_FilterBy_MajorDistance(listEdgesLFT, true, 3);
            listEdgesRHT = GetList_FilterBy_MajorDistance(listEdgesRHT, true, 3);

            CModelLine model_LFT = new CModelLine();
            CModelLine model_RHT = new CModelLine();

            PARAM_FITTING_THR = 3;
            CRansac.ransac_Line_fitting(listEdgesLFT.ToArray(), ref model_LFT, PARAM_FITTING_THR, listEdgesLFT.Count / 2, listEdgesLFT.Count * 2);
            CRansac.ransac_Line_fitting(listEdgesRHT.ToArray(), ref model_RHT, PARAM_FITTING_THR, listEdgesRHT.Count / 2, listEdgesRHT.Count * 2);

            double fDistance = model_RHT.sx - model_LFT.sx;

            if (SHOW_RAW_DATA == false)
            {
                listEdgesLFT = ReplacePointList_Absolute_X(rcLFT, (float)model_LFT.sx);
                listEdgesRHT = ReplacePointList_Absolute_X(rcRHT, (float)model_RHT.sx);
            }

            return Convert.ToSingle(fDistance);
        }
        public override float rape_asshole_Log(byte[] rawImage, int imageW, int imageH, ref List<PointF> listEdgesLFT, ref List<PointF> listEdgesRHT)
        {
            RectangleF rcLFT = GetCompensatedRect(this.rc_LFT);
            RectangleF rcRHT = GetCompensatedRect(this.rc_RHT);

            double[] fKernel = Computer.HC_FILTER_GenerateGaussianFilter(1.0, 3);
            rawImage = Computer.HC_FILTER_ConvolutionWindow(fKernel, rawImage, imageW, imageH, Rectangle.Round(rcLFT));
            rawImage = Computer.HC_FILTER_ConvolutionWindow(fKernel, rawImage, imageW, imageH, Rectangle.Round(rcRHT));

            listEdgesLFT = GetRawPoints_VER_LOG(rawImage, imageW, imageH, rcLFT, true, (int)this.DIR_LFT);
            listEdgesRHT = GetRawPoints_VER_LOG(rawImage, imageW, imageH, rcRHT, false, (int)this.DIR_RHT);

            listEdgesLFT = GetList_FilterBy_MajorDistance(listEdgesLFT, true, 5);
            listEdgesRHT = GetList_FilterBy_MajorDistance(listEdgesRHT, true, 5);

            CModelLine model_LFT = new CModelLine();
            CModelLine model_RHT = new CModelLine();

            PARAM_FITTING_THR = 3;
            CRansac.ransac_Line_fitting(listEdgesLFT.ToArray(), ref model_LFT, PARAM_FITTING_THR, listEdgesLFT.Count / 2, listEdgesLFT.Count * 2);
            CRansac.ransac_Line_fitting(listEdgesRHT.ToArray(), ref model_RHT, PARAM_FITTING_THR, listEdgesRHT.Count / 2, listEdgesRHT.Count * 2);

            double fDistance = model_RHT.sx - model_LFT.sx;

            if (SHOW_RAW_DATA == false)
            {
                listEdgesLFT = ReplacePointList_Absolute_X(rcLFT, (float)model_LFT.sx);
                listEdgesRHT = ReplacePointList_Absolute_X(rcRHT, (float)model_RHT.sx);
            }
            return Convert.ToSingle(fDistance);
        }
        public override float MeasureData(byte[] rawImage, int imageW, int imageH, ref List<PointF> listEdgesFirst, ref List<PointF> listEdgesSecon)
        {
            double fDistance = 0;

            /***/
            if (this.GetMeasurementCategory() == "PRW") { fDistance = this.rape_Pussy_Overay(rawImage, imageW, imageH, ref listEdgesFirst, ref listEdgesSecon); }
            else if (this.GetMeasurementCategory() == "DIR") { fDistance = this.rape_Bitch_Direction(rawImage, imageW, imageH, ref listEdgesFirst, ref listEdgesSecon); }
            else if (this.GetMeasurementCategory() == "ZERO") { fDistance = this.rape_idiot_ZeroCross(rawImage, imageW, imageH, ref listEdgesFirst, ref listEdgesSecon); }
            else if (this.GetMeasurementCategory() == "LAPL") { fDistance = this.rape_asshole_Log(rawImage, imageW, imageH, ref listEdgesFirst, ref listEdgesSecon); }

            return Convert.ToSingle(fDistance);
        }
    }

    public class CMeasurePairDig : CMeasureMotherFucker
    {
        public int angle { get; set; }

        public int measure_FST { get; set; }
        public int measure_SCD { get; set; }

        public parseRect rc_FST = new parseRect();
        public parseRect rc_SCD = new parseRect();

        public double DIR_FST { get; set; }
        public double DIR_SCD { get; set; }
        public double ZC_MAG { get; set; }

        public CMeasurePairDig CopyTo() // in order to avoid icloneable
        {
            CMeasurePairDig single = new CMeasurePairDig();
            single.ptOrientBase = this.ptOrientBase;
            single.ptOrientCurr = this.ptOrientCurr;
            single.angle = this.angle;
            single.measure_FST = this.measure_FST;
            single.measure_SCD = this.measure_SCD;
            single.rc_FST = this.rc_FST.CopyTo();
            single.rc_SCD = this.rc_SCD.CopyTo();
            single.NICKNAME = this.NICKNAME;
            single.DIR_FST = this.DIR_FST;
            single.DIR_SCD = this.DIR_SCD;
            single.ZC_MAG = this.ZC_MAG;
            single.SHOW_RAW_DATA = this.SHOW_RAW_DATA;
            return single;
        }

        public CMeasurePairDig() { }
        public PointF GetCenter()
        {
            float minX = Math.Min(rc_FST.MIN_X, rc_SCD.MIN_X);
            float maxX = Math.Max(rc_FST.MAX_X, rc_SCD.MAX_X);
            float minY = Math.Min(rc_FST.MIN_Y, rc_SCD.MIN_Y);
            float maxY = Math.Max(rc_FST.MAX_Y, rc_SCD.MAX_Y);

            float cx = Convert.ToSingle(minX + ((maxX - minX) / 2.0));
            float cy = Convert.ToSingle(minY + ((maxY - minY) / 2.0));

            return new PointF(cx, cy);
        }

        public void ApplyAbsoluteRotation(int nAngle) // only for increase 1 angle [Popup window]
        {
            angle += nAngle;
            PointF ptCenter = GetCenter();
            rc_FST.RotatePoint(ptCenter, nAngle);
            rc_SCD.RotatePoint(ptCenter, nAngle);
        }

        public RectangleF GetRectOrigin_FST() // for drawing
        {
            PointF ptCenter = GetCenter();
            parseRect rc = new parseRect(rc_FST);
            rc.RotatePoint(ptCenter, -angle);
            return new RectangleF(rc.LT.X, rc.LT.Y, (float)rc.Width, (float)rc.Height);
        }
        public RectangleF GetRectOrigin_SCD() // for drawing
        {
            PointF ptCenter = GetCenter();
            parseRect rc = new parseRect(rc_SCD);
            rc.RotatePoint(ptCenter, -angle);
            return new RectangleF(rc.LT.X, rc.LT.Y, (float)rc.Width, (float)rc.Height);
        }
        
        # region COMMON OVERRIDINGS - NAVICATOR FUNCTIONS

        public override void AdjustGap(int tx, int ty)
        {
            if (tx == 0)
            {
                // gap adjustment function for the fucking digonal rectangle response only for the fucking x-axis
                return;
            }
            PointF ptCenter = GetCenter();
            rc_FST.RotatePoint(ptCenter, -angle);
            rc_SCD.RotatePoint(ptCenter, -angle);

            rc_SCD.OffsetRect(tx, ty);

            rc_FST.RotatePoint(ptCenter, angle);
            rc_SCD.RotatePoint(ptCenter, angle);

        }
        public override void AdjustPos(int tx, int ty)
        {
            rc_FST.OffsetRect(tx, ty);
            rc_SCD.OffsetRect(tx, ty);
        }
        public override void AdjustSize(int tx, int ty)
        {
            PointF ptCenter = GetCenter();
            rc_FST.RotatePoint(ptCenter, -angle);
            rc_SCD.RotatePoint(ptCenter, -angle);

            if (tx != 0) { rc_FST.ScaleX(tx); rc_SCD.ScaleX(tx); }
            if (ty != 0) { rc_FST.ScaleY(ty); rc_SCD.ScaleY(ty); }

            rc_FST.RotatePoint(ptCenter, angle);
            rc_SCD.RotatePoint(ptCenter, angle);
        }
         #endregion

        #region MEASUREMENT METHOD VERIFIER
        public override bool VeryfyMeasurementMatching()
        {
            // rape techniques have to be same 
            string measF = IFX_MEASURE_TYPE.ToStringType(measure_FST).Split('_')[0];
            string measS = IFX_MEASURE_TYPE.ToStringType(measure_SCD).Split('_')[0];

            if (measF != measS) return false;
            return true;
        }
        public override string GetMeasurementCategory()
        {
            return IFX_MEASURE_TYPE.ToStringType(measure_FST).Split('_')[0];
        }
        #endregion

        public parseRect GetCompensatedRect_FST()
        {
            parseRect rcFST = this.rc_FST;

            // 상대좌표가 들어있으면 상대 출력을 해야지
            if (this.ptOrientBase.X != 0 && this.ptOrientBase.Y != 0)
            {
                rcFST.OffsetRect(this.ptOrientBase.X, this.ptOrientBase.Y);

                // 보상좌표가 있으면 보상을 해야지
                if (this.ptOrientCurr.X != 0 && this.ptOrientCurr.Y != 0)
                {
                    PointF ptRelativeDist = new PointF(ptOrientCurr.X - ptOrientBase.X, ptOrientCurr.Y - ptOrientBase.Y);
                    rcFST.OffsetRect(ptRelativeDist.X, ptRelativeDist.Y);
                }
                // 보상 좌표가 없으면 할게 없어.
                else if (this.ptOrientCurr.X == 0 && this.ptOrientCurr.Y == 0) { }
            }
            return rcFST;
        }
        public parseRect GetCompensatedRect_SCD()
        {
            parseRect rcSCD = this.rc_SCD;

            // 상대좌표가 들어있으면 상대 출력을 해야지
            if (this.ptOrientBase.X != 0 && this.ptOrientBase.Y != 0)
            {
                rcSCD.OffsetRect(this.ptOrientBase.X, this.ptOrientBase.Y);

                // 보상좌표가 있으면 보상을 해야지
                if (this.ptOrientCurr.X != 0 && this.ptOrientCurr.Y != 0)
                {
                    PointF ptRelativeDist = new PointF(ptOrientCurr.X - ptOrientBase.X, ptOrientCurr.Y - ptOrientBase.Y);
                    rcSCD.OffsetRect(ptRelativeDist.X, ptRelativeDist.Y);
                }
                // 보상 좌표가 없으면 할게 없어.
                else if (this.ptOrientCurr.X == 0 && this.ptOrientCurr.Y == 0) { }
            }
            return rcSCD;
        }
        public override void SetRelativeCroodinates(PointF ptGravity)
        {
            // if preserved value exists --> recover 
            if (this.ptOrientBase.X != 0 && this.ptOrientBase.Y != 0)
            {
                this.rc_FST.OffsetRect(ptOrientBase.X, ptOrientBase.Y);
                this.rc_SCD.OffsetRect(ptOrientBase.X, ptOrientBase.Y);
            }

            // update new original point
            this.ptOrientBase = ptGravity;

            // set relative distance 
            this.rc_FST.LT = new PointF(this.rc_FST.LT.X - ptGravity.X, this.rc_FST.LT.Y - ptGravity.Y);
            this.rc_FST.RT = new PointF(this.rc_FST.RT.X - ptGravity.X, this.rc_FST.RT.Y - ptGravity.Y);
            this.rc_FST.LB = new PointF(this.rc_FST.LB.X - ptGravity.X, this.rc_FST.LB.Y - ptGravity.Y);
            this.rc_FST.RB = new PointF(this.rc_FST.RB.X - ptGravity.X, this.rc_FST.RB.Y - ptGravity.Y);

            this.rc_SCD.LT = new PointF(this.rc_SCD.LT.X - ptGravity.X, this.rc_SCD.LT.Y - ptGravity.Y);
            this.rc_SCD.RT = new PointF(this.rc_SCD.RT.X - ptGravity.X, this.rc_SCD.RT.Y - ptGravity.Y);
            this.rc_SCD.LB = new PointF(this.rc_SCD.LB.X - ptGravity.X, this.rc_SCD.LB.Y - ptGravity.Y);
            this.rc_SCD.RB = new PointF(this.rc_SCD.RB.X - ptGravity.X, this.rc_SCD.RB.Y - ptGravity.Y);
        }

        public override void SetRelativeOrigin(PointF ptOrigin)
        {
            this.ptOrientCurr = ptOrigin;
        }

        public override float rape_Pussy_Overay(byte[] rawImage, int imageW, int imageH, ref  List<PointF> listEdgesFST, ref List<PointF> listEdgesSCD)
        {
            parseRect rcFST = GetCompensatedRect_FST();
            parseRect rcSCD = GetCompensatedRect_SCD();

            int regionW = (int)(rcFST.Width * 1.5);
            int regionH = (int)(rcFST.Height);
            // first and second region size = absolutely equivalent!! 

            byte[] cropFirst = null;
            byte[] cropSecon = null;

            //********************************************************
            // Get base axis for each digonal rectangle points 

            #region GET DIGONAL BASE LINE 

            listEdgesFST = CLine.GetLyingPointsFromVariationY(rcFST.LT, rcFST.LB);
            regionH = listEdgesFST.Count;
            cropFirst = new byte[regionW * regionH];

            listEdgesSCD = CLine.GetLyingPointsFromVariationY(rcSCD.RT, rcSCD.RB);
            regionH = listEdgesSCD.Count;
            cropSecon = new byte[regionW * regionH];
            #endregion

            //****************************************************************
            // Get fucking target regions

            #region GET TARGET REGION
            for (int y = 0; y < listEdgesFST.Count; y++)
            {
                int imgX = (int)listEdgesFST.ElementAt(y).X;
                int imgY = (int)listEdgesFST.ElementAt(y).Y;

                for (int x = (int)imgX, nIndex = 0; x < (int)imgX + regionW; x++)
                {
                    cropFirst[y * regionW + nIndex++] = rawImage[imgY * imageW + x];
                }
            }
            for (int y = 0; y < listEdgesSCD.Count; y++)
            {
                int imgX = (int)listEdgesSCD.ElementAt(y).X;
                int imgY = (int)listEdgesSCD.ElementAt(y).Y;

                {
                    for (int x = (int)imgX, nIndex = 0; x > (int)imgX - regionW; x--)
                    {
                        cropSecon[y * regionW + nIndex++] = rawImage[imgY * imageW + x];
                    }
                }
            }
            #endregion

            double fDistance = 0;

            byte[] buffFirst = new byte[regionW];
            byte[] buffSecon = new byte[regionW];

            List<PointF> listEdgesFirst = new List<PointF>();
            List<PointF> listEdgesSecon = new List<PointF>();

            #region GET EDGES IN DETAIL
            for (int y = 0; y < listEdgesFST.Count; y++)
            {
                Array.Clear(buffFirst, 0, buffFirst.Length);
                for (int x = 0; x < regionW; x++)
                {
                    buffFirst[x] = cropFirst[y * regionW + x];
                }
                double [] fArrProj = null;

                if( this.measure_FST == IFX_MEASURE_TYPE.PRW_RISING )
                {
                    fArrProj = Computer.GetPrewitBuffLine(buffFirst, 0);
                }
                else if( this.measure_FST == IFX_MEASURE_TYPE.PRW_FALLING)
                {
                    fArrProj = Computer.GetPrewitBuffLine(buffFirst, 1);
                }

                float xx_L = (float)Computer.GetNewtonRapRes(fArrProj);

                PointF pt = listEdgesFST.ElementAt(y);
                pt.X += (float)xx_L;
                listEdgesFirst.Add(pt);
            }

            for (int y = 0; y < listEdgesSCD.Count; y++)
            {
                Array.Clear(buffSecon, 0, buffSecon.Length);
                for (int x = 0; x < regionW; x++)
                {
                    buffSecon[x] = cropSecon[y * regionW + x];
                }
                double[] fArrProj = null;

                if (this.measure_SCD == IFX_MEASURE_TYPE.PRW_RISING)
                {
                    fArrProj = Computer.GetPrewitBuffLine(buffSecon, 0);
                }
                else if (this.measure_SCD == IFX_MEASURE_TYPE.PRW_FALLING)
                {
                    fArrProj = Computer.GetPrewitBuffLine(buffSecon, 1);
                }

                float xx_L = (float)Computer.GetNewtonRapRes(fArrProj);

                PointF pt = listEdgesSCD.ElementAt(y);
                pt.X -= (float)xx_L;
                listEdgesSecon.Add(pt);
            }
            #endregion

            listEdgesFST.Clear();
            listEdgesSCD.Clear();

            // fit line first
            CLine line1 = CLine.GetFitLineHOR(listEdgesFirst);
            CLine line2 = CLine.GetFitLineHOR(listEdgesSecon);

            // line filtering
            listEdgesFST = CLine.GetFilteredFitLineFromVariationY(line1, listEdgesFirst);
            listEdgesSCD = CLine.GetFilteredFitLineFromVariationY(line2, listEdgesSecon);

            // fit again
            line1 = CLine.GetFitLineHOR(listEdgesFST);
            line2 = CLine.GetFitLineHOR(listEdgesSCD);

            // line expansion
            line1 = line1.GetExpandedLine_CrossLineBased(line1, rcFST.LT, rcFST.RT, rcFST.LB, rcFST.RB);
            line2 = line2.GetExpandedLine_CrossLineBased(line2, rcSCD.LT, rcSCD.RT, rcSCD.LB, rcSCD.RB);

            if (SHOW_RAW_DATA == true)
            {
                listEdgesFST = listEdgesFirst;
                listEdgesSCD = listEdgesSecon;
            }
            else
            {
                listEdgesFST = CLine.GetLyingPointsFromVariationY(line1);
                listEdgesSCD = CLine.GetLyingPointsFromVariationY(line2);
            }

            fDistance = CPoint.GetDistance(line1.CENTER, line2.CENTER);
           
            return Convert.ToSingle(fDistance);
        }
        public override float rape_Bitch_Direction(byte[] rawImage, int imageW, int imageH, ref List<PointF> listEdgesFST, ref List<PointF> listEdgesSCD)
        {
            parseRect rcFST = GetCompensatedRect_FST();
            parseRect rcSCD = GetCompensatedRect_SCD();

            Rectangle rcBoundFirst = Rectangle.Round(rcFST.GetBoundingRect());
            Rectangle rcBoundSecon = Rectangle.Round(rcSCD.GetBoundingRect());

            rcBoundFirst.Inflate((int)(rcFST.Width / 2), (int)(rcFST.Width / 2));
            rcBoundSecon.Inflate((int)(rcSCD.Width / 2), (int)(rcSCD.Width / 2));

            double[] fKernel = Computer.HC_FILTER_GenerateGaussianFilter(2.0, 7);
            rawImage = Computer.HC_FILTER_ConvolutionWindow(fKernel, rawImage, imageW, imageH, rcBoundFirst);
            rawImage = Computer.HC_FILTER_ConvolutionWindow(fKernel, rawImage, imageW, imageH, rcBoundSecon);

            int regionW = (int)(rcFST.Width);
            int regionH = (int)(rcFST.Height);
            // first and second region size = absolutely equivalent!! 

            double fDistance = 0;

            byte[] cropFirst = null;
            byte[] cropSecon = null;

            //********************************************************
            // Get base axis for each digonal rectangle points 

            #region GET DIGONAL BASE LINE
            if (this.measure_FST == IFX_MEASURE_TYPE.DIR_INFALL ||
                this.measure_FST == IFX_MEASURE_TYPE.DIR_INRISE)
            {
                listEdgesFST = CLine.GetLyingPointsFromVariationY(rcFST.LT, rcFST.LB);
                cropFirst = new byte[regionW * listEdgesFST.Count];
            }
            else if (this.measure_FST == IFX_MEASURE_TYPE.DIR_EXFALL ||
                     this.measure_FST == IFX_MEASURE_TYPE.DIR_EXRISE)
            {
                listEdgesFST = CLine.GetLyingPointsFromVariationY(rcFST.RT, rcFST.RB);
                cropFirst = new byte[regionW * listEdgesFST.Count];
            }

            if (this.measure_SCD == IFX_MEASURE_TYPE.DIR_INFALL ||
                this.measure_SCD == IFX_MEASURE_TYPE.DIR_INRISE)
            {
                listEdgesSCD = CLine.GetLyingPointsFromVariationY(rcSCD.RT, rcSCD.RB);
                cropSecon = new byte[regionW * listEdgesSCD.Count];
            }
            else if (this.measure_SCD == IFX_MEASURE_TYPE.DIR_EXFALL ||
                     this.measure_SCD == IFX_MEASURE_TYPE.DIR_EXRISE)
            {
                listEdgesSCD = CLine.GetLyingPointsFromVariationY(rcSCD.LT, rcSCD.LB);
                cropSecon = new byte[regionW * listEdgesSCD.Count];
            }

            #endregion

            //****************************************************************
            // Get fucking target regions

            #region GET TARGET REGION
            for (int y = 0; y < listEdgesFST.Count; y++)
            {
                int imgX = (int)listEdgesFST.ElementAt(y).X;
                int imgY = (int)listEdgesFST.ElementAt(y).Y;

                List<PointF> listSingleLines = new List<PointF>();

                if (this.measure_FST == IFX_MEASURE_TYPE.DIR_INFALL ||
                    this.measure_FST == IFX_MEASURE_TYPE.DIR_INRISE)
                {
                    for (int x = (int)imgX, nIndex = 0; x < (int)imgX + regionW; x++)
                    {
                        listSingleLines.Add(new PointF(x, imgY));
                        cropFirst[y * regionW + nIndex++] = rawImage[imgY * imageW + x];
                    }
                }
                else if (this.measure_FST == IFX_MEASURE_TYPE.DIR_EXFALL ||
                         this.measure_FST == IFX_MEASURE_TYPE.DIR_EXRISE)
                {
                    for (int x = (int)imgX, nIndex = 0; x > (int)imgX - regionW; x--)
                    {
                        cropFirst[y * regionW + nIndex++] = rawImage[imgY * imageW + x];
                    }
                }
            }
            for (int y = 0; y < listEdgesSCD.Count; y++)
            {
                int imgX = (int)listEdgesSCD.ElementAt(y).X;
                int imgY = (int)listEdgesSCD.ElementAt(y).Y;

                if (this.measure_SCD == IFX_MEASURE_TYPE.DIR_INFALL ||
                    this.measure_SCD == IFX_MEASURE_TYPE.DIR_INRISE)
                {
                    for (int x = (int)imgX, nIndex = 0; x > (int)imgX - regionW; x--)
                    {
                        cropSecon[y * regionW + nIndex++] = rawImage[imgY * imageW + x];
                    }
                }
                else if (this.measure_SCD == IFX_MEASURE_TYPE.DIR_EXFALL ||
                         this.measure_SCD == IFX_MEASURE_TYPE.DIR_EXRISE)
                {
                    for (int x = (int)imgX, nIndex = 0; x < (int)imgX + regionW; x++)
                    {
                        cropSecon[y * regionW + nIndex++] = rawImage[imgY * imageW + x];
                    }
                }
            }
            #endregion

            //******************************************************************************
            // Edge extraction 

            List<PointF> listEdgesFirst = new List<PointF>();
            List<PointF> listEdgesSecon = new List<PointF>();

            #region GET EDGES IN DETAIL
            if (this.measure_FST == IFX_MEASURE_TYPE.DIR_INFALL)
            {
                List<PointF> list = Computer.Get2ndDerivativeList_HorMax(cropFirst, regionW, listEdgesFST.Count);

                for (int y = 0; y < listEdgesFST.Count; y++)
                {
                    PointF ptEdge = listEdgesFST.ElementAt(y);
                    ptEdge.X += list.ElementAt(y).X;
                    listEdgesFirst.Add(ptEdge);
                }
            }
            else if (this.measure_FST == IFX_MEASURE_TYPE.DIR_INRISE)
            {
                List<PointF> list = Computer.Get2ndDerivativeList_HorMin(cropFirst, regionW, listEdgesFST.Count);
                for (int y = 0; y < listEdgesFST.Count; y++)
                {
                    PointF ptEdge = listEdgesFST.ElementAt(y);
                    ptEdge.X += list.ElementAt(y).X;
                    listEdgesFirst.Add(ptEdge);
                }
            }
            else if (this.measure_FST == IFX_MEASURE_TYPE.DIR_EXFALL)
            {
                List<PointF> list = Computer.Get2ndDerivativeList_HorMax(cropFirst, regionW, listEdgesFST.Count);
                for (int y = 0; y < listEdgesFST.Count; y++)
                {
                    PointF ptEdge = listEdgesFST.ElementAt(y);
                    ptEdge.X -= list.ElementAt(y).X;
                    listEdgesFirst.Add(ptEdge);
                }
            }
            else if (this.measure_FST == IFX_MEASURE_TYPE.DIR_EXRISE)
            {
                List<PointF> list = Computer.Get2ndDerivativeList_HorMin(cropFirst, regionW, listEdgesFST.Count);
                for (int y = 0; y < listEdgesFST.Count; y++)
                {
                    PointF ptEdge = listEdgesFST.ElementAt(y);
                    ptEdge.X -= list.ElementAt(y).X;
                    listEdgesFirst.Add(ptEdge);
                }
            }

            //***************************************************************************************************

            if (this.measure_SCD == IFX_MEASURE_TYPE.DIR_INFALL)
            {
                List<PointF> list = Computer.Get2ndDerivativeList_HorMax(cropSecon, regionW, listEdgesSCD.Count);
                for (int y = 0; y < listEdgesSCD.Count; y++)
                {
                    PointF ptEdge = listEdgesSCD.ElementAt(y);
                    ptEdge.X -= list.ElementAt(y).X;
                    listEdgesSecon.Add(ptEdge);
                }
            }
            else if (this.measure_SCD == IFX_MEASURE_TYPE.DIR_INRISE)
            {
                List<PointF> list = Computer.Get2ndDerivativeList_HorMin(cropSecon, regionW, listEdgesSCD.Count);
                for (int y = 0; y < listEdgesSCD.Count; y++)
                {
                    PointF ptEdge = listEdgesSCD.ElementAt(y);
                    ptEdge.X -= list.ElementAt(y).X;
                    listEdgesSecon.Add(ptEdge);
                }
            }
            else if (this.measure_SCD == IFX_MEASURE_TYPE.DIR_EXFALL)
            {
                List<PointF> list = Computer.Get2ndDerivativeList_HorMax(cropSecon, regionW, listEdgesSCD.Count);
                for (int y = 0; y < listEdgesSCD.Count; y++)
                {
                    PointF ptEdge = listEdgesSCD.ElementAt(y);
                    ptEdge.X += list.ElementAt(y).X;
                    listEdgesSecon.Add(ptEdge);
                }
            }
            else if (this.measure_SCD == IFX_MEASURE_TYPE.DIR_EXRISE)
            {
                List<PointF> list = Computer.Get2ndDerivativeList_HorMin(cropSecon, regionW, listEdgesSCD.Count);
                for (int y = 0; y < listEdgesSCD.Count; y++)
                {
                    PointF ptEdge = listEdgesSCD.ElementAt(y);
                    ptEdge.X += list.ElementAt(y).X;
                    listEdgesSecon.Add(ptEdge);
                }
            }

            #endregion

            listEdgesFST.Clear();
            listEdgesSCD.Clear();

            // fit line first
            CLine line1 = CLine.GetFitLineHOR(listEdgesFirst);
            CLine line2 = CLine.GetFitLineHOR(listEdgesSecon);

            // line filtering
            listEdgesFST = CLine.GetFilteredFitLineFromVariationY(line1, listEdgesFirst);
            listEdgesSCD = CLine.GetFilteredFitLineFromVariationY(line2, listEdgesSecon);

            // fit again
            line1 = CLine.GetFitLineHOR(listEdgesFST);
            line2 = CLine.GetFitLineHOR(listEdgesSCD);

            line1 = line1.GetExpandedLine_CrossLineBased(line1, rcFST.LT, rcFST.RT, rcFST.LB, rcFST.RB);
            line2 = line2.GetExpandedLine_CrossLineBased(line2, rcSCD.LT, rcSCD.RT, rcSCD.LB, rcSCD.RB);

            if (SHOW_RAW_DATA == true)
            {
                listEdgesFST = listEdgesFirst;
                listEdgesSCD = listEdgesSecon;
            }
            else
            {
                listEdgesFST = CLine.GetLyingPointsFromVariationY(line1);
                listEdgesSCD = CLine.GetLyingPointsFromVariationY(line2);
            }
            
            fDistance = CPoint.GetDistance(line1.CENTER, line2.CENTER);
           
            return Convert.ToSingle(fDistance);
        }
        public override float rape_idiot_ZeroCross(byte[] rawImage, int imageW, int imageH, ref List<PointF> listEdgesFST, ref List<PointF> listEdgesSCD)
        {
            parseRect rcFST = GetCompensatedRect_FST();
            parseRect rcSCD = GetCompensatedRect_SCD();

            Rectangle rcBoundFirst = Rectangle.Round(rcFST.GetBoundingRect());
            Rectangle rcBoundSecon = Rectangle.Round(rcSCD.GetBoundingRect());

            rcBoundFirst.Inflate((int)(rcFST.Width / 2), (int)(rcFST.Width / 2));
            rcBoundSecon.Inflate((int)(rcSCD.Width / 2), (int)(rcSCD.Width / 2));

            double[] fKernel = Computer.HC_FILTER_GenerateGaussianFilter(2.0, 7);
            rawImage = Computer.HC_FILTER_ConvolutionWindow(fKernel, rawImage, imageW, imageH, rcBoundFirst);
            rawImage = Computer.HC_FILTER_ConvolutionWindow(fKernel, rawImage, imageW, imageH, rcBoundSecon);

            int regionW = (int)(rcFST.Width * 1.5);
            // first and second region size = absolutely equivalent!! 

            double fDistance = 0;

            byte[] cropFirst = null;
            byte[] cropSecon = null;

            //********************************************************
            // Get base axis for each digonal rectangle points 
            #region GET DIGONAL BASE LINE
            listEdgesFST = CLine.GetLyingPointsFromVariationY(rcFST.LT, rcFST.LB);
            cropFirst = new byte[regionW * listEdgesFST.Count];

            listEdgesSCD = CLine.GetLyingPointsFromVariationY(rcSCD.RT, rcSCD.RB);
            cropSecon = new byte[regionW * listEdgesSCD.Count];
            #endregion

            //****************************************************************
            // Get fucking target regions

            #region GET TARGET REGION
            for (int y = 0; y < listEdgesFST.Count; y++)
            {
                int imgX = (int)listEdgesFST.ElementAt(y).X;
                int imgY = (int)listEdgesFST.ElementAt(y).Y;

                for (int x = (int)imgX, nIndex = 0; x < (int)imgX + regionW; x++)
                {
                    cropFirst[y * regionW + nIndex++] = rawImage[imgY * imageW + x];
                }
            }
            for (int y = 0; y < listEdgesSCD.Count; y++)
            {
                int imgX = (int)listEdgesSCD.ElementAt(y).X;
                int imgY = (int)listEdgesSCD.ElementAt(y).Y;

                {
                    for (int x = (int)imgX, nIndex = 0; x > (int)imgX - regionW; x--)
                    {
                        cropSecon[y * regionW + nIndex++] = rawImage[imgY * imageW + x];
                    }
                }
            }
            #endregion

            byte[] buffLFT = new byte[regionW];
            byte[] buffRHT = new byte[regionW];

            List<PointF> listEdgesFirst = new List<PointF>();
            List<PointF> listEdgesSecon = new List<PointF>();

            #region GET EDGES IN DETAIL
            for (int y = 0; y < listEdgesFST.Count; y++)
            {
                Array.Clear(buffLFT, 0, buffLFT.Length);
                for (int x = 0; x < regionW; x++){buffLFT[x] = cropFirst[y*regionW+x];}

                double fSubPos = Computer.GetZeroCrossingPt(buffLFT, (int)this.DIR_FST, this.ZC_MAG);

                if (fSubPos != 0)
                {
                    PointF pt = listEdgesFST.ElementAt(y);
                    pt.X += (float)fSubPos;
                    listEdgesFirst.Add(pt);
                }
            }

            for (int y = 0; y < listEdgesSCD.Count; y++)
            {
                Array.Clear(buffRHT, 0, buffRHT.Length);
                for (int x = 0; x < regionW; x++) {buffRHT[x] = cropSecon[y*regionW+x];}

                double fSubPos = Computer.GetZeroCrossingPt(buffRHT, (int)this.DIR_SCD, this.ZC_MAG);
                if (fSubPos != 0)
                {
                    PointF pt = listEdgesSCD.ElementAt(y);
                    pt.X -= (float)fSubPos;
                    listEdgesSecon.Add(pt);
                }
            }
            #endregion

            listEdgesFST.Clear();
            listEdgesSCD.Clear();

            // fit line first
            CLine line1 = CLine.GetFitLineHOR(listEdgesFirst);
            CLine line2 = CLine.GetFitLineHOR(listEdgesSecon);

            // line filtering
            listEdgesFST = CLine.GetFilteredFitLineFromVariationY(line1, listEdgesFirst);
            listEdgesSCD = CLine.GetFilteredFitLineFromVariationY(line2, listEdgesSecon);

            // fit again
            line1 = CLine.GetFitLineHOR(listEdgesFST);
            line2 = CLine.GetFitLineHOR(listEdgesSCD);

            line1 = line1.GetExpandedLine_CrossLineBased(line1, rcFST.LT, rcFST.RT, rcFST.LB, rcFST.RB);
            line2 = line2.GetExpandedLine_CrossLineBased(line2, rcSCD.LT, rcSCD.RT, rcSCD.LB, rcSCD.RB);

            if (SHOW_RAW_DATA == true)
            {
                listEdgesFST = listEdgesFirst;
                listEdgesSCD = listEdgesSecon;
            }
            else
            {
                listEdgesFST = CLine.GetLyingPointsFromVariationY(line1);
                listEdgesSCD = CLine.GetLyingPointsFromVariationY(line2);
            }

            fDistance = CPoint.GetDistance(line1.CENTER, line2.CENTER);

            return Convert.ToSingle(fDistance);
        }
        public override float rape_asshole_Log(byte[] rawImage, int imageW, int imageH, ref List<PointF> listEdgesFST, ref List<PointF> listEdgesSCD)
        {
            parseRect rcFST = GetCompensatedRect_FST();
            parseRect rcSCD = GetCompensatedRect_SCD();

            Rectangle rcBoundFirst = Rectangle.Round(rcFST.GetBoundingRect());
            Rectangle rcBoundSecon = Rectangle.Round(rcSCD.GetBoundingRect());

            rcBoundFirst.Inflate((int)(rcFST.Width / 2), (int)(rcFST.Width / 2));
            rcBoundSecon.Inflate((int)(rcSCD.Width / 2), (int)(rcSCD.Width / 2));

            double[] fKernel = Computer.HC_FILTER_GenerateGaussianFilter(2.0, 7);
            rawImage = Computer.HC_FILTER_ConvolutionWindow(fKernel, rawImage, imageW, imageH, rcBoundFirst);
            rawImage = Computer.HC_FILTER_ConvolutionWindow(fKernel, rawImage, imageW, imageH, rcBoundSecon);

            int regionW = (int)(rcFST.Width * 1.5);

            double fDistance = 0;

            // first and second region size = absolutely equivalent!! 

            //********************************************************
            // Get base axis for each digonal rectangle points 

            listEdgesFST = CLine.GetLyingPointsFromVariationY(rc_FST.LT, rc_FST.LB);
            listEdgesSCD = CLine.GetLyingPointsFromVariationY(rc_SCD.RT, rc_SCD.RB);

            //****************************************************************
            // Get fucking target regions

            PointF[] arrTargetPoints_EX = new PointF[regionW];

            List<PointF> listEdgesFirst = new List<PointF>();
            List<PointF> listEdgesSecon = new List<PointF>();

            for (int y = 0; y < listEdgesFST.Count; y++)
            {
                int imgX = (int)listEdgesFST.ElementAt(y).X;
                int imgY = (int)listEdgesFST.ElementAt(y).Y;

                Array.Clear(arrTargetPoints_EX, 0, arrTargetPoints_EX.Length);
                for (int x = (int)imgX, nIndex = 0; x < (int)imgX + regionW; x++)
                {
                    arrTargetPoints_EX[nIndex++] = new PointF(x, imgY);
                }

                double fSubPos = 0;
                fSubPos = Computer.GetLogPos(rawImage, imageW, imageH, arrTargetPoints_EX, (int)this.DIR_FST);


                listEdgesFirst.Add(new PointF(listEdgesFST.ElementAt(y).X + (float)fSubPos, imgY));
            }

            PointF[] arrTargetPoints_IN = new PointF[regionW];
            for (int y = 0; y < listEdgesSCD.Count; y++)
            {
                int imgX = (int)listEdgesSCD.ElementAt(y).X;
                int imgY = (int)listEdgesSCD.ElementAt(y).Y;

                Array.Clear(arrTargetPoints_IN, 0, arrTargetPoints_IN.Length);
                for (int x = (int)imgX, nIndex = 0; x > (int)imgX - regionW; x--)
                {
                    arrTargetPoints_IN[nIndex++] = new PointF(x, imgY);
                }

                double fSubPos = 0;
                fSubPos = Computer.GetLogPos(rawImage, imageW, imageH, arrTargetPoints_IN, (int)this.DIR_SCD);

                listEdgesSecon.Add(new PointF(listEdgesSCD.ElementAt(y).X - (float)fSubPos, imgY));
            }

            listEdgesFST.Clear();
            listEdgesSCD.Clear();


            //CModelLine model_Edges_FST = new CModelLine();
            //CModelLine model_Edges_SCD = new CModelLine();
            //
            //CRansac.ransac_Line_fitting(listEdgesFirst.ToArray(), ref model_Edges_FST, PARAM_FITTING_THR);
            //CRansac.ransac_Line_fitting(listEdgesSecon.ToArray(), ref model_Edges_SCD, PARAM_FITTING_THR);
            //
            //
            //float fHalf_FST = Convert.ToSingle(rcFST.Height / 2.0);
            //float fHalf_SCD = Convert.ToSingle(rcSCD.Height / 2.0);
            //
            //PointF p1_FST = new PointF(Convert.ToSingle(model_Edges_FST.sx - fHalf_FST * model_Edges_FST.mx), Convert.ToSingle(model_Edges_FST.sy - fHalf_FST * model_Edges_FST.my));
            //PointF p2_FST = new PointF(Convert.ToSingle(model_Edges_FST.sx + fHalf_FST * model_Edges_FST.mx), Convert.ToSingle(model_Edges_FST.sy + fHalf_FST * model_Edges_FST.my));
            //
            //PointF p1_SCD = new PointF(Convert.ToSingle(model_Edges_SCD.sx - fHalf_SCD * model_Edges_SCD.mx), Convert.ToSingle(model_Edges_SCD.sy - fHalf_SCD * model_Edges_SCD.my));
            //PointF p2_SCD = new PointF(Convert.ToSingle(model_Edges_SCD.sx + fHalf_SCD * model_Edges_SCD.mx), Convert.ToSingle(model_Edges_SCD.sy + fHalf_SCD * model_Edges_SCD.my));
            //
            //
            //CLine line1 = new CLine(p1_FST, p2_FST);
            //CLine line2 = new CLine(p1_SCD, p2_SCD);
          
            // fit line first
            CLine line1 = CLine.GetFitLineHOR(listEdgesFirst);
            CLine line2 = CLine.GetFitLineHOR(listEdgesSecon);

            // line filtering
            listEdgesFST = CLine.GetFilteredFitLineFromVariationY(line1, listEdgesFirst);
            listEdgesSCD = CLine.GetFilteredFitLineFromVariationY(line2, listEdgesSecon);

            // fit again
            line1 = CLine.GetFitLineHOR(listEdgesFST);
            line2 = CLine.GetFitLineHOR(listEdgesSCD);

            line1 = line1.GetExpandedLine_CrossLineBased(line1, rcFST.LT, rcFST.RT, rcFST.LB, rcFST.RB);
            line2 = line2.GetExpandedLine_CrossLineBased(line2, rcSCD.LT, rcSCD.RT, rcSCD.LB, rcSCD.RB);

            if (SHOW_RAW_DATA == true)
            {
                listEdgesFST = listEdgesFirst;
                listEdgesSCD = listEdgesSecon;
            }
            else
            {
                listEdgesFST = CLine.GetLyingPointsFromVariationY(line1);
                listEdgesSCD = CLine.GetLyingPointsFromVariationY(line2);
            }

            fDistance = CPoint.GetDistance(line1.CENTER, line2.CENTER);
            return Convert.ToSingle(fDistance);
        }

        public override float MeasureData(byte[] rawImage, int imageW, int imageH, ref List<PointF> listEdgesFirst, ref List<PointF> listEdgesSecon)
        {
            double fDistance = 0;

            /***/if (this.GetMeasurementCategory() == "PRW") { fDistance = this.rape_Pussy_Overay(rawImage, imageW, imageH, ref listEdgesFirst, ref listEdgesSecon); }
            else if (this.GetMeasurementCategory() == "DIR") { fDistance = this.rape_Bitch_Direction(rawImage, imageW, imageH, ref listEdgesFirst, ref listEdgesSecon); }
            else if (this.GetMeasurementCategory() == "ZERO") { fDistance = this.rape_idiot_ZeroCross(rawImage, imageW, imageH, ref listEdgesFirst, ref listEdgesSecon); }
            else if (this.GetMeasurementCategory() == "LAPL") { fDistance = this.rape_asshole_Log(rawImage, imageW, imageH, ref listEdgesFirst, ref listEdgesSecon); }

            return Convert.ToSingle(fDistance);
        } 
    }

    public class CMeasurePairOvl : CMeasureMotherFucker
    {
        public CMeasurePairHor RC_VER_IN = new CMeasurePairHor();
        public CMeasurePairHor RC_VER_EX = new CMeasurePairHor();
        public CMeasurePairVer RC_HOR_IN = new CMeasurePairVer();
        public CMeasurePairVer RC_HOR_EX = new CMeasurePairVer();

        public int measureHOR_IN_L { get; set; }
        public int measureHOR_IN_R { get; set; }
        public int measureHOR_EX_L { get; set; }
        public int measureHOR_EX_R { get; set; }

        public int measureVER_IN_T { get; set; }
        public int measureVER_IN_B { get; set; }
        public int measureVER_EX_T { get; set; }
        public int measureVER_EX_B { get; set; }

        public int ZigZagIN { get; set; }
        public int ZigZagEX { get; set; }

        public double DIR_HOR_IN_L { get; set; }
        public double DIR_HOR_IN_R { get; set; }
        public double DIR_HOR_EX_L { get; set; }
        public double DIR_HOR_EX_R { get; set; }

        public double DIR_VER_IN_T { get; set; }
        public double DIR_VER_IN_B { get; set; }
        public double DIR_VER_EX_T { get; set; }
        public double DIR_VER_EX_B { get; set; }
        
        public double ZC_MAG_HOR_IN_L { get; set; }
        public double ZC_MAG_HOR_IN_R { get; set; }
        public double ZC_MAG_HOR_EX_L { get; set; }
        public double ZC_MAG_HOR_EX_R { get; set; }

        public double ZC_MAG_VER_IN_T { get; set; }
        public double ZC_MAG_VER_IN_B { get; set; }
        public double ZC_MAG_VER_EX_T { get; set; }
        public double ZC_MAG_VER_EX_B { get; set; }

        public CMeasurePairOvl()
        {
            ZigZagEX = ZigZagIN = 0;
            NICKNAME = "OVL";
            measureHOR_IN_L = measureHOR_IN_R = measureVER_IN_T = measureVER_IN_B = 0;
            DIR_HOR_IN_L = DIR_HOR_IN_R = DIR_HOR_EX_L = DIR_HOR_EX_R = DIR_VER_IN_T = DIR_VER_IN_B = DIR_VER_EX_T = DIR_VER_EX_B = 0;
            ZC_MAG_HOR_IN_L = ZC_MAG_HOR_IN_R = ZC_MAG_HOR_EX_L = ZC_MAG_HOR_EX_R = ZC_MAG_VER_IN_T = ZC_MAG_VER_IN_B = ZC_MAG_VER_EX_T = ZC_MAG_VER_EX_B = 0;
            SHOW_RAW_DATA = false;
        }

        public CMeasurePairOvl CopyTo()
        {
            CMeasurePairOvl single = new CMeasurePairOvl();

            single.ptOrientBase = this.ptOrientBase;
            single.ptOrientCurr = this.ptOrientCurr;

            single.RC_HOR_IN = this.RC_HOR_IN.CopyTo();
            single.RC_HOR_EX = this.RC_HOR_EX.CopyTo();
            single.RC_VER_IN = this.RC_VER_IN.CopyTo();
            single.RC_VER_EX = this.RC_VER_EX.CopyTo();

            single.measureHOR_IN_L = this.measureHOR_IN_L;
            single.measureHOR_IN_R = this.measureHOR_IN_R;
            single.measureHOR_EX_L = this.measureHOR_EX_L;
            single.measureHOR_EX_R = this.measureHOR_EX_R;

            single.measureVER_IN_T = this.measureVER_IN_T;
            single.measureVER_IN_B = this.measureVER_IN_B;
            single.measureVER_EX_T = this.measureVER_EX_T;
            single.measureVER_EX_B = this.measureVER_EX_B;

            single.ZigZagIN = this.ZigZagIN;
            single.ZigZagEX = this.ZigZagEX;

            single.NICKNAME = this.NICKNAME;
            single.DIR_HOR_IN_L = this.DIR_HOR_IN_L;
            single.DIR_HOR_IN_R = this.DIR_HOR_IN_R;
            single.DIR_HOR_EX_L = this.DIR_HOR_EX_L;
            single.DIR_HOR_EX_R = this.DIR_HOR_EX_R;

            single.DIR_VER_IN_T = this.DIR_VER_IN_T;
            single.DIR_VER_IN_B = this.DIR_VER_IN_B;
            single.DIR_VER_EX_T = this.DIR_VER_EX_T;
            single.DIR_VER_EX_B = this.DIR_VER_EX_B;

            single.ZC_MAG_HOR_IN_L = this.ZC_MAG_HOR_IN_L;
            single.ZC_MAG_HOR_IN_R = this.ZC_MAG_HOR_IN_R;
            single.ZC_MAG_HOR_EX_L = this.ZC_MAG_HOR_EX_L;
            single.ZC_MAG_HOR_EX_R = this.ZC_MAG_HOR_EX_R;

            single.ZC_MAG_VER_IN_T = this.ZC_MAG_VER_IN_T;
            single.ZC_MAG_VER_IN_B = this.ZC_MAG_VER_IN_B;
            single.ZC_MAG_VER_EX_T = this.ZC_MAG_VER_EX_T;
            single.ZC_MAG_VER_EX_B = this.ZC_MAG_VER_EX_B;

            single.SHOW_RAW_DATA = this.SHOW_RAW_DATA;

            return single;
        }

        public PointF GetCenter()
        {
            RectangleF rcIN_LFT = this.RC_HOR_IN.rc_LFT;
            RectangleF rcIN_RHT = this.RC_HOR_IN.rc_RHT;
            RectangleF rcIN_TOP = this.RC_VER_IN.rc_TOP;
            RectangleF rcIN_BTM = this.RC_VER_IN.rc_BTM;

            float lcx = CRect.GetCenter(rcIN_LFT).X;
            float rcx = CRect.GetCenter(rcIN_RHT).X;
            float tcy = CRect.GetCenter(rcIN_TOP).Y;
            float bcy = CRect.GetCenter(rcIN_BTM).Y;

            float cx = Convert.ToSingle(lcx + ((rcx - lcx) / 2.0));
            float cy = Convert.ToSingle(tcy + ((bcy - tcy) / 2.0));

            return new PointF(cx, cy);
        }

        public override void SetRelativeOrigin(PointF ptOrigin)
        {
            this.ptOrientCurr = ptOrigin;
        }
        

        public override string GetMeasurementCategory()
        {
            // Overlay Position 별 Setting Value가 다를 수 있으니,,, 
            // Multi case로 대응해야 되겠다.  170412 

            //return IFX_MEASURE_TYPE.ToStringType(measure_LFT).Split('_')[0];
            return string.Empty;
        }
        public override void SetRelativeCroodinates(PointF ptGravity)
        {
            // if preserved value exists --> recover 
            if (this.ptOrientBase.X != 0 && this.ptOrientBase.Y != 0)
            {
                RC_HOR_IN.rc_LFT.Offset(ptOrientBase);
                RC_HOR_IN.rc_RHT.Offset(ptOrientBase);
                RC_HOR_EX.rc_LFT.Offset(ptOrientBase);
                RC_HOR_EX.rc_RHT.Offset(ptOrientBase);

                RC_VER_IN.rc_TOP.Offset(ptOrientBase);
                RC_VER_IN.rc_BTM.Offset(ptOrientBase);
                RC_VER_EX.rc_TOP.Offset(ptOrientBase);
                RC_VER_EX.rc_BTM.Offset(ptOrientBase);
            }

            // update new original point
            this.ptOrientBase = ptGravity;

            // get relative distance 
            PointF ptDist_HOR_IN_RC_LFT = CPoint.GetDistancePoint(RC_HOR_IN.rc_LFT.Location, ptGravity);
            PointF ptDist_HOR_IN_RC_RHT = CPoint.GetDistancePoint(RC_HOR_IN.rc_RHT.Location, ptGravity);
            PointF ptDist_HOR_EX_RC_LFT = CPoint.GetDistancePoint(RC_HOR_EX.rc_LFT.Location, ptGravity);
            PointF ptDist_HOR_EX_RC_RHT = CPoint.GetDistancePoint(RC_HOR_EX.rc_RHT.Location, ptGravity);

            PointF ptDist_VER_IN_RC_TOP = CPoint.GetDistancePoint(RC_VER_IN.rc_TOP.Location, ptGravity);
            PointF ptDist_VER_IN_RC_BTM = CPoint.GetDistancePoint(RC_VER_IN.rc_BTM.Location, ptGravity);
            PointF ptDist_VER_EX_RC_TOP = CPoint.GetDistancePoint(RC_VER_EX.rc_TOP.Location, ptGravity);
            PointF ptDist_VER_EX_RC_BTM = CPoint.GetDistancePoint(RC_VER_EX.rc_BTM.Location, ptGravity);

            // set relative distance 

            this.RC_HOR_IN.rc_LFT = CRect.ReplaceOrigin(this.RC_HOR_IN.rc_LFT, ptDist_HOR_IN_RC_LFT);
            this.RC_HOR_IN.rc_RHT = CRect.ReplaceOrigin(this.RC_HOR_IN.rc_RHT, ptDist_HOR_IN_RC_RHT);
            this.RC_HOR_EX.rc_LFT = CRect.ReplaceOrigin(this.RC_HOR_EX.rc_LFT, ptDist_HOR_EX_RC_LFT);
            this.RC_HOR_EX.rc_RHT = CRect.ReplaceOrigin(this.RC_HOR_EX.rc_RHT, ptDist_HOR_EX_RC_RHT);

            this.RC_VER_IN.rc_TOP = CRect.ReplaceOrigin(this.RC_VER_IN.rc_TOP, ptDist_VER_IN_RC_TOP);
            this.RC_VER_IN.rc_BTM = CRect.ReplaceOrigin(this.RC_VER_IN.rc_BTM, ptDist_VER_IN_RC_BTM);
            this.RC_VER_EX.rc_TOP = CRect.ReplaceOrigin(this.RC_VER_EX.rc_TOP, ptDist_VER_EX_RC_TOP);
            this.RC_VER_EX.rc_BTM = CRect.ReplaceOrigin(this.RC_VER_EX.rc_BTM, ptDist_VER_EX_RC_BTM);

        }
        public override bool VeryfyMeasurementMatching()
        {
            // 이새끼도 Position 별로 세팅 값이 다를 수 있으므로 멀티 로 해야되겠네 . 젠장. 

            // rape techniques have to be same 
            //string measL = IFX_MEASURE_TYPE.ToStringType(measure_LFT).Split('_')[0];
            //string measR = IFX_MEASURE_TYPE.ToStringType(measure_LFT).Split('_')[0];
            //
            //if (measL != measR) return false;

            return true;
        }


        public override void AdjustGap(int tx, int ty) { throw new NotImplementedException(); }
        public override void AdjustPos(int tx, int ty) { throw new NotImplementedException(); }
        public override void AdjustSize(int tx, int ty) {throw new NotImplementedException(); }

        public void AdjustPos_IN(int nDir, int nScale)
        {
            float fScale = Convert.ToSingle(nScale);

            if (nDir == IFX_DIR.DIR_LFT)
            {
                this.RC_HOR_IN.rc_LFT.X -= fScale;
                this.RC_HOR_IN.rc_RHT.X -= fScale;
                this.RC_VER_IN.rc_TOP.X -= fScale;
                this.RC_VER_IN.rc_BTM.X -= fScale;
            }
            else if (nDir == IFX_DIR.DIR_TOP)
            {
                this.RC_HOR_IN.rc_LFT.Y -= fScale;
                this.RC_HOR_IN.rc_RHT.Y -= fScale;
                this.RC_VER_IN.rc_TOP.Y -= fScale;
                this.RC_VER_IN.rc_BTM.Y -= fScale;
            }
            else if (nDir == IFX_DIR.DIR_RHT)
            {
                this.RC_HOR_IN.rc_LFT.X += fScale;
                this.RC_HOR_IN.rc_RHT.X += fScale;
                this.RC_VER_IN.rc_TOP.X += fScale;
                this.RC_VER_IN.rc_BTM.X += fScale;
            }
            else if (nDir == IFX_DIR.DIR_BTM)
            {
                this.RC_HOR_IN.rc_LFT.Y += fScale;
                this.RC_HOR_IN.rc_RHT.Y += fScale;
                this.RC_VER_IN.rc_TOP.Y += fScale;
                this.RC_VER_IN.rc_BTM.Y += fScale;
            }

        }
        public void AdjustPos_EX(int nDir, int nScale)
        {
            float fScale = Convert.ToSingle(nScale);

            if (nDir == IFX_DIR.DIR_LFT)
            {
                this.RC_HOR_EX.rc_LFT.X -= fScale;
                this.RC_HOR_EX.rc_RHT.X -= fScale;
                this.RC_VER_EX.rc_TOP.X -= fScale;
                this.RC_VER_EX.rc_BTM.X -= fScale;
            }
            else if (nDir == IFX_DIR.DIR_TOP)
            {
                this.RC_HOR_EX.rc_LFT.Y -= fScale;
                this.RC_HOR_EX.rc_RHT.Y -= fScale;
                this.RC_VER_EX.rc_TOP.Y -= fScale;
                this.RC_VER_EX.rc_BTM.Y -= fScale;
            }
            else if (nDir == IFX_DIR.DIR_RHT)
            {
                this.RC_HOR_EX.rc_LFT.X += fScale;
                this.RC_HOR_EX.rc_RHT.X += fScale;
                this.RC_VER_EX.rc_TOP.X += fScale;
                this.RC_VER_EX.rc_BTM.X += fScale;
            }
            else if (nDir == IFX_DIR.DIR_BTM)
            {
                this.RC_HOR_EX.rc_LFT.Y += fScale;
                this.RC_HOR_EX.rc_RHT.Y += fScale;
                this.RC_VER_EX.rc_TOP.Y += fScale;
                this.RC_VER_EX.rc_BTM.Y += fScale;
            }

        }

        public void AdjustGap_IN(int nDir, int nScale)
        {
            float fScale = Convert.ToSingle(nScale / 2.0);

            if (nDir == IFX_DIR.DIR_LFT)
            {
                this.RC_HOR_IN.rc_LFT.X += fScale;
                this.RC_HOR_IN.rc_RHT.X -= fScale;
            }
            else if (nDir == IFX_DIR.DIR_TOP)
            {
                this.RC_VER_IN.rc_TOP.Y += fScale;
                this.RC_VER_IN.rc_BTM.Y -= fScale;
            }
            else if (nDir == IFX_DIR.DIR_RHT)
            {
                this.RC_HOR_IN.rc_LFT.X -= fScale;
                this.RC_HOR_IN.rc_RHT.X += fScale;
            }
            else if (nDir == IFX_DIR.DIR_BTM)
            {
                this.RC_VER_IN.rc_TOP.Y -= fScale;
                this.RC_VER_IN.rc_BTM.Y += nScale;
            }
        }
        public void AdjustGap_EX(int nDir, int nScale)
        {
            float fScale = Convert.ToSingle(nScale / 2.0);

            if (nDir == IFX_DIR.DIR_LFT)
            {
                this.RC_HOR_EX.rc_LFT.X += fScale;
                this.RC_HOR_EX.rc_RHT.X -= fScale;
            }
            else if (nDir == IFX_DIR.DIR_TOP)
            {
                this.RC_VER_EX.rc_TOP.Y += fScale;
                this.RC_VER_EX.rc_BTM.Y -= fScale;
            }
            else if (nDir == IFX_DIR.DIR_RHT)
            {
                this.RC_HOR_EX.rc_LFT.X -= fScale;
                this.RC_HOR_EX.rc_RHT.X += fScale;
            }
            else if (nDir == IFX_DIR.DIR_BTM)
            {
                this.RC_VER_EX.rc_TOP.Y -= fScale;
                this.RC_VER_EX.rc_BTM.Y += nScale;
            }
        }

        public void AdjustSize_IN(int nDir, int nScale)
        {
            float fScale = Convert.ToSingle(nScale);
            float fPos = Convert.ToSingle(fScale / 2.0);

            if (nDir == IFX_DIR.DIR_LFT)
            {
                this.RC_HOR_IN.rc_LFT.Height -= fScale;
                this.RC_HOR_IN.rc_RHT.Height -= fScale;
                this.RC_VER_IN.rc_TOP.Width -= fScale;
                this.RC_VER_IN.rc_BTM.Width -= fScale;

                this.RC_HOR_IN.rc_LFT.Y += fPos;
                this.RC_HOR_IN.rc_RHT.Y += fPos;
                this.RC_VER_IN.rc_TOP.X += fPos;
                this.RC_VER_IN.rc_BTM.X += fPos;
            }
            else if (nDir == IFX_DIR.DIR_TOP)
            {
                this.RC_HOR_IN.rc_LFT.Width -= fScale;
                this.RC_HOR_IN.rc_RHT.Width -= fScale;
                this.RC_VER_IN.rc_TOP.Height -= fScale;
                this.RC_VER_IN.rc_BTM.Height -= fScale;
            }
            else if (nDir == IFX_DIR.DIR_RHT)
            {
                this.RC_HOR_IN.rc_LFT.Height += fScale;
                this.RC_HOR_IN.rc_RHT.Height += fScale;
                this.RC_VER_IN.rc_TOP.Width += fScale;
                this.RC_VER_IN.rc_BTM.Width += fScale;

                this.RC_HOR_IN.rc_LFT.Y -= fPos;
                this.RC_HOR_IN.rc_RHT.Y -= fPos;
                this.RC_VER_IN.rc_TOP.X -= fPos;
                this.RC_VER_IN.rc_BTM.X -= fPos;
            }
            else if (nDir == IFX_DIR.DIR_BTM)
            {
                this.RC_HOR_IN.rc_LFT.Width += fScale;
                this.RC_HOR_IN.rc_RHT.Width += fScale;
                this.RC_VER_IN.rc_TOP.Height += fScale;
                this.RC_VER_IN.rc_BTM.Height += fScale;
            }
        }
        public void AdjustSize_EX(int nDir, int nScale)
        {
            float fScale = Convert.ToSingle(nScale);
            float fPos = Convert.ToSingle(fScale / 2.0);

            if (nDir == IFX_DIR.DIR_LFT)
            {
                this.RC_HOR_EX.rc_LFT.Height -= fScale;
                this.RC_HOR_EX.rc_RHT.Height -= fScale;
                this.RC_VER_EX.rc_TOP.Width -= fScale;
                this.RC_VER_EX.rc_BTM.Width -= fScale;

                this.RC_HOR_EX.rc_LFT.Y += fPos;
                this.RC_HOR_EX.rc_RHT.Y += fPos;
                this.RC_VER_EX.rc_TOP.X += fPos;
                this.RC_VER_EX.rc_BTM.X += fPos;
            }
            else if (nDir == IFX_DIR.DIR_TOP)
            {
                this.RC_HOR_EX.rc_LFT.Width -= fScale;
                this.RC_HOR_EX.rc_RHT.Width -= fScale;
                this.RC_VER_EX.rc_TOP.Height -= fScale;
                this.RC_VER_EX.rc_BTM.Height -= fScale;
            }
            else if (nDir == IFX_DIR.DIR_RHT)
            {
                this.RC_HOR_EX.rc_LFT.Height += fScale;
                this.RC_HOR_EX.rc_RHT.Height += fScale;
                this.RC_VER_EX.rc_TOP.Width  += fScale;
                this.RC_VER_EX.rc_BTM.Width  += fScale;

                this.RC_HOR_EX.rc_LFT.Y -= fPos;
                this.RC_HOR_EX.rc_RHT.Y -= fPos;
                this.RC_VER_EX.rc_TOP.X -= fPos;
                this.RC_VER_EX.rc_BTM.X -= fPos;
            }
            else if (nDir == IFX_DIR.DIR_BTM)
            {
                this.RC_HOR_EX.rc_LFT.Width += fScale;
                this.RC_HOR_EX.rc_RHT.Width += fScale;
                this.RC_VER_EX.rc_TOP.Height += fScale;
                this.RC_VER_EX.rc_BTM.Height += fScale;
            }
        }

        public void AdjustAsym_IN(int nDir, int nScale)
        {
            float fScale = Convert.ToSingle(nScale);

            if (nDir == IFX_DIR.DIR_LFT)
            {
                this.RC_HOR_IN.rc_LFT.Y += fScale;
                this.RC_HOR_IN.rc_RHT.Y -= fScale;
                this.RC_VER_IN.rc_TOP.X -= fScale;
                this.RC_VER_IN.rc_BTM.X += fScale;
            }
            else if (nDir == IFX_DIR.DIR_RHT)
            {
                this.RC_HOR_IN.rc_LFT.Y -= fScale;
                this.RC_HOR_IN.rc_RHT.Y += fScale;
                this.RC_VER_IN.rc_TOP.X += fScale;
                this.RC_VER_IN.rc_BTM.X -= fScale;
            }
            else if (nDir == IFX_DIR.DIR_TOP){}
            else if (nDir == IFX_DIR.DIR_BTM){}
        }
        public void AdjustAsym_EX(int nDir, int nScale)
        {
            float fScale = Convert.ToSingle(nScale);

            if (nDir == IFX_DIR.DIR_LFT)
            {
                this.RC_HOR_EX.rc_LFT.Y += fScale;
                this.RC_HOR_EX.rc_RHT.Y -= fScale;
                this.RC_VER_EX.rc_TOP.X -= fScale;
                this.RC_VER_EX.rc_BTM.X += fScale;
            }
            else if (nDir == IFX_DIR.DIR_RHT)
            {
                this.RC_HOR_EX.rc_LFT.Y -= fScale;
                this.RC_HOR_EX.rc_RHT.Y += fScale;
                this.RC_VER_EX.rc_TOP.X += fScale;
                this.RC_VER_EX.rc_BTM.X -= fScale;
            }
            else if (nDir == IFX_DIR.DIR_TOP){}
            else if (nDir == IFX_DIR.DIR_BTM){}
        }

        public override float rape_asshole_Log(byte[] rawImage, int imageW, int imageH, ref List<PointF> listEdgesFirst, ref List<PointF> listEdgesSecon){throw new NotImplementedException();}
        public override float rape_Bitch_Direction(byte[] rawImage, int imageW, int imageH, ref List<PointF> listEdgesFirst, ref List<PointF> listEdgesSecon){throw new NotImplementedException();}
        public override float rape_idiot_ZeroCross(byte[] rawImage, int imageW, int imageH, ref List<PointF> listEdgesFirst, ref List<PointF> listEdtgesSecon){throw new NotImplementedException();}
        public override float rape_Pussy_Overay(byte[] rawImage, int imageW, int imageH, ref List<PointF> listEdgesFirst, ref List<PointF> listEdgesSecon){throw new NotImplementedException();}

        public override float MeasureData(byte[] rawImage, int imageW, int imageH, ref List<PointF> listEdgesFirst, ref List<PointF> listEdgesSecon)
        {
            throw new NotImplementedException();
        }

        public void raple_MotherFucker(byte[] rawImage, int imageW, int imageH, ref List<PointF> listEdgesHor, ref List<PointF> listEdgesVer, out double fOL_X, out double fOL_Y)
        {
            //*****************************************************************
            // Getting Horizontal Rectangle
            RectangleF rcHOR_EX_LFT = GetCompensatedRect(this.RC_HOR_EX.rc_LFT);
            RectangleF rcHOR_IN_LFT = GetCompensatedRect(this.RC_HOR_IN.rc_LFT);
            RectangleF rcHOR_IN_RHT = GetCompensatedRect(this.RC_HOR_IN.rc_RHT);
            RectangleF rcHOR_EX_RHT = GetCompensatedRect(this.RC_HOR_EX.rc_RHT);

            //*****************************************************************
            // Getting Vertical Rectangle 
            RectangleF rcVER_EX_TOP = GetCompensatedRect(this.RC_VER_EX.rc_TOP);
            RectangleF rcVER_IN_TOP = GetCompensatedRect(this.RC_VER_IN.rc_TOP);
            RectangleF rcVER_IN_BTM = GetCompensatedRect(this.RC_VER_IN.rc_BTM);
            RectangleF rcVER_EX_BTM = GetCompensatedRect(this.RC_VER_EX.rc_BTM);

            List<PointF> listEdges_VER_EX_TOP = new List<PointF>();
            List<PointF> listEdges_VER_IN_TOP = new List<PointF>();
            List<PointF> listEdges_VER_IN_BTM = new List<PointF>();
            List<PointF> listEdges_VER_EX_BTM = new List<PointF>();

            List<PointF> listEdges_HOR_EX_LFT = new List<PointF>();
            List<PointF> listEdges_HOR_IN_LFT = new List<PointF>();
            List<PointF> listEdges_HOR_IN_RHT = new List<PointF>();
            List<PointF> listEdges_HOR_EX_RHT = new List<PointF>();

            //double[] fKernel = Computer.HC_FILTER_GenerateGaussianFilter(1.0, 3);
            //rawImage = Computer.HC_FILTER_ConvolutionWindow(fKernel, rawImage, imageW, imageH, Rectangle.Round(rcVER_EX_TOP));
            //rawImage = Computer.HC_FILTER_ConvolutionWindow(fKernel, rawImage, imageW, imageH, Rectangle.Round(rcVER_EX_BTM));
            //rawImage = Computer.HC_FILTER_ConvolutionWindow(fKernel, rawImage, imageW, imageH, Rectangle.Round(rcVER_IN_TOP));
            //rawImage = Computer.HC_FILTER_ConvolutionWindow(fKernel, rawImage, imageW, imageH, Rectangle.Round(rcVER_IN_BTM));
            //
            //rawImage = Computer.HC_FILTER_ConvolutionWindow(fKernel, rawImage, imageW, imageH, Rectangle.Round(rcHOR_EX_LFT));
            //rawImage = Computer.HC_FILTER_ConvolutionWindow(fKernel, rawImage, imageW, imageH, Rectangle.Round(rcHOR_EX_RHT));
            //rawImage = Computer.HC_FILTER_ConvolutionWindow(fKernel, rawImage, imageW, imageH, Rectangle.Round(rcHOR_IN_LFT));
            //rawImage = Computer.HC_FILTER_ConvolutionWindow(fKernel, rawImage, imageW, imageH, Rectangle.Round(rcHOR_IN_RHT));

            //*************************************************************************************
            // 01 HORIZONTAL - EXTERNAL TOP 
            //*************************************************************************************


            if (this.measureVER_EX_T == IFX_MEASURE_TYPE.DIR_INFALL ||this.measureVER_EX_T == IFX_MEASURE_TYPE.DIR_INRISE ||
                this.measureVER_EX_T == IFX_MEASURE_TYPE.DIR_EXRISE ||this.measureVER_EX_T == IFX_MEASURE_TYPE.DIR_EXFALL)
            {
                listEdges_VER_EX_TOP = GetPointList_Derivative_HOR(rawImage, imageW, imageH, rcVER_EX_TOP, true, this.measureVER_EX_T);
            }
            else if (this.measureVER_EX_T == IFX_MEASURE_TYPE.ZERO_CROSS)
            {
                listEdges_VER_EX_TOP = GetRawPoints_Hor_ZeroCross(rawImage, imageW, imageH, rcVER_EX_TOP, true, (int)this.DIR_VER_EX_T, this.ZC_MAG_VER_EX_T);
            }
            else if (this.measureVER_EX_T == IFX_MEASURE_TYPE.LAPL_GAUSS)
            {
                listEdges_VER_EX_TOP = GetRawPoints_HOR_LOG(rawImage, imageW, imageH, rcVER_EX_TOP, true, (int)this.DIR_VER_EX_T);
            }
            
            //*************************************************************************************
            // 02 HORIZONTAL - INTERNAL TOP
            //*************************************************************************************

            if (this.measureVER_IN_T == IFX_MEASURE_TYPE.DIR_INFALL || this.measureVER_IN_T == IFX_MEASURE_TYPE.DIR_INRISE ||
                this.measureVER_IN_T == IFX_MEASURE_TYPE.DIR_EXRISE || this.measureVER_IN_T == IFX_MEASURE_TYPE.DIR_EXFALL)
            {
                listEdges_VER_IN_TOP = GetPointList_Derivative_HOR(rawImage, imageW, imageH, rcVER_IN_TOP, true, this.measureVER_IN_T);
            }
            else if (this.measureVER_IN_T == IFX_MEASURE_TYPE.ZERO_CROSS)
            {
                listEdges_VER_IN_TOP = GetRawPoints_Hor_ZeroCross(rawImage, imageW, imageH, rcVER_IN_TOP, true, (int)this.DIR_VER_IN_T, this.ZC_MAG_VER_IN_T);
            }
            else if (this.measureVER_IN_T == IFX_MEASURE_TYPE.LAPL_GAUSS)
            {
                listEdges_VER_IN_TOP = GetRawPoints_HOR_LOG(rawImage, imageW, imageH, rcVER_IN_TOP, true, (int)this.DIR_VER_IN_T);
            }

            //*************************************************************************************
            // 03 HORIZONTAL - INTERNAL BTM
            //*************************************************************************************

            if (this.measureVER_IN_B == IFX_MEASURE_TYPE.DIR_INFALL || this.measureVER_IN_B == IFX_MEASURE_TYPE.DIR_INRISE ||
                this.measureVER_IN_B == IFX_MEASURE_TYPE.DIR_EXRISE || this.measureVER_IN_B == IFX_MEASURE_TYPE.DIR_EXFALL)
            {
                listEdges_VER_IN_BTM = GetPointList_Derivative_HOR(rawImage, imageW, imageH, rcVER_IN_BTM, false, this.measureVER_IN_B);
            }
            else if (this.measureVER_IN_B == IFX_MEASURE_TYPE.ZERO_CROSS)
            {
                listEdges_VER_IN_BTM = GetRawPoints_Hor_ZeroCross(rawImage, imageW, imageH, rcVER_IN_BTM, false, (int)this.DIR_VER_IN_B, this.ZC_MAG_VER_IN_B);
            }
            else if (this.measureVER_IN_B == IFX_MEASURE_TYPE.LAPL_GAUSS)
            {
                listEdges_VER_IN_BTM = GetRawPoints_HOR_LOG(rawImage, imageW, imageH, rcVER_IN_BTM, false, (int)this.DIR_VER_IN_B);
            }
            //*************************************************************************************
            // 04 HORIZONTAL - EXTERNAL BTM
            //*************************************************************************************

            if (this.measureVER_EX_B == IFX_MEASURE_TYPE.DIR_INFALL || this.measureVER_EX_B == IFX_MEASURE_TYPE.DIR_INRISE ||
                this.measureVER_EX_B == IFX_MEASURE_TYPE.DIR_EXRISE || this.measureVER_EX_B == IFX_MEASURE_TYPE.DIR_EXFALL)
            {
                listEdges_VER_EX_BTM = GetPointList_Derivative_HOR(rawImage, imageW, imageH, rcVER_EX_BTM, true, this.measureVER_EX_B);
            }
            else if (this.measureVER_EX_B == IFX_MEASURE_TYPE.ZERO_CROSS)
            {
                listEdges_VER_EX_BTM = GetRawPoints_Hor_ZeroCross(rawImage, imageW, imageH, rcVER_EX_BTM, true, (int)this.DIR_VER_EX_B, this.ZC_MAG_VER_EX_B);
            }
            else if (this.measureVER_EX_B == IFX_MEASURE_TYPE.LAPL_GAUSS)
            {
                listEdges_VER_EX_BTM = GetRawPoints_HOR_LOG(rawImage, imageW, imageH, rcVER_EX_BTM, true, (int)this.DIR_VER_EX_B);
            }

            //*************************************************************************************
            // 05 VERTICAL - EXTERNAL LFT
            //*************************************************************************************

            if (this.measureHOR_EX_L == IFX_MEASURE_TYPE.DIR_INFALL || this.measureHOR_EX_L == IFX_MEASURE_TYPE.DIR_INRISE ||
                this.measureHOR_EX_L == IFX_MEASURE_TYPE.DIR_EXFALL || this.measureHOR_EX_L == IFX_MEASURE_TYPE.DIR_EXRISE)
            {
                listEdges_HOR_EX_LFT = GetPointList_Derivative_VER(rawImage, imageW, imageH, rcHOR_EX_LFT, true, this.measureHOR_EX_L);
            }
            else if (this.measureHOR_EX_L == IFX_MEASURE_TYPE.ZERO_CROSS)
            {
                listEdges_HOR_EX_LFT = GetRawPoints_VER_ZeroCross(rawImage, imageW, imageH, rcHOR_EX_LFT, true, (int)this.DIR_HOR_EX_L, this.ZC_MAG_HOR_EX_L);
            }
            else if (this.measureHOR_EX_L == IFX_MEASURE_TYPE.LAPL_GAUSS)
            {
                listEdges_HOR_EX_LFT = GetRawPoints_VER_LOG(rawImage, imageW, imageH, rcHOR_EX_LFT, true, (int)this.DIR_HOR_EX_L);
            }

            //*************************************************************************************
            // 06 VERTICAL - INTERNAL LFT
            //*************************************************************************************

            if (this.measureHOR_IN_L == IFX_MEASURE_TYPE.DIR_INFALL || this.measureHOR_IN_L == IFX_MEASURE_TYPE.DIR_INRISE ||
                this.measureHOR_IN_L == IFX_MEASURE_TYPE.DIR_EXFALL || this.measureHOR_IN_L == IFX_MEASURE_TYPE.DIR_EXRISE)
            {
                listEdges_HOR_IN_LFT = GetPointList_Derivative_VER(rawImage, imageW, imageH, rcHOR_IN_LFT, true, this.measureHOR_IN_L);
            }
            else if (this.measureHOR_IN_L == IFX_MEASURE_TYPE.ZERO_CROSS)
            {
                listEdges_HOR_IN_LFT = GetRawPoints_VER_ZeroCross(rawImage, imageW, imageH, rcHOR_IN_LFT, true, (int)this.DIR_HOR_IN_L, this.ZC_MAG_HOR_IN_L);
            }
            else if (this.measureHOR_IN_L == IFX_MEASURE_TYPE.LAPL_GAUSS)
            {
                listEdges_HOR_IN_LFT = GetRawPoints_VER_LOG(rawImage, imageW, imageH, rcHOR_IN_LFT, true, (int)this.DIR_HOR_IN_L);
            }
            
            //*************************************************************************************
            // 07 VERTICAL - INTERNAL RHT
            //*************************************************************************************

            if (this.measureHOR_IN_R == IFX_MEASURE_TYPE.DIR_INFALL || this.measureHOR_IN_R == IFX_MEASURE_TYPE.DIR_INRISE ||
                this.measureHOR_IN_R == IFX_MEASURE_TYPE.DIR_EXFALL || this.measureHOR_IN_R == IFX_MEASURE_TYPE.DIR_EXRISE)
            {
                listEdges_HOR_IN_RHT = GetPointList_Derivative_VER(rawImage, imageW, imageH, rcHOR_IN_RHT, false, this.measureHOR_IN_R);
            }
            else if (this.measureHOR_IN_R == IFX_MEASURE_TYPE.ZERO_CROSS)
            {
                listEdges_HOR_IN_RHT = GetRawPoints_VER_ZeroCross(rawImage, imageW, imageH, rcHOR_IN_RHT, false, (int)this.DIR_HOR_IN_R, this.ZC_MAG_HOR_IN_R);
            }
            else if (this.measureHOR_IN_R == IFX_MEASURE_TYPE.LAPL_GAUSS)
            {
                listEdges_HOR_IN_RHT = GetRawPoints_VER_LOG(rawImage, imageW, imageH, rcHOR_IN_RHT, false, (int)this.DIR_HOR_IN_R);
            }

            //*************************************************************************************
            // 08 VERTICAL - EXTERNAL RHT
            //*************************************************************************************
            if (this.measureHOR_EX_R == IFX_MEASURE_TYPE.DIR_INFALL || this.measureHOR_EX_R == IFX_MEASURE_TYPE.DIR_INRISE ||
                this.measureHOR_EX_R == IFX_MEASURE_TYPE.DIR_EXFALL || this.measureHOR_EX_R == IFX_MEASURE_TYPE.DIR_EXRISE)
            {
                listEdges_HOR_EX_RHT = GetPointList_Derivative_VER(rawImage, imageW, imageH, rcHOR_EX_RHT, false, this.measureHOR_EX_R);
            }
            else if (this.measureHOR_EX_R == IFX_MEASURE_TYPE.ZERO_CROSS)
            {
                listEdges_HOR_EX_RHT = GetRawPoints_VER_ZeroCross(rawImage, imageW, imageH, rcHOR_EX_RHT, false, (int)this.DIR_HOR_EX_R, this.ZC_MAG_HOR_EX_R);
            }
            else if (this.measureHOR_EX_R == IFX_MEASURE_TYPE.LAPL_GAUSS)
            {
                listEdges_HOR_EX_RHT = GetRawPoints_VER_LOG(rawImage, imageW, imageH, rcHOR_EX_RHT, false, (int)this.DIR_HOR_EX_R);
            }

            listEdges_HOR_EX_LFT = GetList_FilterBy_MajorDistance(listEdges_HOR_EX_LFT, true, 5);
            listEdges_HOR_IN_LFT = GetList_FilterBy_MajorDistance(listEdges_HOR_IN_LFT, true, 5);
            listEdges_HOR_IN_RHT = GetList_FilterBy_MajorDistance(listEdges_HOR_IN_RHT, true, 5);
            listEdges_HOR_EX_RHT = GetList_FilterBy_MajorDistance(listEdges_HOR_EX_RHT, true, 5);

            listEdges_VER_EX_TOP = GetList_FilterBy_MajorDistance(listEdges_VER_EX_TOP, false, 5);
            listEdges_VER_IN_TOP = GetList_FilterBy_MajorDistance(listEdges_VER_IN_TOP, false, 5);
            listEdges_VER_IN_BTM = GetList_FilterBy_MajorDistance(listEdges_VER_IN_BTM, false, 5);
            listEdges_VER_EX_BTM = GetList_FilterBy_MajorDistance(listEdges_VER_EX_BTM, false, 5);

            //*************************************************************************************
            // 10 Summary Every Edges
            //*************************************************************************************


            CModelLine model_HOR_EX_LFT = new CModelLine();
            CModelLine model_HOR_IN_LFT = new CModelLine();
            CModelLine model_HOR_IN_RHT = new CModelLine();
            CModelLine model_HOR_EX_RHT = new CModelLine();

            CModelLine model_VER_EX_TOP = new CModelLine();
            CModelLine model_VER_IN_TOP = new CModelLine();
            CModelLine model_VER_IN_BTM = new CModelLine();
            CModelLine model_VER_EX_BTM = new CModelLine();

            PARAM_FITTING_THR = 3;
            CRansac.ransac_Line_fitting(listEdges_HOR_EX_LFT.ToArray(), ref model_HOR_EX_LFT, PARAM_FITTING_THR, listEdges_HOR_EX_LFT.Count / 2, listEdges_HOR_EX_LFT.Count);
            CRansac.ransac_Line_fitting(listEdges_HOR_IN_LFT.ToArray(), ref model_HOR_IN_LFT, PARAM_FITTING_THR, listEdges_HOR_IN_LFT.Count / 2, listEdges_HOR_IN_LFT.Count);
            CRansac.ransac_Line_fitting(listEdges_HOR_IN_RHT.ToArray(), ref model_HOR_IN_RHT, PARAM_FITTING_THR, listEdges_HOR_IN_RHT.Count / 2, listEdges_HOR_IN_RHT.Count);
            CRansac.ransac_Line_fitting(listEdges_HOR_EX_RHT.ToArray(), ref model_HOR_EX_RHT, PARAM_FITTING_THR, listEdges_HOR_EX_RHT.Count / 2, listEdges_HOR_EX_RHT.Count);

            CRansac.ransac_Line_fitting(listEdges_VER_EX_TOP.ToArray(), ref model_VER_EX_TOP, PARAM_FITTING_THR, listEdges_VER_EX_TOP.Count / 2, listEdges_VER_EX_TOP.Count);
            CRansac.ransac_Line_fitting(listEdges_VER_IN_TOP.ToArray(), ref model_VER_IN_TOP, PARAM_FITTING_THR, listEdges_VER_IN_TOP.Count / 2, listEdges_VER_IN_TOP.Count);
            CRansac.ransac_Line_fitting(listEdges_VER_IN_BTM.ToArray(), ref model_VER_IN_BTM, PARAM_FITTING_THR, listEdges_VER_IN_BTM.Count / 2, listEdges_VER_IN_BTM.Count);
            CRansac.ransac_Line_fitting(listEdges_VER_EX_BTM.ToArray(), ref model_VER_EX_BTM, PARAM_FITTING_THR, listEdges_VER_EX_BTM.Count / 2, listEdges_VER_EX_BTM.Count);


            if (this.SHOW_RAW_DATA == false)
            {
                listEdges_HOR_EX_LFT = ReplacePointList_Absolute_X(rcHOR_EX_LFT, (float)model_HOR_EX_LFT.sx);
                listEdges_HOR_IN_LFT = ReplacePointList_Absolute_X(rcHOR_IN_LFT, (float)model_HOR_IN_LFT.sx);
                listEdges_HOR_IN_RHT = ReplacePointList_Absolute_X(rcHOR_IN_RHT, (float)model_HOR_IN_RHT.sx);
                listEdges_HOR_EX_RHT = ReplacePointList_Absolute_X(rcHOR_EX_RHT, (float)model_HOR_EX_RHT.sx);

                listEdges_VER_EX_TOP = ReplacePointList_Absolute_Y(rcVER_EX_TOP, (float)model_VER_EX_TOP.sy);
                listEdges_VER_IN_TOP = ReplacePointList_Absolute_Y(rcVER_IN_TOP, (float)model_VER_IN_TOP.sy);
                listEdges_VER_IN_BTM = ReplacePointList_Absolute_Y(rcVER_IN_BTM, (float)model_VER_IN_BTM.sy);
                listEdges_VER_EX_BTM = ReplacePointList_Absolute_Y(rcVER_EX_BTM, (float)model_VER_EX_BTM.sy);
            }

            listEdgesHor.AddRange(listEdges_HOR_EX_LFT);
            listEdgesHor.AddRange(listEdges_HOR_IN_LFT);
            listEdgesHor.AddRange(listEdges_HOR_IN_RHT);
            listEdgesHor.AddRange(listEdges_HOR_EX_RHT);

            listEdgesVer.AddRange(listEdges_VER_EX_TOP);
            listEdgesVer.AddRange(listEdges_VER_IN_TOP);
            listEdgesVer.AddRange(listEdges_VER_IN_BTM);
            listEdgesVer.AddRange(listEdges_VER_EX_BTM);

            
            //****************************************************************************************************
            // Overlay Calculation 
            //****************************************************************************************************

            double fol_IN_X = (model_HOR_IN_LFT.sx + model_HOR_IN_RHT.sx) / 2.0;
            double fol_EX_X = (model_HOR_EX_LFT.sx + model_HOR_EX_RHT.sx) / 2.0;

            fOL_X = fol_EX_X - fol_IN_X;

            double fol_IN_Y = (model_VER_IN_TOP.sy + model_VER_IN_BTM.sy) / 2.0;
            double fol_EX_Y = (model_VER_EX_TOP.sy + model_VER_EX_BTM.sy) / 2.0;

            fOL_Y = fol_EX_Y - fol_IN_Y;

            return;
        }

    }

    public class CMeasurePairCir : CMeasureMotherFucker
    {
        public int measure_CIR = 0;

        public RectangleF rc_EX = new RectangleF();
        public RectangleF rc_IN = new RectangleF();

        public double DIR { get; set; }
        public double ZC_MAG { get; set; }
        public double DMG_IGNORANCE { get; set; }
        public bool bTreatAsEllipse { get; set; }

        public CMeasurePairCir() 
        {
            DMG_IGNORANCE = 0.1;
            SHOW_RAW_DATA = false;
            bTreatAsEllipse = false;
        }

        public CMeasurePairCir CopyTo() // In order to avoid icloneable
        {
            CMeasurePairCir single = new CMeasurePairCir();
            single.ptOrientBase = this.ptOrientBase;
            single.ptOrientCurr = this.ptOrientCurr;
            single.measure_CIR = this.measure_CIR;
            single.rc_EX = this.rc_EX;
            single.rc_IN = this.rc_IN;
            single.NICKNAME = this.NICKNAME;
            single.DIR = this.DIR;
            single.ZC_MAG = this.ZC_MAG;
            single.DMG_IGNORANCE = this.DMG_IGNORANCE;
            single.bTreatAsEllipse = this.bTreatAsEllipse;
            single.SHOW_RAW_DATA = this.SHOW_RAW_DATA;
            return single;
        }
        //************************************************************************************************

        public PointF GetCenter()
        {
            float cx = Convert.ToSingle(rc_EX.X + (rc_EX.Width / 2.0));
            float cy = Convert.ToSingle(rc_EX.Y + (rc_EX.Height / 2.0));

            return new PointF(cx, cy);
        }
        private PointF GetCenter(RectangleF rc)
        {
            float rchw = Convert.ToSingle(rc.Width / 2.0);
            float rchh = Convert.ToSingle(rc.Height / 2.0);

            float cx = rc.X + rchw;
            float cy = rc.Y + rchh;

            return new PointF(cx, cy);
        }
        

        # region COMMON OVERRIDINGS - NAVIGATOR FUNCTIONS
        
        public override void AdjustGap(int tx, int ty)
        {
            rc_IN.Width += tx;
            rc_IN.Height += ty;

            // size ensure not to be zero. 170518 
            if (rc_IN.Width <= 2) rc_IN.Width = 2;
            if (rc_IN.Height <= 2) rc_IN.Height = 2;

            rc_IN = CRect.SetCenter(rc_EX, rc_IN);
        }
        public override void AdjustPos(int tx, int ty)
        {
            rc_EX.Offset(tx, ty);
            rc_IN.Offset(tx, ty);
        }
        public override void AdjustSize(int tx, int ty)
        {
            // central resize mode 170515 
            float hx = Convert.ToSingle(tx / 2.0);
            float hy = Convert.ToSingle(ty / 2.0);

            rc_EX.Offset(-hx, -hy);

            rc_EX.Width += tx;
            rc_EX.Height += ty;

            if (rc_EX.Width <= 6) rc_EX.Width = 6;
            if (rc_EX.Height <= 6) rc_EX.Height = 6;

            // size ensure not to be zero. 170518 
            if (rc_IN.Width <= 2) rc_IN.Width = 2;
            if (rc_IN.Height <= 2) rc_IN.Height = 2;

            rc_IN = CRect.SetCenter(rc_EX, rc_IN);
            
        }
         
        #endregion  

        #region MEASUREMENT METHOD VERIFIER
        public override bool VeryfyMeasurementMatching()  {return true;} // this asshole has always true.
        public override string GetMeasurementCategory() {return IFX_MEASURE_TYPE.ToStringType(measure_CIR).Split('_')[0];}
        #endregion
         
        public override void SetRelativeCroodinates(PointF ptGravity)
        {
            // if preserved value exists --> recover 
            if (this.ptOrientBase.X != 0 && this.ptOrientBase.Y != 0)
            {
                this.rc_IN.Offset(ptOrientBase);
                this.rc_EX.Offset(ptOrientBase);
            }

            // update new original point
            this.ptOrientBase = ptGravity;

            // get relative distance 
            PointF ptDistEX = CPoint.GetDistancePoint(this.rc_EX.Location, ptGravity);
            PointF ptDistIN = CPoint.GetDistancePoint(this.rc_IN.Location, ptGravity);

            // set relative distance 
            this.rc_EX =  CRect.ReplaceOrigin(this.rc_EX, ptDistEX);
            this.rc_IN = CRect.ReplaceOrigin(this.rc_IN, ptDistIN);
        }

        public override void SetRelativeOrigin(PointF ptOrigin)
        {
            this.ptOrientCurr = ptOrigin;
        }
        //************************************************************************************************
        
        public override float rape_Pussy_Overay(byte[] rawImage, int imageW, int imageH, ref List<PointF> listContour, ref List<PointF> listDummy)
        {
            double fRadius = 0;

            try
            {
                RectangleF rcCirEx = GetCompensatedRect(this.rc_EX);
                RectangleF rcCirIn = GetCompensatedRect(this.rc_IN);

                PointF ptCenter = CRect.GetCenter(rcCirEx);

                int nRadLength = (int)Math.Max(rcCirEx.Width / 2.0, rcCirEx.Height / 2.0);
                int nRadiStart = (int)Math.Max(rcCirIn.Width / 2.0, rcCirIn.Height / 2.0);

                listContour.Clear();
                listDummy.Clear();

                byte[] buffLine = new byte[nRadLength - nRadiStart];

                for (int nAngle = 0; nAngle < 360; nAngle++)
                {
                    Array.Clear(buffLine, 0, buffLine.Length);

                    double fDegree = ((nAngle - 90.0) * Math.PI / 180.0);

                    for (int nRadiPos = nRadiStart, nIndex = 0; nRadiPos < nRadLength; nRadiPos++)
                    {
                        double x = (ptCenter.X + (nRadiPos * Math.Cos(fDegree)));
                        double y = (ptCenter.Y + (nRadiPos * Math.Sin(fDegree)));

                        if (x < 0 || y < 0 || x >= imageW || y >= imageH) { continue; }

                        buffLine[nIndex++] = rawImage[(int)y * imageW + (int)x];
                    }

                    double[] fArrProj = null;

                    /***/if (this.measure_CIR == IFX_MEASURE_TYPE.PRW_RISING){fArrProj = Computer.GetPrewitBuffLine(buffLine, 0);}
                    else if (this.measure_CIR == IFX_MEASURE_TYPE.PRW_FALLING){fArrProj = Computer.GetPrewitBuffLine(buffLine, 1);}

                    float fSubPos = (float)Computer.GetNewtonRapRes(fArrProj);

                    double ex = ptCenter.X + ((nRadiStart + fSubPos) * Math.Cos(fDegree));
                    double ey = ptCenter.Y + ((nRadiStart + fSubPos) * Math.Sin(fDegree));

                    PointF ptEdge = new PointF((float)ex, (float)ey);
                    listContour.Add(ptEdge);
                }

                if (bTreatAsEllipse == false)
                {
                    Computer.HC_FIT_Circle(listContour, ref ptCenter, ref fRadius);
                }
                else if (bTreatAsEllipse == true)
                {
                    listDummy = Computer.GetFilteredEllipsePoints(rcCirEx, listContour);

                    double distanceThreshold = 50;
                    CModelEllipse model = new CModelEllipse();
                    CRansac.ransac_ellipse_fitting(listDummy.ToArray(), ref model, distanceThreshold);

                    listDummy.Clear();
                    listDummy = CRansac.EllipseRot(model);

                    for (int i = 0; i < listDummy.Count; i++)
                    {
                        PointF pt = listDummy.ElementAt(i);
                        fRadius += CPoint.GetDistance(ptCenter, pt);
                    }
                    fRadius /= listDummy.Count;
                }

                if (SHOW_RAW_DATA == false)
                {
                    if (bTreatAsEllipse == false)
                    {
                        listContour.Clear();
                        listContour.Add(ptCenter);

                        for (int nAngle = 0; nAngle < 360; nAngle++)
                        {
                            double fDegree = ((nAngle - 90.0) * Math.PI / 180.0);

                            double x = ptCenter.X + (fRadius * Math.Cos(fDegree));
                            double y = ptCenter.Y + (fRadius * Math.Sin(fDegree));

                            listContour.Add(new PointF((float)x, (float)y));
                        }
                    }
                    else if (bTreatAsEllipse == true)
                    {
                        listContour = listDummy.ToList();
                    }
                } // bShowData
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return Convert.ToSingle(fRadius * 2.0);
        }
        public override float rape_Bitch_Direction(byte[] rawImage, int imageW, int imageH, ref List<PointF> listContour, ref List<PointF>listDummy)
        {
            double fRadius = 0;

            try
            {
            RectangleF rcCirEx = GetCompensatedRect(this.rc_EX);
            RectangleF rcCirIn = GetCompensatedRect(this.rc_IN);

            PointF ptCenter = CRect.GetCenter(rcCirEx);

            int nRadLength = (int)Math.Max(rcCirEx.Width / 2.0, rcCirEx.Height / 2.0);
            int nRadiStart = (int)Math.Max(rcCirIn.Width / 2.0, rcCirIn.Height / 2.0);

            listContour.Clear();
            listDummy.Clear();

            byte[] rawCopy = new byte[rawImage.Length];
            Array.Copy(rawImage, rawCopy, rawImage.Length);

            double[] fKernel = Computer.HC_FILTER_GenerateGaussianFilter(2, 7);
            rawImage = Computer.HC_FILTER_ConvolutionWindow(fKernel, rawImage, imageW, imageH, Rectangle.Round(rcCirEx));

            double[] buffLine = new double[nRadLength - nRadiStart];

            for (int nAngle = 0; nAngle < 360; nAngle++)
            {
                Array.Clear(buffLine, 0, buffLine.Length);

                double fAngle = nAngle;
                double fDegree = (((double)fAngle - 90.0) * Math.PI / 180.0);
 
                if (this.measure_CIR == IFX_MEASURE_TYPE.DIR_EXFALL ||
                    this.measure_CIR == IFX_MEASURE_TYPE.DIR_EXRISE)
                {
                    for (int nRadiPos = nRadiStart, nIndex = 0; nRadiPos < nRadLength; nRadiPos++)
                    {
                        double fRadi = nRadiPos;
                        double x = (double)ptCenter.X + (double)(fRadi * Math.Cos(fDegree));
                        double y = (double)ptCenter.Y + (double)(fRadi * Math.Sin(fDegree));

                        if (x < 0 || y < 0 || x >= imageW || y >= imageH) { continue; }

                        //buffLine[nIndex++] = rawImage[(int)y * imageW + (int)x];

                        int x1 = (int)Math.Floor(x);
                        int x2 = (int)Math.Ceiling(x);
                        int y1 = (int)Math.Floor(y);
                        int y2 = (int)Math.Ceiling(y);
                        
                        int q11 = rawImage[y1 * imageW + x1];
                        int q12 = rawImage[y2 * imageW + x1];
                        int q21 = rawImage[y1 * imageW + x2];
                        int q22 = rawImage[y2 * imageW + x2];
                        
                        double fInterplated = Computer.GetInterPolatedValue(x, y, x1, x2, y1, y2, q11, q12, q21, q22);

                        buffLine[nIndex++] = fInterplated;
                    }
                }
                if (this.measure_CIR == IFX_MEASURE_TYPE.DIR_INFALL ||
                    this.measure_CIR == IFX_MEASURE_TYPE.DIR_INRISE)
                {
                    for (int nRadiPos = nRadLength - 1, nIndex = 0; nRadiPos >= nRadiStart; nRadiPos--)
                    {
                        double x = (double)ptCenter.X + (nRadiPos * Math.Cos(fDegree));
                        double y = (double)ptCenter.Y + (nRadiPos * Math.Sin(fDegree));

                        if (x < 0 || y < 0 || x >= imageW || y >= imageH) { continue; }

                        //buffLine[nIndex++] = rawImage[(int)y * imageW + (int)x];

                        int x1 = (int)Math.Floor(x);
                        int x2 = (int)Math.Ceiling(x);
                        int y1 = (int)Math.Floor(y);
                        int y2 = (int)Math.Ceiling(y);

                        int q11 = rawImage[y1 * imageW + x1];
                        int q12 = rawImage[y2 * imageW + x1];
                        int q21 = rawImage[y1 * imageW + x2];
                        int q22 = rawImage[y2 * imageW + x2];
                        
                        double fInterplated = Computer.GetInterPolatedValue(x, y, x1, x2, y1, y2, q11, q12, q21, q22);

                        buffLine[nIndex++] = fInterplated;

                    }
                }
                double fSubPos = 0;
                double ex = 0;
                double ey = 0;

                if (this.measure_CIR == IFX_MEASURE_TYPE.DIR_EXFALL)
                {
                    fSubPos = Computer.Get2ndDerivativeLine_MaxPos(buffLine);
                    ex = ptCenter.X+ ((nRadiStart + fSubPos) * Math.Cos(fDegree));
                    ey = ptCenter.Y + ((nRadiStart + fSubPos) * Math.Sin(fDegree));
                }
                else if (this.measure_CIR == IFX_MEASURE_TYPE.DIR_EXRISE)
                {
                    fSubPos = Computer.Get2ndDerivativeLine_MinPos(buffLine);
                    ex = ptCenter.X + ((nRadiStart + fSubPos) * Math.Cos(fDegree));
                    ey = ptCenter.Y + ((nRadiStart + fSubPos) * Math.Sin(fDegree));
                }
                else if (this.measure_CIR == IFX_MEASURE_TYPE.DIR_INFALL)
                {
                    fSubPos = Computer.Get2ndDerivativeLine_MaxPos(buffLine);
                    ex = ptCenter.X + ((nRadLength - 1 - fSubPos) * Math.Cos(fDegree));
                    ey = ptCenter.Y + ((nRadLength - 1 - fSubPos) * Math.Sin(fDegree));
                }
                else if (this.measure_CIR == IFX_MEASURE_TYPE.DIR_INRISE)
                {
                    fSubPos = Computer.Get2ndDerivativeLine_MinPos(buffLine);
                    ex = ptCenter.X + ((nRadLength - 1 - fSubPos) * Math.Cos(fDegree));
                    ey = ptCenter.Y + ((nRadLength - 1 - fSubPos) * Math.Sin(fDegree));
                }

                PointF ptEdge = new PointF((float)ex, (float)ey);
                listContour.Add(ptEdge);
            }

            if (bTreatAsEllipse == false)
            {
                //**********************************************************************************
                // Damage Filtering 

                int nFilterLength = Convert.ToInt32(rc_IN.Width / 2) + 5;

                byte[] rawPoloar = Computer.HC_CropImage_Polar(rawImage, imageW, (int)imageH, rcCirEx);
                int[] arrProj = Computer.GetProjection_Horizontal(rawPoloar, 360, rawPoloar.Length / 360);

                int nMinValue = arrProj.Min();
                int nMaxValue = arrProj.Max();

                int nThreshold = nMinValue + Convert.ToInt32((nMaxValue - nMinValue) * DMG_IGNORANCE);

                List<PointF> tempFiltered = new List<PointF>();

                for (int an = 0; an < 360; an++)
                {
                    double fFilterDist = CPoint.GetDistance(ptCenter, listContour.ElementAt(an));

                    if (arrProj[an] > nThreshold && fFilterDist > nFilterLength)
                    {
                        tempFiltered.Add(listContour.ElementAt(an));
                    }
                }
                
                listContour = tempFiltered.ToList();
                listDummy = tempFiltered.ToList();

                // Additive Work 1 : Get the tempolary Radius 
                CModelCircle model = new CModelCircle();
                CRansac.ransac_Circle_fitting(listContour.ToArray(), ref model, 1.0, tempFiltered.Count / 3, tempFiltered.Count * 2);
                double fTempRadi = model.r;

                #region Filtering Test

                List<PointF> listFarDist = new List<PointF>();
                
                for (int filter = 0; filter < listContour.Count; filter++)
                {
                    double fLength = Math.Abs(CPoint.GetDistance(ptCenter, listContour.ElementAt(filter)) - fTempRadi);
                    if( fLength < 5)
                    {
                        listFarDist.Add(listContour.ElementAt(filter));
                    }
                }
                
                listContour = listFarDist.ToList();
                listDummy = listFarDist.ToList();

                Computer.HC_FIT_Circle(listContour, ref ptCenter, ref fRadius);
                #endregion  

                //
               //CModelCircle model = new CModelCircle();
               //CRansac.ransac_Circle_fitting(tempFiltered.ToArray(), ref model, 1.0, tempFiltered.Count / 3, tempFiltered.Count * 2);
               //fRadius = model.r;
               //
               //listContour = tempFiltered.ToList();
               //listDummy = tempFiltered.ToList();
               //
               //Computer.HC_FIT_Circle(listContour, ref ptCenter, ref fRadius);
            }
            else if (bTreatAsEllipse == true)
            {
                listDummy = Computer.GetFilteredEllipsePoints(rcCirEx, listContour);

                double distanceThreshold = 50;
                CModelEllipse model = new CModelEllipse();
                CRansac.ransac_ellipse_fitting(listDummy.ToArray(), ref model, distanceThreshold);

                listDummy.Clear();
                listDummy = CRansac.EllipseRot(model);

                for (int i = 0; i < listDummy.Count; i++)
                {
                    PointF pt = listDummy.ElementAt(i);
                    fRadius += CPoint.GetDistance(ptCenter, pt);
                }
                fRadius /= listDummy.Count;
            }

            if (SHOW_RAW_DATA == false)
                {
                    if (bTreatAsEllipse == false)
                    {
                        listContour.Clear();
                        listContour.Add(ptCenter);

                        for (int nAngle = 0; nAngle < 360; nAngle++)
                        {
                            double fDegree = ((nAngle - 90.0) * Math.PI / 180.0);

                            double x = ptCenter.X + (fRadius * Math.Cos(fDegree));
                            double y = ptCenter.Y + (fRadius * Math.Sin(fDegree));

                            listContour.Add(new PointF((float)x, (float)y));
                        }
                    }
                    else if (bTreatAsEllipse == true)
                    {
                        listContour = listDummy.ToList();
                    }
                } // bShowData
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return Convert.ToSingle(fRadius * 2.0);
        }
        public override float rape_idiot_ZeroCross(byte[] rawImage, int imageW, int imageH, ref List<PointF> listContour, ref List<PointF> listDummy)
        {
            double fRadius = 0;

            try
            {
                RectangleF rcCirEx = GetCompensatedRect(this.rc_EX);
                RectangleF rcCirIn = GetCompensatedRect(this.rc_IN);

                PointF ptCenter = CRect.GetCenter(rcCirEx);
            
                double[] fKernel = Computer.HC_FILTER_GenerateGaussianFilter(2.0, 7);
                rawImage = Computer.HC_FILTER_ConvolutionWindow(fKernel, rawImage, imageW, imageH, Rectangle.Round(rcCirEx));

                int nRadLength = (int)Math.Max(rcCirEx.Width / 2.0, rcCirEx.Height / 2.0);
                int nRadiStart = (int)Math.Max(rcCirIn.Width / 2.0, rcCirIn.Height / 2.0);

                listContour.Clear();

                double ex = 0;
                double ey = 0;
                double fSubPos = 0;

                byte[] buffLine = new byte[nRadLength - nRadiStart];

                for (int nAngle = 0; nAngle < 360; nAngle++)
                {
                    Array.Clear(buffLine, 0, buffLine.Length);

                    double fDegree = ((nAngle - 90.0) * Math.PI / 180.0);

                    for (int nRadiPos = nRadiStart, nIndex = 0; nRadiPos < nRadLength; nRadiPos++)
                    {
                        double x = ptCenter.X + (nRadiPos * Math.Cos(fDegree));
                        double y = ptCenter.Y + (nRadiPos * Math.Sin(fDegree));

                        if (x < 0 || y < 0 || x >= imageW || y >= imageH) { continue; }

                        buffLine[nIndex++] = rawImage[(int)y * imageW + (int)x];
                    }

                    ex = ey = fSubPos = 0;
                
                    fSubPos = Computer.GetZeroCrossingPt(buffLine, (int)this.DIR, this.ZC_MAG);
                
                    if (fSubPos != 0)
                    {
                        ex = ptCenter.X + ((nRadiStart + fSubPos) * Math.Cos(fDegree));
                        ey = ptCenter.Y + ((nRadiStart + fSubPos) * Math.Sin(fDegree));
                        PointF pt = new PointF((float)ex, (float)ey);
                        listContour.Add(pt);
                    }
                }

                if (bTreatAsEllipse == false)
                {
                    Computer.HC_FIT_Circle(listContour, ref ptCenter, ref fRadius);
                }
                else if (bTreatAsEllipse == true)
                {
                    listDummy = Computer.GetFilteredEllipsePoints(rcCirEx, listContour);

                    double distanceThreshold = 50;
                    CModelEllipse model = new CModelEllipse();
                    CRansac.ransac_ellipse_fitting(listDummy.ToArray(), ref model, distanceThreshold);

                    listDummy.Clear();
                    listDummy = CRansac.EllipseRot(model);

                    for (int i = 0; i < listDummy.Count; i++)
                    {
                        PointF pt = listDummy.ElementAt(i);
                        fRadius += CPoint.GetDistance(ptCenter, pt);
                    }
                    fRadius /= listDummy.Count;
                }

                if (SHOW_RAW_DATA == false)
                    {
                        if (bTreatAsEllipse == false)
                        {
                            listContour.Clear();
                            listContour.Add(ptCenter);

                            for (int nAngle = 0; nAngle < 360; nAngle++)
                            {
                                double fDegree = ((nAngle - 90.0) * Math.PI / 180.0);

                                double x = ptCenter.X + (fRadius * Math.Cos(fDegree));
                                double y = ptCenter.Y + (fRadius * Math.Sin(fDegree));

                                listContour.Add(new PointF((float)x, (float)y));
                            }
                        }
                        else if (bTreatAsEllipse == true)
                        {
                            listContour = listDummy.ToList();
                        }
                    } // bShowData
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return Convert.ToSingle(fRadius * 2.0);
        }
        public override float rape_asshole_Log(byte[] rawImage, int imageW, int imageH, ref List<PointF> listContour, ref List<PointF> listDummy)
        {
            double fRadius = 0;
            PARAM_FITTING_THR = 30;
 
            try
            {
                RectangleF rcCirEx = GetCompensatedRect(this.rc_EX);
                RectangleF rcCirIn = GetCompensatedRect(this.rc_IN);

                if (PARAM_SAVE_CROPS == true)
                {
                    byte[] rawCrop = Computer.HC_CropImage(rawImage, imageW, imageH, rcCirEx);
                    Computer.SaveImage(rawCrop, (int)rcCirEx.Width, (int)rcCirEx.Height, "c:\\Random_" + Computer.GetTimeCode4Save() + ".bmp");
                }
                
                double[] fKernel = Computer.HC_FILTER_GenerateGaussianFilter(2, 5);
                rawImage = Computer.HC_FILTER_ConvolutionWindow(fKernel, rawImage, imageW, imageH, Rectangle.Round(rcCirEx));

                //rawImage = Computer.HC_TRANS_SIGMOID_Contrast(rawImage, imageW, imageH, 1, 3.5);
                //rawImage = Computer.HC_FILTER_ConvolutionWindow(fKernel, rawImage, imageW, imageH, Rectangle.Round(rcCirEx));

                PointF ptCenter = CRect.GetCenter(rcCirEx);

                int nRadLength = (int)Math.Max(rcCirEx.Width / 2.0, rcCirEx.Height / 2.0);
                int nRadiStart = (int)Math.Max(rcCirIn.Width / 2.0, rcCirIn.Height / 2.0);

                listContour.Clear();
                listDummy.Clear();

                PointF[] ptTarget_IN = new PointF[nRadLength - nRadiStart];
                PointF[] ptTarget_EX = new PointF[nRadLength - nRadiStart];

                //***********************************************************************************
                // Get Rough Edges

                for (int nAngle = 0; nAngle < 360; nAngle++)
                {
                    Array.Clear(ptTarget_IN, 0, ptTarget_IN.Length);

                    double fDegree = ((nAngle - 90.0) * Math.PI / 180.0);

                    for (int nRadiPos = nRadiStart, nIndex = 0; nRadiPos < nRadLength; nRadiPos++)
                    {
                        double x = ptCenter.X + (nRadiPos * Math.Cos(fDegree));
                        double y = ptCenter.Y + (nRadiPos * Math.Sin(fDegree));

                        if (x < 0 || y < 0 || x >= imageW || y >= imageH) { continue; }

                        ptTarget_IN[nIndex++] = new PointF((float)x, (float)y);
                    }

                    

                    // get the copy
                    Array.Copy(ptTarget_IN, ptTarget_EX, ptTarget_IN.Length);

                    // set the reverse
                    Array.Reverse(ptTarget_EX);

                    // 170511 Fix direction for circle only 1
                    //fSubPos = Computer.GetLogPos(rawImage, imageW, imageH, ptTarget, (int)this.DIR);

                    double fSubPos_EX = Computer.GetLogPos(rawImage, imageW, imageH, ptTarget_EX, 1);
                    double fSubPos_IN = Computer.GetLogPos(rawImage, imageW, imageH, ptTarget_IN, 1);

                    double EX_X = 0; double EX_Y = 0;
                    double IN_X = 0; double IN_Y = 0;

                    if (fSubPos_EX != 0)
                    {
                        EX_X = ptCenter.X + ((nRadLength - fSubPos_EX) * Math.Cos(fDegree));
                        EX_Y = ptCenter.Y + ((nRadLength - fSubPos_EX) * Math.Sin(fDegree));

                    }
                    if (fSubPos_IN != 0)
                    {
                        IN_X = ptCenter.X + ((nRadiStart + fSubPos_IN) * Math.Cos(fDegree));
                        IN_Y = ptCenter.Y + ((nRadiStart + fSubPos_IN) * Math.Sin(fDegree));
                    }

                    PointF pt_EX = new PointF((float)EX_X, (float)EX_Y);
                    PointF pt_IN = new PointF((float)IN_X, (float)IN_Y);

                    const int DIR_EX = +1;
                    const int DIR_IN = -1;


                    if (this.DIR == DIR_IN )
                    {
                        if (fSubPos_EX != 0 && fSubPos_IN != 0)
                        {
                            CLine line = new CLine(pt_IN, pt_EX);
                            PointF ptEstimatedCenter = line.CENTER;

                            listContour.Add(new PointF(pt_IN.X - (pt_EX.X - pt_IN.X), pt_IN.Y - (pt_EX.Y - pt_IN.Y)));
                        }
                        else
                        {
                            listContour.Add(ptCenter);
                        }
                    }

                    if (this.DIR == DIR_EX )
                    {
                        if (fSubPos_EX != 0){listContour.Add(pt_EX);}
                        else
                        {
                            listContour.Add(ptCenter);
                        }
                    }

                    if (this.DIR == 0 )
                    {
                        if (fSubPos_IN != 0) listContour.Add(pt_IN);
                        else
                        {
                            listContour.Add(ptCenter);
                        }
                    }
                }
                
                // Currently listcount = raw contour points !@!!@!@!@!@
                //********************************************************************

                if (bTreatAsEllipse == false)
                {
                    byte[] rawPoloar = Computer.HC_CropImage_Polar(rawImage, imageW, (int)imageH, rcCirEx);
                    
                    int[] arrProj = Computer.GetProjection_Horizontal(rawPoloar, 360, rawPoloar.Length / 360);
                    
                    int nMinValue = arrProj.Min();  
                    int nMaxValue = arrProj.Max();

                     int nThreshold = nMinValue + Convert.ToInt32((nMaxValue - nMinValue) * DMG_IGNORANCE);
                    
                    List<PointF> tempFiltered = new List<PointF>();
                    List<double> distanceList = new List<double>();
                    
                    for (int an = 0; an < 360; an++)
                    {
                        if (arrProj[an] > nThreshold)
                        {
                            tempFiltered.Add(listContour.ElementAt(an));
                        }
                    }
                    
                    listContour = tempFiltered.ToList();
                    listDummy = tempFiltered.ToList();
                    
                    //CModelCircle model = new CModelCircle();
                    //CRansac.ransac_Circle_fitting(listContour.ToArray(), ref model, 0.2, 50, 100);
                    //fRadius = model.r;

                    Computer.HC_FIT_Circle(listContour, ref ptCenter, ref fRadius);

                    #region OLD VERSION - based on Major Symetric diameter
                   //List<PointF> tempFiltered = new List<PointF>();
                   //
                   //// assumption = circle diameter is under the 200
                   //int[] HistoDia = new int[200];
                   //double[] arrDia = new double[180];
                   //CLine[] arrLine = new CLine[180];
                   //
                   //// calculate symetric position and distance histogram 
                   //for (int an = 0; an < 180; an++)
                   //{
                   //    PointF ptHead = listContour.ElementAt(an);
                   //    PointF ptTail = listContour.ElementAt(an + 180);
                   //    
                   //    int nDistance = (int)Math.Floor(CPoint.GetDistance(ptHead, ptTail));
                   //    HistoDia[nDistance]++;
                   //    
                   //    // backup line to make display show 
                   //    CLine line = new CLine(ptHead, ptTail);
                   //    arrLine[an] = line;
                   //
                   //    arrDia[an] = (int)Math.Floor(CPoint.GetDistance(ptHead, ptTail));
                   //}
                   //
                   //// get max diameter based on diameter histogram
                   //int nPopularDia = HistoDia.Max();
                   //int nIndexDia/**/= Array.IndexOf(HistoDia, nPopularDia);
                   //
                   //for (int element = 1; element < 180 - 1; element++)
                   //{
                   //    // common raw points has to have close distance from the base diameter 
                   //    if (Math.Abs(arrDia[element] - nIndexDia) < 0.5)
                   //    {
                   //        tempFiltered.Add(arrLine.ElementAt(element).P1);
                   //        tempFiltered.Add(arrLine.ElementAt(element).P2);
                   //    }
                   //}
                   //
                   //listContour = tempFiltered.ToList();
                   //// make circle fitting
                   //Computer.HC_FIT_Circle(listContour, ref ptCenter, ref fRadius);
                    #endregion
                }
                else if (bTreatAsEllipse == true)
                {
                    listDummy = Computer.GetFilteredEllipsePoints(rcCirEx, listContour);

                    double distanceThreshold = 50;
                    CModelEllipse model = new CModelEllipse();
                    CRansac.ransac_ellipse_fitting(listDummy.ToArray(), ref model, distanceThreshold);

                    listDummy.Clear();
                    listDummy = CRansac.EllipseRot(model);
                    
                    for (int i = 0; i < listDummy.Count; i++)
                    {
                        PointF pt = listDummy.ElementAt(i);
                        fRadius += CPoint.GetDistance(ptCenter, pt);
                    }
                    fRadius /= listDummy.Count;
                }
                
                if (SHOW_RAW_DATA == false)
                {
                    if (bTreatAsEllipse == false)
                    {
                        listContour.Clear();
                        listContour.Add(ptCenter);

                        for (int nAngle = 0; nAngle < 360; nAngle++)
                        {
                            double fDegree = ((nAngle - 90.0) * Math.PI / 180.0);

                            double x = ptCenter.X + (fRadius * Math.Cos(fDegree));
                            double y = ptCenter.Y + (fRadius * Math.Sin(fDegree));

                            listContour.Add(new PointF((float)x, (float)y));
                        }
                    }
                    else if (bTreatAsEllipse == true)
                    {
                        listContour = listDummy.ToList();
                    }
                } // bShowData
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return Convert.ToSingle(fRadius * 2.0);
        }

        public override float MeasureData(byte[] rawImage, int imageW, int imageH, ref List<PointF> listEdgesFirst, ref List<PointF> listEdgesSecon)
        {
            double fDistance = 0;

            /***/if (this.GetMeasurementCategory() == "PRW") { fDistance = this.rape_Pussy_Overay(rawImage, imageW, imageH, ref listEdgesFirst, ref listEdgesSecon); }
            else if (this.GetMeasurementCategory() == "DIR") { fDistance = this.rape_Bitch_Direction(rawImage, imageW, imageH, ref listEdgesFirst, ref listEdgesSecon); }
            else if (this.GetMeasurementCategory() == "ZERO") { fDistance = this.rape_idiot_ZeroCross(rawImage, imageW, imageH, ref listEdgesFirst, ref listEdgesSecon); }
            else if (this.GetMeasurementCategory() == "LAPL") { fDistance = this.rape_asshole_Log(rawImage, imageW, imageH, ref listEdgesFirst, ref listEdgesSecon); }

            return Convert.ToSingle(fDistance);
        }
    }

    public class COverlay
    {
        public double DX { get; set; }
        public double DY { get; set; }

        public COverlay()
        {
            DX = DY = 0;
        }
        public COverlay(double dx, double dy)
        {
            DX = dx; DY = dy;
        }
    }

    public abstract class CMeasureFather
    {
        public CMeasureFather(){}

        public string INSP_FIGURE_TYPE { get; set; }
        public string INSP_TARGET_NAME { get; set; }

        public string INSP_TIME { get; set; }
        public string INSP_FILE { get; set; }
        
        public List<double> listRaw_Figure = new List<double>();
        public List<COverlay> listRaw_Overlay = new List<COverlay>();

        public int DataCount_Figure { get { return listRaw_Figure.Count; } }
        public int DataCount_Overlay { get { return listRaw_Overlay.Count; } }

        public abstract void CalcAccResult();

    }

    public class CMeasureReport
    {
        private List<DataFigure> m_listFigure = new List<DataFigure>();
        private List<DataOverlay> m_listOverlay = new List<DataOverlay>();

        public string INFO_RECIPE { get; set; }
        public string INFO_PTRN { get; set; }
        public double INFO_PIXEL_X { get; set; }
        public double INFO_PIXEL_Y { get; set; }
        public string INFO_TIME { get; set; }

        private int/**/COUNT_FIGURE { get { return m_listFigure.Count; } }
        private int/**/COUNT_OVERLAY { get { return m_listOverlay.Count; } }

        public class DataOverlay : CMeasureFather
        {
            public string INSP_METHOD_HOR_EX_LFT { get; set; }
            public string INSP_METHOD_HOR_IN_LFT { get; set; }
            public string INSP_METHOD_HOR_IN_RHT { get; set; }
            public string INSP_METHOD_HOR_EX_RHT { get; set; }

            public string INSP_METHOD_VER_EX_TOP { get; set; }
            public string INSP_METHOD_VER_IN_TOP { get; set; }
            public string INSP_METHOD_VER_IN_BTM { get; set; }
            public string INSP_METHOD_VER_EX_BTM { get; set; }

            public double INSP_DX { get; set; }
            public double INSP_DY { get; set; }

            public int TOTAL_COUNT { get { return listRaw_Overlay.Count; } }

            public DataOverlay CopyTo()
            {
                DataOverlay single = new DataOverlay();

                single.INSP_FILE = this.INSP_FILE;
                single.INSP_FIGURE_TYPE = this.INSP_FIGURE_TYPE;
                single.INSP_TARGET_NAME = this.INSP_TARGET_NAME;
                single.INSP_TIME = this.INSP_TIME;

                single.INSP_METHOD_HOR_EX_LFT = this.INSP_METHOD_HOR_EX_LFT;
                single.INSP_METHOD_HOR_IN_LFT = this.INSP_METHOD_HOR_IN_LFT;
                single.INSP_METHOD_HOR_IN_RHT = this.INSP_METHOD_HOR_IN_RHT;
                single.INSP_METHOD_HOR_EX_RHT = this.INSP_METHOD_HOR_EX_RHT;

                single.INSP_METHOD_VER_EX_TOP = this.INSP_METHOD_VER_EX_TOP;
                single.INSP_METHOD_VER_IN_TOP = this.INSP_METHOD_VER_IN_TOP;
                single.INSP_METHOD_VER_IN_BTM = this.INSP_METHOD_VER_IN_BTM;
                single.INSP_METHOD_VER_EX_BTM = this.INSP_METHOD_VER_EX_BTM;

                single.INSP_DX = this.INSP_DY;
                single.INSP_DY = this.INSP_DY;
                return single;
            }
            public void Insert_Data(double dx, double dy)
            {
                COverlay single = new COverlay(dx, dy);

                listRaw_Overlay.Add(single);
                INSP_DX += dx;
                INSP_DY += dy;
             }

            public override void CalcAccResult()
            {
                INSP_DX /= listRaw_Overlay.Count();
                INSP_DY /= listRaw_Overlay.Count();
            }
            public COverlay calcSigma(double fPixelRes )
            {
                COverlay[] arrRaw = listRaw_Overlay.ToArray();

                double [] arrRaw_X = arrRaw.Select(element => element.DX).ToArray();
                double [] arrRaw_Y = arrRaw.Select(element => element.DY).ToArray();

                double fMeanX = arrRaw_X.Average();
                double fMeanY = arrRaw_Y.Average();

                double varX = 0;
                double varY = 0;

                for (int i = 0; i < TOTAL_COUNT; i++)
                {
                    varX += (arrRaw_X[i] - fMeanX) * (arrRaw_X[i] - fMeanX);
                    varY += (arrRaw_Y[i] - fMeanY) * (arrRaw_Y[i] - fMeanY);
                }

                varX /= TOTAL_COUNT - 1;
                varY /= TOTAL_COUNT - 1;

                COverlay overlay = new COverlay();

                overlay.DX = Math.Sqrt(varX);
                overlay.DY = Math.Sqrt(varY);

                return overlay;
            }
        }
        public class DataFigure : CMeasureFather
        {
            public string INSP_METHOD1 { get; set; }
            public string INSP_METHOD2 { get; set; }
            public double INSP_RES { get; set; }
            public double DMG_IGNORANCE { get; set; }
            public int TOTAL_COUNT { get { return listRaw_Figure.Count; } }

            // to make data frame for accumulation
            public DataFigure CopyTo()
            {
                DataFigure single = new DataFigure();
                single.INSP_FILE = this.INSP_FILE;
                single.INSP_FIGURE_TYPE = this.INSP_FIGURE_TYPE;
                single.INSP_TARGET_NAME = this.INSP_TARGET_NAME;
                single.INSP_METHOD1 = this.INSP_METHOD1;
                single.INSP_METHOD2 = this.INSP_METHOD2;
                single.DMG_IGNORANCE = this.DMG_IGNORANCE;
                single.INSP_TIME = this.INSP_TIME;
                single.INSP_RES = this.INSP_RES;
                

                return single;
            }

             // data accumulation interface 
            public void Insert_Data(double fValue)
            {
                listRaw_Figure.Add(fValue);
                INSP_RES += fValue;
             }

            // sumarry function
            public override void CalcAccResult() { INSP_RES /= listRaw_Figure.Count; }
            public double calcSigma(double fPixelRes)
            {
                double[] arrRaw = listRaw_Figure.ToArray();
                
                double fMean = arrRaw.Average();

                double variance = 0;

                for (int i = 0; i < arrRaw.Length; i++)
                {
                    variance += (arrRaw[i] - fMean)*(arrRaw[i] - fMean);
                }
                variance /= arrRaw.Length-1;

                double sigma = Math.Sqrt(variance); 
                return sigma;
            }
        }


        private DataFigure GetIndex_Figure(int nIndex)
        {
            DataFigure single = new DataFigure();
            if (COUNT_FIGURE >= nIndex){single = m_listFigure.ElementAt(nIndex);}
            return single;
        }
        private DataOverlay GetIndex_Overlay(int nIndex)
        {
            DataOverlay single = new DataOverlay();
            if (COUNT_OVERLAY >= nIndex){single = m_listOverlay.ElementAt(nIndex);}
            return single;
        }

        public List<DataFigure> GetAverage_Figure()
        {
            List<DataFigure> listUnique = new List<DataFigure>();

            // Build Unique List 
            for (int i = 0; i < COUNT_FIGURE; i++)
            {
                DataFigure single = GetIndex_Figure(i);

                // first chance exception
                if (listUnique.Count == 0)
                {
                    DataFigure temp = single.CopyTo();
                    temp.INSP_RES = 0;

                    listUnique.Add(temp);
                }
                else
                {
                    bool bExistance = Check_UniqueExistance_Figure(listUnique, single);

                    // if unique
                    if (bExistance == false)
                    {
                        DataFigure temp = single.CopyTo();
                        temp.INSP_RES = 0;

                        listUnique.Add(temp);
                    }
                }
            }

            //**********************************************************
            // generate array : accumulation

            DataFigure[] arrUnitData = listUnique.ToArray();

            for (int i = 0; i < COUNT_FIGURE; i++)
            {
                DataFigure single = m_listFigure.ElementAt(i);

                int nIndex = Find_UniqueIndex_Figure(arrUnitData, single);

                arrUnitData[nIndex].Insert_Data(single.INSP_RES*INFO_PIXEL_X);
            }

            // Summary 
            for (int i = 0; i < listUnique.Count; i++)
            {
                arrUnitData[i].CalcAccResult();
            }
            return arrUnitData.ToList();
        }
        public List<DataOverlay> GetAverage_Overlay()
        {
            List<DataOverlay> listUnique = new List<DataOverlay>();

            // Build Unique List 
            for (int i = 0; i < COUNT_OVERLAY; i++)
            {
                DataOverlay single = GetIndex_Overlay(i);

                // first chance exception
                if (listUnique.Count == 0)
                {
                    DataOverlay temp = single.CopyTo();
                    temp.INSP_DX = 0;
                    temp.INSP_DY = 0;
                    listUnique.Add(temp);
                }
                else
                {
                    bool bExistance = Check_UniqueExistance_Overlay(listUnique, single);

                    // if unique
                    if (bExistance == false)
                    {
                        DataOverlay temp = single.CopyTo();
                        temp.INSP_DX = 0;
                        temp.INSP_DY = 0;

                        listUnique.Add(temp);
                    }
                }
            }

            //**********************************************************
            // generate array : accumulation

            DataOverlay[] arrUnitData = listUnique.ToArray();

            for (int i = 0; i < COUNT_OVERLAY; i++)
            {
                DataOverlay single = m_listOverlay.ElementAt(i);

                int nIndex = Find_UniqueIndex_Overlay(arrUnitData, single);

                double dx = single.INSP_DX * INFO_PIXEL_X;
                double dy = single.INSP_DY * INFO_PIXEL_Y;

                arrUnitData[nIndex].Insert_Data(dx, dy);
            }

            // Summary 
            for (int i = 0; i < listUnique.Count; i++)
            {
                arrUnitData[i].CalcAccResult();
            }
            return arrUnitData.ToList();
        }

        // get index from a given array
        private int Find_UniqueIndex_Figure(DataFigure[] arrUnitData, DataFigure single)
        {
            int nIndex = -1;

            for (int i = 0; i < arrUnitData.Length; i++)
            {
                DataFigure baseSingle = arrUnitData[i];

                if (baseSingle.INSP_FIGURE_TYPE == single.INSP_FIGURE_TYPE &&
                    baseSingle.INSP_TARGET_NAME == single.INSP_TARGET_NAME)
                {
                    nIndex = i;
                    break;
                }
            }
            return nIndex;
        }
        private int Find_UniqueIndex_Overlay(DataOverlay[] arrUnitData, DataOverlay single)
        {
            int nIndex = -1;

            for (int i = 0; i < arrUnitData.Length; i++)
            {
                DataOverlay baseSingle = arrUnitData[i];

                if (baseSingle.INSP_TARGET_NAME == single.INSP_TARGET_NAME)
                {
                    nIndex = i;
                    break;
                }
            }
            return nIndex;
        }
        // get existance from a given list
        private bool Check_UniqueExistance_Figure(List<DataFigure> list, DataFigure single)
        {
            bool bExistance = false;

            for (int i = 0; i < list.Count; i++)
            {
                DataFigure baseSignle = list.ElementAt(i);

                if (baseSignle.INSP_FIGURE_TYPE == single.INSP_FIGURE_TYPE &&
                    baseSignle.INSP_TARGET_NAME == single.INSP_TARGET_NAME)
                {
                    bExistance = true;
                    break;
                }
            }
            return bExistance;
        }
        private bool Check_UniqueExistance_Overlay(List<DataOverlay> list, DataOverlay single)
        {
            bool bExistance = false;

            for (int i = 0; i < list.Count; i++)
            {
                DataOverlay baseSignle = list.ElementAt(i);

                if (baseSignle.INSP_TARGET_NAME == single.INSP_TARGET_NAME)
                {
                    bExistance = true;
                    break;
                }
            }
            return bExistance;
        }

        public void SetInit()
        {
            m_listFigure.Clear();
            m_listOverlay.Clear();
        }
     

        public void AddResult_FIG(int nFigureType, string strFile, object Ini, double fResult)
        {
            string strTargetName = string.Empty;
            string strMethod1 = string.Empty;
            string strMethod2 = string.Empty;
            double fDmgIgnorance = 0.0;

            if (nFigureType == IFX_FIGURE.PAIR_HOR)
            {
                CMeasurePairHor buff = ((CMeasurePairHor)Ini);

                strTargetName = buff.NICKNAME;
                strMethod1 = IFX_MEASURE_TYPE.ToStringType(buff.measure_TOP);
                strMethod2 = IFX_MEASURE_TYPE.ToStringType(buff.measure_BTM);
            }
            else if( nFigureType == IFX_FIGURE.PAIR_VER)
            {
                CMeasurePairVer buff = ((CMeasurePairVer)Ini);

                strTargetName = buff.NICKNAME;
                strMethod1 = IFX_MEASURE_TYPE.ToStringType(buff.measure_LFT);
                strMethod2 = IFX_MEASURE_TYPE.ToStringType(buff.measure_RHT);
            }
            else if( nFigureType == IFX_FIGURE.PAIR_DIG)
            {
                CMeasurePairDig buff = ((CMeasurePairDig)Ini);

                strTargetName = buff.NICKNAME;
                strMethod1 = IFX_MEASURE_TYPE.ToStringType(buff.measure_FST);
                strMethod2 = IFX_MEASURE_TYPE.ToStringType(buff.measure_SCD);
            }
            else if (nFigureType == IFX_FIGURE.PAIR_CIR)
            {
                CMeasurePairCir buff = ((CMeasurePairCir)Ini);

                strTargetName = buff.NICKNAME;
                strMethod1 = IFX_MEASURE_TYPE.ToStringType(buff.measure_CIR);
                strMethod2 = IFX_MEASURE_TYPE.ToStringType(buff.measure_CIR);
                fDmgIgnorance = buff.DMG_IGNORANCE;
            }

            DataFigure single = new DataFigure();

            single.INSP_FIGURE_TYPE = IFX_FIGURE.ToStringType(nFigureType); ;
            single.INSP_FILE = strFile;
            single.INSP_TARGET_NAME = strTargetName;
            single.INSP_METHOD1 = strMethod1;
            single.INSP_METHOD2 = strMethod2;
            single.DMG_IGNORANCE = fDmgIgnorance;
            single.INSP_RES = fResult;
            single.INSP_TIME = Computer.TIME_GetTimeCode_MD_HMS_MS();

            m_listFigure.Add(single);
        }
        public void AddResult_OVL(int nFigureType, string strFile, double fOLX, double fOLY, CMeasurePairOvl ini)
        {
            DataOverlay single = new DataOverlay();

            single.INSP_FIGURE_TYPE = IFX_FIGURE.ToStringType(nFigureType);
            single.INSP_FILE = strFile;
            single.INSP_TARGET_NAME = ini.NICKNAME;

            single.INSP_METHOD_HOR_EX_LFT = IFX_MEASURE_TYPE.ToStringType(ini.measureHOR_EX_L);
            single.INSP_METHOD_HOR_IN_LFT = IFX_MEASURE_TYPE.ToStringType(ini.measureHOR_IN_L);
            single.INSP_METHOD_HOR_IN_RHT = IFX_MEASURE_TYPE.ToStringType(ini.measureHOR_IN_R);
            single.INSP_METHOD_HOR_EX_RHT = IFX_MEASURE_TYPE.ToStringType(ini.measureHOR_EX_R);

            single.INSP_METHOD_VER_EX_TOP = IFX_MEASURE_TYPE.ToStringType(ini.measureVER_EX_T);
            single.INSP_METHOD_VER_IN_TOP = IFX_MEASURE_TYPE.ToStringType(ini.measureVER_IN_T);
            single.INSP_METHOD_VER_IN_BTM = IFX_MEASURE_TYPE.ToStringType(ini.measureVER_IN_B);
            single.INSP_METHOD_VER_EX_BTM = IFX_MEASURE_TYPE.ToStringType(ini.measureVER_EX_B);

            single.INSP_DX = fOLX;
            single.INSP_DY = fOLY;

            m_listOverlay.Add(single);
        }

        
    }
    
     
    
    
}

