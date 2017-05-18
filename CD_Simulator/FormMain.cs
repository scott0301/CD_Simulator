using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using CFigure;
using CMeasure;
using ParameterSetting;
using CD_View;
using DispObject;
using WrapperMatrox;
using Wrapper;

namespace CD_Simulator
{
    partial class FormMain : Form
    {
        public int m_nScale = 10;
        public const int roi_position = 0;
        public const int roi_gap = 1;
        public const int roi_size = 2;
        public int m_roiControl = 0;

        public wrapperMilSys milsys = new wrapperMilSys();
        public CMeasureReport report = new CMeasureReport();

        int m_DrawType_Master = UC_Graph.IFX_GRAPH_TYPE.PROJ_V;
        int m_DrawType_Slave = UC_Graph.IFX_GRAPH_TYPE.PROJ_V;

        public FormMain()
        {
            InitializeComponent();

            imageView1.SetInit();
            imageView2.SetInit();

            imageView1.SetComponentPos(imageView1.Width, imageView1.Height);
            imageView2.SetComponentPos(imageView2.Width, imageView2.Height);

            imageView1.eventDele_HereComesNewImage += new dele_HereComesNewImage(fuck1);
            imageView2.eventDele_HereComesNewImage += new dele_HereComesNewImage(fuck2);

        }

        //*************************************************************************************************
        // view related ui functions
        //*************************************************************************************************

        #region view related ui functions

        private void BTN_VIEW_OVERLAY_MAG_ORG_Click(object sender, EventArgs e) 
        {
            imageView1.VIEW_SET_Mag_Origin();
            imageView1.VIEW_Set_Panning();
            BTN_VIEW_PANNING_Click(null, EventArgs.Empty);
        }
        private void BTN_VIEW_MAG_PLUS_Click(object sender, EventArgs e) { imageView1.VIEW_Set_Mag_Plus(); }
        private void BTN_VIEW_MAG_MINUS_Click(object sender, EventArgs e) { imageView1.VIEW_Set_Mag_Minus(); }

        private void BTN_VIEW_IMAGE_LOAD_Click(object sender, EventArgs e) { imageView1.VIEW_ImageLoad(); }
        private void BTN_VIEW_IMAGE_SAVE_Click(object sender, EventArgs e) { imageView1.VIEW_ImageSave(); }

        private void BTN_VIEW_PANNING_Click(object sender, EventArgs e)
        {
            bool bPanning = imageView1.VIEW_Set_Panning();

            this.UIThread(delegate
            {
                if/***/ (bPanning == true) { BTN_VIEW_PANNING.BackgroundImage = Properties.Resources.medical_joystick; }
                else if (bPanning == false) { BTN_VIEW_PANNING.BackgroundImage = Properties.Resources.medical_joystick_off; }
                imageView1.Refresh();
            });

        }
        private void BTN_VIEW_SET_OVERLAY_Click(object sender, EventArgs e)
        {
            bool bDraw = !imageView1.bDrawOveralay;

            imageView1.VIEW_Set_Overlay(bDraw);

            this.UIThread(delegate
            {
                if/***/ (bDraw == true) { BTN_VIEW_SET_OVERLAY.BackgroundImage = Properties.Resources.PaintBrushOn; }
                else if (bDraw == false) { BTN_VIEW_SET_OVERLAY.BackgroundImage = Properties.Resources.PaintBrushOff; }
                imageView1.Refresh();
            });
        }
        private void BTN_DRAW_FIGURE_Click(object sender, EventArgs e)
        {
            bool bDraw  = !imageView1.BOOL_TEACHING_ACTIVATION;

            imageView1.BOOL_TEACHING_ACTIVATION = bDraw;

            this.UIThread(delegate
            {
                if/***/ (bDraw == true) {  BTN_DRAW_FIGURE.BackgroundImage = Properties.Resources.drawfigure_On; }
                else if (bDraw == false) { BTN_DRAW_FIGURE.BackgroundImage = Properties.Resources.DrawFigure_Off; }
                imageView1.Refresh();
            });

        }

        private void BTN_VIEW_OVERLAY_CLEAR_Click(object sender, EventArgs e)
        {
            this.UIThread(delegate
            {
                imageView1.VIEW_Set_Clear_DispObject();
                imageView1.Refresh();
                TXT_PATH_RECP_FILE.Text = string.Empty;
            });
        }
        private void fuck1()
        {
            int imageW = imageView1.VIEW_GetImageW();
            int imageH = imageView1.VIEW_GetImageH();

            this.UIThread(delegate
            {
                TXT_INFO_IMAGE_X.Text = imageW.ToString("N0");
                TXT_INFO_IMAGE_Y.Text = imageH.ToString("N0");

                byte[] rawImage = imageView1.GetDisplay_Raw();
                var intArr = rawImage.Select(element => (int)element);

                int min = rawImage.Min();
                int max = rawImage.Max();
                int diff = max - min;
                double avg = intArr.Average();

                TXT_INFO_IMAGE_MIN.Text = min.ToString("N0");
                TXT_INFO_IMAGE_MAX.Text = max.ToString("N0");
                TXT_INFO_IMAGE_DIFF.Text = diff.ToString("N0");
                TXT_INFO_IMAGE_AVG.Text = avg.ToString("N0");

                uc_graph_global.SetImage( UC_Graph.IFX_GRAPH_TYPE.HISTO, rawImage, imageW, imageH);
                uc_graph_global.Refresh();
            });
        }
        private void fuck2()
        {
        }

        private void PRINT_MSG(string message)
        {
            string time = Support.TIME_GetTimeCode_MD_HMS_MS();

            string line = time + " : " + message + System.Environment.NewLine;
            msg.AppendText(line);
            msg.ScrollToCaret();
        }
        #endregion


        private void BTN_UPDATE_PARAM_FIGURES_Click(object sender, EventArgs e)
        {
            BTN_UPDATE_PARAMETER_EMPTY();
            LV_PARAMETER.Items.Clear();

            CFigureManager fmCopy = imageView1.fm;

            LV_PARAMETER.BeginUpdate();

            {
                //@@@ IMPORTANT 
                //@@@ PARSER EQUALS =====> -  not underbar it is hipen;

                // for horizontal rect pair

                for (int i = 0; i < fmCopy.COUNT_PAIR_HOR; i++)
                {
                    string strType = IFX_FIGURE.ToStringType(IFX_FIGURE.PAIR_HOR);

                    ListViewItem lvi = new ListViewItem(i.ToString());
                    lvi.SubItems.Add( strType + "-" + i.ToString("N0"));
                    LV_PARAMETER.Items.Add(lvi);
                }

                // for vertical rect pair
                for (int i = 0; i < fmCopy.COUNT_PAIR_VER; i++)
                {
                    string strType = IFX_FIGURE.ToStringType(IFX_FIGURE.PAIR_VER);

                    ListViewItem lvi = new ListViewItem(i.ToString());
                    lvi.SubItems.Add(strType + "-" + i.ToString("N0"));
                    LV_PARAMETER.Items.Add(lvi);
                }

                // for digonal rect pair
                for (int i = 0; i < fmCopy.COUNT_PAIR_DIG; i++)
                {
                    string strType = IFX_FIGURE.ToStringType(IFX_FIGURE.PAIR_DIG);

                    ListViewItem lvi = new ListViewItem(i.ToString());
                    lvi.SubItems.Add( strType + "-" + i.ToString("N0"));
                    LV_PARAMETER.Items.Add(lvi);
                }

                // for circle 
                for (int i = 0; i < fmCopy.COUNT_PAIR_CIR; i++)
                {
                    string strType = IFX_FIGURE.ToStringType(IFX_FIGURE.PAIR_CIR);

                    ListViewItem lvi = new ListViewItem(i.ToString());
                    lvi.SubItems.Add(strType + "-" + i.ToString("N0"));
                    LV_PARAMETER.Items.Add(lvi);
                }
                // for overlay
                for (int i = 0; i < fmCopy.COUNT_PAIR_OVL; i++)
                {
                    string strTye = IFX_FIGURE.ToStringType(IFX_FIGURE.PAIR_OVL);

                    ListViewItem lvi = new ListViewItem(i.ToString());
                    lvi.SubItems.Add(strTye + "-" + i.ToString("N0"));
                    LV_PARAMETER.Items.Add(lvi);
                }

            }
            
            LV_PARAMETER.EndUpdate();

        }
        private void LV_PARAMETER_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (LV_PARAMETER.FocusedItem == null) return;

            int nIndex = LV_PARAMETER.FocusedItem.Index;


            string strSelected = LV_PARAMETER.Items[nIndex].SubItems[1].Text;

            string[] parse = strSelected.Split('-');

            string strHeader = parse[0];
            int nItemIndex = Convert.ToInt32(parse[1]);

            //*****************************************************************************************
            // value assignment

            CFigureManager fmCopy = imageView1.fm;

            if (strHeader == IFX_FIGURE.ToStringType(IFX_FIGURE.PAIR_HOR))
            {
                CMeasurePairHor single = fmCopy.ElementAt_PairHor(nItemIndex);

                PROPERTY_PairHor propertySingle = new PROPERTY_PairHor();

                propertySingle.FromFigure(single);
                UC_PARAMETER.SetParam_RC_PAIR_HOR(propertySingle);
            }
            else if (strHeader == IFX_FIGURE.ToStringType(IFX_FIGURE.PAIR_VER))
            {
                CMeasurePairVer single = fmCopy.ElementAt_PairVer(nItemIndex);

                PROPERTY_PairVer propertySingle = new PROPERTY_PairVer();

                propertySingle.FromFigure(single);
                UC_PARAMETER.SetParam_RC_PAIR_VER(propertySingle);
            }
            else if (strHeader == IFX_FIGURE.ToStringType(IFX_FIGURE.PAIR_DIG))
            {
                CMeasurePairDig single = fmCopy.ElementAt_PairDig(nItemIndex);

                PROPERTY_PairDig propertySingle = new PROPERTY_PairDig();

                propertySingle.FromFigure(single);
                UC_PARAMETER.SetParam_RC_PAIR_DIG(propertySingle);
            }
            else if (strHeader == IFX_FIGURE.ToStringType(IFX_FIGURE.PAIR_CIR))
            {
                CMeasurePairCir single = fmCopy.ElementAt_PairCir(nItemIndex);

                PROPERTY_PairCir propertySingle = new PROPERTY_PairCir();

                propertySingle.FromFigure(single);
                UC_PARAMETER.SetParam_Circle(propertySingle);
            }
            else if( strHeader == IFX_FIGURE.ToStringType(IFX_FIGURE.PAIR_OVL))
            {
                CMeasurePairOvl single = fmCopy.ElementAt_PairOvl(nItemIndex);

                PROPERTY_PairOvl propertySingle = new PROPERTY_PairOvl();

                propertySingle.FromFigure(single);
                UC_PARAMETER.SetParam_Overlay(propertySingle);
            }
        }
        private void LV_PARAMETER_SelectedIndexChanged(object sender, EventArgs e) {}


        private void BTN_RECIPE_LOAD_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "XML files (*.XML)|*.xml|All files (*.*)|*.*";
            dlg.InitialDirectory = DEF_PATH.PATH_RECP;

            if (dlg.ShowDialog() != DialogResult.OK)
                return;

            // exception
            string strFileName = dlg.FileName;
            if (strFileName == string.Empty) return;

            // do operation
            imageView1.fm = CFigureManager.SerializedXml_Load(strFileName);
            strFileName = Path.GetFileName(strFileName);

            string strPtrnFullPath = string.Empty;
            string strPtrnFileName = string.Empty;
            string strPtrnDirName = string.Empty;

            try
            {
                strPtrnFullPath = imageView1.fm.PTRN_TEACH_FILE;
                strPtrnFileName = Path.GetFileName(strPtrnFullPath);
                strPtrnDirName = strPtrnFullPath.Replace(strPtrnFileName, "");

                TXT_PTRN_FILE_NAME.Text = strPtrnFileName;
                TXT_PTRN_PATH.Text = strPtrnDirName;

                // update ptrn view
                SetView_PTRN(strPtrnFullPath);
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString() + System.Environment.NewLine); }

            imageView1.Refresh();

            // update information 
            TXT_PATH_RECP_FILE.Text = imageView1.fm.RECP_FILE;
            TXT_INFO_PIXEL_X.Text = imageView1.fm.PIXEL_RES_X.ToString("F5");
            TXT_INFO_PIXEL_Y.Text = imageView1.fm.PIXEL_RES_Y.ToString("F5");
            BTN_UPDATE_PARAM_FIGURES_Click(null, EventArgs.Empty);

            TXT_PTRN_ACC_RATIO.Text = imageView1.fm.PTRN_ACCEPT_RATIO.ToString("F4");

            PRINT_MSG("New Recipe has loaded.");
            PRINT_MSG(strFileName);

            BTN_UPDATE_FIGURE_LIST_Click(null, EventArgs.Empty);
        }

        private void BTN_RECIPE_SAVE_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "XML files (*.XML)|*.xml|All files (*.*)|*.*";
              dlg.InitialDirectory = DEF_PATH.PATH_RECP;

            if (dlg.ShowDialog() != DialogResult.OK)
                return;

            // exception
            string strFileName = dlg.FileName;
            if (strFileName == string.Empty) return;

            // update Pixel Size
            imageView1.fm.SetPixelSize(TXT_INFO_PIXEL_X.Text, TXT_INFO_PIXEL_Y.Text);

            // update PTRN Teach Info
            imageView1.fm.PTRN_TEACH_FILE = TXT_PTRN_PATH.Text + TXT_PTRN_FILE_NAME.Text;

            if (TXT_PTRN_ACC_RATIO.Text == string.Empty) TXT_PTRN_ACC_RATIO.Text = "95.000";

            double fAcceptRatio = double.Parse(TXT_PTRN_ACC_RATIO.Text);
            TXT_PTRN_ACC_RATIO.Text = fAcceptRatio.ToString("F4");
            imageView1.fm.PTRN_ACCEPT_RATIO = fAcceptRatio;

            // update Recipe File  Info
            imageView1.fm.RECP_FILE = strFileName;

            CFigureManager.SerializedXml_Save(strFileName, imageView1.fm);
            strFileName = Path.GetFileName(strFileName);

            // update information
            TXT_PATH_RECP_FILE.Text = strFileName;
            PRINT_MSG("Current Recipe has saved.");
            PRINT_MSG(strFileName);
        }

        
        private void FormMainUI_Load(object sender, EventArgs e)
        {
            PRINT_MSG("Program Initialized.");

            TXT_PATH_RECIPE.Text = DEF_PATH.PATH_RECP;
            TXT_PATH_DUMP.Text = DEF_PATH.PATH_DUMP;

            Support.PATH_MakeSureExistance(DEF_PATH.PATH_MAIN);
            Support.PATH_MakeSureExistance(DEF_PATH.PATH_DUMP);
            Support.PATH_MakeSureExistance(DEF_PATH.PATH_RECP);

            int imageW = imageView1.VIEW_GetImageW();
            int imageH = imageView1.VIEW_GetImageH();

            Update_PTRN_Files();

            milsys.SetBoardInit(imageW, imageH);

            string strBuildInfo = WrapperDateTime.GetBuildInfo();

            this.Text += " -:: " +strBuildInfo;

        }

        private void BTN_SELECT_VIEW_Click(object sender, EventArgs e)
        {
            string Who = ((Button)sender).Name;

            if (Who.Contains("VIEW1"))
            {
                imageView1.Show();
                imageView2.Hide();
                LB_CAM_INDEX.Text = "#1";
                PANEL_VIEW_TOOLS.Enabled = true;
                PANEL_VIEW_BLEND.Enabled = true;
            }
            else
            {
                imageView1.Hide();
                imageView2.Show();
                LB_CAM_INDEX.Text = "#2";
                PANEL_VIEW_TOOLS.Enabled = false;
                PANEL_VIEW_BLEND.Enabled = false;
            }
        }

        private void TB_BLENDING_RATIO_Scroll(object sender, EventArgs e)
        {
            int imageW1 = imageView1.VIEW_GetImageW();
            int imageH1 = imageView1.VIEW_GetImageH();
            int imageW2 = imageView2.VIEW_GetImageW();
            int imageH2 = imageView2.VIEW_GetImageH();

            if (imageW1 == imageW2 && imageH1 == imageH2)
            {
                int nValue = TB_BLENDING_RATIO.Value;
                LB_BLEND_VALUE.Text = nValue.ToString() + "%";
                imageView1.SetLayerDisp(nValue);
             }
            else
            {
                return;
            }
        }

        private void CHK_BLEND_CheckedChanged(object sender, EventArgs e)
        {
            /***/
            if (CHK_BLEND.Checked == true)
            {
                imageView1.SetLayerDisp_Status(true, imageView2.GetDisplay_Bmp());
                TB_BLENDING_RATIO.Enabled = true;
                LB_BLEND_VALUE.ForeColor = Color.Yellow;
            }
            else
            {
                imageView1.SetLayerDisp_Status(false, null);
                TB_BLENDING_RATIO.Enabled = false;
                LB_BLEND_VALUE.ForeColor = Color.Black;
            }
        }

        private PointF DO_PTRN_And_Get_Center(out RectangleF rcOut )
        {
            PointF ptBasement = new PointF(0,0);
            rcOut = new RectangleF();

            string strPath = TXT_PTRN_PATH.Text;
            string strFile = TXT_PTRN_FILE_NAME.Text;
            string strPTRNFIle = Path.Combine(strPath, strFile);

            if (File.Exists( strPTRNFIle) == true)
            {
                Bitmap bmpPTRN = (Bitmap)Bitmap.FromFile(strPTRNFIle);
                Bitmap bmpView = (Bitmap)imageView1.GetDisplay_Bmp();

                ResultPTRN ptrn = WrapperMil.MIL_MATCH_Find_PTRN(milsys.MilSystem, bmpView, bmpPTRN, imageView1.fm.PTRN_ACCEPT_RATIO, 1);

                if (ptrn.Count >= 1)
                {
                    PRINT_MSG("PTRN SUCESS.");

                    ptBasement = ptrn.resultList.ElementAt(0).ptCenter;
                    rcOut = ptrn.resultList.ElementAt(0).rc;
                    PRINT_MSG("Matching Ratio = " + ptrn.resultList.ElementAt(0).fScore.ToString("F3") + "%");

                    PointF ptDist = ptrn.resultList.ElementAt(0).ptDist;
                    PRINT_MSG(string.Format("Distance = [{0},{1}]", ptDist.X.ToString("F3"), ptDist.Y.ToString("F3")));
                }
                else
                {
                    PRINT_MSG("PTRN MATCHING Failed.");

                }
            }
            else{PRINT_MSG("PTRN File Not Found.");}

            return ptBasement;
        }

        private void Do_Inspection(Bitmap bmp, string strFileName)
        {
            int imageW = 0;
            int imageH = 0;
            byte[] rawImage = Computer.HC_CONV_Bmp2Raw(bmp, ref imageW, ref imageH);

            RectangleF rcBasement/*****/ = new RectangleF();
            PointF/***/ptMatchingCenter/***/ = DO_PTRN_And_Get_Center(out rcBasement);

            imageView1.DrawPoint(ptMatchingCenter, 100, (float)5, Color.Magenta);
            imageView1.DrawRect(rcBasement, Color.Magenta);

            CFigureManager fm = imageView1.fm.Clone() as CFigureManager;

            #region CIRCLE - NOrmal case 
            for (int i = 0; i < fm.COUNT_PAIR_CIR; i++)
            {
               List<PointF> listEdgesCIR = new List<PointF>();
               List<PointF> listEdgesCirDummy = new List<PointF>();
               
               CMeasurePairCir single = fm.ElementAt_PairCir(i);
               single.SetRelativeOrigin(ptMatchingCenter);

               double fDistance = single.MeasureData(rawImage, imageW, imageH, ref listEdgesCIR, ref listEdgesCirDummy);

               imageView1.DrawPoints(listEdgesCirDummy, /***/1, (float)0.1, Color.Yellow);
               imageView1.DrawPoints(listEdgesCIR, /***/1, (float)0.1, Color.Red);
               
               report.AddResult_FIG(IFX_FIGURE.PAIR_CIR, strFileName, single, fDistance);
            }
            #endregion

            #region Hor - Normal Case 
            for (int i = 0; i < fm.COUNT_PAIR_HOR; i++)
            {
                List<PointF> listEdgesTop = new List<PointF>();
                List<PointF> listEdgesBtm = new List<PointF>();
            
                CMeasurePairHor single = fm.ElementAt_PairHor(i);
                single.SetRelativeOrigin(ptMatchingCenter);
            
                if (single.VeryfyMeasurementMatching() == false) { PRINT_MSG("Invalid types of Measurement Methods [ TOP vs BTM ]"); continue; }

                double fDistance = single.MeasureData(rawImage, imageW, imageH, ref listEdgesTop, ref listEdgesBtm);
            
                imageView1.DrawPoints(listEdgesTop, 1, (float)0.4, Color.Magenta);
                imageView1.DrawPoints(listEdgesBtm, 1, (float)0.4, Color.Magenta);
                report.AddResult_FIG(IFX_FIGURE.PAIR_HOR, strFileName, single, fDistance);
            }
            #endregion

            #region VER - normal case 
            for (int i = 0; i < fm.COUNT_PAIR_VER; i++)
            {
                List<PointF> listEdgesLFT = new List<PointF>();
                List<PointF> listEdgesRHT = new List<PointF>();
            
                CMeasurePairVer single = fm.ElementAt_PairVer(i);
                single.SetRelativeOrigin(ptMatchingCenter);
            
                if (single.VeryfyMeasurementMatching() == false) { PRINT_MSG("Invalid types of Measurement Methods [ LFT vs RHT ]"); continue; }

                double fDistance = single.MeasureData(rawImage, imageW, imageH, ref listEdgesLFT, ref listEdgesRHT); 
            
                imageView1.DrawPoints(listEdgesLFT, 1, (float)1, Color.Magenta);
                imageView1.DrawPoints(listEdgesRHT, 1, (float)1, Color.Magenta);
                report.AddResult_FIG(IFX_FIGURE.PAIR_VER, strFileName, single, fDistance);
            }
            #endregion
             

            #region Digonal - Normal Case 
            for (int i = 0; i < fm.COUNT_PAIR_DIG; i++)
            {
                List<PointF> listEdgesFirst = new List<PointF>();
                List<PointF> listEdgesSecon = new List<PointF>();

                CMeasurePairDig single = fm.ElementAt_PairDig(i);
                single.SetRelativeOrigin(ptMatchingCenter);

                if (single.VeryfyMeasurementMatching() == false) { PRINT_MSG("Invalid types of Measurement Methods [ FST vs SCD ]"); continue; }

                double fDistance = single.MeasureData(rawImage, imageW, imageH, ref listEdgesFirst, ref listEdgesSecon);

                imageView1.DrawPoints(listEdgesFirst, 1, (float)0.1, Color.Magenta);
                imageView1.DrawPoints(listEdgesSecon, 1, (float)0.1, Color.Magenta);
                report.AddResult_FIG(IFX_FIGURE.PAIR_DIG, strFileName,  single, fDistance);
            }
            #endregion

            #region OVL - Normal Case 
            for (int i = 0; i < fm.COUNT_PAIR_OVL; i++)
            {
                List<PointF> listEdgesHOR = new List<PointF>();
                List<PointF> listEdgesVER = new List<PointF>();

                CMeasurePairOvl single = fm.ElementAt_PairOvl(i);
                single.SetRelativeOrigin(ptMatchingCenter);
       
                double fOL_X = 0;
                double fOL_Y = 0; 

                single.raple_MotherFucker(rawImage, imageW, imageH, ref listEdgesHOR, ref listEdgesVER, out fOL_X, out fOL_Y);

                imageView1.DrawPoints(listEdgesHOR, /***/1, (float)0.1, Color.Magenta);
                imageView1.DrawPoints(listEdgesVER, /***/1, (float)0.1, Color.Magenta);

                report.AddResult_OVL(IFX_FIGURE.PAIR_OVL, strFileName, fOL_X, fOL_Y, single);
            }
            #endregion

            imageView1.Refresh();
        }
        private void BTN_MEASURE_Click(object sender, EventArgs e)
        {
            imageView1.VIEW_Set_Clear_DispObject();

            CFigureManager fm = imageView1.fm.Clone() as CFigureManager;

            if (fm.RECP_FILE == null)
            {
                MessageBox.Show("Invalid RECP File.\n Please Try Again With Correct RECP.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int nCount = LV_FILE_LIST.Items.Count;

            if (sender.ToString() == "SELECTABLE") // Arbitrary selectable measurement
            {
                if (LV_FILE_LIST.FocusedItem == null) return;
                int nIndex = LV_FILE_LIST.FocusedItem.Index;

                string strFile = LV_FILE_LIST.Items[nIndex].SubItems[1].Text;
                imageView1.ThreadCall_LoadImage(strFile);

                // only for the selected item 
                Bitmap bmp = imageView1.GetDisplay_Bmp();
                Do_Inspection(bmp, imageView1.m_strLoadedFile);

            }
            else if (CHK_MEASURE_VIEW_ONLY.Checked == true) // image view measurement
            {
                Bitmap bmp = imageView1.GetDisplay_Bmp();
                Do_Inspection(bmp, imageView1.m_strLoadedFile);
            }
            else if(CHK_MEASURE_VIEW_ONLY.Checked == false ) // full sequential measurement
            {
                for (int nIndex = 0; nIndex < nCount; nIndex++)
                {
                    string strFile = LV_FILE_LIST.Items[nIndex].SubItems[1].Text;

                    Bitmap bmp = (Bitmap)Bitmap.FromFile(strFile);
                    imageView1.VIEW_Set_Clear_DispObject();
                    imageView1.SetDisplay(bmp);
                    imageView1.VIEW_SET_Mag_Origin();

                    Do_Inspection(bmp, strFile);
                 }
            }

            report.SetInit();
            report.INFO_PTRN = fm.PTRN_TEACH_FILE;
            report.INFO_RECIPE = fm.RECP_FILE;
            report.INFO_TIME = Computer.TIME_GetTimeCode_MD_HMS_MS();
            report.INFO_PIXEL_X = fm.PIXEL_RES_X;
            report.INFO_PIXEL_Y = fm.PIXEL_RES_Y;


            //*************************************************************************
            // make report file

            WriteMeasurementData(report);
        }
        private void WriteMeasurementData(CMeasureReport report)
        {
            WrapperExcel ex = new WrapperExcel();

            string[] header = new string[10];

            header[0] = "RECP"/*****/; header[1] = report.INFO_RECIPE; /*********************/ ex.data.Add(header.ToArray());
            header[0] = "PTRN"/*****/; header[1] = report.INFO_PTRN; /***********************/ ex.data.Add(header.ToArray());
            header[0] = "TIME"/*****/; header[1] = report.INFO_TIME; /***********************/ ex.data.Add(header.ToArray());
            header[0] = "PIXEL_RES_X"; header[1] = report.INFO_PIXEL_X.ToString("N5"); /*****/ ex.data.Add(header.ToArray());
            header[0] = "PIXEL_RES_Y"; header[1] = report.INFO_PIXEL_Y.ToString("N5"); /*****/ ex.data.Add(header.ToArray());
            header[0] = /************/ header[1] = ""; /*************************************/ ex.data.Add(header.ToArray());
            header[0] = /************/ header[1] = ""; /*************************************/ ex.data.Add(header.ToArray());
            header[0] = "SUMARRY"/**/; header[1] = ""; /*************************************/ ex.data.Add(header.ToArray());


            List<CMeasureReport.DataFigure> listFigure = report.GetAverage_Figure();
            List<CMeasureReport.DataOverlay> listOverlay = report.GetAverage_Overlay();

            for (int nItem = 0; nItem < listFigure.Count; nItem++)
            {
                string[] single = new string[10];

                CMeasureReport.DataFigure summary = listFigure.ElementAt(nItem);
                double fSigam = summary.calcSigma(report.INFO_PIXEL_X) * 3;

                int nACC = summary.TOTAL_COUNT;

                single[0] = "TOTAL"; /***********/single[1] = nACC.ToString("N0");/****/ex.data.Add(single.ToArray());
                single[0] = "TYPE"; /************/single[1] = summary.INSP_FIGURE_TYPE; ex.data.Add(single.ToArray());
                single[0] = "NAME"; /************/single[1] = summary.INSP_TARGET_NAME; ex.data.Add(single.ToArray());
                single[0] = "MEASURE TYPE 1";/***/single[1] = summary.INSP_METHOD1; /**/ex.data.Add(single.ToArray());
                single[0] = "MEASURE TYPE 2";/***/single[1] = summary.INSP_METHOD2; /**/ex.data.Add(single.ToArray());

                if (summary.INSP_FIGURE_TYPE != IFX_FIGURE.ToStringType(IFX_FIGURE.PAIR_CIR))
                {
                    single[0] = "WIDTH"; single[1] = summary.INSP_RES.ToString("F4"); ex.data.Add(single.ToArray());
                }
                else
                {
                    single[0] = "DIAMETER"; single[1] = summary.INSP_RES.ToString("F4"); ex.data.Add(single.ToArray());
                    single[0] = "DMG IGNORANCE"; single[1] = summary.DMG_IGNORANCE.ToString("F2"); ex.data.Add(single.ToArray());

                }
                single[0] = "SIGMA";/***/single[1] = fSigam.ToString("F4"); /**/ex.data.Add(single.ToArray());
                single[0] = single[1] = ""; ex.data.Add(single.ToArray());
            }

            header[0] = /****************/ header[1] = ""; /*************************************/ ex.data.Add(header.ToArray());
            header[0] = /****************/ header[1] = ""; /*************************************/ ex.data.Add(header.ToArray());


            if (listFigure.Count != 0)
            {
                //*******************************************************************************
                // Entire Data Chart In detail : Column Generation
                //*******************************************************************************

                // column header [Empty] + [Index 0]...[Index N-1]
                int nIterationCount = listFigure.ElementAt(0).TOTAL_COUNT;
                int nHeaderLength = nIterationCount + 1;
                string[] arrHeader = new string[nHeaderLength];
                arrHeader[0] = "ITEM";

                for (int nColumn = 1; nColumn < nHeaderLength; nColumn++) { arrHeader[nColumn] = "ITER_" + nColumn.ToString("N0"); }
                ex.data.Add(arrHeader.ToArray());

                //*******************************************************************************
                // Raw Data Listing
                //*******************************************************************************

                for (int nItem = 0; nItem < listFigure.Count; nItem++)
                {
                    CMeasureReport.DataFigure summary = listFigure.ElementAt(nItem);

                    string[] rawData = new string[nHeaderLength];

                    rawData[0] = summary.INSP_TARGET_NAME;
                    for (int i = 0; i < nIterationCount; i++)
                    {
                        rawData[i + 1] = summary.listRaw_Figure.ElementAt(i).ToString("F4");
                    }
                    ex.data.Add(rawData.ToArray());
                }
            }

            for (int nItem = 0; nItem < listOverlay.Count; nItem++)
            {
                string[] single = new string[10];

                CMeasureReport.DataOverlay summary = listOverlay.ElementAt(nItem);
                COverlay sigmaOVL = summary.calcSigma(report.INFO_PIXEL_X);

                int nACC = summary.TOTAL_COUNT;

                single[0] = "TOTAL"; /***********/single[1] = nACC.ToString("N0");/****/ex.data.Add(single.ToArray());
                single[0] = "TYPE"; /************/single[1] = summary.INSP_FIGURE_TYPE; ex.data.Add(single.ToArray());
                single[0] = "NAME"; /************/single[1] = summary.INSP_TARGET_NAME; ex.data.Add(single.ToArray());

                single[0] = "MEASURE HOR_EX_LFT";/***/single[1] = summary.INSP_METHOD_HOR_EX_LFT; /**/ex.data.Add(single.ToArray());
                single[0] = "MEASURE HOR_IN_LFT";/***/single[1] = summary.INSP_METHOD_HOR_IN_LFT; /**/ex.data.Add(single.ToArray());
                single[0] = "MEASURE HOR_IN_RHT";/***/single[1] = summary.INSP_METHOD_HOR_IN_RHT; /**/ex.data.Add(single.ToArray());
                single[0] = "MEASURE HOR_EX_RHT";/***/single[1] = summary.INSP_METHOD_HOR_EX_RHT; /**/ex.data.Add(single.ToArray());

                single[0] = "MEASURE VER_EX_TOP";/***/single[1] = summary.INSP_METHOD_VER_EX_TOP; /**/ex.data.Add(single.ToArray());
                single[0] = "MEASURE VER_IN_TOP";/***/single[1] = summary.INSP_METHOD_VER_IN_TOP; /**/ex.data.Add(single.ToArray());
                single[0] = "MEASURE VER_IN_BTM";/***/single[1] = summary.INSP_METHOD_VER_IN_BTM; /**/ex.data.Add(single.ToArray());
                single[0] = "MEASURE VER_EX_BTM";/***/single[1] = summary.INSP_METHOD_VER_EX_BTM; /**/ex.data.Add(single.ToArray());

                 
                single[0] = "SIGMA_X";/***/single[1] = sigmaOVL.DX.ToString("F4"); /**/ex.data.Add(single.ToArray());
                single[0] = "SIGMA_Y";/***/single[1] = sigmaOVL.DY.ToString("F4"); /**/ex.data.Add(single.ToArray());
                single[0] = single[1] = ""; ex.data.Add(single.ToArray());
            }
            if (listOverlay.Count != 0)
            {
                 //*******************************************************************************
                // Entire Data Chart In detail : Column Generation
                //*******************************************************************************

                // column header [Empty] + [Index 0]...[Index N-1]
                int nIterationCount = listOverlay.ElementAt(0).TOTAL_COUNT;
                int nHeaderLength = nIterationCount + 1;
                string[] arrHeader = new string[nHeaderLength];
                arrHeader[0] = "ITEM";

                for (int nColumn = 1; nColumn < nHeaderLength; nColumn++) { arrHeader[nColumn] = "ITER_" + nColumn.ToString("N0"); }
                ex.data.Add(arrHeader.ToArray());

                //*******************************************************************************
                // Raw Data Listing
                //*******************************************************************************

                for (int nItem = 0; nItem < listOverlay.Count; nItem++)
                {
                    CMeasureReport.DataOverlay summary = listOverlay.ElementAt(nItem);

                    //*******************************************************************
                    // For overlay X
                    string[] rawData_X = new string[nHeaderLength];
                    rawData_X[0] = summary.INSP_TARGET_NAME + "OLX";
                    for (int i = 0; i < nIterationCount; i++)
                    {
                        rawData_X[i + 1] = summary.listRaw_Overlay.ElementAt(i).DX.ToString("F4");
                    }
                    ex.data.Add(rawData_X.ToArray());

                    //*******************************************************************
                    // for Overlay Y 
                    string[] rawData_Y = new string[nHeaderLength];
                    rawData_Y[0] = summary.INSP_TARGET_NAME + "OLY";
                    for (int i = 0; i < nIterationCount; i++)
                    {
                        rawData_Y[i + 1] = summary.listRaw_Overlay.ElementAt(i).DY.ToString("F4");
                    }
                    ex.data.Add(rawData_Y.ToArray());
                }
            }
            string strDumpFileName = Computer.GetTimeCode4Save() + ".XLSX";
            string strDumpFilePath = Path.Combine(DEF_PATH.PATH_DUMP, strDumpFileName);

            if (CHK_MEASURE_DUMP.Checked == true)
            {
                ex.Dump_Data(strDumpFilePath);
                WrapperExcel.ExcuteExcel(strDumpFilePath);
            }
        }

        private void BTN_UPDATE_PARAMETER_EMPTY()
        {
            UC_PARAMETER.ClearData();
        }
        private bool IsInvalidParameters(Object obj)
        {
            CMeasurePairHor singleHor = new CMeasurePairHor();
            CMeasurePairVer singleVer = new CMeasurePairVer();
            CMeasurePairDig singleDig = new CMeasurePairDig();
            CMeasurePairCir singleCIr = new CMeasurePairCir();

            bool bError = false;

            /**/if (obj.GetType() == singleHor.GetType())
            {
                CMeasurePairHor org = (CMeasurePairHor)obj;

                if (org.measure_TOP == IFX_MEASURE_TYPE.ZERO_CROSS && org.ZC_MAG <= 0) { bError |= true; }
                if (org.measure_TOP == IFX_MEASURE_TYPE.ZERO_CROSS && org.ZC_MAG <= 0) { bError |= true; }

                if( bError == true)
                {
                    MessageBox.Show("Invalid Parameter.\n Incorrect Mag Value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return bError;
                }

                if (org.measure_TOP == IFX_MEASURE_TYPE.ZERO_CROSS && org.DIR_TOP != -1 && org.DIR_TOP != 1) { bError |= true; }
                if (org.measure_BTM == IFX_MEASURE_TYPE.ZERO_CROSS && org.DIR_BTM != -1 && org.DIR_BTM != 1) { bError |= true; }

                if (bError == true)
                {
                    MessageBox.Show("Invalid Parameter.\n Incorrect Searching Direction.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return bError;
                }
            }
            else if (obj.GetType() == singleVer.GetType())
            {
                CMeasurePairVer org = (CMeasurePairVer)obj;

                if (org.measure_LFT == IFX_MEASURE_TYPE.ZERO_CROSS && org.ZC_MAG <= 0) { bError |= true; }
                if (org.measure_RHT == IFX_MEASURE_TYPE.ZERO_CROSS && org.ZC_MAG <= 0) { bError |= true; }

                if (bError == true)
                {
                    MessageBox.Show("Invalid Parameter.\n Incorrect Mag Value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return bError;
                }

                if (org.measure_LFT == IFX_MEASURE_TYPE.ZERO_CROSS && org.DIR_LFT != -1 && org.DIR_LFT != 1) { bError |= true; }
                if (org.measure_RHT == IFX_MEASURE_TYPE.ZERO_CROSS && org.DIR_RHT != -1 && org.DIR_RHT != 1) { bError |= true; }

                if (bError== true)
                {
                    MessageBox.Show("Invalid Parameter.\n Incorrect Searching Direction.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return bError;
                }
            }
            else if (obj.GetType() == singleDig.GetType())
            {
                CMeasurePairDig org = (CMeasurePairDig)obj;

                if (org.measure_FST == IFX_MEASURE_TYPE.ZERO_CROSS && org.ZC_MAG <= 0) { bError |= true; }
                if (org.measure_SCD == IFX_MEASURE_TYPE.ZERO_CROSS && org.ZC_MAG <= 0) { bError |= true; }

                if (bError == true)
                {
                    MessageBox.Show("Invalid Parameter.\n Incorrect Mag Value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return bError;
                }

                if (org.measure_FST == IFX_MEASURE_TYPE.ZERO_CROSS && org.DIR_FST != -1 && org.DIR_FST != 1) { bError |= true; }
                if (org.measure_SCD == IFX_MEASURE_TYPE.ZERO_CROSS && org.DIR_SCD != -1 && org.DIR_SCD != 1) { bError |= true; }

                if (bError == true)
                {
                    MessageBox.Show("Invalid Parameter.\n Incorrect Searching Direction.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return bError;
                }
            }
            else if (obj.GetType() == singleCIr.GetType())
            {
                CMeasurePairCir org = (CMeasurePairCir)obj;

                if (org.measure_CIR == IFX_MEASURE_TYPE.ZERO_CROSS && org.ZC_MAG <= 0)
                {
                    MessageBox.Show("Invalid Parameter.\n Incorrect Mag Value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
                }

                if (org.measure_CIR == IFX_MEASURE_TYPE.ZERO_CROSS && org.DIR != -1 && org.DIR != 1)
                {
                    MessageBox.Show("Invalid Parameter.\n Incorrect Searching Direction.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
                }

            }

            return bError;
        }
        private void BTN_UPDATE_PARAMETER_Click(object sender, EventArgs e)
        {
            // exception
            if (LV_PARAMETER.FocusedItem == null) return; 
            int nIndexLV = LV_PARAMETER.FocusedItem.Index;
            
            // get selection index
            string strSelected = LV_PARAMETER.Items[nIndexLV].SubItems[1].Text;
            string[] parse = strSelected.Split('-');

            string strHeader = parse[0];
            int nSelectedIndex = Convert.ToInt32(parse[1]);

            object objectSelected = UC_PARAMETER.GetCurrentData();

            if (IFX_FIGURE.ToStringType(IFX_FIGURE.PAIR_HOR) == IFX_FIGURE.ToStringType(IFX_FIGURE.ToNumericType(strHeader)))
            {
                CMeasurePairHor org = (CMeasurePairHor)imageView1.iGet_Figure(IFX_FIGURE.PAIR_HOR, nSelectedIndex);

                string strOrgName = org.GetType().ToString();
                string strObjName = objectSelected.GetType().ToString();

                if (strOrgName.Contains("PairHor") == false || strObjName.Contains("PairHor") == false)
                {
                    MessageBox.Show("Wrong Target Selection", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                    return;  // exception for the cross selection
                }

                CMeasurePairHor obj = ((PROPERTY_PairHor)objectSelected).ToFigure();

                if (org.NICKNAME == obj.NICKNAME)
                {
                    org = obj.CopyTo();

                    if (IsInvalidParameters(org) == true) return;

                    imageView1.iMod_Figure(org, nSelectedIndex);
                    MessageBox.Show("Parameters has modified.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (IFX_FIGURE.ToStringType(IFX_FIGURE.PAIR_VER) == IFX_FIGURE.ToStringType(IFX_FIGURE.ToNumericType(strHeader)))
            {
                CMeasurePairVer org = (CMeasurePairVer)imageView1.iGet_Figure(IFX_FIGURE.PAIR_VER, nSelectedIndex);

                string strOrgName = org.GetType().ToString();
                string strObjName = objectSelected.GetType().ToString();
                if (strOrgName.Contains("PairVer") == false || strObjName.Contains("PairVer") == false)
                {
                    MessageBox.Show("Wrong Target Selection", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                    return;  // exception for the cross selection
                }

                CMeasurePairVer obj = ((PROPERTY_PairVer)objectSelected).ToFigure();

                if (org.NICKNAME == obj.NICKNAME)
                {
                    org = obj.CopyTo();

                    if (IsInvalidParameters(org) == true) return;

                    imageView1.iMod_Figure(org, nSelectedIndex);
                    MessageBox.Show("Parameters has modified.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if(IFX_FIGURE.ToStringType(IFX_FIGURE.PAIR_DIG) == IFX_FIGURE.ToStringType(IFX_FIGURE.ToNumericType(strHeader)))
            {
                CMeasurePairDig org = (CMeasurePairDig)imageView1.iGet_Figure(IFX_FIGURE.PAIR_DIG, nSelectedIndex);

                string strOrgName = org.GetType().ToString();
                string strObjName = objectSelected.GetType().ToString();
                if (strOrgName.Contains("PairDig") == false || strObjName.Contains("PairDig") == false)
                {
                    MessageBox.Show("Wrong Target Selection", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;  // exception for the cross selection
                }

                CMeasurePairDig obj = ((PROPERTY_PairDig)objectSelected).ToFigure();

                if (org.NICKNAME == obj.NICKNAME)
                {
                    // backup and Recovery
                    obj.angle = org.angle;

                    org = obj.CopyTo();

                    if (IsInvalidParameters(org) == true) return;
                    
                    imageView1.iMod_Figure(org, nSelectedIndex);
                    MessageBox.Show("Parameters has modified.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if(IFX_FIGURE.ToStringType(IFX_FIGURE.PAIR_CIR) == IFX_FIGURE.ToStringType(IFX_FIGURE.ToNumericType(strHeader)))
            {
                CMeasurePairCir org = (CMeasurePairCir)imageView1.iGet_Figure(IFX_FIGURE.PAIR_CIR, nSelectedIndex);

                string strOrgName = org.GetType().ToString();
                string strObjName = objectSelected.GetType().ToString();
                if (strOrgName.Contains("PairCir") == false || strObjName.Contains("PairCir") == false)
                {
                    MessageBox.Show("Wrong Target Selection", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;  // exception for the cross selection
                }

                CMeasurePairCir obj = ((PROPERTY_PairCir)objectSelected).ToFigure();

                if (org.NICKNAME == obj.NICKNAME)
                {
                    org = obj.CopyTo();

                    if (IsInvalidParameters(obj) == true) return;
                    
                    imageView1.iMod_Figure(org, nSelectedIndex);
                    MessageBox.Show("Parameters has modified.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (IFX_FIGURE.ToStringType(IFX_FIGURE.PAIR_OVL) == IFX_FIGURE.ToStringType(IFX_FIGURE.ToNumericType(strHeader)))
            {
                CMeasurePairOvl org = (CMeasurePairOvl)imageView1.iGet_Figure(IFX_FIGURE.PAIR_OVL, nSelectedIndex);

                string strOrgName = org.GetType().ToString();
                string strobjName = objectSelected.GetType().ToString();

                if( strobjName.Contains("PairOvl") == false || strobjName.Contains("PairOvl") == false)
                {
                    MessageBox.Show("Wrong Target Selection", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                CMeasurePairOvl obj = ((PROPERTY_PairOvl)objectSelected).ToFigure();

                if (org.NICKNAME == obj.NICKNAME)
                {
                    org = obj.CopyTo();

                    if (IsInvalidParameters(obj) == true) return;

                    imageView1.iMod_Figure(org, nSelectedIndex);
                    MessageBox.Show("Parameters has modified.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            imageView1.Refresh();
        }

        private void BTN_PTRN_TEACHING_LOAD_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "BMP files (*.BMP)|*.bmp|JPG files (*.JPG)|*.JPG|PNG files (*.PNG)|*.PNG|All files (*.*)|*.*";
            dlg.InitialDirectory = DEF_PATH.PATH_PTRN;

            if (dlg.ShowDialog() != DialogResult.OK)
                return;

            TXT_PTRN_FILE_NAME.Text = Path.GetFileName(dlg.FileName);
            TXT_PTRN_PATH.Text = dlg.FileName.Replace(TXT_PTRN_FILE_NAME.Text,"");

            imageView1.fm.PTRN_TEACH_FILE = dlg.FileName;


        }

        private void BTN_PTRN_MATCH_Click(object sender, EventArgs e)
        {
            if (TXT_PTRN_PATH.Text != null && TXT_PTRN_FILE_NAME.Text != null)
            {
                int imageW = imageView1.VIEW_GetImageW();
                int imageH = imageView2.VIEW_GetImageH();

                imageView1.VIEW_Set_Clear_DispObject();

                RectangleF rcBasement = new RectangleF();
                PointF ptGravity = DO_PTRN_And_Get_Center(out rcBasement);

                imageView1.fm.SetBaseCroodinate(ptGravity);
                imageView1.DrawPoint(ptGravity, 100, (float) 5, Color.Magenta);
                imageView1.DrawRect(rcBasement, Color.Magenta);

                imageView1.Refresh();
            }
            else { MessageBox.Show("PTRN Data Not Found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void BTN_SET_RELATIVE_POSITION_Click(object sender, EventArgs e)
        {
            if (TXT_PTRN_PATH.Text != null && TXT_PTRN_FILE_NAME.Text != null)
            {
                int imageW = imageView1.VIEW_GetImageW();
                int imageH = imageView2.VIEW_GetImageH();

                imageView1.VIEW_Set_Clear_DispObject();

                RectangleF rcBasement = new RectangleF();
                PointF ptGravity = DO_PTRN_And_Get_Center(out rcBasement);

                imageView1.fm.SetRelativeCroodinate(ptGravity);
                imageView1.DrawPoint(ptGravity, 100, 5, Color.Magenta);
                imageView1.DrawRect(rcBasement, Color.Magenta);

                imageView1.Refresh();
            }
            else { MessageBox.Show("PTRN Data Not Found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void PANEL_MESSAGE_WINDOW_DragEnter(object sender, DragEventArgs e)
        {
          
            
        }

        

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            milsys.SetBoardRelease();
        }

        private void PANEL_MESSAGE_WINDOW_DragDrop(object sender, DragEventArgs e)
        {
            
        }

        private void CHK_MEASURE_VIEW_ONLY_CheckedChanged(object sender, EventArgs e)
        {
            if (CHK_MEASURE_VIEW_ONLY.Checked == true)
            {
                PRINT_MSG("Measurement Target → File List");
            }
            else if (CHK_MEASURE_VIEW_ONLY.Checked == false)
            {
                PRINT_MSG("Measurement Target → Image View");
            }
        }

        private void LV_FILE_LIST_SelectedIndexChanged(object sender, EventArgs e) { }

        private void LV_FILE_LIST_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (LV_FILE_LIST.FocusedItem == null) return;

            int nIndex = LV_FILE_LIST.FocusedItem.Index;

            string strSelected = LV_FILE_LIST.Items[nIndex].SubItems[1].Text;

            if (File.Exists(strSelected) == true)
            {
                Bitmap bmp = (Bitmap)Bitmap.FromFile(strSelected);
                imageView1.SetDisplay(bmp);
                imageView1.VIEW_SET_Mag_Origin();

                BTN_MEASURE_Click("SELECTABLE", EventArgs.Empty);
            }

            
        }
        private void Update_PTRN_Files()
        {
            //************************************************************************************
            // Get PTRN Files
            
            string[] arrPtrnFiles = Directory.GetFiles(DEF_PATH.PATH_PTRN, "*.BMP");
            LV_PTRN.Items.Clear();
            for (int i = 0; i < arrPtrnFiles.Length; i++)
            {
                string strFile = Path.GetFileName(arrPtrnFiles.ElementAt(i));
            
                ListViewItem lvi = new ListViewItem();
                lvi.Text = (i + 1).ToString("N0");
                lvi.SubItems.Add(strFile);
            
                LV_PTRN.Items.Add(lvi);
            }
        }

        private void BTN_UPDATE_FIGURE_LIST_Click(object sender, EventArgs e)
        {
            CFigureManager fm = imageView1.fm.Clone() as CFigureManager;

            LV_PAIR_HOR.Items.Clear();
            LV_PAIR_VER.Items.Clear();
            LV_PAIR_DIG.Items.Clear();
            LV_PAIR_CIR.Items.Clear();
            LV_PAIR_OVL.Items.Clear();
            
            //*************************************************************************************
            // horizontal rect pair
            //*************************************************************************************
            for (int nIndex = 0; nIndex < fm.COUNT_PAIR_HOR; nIndex++)
            {
                CMeasurePairHor single = fm.ElementAt_PairHor(nIndex);

                ListViewItem lvi = new ListViewItem();lvi.Text = nIndex.ToString("N0");
                lvi.SubItems.Add(string.Format("{0}_{1}", nIndex, single.NICKNAME ));

                LV_PAIR_HOR.Items.Add(lvi);
            }
            //*************************************************************************************
            // vertical rect pair
            //*************************************************************************************
            for (int nIndex = 0; nIndex < fm.COUNT_PAIR_VER; nIndex++)
            {
                CMeasurePairVer single = fm.ElementAt_PairVer(nIndex);

                ListViewItem lvi = new ListViewItem(); lvi.Text = nIndex.ToString("N0");
                lvi.SubItems.Add(string.Format("{0}_{1}", nIndex, single.NICKNAME));

                LV_PAIR_VER.Items.Add(lvi);
            }
            //*************************************************************************************
            // Digonal rect pair
            //*************************************************************************************
            for (int nIndex = 0; nIndex < fm.COUNT_PAIR_DIG; nIndex++)
            {
                CMeasurePairDig single = fm.ElementAt_PairDig(nIndex);

                ListViewItem lvi = new ListViewItem(); lvi.Text = nIndex.ToString("N0");
                lvi.SubItems.Add(string.Format("{0}_{1}", nIndex, single.NICKNAME));

                LV_PAIR_DIG.Items.Add(lvi);
            }
            //*************************************************************************************
            // circle
            //*************************************************************************************
            for (int nIndex = 0; nIndex < fm.COUNT_PAIR_CIR; nIndex++)
            {
                CMeasurePairCir single = fm.ElementAt_PairCir(nIndex);

                ListViewItem lvi = new ListViewItem(); lvi.Text = nIndex.ToString("N0");
                lvi.SubItems.Add(string.Format("{0}_{1}", nIndex, single.NICKNAME));

                LV_PAIR_CIR.Items.Add(lvi);
            }
            //*************************************************************************************
            // OverLay
            //*************************************************************************************
            for (int nIndex = 0; nIndex < fm.COUNT_PAIR_OVL; nIndex++)
            {
                CMeasurePairOvl single = fm.ElementAt_PairOvl(nIndex);

                ListViewItem lvi = new ListViewItem(); lvi.Text = nIndex.ToString("N0");
                lvi.SubItems.Add(string.Format("{0}_{1}", nIndex, single.NICKNAME));

                LV_PAIR_OVL.Items.Add(lvi);
            }

            imageView1.Refresh();
        }

        private void LV_PAIR_HOR_SelectedIndexChanged(object sender, EventArgs e){}
        private void LV_PAIR_VER_SelectedIndexChanged(object sender, EventArgs e){}
        private void LV_PAIR_DIG_SelectedIndexChanged(object sender, EventArgs e){}
        private void LV_PAIR_CIR_SelectedIndexChanged(object sender, EventArgs e){ }
        private void LV_PAIR_OL_SelectedIndexChanged(object sender, EventArgs e){}
        private void LV_RECTANGLE_SelectedIndexChanged(object sender, EventArgs e){ }

        private void LV_PAIR_HOR_DoubleClick(object sender, EventArgs e)
        {
            // initialization
            if (LV_PAIR_HOR.FocusedItem == null) return;
            
            int nIndex = LV_PAIR_HOR.FocusedItem.Index;
            UpdateFigureVariation(nIndex);
            
            // value assignment
            CFigureManager fm = imageView1.iGet_AllData();
            CMeasurePairHor single = fm.ElementAt_PairHor(nIndex);

            TXT_PARAM_HOR_NICK.Text = single.NICKNAME;
            
            // Get Crop part
            byte[] cropTop = null;
            byte[] cropBtm = null;
            
            RectangleF rcTOP = single.GetCompensatedRect(single.rc_TOP);
            RectangleF rcBTM = single.GetCompensatedRect(single.rc_BTM);

            imageView1.iGet_CropsRectPairNormal(rcTOP, rcBTM, out cropTop, out cropBtm);
            
            UC_GRAPH_MASTER.SetImage(m_DrawType_Master, cropTop, (int)rcTOP.Width, (int)rcTOP.Height);
            UC_GRAPH_SLAVE.SetImage(m_DrawType_Slave, cropBtm, (int)rcBTM.Width, (int)rcBTM.Height);
        }

        private void LV_PAIR_VER_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //initialization
            if (LV_PAIR_VER.FocusedItem == null) return;
            
            int nIndex = LV_PAIR_VER.FocusedItem.Index;
            UpdateFigureVariation(nIndex);
            
            // value assignment
            CFigureManager fm = imageView1.iGet_AllData();
            CMeasurePairVer single = fm.ElementAt_PairVer(nIndex);

            TXT_PARAM_VER_NICK.Text = single.NICKNAME;

            // Get Crop part
            byte[] cropTop = null;
            byte[] cropBtm = null;
            
            RectangleF rcLFT = single.GetCompensatedRect(single.rc_LFT);
            RectangleF rcRHT = single.GetCompensatedRect(single.rc_RHT);
            
            imageView1.iGet_CropsRectPairNormal(rcLFT, rcRHT, out cropTop, out cropBtm);
            
            // Apply selectional graph
            UC_GRAPH_MASTER.SetImage(m_DrawType_Master, cropTop, (int)single.rc_LFT.Width, (int)single.rc_LFT.Height);
            UC_GRAPH_SLAVE.SetImage(m_DrawType_Slave, cropBtm, (int)single.rc_RHT.Width, (int)single.rc_RHT.Height);
        }

        private void LV_PAIR_DIG_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // initialization
            if (LV_PAIR_DIG.FocusedItem == null) return;
            
            int nIndex = LV_PAIR_DIG.FocusedItem.Index;
            UpdateFigureVariation(nIndex);
            
            // value assignment
            CFigureManager fm = imageView1.iGet_AllData();
            CMeasurePairDig single = fm.ElementAt_PairDig(nIndex);

            TXT_PARAM_DIG_NICK.Text = single.NICKNAME;
            TXT_PARAM_DIG_ANGLE.Text = single.angle.ToString("N0");
            
            byte[] cropTop = null;
            byte[] cropBtm = null;
            
            imageView1.iGet_CropsRectPairDigonal(single, out cropTop, out cropBtm);
            
            RectangleF rc_FST = single.GetRectOrigin_FST();
            RectangleF rc_SCD = single.GetRectOrigin_SCD();
            
            UC_GRAPH_MASTER.SetImage(m_DrawType_Master, cropTop, (int)rc_FST.Width, (int)rc_FST.Height);
            UC_GRAPH_SLAVE.SetImage(m_DrawType_Slave, cropBtm, (int)rc_SCD.Width, (int)rc_SCD.Height);
        }

        private void LV_PAIR_CIR_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (LV_PAIR_CIR.FocusedItem == null) return;
            
            int nIndex = LV_PAIR_CIR.FocusedItem.Index;
            UpdateFigureVariation(nIndex);
            
            CFigureManager fm = imageView1.iGet_AllData();
            CMeasurePairCir single = fm.ElementAt_PairCir(nIndex);

            TXT_PARAM_CIR_NICK.Text = single.NICKNAME;
            
            byte[] cropTop = null;
            byte[] cropBtm = null;
            
            imageView1.iGet_CropsCircle(single, out cropTop, out cropBtm);
            
            int nCX = (int)(single.rc_EX.Width / 2.0);
            int nCY = (int)(single.rc_EX.Height / 2.0);
            int nRadi = Math.Max(nCX, nCY);
            
            UC_GRAPH_MASTER.SetImage(m_DrawType_Master, cropTop, 360, nRadi);
            UC_GRAPH_SLAVE.SetImage(m_DrawType_Slave, cropBtm, 360, nRadi);
        }

        private void LV_PAIR_OL_DoubleClick(object sender, EventArgs e)
        {
            if (LV_PAIR_OVL.FocusedItem == null) return;

            int nIndex = LV_PAIR_OVL.FocusedItem.Index;
            UpdateFigureVariation(nIndex);

        }


        private void LV_PTRN_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if( LV_PTRN.FocusedItem == null) return;

            int nIndex = LV_PTRN.FocusedItem.Index;

            string strFileName = LV_PTRN.Items[nIndex].SubItems[1].Text;
            
            string strFullFilePath = Path.Combine( DEF_PATH.PATH_PTRN, strFileName);

            SetView_PTRN(strFullFilePath);
        }

        private void BTN_HOR_ADD_Click(object sender, EventArgs e)
        {
            if (imageView1.BOOL_TEACHING_ACTIVATION == false) return;

            imageView1.VIEW_Set_Overlay(true);
            CMeasurePairHor single = new CMeasurePairHor();

            PointF ptDraw = imageView1.PT_FIGURE_TO_DRAW;

            // assign default coordinate
            single.NICKNAME = "HOR";
            single.rc_TOP = new RectangleF(ptDraw.X, ptDraw.Y, 100, 30);
            single.rc_BTM = new RectangleF(ptDraw.X, ptDraw.Y + 50, 100, 30);

            imageView1.fm.Figure_Add(single);
            
            BTN_UPDATE_FIGURE_LIST_Click(null, EventArgs.Empty);
        }

        private void BTN_VER_ADD_Click(object sender, EventArgs e)
        {
            if (imageView1.BOOL_TEACHING_ACTIVATION == false) return;

            imageView1.VIEW_Set_Overlay(true);
            CMeasurePairVer single = new CMeasurePairVer();

            PointF ptDraw = imageView1.PT_FIGURE_TO_DRAW;

            single.NICKNAME = "VER";
            single.rc_LFT = new RectangleF(ptDraw.X + 00, ptDraw.Y, 30, 100);
            single.rc_RHT = new RectangleF(ptDraw.X + 50, ptDraw.Y, 30, 100);

            imageView1.fm.Figure_Add(single);
            BTN_UPDATE_FIGURE_LIST_Click(null, EventArgs.Empty);
        }

        private void BTN_DIG_ADD_Click(object sender, EventArgs e)
        {
            if (imageView1.BOOL_TEACHING_ACTIVATION == false) return;

            imageView1.VIEW_Set_Overlay(true);
            CMeasurePairDig single = new CMeasurePairDig();

            PointF ptDraw = imageView1.PT_FIGURE_TO_DRAW;

            single.NICKNAME = "DIG";
            single.rc_FST = new parseRect(ptDraw.X + 00, ptDraw.Y, 30, 100);
            single.rc_SCD = new parseRect(ptDraw.X + 50, ptDraw.Y, 30, 100);

            imageView1.fm.Figure_Add(single);
            BTN_UPDATE_FIGURE_LIST_Click(null, EventArgs.Empty);
        }

        private void BTN_CIR_ADD_Click(object sender, EventArgs e)
        {
            if (imageView1.BOOL_TEACHING_ACTIVATION == false) return;

            imageView1.VIEW_Set_Overlay(true);
            CMeasurePairCir single = new CMeasurePairCir();

            PointF ptDraw = imageView1.PT_FIGURE_TO_DRAW;

            single.NICKNAME = "CIR";
            single.rc_EX = new RectangleF(ptDraw.X - 50, ptDraw.Y -50, 100, 100);
            single.rc_IN = new RectangleF(0, 0, 5, 5);
            single.rc_IN = CRect.SetCenter(single.rc_EX, single.rc_IN);

            //single.rc_IN = new RectangleF(ptDraw.X - single.BAND_WIDTH, ptDraw.Y - single.BAND_WIDTH, 30, 30);

            imageView1.fm.Figure_Add(single);
            BTN_UPDATE_FIGURE_LIST_Click(null, EventArgs.Empty);
        }

        private void BTN_OL_ADD_Click(object sender, EventArgs e)
        {
            if (imageView1.BOOL_TEACHING_ACTIVATION == false) return;

            imageView1.VIEW_Set_Overlay(true);
            CMeasurePairOvl single = new CMeasurePairOvl();

            PointF ptDraw = imageView1.PT_FIGURE_TO_DRAW;

            single.NICKNAME = "OL";

            single.RC_HOR_IN.rc_LFT = new RectangleF(ptDraw.X - 150, ptDraw.Y - 50, 50, 100);
            single.RC_HOR_IN.rc_RHT = new RectangleF(ptDraw.X + 100, ptDraw.Y - 50, 50, 100); 
            
            single.RC_HOR_EX.rc_LFT = new RectangleF(ptDraw.X - 300, ptDraw.Y - 50, 50, 100);
            single.RC_HOR_EX.rc_RHT = new RectangleF(ptDraw.X + 250, ptDraw.Y - 50, 50, 100);
            
            single.RC_VER_IN.rc_TOP = new RectangleF(ptDraw.X - 050, ptDraw.Y - 150, 100, 50);
            single.RC_VER_IN.rc_BTM = new RectangleF(ptDraw.X - 050, ptDraw.Y + 100, 100, 50);
            
            single.RC_VER_EX.rc_TOP = new RectangleF(ptDraw.X - 050, ptDraw.Y - 300, 100, 50);
            single.RC_VER_EX.rc_BTM = new RectangleF(ptDraw.X - 050, ptDraw.Y + 250, 100, 50);
            

            imageView1.fm.Figure_Add(single);

            BTN_UPDATE_FIGURE_LIST_Click(null, EventArgs.Empty);

        }

        private void BTN_HOR_REMOVE_Click(object sender, EventArgs e)
        {
            if (LV_PAIR_HOR.FocusedItem != null)
            {
                int nIndex = LV_PAIR_HOR.FocusedItem.Index;
                imageView1.fm.Figure_Remove(IFX_FIGURE.PAIR_HOR, nIndex);
                BTN_UPDATE_FIGURE_LIST_Click(null, EventArgs.Empty);
            }
        }

        private void BTN_VER_REMOVE_Click(object sender, EventArgs e)
        {
            if (LV_PAIR_VER.FocusedItem != null)
            {
                int nIndex = LV_PAIR_VER.FocusedItem.Index;
                imageView1.fm.Figure_Remove(IFX_FIGURE.PAIR_VER, nIndex);
                BTN_UPDATE_FIGURE_LIST_Click(null, EventArgs.Empty);
            }
        }

        private void BTN_DIG_REMOVE_Click(object sender, EventArgs e)
        {
            if (LV_PAIR_DIG.FocusedItem != null)
            {
                int nIndex = LV_PAIR_DIG.FocusedItem.Index;
                imageView1.fm.Figure_Remove(IFX_FIGURE.PAIR_DIG, nIndex);
                BTN_UPDATE_FIGURE_LIST_Click(null, EventArgs.Empty);
            }
        }

        private void BTN_CIR_REMOVE_Click(object sender, EventArgs e)
        {
            if (LV_PAIR_CIR.FocusedItem != null)
            {
                int nIndex = LV_PAIR_CIR.FocusedItem.Index;
                imageView1.fm.Figure_Remove(IFX_FIGURE.PAIR_CIR, nIndex);
                BTN_UPDATE_FIGURE_LIST_Click(null, EventArgs.Empty);
            }
        }


        private void BTN_OL_REMOVE_Click(object sender, EventArgs e)
        {
            if (LV_PAIR_OVL.FocusedItem != null)
            {
                int nIndex = LV_PAIR_OVL.FocusedItem.Index;
                imageView1.fm.Figure_Remove(IFX_FIGURE.PAIR_OVL, nIndex);
                BTN_UPDATE_FIGURE_LIST_Click(null, EventArgs.Empty);
            }

        }


        private void LV_FIGURE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Handled) return;

            int nFigureIndex = TAB_FIGURE.SelectedIndex;
            int nDataIndex = IFX_FIGURE.PAIR_HOR; // just set defalut value 

            //********************************************************************
            // Invalid Focus exception

            /***/if (nFigureIndex == IFX_FIGURE.PAIR_HOR && LV_PAIR_HOR.Focused == false) { return; }
            else if (nFigureIndex == IFX_FIGURE.PAIR_VER && LV_PAIR_VER.Focused == false) { return; }
            else if (nFigureIndex == IFX_FIGURE.PAIR_DIG && LV_PAIR_DIG.Focused == false) { return; }
            else if (nFigureIndex == IFX_FIGURE.PAIR_CIR && LV_PAIR_CIR.Focused == false) { return; }
            else if (nFigureIndex == IFX_FIGURE.PAIR_OVL && LV_PAIR_OVL.Focused == false) { return; }

            int tx = TB_FIGURE_CTRL_SCALE.Value;
            int ty = TB_FIGURE_CTRL_SCALE.Value; ;

             /***/if (nFigureIndex == IFX_FIGURE.PAIR_HOR){if (LV_PAIR_HOR.FocusedItem == null) return;nDataIndex = LV_PAIR_HOR.FocusedItem.Index;}
             else if (nFigureIndex == IFX_FIGURE.PAIR_VER){if (LV_PAIR_VER.FocusedItem == null) return;nDataIndex = LV_PAIR_VER.FocusedItem.Index;}
             else if (nFigureIndex == IFX_FIGURE.PAIR_DIG){if (LV_PAIR_DIG.FocusedItem == null) return;nDataIndex = LV_PAIR_DIG.FocusedItem.Index;}
             else if (nFigureIndex == IFX_FIGURE.PAIR_CIR){if (LV_PAIR_CIR.FocusedItem == null) return;nDataIndex = LV_PAIR_CIR.FocusedItem.Index;}
             else if (nFigureIndex == IFX_FIGURE.PAIR_OVL) { if (LV_PAIR_OVL.FocusedItem == null) return; nDataIndex = LV_PAIR_OVL.FocusedItem.Index; }
            //********************************************************************
            //apply directional operation 

             int m_nAction = 0;
             /***/if (RDO_ROI_POSITION.Checked == true) m_nAction = IFX_ADJ_ACTION.POS;
             else if (RDO_ROI_GAP.Checked /***/== true) m_nAction = IFX_ADJ_ACTION.GAP;
             else if (RDO_ROI_SIZE.Checked /**/== true) m_nAction = IFX_ADJ_ACTION.SIZE;
             else if (RDO_ROI_ASYM.Checked /**/== true) m_nAction = IFX_ADJ_ACTION.ASYM;



            if (e.KeyCode == Keys.P || e.KeyCode == Keys.G || e.KeyCode == Keys.S || e.KeyCode == Keys.Z)
            {
                string mode = string.Empty;

                /***/if (e.KeyCode == Keys.P) { RDO_ROI_POSITION.Checked = true; mode = "POSITION ADJUST"; }
                else if (e.KeyCode == Keys.G) { RDO_ROI_GAP.Checked /***/= true; mode = "GAP ADJUST"; }
                else if (e.KeyCode == Keys.S) { RDO_ROI_SIZE.Checked /**/= true; mode = "SIZE ADJUST"; }
                else if (e.KeyCode == Keys.Z) { RDO_ROI_ASYM.Checked/**/ = true; mode = "ZIG ZAG ADJUST"; }
                MessageBox.Show("MODE CHANGE : " + mode, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
            else if (e.KeyCode == Keys.PageUp || e.KeyCode == Keys.PageDown)
            {
                /***/if(e.KeyCode == Keys.PageUp ) BTN_DIG_ANGLE_UP_Click(null, EventArgs.Empty);
                else if(e.KeyCode == Keys.PageDown)BTN_DIG_ANGLE_DW_Click(null, EventArgs.Empty);
            }
            else if (e.KeyCode == Keys.Add || e.KeyCode == Keys.Subtract)
            {
                /***/if (e.KeyCode == Keys.Add/***/){BTN_CHANGE_FIGURE_CONTROL_LEVEL(+1);}
                else if (e.KeyCode == Keys.Subtract){BTN_CHANGE_FIGURE_CONTROL_LEVEL(-1);}
            }
            else
            {
                if (nFigureIndex == IFX_FIGURE.PAIR_OVL) // only for overlay figure
                {
                    int nTarget = RDO_ROI_OVL_IN.Checked == true ? 0 : RDO_ROI_OVL_EX.Checked == true ? 1 : -1;

                    int nDir = 0;

                    /***/if (e.KeyCode == Keys.Left)/****/nDir = IFX_DIR.DIR_LFT;
                    else if (e.KeyCode == Keys.Up)/******/nDir = IFX_DIR.DIR_TOP;
                    else if (e.KeyCode == Keys.Right)/***/nDir = IFX_DIR.DIR_RHT;
                    else if (e.KeyCode == Keys.Down)/****/nDir = IFX_DIR.DIR_BTM;

                    if (nTarget != -1) // 0 or 1 Special target 
                    {
                        imageView1.iAdj_Overlay(m_nAction, nTarget, nDataIndex, nDir, TB_FIGURE_CTRL_SCALE.Value);
                    }
                    else if (nTarget == -1) // NON SELECTION : ENTIARE TARGET
                    {
                        imageView1.iAdj_Overlay(m_nAction, 0, nDataIndex, nDir, TB_FIGURE_CTRL_SCALE.Value);
                        imageView1.iAdj_Overlay(m_nAction, 1, nDataIndex, nDir, TB_FIGURE_CTRL_SCALE.Value);
                    }
                }
                else // for common figure 
                {
                    if (e.KeyCode == Keys.Left)
                    {
                        // 가독성을 위해서.. "if 문" <--- 
                        /***/if (m_nAction == IFX_ADJ_ACTION.POS/******/) imageView1.iAdj_Figure(nFigureIndex, nDataIndex, IFX_ADJ_ACTION.POS, -tx, 0);
                        else if (m_nAction == IFX_ADJ_ACTION.GAP/******/) imageView1.iAdj_Figure(nFigureIndex, nDataIndex, IFX_ADJ_ACTION.GAP, -tx, 0);
                        else if (m_nAction == IFX_ADJ_ACTION.SIZE/*****/) imageView1.iAdj_Figure(nFigureIndex, nDataIndex, IFX_ADJ_ACTION.SIZE, -tx, 0);
                    }
                    else if (e.KeyCode == Keys.Right)
                    {
                        /***/if (m_nAction == IFX_ADJ_ACTION.POS/******/) imageView1.iAdj_Figure(nFigureIndex, nDataIndex, IFX_ADJ_ACTION.POS, tx, 0);
                        else if (m_nAction == IFX_ADJ_ACTION.GAP/******/) imageView1.iAdj_Figure(nFigureIndex, nDataIndex, IFX_ADJ_ACTION.GAP, tx, 0);
                        else if (m_nAction == IFX_ADJ_ACTION.SIZE/*****/) imageView1.iAdj_Figure(nFigureIndex, nDataIndex, IFX_ADJ_ACTION.SIZE, tx, 0);
                    }
                    else if (e.KeyCode == Keys.Up)
                    {
                        /***/if (m_nAction == IFX_ADJ_ACTION.POS/******/) { imageView1.iAdj_Figure(nFigureIndex, nDataIndex, IFX_ADJ_ACTION.POS, 0, -ty); }
                        else if (m_nAction == IFX_ADJ_ACTION.GAP/******/) { imageView1.iAdj_Figure(nFigureIndex, nDataIndex, IFX_ADJ_ACTION.GAP, 0, -ty); }
                        else if (m_nAction == IFX_ADJ_ACTION.SIZE/*****/) { imageView1.iAdj_Figure(nFigureIndex, nDataIndex, IFX_ADJ_ACTION.SIZE, 0, -ty); }
                    }
                    else if (e.KeyCode == Keys.Down)
                    {
                        /***/if (m_nAction == IFX_ADJ_ACTION.POS/******/) imageView1.iAdj_Figure(nFigureIndex, nDataIndex, IFX_ADJ_ACTION.POS, 0, ty);
                        else if (m_nAction == IFX_ADJ_ACTION.GAP/******/) imageView1.iAdj_Figure(nFigureIndex, nDataIndex, IFX_ADJ_ACTION.GAP, 0, ty);
                        else if (m_nAction == IFX_ADJ_ACTION.SIZE/*****/) imageView1.iAdj_Figure(nFigureIndex, nDataIndex, IFX_ADJ_ACTION.SIZE, 0, ty);
                    }
                }
                UpdateFigureVariation(nDataIndex);
            }

            // to prevent envet duplication
            e.Handled = true;
        }

        private void UpdateFigureVariation(int nDataIndex)
        {
            CFigureManager fm = imageView1.iGet_AllData();

            //********************************************************************
            // select figure type

            int nFigureIndex = TAB_FIGURE.SelectedIndex;

            if (nFigureIndex == IFX_FIGURE.PAIR_HOR)
            {
                CMeasurePairHor single = fm.ElementAt_PairHor(nDataIndex);
                TXT_RCH_W.Text = single.rc_TOP.Width.ToString("N0");
                TXT_RCH_H.Text = single.rc_TOP.Height.ToString("N0");
            }
            else if (nFigureIndex == IFX_FIGURE.PAIR_VER)
            {
                CMeasurePairVer single = fm.ElementAt_PairVer(nDataIndex);
                TXT_RCV_W.Text = single.rc_LFT.Width.ToString("N0");
                TXT_RCV_H.Text = single.rc_LFT.Height.ToString("N0");
            }
            else if (nFigureIndex == IFX_FIGURE.PAIR_DIG)
            {
                CMeasurePairDig single = fm.ElementAt_PairDig(nDataIndex);
                TXT_RCD_W.Text = single.rc_FST.Width.ToString("N0");
                TXT_RCD_H.Text = single.rc_FST.Height.ToString("N0");
            }
            else if (nFigureIndex == IFX_FIGURE.PAIR_CIR)
            {
                CMeasurePairCir single = fm.ElementAt_PairCir(nDataIndex);
                TXT_CIRCLE_W.Text = single.rc_EX.Width.ToString("N0");
                TXT_CIRCLE_H.Text = single.rc_EX.Height.ToString("N0");
            }
            else if (nFigureIndex == IFX_FIGURE.PAIR_OVL)
            {
                CMeasurePairOvl single = fm.ElementAt_PairOvl(nDataIndex);
                TXT_OVL_IN_W.Text = single.RC_VER_IN.rc_TOP.Width.ToString("N0");
                TXT_OVL_IN_H.Text = single.RC_VER_IN.rc_TOP.Height.ToString("N0");

                TXT_OVL_EX_W.Text = single.RC_VER_EX.rc_TOP.Width.ToString("N0");
                TXT_OVL_EX_H.Text = single.RC_VER_EX.rc_TOP.Height.ToString("N0");
            }
        }

        private void TB_FIGURE_CTRL_SCALE_Scroll(object sender, EventArgs e)
        {
            TXT_FIGURE_CONTROL_SCALE.Text = TB_FIGURE_CTRL_SCALE.Value.ToString("N0");
        }

        private void BTN_HOR_COPY_Click(object sender, EventArgs e)
        {
            if (LV_PAIR_HOR.FocusedItem == null) return;
            int nIndex = LV_PAIR_HOR.FocusedItem.Index;

            CMeasurePairHor temp = (CMeasurePairHor)imageView1.fm.ElementAt_PairHor(nIndex);
            
            CMeasurePairHor single = temp.CopyTo();
            imageView1.fm.Figure_Add(single);
            BTN_UPDATE_FIGURE_LIST_Click(null, EventArgs.Empty);
        }

        private void BTN_VER_COPY_Click(object sender, EventArgs e)
        {
            if (LV_PAIR_VER.FocusedItem == null) return;
            int nIndex = LV_PAIR_VER.FocusedItem.Index;

            CMeasurePairVer temp = (CMeasurePairVer)imageView1.fm.ElementAt_PairVer(nIndex);
            CMeasurePairVer single = temp.CopyTo();

            imageView1.fm.Figure_Add(single);
            BTN_UPDATE_FIGURE_LIST_Click(null, EventArgs.Empty);
        }

        private void BTN_DIG_COPY_Click(object sender, EventArgs e)
        {
            if (LV_PAIR_DIG.FocusedItem == null) return;
            int nIndex = LV_PAIR_DIG.FocusedItem.Index;

            CMeasurePairDig temp = (CMeasurePairDig)imageView1.fm.ElementAt_PairDig(nIndex);
            CMeasurePairDig single = temp.CopyTo();

            imageView1.fm.Figure_Add(single);
            BTN_UPDATE_FIGURE_LIST_Click(null, EventArgs.Empty);
        }

        private void BTN_CIR_COPY_Click(object sender, EventArgs e)
        {
            if (LV_PAIR_CIR.FocusedItem == null) return;
            int nIndex = LV_PAIR_CIR.FocusedItem.Index;

            CMeasurePairCir temp = (CMeasurePairCir)imageView1.fm.ElementAt_PairCir(nIndex);
            CMeasurePairCir single = temp.CopyTo();

            imageView1.fm.Figure_Add(single);
            BTN_UPDATE_FIGURE_LIST_Click(null, EventArgs.Empty);
        }

        private void BTN_OL_COPY_Click(object sender, EventArgs e)
        {
            if (LV_PAIR_OVL.FocusedItem == null) return;
            int nIndex = LV_PAIR_OVL.FocusedItem.Index;

            CMeasurePairOvl temp = (CMeasurePairOvl)imageView1.fm.ElementAt_PairOvl(nIndex);
            CMeasurePairOvl single = temp.CopyTo();

            imageView1.fm.Figure_Add(single);
            BTN_UPDATE_FIGURE_LIST_Click(null, EventArgs.Empty);

        }

        private void BTN_HOR_MODIFY_Click(object sender, EventArgs e)
        {
            if (LV_PAIR_HOR.FocusedItem == null) return;
            int nIndex = LV_PAIR_HOR.FocusedItem.Index;
            
            //// read  for latest roi croodinates
            CMeasurePairHor single = (CMeasurePairHor)imageView1.fm.ElementAt_PairHor(nIndex);
            single.NICKNAME = TXT_PARAM_HOR_NICK.Text;

            CMeasurePairHor[] array = imageView1.fm.ToArray_PairHor();
            array[nIndex] = (CMeasurePairHor)single;
            imageView1.fm.Figure_Replace(array);
            
            MessageBox.Show("Data Modification has finished.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BTN_UPDATE_FIGURE_LIST_Click(null, EventArgs.Empty);
        }

        private void BTN_VER_MODIFY_Click(object sender, EventArgs e)
        {
            if (LV_PAIR_VER.FocusedItem == null) return;
            int nIndex = LV_PAIR_VER.FocusedItem.Index;

            //// read  for latest roi croodinates
            CMeasurePairVer single = (CMeasurePairVer)imageView1.fm.ElementAt_PairVer(nIndex);
            single.NICKNAME = TXT_PARAM_VER_NICK.Text;

            CMeasurePairVer[] array = imageView1.fm.ToArrya_PairVer();
            array[nIndex] = (CMeasurePairVer)single;
            imageView1.fm.Figure_Replace(array);

            MessageBox.Show("Data Modification has finished.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BTN_UPDATE_FIGURE_LIST_Click(null, EventArgs.Empty);
        }

        private void BTN_DIG_MODIFY_Click(object sender, EventArgs e)
        {
            if (LV_PAIR_DIG.FocusedItem == null) return;
            int nIndex = LV_PAIR_DIG.FocusedItem.Index;

            //// read  for latest roi croodinates
            CMeasurePairDig single = (CMeasurePairDig)imageView1.fm.ElementAt_PairDig(nIndex);
            single.NICKNAME = TXT_PARAM_DIG_NICK.Text;

            CMeasurePairDig[] array = imageView1.fm.ToArray_PairDig();
            array[nIndex] = (CMeasurePairDig)single;
            imageView1.fm.Figure_Replace(array);

            MessageBox.Show("Data Modification has finished.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BTN_UPDATE_FIGURE_LIST_Click(null, EventArgs.Empty);
        }

        private void BTN_CIR_MODIFY_Click(object sender, EventArgs e)
        {
            if (LV_PAIR_CIR.FocusedItem == null) return;
            int nIndex = LV_PAIR_CIR.FocusedItem.Index;

            //// read  for latest roi croodinates
            CMeasurePairCir single = (CMeasurePairCir)imageView1.fm.ElementAt_PairCir(nIndex);
            single.NICKNAME = TXT_PARAM_CIR_NICK.Text;

            CMeasurePairCir[] array = imageView1.fm.ToArray_PairCir();
            array[nIndex] = (CMeasurePairCir)single;
            imageView1.fm.Figure_Replace(array);

            MessageBox.Show("Data Modification has finished.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BTN_UPDATE_FIGURE_LIST_Click(null, EventArgs.Empty);
        }

        private void RDO_GRAPH_FST_TYPE_PROJECTION_H_CheckedChanged/***/(object sender, EventArgs e) { m_DrawType_Master = UC_Graph.IFX_GRAPH_TYPE.PROJ_H; }
        private void RDO_GRAPH_FST_TYPE_PROJECTION_V_CheckedChanged/***/(object sender, EventArgs e) { m_DrawType_Master = UC_Graph.IFX_GRAPH_TYPE.PROJ_V; }
        private void RDO_GRAPH_FST_TYPE_HISTOGRAM_CheckedChanged/******/(object sender, EventArgs e) { m_DrawType_Master = UC_Graph.IFX_GRAPH_TYPE.HISTO; }
        private void RDO_GRAPH_FST_TYPE_REAL_CheckedChanged/***********/(object sender, EventArgs e) { m_DrawType_Master = UC_Graph.IFX_GRAPH_TYPE.REAL; }

        private void RDO_GRAPH_SCD_TYPE_PROJECTION_H_CheckedChanged/***/(object sender, EventArgs e) { m_DrawType_Slave = UC_Graph.IFX_GRAPH_TYPE.PROJ_H; }
        private void RDO_GRAPH_SCD_TYPE_PROJECTION_V_CheckedChanged/***/(object sender, EventArgs e) { m_DrawType_Slave = UC_Graph.IFX_GRAPH_TYPE.PROJ_V; }
        private void RDO_GRAPH_SCD_TYPE_HISTOGRAM_CheckedChanged/******/(object sender, EventArgs e) { m_DrawType_Slave = UC_Graph.IFX_GRAPH_TYPE.HISTO; }
        private void RDO_GRAPH_SCD_TYPE_REAL_CheckedChanged/***********/(object sender, EventArgs e) { m_DrawType_Slave = UC_Graph.IFX_GRAPH_TYPE.REAL; }

        private void CHK_GRAPH_MASTER_DRAW_BAR_CheckedChanged(object sender, EventArgs e) { UC_GRAPH_MASTER.SetDrawTypeAsBar(CHK_GRAPH_MASTER_DRAW_BAR.Checked); }
        private void CHK_GRAPH_SLAVE_DRAW_BAR_CheckedChanged(object sender, EventArgs e) { UC_GRAPH_SLAVE.SetDrawTypeAsBar(CHK_GRAPH_SLAVE_DRAW_BAR.Checked); }

        private void BTN_DIG_ANGLE_UP_Click(object sender, EventArgs e)
        {
            if (LV_PAIR_DIG.FocusedItem == null) return;
            
            int nAngleTemp = Convert.ToInt32(TXT_PARAM_DIG_ANGLE.Text);
            int nAngleAccu = +1;
            
            TXT_PARAM_DIG_ANGLE.Text = (nAngleTemp + nAngleAccu).ToString("N0");
            
            int nDataIndex = LV_PAIR_DIG.FocusedItem.Index;
            
            imageView1.iMod_RectPair_DigonalAngle(nDataIndex, nAngleAccu);
        }

        private void BTN_DIG_ANGLE_DW_Click(object sender, EventArgs e)
        {
            if (LV_PAIR_DIG.FocusedItem == null) return;

            int nAngleTemp = Convert.ToInt32(TXT_PARAM_DIG_ANGLE.Text);
            int nAngleAccu = -1;

            TXT_PARAM_DIG_ANGLE.Text = (nAngleTemp + nAngleAccu).ToString("N0");

            int nDataIndex = LV_PAIR_DIG.FocusedItem.Index;

            imageView1.iMod_RectPair_DigonalAngle(nDataIndex, nAngleAccu);
        }
        private void BTN_CHANGE_FIGURE_CONTROL_LEVEL(int sign)
        {
            int nValue = TB_FIGURE_CTRL_SCALE.Value;

            /***/if (sign > 0x0) { nValue++; }
            else if (sign < 0x0) {nValue--;}

            nValue = nValue > 0 ? nValue : 1;
            TB_FIGURE_CTRL_SCALE.Value = nValue;
            TB_FIGURE_CTRL_SCALE_Scroll(null, EventArgs.Empty);
        }


        private void BTN_ROI_ADD_Click(object sender, EventArgs e)
        {
            imageView1.iDrawROIWrite(true);
        }
       
        private void BTN_ROI_REMOVE_ALL_Click(object sender, EventArgs e)
        {
            imageView1.iRemoveRoiAll();
        }

        private void BTN_SAVE_REGION_Click(object sender, EventArgs e)
        {
            imageView1.iSaveROI(0);
        }

        private void BTN_TEACH_PTRN_Click(object sender, EventArgs e)
        {
            imageView1.iPTRN_Teach();
        }
        private void SetView_PTRN(string strFullFilePath)
        {
            string strFilePath = Path.GetFileName(strFullFilePath);

            string strExtension = Path.GetExtension(strFilePath).ToUpper();

            if (strExtension == ".BMP")
            {
                PIC_PTRN.Image = Bitmap.FromFile(strFullFilePath);
            }
        }

     

        private void TAB_MENU_SelectedIndexChanged(object sender, EventArgs e)
        {
            int nTabIndex = TAB_MENU.SelectedIndex;

            BTN_UPDATE_PARAM_FIGURES_Click(null, EventArgs.Empty);
        }

        private void BTN_VIEW_SAVE_OVERLAY_Click(object sender, EventArgs e)
        {
            string strFileName = imageView1.SaveDisplayOvr(100);
            PRINT_MSG("OVR IMAGE Saved.\n" + strFileName);
        }

        private void RDO_ROI_OVL_CheckedChanged(object sender, EventArgs e)
        {
            // Set Focust --> after status changed 
            LV_PAIR_OVL.Focus();
        }

        private void RDO_FIGURE_ROI_CheckedChanged(object sender, EventArgs e)
        {
            int nFigureIndex = TAB_FIGURE.SelectedIndex;

            /***/if (nFigureIndex == IFX_FIGURE.PAIR_HOR) LV_PAIR_HOR.Focus();
            else if (nFigureIndex == IFX_FIGURE.PAIR_VER) LV_PAIR_VER.Focus();
            else if (nFigureIndex == IFX_FIGURE.PAIR_DIG) LV_PAIR_DIG.Focus();
            else if (nFigureIndex == IFX_FIGURE.PAIR_CIR) LV_PAIR_CIR.Focus();
            else if (nFigureIndex == IFX_FIGURE.PAIR_OVL) LV_PAIR_OVL.Focus();
        }

        private void TAB_FIGURE_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Ziz Zag Option은 Only for Pair OVERLAY
            int nFigureIndex = TAB_FIGURE.SelectedIndex;

            if (nFigureIndex != IFX_FIGURE.PAIR_OVL)
            {
                RDO_ROI_ASYM.Visible = false;
            }
            else
            {
                RDO_ROI_ASYM.Visible = true;
            }
            BTN_UPDATE_PARAM_FIGURES_Click(null, EventArgs.Empty);
        }

       

        private void LV_FILE_LIST_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void LV_FILE_LIST_DragDrop(object sender, DragEventArgs e)
        {

            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            int nFileCount = files.Length;

            LV_FILE_LIST.Items.Clear();

            for (int i = 0; i < nFileCount; i++)
            {
                ListViewItem lvi = new ListViewItem();

                lvi.Text = string.Format("{0}", i + 1);
                lvi.SubItems.Add(files[i]);

                LV_FILE_LIST.Items.Add(lvi);
            }

            PRINT_MSG("Total " + nFileCount.ToString("N0") + " Files Has Found.");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Bitmap bmp = imageView1.GetDisplay_Bmp();
            int imageW = bmp.Width;
            int imageH = bmp.Height;


            byte[] rawImage = Computer.HC_CONV_Bmp2Raw(bmp, ref imageW, ref imageH);

            RectangleF rc = new RectangleF(100, 100, 100, 100);
            double powValue =0.5;
            rawImage = Computer.HC_FILTER_STD_Window(rawImage, imageW, imageH,rc, 5, powValue);

            imageView1.SetDisplay(rawImage, imageW, imageH);
        }


        




       

       

        

        
        
     
      

        

       
         
    }
    public static class EllipsePolygonCreator
    {
        #region Public static methods

        public static IEnumerable<PointF> CreateEllipsePoints(
          double maxAngleErrorRadians,
          double width,
          double height)
        {
            IEnumerable<double> thetas = CreateEllipseThetas(maxAngleErrorRadians, width, height);
            return thetas.Select(theta => GetPointOnEllipse(theta, width, height));
        }

        #endregion

        #region Private methods

        private static IEnumerable<double> CreateEllipseThetas(
          double maxAngleErrorRadians,
          double width,
          double height)
        {
            double firstQuarterStart = 0;
            double firstQuarterEnd = Math.PI / 2;
            double startPrimeAngle = Math.PI / 2;
            double endPrimeAngle = 0;

            double[] thetasFirstQuarter = RecursiveCreateEllipsePoints(
              firstQuarterStart,
              firstQuarterEnd,
              maxAngleErrorRadians,
              width / height,
              startPrimeAngle,
              endPrimeAngle).ToArray();

            double[] thetasSecondQuarter = new double[thetasFirstQuarter.Length];
            for (int i = 0; i < thetasFirstQuarter.Length; ++i)
            {
                thetasSecondQuarter[i] = Math.PI - thetasFirstQuarter[thetasFirstQuarter.Length - i - 1];
            }

            IEnumerable<double> thetasFirstHalf = thetasFirstQuarter.Concat(thetasSecondQuarter);
            IEnumerable<double> thetasSecondHalf = thetasFirstHalf.Select(theta => theta + Math.PI);
            IEnumerable<double> thetas = thetasFirstHalf.Concat(thetasSecondHalf);
            return thetas;
        }

        private static IEnumerable<double> RecursiveCreateEllipsePoints(
          double startTheta,
          double endTheta,
          double maxAngleError,
          double widthHeightRatio,
          double startPrimeAngle,
          double endPrimeAngle)
        {
            double yDelta = Math.Sin(endTheta) - Math.Sin(startTheta);
            double xDelta = Math.Cos(startTheta) - Math.Cos(endTheta);
            double averageAngle = Math.Atan2(yDelta, xDelta * widthHeightRatio);

            if (Math.Abs(averageAngle - startPrimeAngle) < maxAngleError &&
                Math.Abs(averageAngle - endPrimeAngle) < maxAngleError)
            {
                return new double[] { endTheta };
            }

            double middleTheta = (startTheta + endTheta) / 2;
            double middlePrimeAngle = GetPrimeAngle(middleTheta, widthHeightRatio);
            IEnumerable<double> firstPoints = RecursiveCreateEllipsePoints(
              startTheta,
              middleTheta,
              maxAngleError,
              widthHeightRatio,
              startPrimeAngle,
              middlePrimeAngle);
            IEnumerable<double> lastPoints = RecursiveCreateEllipsePoints(
              middleTheta,
              endTheta,
              maxAngleError,
              widthHeightRatio,
              middlePrimeAngle,
              endPrimeAngle);

            return firstPoints.Concat(lastPoints);
        }

        private static double GetPrimeAngle(double theta, double widthHeightRatio)
        {
            return Math.Atan(1 / (Math.Tan(theta) * widthHeightRatio)); // Prime of an ellipse
        }

        private static PointF GetPointOnEllipse(double theta, double width, double height)
        {
            double x = width * Math.Cos(theta);
            double y = height * Math.Sin(theta);
            return new PointF((float)x, (float)y);
        }

        #endregion
    }
    static class ControlExtensions
    {
        static public void UIThread(this Control control, Action code)
        {
            if (control.InvokeRequired)
            {
                control.BeginInvoke(code);
                return;
            }
            code.Invoke();
        }
    }
}
