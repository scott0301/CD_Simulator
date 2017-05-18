namespace CD_Simulator
{
    partial class FormMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.PANEL_VIEW_TOOLS = new System.Windows.Forms.Panel();
            this.label53 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LB_VIEW_ZOOM_ORIGIN = new System.Windows.Forms.Label();
            this.BTN_VIEW_OVERLAY_CLEAR = new System.Windows.Forms.Button();
            this.BTN_VIEW_PANNING = new System.Windows.Forms.Button();
            this.BTN_VIEW_SET_OVERLAY = new System.Windows.Forms.Button();
            this.BTN_DRAW_FIGURE = new System.Windows.Forms.Button();
            this.BTN_VIEW_OVERLAY_MAG_ORG = new System.Windows.Forms.Button();
            this.BTN_VIEW_MAG_PLUS = new System.Windows.Forms.Button();
            this.BTN_VIEW_MAG_MINUS = new System.Windows.Forms.Button();
            this.BTN_VIEW_IMAGE_LOAD = new System.Windows.Forms.Button();
            this.BTN_VIEW_SAVE_OVERLAY = new System.Windows.Forms.Button();
            this.BTN_VIEW_IMAGE_SAVE = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TXT_INFO_PIXEL_Y = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.TXT_INFO_PIXEL_X = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.TXT_INFO_IMAGE_Y = new System.Windows.Forms.TextBox();
            this.TXT_INFO_IMAGE_X = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TXT_INFO_IMAGE_AVG = new System.Windows.Forms.TextBox();
            this.TXT_INFO_IMAGE_DIFF = new System.Windows.Forms.TextBox();
            this.TXT_INFO_IMAGE_MAX = new System.Windows.Forms.TextBox();
            this.TXT_INFO_IMAGE_MIN = new System.Windows.Forms.TextBox();
            this.msg = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label52 = new System.Windows.Forms.Label();
            this.BTN_PTRN_TEACHING_LOAD = new System.Windows.Forms.Button();
            this.BTN_SET_RELATIVE_POSITION = new System.Windows.Forms.Button();
            this.BTN_PTRN_MATCH = new System.Windows.Forms.Button();
            this.TXT_PTRN_ACC_RATIO = new System.Windows.Forms.TextBox();
            this.TXT_PTRN_FILE_NAME = new System.Windows.Forms.TextBox();
            this.TXT_PTRN_PATH = new System.Windows.Forms.TextBox();
            this.uc_graph_global = new UC_Graph.penelGraph();
            this.label51 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.PANEL_MESSAGE_WINDOW = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.CHK_MEASURE_DUMP = new System.Windows.Forms.CheckBox();
            this.CHK_MEASURE_VIEW_ONLY = new System.Windows.Forms.CheckBox();
            this.LV_FILE_LIST = new System.Windows.Forms.ListView();
            this.INDEX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FILES = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label31 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.LV_PARAMETER = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel6 = new System.Windows.Forms.Panel();
            this.BTN_UPDATE_PARAM_FIGURES = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.UC_PARAMETER = new ParameterSetting.Parameter();
            this.label39 = new System.Windows.Forms.Label();
            this.BTN_UPDATE_PARAMETER = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.BTN_RECIPE_SAVE = new System.Windows.Forms.Button();
            this.BTN_RECIPE_LOAD = new System.Windows.Forms.Button();
            this.TXT_PATH_DUMP = new System.Windows.Forms.TextBox();
            this.TXT_PATH_RECP_FILE = new System.Windows.Forms.TextBox();
            this.TXT_PATH_RECIPE = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.imageView1 = new CD_View.Viewer();
            this.SELECT_VIEW2 = new System.Windows.Forms.Button();
            this.BTN_SELECT_VIEW1 = new System.Windows.Forms.Button();
            this.imageView2 = new CD_View.Viewer();
            this.LB_CAM_INDEX = new System.Windows.Forms.Label();
            this.PANEL_VIEW_BLEND = new System.Windows.Forms.Panel();
            this.CHK_BLEND = new System.Windows.Forms.CheckBox();
            this.TB_BLENDING_RATIO = new System.Windows.Forms.TrackBar();
            this.LB_BLEND_VALUE = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.panel_temp = new System.Windows.Forms.Panel();
            this.TAB_MENU = new System.Windows.Forms.TabControl();
            this.page_main = new System.Windows.Forms.TabPage();
            this.page_setting = new System.Windows.Forms.TabPage();
            this.panel12 = new System.Windows.Forms.Panel();
            this.TAB_FIGURE = new System.Windows.Forms.TabControl();
            this.rcPairHorizontal = new System.Windows.Forms.TabPage();
            this.panel14 = new System.Windows.Forms.Panel();
            this.BTN_HOR_ADD = new System.Windows.Forms.Button();
            this.BTN_HOR_COPY = new System.Windows.Forms.Button();
            this.BTN_HOR_MODIFY = new System.Windows.Forms.Button();
            this.BTN_HOR_REMOVE = new System.Windows.Forms.Button();
            this.panel15 = new System.Windows.Forms.Panel();
            this.label40 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TXT_RCH_W = new System.Windows.Forms.TextBox();
            this.LB_RCH_W = new System.Windows.Forms.Label();
            this.TXT_RCH_H = new System.Windows.Forms.TextBox();
            this.LB_RCH_H = new System.Windows.Forms.Label();
            this.TXT_PARAM_HOR_NICK = new System.Windows.Forms.TextBox();
            this.LV_PAIR_HOR = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rcPairVertical = new System.Windows.Forms.TabPage();
            this.panel16 = new System.Windows.Forms.Panel();
            this.BTN_VER_COPY = new System.Windows.Forms.Button();
            this.BTN_VER_ADD = new System.Windows.Forms.Button();
            this.BTN_VER_MODIFY = new System.Windows.Forms.Button();
            this.BTN_VER_REMOVE = new System.Windows.Forms.Button();
            this.panel18 = new System.Windows.Forms.Panel();
            this.label41 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label42 = new System.Windows.Forms.Label();
            this.TXT_RCV_H = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.TXT_PARAM_VER_NICK = new System.Windows.Forms.TextBox();
            this.TXT_RCV_W = new System.Windows.Forms.TextBox();
            this.LV_PAIR_VER = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rcPairDiagonal = new System.Windows.Forms.TabPage();
            this.panel19 = new System.Windows.Forms.Panel();
            this.BTN_DIG_COPY = new System.Windows.Forms.Button();
            this.BTN_DIG_ADD = new System.Windows.Forms.Button();
            this.BTN_DIG_MODIFY = new System.Windows.Forms.Button();
            this.BTN_DIG_REMOVE = new System.Windows.Forms.Button();
            this.panel21 = new System.Windows.Forms.Panel();
            this.label44 = new System.Windows.Forms.Label();
            this.TXT_RCD_H = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.BTN_DIG_ANGLE_DW = new System.Windows.Forms.Button();
            this.label46 = new System.Windows.Forms.Label();
            this.TXT_RCD_W = new System.Windows.Forms.TextBox();
            this.BTN_DIG_ANGLE_UP = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.TXT_PARAM_DIG_ANGLE = new System.Windows.Forms.TextBox();
            this.TXT_PARAM_DIG_NICK = new System.Windows.Forms.TextBox();
            this.label67 = new System.Windows.Forms.Label();
            this.LV_PAIR_DIG = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.circle = new System.Windows.Forms.TabPage();
            this.panel22 = new System.Windows.Forms.Panel();
            this.BTN_CIR_ADD = new System.Windows.Forms.Button();
            this.BTN_CIR_COPY = new System.Windows.Forms.Button();
            this.BTN_CIR_MODIFY = new System.Windows.Forms.Button();
            this.BTN_CIR_REMOVE = new System.Windows.Forms.Button();
            this.panel24 = new System.Windows.Forms.Panel();
            this.label48 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.TXT_CIRCLE_H = new System.Windows.Forms.TextBox();
            this.TXT_CIRCLE_W = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.TXT_PARAM_CIR_NICK = new System.Windows.Forms.TextBox();
            this.LV_PAIR_CIR = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ol = new System.Windows.Forms.TabPage();
            this.panel28 = new System.Windows.Forms.Panel();
            this.label54 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.TXT_OVL_EX_H = new System.Windows.Forms.TextBox();
            this.TXT_OVL_IN_H = new System.Windows.Forms.TextBox();
            this.TXT_OVL_EX_W = new System.Windows.Forms.TextBox();
            this.TXT_OVL_IN_W = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.TXT_PARAM_OVL_NICK = new System.Windows.Forms.TextBox();
            this.LV_PAIR_OVL = new System.Windows.Forms.ListView();
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel23 = new System.Windows.Forms.Panel();
            this.RDO_ROI_OVL_EX = new System.Windows.Forms.RadioButton();
            this.RDO_ROI_OVL_ENTIRE = new System.Windows.Forms.RadioButton();
            this.RDO_ROI_OVL_IN = new System.Windows.Forms.RadioButton();
            this.BTN_OL_ADD = new System.Windows.Forms.Button();
            this.BTN_OL_COPY = new System.Windows.Forms.Button();
            this.BTN_OL_REMOVE = new System.Windows.Forms.Button();
            this.ptrn = new System.Windows.Forms.TabPage();
            this.panel17 = new System.Windows.Forms.Panel();
            this.BTN_ROI_REMOVE_ALL = new System.Windows.Forms.Button();
            this.BTN_SAVE_REGION = new System.Windows.Forms.Button();
            this.BTN_ROI_ADD = new System.Windows.Forms.Button();
            this.BTN_TEACH_PTRN = new System.Windows.Forms.Button();
            this.panel13 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.PIC_PTRN = new System.Windows.Forms.PictureBox();
            this.LV_PTRN = new System.Windows.Forms.ListView();
            this.IDX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FIELS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel25 = new System.Windows.Forms.Panel();
            this.panel26 = new System.Windows.Forms.Panel();
            this.panel27 = new System.Windows.Forms.Panel();
            this.RDO_ROI_ASYM = new System.Windows.Forms.RadioButton();
            this.RDO_ROI_SIZE = new System.Windows.Forms.RadioButton();
            this.TXT_FIGURE_CONTROL_SCALE = new System.Windows.Forms.TextBox();
            this.TB_FIGURE_CTRL_SCALE = new System.Windows.Forms.TrackBar();
            this.RDO_ROI_POSITION = new System.Windows.Forms.RadioButton();
            this.RDO_ROI_GAP = new System.Windows.Forms.RadioButton();
            this.label47 = new System.Windows.Forms.Label();
            this.label87 = new System.Windows.Forms.Label();
            this.panel29 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RDO_GRAPH_FST_TYPE_REAL = new System.Windows.Forms.RadioButton();
            this.RDO_GRAPH_FST_TYPE_HISTOGRAM = new System.Windows.Forms.RadioButton();
            this.RDO_GRAPH_FST_TYPE_PROJECTION_V = new System.Windows.Forms.RadioButton();
            this.RDO_GRAPH_FST_TYPE_PROJECTION_H = new System.Windows.Forms.RadioButton();
            this.CHK_GRAPH_MASTER_DRAW_BAR = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RDO_GRAPH_SCD_TYPE_PROJECTION_V = new System.Windows.Forms.RadioButton();
            this.RDO_GRAPH_SCD_TYPE_PROJECTION_H = new System.Windows.Forms.RadioButton();
            this.CHK_GRAPH_SLAVE_DRAW_BAR = new System.Windows.Forms.CheckBox();
            this.RDO_GRAPH_SCD_TYPE_REAL = new System.Windows.Forms.RadioButton();
            this.RDO_GRAPH_SCD_TYPE_HISTOGRAM = new System.Windows.Forms.RadioButton();
            this.panel30 = new System.Windows.Forms.Panel();
            this.UC_GRAPH_MASTER = new UC_Graph.penelGraph();
            this.panel31 = new System.Windows.Forms.Panel();
            this.UC_GRAPH_SLAVE = new UC_Graph.penelGraph();
            this.panel32 = new System.Windows.Forms.Panel();
            this.panel33 = new System.Windows.Forms.Panel();
            this.BTN_ROI_DIR_LFT = new System.Windows.Forms.Button();
            this.BTN_ROI_DIR_TOP = new System.Windows.Forms.Button();
            this.BTN_ROI_DIR_RHT = new System.Windows.Forms.Button();
            this.BTN_ROI_DIR_BTM = new System.Windows.Forms.Button();
            this.page_param = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.BTN_UPDATE_FIGURE_LIST = new System.Windows.Forms.Button();
            this.panel20 = new System.Windows.Forms.Panel();
            this.BTN_MEASURE = new System.Windows.Forms.Button();
            this.PANEL_VIEW_TOOLS.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel9.SuspendLayout();
            this.PANEL_MESSAGE_WINDOW.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.PANEL_VIEW_BLEND.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TB_BLENDING_RATIO)).BeginInit();
            this.panel_temp.SuspendLayout();
            this.TAB_MENU.SuspendLayout();
            this.page_main.SuspendLayout();
            this.page_setting.SuspendLayout();
            this.panel12.SuspendLayout();
            this.TAB_FIGURE.SuspendLayout();
            this.rcPairHorizontal.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel15.SuspendLayout();
            this.rcPairVertical.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel18.SuspendLayout();
            this.rcPairDiagonal.SuspendLayout();
            this.panel19.SuspendLayout();
            this.panel21.SuspendLayout();
            this.circle.SuspendLayout();
            this.panel22.SuspendLayout();
            this.panel24.SuspendLayout();
            this.Ol.SuspendLayout();
            this.panel28.SuspendLayout();
            this.panel23.SuspendLayout();
            this.ptrn.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_PTRN)).BeginInit();
            this.panel25.SuspendLayout();
            this.panel26.SuspendLayout();
            this.panel27.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TB_FIGURE_CTRL_SCALE)).BeginInit();
            this.panel29.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel30.SuspendLayout();
            this.panel31.SuspendLayout();
            this.panel32.SuspendLayout();
            this.panel33.SuspendLayout();
            this.page_param.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel20.SuspendLayout();
            this.SuspendLayout();
            // 
            // PANEL_VIEW_TOOLS
            // 
            this.PANEL_VIEW_TOOLS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.PANEL_VIEW_TOOLS.Controls.Add(this.label53);
            this.PANEL_VIEW_TOOLS.Controls.Add(this.label4);
            this.PANEL_VIEW_TOOLS.Controls.Add(this.label3);
            this.PANEL_VIEW_TOOLS.Controls.Add(this.label2);
            this.PANEL_VIEW_TOOLS.Controls.Add(this.label1);
            this.PANEL_VIEW_TOOLS.Controls.Add(this.label7);
            this.PANEL_VIEW_TOOLS.Controls.Add(this.label32);
            this.PANEL_VIEW_TOOLS.Controls.Add(this.label6);
            this.PANEL_VIEW_TOOLS.Controls.Add(this.label5);
            this.PANEL_VIEW_TOOLS.Controls.Add(this.LB_VIEW_ZOOM_ORIGIN);
            this.PANEL_VIEW_TOOLS.Controls.Add(this.BTN_VIEW_OVERLAY_CLEAR);
            this.PANEL_VIEW_TOOLS.Controls.Add(this.BTN_VIEW_PANNING);
            this.PANEL_VIEW_TOOLS.Controls.Add(this.BTN_VIEW_SET_OVERLAY);
            this.PANEL_VIEW_TOOLS.Controls.Add(this.BTN_DRAW_FIGURE);
            this.PANEL_VIEW_TOOLS.Controls.Add(this.BTN_VIEW_OVERLAY_MAG_ORG);
            this.PANEL_VIEW_TOOLS.Controls.Add(this.BTN_VIEW_MAG_PLUS);
            this.PANEL_VIEW_TOOLS.Controls.Add(this.BTN_VIEW_MAG_MINUS);
            this.PANEL_VIEW_TOOLS.Controls.Add(this.BTN_VIEW_IMAGE_LOAD);
            this.PANEL_VIEW_TOOLS.Controls.Add(this.BTN_VIEW_SAVE_OVERLAY);
            this.PANEL_VIEW_TOOLS.Controls.Add(this.BTN_VIEW_IMAGE_SAVE);
            this.PANEL_VIEW_TOOLS.Location = new System.Drawing.Point(5, 5);
            this.PANEL_VIEW_TOOLS.Name = "PANEL_VIEW_TOOLS";
            this.PANEL_VIEW_TOOLS.Size = new System.Drawing.Size(643, 76);
            this.PANEL_VIEW_TOOLS.TabIndex = 1;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label53.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label53.Location = new System.Drawing.Point(580, 61);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(60, 12);
            this.label53.TabIndex = 1;
            this.label53.Text = "SAVE_OVR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label4.Location = new System.Drawing.Point(522, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "SAVE_IMG";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Location = new System.Drawing.Point(470, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "LOAD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(406, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "ZOOM -";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(349, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "ZOOM +";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label7.Location = new System.Drawing.Point(220, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "CLEAR";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label32.Location = new System.Drawing.Point(88, 61);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(61, 12);
            this.label32.TabIndex = 1;
            this.label32.Text = "DRAW OFF";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label6.Location = new System.Drawing.Point(155, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "OVR ON";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label5.Location = new System.Drawing.Point(4, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "PANNING";
            // 
            // LB_VIEW_ZOOM_ORIGIN
            // 
            this.LB_VIEW_ZOOM_ORIGIN.AutoSize = true;
            this.LB_VIEW_ZOOM_ORIGIN.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_VIEW_ZOOM_ORIGIN.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.LB_VIEW_ZOOM_ORIGIN.Location = new System.Drawing.Point(294, 61);
            this.LB_VIEW_ZOOM_ORIGIN.Name = "LB_VIEW_ZOOM_ORIGIN";
            this.LB_VIEW_ZOOM_ORIGIN.Size = new System.Drawing.Size(44, 12);
            this.LB_VIEW_ZOOM_ORIGIN.TabIndex = 1;
            this.LB_VIEW_ZOOM_ORIGIN.Text = "ORIGIN";
            // 
            // BTN_VIEW_OVERLAY_CLEAR
            // 
            this.BTN_VIEW_OVERLAY_CLEAR.AutoEllipsis = true;
            this.BTN_VIEW_OVERLAY_CLEAR.BackColor = System.Drawing.Color.Transparent;
            this.BTN_VIEW_OVERLAY_CLEAR.BackgroundImage = global::CD_Simulator.Properties.Resources.Trash_empty;
            this.BTN_VIEW_OVERLAY_CLEAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_VIEW_OVERLAY_CLEAR.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.BTN_VIEW_OVERLAY_CLEAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_VIEW_OVERLAY_CLEAR.ForeColor = System.Drawing.Color.Cornsilk;
            this.BTN_VIEW_OVERLAY_CLEAR.Location = new System.Drawing.Point(214, 8);
            this.BTN_VIEW_OVERLAY_CLEAR.Name = "BTN_VIEW_OVERLAY_CLEAR";
            this.BTN_VIEW_OVERLAY_CLEAR.Size = new System.Drawing.Size(50, 50);
            this.BTN_VIEW_OVERLAY_CLEAR.TabIndex = 0;
            this.BTN_VIEW_OVERLAY_CLEAR.UseVisualStyleBackColor = false;
            this.BTN_VIEW_OVERLAY_CLEAR.Click += new System.EventHandler(this.BTN_VIEW_OVERLAY_CLEAR_Click);
            // 
            // BTN_VIEW_PANNING
            // 
            this.BTN_VIEW_PANNING.BackgroundImage = global::CD_Simulator.Properties.Resources.medical_joystick_off;
            this.BTN_VIEW_PANNING.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_VIEW_PANNING.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.BTN_VIEW_PANNING.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_VIEW_PANNING.ForeColor = System.Drawing.Color.Cornsilk;
            this.BTN_VIEW_PANNING.Location = new System.Drawing.Point(4, 5);
            this.BTN_VIEW_PANNING.Name = "BTN_VIEW_PANNING";
            this.BTN_VIEW_PANNING.Size = new System.Drawing.Size(50, 50);
            this.BTN_VIEW_PANNING.TabIndex = 0;
            this.BTN_VIEW_PANNING.UseVisualStyleBackColor = true;
            this.BTN_VIEW_PANNING.Click += new System.EventHandler(this.BTN_VIEW_PANNING_Click);
            // 
            // BTN_VIEW_SET_OVERLAY
            // 
            this.BTN_VIEW_SET_OVERLAY.BackgroundImage = global::CD_Simulator.Properties.Resources.PaintBrushOff;
            this.BTN_VIEW_SET_OVERLAY.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_VIEW_SET_OVERLAY.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.BTN_VIEW_SET_OVERLAY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_VIEW_SET_OVERLAY.ForeColor = System.Drawing.Color.Cornsilk;
            this.BTN_VIEW_SET_OVERLAY.Location = new System.Drawing.Point(154, 8);
            this.BTN_VIEW_SET_OVERLAY.Name = "BTN_VIEW_SET_OVERLAY";
            this.BTN_VIEW_SET_OVERLAY.Size = new System.Drawing.Size(50, 50);
            this.BTN_VIEW_SET_OVERLAY.TabIndex = 0;
            this.BTN_VIEW_SET_OVERLAY.UseVisualStyleBackColor = true;
            this.BTN_VIEW_SET_OVERLAY.Click += new System.EventHandler(this.BTN_VIEW_SET_OVERLAY_Click);
            // 
            // BTN_DRAW_FIGURE
            // 
            this.BTN_DRAW_FIGURE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BTN_DRAW_FIGURE.BackgroundImage = global::CD_Simulator.Properties.Resources.DrawFigure_Off;
            this.BTN_DRAW_FIGURE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_DRAW_FIGURE.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.BTN_DRAW_FIGURE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_DRAW_FIGURE.ForeColor = System.Drawing.Color.Cornsilk;
            this.BTN_DRAW_FIGURE.Location = new System.Drawing.Point(94, 8);
            this.BTN_DRAW_FIGURE.Name = "BTN_DRAW_FIGURE";
            this.BTN_DRAW_FIGURE.Size = new System.Drawing.Size(50, 50);
            this.BTN_DRAW_FIGURE.TabIndex = 0;
            this.BTN_DRAW_FIGURE.UseVisualStyleBackColor = false;
            this.BTN_DRAW_FIGURE.Click += new System.EventHandler(this.BTN_DRAW_FIGURE_Click);
            // 
            // BTN_VIEW_OVERLAY_MAG_ORG
            // 
            this.BTN_VIEW_OVERLAY_MAG_ORG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BTN_VIEW_OVERLAY_MAG_ORG.BackgroundImage = global::CD_Simulator.Properties.Resources.search;
            this.BTN_VIEW_OVERLAY_MAG_ORG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_VIEW_OVERLAY_MAG_ORG.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.BTN_VIEW_OVERLAY_MAG_ORG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_VIEW_OVERLAY_MAG_ORG.ForeColor = System.Drawing.Color.Cornsilk;
            this.BTN_VIEW_OVERLAY_MAG_ORG.Location = new System.Drawing.Point(291, 8);
            this.BTN_VIEW_OVERLAY_MAG_ORG.Name = "BTN_VIEW_OVERLAY_MAG_ORG";
            this.BTN_VIEW_OVERLAY_MAG_ORG.Size = new System.Drawing.Size(50, 50);
            this.BTN_VIEW_OVERLAY_MAG_ORG.TabIndex = 0;
            this.BTN_VIEW_OVERLAY_MAG_ORG.UseVisualStyleBackColor = false;
            this.BTN_VIEW_OVERLAY_MAG_ORG.Click += new System.EventHandler(this.BTN_VIEW_OVERLAY_MAG_ORG_Click);
            // 
            // BTN_VIEW_MAG_PLUS
            // 
            this.BTN_VIEW_MAG_PLUS.BackgroundImage = global::CD_Simulator.Properties.Resources.search_add;
            this.BTN_VIEW_MAG_PLUS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_VIEW_MAG_PLUS.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.BTN_VIEW_MAG_PLUS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_VIEW_MAG_PLUS.Font = new System.Drawing.Font("Verdana", 9F);
            this.BTN_VIEW_MAG_PLUS.ForeColor = System.Drawing.Color.Cornsilk;
            this.BTN_VIEW_MAG_PLUS.Location = new System.Drawing.Point(347, 8);
            this.BTN_VIEW_MAG_PLUS.Name = "BTN_VIEW_MAG_PLUS";
            this.BTN_VIEW_MAG_PLUS.Size = new System.Drawing.Size(50, 50);
            this.BTN_VIEW_MAG_PLUS.TabIndex = 0;
            this.BTN_VIEW_MAG_PLUS.UseVisualStyleBackColor = true;
            this.BTN_VIEW_MAG_PLUS.Click += new System.EventHandler(this.BTN_VIEW_MAG_PLUS_Click);
            // 
            // BTN_VIEW_MAG_MINUS
            // 
            this.BTN_VIEW_MAG_MINUS.BackgroundImage = global::CD_Simulator.Properties.Resources.search_remove;
            this.BTN_VIEW_MAG_MINUS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_VIEW_MAG_MINUS.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.BTN_VIEW_MAG_MINUS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_VIEW_MAG_MINUS.Font = new System.Drawing.Font("Verdana", 9F);
            this.BTN_VIEW_MAG_MINUS.ForeColor = System.Drawing.Color.Cornsilk;
            this.BTN_VIEW_MAG_MINUS.Location = new System.Drawing.Point(403, 8);
            this.BTN_VIEW_MAG_MINUS.Name = "BTN_VIEW_MAG_MINUS";
            this.BTN_VIEW_MAG_MINUS.Size = new System.Drawing.Size(50, 50);
            this.BTN_VIEW_MAG_MINUS.TabIndex = 0;
            this.BTN_VIEW_MAG_MINUS.UseVisualStyleBackColor = true;
            this.BTN_VIEW_MAG_MINUS.Click += new System.EventHandler(this.BTN_VIEW_MAG_MINUS_Click);
            // 
            // BTN_VIEW_IMAGE_LOAD
            // 
            this.BTN_VIEW_IMAGE_LOAD.BackgroundImage = global::CD_Simulator.Properties.Resources.Device_scanner;
            this.BTN_VIEW_IMAGE_LOAD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_VIEW_IMAGE_LOAD.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.BTN_VIEW_IMAGE_LOAD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_VIEW_IMAGE_LOAD.Font = new System.Drawing.Font("Verdana", 9F);
            this.BTN_VIEW_IMAGE_LOAD.ForeColor = System.Drawing.Color.Cornsilk;
            this.BTN_VIEW_IMAGE_LOAD.Location = new System.Drawing.Point(459, 8);
            this.BTN_VIEW_IMAGE_LOAD.Name = "BTN_VIEW_IMAGE_LOAD";
            this.BTN_VIEW_IMAGE_LOAD.Size = new System.Drawing.Size(50, 50);
            this.BTN_VIEW_IMAGE_LOAD.TabIndex = 0;
            this.BTN_VIEW_IMAGE_LOAD.UseVisualStyleBackColor = true;
            this.BTN_VIEW_IMAGE_LOAD.Click += new System.EventHandler(this.BTN_VIEW_IMAGE_LOAD_Click);
            // 
            // BTN_VIEW_SAVE_OVERLAY
            // 
            this.BTN_VIEW_SAVE_OVERLAY.BackgroundImage = global::CD_Simulator.Properties.Resources.DrawIt;
            this.BTN_VIEW_SAVE_OVERLAY.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_VIEW_SAVE_OVERLAY.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.BTN_VIEW_SAVE_OVERLAY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_VIEW_SAVE_OVERLAY.Font = new System.Drawing.Font("Verdana", 9F);
            this.BTN_VIEW_SAVE_OVERLAY.ForeColor = System.Drawing.Color.Cornsilk;
            this.BTN_VIEW_SAVE_OVERLAY.Location = new System.Drawing.Point(584, 8);
            this.BTN_VIEW_SAVE_OVERLAY.Name = "BTN_VIEW_SAVE_OVERLAY";
            this.BTN_VIEW_SAVE_OVERLAY.Size = new System.Drawing.Size(50, 50);
            this.BTN_VIEW_SAVE_OVERLAY.TabIndex = 0;
            this.BTN_VIEW_SAVE_OVERLAY.UseVisualStyleBackColor = true;
            this.BTN_VIEW_SAVE_OVERLAY.Click += new System.EventHandler(this.BTN_VIEW_SAVE_OVERLAY_Click);
            // 
            // BTN_VIEW_IMAGE_SAVE
            // 
            this.BTN_VIEW_IMAGE_SAVE.BackgroundImage = global::CD_Simulator.Properties.Resources.Print_printer;
            this.BTN_VIEW_IMAGE_SAVE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_VIEW_IMAGE_SAVE.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.BTN_VIEW_IMAGE_SAVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_VIEW_IMAGE_SAVE.Font = new System.Drawing.Font("Verdana", 9F);
            this.BTN_VIEW_IMAGE_SAVE.ForeColor = System.Drawing.Color.Cornsilk;
            this.BTN_VIEW_IMAGE_SAVE.Location = new System.Drawing.Point(528, 8);
            this.BTN_VIEW_IMAGE_SAVE.Name = "BTN_VIEW_IMAGE_SAVE";
            this.BTN_VIEW_IMAGE_SAVE.Size = new System.Drawing.Size(50, 50);
            this.BTN_VIEW_IMAGE_SAVE.TabIndex = 0;
            this.BTN_VIEW_IMAGE_SAVE.UseVisualStyleBackColor = true;
            this.BTN_VIEW_IMAGE_SAVE.Click += new System.EventHandler(this.BTN_VIEW_IMAGE_SAVE_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "construction work.png");
            this.imageList1.Images.SetKeyName(1, "measureCir.png");
            this.imageList1.Images.SetKeyName(2, "measureDig.png");
            this.imageList1.Images.SetKeyName(3, "measureHor.png");
            this.imageList1.Images.SetKeyName(4, "measureRec.png");
            this.imageList1.Images.SetKeyName(5, "measureVer.png");
            this.imageList1.Images.SetKeyName(6, "measureOVL.png");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label8.Location = new System.Drawing.Point(7, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 14);
            this.label8.TabIndex = 0;
            this.label8.Text = "Image SX :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.label29);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(566, 83);
            this.panel2.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel4.Controls.Add(this.TXT_INFO_PIXEL_Y);
            this.panel4.Controls.Add(this.label23);
            this.panel4.Controls.Add(this.label24);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.label18);
            this.panel4.Controls.Add(this.TXT_INFO_PIXEL_X);
            this.panel4.Location = new System.Drawing.Point(254, 25);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(243, 55);
            this.panel4.TabIndex = 3;
            // 
            // TXT_INFO_PIXEL_Y
            // 
            this.TXT_INFO_PIXEL_Y.BackColor = System.Drawing.Color.Black;
            this.TXT_INFO_PIXEL_Y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_INFO_PIXEL_Y.ForeColor = System.Drawing.Color.Yellow;
            this.TXT_INFO_PIXEL_Y.Location = new System.Drawing.Point(105, 31);
            this.TXT_INFO_PIXEL_Y.Name = "TXT_INFO_PIXEL_Y";
            this.TXT_INFO_PIXEL_Y.Size = new System.Drawing.Size(89, 22);
            this.TXT_INFO_PIXEL_Y.TabIndex = 1;
            this.TXT_INFO_PIXEL_Y.Text = "1";
            this.TXT_INFO_PIXEL_Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label23.Location = new System.Drawing.Point(196, 34);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(27, 14);
            this.label23.TabIndex = 0;
            this.label23.Text = "um";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label24.Location = new System.Drawing.Point(196, 9);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(27, 14);
            this.label24.TabIndex = 0;
            this.label24.Text = "um";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label16.Location = new System.Drawing.Point(9, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(94, 14);
            this.label16.TabIndex = 0;
            this.label16.Text = "Pixel Res. X :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label18.Location = new System.Drawing.Point(9, 33);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(95, 14);
            this.label18.TabIndex = 0;
            this.label18.Text = "Pixel Res. Y :";
            // 
            // TXT_INFO_PIXEL_X
            // 
            this.TXT_INFO_PIXEL_X.BackColor = System.Drawing.Color.Black;
            this.TXT_INFO_PIXEL_X.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_INFO_PIXEL_X.ForeColor = System.Drawing.Color.Yellow;
            this.TXT_INFO_PIXEL_X.Location = new System.Drawing.Point(105, 6);
            this.TXT_INFO_PIXEL_X.Name = "TXT_INFO_PIXEL_X";
            this.TXT_INFO_PIXEL_X.Size = new System.Drawing.Size(89, 22);
            this.TXT_INFO_PIXEL_X.TabIndex = 1;
            this.TXT_INFO_PIXEL_X.Text = "1";
            this.TXT_INFO_PIXEL_X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.ForeColor = System.Drawing.Color.Orange;
            this.label29.Location = new System.Drawing.Point(8, 5);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(99, 14);
            this.label29.TabIndex = 0;
            this.label29.Text = "IMAGE INFO :";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.label26);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label25);
            this.panel3.Controls.Add(this.TXT_INFO_IMAGE_Y);
            this.panel3.Controls.Add(this.TXT_INFO_IMAGE_X);
            this.panel3.Location = new System.Drawing.Point(5, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(243, 55);
            this.panel3.TabIndex = 2;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label17.Location = new System.Drawing.Point(9, 32);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(81, 14);
            this.label17.TabIndex = 0;
            this.label17.Text = "Image SY :";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label26.Location = new System.Drawing.Point(152, 34);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(27, 14);
            this.label26.TabIndex = 0;
            this.label26.Text = "pxl";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label25.Location = new System.Drawing.Point(152, 8);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(27, 14);
            this.label25.TabIndex = 0;
            this.label25.Text = "pxl";
            // 
            // TXT_INFO_IMAGE_Y
            // 
            this.TXT_INFO_IMAGE_Y.BackColor = System.Drawing.Color.Black;
            this.TXT_INFO_IMAGE_Y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_INFO_IMAGE_Y.ForeColor = System.Drawing.Color.Yellow;
            this.TXT_INFO_IMAGE_Y.Location = new System.Drawing.Point(96, 29);
            this.TXT_INFO_IMAGE_Y.Name = "TXT_INFO_IMAGE_Y";
            this.TXT_INFO_IMAGE_Y.Size = new System.Drawing.Size(50, 22);
            this.TXT_INFO_IMAGE_Y.TabIndex = 1;
            this.TXT_INFO_IMAGE_Y.Text = "1";
            this.TXT_INFO_IMAGE_Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TXT_INFO_IMAGE_X
            // 
            this.TXT_INFO_IMAGE_X.BackColor = System.Drawing.Color.Black;
            this.TXT_INFO_IMAGE_X.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_INFO_IMAGE_X.ForeColor = System.Drawing.Color.Yellow;
            this.TXT_INFO_IMAGE_X.Location = new System.Drawing.Point(96, 5);
            this.TXT_INFO_IMAGE_X.Name = "TXT_INFO_IMAGE_X";
            this.TXT_INFO_IMAGE_X.Size = new System.Drawing.Size(50, 22);
            this.TXT_INFO_IMAGE_X.TabIndex = 1;
            this.TXT_INFO_IMAGE_X.Text = "1";
            this.TXT_INFO_IMAGE_X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label19.Location = new System.Drawing.Point(371, 60);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(48, 14);
            this.label19.TabIndex = 0;
            this.label19.Text = "DIFF :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label15.Location = new System.Drawing.Point(371, 84);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 14);
            this.label15.TabIndex = 0;
            this.label15.Text = "AVG :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label14.Location = new System.Drawing.Point(371, 35);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 14);
            this.label14.TabIndex = 0;
            this.label14.Text = "MAX :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label10.Location = new System.Drawing.Point(372, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 14);
            this.label10.TabIndex = 0;
            this.label10.Text = "MIN :";
            // 
            // TXT_INFO_IMAGE_AVG
            // 
            this.TXT_INFO_IMAGE_AVG.BackColor = System.Drawing.Color.Black;
            this.TXT_INFO_IMAGE_AVG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_INFO_IMAGE_AVG.ForeColor = System.Drawing.Color.Yellow;
            this.TXT_INFO_IMAGE_AVG.Location = new System.Drawing.Point(419, 83);
            this.TXT_INFO_IMAGE_AVG.Name = "TXT_INFO_IMAGE_AVG";
            this.TXT_INFO_IMAGE_AVG.Size = new System.Drawing.Size(68, 22);
            this.TXT_INFO_IMAGE_AVG.TabIndex = 1;
            this.TXT_INFO_IMAGE_AVG.Text = "1";
            this.TXT_INFO_IMAGE_AVG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TXT_INFO_IMAGE_DIFF
            // 
            this.TXT_INFO_IMAGE_DIFF.BackColor = System.Drawing.Color.Black;
            this.TXT_INFO_IMAGE_DIFF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_INFO_IMAGE_DIFF.ForeColor = System.Drawing.Color.Yellow;
            this.TXT_INFO_IMAGE_DIFF.Location = new System.Drawing.Point(419, 59);
            this.TXT_INFO_IMAGE_DIFF.Name = "TXT_INFO_IMAGE_DIFF";
            this.TXT_INFO_IMAGE_DIFF.Size = new System.Drawing.Size(68, 22);
            this.TXT_INFO_IMAGE_DIFF.TabIndex = 1;
            this.TXT_INFO_IMAGE_DIFF.Text = "1";
            this.TXT_INFO_IMAGE_DIFF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TXT_INFO_IMAGE_MAX
            // 
            this.TXT_INFO_IMAGE_MAX.BackColor = System.Drawing.Color.Black;
            this.TXT_INFO_IMAGE_MAX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_INFO_IMAGE_MAX.ForeColor = System.Drawing.Color.Yellow;
            this.TXT_INFO_IMAGE_MAX.Location = new System.Drawing.Point(419, 34);
            this.TXT_INFO_IMAGE_MAX.Name = "TXT_INFO_IMAGE_MAX";
            this.TXT_INFO_IMAGE_MAX.Size = new System.Drawing.Size(68, 22);
            this.TXT_INFO_IMAGE_MAX.TabIndex = 1;
            this.TXT_INFO_IMAGE_MAX.Text = "1";
            this.TXT_INFO_IMAGE_MAX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TXT_INFO_IMAGE_MIN
            // 
            this.TXT_INFO_IMAGE_MIN.BackColor = System.Drawing.Color.Black;
            this.TXT_INFO_IMAGE_MIN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_INFO_IMAGE_MIN.ForeColor = System.Drawing.Color.Yellow;
            this.TXT_INFO_IMAGE_MIN.Location = new System.Drawing.Point(419, 10);
            this.TXT_INFO_IMAGE_MIN.Name = "TXT_INFO_IMAGE_MIN";
            this.TXT_INFO_IMAGE_MIN.Size = new System.Drawing.Size(68, 22);
            this.TXT_INFO_IMAGE_MIN.TabIndex = 1;
            this.TXT_INFO_IMAGE_MIN.Text = "1";
            this.TXT_INFO_IMAGE_MIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // msg
            // 
            this.msg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.msg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.msg.ForeColor = System.Drawing.Color.LimeGreen;
            this.msg.Location = new System.Drawing.Point(8, 30);
            this.msg.Name = "msg";
            this.msg.Size = new System.Drawing.Size(555, 127);
            this.msg.TabIndex = 6;
            this.msg.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.label27);
            this.panel1.Location = new System.Drawing.Point(6, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(566, 317);
            this.panel1.TabIndex = 8;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(422, 287);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 9;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Visible = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel9.Controls.Add(this.label19);
            this.panel9.Controls.Add(this.label52);
            this.panel9.Controls.Add(this.TXT_INFO_IMAGE_MIN);
            this.panel9.Controls.Add(this.TXT_INFO_IMAGE_MAX);
            this.panel9.Controls.Add(this.BTN_PTRN_TEACHING_LOAD);
            this.panel9.Controls.Add(this.BTN_SET_RELATIVE_POSITION);
            this.panel9.Controls.Add(this.BTN_PTRN_MATCH);
            this.panel9.Controls.Add(this.label10);
            this.panel9.Controls.Add(this.TXT_PTRN_ACC_RATIO);
            this.panel9.Controls.Add(this.TXT_PTRN_FILE_NAME);
            this.panel9.Controls.Add(this.TXT_PTRN_PATH);
            this.panel9.Controls.Add(this.TXT_INFO_IMAGE_AVG);
            this.panel9.Controls.Add(this.uc_graph_global);
            this.panel9.Controls.Add(this.label51);
            this.panel9.Controls.Add(this.label38);
            this.panel9.Controls.Add(this.label35);
            this.panel9.Controls.Add(this.TXT_INFO_IMAGE_DIFF);
            this.panel9.Controls.Add(this.label34);
            this.panel9.Controls.Add(this.label36);
            this.panel9.Controls.Add(this.label33);
            this.panel9.Controls.Add(this.label15);
            this.panel9.Controls.Add(this.label14);
            this.panel9.Location = new System.Drawing.Point(5, 25);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(492, 256);
            this.panel9.TabIndex = 8;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label52.Location = new System.Drawing.Point(337, 224);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(22, 14);
            this.label52.TabIndex = 0;
            this.label52.Text = "%";
            // 
            // BTN_PTRN_TEACHING_LOAD
            // 
            this.BTN_PTRN_TEACHING_LOAD.BackgroundImage = global::CD_Simulator.Properties.Resources.recipe_load1;
            this.BTN_PTRN_TEACHING_LOAD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_PTRN_TEACHING_LOAD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_PTRN_TEACHING_LOAD.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.BTN_PTRN_TEACHING_LOAD.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BTN_PTRN_TEACHING_LOAD.Location = new System.Drawing.Point(451, 172);
            this.BTN_PTRN_TEACHING_LOAD.Name = "BTN_PTRN_TEACHING_LOAD";
            this.BTN_PTRN_TEACHING_LOAD.Size = new System.Drawing.Size(40, 40);
            this.BTN_PTRN_TEACHING_LOAD.TabIndex = 12;
            this.BTN_PTRN_TEACHING_LOAD.UseVisualStyleBackColor = true;
            this.BTN_PTRN_TEACHING_LOAD.Click += new System.EventHandler(this.BTN_PTRN_TEACHING_LOAD_Click);
            // 
            // BTN_SET_RELATIVE_POSITION
            // 
            this.BTN_SET_RELATIVE_POSITION.BackgroundImage = global::CD_Simulator.Properties.Resources.Posterious;
            this.BTN_SET_RELATIVE_POSITION.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_SET_RELATIVE_POSITION.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_SET_RELATIVE_POSITION.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.BTN_SET_RELATIVE_POSITION.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BTN_SET_RELATIVE_POSITION.Location = new System.Drawing.Point(365, 172);
            this.BTN_SET_RELATIVE_POSITION.Name = "BTN_SET_RELATIVE_POSITION";
            this.BTN_SET_RELATIVE_POSITION.Size = new System.Drawing.Size(40, 40);
            this.BTN_SET_RELATIVE_POSITION.TabIndex = 12;
            this.BTN_SET_RELATIVE_POSITION.UseVisualStyleBackColor = true;
            this.BTN_SET_RELATIVE_POSITION.Click += new System.EventHandler(this.BTN_SET_RELATIVE_POSITION_Click);
            // 
            // BTN_PTRN_MATCH
            // 
            this.BTN_PTRN_MATCH.BackgroundImage = global::CD_Simulator.Properties.Resources.matchfind;
            this.BTN_PTRN_MATCH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_PTRN_MATCH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_PTRN_MATCH.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.BTN_PTRN_MATCH.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BTN_PTRN_MATCH.Location = new System.Drawing.Point(408, 172);
            this.BTN_PTRN_MATCH.Name = "BTN_PTRN_MATCH";
            this.BTN_PTRN_MATCH.Size = new System.Drawing.Size(40, 40);
            this.BTN_PTRN_MATCH.TabIndex = 12;
            this.BTN_PTRN_MATCH.UseVisualStyleBackColor = true;
            this.BTN_PTRN_MATCH.Click += new System.EventHandler(this.BTN_PTRN_MATCH_Click);
            // 
            // TXT_PTRN_ACC_RATIO
            // 
            this.TXT_PTRN_ACC_RATIO.BackColor = System.Drawing.Color.Black;
            this.TXT_PTRN_ACC_RATIO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_PTRN_ACC_RATIO.ForeColor = System.Drawing.Color.Yellow;
            this.TXT_PTRN_ACC_RATIO.Location = new System.Drawing.Point(101, 221);
            this.TXT_PTRN_ACC_RATIO.Name = "TXT_PTRN_ACC_RATIO";
            this.TXT_PTRN_ACC_RATIO.Size = new System.Drawing.Size(230, 22);
            this.TXT_PTRN_ACC_RATIO.TabIndex = 1;
            // 
            // TXT_PTRN_FILE_NAME
            // 
            this.TXT_PTRN_FILE_NAME.BackColor = System.Drawing.Color.Black;
            this.TXT_PTRN_FILE_NAME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_PTRN_FILE_NAME.ForeColor = System.Drawing.Color.Yellow;
            this.TXT_PTRN_FILE_NAME.Location = new System.Drawing.Point(100, 196);
            this.TXT_PTRN_FILE_NAME.Name = "TXT_PTRN_FILE_NAME";
            this.TXT_PTRN_FILE_NAME.Size = new System.Drawing.Size(263, 22);
            this.TXT_PTRN_FILE_NAME.TabIndex = 1;
            // 
            // TXT_PTRN_PATH
            // 
            this.TXT_PTRN_PATH.BackColor = System.Drawing.Color.Black;
            this.TXT_PTRN_PATH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_PTRN_PATH.ForeColor = System.Drawing.Color.Yellow;
            this.TXT_PTRN_PATH.Location = new System.Drawing.Point(100, 171);
            this.TXT_PTRN_PATH.Name = "TXT_PTRN_PATH";
            this.TXT_PTRN_PATH.Size = new System.Drawing.Size(263, 22);
            this.TXT_PTRN_PATH.TabIndex = 1;
            // 
            // uc_graph_global
            // 
            this.uc_graph_global.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.uc_graph_global.COLOR_BOUND = System.Drawing.Color.White;
            this.uc_graph_global.COLOR_GRAPH = System.Drawing.Color.DeepSkyBlue;
            this.uc_graph_global.Font = new System.Drawing.Font("Verdana", 9F);
            this.uc_graph_global.Location = new System.Drawing.Point(5, 7);
            this.uc_graph_global.Name = "uc_graph_global";
            this.uc_graph_global.Size = new System.Drawing.Size(356, 160);
            this.uc_graph_global.TabIndex = 7;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label51.Location = new System.Drawing.Point(3, 224);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(98, 14);
            this.label51.TabIndex = 0;
            this.label51.Text = "ACPT RATIO :";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label38.Location = new System.Drawing.Point(5, 198);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(94, 14);
            this.label38.TabIndex = 0;
            this.label38.Text = "NAME PTRN :";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label35.Location = new System.Drawing.Point(4, 174);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(92, 14);
            this.label35.TabIndex = 0;
            this.label35.Text = "PATH PTRN :";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Verdana", 5F, System.Drawing.FontStyle.Bold);
            this.label34.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label34.Location = new System.Drawing.Point(453, 214);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(36, 8);
            this.label34.TabIndex = 0;
            this.label34.Text = "RELOAD";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Verdana", 5F, System.Drawing.FontStyle.Bold);
            this.label36.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label36.Location = new System.Drawing.Point(363, 214);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(43, 8);
            this.label36.TabIndex = 0;
            this.label36.Text = "RELATIVE";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Verdana", 5F, System.Drawing.FontStyle.Bold);
            this.label33.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label33.Location = new System.Drawing.Point(411, 214);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(33, 8);
            this.label33.TabIndex = 0;
            this.label33.Text = "MATCH";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.ForeColor = System.Drawing.Color.Orange;
            this.label27.Location = new System.Drawing.Point(7, 7);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(126, 14);
            this.label27.TabIndex = 0;
            this.label27.Text = "IMAGE QUALITY :";
            // 
            // PANEL_MESSAGE_WINDOW
            // 
            this.PANEL_MESSAGE_WINDOW.AllowDrop = true;
            this.PANEL_MESSAGE_WINDOW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.PANEL_MESSAGE_WINDOW.Controls.Add(this.msg);
            this.PANEL_MESSAGE_WINDOW.Controls.Add(this.label13);
            this.PANEL_MESSAGE_WINDOW.ForeColor = System.Drawing.Color.Cornsilk;
            this.PANEL_MESSAGE_WINDOW.Location = new System.Drawing.Point(6, 549);
            this.PANEL_MESSAGE_WINDOW.Name = "PANEL_MESSAGE_WINDOW";
            this.PANEL_MESSAGE_WINDOW.Size = new System.Drawing.Size(566, 160);
            this.PANEL_MESSAGE_WINDOW.TabIndex = 9;
            this.PANEL_MESSAGE_WINDOW.DragDrop += new System.Windows.Forms.DragEventHandler(this.PANEL_MESSAGE_WINDOW_DragDrop);
            this.PANEL_MESSAGE_WINDOW.DragEnter += new System.Windows.Forms.DragEventHandler(this.PANEL_MESSAGE_WINDOW_DragEnter);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Orange;
            this.label13.Location = new System.Drawing.Point(7, 8);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(149, 14);
            this.label13.TabIndex = 0;
            this.label13.Text = "MESSAGE WINDOW :";
            // 
            // CHK_MEASURE_DUMP
            // 
            this.CHK_MEASURE_DUMP.AutoSize = true;
            this.CHK_MEASURE_DUMP.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.CHK_MEASURE_DUMP.Location = new System.Drawing.Point(229, 8);
            this.CHK_MEASURE_DUMP.Name = "CHK_MEASURE_DUMP";
            this.CHK_MEASURE_DUMP.Size = new System.Drawing.Size(66, 18);
            this.CHK_MEASURE_DUMP.TabIndex = 8;
            this.CHK_MEASURE_DUMP.Text = "DUMP";
            this.CHK_MEASURE_DUMP.UseVisualStyleBackColor = true;
            this.CHK_MEASURE_DUMP.CheckedChanged += new System.EventHandler(this.CHK_MEASURE_VIEW_ONLY_CheckedChanged);
            // 
            // CHK_MEASURE_VIEW_ONLY
            // 
            this.CHK_MEASURE_VIEW_ONLY.AutoSize = true;
            this.CHK_MEASURE_VIEW_ONLY.Checked = true;
            this.CHK_MEASURE_VIEW_ONLY.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CHK_MEASURE_VIEW_ONLY.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.CHK_MEASURE_VIEW_ONLY.Location = new System.Drawing.Point(128, 8);
            this.CHK_MEASURE_VIEW_ONLY.Name = "CHK_MEASURE_VIEW_ONLY";
            this.CHK_MEASURE_VIEW_ONLY.Size = new System.Drawing.Size(106, 18);
            this.CHK_MEASURE_VIEW_ONLY.TabIndex = 8;
            this.CHK_MEASURE_VIEW_ONLY.Text = "VIEW ONLY";
            this.CHK_MEASURE_VIEW_ONLY.UseVisualStyleBackColor = true;
            this.CHK_MEASURE_VIEW_ONLY.CheckedChanged += new System.EventHandler(this.CHK_MEASURE_VIEW_ONLY_CheckedChanged);
            // 
            // LV_FILE_LIST
            // 
            this.LV_FILE_LIST.AllowDrop = true;
            this.LV_FILE_LIST.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.LV_FILE_LIST.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.INDEX,
            this.FILES});
            this.LV_FILE_LIST.ForeColor = System.Drawing.Color.LimeGreen;
            this.LV_FILE_LIST.FullRowSelect = true;
            this.LV_FILE_LIST.GridLines = true;
            this.LV_FILE_LIST.Location = new System.Drawing.Point(7, 33);
            this.LV_FILE_LIST.Name = "LV_FILE_LIST";
            this.LV_FILE_LIST.Size = new System.Drawing.Size(303, 486);
            this.LV_FILE_LIST.TabIndex = 7;
            this.LV_FILE_LIST.UseCompatibleStateImageBehavior = false;
            this.LV_FILE_LIST.View = System.Windows.Forms.View.Details;
            this.LV_FILE_LIST.SelectedIndexChanged += new System.EventHandler(this.LV_FILE_LIST_SelectedIndexChanged);
            this.LV_FILE_LIST.DragDrop += new System.Windows.Forms.DragEventHandler(this.LV_FILE_LIST_DragDrop);
            this.LV_FILE_LIST.DragEnter += new System.Windows.Forms.DragEventHandler(this.LV_FILE_LIST_DragEnter);
            this.LV_FILE_LIST.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LV_FILE_LIST_MouseDoubleClick);
            // 
            // INDEX
            // 
            this.INDEX.Text = "IDX";
            // 
            // FILES
            // 
            this.FILES.Text = "FILES";
            this.FILES.Width = 300;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label31.Location = new System.Drawing.Point(4, 105);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(94, 18);
            this.label31.TabIndex = 1;
            this.label31.Text = "MEASURE";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.ForeColor = System.Drawing.Color.Orange;
            this.label37.Location = new System.Drawing.Point(7, 9);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(115, 14);
            this.label37.TabIndex = 0;
            this.label37.Text = "MEASURE LIST :";
            // 
            // LV_PARAMETER
            // 
            this.LV_PARAMETER.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LV_PARAMETER.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.LV_PARAMETER.ForeColor = System.Drawing.Color.LimeGreen;
            this.LV_PARAMETER.FullRowSelect = true;
            this.LV_PARAMETER.GridLines = true;
            this.LV_PARAMETER.Location = new System.Drawing.Point(6, 46);
            this.LV_PARAMETER.Name = "LV_PARAMETER";
            this.LV_PARAMETER.Scrollable = false;
            this.LV_PARAMETER.Size = new System.Drawing.Size(209, 602);
            this.LV_PARAMETER.TabIndex = 11;
            this.LV_PARAMETER.UseCompatibleStateImageBehavior = false;
            this.LV_PARAMETER.View = System.Windows.Forms.View.Details;
            this.LV_PARAMETER.SelectedIndexChanged += new System.EventHandler(this.LV_PARAMETER_SelectedIndexChanged);
            this.LV_PARAMETER.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LV_PARAMETER_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "IDX";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "FIGURES";
            this.columnHeader2.Width = 200;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.panel6.Controls.Add(this.BTN_UPDATE_PARAM_FIGURES);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.LV_PARAMETER);
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(223, 651);
            this.panel6.TabIndex = 12;
            // 
            // BTN_UPDATE_PARAM_FIGURES
            // 
            this.BTN_UPDATE_PARAM_FIGURES.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.BTN_UPDATE_PARAM_FIGURES.FlatAppearance.BorderSize = 3;
            this.BTN_UPDATE_PARAM_FIGURES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_UPDATE_PARAM_FIGURES.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.BTN_UPDATE_PARAM_FIGURES.Location = new System.Drawing.Point(118, 3);
            this.BTN_UPDATE_PARAM_FIGURES.Name = "BTN_UPDATE_PARAM_FIGURES";
            this.BTN_UPDATE_PARAM_FIGURES.Size = new System.Drawing.Size(100, 35);
            this.BTN_UPDATE_PARAM_FIGURES.TabIndex = 12;
            this.BTN_UPDATE_PARAM_FIGURES.Text = "REFRESH";
            this.BTN_UPDATE_PARAM_FIGURES.UseVisualStyleBackColor = true;
            this.BTN_UPDATE_PARAM_FIGURES.Click += new System.EventHandler(this.BTN_UPDATE_PARAM_FIGURES_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Orange;
            this.label9.Location = new System.Drawing.Point(10, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 14);
            this.label9.TabIndex = 0;
            this.label9.Text = "FIGURE LIST :";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel7.Controls.Add(this.UC_PARAMETER);
            this.panel7.Controls.Add(this.label39);
            this.panel7.Controls.Add(this.BTN_UPDATE_PARAMETER);
            this.panel7.Location = new System.Drawing.Point(228, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(344, 650);
            this.panel7.TabIndex = 12;
            // 
            // UC_PARAMETER
            // 
            this.UC_PARAMETER.Location = new System.Drawing.Point(6, 45);
            this.UC_PARAMETER.Name = "UC_PARAMETER";
            this.UC_PARAMETER.Size = new System.Drawing.Size(335, 587);
            this.UC_PARAMETER.TabIndex = 1;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.ForeColor = System.Drawing.Color.Orange;
            this.label39.Location = new System.Drawing.Point(3, 13);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(105, 14);
            this.label39.TabIndex = 0;
            this.label39.Text = "PARAMETERS :";
            // 
            // BTN_UPDATE_PARAMETER
            // 
            this.BTN_UPDATE_PARAMETER.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_UPDATE_PARAMETER.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.BTN_UPDATE_PARAMETER.FlatAppearance.BorderSize = 3;
            this.BTN_UPDATE_PARAMETER.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_UPDATE_PARAMETER.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.BTN_UPDATE_PARAMETER.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.BTN_UPDATE_PARAMETER.Location = new System.Drawing.Point(178, 2);
            this.BTN_UPDATE_PARAMETER.Name = "BTN_UPDATE_PARAMETER";
            this.BTN_UPDATE_PARAMETER.Size = new System.Drawing.Size(100, 35);
            this.BTN_UPDATE_PARAMETER.TabIndex = 0;
            this.BTN_UPDATE_PARAMETER.Text = "Update";
            this.BTN_UPDATE_PARAMETER.UseVisualStyleBackColor = true;
            this.BTN_UPDATE_PARAMETER.Click += new System.EventHandler(this.BTN_UPDATE_PARAMETER_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.panel8.Controls.Add(this.panel10);
            this.panel8.Controls.Add(this.label28);
            this.panel8.Location = new System.Drawing.Point(6, 417);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(566, 126);
            this.panel8.TabIndex = 13;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel10.Controls.Add(this.label22);
            this.panel10.Controls.Add(this.label21);
            this.panel10.Controls.Add(this.BTN_RECIPE_SAVE);
            this.panel10.Controls.Add(this.BTN_RECIPE_LOAD);
            this.panel10.Controls.Add(this.TXT_PATH_DUMP);
            this.panel10.Controls.Add(this.TXT_PATH_RECP_FILE);
            this.panel10.Controls.Add(this.TXT_PATH_RECIPE);
            this.panel10.Controls.Add(this.label20);
            this.panel10.Controls.Add(this.label12);
            this.panel10.Controls.Add(this.label11);
            this.panel10.Location = new System.Drawing.Point(5, 25);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(558, 94);
            this.panel10.TabIndex = 13;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label22.Location = new System.Drawing.Point(513, 63);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(32, 12);
            this.label22.TabIndex = 1;
            this.label22.Text = "SAVE";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label21.Location = new System.Drawing.Point(457, 63);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(34, 12);
            this.label21.TabIndex = 1;
            this.label21.Text = "LOAD";
            // 
            // BTN_RECIPE_SAVE
            // 
            this.BTN_RECIPE_SAVE.BackgroundImage = global::CD_Simulator.Properties.Resources.recipe_save;
            this.BTN_RECIPE_SAVE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_RECIPE_SAVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_RECIPE_SAVE.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.BTN_RECIPE_SAVE.Location = new System.Drawing.Point(504, 10);
            this.BTN_RECIPE_SAVE.Name = "BTN_RECIPE_SAVE";
            this.BTN_RECIPE_SAVE.Size = new System.Drawing.Size(50, 50);
            this.BTN_RECIPE_SAVE.TabIndex = 12;
            this.BTN_RECIPE_SAVE.UseVisualStyleBackColor = true;
            this.BTN_RECIPE_SAVE.Click += new System.EventHandler(this.BTN_RECIPE_SAVE_Click);
            // 
            // BTN_RECIPE_LOAD
            // 
            this.BTN_RECIPE_LOAD.BackgroundImage = global::CD_Simulator.Properties.Resources.recipe_load;
            this.BTN_RECIPE_LOAD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_RECIPE_LOAD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_RECIPE_LOAD.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.BTN_RECIPE_LOAD.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BTN_RECIPE_LOAD.Location = new System.Drawing.Point(448, 10);
            this.BTN_RECIPE_LOAD.Name = "BTN_RECIPE_LOAD";
            this.BTN_RECIPE_LOAD.Size = new System.Drawing.Size(50, 50);
            this.BTN_RECIPE_LOAD.TabIndex = 12;
            this.BTN_RECIPE_LOAD.UseVisualStyleBackColor = true;
            this.BTN_RECIPE_LOAD.Click += new System.EventHandler(this.BTN_RECIPE_LOAD_Click);
            // 
            // TXT_PATH_DUMP
            // 
            this.TXT_PATH_DUMP.BackColor = System.Drawing.Color.Black;
            this.TXT_PATH_DUMP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_PATH_DUMP.ForeColor = System.Drawing.Color.Yellow;
            this.TXT_PATH_DUMP.Location = new System.Drawing.Point(102, 65);
            this.TXT_PATH_DUMP.Name = "TXT_PATH_DUMP";
            this.TXT_PATH_DUMP.Size = new System.Drawing.Size(342, 22);
            this.TXT_PATH_DUMP.TabIndex = 1;
            // 
            // TXT_PATH_RECP_FILE
            // 
            this.TXT_PATH_RECP_FILE.BackColor = System.Drawing.Color.Black;
            this.TXT_PATH_RECP_FILE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_PATH_RECP_FILE.ForeColor = System.Drawing.Color.Yellow;
            this.TXT_PATH_RECP_FILE.Location = new System.Drawing.Point(102, 37);
            this.TXT_PATH_RECP_FILE.Name = "TXT_PATH_RECP_FILE";
            this.TXT_PATH_RECP_FILE.Size = new System.Drawing.Size(341, 22);
            this.TXT_PATH_RECP_FILE.TabIndex = 1;
            // 
            // TXT_PATH_RECIPE
            // 
            this.TXT_PATH_RECIPE.BackColor = System.Drawing.Color.Black;
            this.TXT_PATH_RECIPE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_PATH_RECIPE.ForeColor = System.Drawing.Color.Yellow;
            this.TXT_PATH_RECIPE.Location = new System.Drawing.Point(102, 9);
            this.TXT_PATH_RECIPE.Name = "TXT_PATH_RECIPE";
            this.TXT_PATH_RECIPE.Size = new System.Drawing.Size(342, 22);
            this.TXT_PATH_RECIPE.TabIndex = 1;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label20.Location = new System.Drawing.Point(3, 39);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(98, 14);
            this.label20.TabIndex = 0;
            this.label20.Text = "NAME_RECP :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label12.Location = new System.Drawing.Point(3, 69);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 14);
            this.label12.TabIndex = 0;
            this.label12.Text = "PATH_DUMP :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label11.Location = new System.Drawing.Point(3, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 14);
            this.label11.TabIndex = 0;
            this.label11.Text = "PATH_RECP :";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.ForeColor = System.Drawing.Color.Orange;
            this.label28.Location = new System.Drawing.Point(9, 8);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(128, 14);
            this.label28.TabIndex = 0;
            this.label28.Text = "RECIPE SETTING :";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.panel11.Controls.Add(this.imageView1);
            this.panel11.Controls.Add(this.SELECT_VIEW2);
            this.panel11.Controls.Add(this.BTN_SELECT_VIEW1);
            this.panel11.Controls.Add(this.imageView2);
            this.panel11.Controls.Add(this.LB_CAM_INDEX);
            this.panel11.Location = new System.Drawing.Point(9, 12);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(654, 626);
            this.panel11.TabIndex = 14;
            // 
            // imageView1
            // 
            this.imageView1.AllowDrop = true;
            this.imageView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.imageView1.BOOL_TEACHING_ACTIVATION = false;
            this.imageView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imageView1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageView1.ForeColor = System.Drawing.Color.Lime;
            this.imageView1.Location = new System.Drawing.Point(48, 8);
            this.imageView1.Name = "imageView1";
            this.imageView1.PT_FIGURE_TO_DRAW = ((System.Drawing.PointF)(resources.GetObject("imageView1.PT_FIGURE_TO_DRAW")));
            this.imageView1.ROI_INDEX = -1;
            this.imageView1.Size = new System.Drawing.Size(600, 600);
            this.imageView1.TabIndex = 13;
            // 
            // SELECT_VIEW2
            // 
            this.SELECT_VIEW2.BackgroundImage = global::CD_Simulator.Properties.Resources.cam2;
            this.SELECT_VIEW2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SELECT_VIEW2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.SELECT_VIEW2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.SELECT_VIEW2.Location = new System.Drawing.Point(8, 46);
            this.SELECT_VIEW2.Name = "SELECT_VIEW2";
            this.SELECT_VIEW2.Size = new System.Drawing.Size(40, 40);
            this.SELECT_VIEW2.TabIndex = 12;
            this.SELECT_VIEW2.UseVisualStyleBackColor = true;
            this.SELECT_VIEW2.Click += new System.EventHandler(this.BTN_SELECT_VIEW_Click);
            // 
            // BTN_SELECT_VIEW1
            // 
            this.BTN_SELECT_VIEW1.BackgroundImage = global::CD_Simulator.Properties.Resources.cam1;
            this.BTN_SELECT_VIEW1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_SELECT_VIEW1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.BTN_SELECT_VIEW1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BTN_SELECT_VIEW1.Location = new System.Drawing.Point(8, 8);
            this.BTN_SELECT_VIEW1.Name = "BTN_SELECT_VIEW1";
            this.BTN_SELECT_VIEW1.Size = new System.Drawing.Size(40, 40);
            this.BTN_SELECT_VIEW1.TabIndex = 12;
            this.BTN_SELECT_VIEW1.UseVisualStyleBackColor = true;
            this.BTN_SELECT_VIEW1.Click += new System.EventHandler(this.BTN_SELECT_VIEW_Click);
            // 
            // imageView2
            // 
            this.imageView2.AllowDrop = true;
            this.imageView2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.imageView2.BOOL_TEACHING_ACTIVATION = false;
            this.imageView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imageView2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageView2.ForeColor = System.Drawing.Color.Lime;
            this.imageView2.Location = new System.Drawing.Point(48, 8);
            this.imageView2.Name = "imageView2";
            this.imageView2.PT_FIGURE_TO_DRAW = ((System.Drawing.PointF)(resources.GetObject("imageView2.PT_FIGURE_TO_DRAW")));
            this.imageView2.ROI_INDEX = -1;
            this.imageView2.Size = new System.Drawing.Size(600, 600);
            this.imageView2.TabIndex = 0;
            // 
            // LB_CAM_INDEX
            // 
            this.LB_CAM_INDEX.AutoSize = true;
            this.LB_CAM_INDEX.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.LB_CAM_INDEX.Location = new System.Drawing.Point(16, 544);
            this.LB_CAM_INDEX.Name = "LB_CAM_INDEX";
            this.LB_CAM_INDEX.Size = new System.Drawing.Size(26, 14);
            this.LB_CAM_INDEX.TabIndex = 0;
            this.LB_CAM_INDEX.Text = "#1";
            // 
            // PANEL_VIEW_BLEND
            // 
            this.PANEL_VIEW_BLEND.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.PANEL_VIEW_BLEND.Controls.Add(this.CHK_BLEND);
            this.PANEL_VIEW_BLEND.Controls.Add(this.TB_BLENDING_RATIO);
            this.PANEL_VIEW_BLEND.Controls.Add(this.LB_BLEND_VALUE);
            this.PANEL_VIEW_BLEND.Controls.Add(this.label30);
            this.PANEL_VIEW_BLEND.Location = new System.Drawing.Point(9, 644);
            this.PANEL_VIEW_BLEND.Name = "PANEL_VIEW_BLEND";
            this.PANEL_VIEW_BLEND.Size = new System.Drawing.Size(653, 26);
            this.PANEL_VIEW_BLEND.TabIndex = 15;
            // 
            // CHK_BLEND
            // 
            this.CHK_BLEND.AutoSize = true;
            this.CHK_BLEND.Location = new System.Drawing.Point(9, 6);
            this.CHK_BLEND.Name = "CHK_BLEND";
            this.CHK_BLEND.Size = new System.Drawing.Size(15, 14);
            this.CHK_BLEND.TabIndex = 5;
            this.CHK_BLEND.UseVisualStyleBackColor = true;
            this.CHK_BLEND.CheckedChanged += new System.EventHandler(this.CHK_BLEND_CheckedChanged);
            // 
            // TB_BLENDING_RATIO
            // 
            this.TB_BLENDING_RATIO.Enabled = false;
            this.TB_BLENDING_RATIO.Location = new System.Drawing.Point(103, -10);
            this.TB_BLENDING_RATIO.Maximum = 100;
            this.TB_BLENDING_RATIO.Name = "TB_BLENDING_RATIO";
            this.TB_BLENDING_RATIO.Size = new System.Drawing.Size(430, 45);
            this.TB_BLENDING_RATIO.SmallChange = 5;
            this.TB_BLENDING_RATIO.TabIndex = 4;
            this.TB_BLENDING_RATIO.TickFrequency = 5;
            this.TB_BLENDING_RATIO.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.TB_BLENDING_RATIO.Scroll += new System.EventHandler(this.TB_BLENDING_RATIO_Scroll);
            // 
            // LB_BLEND_VALUE
            // 
            this.LB_BLEND_VALUE.AutoSize = true;
            this.LB_BLEND_VALUE.ForeColor = System.Drawing.Color.Black;
            this.LB_BLEND_VALUE.Location = new System.Drawing.Point(561, 7);
            this.LB_BLEND_VALUE.Name = "LB_BLEND_VALUE";
            this.LB_BLEND_VALUE.Size = new System.Drawing.Size(35, 14);
            this.LB_BLEND_VALUE.TabIndex = 0;
            this.LB_BLEND_VALUE.Text = "0 %";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label30.Location = new System.Drawing.Point(30, 6);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(67, 14);
            this.label30.TabIndex = 0;
            this.label30.Text = "Blender :";
            // 
            // panel_temp
            // 
            this.panel_temp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.panel_temp.Controls.Add(this.PANEL_VIEW_TOOLS);
            this.panel_temp.Location = new System.Drawing.Point(9, 676);
            this.panel_temp.Name = "panel_temp";
            this.panel_temp.Size = new System.Drawing.Size(653, 86);
            this.panel_temp.TabIndex = 15;
            // 
            // TAB_MENU
            // 
            this.TAB_MENU.Controls.Add(this.page_main);
            this.TAB_MENU.Controls.Add(this.page_setting);
            this.TAB_MENU.Controls.Add(this.page_param);
            this.TAB_MENU.ItemSize = new System.Drawing.Size(54, 30);
            this.TAB_MENU.Location = new System.Drawing.Point(668, 9);
            this.TAB_MENU.Name = "TAB_MENU";
            this.TAB_MENU.SelectedIndex = 0;
            this.TAB_MENU.Size = new System.Drawing.Size(583, 753);
            this.TAB_MENU.TabIndex = 17;
            this.TAB_MENU.SelectedIndexChanged += new System.EventHandler(this.TAB_MENU_SelectedIndexChanged);
            // 
            // page_main
            // 
            this.page_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.page_main.Controls.Add(this.panel2);
            this.page_main.Controls.Add(this.panel8);
            this.page_main.Controls.Add(this.panel1);
            this.page_main.Controls.Add(this.PANEL_MESSAGE_WINDOW);
            this.page_main.Location = new System.Drawing.Point(4, 34);
            this.page_main.Name = "page_main";
            this.page_main.Padding = new System.Windows.Forms.Padding(3);
            this.page_main.Size = new System.Drawing.Size(575, 715);
            this.page_main.TabIndex = 0;
            this.page_main.Text = "MAIN";
            // 
            // page_setting
            // 
            this.page_setting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.page_setting.Controls.Add(this.panel12);
            this.page_setting.Location = new System.Drawing.Point(4, 34);
            this.page_setting.Name = "page_setting";
            this.page_setting.Padding = new System.Windows.Forms.Padding(3);
            this.page_setting.Size = new System.Drawing.Size(575, 715);
            this.page_setting.TabIndex = 1;
            this.page_setting.Text = "SETTING";
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel12.Controls.Add(this.TAB_FIGURE);
            this.panel12.Controls.Add(this.panel25);
            this.panel12.Location = new System.Drawing.Point(-4, 6);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(1020, 648);
            this.panel12.TabIndex = 19;
            // 
            // TAB_FIGURE
            // 
            this.TAB_FIGURE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TAB_FIGURE.Controls.Add(this.rcPairHorizontal);
            this.TAB_FIGURE.Controls.Add(this.rcPairVertical);
            this.TAB_FIGURE.Controls.Add(this.rcPairDiagonal);
            this.TAB_FIGURE.Controls.Add(this.circle);
            this.TAB_FIGURE.Controls.Add(this.Ol);
            this.TAB_FIGURE.Controls.Add(this.ptrn);
            this.TAB_FIGURE.ImageList = this.imageList1;
            this.TAB_FIGURE.ItemSize = new System.Drawing.Size(82, 30);
            this.TAB_FIGURE.Location = new System.Drawing.Point(14, 10);
            this.TAB_FIGURE.Name = "TAB_FIGURE";
            this.TAB_FIGURE.SelectedIndex = 0;
            this.TAB_FIGURE.Size = new System.Drawing.Size(559, 267);
            this.TAB_FIGURE.TabIndex = 14;
            this.TAB_FIGURE.SelectedIndexChanged += new System.EventHandler(this.TAB_FIGURE_SelectedIndexChanged);
            this.TAB_FIGURE.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LV_FIGURE_KeyDown);
            // 
            // rcPairHorizontal
            // 
            this.rcPairHorizontal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.rcPairHorizontal.Controls.Add(this.panel14);
            this.rcPairHorizontal.Controls.Add(this.panel15);
            this.rcPairHorizontal.Controls.Add(this.LV_PAIR_HOR);
            this.rcPairHorizontal.ImageKey = "measureHor.png";
            this.rcPairHorizontal.Location = new System.Drawing.Point(4, 34);
            this.rcPairHorizontal.Name = "rcPairHorizontal";
            this.rcPairHorizontal.Padding = new System.Windows.Forms.Padding(3);
            this.rcPairHorizontal.Size = new System.Drawing.Size(551, 229);
            this.rcPairHorizontal.TabIndex = 0;
            this.rcPairHorizontal.Text = "HOR";
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.panel14.Controls.Add(this.BTN_HOR_ADD);
            this.panel14.Controls.Add(this.BTN_HOR_COPY);
            this.panel14.Controls.Add(this.BTN_HOR_MODIFY);
            this.panel14.Controls.Add(this.BTN_HOR_REMOVE);
            this.panel14.Location = new System.Drawing.Point(125, 5);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(115, 220);
            this.panel14.TabIndex = 7;
            // 
            // BTN_HOR_ADD
            // 
            this.BTN_HOR_ADD.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.BTN_HOR_ADD.FlatAppearance.BorderSize = 3;
            this.BTN_HOR_ADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_HOR_ADD.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.BTN_HOR_ADD.Location = new System.Drawing.Point(2, 5);
            this.BTN_HOR_ADD.Name = "BTN_HOR_ADD";
            this.BTN_HOR_ADD.Size = new System.Drawing.Size(110, 30);
            this.BTN_HOR_ADD.TabIndex = 2;
            this.BTN_HOR_ADD.Text = "ADD";
            this.BTN_HOR_ADD.UseVisualStyleBackColor = true;
            this.BTN_HOR_ADD.Click += new System.EventHandler(this.BTN_HOR_ADD_Click);
            // 
            // BTN_HOR_COPY
            // 
            this.BTN_HOR_COPY.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.BTN_HOR_COPY.FlatAppearance.BorderSize = 3;
            this.BTN_HOR_COPY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_HOR_COPY.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.BTN_HOR_COPY.Location = new System.Drawing.Point(2, 40);
            this.BTN_HOR_COPY.Name = "BTN_HOR_COPY";
            this.BTN_HOR_COPY.Size = new System.Drawing.Size(110, 30);
            this.BTN_HOR_COPY.TabIndex = 2;
            this.BTN_HOR_COPY.Text = "COPY";
            this.BTN_HOR_COPY.UseVisualStyleBackColor = true;
            this.BTN_HOR_COPY.Click += new System.EventHandler(this.BTN_HOR_COPY_Click);
            // 
            // BTN_HOR_MODIFY
            // 
            this.BTN_HOR_MODIFY.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.BTN_HOR_MODIFY.FlatAppearance.BorderSize = 3;
            this.BTN_HOR_MODIFY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_HOR_MODIFY.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.BTN_HOR_MODIFY.Location = new System.Drawing.Point(2, 75);
            this.BTN_HOR_MODIFY.Name = "BTN_HOR_MODIFY";
            this.BTN_HOR_MODIFY.Size = new System.Drawing.Size(110, 30);
            this.BTN_HOR_MODIFY.TabIndex = 2;
            this.BTN_HOR_MODIFY.Text = "MODIFY";
            this.BTN_HOR_MODIFY.UseVisualStyleBackColor = true;
            this.BTN_HOR_MODIFY.Click += new System.EventHandler(this.BTN_HOR_MODIFY_Click);
            // 
            // BTN_HOR_REMOVE
            // 
            this.BTN_HOR_REMOVE.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.BTN_HOR_REMOVE.FlatAppearance.BorderSize = 3;
            this.BTN_HOR_REMOVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_HOR_REMOVE.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.BTN_HOR_REMOVE.Location = new System.Drawing.Point(2, 111);
            this.BTN_HOR_REMOVE.Name = "BTN_HOR_REMOVE";
            this.BTN_HOR_REMOVE.Size = new System.Drawing.Size(110, 30);
            this.BTN_HOR_REMOVE.TabIndex = 2;
            this.BTN_HOR_REMOVE.TabStop = false;
            this.BTN_HOR_REMOVE.Text = "REMOVE";
            this.BTN_HOR_REMOVE.UseVisualStyleBackColor = true;
            this.BTN_HOR_REMOVE.Click += new System.EventHandler(this.BTN_HOR_REMOVE_Click);
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.panel15.Controls.Add(this.label40);
            this.panel15.Controls.Add(this.button1);
            this.panel15.Controls.Add(this.TXT_RCH_W);
            this.panel15.Controls.Add(this.LB_RCH_W);
            this.panel15.Controls.Add(this.TXT_RCH_H);
            this.panel15.Controls.Add(this.LB_RCH_H);
            this.panel15.Controls.Add(this.TXT_PARAM_HOR_NICK);
            this.panel15.Location = new System.Drawing.Point(5, 5);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(115, 220);
            this.panel15.TabIndex = 6;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label40.ForeColor = System.Drawing.Color.Orange;
            this.label40.Location = new System.Drawing.Point(5, 140);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(50, 14);
            this.label40.TabIndex = 0;
            this.label40.Text = "NICK :";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::CD_Simulator.Properties.Resources.measureHor;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.button1.Location = new System.Drawing.Point(5, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 100);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TXT_RCH_W
            // 
            this.TXT_RCH_W.BackColor = System.Drawing.Color.Black;
            this.TXT_RCH_W.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_RCH_W.ForeColor = System.Drawing.Color.LimeGreen;
            this.TXT_RCH_W.Location = new System.Drawing.Point(58, 165);
            this.TXT_RCH_W.Name = "TXT_RCH_W";
            this.TXT_RCH_W.Size = new System.Drawing.Size(54, 22);
            this.TXT_RCH_W.TabIndex = 7;
            this.TXT_RCH_W.Text = "0";
            this.TXT_RCH_W.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LB_RCH_W
            // 
            this.LB_RCH_W.AutoSize = true;
            this.LB_RCH_W.ForeColor = System.Drawing.Color.Orange;
            this.LB_RCH_W.Location = new System.Drawing.Point(5, 167);
            this.LB_RCH_W.Name = "LB_RCH_W";
            this.LB_RCH_W.Size = new System.Drawing.Size(51, 14);
            this.LB_RCH_W.TabIndex = 0;
            this.LB_RCH_W.Text = "SZ_X :";
            // 
            // TXT_RCH_H
            // 
            this.TXT_RCH_H.BackColor = System.Drawing.Color.Black;
            this.TXT_RCH_H.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_RCH_H.ForeColor = System.Drawing.Color.LimeGreen;
            this.TXT_RCH_H.Location = new System.Drawing.Point(58, 192);
            this.TXT_RCH_H.Name = "TXT_RCH_H";
            this.TXT_RCH_H.Size = new System.Drawing.Size(54, 22);
            this.TXT_RCH_H.TabIndex = 7;
            this.TXT_RCH_H.Text = "0";
            this.TXT_RCH_H.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LB_RCH_H
            // 
            this.LB_RCH_H.AutoSize = true;
            this.LB_RCH_H.ForeColor = System.Drawing.Color.Orange;
            this.LB_RCH_H.Location = new System.Drawing.Point(5, 194);
            this.LB_RCH_H.Name = "LB_RCH_H";
            this.LB_RCH_H.Size = new System.Drawing.Size(52, 14);
            this.LB_RCH_H.TabIndex = 0;
            this.LB_RCH_H.Text = "SZ_Y :";
            // 
            // TXT_PARAM_HOR_NICK
            // 
            this.TXT_PARAM_HOR_NICK.BackColor = System.Drawing.Color.Black;
            this.TXT_PARAM_HOR_NICK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_PARAM_HOR_NICK.ForeColor = System.Drawing.Color.LimeGreen;
            this.TXT_PARAM_HOR_NICK.Location = new System.Drawing.Point(58, 138);
            this.TXT_PARAM_HOR_NICK.Name = "TXT_PARAM_HOR_NICK";
            this.TXT_PARAM_HOR_NICK.Size = new System.Drawing.Size(54, 22);
            this.TXT_PARAM_HOR_NICK.TabIndex = 7;
            this.TXT_PARAM_HOR_NICK.Text = "hor";
            this.TXT_PARAM_HOR_NICK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LV_PAIR_HOR
            // 
            this.LV_PAIR_HOR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.LV_PAIR_HOR.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.LV_PAIR_HOR.ForeColor = System.Drawing.Color.LimeGreen;
            this.LV_PAIR_HOR.FullRowSelect = true;
            this.LV_PAIR_HOR.GridLines = true;
            this.LV_PAIR_HOR.Location = new System.Drawing.Point(245, 5);
            this.LV_PAIR_HOR.Name = "LV_PAIR_HOR";
            this.LV_PAIR_HOR.Size = new System.Drawing.Size(300, 220);
            this.LV_PAIR_HOR.TabIndex = 3;
            this.LV_PAIR_HOR.UseCompatibleStateImageBehavior = false;
            this.LV_PAIR_HOR.View = System.Windows.Forms.View.Details;
            this.LV_PAIR_HOR.SelectedIndexChanged += new System.EventHandler(this.LV_PAIR_HOR_SelectedIndexChanged);
            this.LV_PAIR_HOR.DoubleClick += new System.EventHandler(this.LV_PAIR_HOR_DoubleClick);
            this.LV_PAIR_HOR.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LV_FIGURE_KeyDown);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "IDX";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "FIGURE";
            this.columnHeader4.Width = 150;
            // 
            // rcPairVertical
            // 
            this.rcPairVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.rcPairVertical.Controls.Add(this.panel16);
            this.rcPairVertical.Controls.Add(this.panel18);
            this.rcPairVertical.Controls.Add(this.LV_PAIR_VER);
            this.rcPairVertical.ImageKey = "measureVer.png";
            this.rcPairVertical.Location = new System.Drawing.Point(4, 34);
            this.rcPairVertical.Name = "rcPairVertical";
            this.rcPairVertical.Padding = new System.Windows.Forms.Padding(3);
            this.rcPairVertical.Size = new System.Drawing.Size(551, 229);
            this.rcPairVertical.TabIndex = 1;
            this.rcPairVertical.Text = "VER";
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.panel16.Controls.Add(this.BTN_VER_COPY);
            this.panel16.Controls.Add(this.BTN_VER_ADD);
            this.panel16.Controls.Add(this.BTN_VER_MODIFY);
            this.panel16.Controls.Add(this.BTN_VER_REMOVE);
            this.panel16.Location = new System.Drawing.Point(125, 5);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(115, 220);
            this.panel16.TabIndex = 13;
            // 
            // BTN_VER_COPY
            // 
            this.BTN_VER_COPY.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.BTN_VER_COPY.FlatAppearance.BorderSize = 3;
            this.BTN_VER_COPY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_VER_COPY.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.BTN_VER_COPY.Location = new System.Drawing.Point(2, 40);
            this.BTN_VER_COPY.Name = "BTN_VER_COPY";
            this.BTN_VER_COPY.Size = new System.Drawing.Size(110, 30);
            this.BTN_VER_COPY.TabIndex = 3;
            this.BTN_VER_COPY.Text = "COPY";
            this.BTN_VER_COPY.UseVisualStyleBackColor = true;
            this.BTN_VER_COPY.Click += new System.EventHandler(this.BTN_VER_COPY_Click);
            // 
            // BTN_VER_ADD
            // 
            this.BTN_VER_ADD.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.BTN_VER_ADD.FlatAppearance.BorderSize = 3;
            this.BTN_VER_ADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_VER_ADD.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.BTN_VER_ADD.Location = new System.Drawing.Point(2, 5);
            this.BTN_VER_ADD.Name = "BTN_VER_ADD";
            this.BTN_VER_ADD.Size = new System.Drawing.Size(110, 30);
            this.BTN_VER_ADD.TabIndex = 2;
            this.BTN_VER_ADD.Text = "ADD";
            this.BTN_VER_ADD.UseVisualStyleBackColor = true;
            this.BTN_VER_ADD.Click += new System.EventHandler(this.BTN_VER_ADD_Click);
            // 
            // BTN_VER_MODIFY
            // 
            this.BTN_VER_MODIFY.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.BTN_VER_MODIFY.FlatAppearance.BorderSize = 3;
            this.BTN_VER_MODIFY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_VER_MODIFY.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.BTN_VER_MODIFY.Location = new System.Drawing.Point(2, 75);
            this.BTN_VER_MODIFY.Name = "BTN_VER_MODIFY";
            this.BTN_VER_MODIFY.Size = new System.Drawing.Size(110, 30);
            this.BTN_VER_MODIFY.TabIndex = 2;
            this.BTN_VER_MODIFY.Text = "MODIFY";
            this.BTN_VER_MODIFY.UseVisualStyleBackColor = true;
            this.BTN_VER_MODIFY.Click += new System.EventHandler(this.BTN_VER_MODIFY_Click);
            // 
            // BTN_VER_REMOVE
            // 
            this.BTN_VER_REMOVE.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.BTN_VER_REMOVE.FlatAppearance.BorderSize = 3;
            this.BTN_VER_REMOVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_VER_REMOVE.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.BTN_VER_REMOVE.Location = new System.Drawing.Point(2, 111);
            this.BTN_VER_REMOVE.Name = "BTN_VER_REMOVE";
            this.BTN_VER_REMOVE.Size = new System.Drawing.Size(110, 30);
            this.BTN_VER_REMOVE.TabIndex = 2;
            this.BTN_VER_REMOVE.TabStop = false;
            this.BTN_VER_REMOVE.Text = "REMOVE";
            this.BTN_VER_REMOVE.UseVisualStyleBackColor = true;
            this.BTN_VER_REMOVE.Click += new System.EventHandler(this.BTN_VER_REMOVE_Click);
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.panel18.Controls.Add(this.label41);
            this.panel18.Controls.Add(this.button4);
            this.panel18.Controls.Add(this.label42);
            this.panel18.Controls.Add(this.TXT_RCV_H);
            this.panel18.Controls.Add(this.label43);
            this.panel18.Controls.Add(this.TXT_PARAM_VER_NICK);
            this.panel18.Controls.Add(this.TXT_RCV_W);
            this.panel18.Location = new System.Drawing.Point(5, 5);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(115, 220);
            this.panel18.TabIndex = 12;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label41.ForeColor = System.Drawing.Color.Orange;
            this.label41.Location = new System.Drawing.Point(5, 140);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(50, 14);
            this.label41.TabIndex = 4;
            this.label41.Text = "NICK :";
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.button4.Location = new System.Drawing.Point(5, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 100);
            this.button4.TabIndex = 8;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.ForeColor = System.Drawing.Color.Orange;
            this.label42.Location = new System.Drawing.Point(5, 167);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(51, 14);
            this.label42.TabIndex = 5;
            this.label42.Text = "SZ_X :";
            // 
            // TXT_RCV_H
            // 
            this.TXT_RCV_H.BackColor = System.Drawing.Color.Black;
            this.TXT_RCV_H.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_RCV_H.ForeColor = System.Drawing.Color.LimeGreen;
            this.TXT_RCV_H.Location = new System.Drawing.Point(58, 192);
            this.TXT_RCV_H.Name = "TXT_RCV_H";
            this.TXT_RCV_H.Size = new System.Drawing.Size(54, 22);
            this.TXT_RCV_H.TabIndex = 19;
            this.TXT_RCV_H.Text = "0";
            this.TXT_RCV_H.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.ForeColor = System.Drawing.Color.Orange;
            this.label43.Location = new System.Drawing.Point(5, 194);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(52, 14);
            this.label43.TabIndex = 6;
            this.label43.Text = "SZ_Y :";
            // 
            // TXT_PARAM_VER_NICK
            // 
            this.TXT_PARAM_VER_NICK.BackColor = System.Drawing.Color.Black;
            this.TXT_PARAM_VER_NICK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_PARAM_VER_NICK.ForeColor = System.Drawing.Color.LimeGreen;
            this.TXT_PARAM_VER_NICK.Location = new System.Drawing.Point(58, 138);
            this.TXT_PARAM_VER_NICK.Name = "TXT_PARAM_VER_NICK";
            this.TXT_PARAM_VER_NICK.Size = new System.Drawing.Size(54, 22);
            this.TXT_PARAM_VER_NICK.TabIndex = 7;
            this.TXT_PARAM_VER_NICK.Text = "vert";
            this.TXT_PARAM_VER_NICK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TXT_RCV_W
            // 
            this.TXT_RCV_W.BackColor = System.Drawing.Color.Black;
            this.TXT_RCV_W.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_RCV_W.ForeColor = System.Drawing.Color.LimeGreen;
            this.TXT_RCV_W.Location = new System.Drawing.Point(58, 165);
            this.TXT_RCV_W.Name = "TXT_RCV_W";
            this.TXT_RCV_W.Size = new System.Drawing.Size(54, 22);
            this.TXT_RCV_W.TabIndex = 20;
            this.TXT_RCV_W.Text = "0";
            this.TXT_RCV_W.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LV_PAIR_VER
            // 
            this.LV_PAIR_VER.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.LV_PAIR_VER.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6});
            this.LV_PAIR_VER.ForeColor = System.Drawing.Color.LimeGreen;
            this.LV_PAIR_VER.FullRowSelect = true;
            this.LV_PAIR_VER.GridLines = true;
            this.LV_PAIR_VER.Location = new System.Drawing.Point(245, 5);
            this.LV_PAIR_VER.Name = "LV_PAIR_VER";
            this.LV_PAIR_VER.Size = new System.Drawing.Size(300, 220);
            this.LV_PAIR_VER.TabIndex = 11;
            this.LV_PAIR_VER.UseCompatibleStateImageBehavior = false;
            this.LV_PAIR_VER.View = System.Windows.Forms.View.Details;
            this.LV_PAIR_VER.SelectedIndexChanged += new System.EventHandler(this.LV_PAIR_VER_SelectedIndexChanged);
            this.LV_PAIR_VER.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LV_FIGURE_KeyDown);
            this.LV_PAIR_VER.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LV_PAIR_VER_MouseDoubleClick);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "IDX";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "FIGURE";
            this.columnHeader6.Width = 150;
            // 
            // rcPairDiagonal
            // 
            this.rcPairDiagonal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.rcPairDiagonal.Controls.Add(this.panel19);
            this.rcPairDiagonal.Controls.Add(this.panel21);
            this.rcPairDiagonal.Controls.Add(this.LV_PAIR_DIG);
            this.rcPairDiagonal.ImageKey = "measureDig.png";
            this.rcPairDiagonal.Location = new System.Drawing.Point(4, 34);
            this.rcPairDiagonal.Name = "rcPairDiagonal";
            this.rcPairDiagonal.Size = new System.Drawing.Size(551, 229);
            this.rcPairDiagonal.TabIndex = 4;
            this.rcPairDiagonal.Text = "DIG";
            // 
            // panel19
            // 
            this.panel19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.panel19.Controls.Add(this.BTN_DIG_COPY);
            this.panel19.Controls.Add(this.BTN_DIG_ADD);
            this.panel19.Controls.Add(this.BTN_DIG_MODIFY);
            this.panel19.Controls.Add(this.BTN_DIG_REMOVE);
            this.panel19.Location = new System.Drawing.Point(125, 5);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(115, 220);
            this.panel19.TabIndex = 20;
            // 
            // BTN_DIG_COPY
            // 
            this.BTN_DIG_COPY.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.BTN_DIG_COPY.FlatAppearance.BorderSize = 3;
            this.BTN_DIG_COPY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_DIG_COPY.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.BTN_DIG_COPY.Location = new System.Drawing.Point(2, 40);
            this.BTN_DIG_COPY.Name = "BTN_DIG_COPY";
            this.BTN_DIG_COPY.Size = new System.Drawing.Size(110, 30);
            this.BTN_DIG_COPY.TabIndex = 4;
            this.BTN_DIG_COPY.Text = "COPY";
            this.BTN_DIG_COPY.UseVisualStyleBackColor = true;
            this.BTN_DIG_COPY.Click += new System.EventHandler(this.BTN_DIG_COPY_Click);
            // 
            // BTN_DIG_ADD
            // 
            this.BTN_DIG_ADD.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.BTN_DIG_ADD.FlatAppearance.BorderSize = 3;
            this.BTN_DIG_ADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_DIG_ADD.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.BTN_DIG_ADD.Location = new System.Drawing.Point(2, 5);
            this.BTN_DIG_ADD.Name = "BTN_DIG_ADD";
            this.BTN_DIG_ADD.Size = new System.Drawing.Size(110, 30);
            this.BTN_DIG_ADD.TabIndex = 2;
            this.BTN_DIG_ADD.Text = "ADD";
            this.BTN_DIG_ADD.UseVisualStyleBackColor = true;
            this.BTN_DIG_ADD.Click += new System.EventHandler(this.BTN_DIG_ADD_Click);
            // 
            // BTN_DIG_MODIFY
            // 
            this.BTN_DIG_MODIFY.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.BTN_DIG_MODIFY.FlatAppearance.BorderSize = 3;
            this.BTN_DIG_MODIFY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_DIG_MODIFY.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.BTN_DIG_MODIFY.Location = new System.Drawing.Point(2, 75);
            this.BTN_DIG_MODIFY.Name = "BTN_DIG_MODIFY";
            this.BTN_DIG_MODIFY.Size = new System.Drawing.Size(110, 30);
            this.BTN_DIG_MODIFY.TabIndex = 2;
            this.BTN_DIG_MODIFY.Text = "MODIFY";
            this.BTN_DIG_MODIFY.UseVisualStyleBackColor = true;
            this.BTN_DIG_MODIFY.Click += new System.EventHandler(this.BTN_DIG_MODIFY_Click);
            // 
            // BTN_DIG_REMOVE
            // 
            this.BTN_DIG_REMOVE.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.BTN_DIG_REMOVE.FlatAppearance.BorderSize = 3;
            this.BTN_DIG_REMOVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_DIG_REMOVE.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.BTN_DIG_REMOVE.Location = new System.Drawing.Point(2, 111);
            this.BTN_DIG_REMOVE.Name = "BTN_DIG_REMOVE";
            this.BTN_DIG_REMOVE.Size = new System.Drawing.Size(110, 30);
            this.BTN_DIG_REMOVE.TabIndex = 2;
            this.BTN_DIG_REMOVE.TabStop = false;
            this.BTN_DIG_REMOVE.Text = "REMOVE";
            this.BTN_DIG_REMOVE.UseVisualStyleBackColor = true;
            this.BTN_DIG_REMOVE.Click += new System.EventHandler(this.BTN_DIG_REMOVE_Click);
            // 
            // panel21
            // 
            this.panel21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.panel21.Controls.Add(this.label44);
            this.panel21.Controls.Add(this.TXT_RCD_H);
            this.panel21.Controls.Add(this.label45);
            this.panel21.Controls.Add(this.BTN_DIG_ANGLE_DW);
            this.panel21.Controls.Add(this.label46);
            this.panel21.Controls.Add(this.TXT_RCD_W);
            this.panel21.Controls.Add(this.BTN_DIG_ANGLE_UP);
            this.panel21.Controls.Add(this.button5);
            this.panel21.Controls.Add(this.TXT_PARAM_DIG_ANGLE);
            this.panel21.Controls.Add(this.TXT_PARAM_DIG_NICK);
            this.panel21.Controls.Add(this.label67);
            this.panel21.Location = new System.Drawing.Point(5, 5);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(115, 220);
            this.panel21.TabIndex = 19;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label44.ForeColor = System.Drawing.Color.Orange;
            this.label44.Location = new System.Drawing.Point(5, 140);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(50, 14);
            this.label44.TabIndex = 7;
            this.label44.Text = "NICK :";
            // 
            // TXT_RCD_H
            // 
            this.TXT_RCD_H.BackColor = System.Drawing.Color.Black;
            this.TXT_RCD_H.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_RCD_H.ForeColor = System.Drawing.Color.LimeGreen;
            this.TXT_RCD_H.Location = new System.Drawing.Point(58, 192);
            this.TXT_RCD_H.Name = "TXT_RCD_H";
            this.TXT_RCD_H.Size = new System.Drawing.Size(54, 22);
            this.TXT_RCD_H.TabIndex = 26;
            this.TXT_RCD_H.Text = "0";
            this.TXT_RCD_H.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.ForeColor = System.Drawing.Color.Orange;
            this.label45.Location = new System.Drawing.Point(5, 167);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(51, 14);
            this.label45.TabIndex = 8;
            this.label45.Text = "SZ_X :";
            // 
            // BTN_DIG_ANGLE_DW
            // 
            this.BTN_DIG_ANGLE_DW.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BTN_DIG_ANGLE_DW.Location = new System.Drawing.Point(89, 111);
            this.BTN_DIG_ANGLE_DW.Name = "BTN_DIG_ANGLE_DW";
            this.BTN_DIG_ANGLE_DW.Size = new System.Drawing.Size(23, 23);
            this.BTN_DIG_ANGLE_DW.TabIndex = 9;
            this.BTN_DIG_ANGLE_DW.Text = "↓";
            this.BTN_DIG_ANGLE_DW.UseVisualStyleBackColor = true;
            this.BTN_DIG_ANGLE_DW.Click += new System.EventHandler(this.BTN_DIG_ANGLE_DW_Click);
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.ForeColor = System.Drawing.Color.Orange;
            this.label46.Location = new System.Drawing.Point(5, 194);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(52, 14);
            this.label46.TabIndex = 9;
            this.label46.Text = "SZ_Y :";
            // 
            // TXT_RCD_W
            // 
            this.TXT_RCD_W.BackColor = System.Drawing.Color.Black;
            this.TXT_RCD_W.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_RCD_W.ForeColor = System.Drawing.Color.LimeGreen;
            this.TXT_RCD_W.Location = new System.Drawing.Point(58, 165);
            this.TXT_RCD_W.Name = "TXT_RCD_W";
            this.TXT_RCD_W.Size = new System.Drawing.Size(54, 22);
            this.TXT_RCD_W.TabIndex = 27;
            this.TXT_RCD_W.Text = "0";
            this.TXT_RCD_W.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BTN_DIG_ANGLE_UP
            // 
            this.BTN_DIG_ANGLE_UP.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BTN_DIG_ANGLE_UP.Location = new System.Drawing.Point(68, 111);
            this.BTN_DIG_ANGLE_UP.Name = "BTN_DIG_ANGLE_UP";
            this.BTN_DIG_ANGLE_UP.Size = new System.Drawing.Size(23, 23);
            this.BTN_DIG_ANGLE_UP.TabIndex = 9;
            this.BTN_DIG_ANGLE_UP.Text = "↑";
            this.BTN_DIG_ANGLE_UP.UseVisualStyleBackColor = true;
            this.BTN_DIG_ANGLE_UP.Click += new System.EventHandler(this.BTN_DIG_ANGLE_UP_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::CD_Simulator.Properties.Resources.measureDig;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.button5.Location = new System.Drawing.Point(5, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 100);
            this.button5.TabIndex = 8;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // TXT_PARAM_DIG_ANGLE
            // 
            this.TXT_PARAM_DIG_ANGLE.BackColor = System.Drawing.Color.Black;
            this.TXT_PARAM_DIG_ANGLE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_PARAM_DIG_ANGLE.ForeColor = System.Drawing.Color.LimeGreen;
            this.TXT_PARAM_DIG_ANGLE.Location = new System.Drawing.Point(39, 112);
            this.TXT_PARAM_DIG_ANGLE.Name = "TXT_PARAM_DIG_ANGLE";
            this.TXT_PARAM_DIG_ANGLE.Size = new System.Drawing.Size(29, 22);
            this.TXT_PARAM_DIG_ANGLE.TabIndex = 8;
            this.TXT_PARAM_DIG_ANGLE.Text = "0";
            this.TXT_PARAM_DIG_ANGLE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TXT_PARAM_DIG_NICK
            // 
            this.TXT_PARAM_DIG_NICK.BackColor = System.Drawing.Color.Black;
            this.TXT_PARAM_DIG_NICK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_PARAM_DIG_NICK.ForeColor = System.Drawing.Color.LimeGreen;
            this.TXT_PARAM_DIG_NICK.Location = new System.Drawing.Point(58, 138);
            this.TXT_PARAM_DIG_NICK.Name = "TXT_PARAM_DIG_NICK";
            this.TXT_PARAM_DIG_NICK.Size = new System.Drawing.Size(54, 22);
            this.TXT_PARAM_DIG_NICK.TabIndex = 7;
            this.TXT_PARAM_DIG_NICK.Text = "dig";
            this.TXT_PARAM_DIG_NICK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.ForeColor = System.Drawing.Color.Orange;
            this.label67.Location = new System.Drawing.Point(13, 119);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(24, 14);
            this.label67.TabIndex = 0;
            this.label67.Text = "θ :";
            // 
            // LV_PAIR_DIG
            // 
            this.LV_PAIR_DIG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.LV_PAIR_DIG.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8});
            this.LV_PAIR_DIG.ForeColor = System.Drawing.Color.LimeGreen;
            this.LV_PAIR_DIG.FullRowSelect = true;
            this.LV_PAIR_DIG.GridLines = true;
            this.LV_PAIR_DIG.Location = new System.Drawing.Point(245, 5);
            this.LV_PAIR_DIG.Name = "LV_PAIR_DIG";
            this.LV_PAIR_DIG.Size = new System.Drawing.Size(303, 220);
            this.LV_PAIR_DIG.TabIndex = 18;
            this.LV_PAIR_DIG.UseCompatibleStateImageBehavior = false;
            this.LV_PAIR_DIG.View = System.Windows.Forms.View.Details;
            this.LV_PAIR_DIG.SelectedIndexChanged += new System.EventHandler(this.LV_PAIR_DIG_SelectedIndexChanged);
            this.LV_PAIR_DIG.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LV_PAIR_DIG_MouseDoubleClick);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "IDX";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "FIGURE";
            this.columnHeader8.Width = 150;
            // 
            // circle
            // 
            this.circle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.circle.Controls.Add(this.panel22);
            this.circle.Controls.Add(this.panel24);
            this.circle.Controls.Add(this.LV_PAIR_CIR);
            this.circle.ImageKey = "measureCir.png";
            this.circle.Location = new System.Drawing.Point(4, 34);
            this.circle.Name = "circle";
            this.circle.Size = new System.Drawing.Size(551, 229);
            this.circle.TabIndex = 3;
            this.circle.Text = "CIR";
            // 
            // panel22
            // 
            this.panel22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.panel22.Controls.Add(this.BTN_CIR_ADD);
            this.panel22.Controls.Add(this.BTN_CIR_COPY);
            this.panel22.Controls.Add(this.BTN_CIR_MODIFY);
            this.panel22.Controls.Add(this.BTN_CIR_REMOVE);
            this.panel22.Location = new System.Drawing.Point(125, 5);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(115, 220);
            this.panel22.TabIndex = 27;
            // 
            // BTN_CIR_ADD
            // 
            this.BTN_CIR_ADD.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.BTN_CIR_ADD.FlatAppearance.BorderSize = 3;
            this.BTN_CIR_ADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_CIR_ADD.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_CIR_ADD.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.BTN_CIR_ADD.Location = new System.Drawing.Point(2, 5);
            this.BTN_CIR_ADD.Name = "BTN_CIR_ADD";
            this.BTN_CIR_ADD.Size = new System.Drawing.Size(110, 30);
            this.BTN_CIR_ADD.TabIndex = 2;
            this.BTN_CIR_ADD.Text = "ADD";
            this.BTN_CIR_ADD.UseVisualStyleBackColor = true;
            this.BTN_CIR_ADD.Click += new System.EventHandler(this.BTN_CIR_ADD_Click);
            // 
            // BTN_CIR_COPY
            // 
            this.BTN_CIR_COPY.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.BTN_CIR_COPY.FlatAppearance.BorderSize = 3;
            this.BTN_CIR_COPY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_CIR_COPY.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_CIR_COPY.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.BTN_CIR_COPY.Location = new System.Drawing.Point(2, 40);
            this.BTN_CIR_COPY.Name = "BTN_CIR_COPY";
            this.BTN_CIR_COPY.Size = new System.Drawing.Size(110, 30);
            this.BTN_CIR_COPY.TabIndex = 2;
            this.BTN_CIR_COPY.Text = "COPY";
            this.BTN_CIR_COPY.UseVisualStyleBackColor = true;
            this.BTN_CIR_COPY.Click += new System.EventHandler(this.BTN_CIR_COPY_Click);
            // 
            // BTN_CIR_MODIFY
            // 
            this.BTN_CIR_MODIFY.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.BTN_CIR_MODIFY.FlatAppearance.BorderSize = 3;
            this.BTN_CIR_MODIFY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_CIR_MODIFY.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_CIR_MODIFY.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.BTN_CIR_MODIFY.Location = new System.Drawing.Point(2, 75);
            this.BTN_CIR_MODIFY.Name = "BTN_CIR_MODIFY";
            this.BTN_CIR_MODIFY.Size = new System.Drawing.Size(110, 30);
            this.BTN_CIR_MODIFY.TabIndex = 2;
            this.BTN_CIR_MODIFY.Text = "MODIFY";
            this.BTN_CIR_MODIFY.UseVisualStyleBackColor = true;
            this.BTN_CIR_MODIFY.Click += new System.EventHandler(this.BTN_CIR_MODIFY_Click);
            // 
            // BTN_CIR_REMOVE
            // 
            this.BTN_CIR_REMOVE.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.BTN_CIR_REMOVE.FlatAppearance.BorderSize = 3;
            this.BTN_CIR_REMOVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_CIR_REMOVE.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_CIR_REMOVE.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.BTN_CIR_REMOVE.Location = new System.Drawing.Point(2, 111);
            this.BTN_CIR_REMOVE.Name = "BTN_CIR_REMOVE";
            this.BTN_CIR_REMOVE.Size = new System.Drawing.Size(110, 30);
            this.BTN_CIR_REMOVE.TabIndex = 2;
            this.BTN_CIR_REMOVE.TabStop = false;
            this.BTN_CIR_REMOVE.Text = "REMOVE";
            this.BTN_CIR_REMOVE.UseVisualStyleBackColor = true;
            this.BTN_CIR_REMOVE.Click += new System.EventHandler(this.BTN_CIR_REMOVE_Click);
            // 
            // panel24
            // 
            this.panel24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.panel24.Controls.Add(this.label48);
            this.panel24.Controls.Add(this.label49);
            this.panel24.Controls.Add(this.label50);
            this.panel24.Controls.Add(this.TXT_CIRCLE_H);
            this.panel24.Controls.Add(this.TXT_CIRCLE_W);
            this.panel24.Controls.Add(this.button9);
            this.panel24.Controls.Add(this.TXT_PARAM_CIR_NICK);
            this.panel24.Location = new System.Drawing.Point(5, 5);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(115, 220);
            this.panel24.TabIndex = 26;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label48.ForeColor = System.Drawing.Color.Orange;
            this.label48.Location = new System.Drawing.Point(5, 140);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(50, 14);
            this.label48.TabIndex = 35;
            this.label48.Text = "NICK :";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.ForeColor = System.Drawing.Color.Orange;
            this.label49.Location = new System.Drawing.Point(5, 167);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(51, 14);
            this.label49.TabIndex = 36;
            this.label49.Text = "SZ_X :";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.ForeColor = System.Drawing.Color.Orange;
            this.label50.Location = new System.Drawing.Point(5, 194);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(52, 14);
            this.label50.TabIndex = 37;
            this.label50.Text = "SZ_Y :";
            // 
            // TXT_CIRCLE_H
            // 
            this.TXT_CIRCLE_H.BackColor = System.Drawing.Color.Black;
            this.TXT_CIRCLE_H.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_CIRCLE_H.ForeColor = System.Drawing.Color.LimeGreen;
            this.TXT_CIRCLE_H.Location = new System.Drawing.Point(58, 192);
            this.TXT_CIRCLE_H.Name = "TXT_CIRCLE_H";
            this.TXT_CIRCLE_H.Size = new System.Drawing.Size(54, 22);
            this.TXT_CIRCLE_H.TabIndex = 33;
            this.TXT_CIRCLE_H.Text = "0";
            this.TXT_CIRCLE_H.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TXT_CIRCLE_W
            // 
            this.TXT_CIRCLE_W.BackColor = System.Drawing.Color.Black;
            this.TXT_CIRCLE_W.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_CIRCLE_W.ForeColor = System.Drawing.Color.LimeGreen;
            this.TXT_CIRCLE_W.Location = new System.Drawing.Point(58, 165);
            this.TXT_CIRCLE_W.Name = "TXT_CIRCLE_W";
            this.TXT_CIRCLE_W.Size = new System.Drawing.Size(54, 22);
            this.TXT_CIRCLE_W.TabIndex = 34;
            this.TXT_CIRCLE_W.Text = "0";
            this.TXT_CIRCLE_W.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button9
            // 
            this.button9.BackgroundImage = global::CD_Simulator.Properties.Resources.measureCir;
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.button9.Location = new System.Drawing.Point(5, 5);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(100, 100);
            this.button9.TabIndex = 8;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // TXT_PARAM_CIR_NICK
            // 
            this.TXT_PARAM_CIR_NICK.BackColor = System.Drawing.Color.Black;
            this.TXT_PARAM_CIR_NICK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_PARAM_CIR_NICK.ForeColor = System.Drawing.Color.LimeGreen;
            this.TXT_PARAM_CIR_NICK.Location = new System.Drawing.Point(58, 138);
            this.TXT_PARAM_CIR_NICK.Name = "TXT_PARAM_CIR_NICK";
            this.TXT_PARAM_CIR_NICK.Size = new System.Drawing.Size(54, 22);
            this.TXT_PARAM_CIR_NICK.TabIndex = 7;
            this.TXT_PARAM_CIR_NICK.Text = "circle";
            this.TXT_PARAM_CIR_NICK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LV_PAIR_CIR
            // 
            this.LV_PAIR_CIR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.LV_PAIR_CIR.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10});
            this.LV_PAIR_CIR.ForeColor = System.Drawing.Color.LimeGreen;
            this.LV_PAIR_CIR.FullRowSelect = true;
            this.LV_PAIR_CIR.GridLines = true;
            this.LV_PAIR_CIR.Location = new System.Drawing.Point(245, 5);
            this.LV_PAIR_CIR.Name = "LV_PAIR_CIR";
            this.LV_PAIR_CIR.Size = new System.Drawing.Size(303, 220);
            this.LV_PAIR_CIR.TabIndex = 25;
            this.LV_PAIR_CIR.UseCompatibleStateImageBehavior = false;
            this.LV_PAIR_CIR.View = System.Windows.Forms.View.Details;
            this.LV_PAIR_CIR.SelectedIndexChanged += new System.EventHandler(this.LV_PAIR_CIR_SelectedIndexChanged);
            this.LV_PAIR_CIR.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LV_FIGURE_KeyDown);
            this.LV_PAIR_CIR.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LV_PAIR_CIR_MouseDoubleClick);
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "IDX";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "FIGURE";
            this.columnHeader10.Width = 150;
            // 
            // Ol
            // 
            this.Ol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Ol.Controls.Add(this.panel28);
            this.Ol.Controls.Add(this.LV_PAIR_OVL);
            this.Ol.Controls.Add(this.panel23);
            this.Ol.ImageKey = "measureOVL.png";
            this.Ol.Location = new System.Drawing.Point(4, 34);
            this.Ol.Name = "Ol";
            this.Ol.Size = new System.Drawing.Size(551, 229);
            this.Ol.TabIndex = 5;
            this.Ol.Text = "OL";
            // 
            // panel28
            // 
            this.panel28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.panel28.Controls.Add(this.label54);
            this.panel28.Controls.Add(this.label58);
            this.panel28.Controls.Add(this.label55);
            this.panel28.Controls.Add(this.label57);
            this.panel28.Controls.Add(this.label56);
            this.panel28.Controls.Add(this.TXT_OVL_EX_H);
            this.panel28.Controls.Add(this.TXT_OVL_IN_H);
            this.panel28.Controls.Add(this.TXT_OVL_EX_W);
            this.panel28.Controls.Add(this.TXT_OVL_IN_W);
            this.panel28.Controls.Add(this.button3);
            this.panel28.Controls.Add(this.TXT_PARAM_OVL_NICK);
            this.panel28.Location = new System.Drawing.Point(5, 5);
            this.panel28.Name = "panel28";
            this.panel28.Size = new System.Drawing.Size(115, 220);
            this.panel28.TabIndex = 30;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label54.ForeColor = System.Drawing.Color.Orange;
            this.label54.Location = new System.Drawing.Point(9, 114);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(50, 14);
            this.label54.TabIndex = 35;
            this.label54.Text = "NICK :";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.ForeColor = System.Drawing.Color.Orange;
            this.label58.Location = new System.Drawing.Point(3, 178);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(59, 14);
            this.label58.TabIndex = 36;
            this.label58.Text = "SZ_EX :";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.ForeColor = System.Drawing.Color.Orange;
            this.label55.Location = new System.Drawing.Point(3, 135);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(57, 14);
            this.label55.TabIndex = 36;
            this.label55.Text = "SZ_IX :";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.ForeColor = System.Drawing.Color.Orange;
            this.label57.Location = new System.Drawing.Point(3, 200);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(60, 14);
            this.label57.TabIndex = 37;
            this.label57.Text = "SZ_EY :";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.ForeColor = System.Drawing.Color.Orange;
            this.label56.Location = new System.Drawing.Point(3, 157);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(58, 14);
            this.label56.TabIndex = 37;
            this.label56.Text = "SZ_IY :";
            // 
            // TXT_OVL_EX_H
            // 
            this.TXT_OVL_EX_H.BackColor = System.Drawing.Color.Black;
            this.TXT_OVL_EX_H.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_OVL_EX_H.ForeColor = System.Drawing.Color.LimeGreen;
            this.TXT_OVL_EX_H.Location = new System.Drawing.Point(63, 195);
            this.TXT_OVL_EX_H.Name = "TXT_OVL_EX_H";
            this.TXT_OVL_EX_H.Size = new System.Drawing.Size(50, 22);
            this.TXT_OVL_EX_H.TabIndex = 33;
            this.TXT_OVL_EX_H.Text = "0";
            this.TXT_OVL_EX_H.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TXT_OVL_IN_H
            // 
            this.TXT_OVL_IN_H.BackColor = System.Drawing.Color.Black;
            this.TXT_OVL_IN_H.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_OVL_IN_H.ForeColor = System.Drawing.Color.LimeGreen;
            this.TXT_OVL_IN_H.Location = new System.Drawing.Point(63, 153);
            this.TXT_OVL_IN_H.Name = "TXT_OVL_IN_H";
            this.TXT_OVL_IN_H.Size = new System.Drawing.Size(50, 22);
            this.TXT_OVL_IN_H.TabIndex = 33;
            this.TXT_OVL_IN_H.Text = "0";
            this.TXT_OVL_IN_H.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TXT_OVL_EX_W
            // 
            this.TXT_OVL_EX_W.BackColor = System.Drawing.Color.Black;
            this.TXT_OVL_EX_W.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_OVL_EX_W.ForeColor = System.Drawing.Color.LimeGreen;
            this.TXT_OVL_EX_W.Location = new System.Drawing.Point(63, 174);
            this.TXT_OVL_EX_W.Name = "TXT_OVL_EX_W";
            this.TXT_OVL_EX_W.Size = new System.Drawing.Size(50, 22);
            this.TXT_OVL_EX_W.TabIndex = 34;
            this.TXT_OVL_EX_W.Text = "0";
            this.TXT_OVL_EX_W.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TXT_OVL_IN_W
            // 
            this.TXT_OVL_IN_W.BackColor = System.Drawing.Color.Black;
            this.TXT_OVL_IN_W.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_OVL_IN_W.ForeColor = System.Drawing.Color.LimeGreen;
            this.TXT_OVL_IN_W.Location = new System.Drawing.Point(63, 132);
            this.TXT_OVL_IN_W.Name = "TXT_OVL_IN_W";
            this.TXT_OVL_IN_W.Size = new System.Drawing.Size(50, 22);
            this.TXT_OVL_IN_W.TabIndex = 34;
            this.TXT_OVL_IN_W.Text = "0";
            this.TXT_OVL_IN_W.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::CD_Simulator.Properties.Resources.measureOVL;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.button3.Location = new System.Drawing.Point(5, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 100);
            this.button3.TabIndex = 8;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // TXT_PARAM_OVL_NICK
            // 
            this.TXT_PARAM_OVL_NICK.BackColor = System.Drawing.Color.Black;
            this.TXT_PARAM_OVL_NICK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_PARAM_OVL_NICK.ForeColor = System.Drawing.Color.LimeGreen;
            this.TXT_PARAM_OVL_NICK.Location = new System.Drawing.Point(63, 111);
            this.TXT_PARAM_OVL_NICK.Name = "TXT_PARAM_OVL_NICK";
            this.TXT_PARAM_OVL_NICK.Size = new System.Drawing.Size(50, 22);
            this.TXT_PARAM_OVL_NICK.TabIndex = 7;
            this.TXT_PARAM_OVL_NICK.Text = "OVL";
            this.TXT_PARAM_OVL_NICK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LV_PAIR_OVL
            // 
            this.LV_PAIR_OVL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.LV_PAIR_OVL.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11,
            this.columnHeader12});
            this.LV_PAIR_OVL.ForeColor = System.Drawing.Color.LimeGreen;
            this.LV_PAIR_OVL.FullRowSelect = true;
            this.LV_PAIR_OVL.GridLines = true;
            this.LV_PAIR_OVL.Location = new System.Drawing.Point(245, 5);
            this.LV_PAIR_OVL.Name = "LV_PAIR_OVL";
            this.LV_PAIR_OVL.Size = new System.Drawing.Size(303, 220);
            this.LV_PAIR_OVL.TabIndex = 29;
            this.LV_PAIR_OVL.UseCompatibleStateImageBehavior = false;
            this.LV_PAIR_OVL.View = System.Windows.Forms.View.Details;
            this.LV_PAIR_OVL.SelectedIndexChanged += new System.EventHandler(this.LV_PAIR_OL_SelectedIndexChanged);
            this.LV_PAIR_OVL.DoubleClick += new System.EventHandler(this.LV_PAIR_OL_DoubleClick);
            this.LV_PAIR_OVL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LV_FIGURE_KeyDown);
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "IDX";
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "FIGURE";
            this.columnHeader12.Width = 150;
            // 
            // panel23
            // 
            this.panel23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.panel23.Controls.Add(this.RDO_ROI_OVL_EX);
            this.panel23.Controls.Add(this.RDO_ROI_OVL_ENTIRE);
            this.panel23.Controls.Add(this.RDO_ROI_OVL_IN);
            this.panel23.Controls.Add(this.BTN_OL_ADD);
            this.panel23.Controls.Add(this.BTN_OL_COPY);
            this.panel23.Controls.Add(this.BTN_OL_REMOVE);
            this.panel23.Location = new System.Drawing.Point(125, 5);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(115, 220);
            this.panel23.TabIndex = 28;
            // 
            // RDO_ROI_OVL_EX
            // 
            this.RDO_ROI_OVL_EX.AutoSize = true;
            this.RDO_ROI_OVL_EX.ForeColor = System.Drawing.Color.Orange;
            this.RDO_ROI_OVL_EX.Location = new System.Drawing.Point(10, 197);
            this.RDO_ROI_OVL_EX.Name = "RDO_ROI_OVL_EX";
            this.RDO_ROI_OVL_EX.Size = new System.Drawing.Size(94, 18);
            this.RDO_ROI_OVL_EX.TabIndex = 2;
            this.RDO_ROI_OVL_EX.Text = "EXTERNAL";
            this.RDO_ROI_OVL_EX.UseVisualStyleBackColor = true;
            this.RDO_ROI_OVL_EX.CheckedChanged += new System.EventHandler(this.RDO_ROI_OVL_CheckedChanged);
            // 
            // RDO_ROI_OVL_ENTIRE
            // 
            this.RDO_ROI_OVL_ENTIRE.AutoSize = true;
            this.RDO_ROI_OVL_ENTIRE.Checked = true;
            this.RDO_ROI_OVL_ENTIRE.ForeColor = System.Drawing.Color.Orange;
            this.RDO_ROI_OVL_ENTIRE.Location = new System.Drawing.Point(10, 151);
            this.RDO_ROI_OVL_ENTIRE.Name = "RDO_ROI_OVL_ENTIRE";
            this.RDO_ROI_OVL_ENTIRE.Size = new System.Drawing.Size(74, 18);
            this.RDO_ROI_OVL_ENTIRE.TabIndex = 2;
            this.RDO_ROI_OVL_ENTIRE.TabStop = true;
            this.RDO_ROI_OVL_ENTIRE.Text = "ENTIRE";
            this.RDO_ROI_OVL_ENTIRE.UseVisualStyleBackColor = true;
            this.RDO_ROI_OVL_ENTIRE.CheckedChanged += new System.EventHandler(this.RDO_ROI_OVL_CheckedChanged);
            // 
            // RDO_ROI_OVL_IN
            // 
            this.RDO_ROI_OVL_IN.AutoSize = true;
            this.RDO_ROI_OVL_IN.ForeColor = System.Drawing.Color.Orange;
            this.RDO_ROI_OVL_IN.Location = new System.Drawing.Point(10, 173);
            this.RDO_ROI_OVL_IN.Name = "RDO_ROI_OVL_IN";
            this.RDO_ROI_OVL_IN.Size = new System.Drawing.Size(93, 18);
            this.RDO_ROI_OVL_IN.TabIndex = 2;
            this.RDO_ROI_OVL_IN.Text = "INTERNAL";
            this.RDO_ROI_OVL_IN.UseVisualStyleBackColor = true;
            this.RDO_ROI_OVL_IN.CheckedChanged += new System.EventHandler(this.RDO_ROI_OVL_CheckedChanged);
            // 
            // BTN_OL_ADD
            // 
            this.BTN_OL_ADD.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.BTN_OL_ADD.FlatAppearance.BorderSize = 3;
            this.BTN_OL_ADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_OL_ADD.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_OL_ADD.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.BTN_OL_ADD.Location = new System.Drawing.Point(2, 5);
            this.BTN_OL_ADD.Name = "BTN_OL_ADD";
            this.BTN_OL_ADD.Size = new System.Drawing.Size(110, 30);
            this.BTN_OL_ADD.TabIndex = 2;
            this.BTN_OL_ADD.TabStop = false;
            this.BTN_OL_ADD.Text = "ADD";
            this.BTN_OL_ADD.UseVisualStyleBackColor = true;
            this.BTN_OL_ADD.Click += new System.EventHandler(this.BTN_OL_ADD_Click);
            // 
            // BTN_OL_COPY
            // 
            this.BTN_OL_COPY.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.BTN_OL_COPY.FlatAppearance.BorderSize = 3;
            this.BTN_OL_COPY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_OL_COPY.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_OL_COPY.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.BTN_OL_COPY.Location = new System.Drawing.Point(2, 40);
            this.BTN_OL_COPY.Name = "BTN_OL_COPY";
            this.BTN_OL_COPY.Size = new System.Drawing.Size(110, 30);
            this.BTN_OL_COPY.TabIndex = 2;
            this.BTN_OL_COPY.TabStop = false;
            this.BTN_OL_COPY.Text = "COPY";
            this.BTN_OL_COPY.UseVisualStyleBackColor = true;
            this.BTN_OL_COPY.Click += new System.EventHandler(this.BTN_OL_COPY_Click);
            // 
            // BTN_OL_REMOVE
            // 
            this.BTN_OL_REMOVE.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.BTN_OL_REMOVE.FlatAppearance.BorderSize = 3;
            this.BTN_OL_REMOVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_OL_REMOVE.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_OL_REMOVE.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.BTN_OL_REMOVE.Location = new System.Drawing.Point(2, 76);
            this.BTN_OL_REMOVE.Name = "BTN_OL_REMOVE";
            this.BTN_OL_REMOVE.Size = new System.Drawing.Size(110, 30);
            this.BTN_OL_REMOVE.TabIndex = 2;
            this.BTN_OL_REMOVE.TabStop = false;
            this.BTN_OL_REMOVE.Text = "REMOVE";
            this.BTN_OL_REMOVE.UseVisualStyleBackColor = true;
            this.BTN_OL_REMOVE.Click += new System.EventHandler(this.BTN_OL_REMOVE_Click);
            // 
            // ptrn
            // 
            this.ptrn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ptrn.Controls.Add(this.panel17);
            this.ptrn.Controls.Add(this.panel13);
            this.ptrn.Controls.Add(this.PIC_PTRN);
            this.ptrn.Controls.Add(this.LV_PTRN);
            this.ptrn.ImageKey = "measureRec.png";
            this.ptrn.Location = new System.Drawing.Point(4, 34);
            this.ptrn.Name = "ptrn";
            this.ptrn.Size = new System.Drawing.Size(551, 229);
            this.ptrn.TabIndex = 2;
            this.ptrn.Text = "PTRN";
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.panel17.Controls.Add(this.BTN_ROI_REMOVE_ALL);
            this.panel17.Controls.Add(this.BTN_SAVE_REGION);
            this.panel17.Controls.Add(this.BTN_ROI_ADD);
            this.panel17.Controls.Add(this.BTN_TEACH_PTRN);
            this.panel17.Location = new System.Drawing.Point(124, 5);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(115, 220);
            this.panel17.TabIndex = 30;
            // 
            // BTN_ROI_REMOVE_ALL
            // 
            this.BTN_ROI_REMOVE_ALL.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.BTN_ROI_REMOVE_ALL.FlatAppearance.BorderSize = 3;
            this.BTN_ROI_REMOVE_ALL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_ROI_REMOVE_ALL.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.BTN_ROI_REMOVE_ALL.Location = new System.Drawing.Point(2, 39);
            this.BTN_ROI_REMOVE_ALL.Name = "BTN_ROI_REMOVE_ALL";
            this.BTN_ROI_REMOVE_ALL.Size = new System.Drawing.Size(110, 30);
            this.BTN_ROI_REMOVE_ALL.TabIndex = 1;
            this.BTN_ROI_REMOVE_ALL.Text = "REMOVE";
            this.BTN_ROI_REMOVE_ALL.UseVisualStyleBackColor = true;
            this.BTN_ROI_REMOVE_ALL.Click += new System.EventHandler(this.BTN_ROI_REMOVE_ALL_Click);
            // 
            // BTN_SAVE_REGION
            // 
            this.BTN_SAVE_REGION.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.BTN_SAVE_REGION.FlatAppearance.BorderSize = 3;
            this.BTN_SAVE_REGION.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_SAVE_REGION.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.BTN_SAVE_REGION.Location = new System.Drawing.Point(3, 185);
            this.BTN_SAVE_REGION.Name = "BTN_SAVE_REGION";
            this.BTN_SAVE_REGION.Size = new System.Drawing.Size(110, 30);
            this.BTN_SAVE_REGION.TabIndex = 1;
            this.BTN_SAVE_REGION.Text = "To IMG";
            this.BTN_SAVE_REGION.UseVisualStyleBackColor = true;
            this.BTN_SAVE_REGION.Click += new System.EventHandler(this.BTN_SAVE_REGION_Click);
            // 
            // BTN_ROI_ADD
            // 
            this.BTN_ROI_ADD.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.BTN_ROI_ADD.FlatAppearance.BorderSize = 3;
            this.BTN_ROI_ADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_ROI_ADD.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.BTN_ROI_ADD.Location = new System.Drawing.Point(2, 5);
            this.BTN_ROI_ADD.Name = "BTN_ROI_ADD";
            this.BTN_ROI_ADD.Size = new System.Drawing.Size(110, 30);
            this.BTN_ROI_ADD.TabIndex = 1;
            this.BTN_ROI_ADD.Text = "DRAW";
            this.BTN_ROI_ADD.UseVisualStyleBackColor = true;
            this.BTN_ROI_ADD.Click += new System.EventHandler(this.BTN_ROI_ADD_Click);
            // 
            // BTN_TEACH_PTRN
            // 
            this.BTN_TEACH_PTRN.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.BTN_TEACH_PTRN.FlatAppearance.BorderSize = 3;
            this.BTN_TEACH_PTRN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_TEACH_PTRN.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.BTN_TEACH_PTRN.Location = new System.Drawing.Point(2, 72);
            this.BTN_TEACH_PTRN.Name = "BTN_TEACH_PTRN";
            this.BTN_TEACH_PTRN.Size = new System.Drawing.Size(110, 30);
            this.BTN_TEACH_PTRN.TabIndex = 1;
            this.BTN_TEACH_PTRN.Text = "TEACH";
            this.BTN_TEACH_PTRN.UseVisualStyleBackColor = true;
            this.BTN_TEACH_PTRN.Click += new System.EventHandler(this.BTN_TEACH_PTRN_Click);
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.panel13.Controls.Add(this.button2);
            this.panel13.Location = new System.Drawing.Point(5, 5);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(115, 220);
            this.panel13.TabIndex = 29;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::CD_Simulator.Properties.Resources.measureRec1;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.button2.Location = new System.Drawing.Point(5, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 100);
            this.button2.TabIndex = 9;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // PIC_PTRN
            // 
            this.PIC_PTRN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.PIC_PTRN.Location = new System.Drawing.Point(278, 5);
            this.PIC_PTRN.Name = "PIC_PTRN";
            this.PIC_PTRN.Size = new System.Drawing.Size(174, 112);
            this.PIC_PTRN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PIC_PTRN.TabIndex = 28;
            this.PIC_PTRN.TabStop = false;
            // 
            // LV_PTRN
            // 
            this.LV_PTRN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.LV_PTRN.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDX,
            this.FIELS});
            this.LV_PTRN.ForeColor = System.Drawing.Color.LimeGreen;
            this.LV_PTRN.FullRowSelect = true;
            this.LV_PTRN.GridLines = true;
            this.LV_PTRN.Location = new System.Drawing.Point(242, 123);
            this.LV_PTRN.Name = "LV_PTRN";
            this.LV_PTRN.Size = new System.Drawing.Size(306, 102);
            this.LV_PTRN.TabIndex = 27;
            this.LV_PTRN.UseCompatibleStateImageBehavior = false;
            this.LV_PTRN.View = System.Windows.Forms.View.Details;
            this.LV_PTRN.SelectedIndexChanged += new System.EventHandler(this.LV_RECTANGLE_SelectedIndexChanged);
            this.LV_PTRN.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LV_PTRN_MouseDoubleClick);
            // 
            // IDX
            // 
            this.IDX.Text = "IDX";
            this.IDX.Width = 40;
            // 
            // FIELS
            // 
            this.FIELS.Text = "FILES";
            this.FIELS.Width = 200;
            // 
            // panel25
            // 
            this.panel25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.panel25.Controls.Add(this.panel26);
            this.panel25.Controls.Add(this.panel29);
            this.panel25.Controls.Add(this.panel30);
            this.panel25.Controls.Add(this.panel31);
            this.panel25.Controls.Add(this.panel32);
            this.panel25.Location = new System.Drawing.Point(14, 283);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(559, 362);
            this.panel25.TabIndex = 17;
            // 
            // panel26
            // 
            this.panel26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.panel26.Controls.Add(this.panel27);
            this.panel26.Location = new System.Drawing.Point(3, 255);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(402, 100);
            this.panel26.TabIndex = 8;
            // 
            // panel27
            // 
            this.panel27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.panel27.Controls.Add(this.RDO_ROI_ASYM);
            this.panel27.Controls.Add(this.RDO_ROI_SIZE);
            this.panel27.Controls.Add(this.TXT_FIGURE_CONTROL_SCALE);
            this.panel27.Controls.Add(this.TB_FIGURE_CTRL_SCALE);
            this.panel27.Controls.Add(this.RDO_ROI_POSITION);
            this.panel27.Controls.Add(this.RDO_ROI_GAP);
            this.panel27.Controls.Add(this.label47);
            this.panel27.Controls.Add(this.label87);
            this.panel27.Location = new System.Drawing.Point(3, 5);
            this.panel27.Name = "panel27";
            this.panel27.Size = new System.Drawing.Size(396, 92);
            this.panel27.TabIndex = 12;
            // 
            // RDO_ROI_ASYM
            // 
            this.RDO_ROI_ASYM.AutoSize = true;
            this.RDO_ROI_ASYM.ForeColor = System.Drawing.Color.Orange;
            this.RDO_ROI_ASYM.Location = new System.Drawing.Point(232, 58);
            this.RDO_ROI_ASYM.Name = "RDO_ROI_ASYM";
            this.RDO_ROI_ASYM.Size = new System.Drawing.Size(69, 18);
            this.RDO_ROI_ASYM.TabIndex = 2;
            this.RDO_ROI_ASYM.Text = "ZigZag";
            this.RDO_ROI_ASYM.UseVisualStyleBackColor = true;
            this.RDO_ROI_ASYM.Visible = false;
            this.RDO_ROI_ASYM.CheckedChanged += new System.EventHandler(this.RDO_ROI_OVL_CheckedChanged);
            // 
            // RDO_ROI_SIZE
            // 
            this.RDO_ROI_SIZE.AutoSize = true;
            this.RDO_ROI_SIZE.ForeColor = System.Drawing.Color.Orange;
            this.RDO_ROI_SIZE.Location = new System.Drawing.Point(170, 58);
            this.RDO_ROI_SIZE.Name = "RDO_ROI_SIZE";
            this.RDO_ROI_SIZE.Size = new System.Drawing.Size(56, 18);
            this.RDO_ROI_SIZE.TabIndex = 2;
            this.RDO_ROI_SIZE.Text = "SIZE";
            this.RDO_ROI_SIZE.UseVisualStyleBackColor = true;
            this.RDO_ROI_SIZE.CheckedChanged += new System.EventHandler(this.RDO_FIGURE_ROI_CheckedChanged);
            // 
            // TXT_FIGURE_CONTROL_SCALE
            // 
            this.TXT_FIGURE_CONTROL_SCALE.BackColor = System.Drawing.Color.Black;
            this.TXT_FIGURE_CONTROL_SCALE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_FIGURE_CONTROL_SCALE.ForeColor = System.Drawing.Color.LimeGreen;
            this.TXT_FIGURE_CONTROL_SCALE.Location = new System.Drawing.Point(363, 24);
            this.TXT_FIGURE_CONTROL_SCALE.Name = "TXT_FIGURE_CONTROL_SCALE";
            this.TXT_FIGURE_CONTROL_SCALE.Size = new System.Drawing.Size(29, 22);
            this.TXT_FIGURE_CONTROL_SCALE.TabIndex = 7;
            this.TXT_FIGURE_CONTROL_SCALE.Text = "10";
            this.TXT_FIGURE_CONTROL_SCALE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TB_FIGURE_CTRL_SCALE
            // 
            this.TB_FIGURE_CTRL_SCALE.Location = new System.Drawing.Point(4, 4);
            this.TB_FIGURE_CTRL_SCALE.Maximum = 50;
            this.TB_FIGURE_CTRL_SCALE.Minimum = 1;
            this.TB_FIGURE_CTRL_SCALE.Name = "TB_FIGURE_CTRL_SCALE";
            this.TB_FIGURE_CTRL_SCALE.Size = new System.Drawing.Size(353, 45);
            this.TB_FIGURE_CTRL_SCALE.SmallChange = 5;
            this.TB_FIGURE_CTRL_SCALE.TabIndex = 3;
            this.TB_FIGURE_CTRL_SCALE.TickFrequency = 5;
            this.TB_FIGURE_CTRL_SCALE.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.TB_FIGURE_CTRL_SCALE.Value = 10;
            this.TB_FIGURE_CTRL_SCALE.Scroll += new System.EventHandler(this.TB_FIGURE_CTRL_SCALE_Scroll);
            // 
            // RDO_ROI_POSITION
            // 
            this.RDO_ROI_POSITION.AutoSize = true;
            this.RDO_ROI_POSITION.Checked = true;
            this.RDO_ROI_POSITION.ForeColor = System.Drawing.Color.Orange;
            this.RDO_ROI_POSITION.Location = new System.Drawing.Point(57, 57);
            this.RDO_ROI_POSITION.Name = "RDO_ROI_POSITION";
            this.RDO_ROI_POSITION.Size = new System.Drawing.Size(54, 18);
            this.RDO_ROI_POSITION.TabIndex = 2;
            this.RDO_ROI_POSITION.TabStop = true;
            this.RDO_ROI_POSITION.Text = "POS";
            this.RDO_ROI_POSITION.UseVisualStyleBackColor = true;
            this.RDO_ROI_POSITION.CheckedChanged += new System.EventHandler(this.RDO_FIGURE_ROI_CheckedChanged);
            // 
            // RDO_ROI_GAP
            // 
            this.RDO_ROI_GAP.AutoSize = true;
            this.RDO_ROI_GAP.ForeColor = System.Drawing.Color.Orange;
            this.RDO_ROI_GAP.Location = new System.Drawing.Point(116, 58);
            this.RDO_ROI_GAP.Name = "RDO_ROI_GAP";
            this.RDO_ROI_GAP.Size = new System.Drawing.Size(53, 18);
            this.RDO_ROI_GAP.TabIndex = 2;
            this.RDO_ROI_GAP.Text = "GAP";
            this.RDO_ROI_GAP.UseVisualStyleBackColor = true;
            this.RDO_ROI_GAP.CheckedChanged += new System.EventHandler(this.RDO_FIGURE_ROI_CheckedChanged);
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label47.Location = new System.Drawing.Point(10, 58);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(42, 14);
            this.label47.TabIndex = 0;
            this.label47.Text = "ACT :";
            // 
            // label87
            // 
            this.label87.AutoSize = true;
            this.label87.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label87.Location = new System.Drawing.Point(356, 6);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(41, 14);
            this.label87.TabIndex = 0;
            this.label87.Text = "UNIT";
            // 
            // panel29
            // 
            this.panel29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.panel29.Controls.Add(this.groupBox3);
            this.panel29.Controls.Add(this.groupBox2);
            this.panel29.Location = new System.Drawing.Point(475, 3);
            this.panel29.Name = "panel29";
            this.panel29.Size = new System.Drawing.Size(80, 248);
            this.panel29.TabIndex = 21;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.groupBox3.Controls.Add(this.RDO_GRAPH_FST_TYPE_REAL);
            this.groupBox3.Controls.Add(this.RDO_GRAPH_FST_TYPE_HISTOGRAM);
            this.groupBox3.Controls.Add(this.RDO_GRAPH_FST_TYPE_PROJECTION_V);
            this.groupBox3.Controls.Add(this.RDO_GRAPH_FST_TYPE_PROJECTION_H);
            this.groupBox3.Controls.Add(this.CHK_GRAPH_MASTER_DRAW_BAR);
            this.groupBox3.Location = new System.Drawing.Point(5, -3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(70, 125);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            // 
            // RDO_GRAPH_FST_TYPE_REAL
            // 
            this.RDO_GRAPH_FST_TYPE_REAL.AutoSize = true;
            this.RDO_GRAPH_FST_TYPE_REAL.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold);
            this.RDO_GRAPH_FST_TYPE_REAL.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.RDO_GRAPH_FST_TYPE_REAL.Location = new System.Drawing.Point(7, 80);
            this.RDO_GRAPH_FST_TYPE_REAL.Name = "RDO_GRAPH_FST_TYPE_REAL";
            this.RDO_GRAPH_FST_TYPE_REAL.Size = new System.Drawing.Size(53, 16);
            this.RDO_GRAPH_FST_TYPE_REAL.TabIndex = 17;
            this.RDO_GRAPH_FST_TYPE_REAL.Text = "REAL";
            this.RDO_GRAPH_FST_TYPE_REAL.UseVisualStyleBackColor = true;
            this.RDO_GRAPH_FST_TYPE_REAL.CheckedChanged += new System.EventHandler(this.RDO_GRAPH_FST_TYPE_REAL_CheckedChanged);
            // 
            // RDO_GRAPH_FST_TYPE_HISTOGRAM
            // 
            this.RDO_GRAPH_FST_TYPE_HISTOGRAM.AutoSize = true;
            this.RDO_GRAPH_FST_TYPE_HISTOGRAM.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold);
            this.RDO_GRAPH_FST_TYPE_HISTOGRAM.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.RDO_GRAPH_FST_TYPE_HISTOGRAM.Location = new System.Drawing.Point(8, 58);
            this.RDO_GRAPH_FST_TYPE_HISTOGRAM.Name = "RDO_GRAPH_FST_TYPE_HISTOGRAM";
            this.RDO_GRAPH_FST_TYPE_HISTOGRAM.Size = new System.Drawing.Size(59, 16);
            this.RDO_GRAPH_FST_TYPE_HISTOGRAM.TabIndex = 17;
            this.RDO_GRAPH_FST_TYPE_HISTOGRAM.Text = "HISTO";
            this.RDO_GRAPH_FST_TYPE_HISTOGRAM.UseVisualStyleBackColor = true;
            this.RDO_GRAPH_FST_TYPE_HISTOGRAM.CheckedChanged += new System.EventHandler(this.RDO_GRAPH_FST_TYPE_HISTOGRAM_CheckedChanged);
            // 
            // RDO_GRAPH_FST_TYPE_PROJECTION_V
            // 
            this.RDO_GRAPH_FST_TYPE_PROJECTION_V.AutoSize = true;
            this.RDO_GRAPH_FST_TYPE_PROJECTION_V.Checked = true;
            this.RDO_GRAPH_FST_TYPE_PROJECTION_V.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold);
            this.RDO_GRAPH_FST_TYPE_PROJECTION_V.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.RDO_GRAPH_FST_TYPE_PROJECTION_V.Location = new System.Drawing.Point(8, 36);
            this.RDO_GRAPH_FST_TYPE_PROJECTION_V.Name = "RDO_GRAPH_FST_TYPE_PROJECTION_V";
            this.RDO_GRAPH_FST_TYPE_PROJECTION_V.Size = new System.Drawing.Size(31, 16);
            this.RDO_GRAPH_FST_TYPE_PROJECTION_V.TabIndex = 17;
            this.RDO_GRAPH_FST_TYPE_PROJECTION_V.TabStop = true;
            this.RDO_GRAPH_FST_TYPE_PROJECTION_V.Text = "V";
            this.RDO_GRAPH_FST_TYPE_PROJECTION_V.UseVisualStyleBackColor = true;
            this.RDO_GRAPH_FST_TYPE_PROJECTION_V.CheckedChanged += new System.EventHandler(this.RDO_GRAPH_FST_TYPE_PROJECTION_V_CheckedChanged);
            // 
            // RDO_GRAPH_FST_TYPE_PROJECTION_H
            // 
            this.RDO_GRAPH_FST_TYPE_PROJECTION_H.AutoSize = true;
            this.RDO_GRAPH_FST_TYPE_PROJECTION_H.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold);
            this.RDO_GRAPH_FST_TYPE_PROJECTION_H.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.RDO_GRAPH_FST_TYPE_PROJECTION_H.Location = new System.Drawing.Point(8, 14);
            this.RDO_GRAPH_FST_TYPE_PROJECTION_H.Name = "RDO_GRAPH_FST_TYPE_PROJECTION_H";
            this.RDO_GRAPH_FST_TYPE_PROJECTION_H.Size = new System.Drawing.Size(31, 16);
            this.RDO_GRAPH_FST_TYPE_PROJECTION_H.TabIndex = 17;
            this.RDO_GRAPH_FST_TYPE_PROJECTION_H.Text = "H";
            this.RDO_GRAPH_FST_TYPE_PROJECTION_H.UseVisualStyleBackColor = true;
            this.RDO_GRAPH_FST_TYPE_PROJECTION_H.CheckedChanged += new System.EventHandler(this.RDO_GRAPH_FST_TYPE_PROJECTION_H_CheckedChanged);
            // 
            // CHK_GRAPH_MASTER_DRAW_BAR
            // 
            this.CHK_GRAPH_MASTER_DRAW_BAR.AutoSize = true;
            this.CHK_GRAPH_MASTER_DRAW_BAR.Checked = true;
            this.CHK_GRAPH_MASTER_DRAW_BAR.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CHK_GRAPH_MASTER_DRAW_BAR.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold);
            this.CHK_GRAPH_MASTER_DRAW_BAR.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.CHK_GRAPH_MASTER_DRAW_BAR.Location = new System.Drawing.Point(6, 102);
            this.CHK_GRAPH_MASTER_DRAW_BAR.Name = "CHK_GRAPH_MASTER_DRAW_BAR";
            this.CHK_GRAPH_MASTER_DRAW_BAR.Size = new System.Drawing.Size(49, 16);
            this.CHK_GRAPH_MASTER_DRAW_BAR.TabIndex = 18;
            this.CHK_GRAPH_MASTER_DRAW_BAR.Text = "BAR";
            this.CHK_GRAPH_MASTER_DRAW_BAR.UseVisualStyleBackColor = true;
            this.CHK_GRAPH_MASTER_DRAW_BAR.CheckedChanged += new System.EventHandler(this.CHK_GRAPH_MASTER_DRAW_BAR_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.groupBox2.Controls.Add(this.RDO_GRAPH_SCD_TYPE_PROJECTION_V);
            this.groupBox2.Controls.Add(this.RDO_GRAPH_SCD_TYPE_PROJECTION_H);
            this.groupBox2.Controls.Add(this.CHK_GRAPH_SLAVE_DRAW_BAR);
            this.groupBox2.Controls.Add(this.RDO_GRAPH_SCD_TYPE_REAL);
            this.groupBox2.Controls.Add(this.RDO_GRAPH_SCD_TYPE_HISTOGRAM);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(3, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(72, 125);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            // 
            // RDO_GRAPH_SCD_TYPE_PROJECTION_V
            // 
            this.RDO_GRAPH_SCD_TYPE_PROJECTION_V.AutoSize = true;
            this.RDO_GRAPH_SCD_TYPE_PROJECTION_V.Checked = true;
            this.RDO_GRAPH_SCD_TYPE_PROJECTION_V.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.RDO_GRAPH_SCD_TYPE_PROJECTION_V.Location = new System.Drawing.Point(8, 34);
            this.RDO_GRAPH_SCD_TYPE_PROJECTION_V.Name = "RDO_GRAPH_SCD_TYPE_PROJECTION_V";
            this.RDO_GRAPH_SCD_TYPE_PROJECTION_V.Size = new System.Drawing.Size(31, 16);
            this.RDO_GRAPH_SCD_TYPE_PROJECTION_V.TabIndex = 19;
            this.RDO_GRAPH_SCD_TYPE_PROJECTION_V.TabStop = true;
            this.RDO_GRAPH_SCD_TYPE_PROJECTION_V.Text = "V";
            this.RDO_GRAPH_SCD_TYPE_PROJECTION_V.UseVisualStyleBackColor = true;
            this.RDO_GRAPH_SCD_TYPE_PROJECTION_V.CheckedChanged += new System.EventHandler(this.RDO_GRAPH_SCD_TYPE_PROJECTION_V_CheckedChanged);
            // 
            // RDO_GRAPH_SCD_TYPE_PROJECTION_H
            // 
            this.RDO_GRAPH_SCD_TYPE_PROJECTION_H.AutoSize = true;
            this.RDO_GRAPH_SCD_TYPE_PROJECTION_H.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.RDO_GRAPH_SCD_TYPE_PROJECTION_H.Location = new System.Drawing.Point(8, 12);
            this.RDO_GRAPH_SCD_TYPE_PROJECTION_H.Name = "RDO_GRAPH_SCD_TYPE_PROJECTION_H";
            this.RDO_GRAPH_SCD_TYPE_PROJECTION_H.Size = new System.Drawing.Size(31, 16);
            this.RDO_GRAPH_SCD_TYPE_PROJECTION_H.TabIndex = 19;
            this.RDO_GRAPH_SCD_TYPE_PROJECTION_H.Text = "H";
            this.RDO_GRAPH_SCD_TYPE_PROJECTION_H.UseVisualStyleBackColor = true;
            this.RDO_GRAPH_SCD_TYPE_PROJECTION_H.CheckedChanged += new System.EventHandler(this.RDO_GRAPH_SCD_TYPE_PROJECTION_H_CheckedChanged);
            // 
            // CHK_GRAPH_SLAVE_DRAW_BAR
            // 
            this.CHK_GRAPH_SLAVE_DRAW_BAR.AutoSize = true;
            this.CHK_GRAPH_SLAVE_DRAW_BAR.Checked = true;
            this.CHK_GRAPH_SLAVE_DRAW_BAR.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CHK_GRAPH_SLAVE_DRAW_BAR.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.CHK_GRAPH_SLAVE_DRAW_BAR.Location = new System.Drawing.Point(8, 100);
            this.CHK_GRAPH_SLAVE_DRAW_BAR.Name = "CHK_GRAPH_SLAVE_DRAW_BAR";
            this.CHK_GRAPH_SLAVE_DRAW_BAR.Size = new System.Drawing.Size(49, 16);
            this.CHK_GRAPH_SLAVE_DRAW_BAR.TabIndex = 18;
            this.CHK_GRAPH_SLAVE_DRAW_BAR.Text = "BAR";
            this.CHK_GRAPH_SLAVE_DRAW_BAR.UseVisualStyleBackColor = true;
            this.CHK_GRAPH_SLAVE_DRAW_BAR.CheckedChanged += new System.EventHandler(this.CHK_GRAPH_SLAVE_DRAW_BAR_CheckedChanged);
            // 
            // RDO_GRAPH_SCD_TYPE_REAL
            // 
            this.RDO_GRAPH_SCD_TYPE_REAL.AutoSize = true;
            this.RDO_GRAPH_SCD_TYPE_REAL.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.RDO_GRAPH_SCD_TYPE_REAL.Location = new System.Drawing.Point(8, 78);
            this.RDO_GRAPH_SCD_TYPE_REAL.Name = "RDO_GRAPH_SCD_TYPE_REAL";
            this.RDO_GRAPH_SCD_TYPE_REAL.Size = new System.Drawing.Size(53, 16);
            this.RDO_GRAPH_SCD_TYPE_REAL.TabIndex = 19;
            this.RDO_GRAPH_SCD_TYPE_REAL.Text = "REAL";
            this.RDO_GRAPH_SCD_TYPE_REAL.UseVisualStyleBackColor = true;
            this.RDO_GRAPH_SCD_TYPE_REAL.CheckedChanged += new System.EventHandler(this.RDO_GRAPH_SCD_TYPE_REAL_CheckedChanged);
            // 
            // RDO_GRAPH_SCD_TYPE_HISTOGRAM
            // 
            this.RDO_GRAPH_SCD_TYPE_HISTOGRAM.AutoSize = true;
            this.RDO_GRAPH_SCD_TYPE_HISTOGRAM.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.RDO_GRAPH_SCD_TYPE_HISTOGRAM.Location = new System.Drawing.Point(8, 56);
            this.RDO_GRAPH_SCD_TYPE_HISTOGRAM.Name = "RDO_GRAPH_SCD_TYPE_HISTOGRAM";
            this.RDO_GRAPH_SCD_TYPE_HISTOGRAM.Size = new System.Drawing.Size(59, 16);
            this.RDO_GRAPH_SCD_TYPE_HISTOGRAM.TabIndex = 19;
            this.RDO_GRAPH_SCD_TYPE_HISTOGRAM.Text = "HISTO";
            this.RDO_GRAPH_SCD_TYPE_HISTOGRAM.UseVisualStyleBackColor = true;
            this.RDO_GRAPH_SCD_TYPE_HISTOGRAM.CheckedChanged += new System.EventHandler(this.RDO_GRAPH_SCD_TYPE_HISTOGRAM_CheckedChanged);
            // 
            // panel30
            // 
            this.panel30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.panel30.Controls.Add(this.UC_GRAPH_MASTER);
            this.panel30.Location = new System.Drawing.Point(5, 5);
            this.panel30.Name = "panel30";
            this.panel30.Size = new System.Drawing.Size(467, 122);
            this.panel30.TabIndex = 16;
            // 
            // UC_GRAPH_MASTER
            // 
            this.UC_GRAPH_MASTER.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.UC_GRAPH_MASTER.COLOR_BOUND = System.Drawing.Color.White;
            this.UC_GRAPH_MASTER.COLOR_GRAPH = System.Drawing.Color.DeepSkyBlue;
            this.UC_GRAPH_MASTER.Font = new System.Drawing.Font("Verdana", 9F);
            this.UC_GRAPH_MASTER.Location = new System.Drawing.Point(3, 3);
            this.UC_GRAPH_MASTER.Name = "UC_GRAPH_MASTER";
            this.UC_GRAPH_MASTER.Size = new System.Drawing.Size(461, 116);
            this.UC_GRAPH_MASTER.TabIndex = 0;
            // 
            // panel31
            // 
            this.panel31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.panel31.Controls.Add(this.UC_GRAPH_SLAVE);
            this.panel31.Location = new System.Drawing.Point(3, 131);
            this.panel31.Name = "panel31";
            this.panel31.Size = new System.Drawing.Size(469, 120);
            this.panel31.TabIndex = 16;
            // 
            // UC_GRAPH_SLAVE
            // 
            this.UC_GRAPH_SLAVE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.UC_GRAPH_SLAVE.COLOR_BOUND = System.Drawing.Color.White;
            this.UC_GRAPH_SLAVE.COLOR_GRAPH = System.Drawing.Color.DeepSkyBlue;
            this.UC_GRAPH_SLAVE.Font = new System.Drawing.Font("Verdana", 9F);
            this.UC_GRAPH_SLAVE.Location = new System.Drawing.Point(3, 3);
            this.UC_GRAPH_SLAVE.Name = "UC_GRAPH_SLAVE";
            this.UC_GRAPH_SLAVE.Size = new System.Drawing.Size(463, 114);
            this.UC_GRAPH_SLAVE.TabIndex = 0;
            // 
            // panel32
            // 
            this.panel32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.panel32.Controls.Add(this.panel33);
            this.panel32.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.panel32.Location = new System.Drawing.Point(408, 254);
            this.panel32.Name = "panel32";
            this.panel32.Size = new System.Drawing.Size(148, 100);
            this.panel32.TabIndex = 11;
            // 
            // panel33
            // 
            this.panel33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.panel33.Controls.Add(this.BTN_ROI_DIR_LFT);
            this.panel33.Controls.Add(this.BTN_ROI_DIR_TOP);
            this.panel33.Controls.Add(this.BTN_ROI_DIR_RHT);
            this.panel33.Controls.Add(this.BTN_ROI_DIR_BTM);
            this.panel33.Location = new System.Drawing.Point(3, 2);
            this.panel33.Name = "panel33";
            this.panel33.Size = new System.Drawing.Size(141, 95);
            this.panel33.TabIndex = 1;
            // 
            // BTN_ROI_DIR_LFT
            // 
            this.BTN_ROI_DIR_LFT.BackgroundImage = global::CD_Simulator.Properties.Resources.dir_left;
            this.BTN_ROI_DIR_LFT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_ROI_DIR_LFT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BTN_ROI_DIR_LFT.FlatAppearance.BorderSize = 0;
            this.BTN_ROI_DIR_LFT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_ROI_DIR_LFT.Font = new System.Drawing.Font("Verdana", 9F);
            this.BTN_ROI_DIR_LFT.Location = new System.Drawing.Point(3, 50);
            this.BTN_ROI_DIR_LFT.Name = "BTN_ROI_DIR_LFT";
            this.BTN_ROI_DIR_LFT.Size = new System.Drawing.Size(40, 40);
            this.BTN_ROI_DIR_LFT.TabIndex = 0;
            this.BTN_ROI_DIR_LFT.UseVisualStyleBackColor = true;
            // 
            // BTN_ROI_DIR_TOP
            // 
            this.BTN_ROI_DIR_TOP.BackgroundImage = global::CD_Simulator.Properties.Resources.dir_top;
            this.BTN_ROI_DIR_TOP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_ROI_DIR_TOP.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BTN_ROI_DIR_TOP.FlatAppearance.BorderSize = 0;
            this.BTN_ROI_DIR_TOP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_ROI_DIR_TOP.Font = new System.Drawing.Font("Verdana", 9F);
            this.BTN_ROI_DIR_TOP.Location = new System.Drawing.Point(49, 4);
            this.BTN_ROI_DIR_TOP.Name = "BTN_ROI_DIR_TOP";
            this.BTN_ROI_DIR_TOP.Size = new System.Drawing.Size(40, 40);
            this.BTN_ROI_DIR_TOP.TabIndex = 0;
            this.BTN_ROI_DIR_TOP.UseVisualStyleBackColor = true;
            // 
            // BTN_ROI_DIR_RHT
            // 
            this.BTN_ROI_DIR_RHT.BackgroundImage = global::CD_Simulator.Properties.Resources.dir_right;
            this.BTN_ROI_DIR_RHT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_ROI_DIR_RHT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BTN_ROI_DIR_RHT.FlatAppearance.BorderSize = 0;
            this.BTN_ROI_DIR_RHT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_ROI_DIR_RHT.Font = new System.Drawing.Font("Verdana", 9F);
            this.BTN_ROI_DIR_RHT.Location = new System.Drawing.Point(95, 50);
            this.BTN_ROI_DIR_RHT.Name = "BTN_ROI_DIR_RHT";
            this.BTN_ROI_DIR_RHT.Size = new System.Drawing.Size(40, 40);
            this.BTN_ROI_DIR_RHT.TabIndex = 0;
            this.BTN_ROI_DIR_RHT.UseVisualStyleBackColor = true;
            // 
            // BTN_ROI_DIR_BTM
            // 
            this.BTN_ROI_DIR_BTM.BackgroundImage = global::CD_Simulator.Properties.Resources.dir_bottom;
            this.BTN_ROI_DIR_BTM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_ROI_DIR_BTM.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BTN_ROI_DIR_BTM.FlatAppearance.BorderSize = 0;
            this.BTN_ROI_DIR_BTM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_ROI_DIR_BTM.Font = new System.Drawing.Font("Verdana", 9F);
            this.BTN_ROI_DIR_BTM.Location = new System.Drawing.Point(49, 50);
            this.BTN_ROI_DIR_BTM.Name = "BTN_ROI_DIR_BTM";
            this.BTN_ROI_DIR_BTM.Size = new System.Drawing.Size(40, 40);
            this.BTN_ROI_DIR_BTM.TabIndex = 0;
            this.BTN_ROI_DIR_BTM.UseVisualStyleBackColor = true;
            // 
            // page_param
            // 
            this.page_param.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.page_param.Controls.Add(this.panel6);
            this.page_param.Controls.Add(this.panel7);
            this.page_param.Location = new System.Drawing.Point(4, 34);
            this.page_param.Name = "page_param";
            this.page_param.Size = new System.Drawing.Size(575, 715);
            this.page_param.TabIndex = 2;
            this.page_param.Text = "EXPERIMENT";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.panel5.Controls.Add(this.CHK_MEASURE_DUMP);
            this.panel5.Controls.Add(this.label37);
            this.panel5.Controls.Add(this.CHK_MEASURE_VIEW_ONLY);
            this.panel5.Controls.Add(this.LV_FILE_LIST);
            this.panel5.Location = new System.Drawing.Point(1257, 41);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(321, 529);
            this.panel5.TabIndex = 18;
            // 
            // BTN_UPDATE_FIGURE_LIST
            // 
            this.BTN_UPDATE_FIGURE_LIST.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.BTN_UPDATE_FIGURE_LIST.FlatAppearance.BorderSize = 2;
            this.BTN_UPDATE_FIGURE_LIST.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_UPDATE_FIGURE_LIST.Font = new System.Drawing.Font("Verdana", 10F);
            this.BTN_UPDATE_FIGURE_LIST.ForeColor = System.Drawing.Color.Linen;
            this.BTN_UPDATE_FIGURE_LIST.Location = new System.Drawing.Point(1254, 9);
            this.BTN_UPDATE_FIGURE_LIST.Name = "BTN_UPDATE_FIGURE_LIST";
            this.BTN_UPDATE_FIGURE_LIST.Size = new System.Drawing.Size(113, 28);
            this.BTN_UPDATE_FIGURE_LIST.TabIndex = 19;
            this.BTN_UPDATE_FIGURE_LIST.Text = "Update";
            this.BTN_UPDATE_FIGURE_LIST.UseVisualStyleBackColor = true;
            this.BTN_UPDATE_FIGURE_LIST.Visible = false;
            this.BTN_UPDATE_FIGURE_LIST.Click += new System.EventHandler(this.BTN_UPDATE_FIGURE_LIST_Click);
            // 
            // panel20
            // 
            this.panel20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.panel20.Controls.Add(this.label31);
            this.panel20.Controls.Add(this.BTN_MEASURE);
            this.panel20.Location = new System.Drawing.Point(1257, 576);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(321, 187);
            this.panel20.TabIndex = 20;
            // 
            // BTN_MEASURE
            // 
            this.BTN_MEASURE.BackgroundImage = global::CD_Simulator.Properties.Resources.package_graphics;
            this.BTN_MEASURE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_MEASURE.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.BTN_MEASURE.Font = new System.Drawing.Font("Verdana", 9F);
            this.BTN_MEASURE.ForeColor = System.Drawing.Color.Cornsilk;
            this.BTN_MEASURE.Location = new System.Drawing.Point(4, 4);
            this.BTN_MEASURE.Name = "BTN_MEASURE";
            this.BTN_MEASURE.Size = new System.Drawing.Size(100, 100);
            this.BTN_MEASURE.TabIndex = 0;
            this.BTN_MEASURE.UseVisualStyleBackColor = true;
            this.BTN_MEASURE.Click += new System.EventHandler(this.BTN_MEASURE_Click);
            // 
            // FormMain
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(1584, 766);
            this.Controls.Add(this.panel20);
            this.Controls.Add(this.BTN_UPDATE_FIGURE_LIST);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.TAB_MENU);
            this.Controls.Add(this.panel_temp);
            this.Controls.Add(this.PANEL_VIEW_BLEND);
            this.Controls.Add(this.panel11);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormMain";
            this.Text = "CD Meter Simulator";
            this.Load += new System.EventHandler(this.FormMainUI_Load);
            this.PANEL_VIEW_TOOLS.ResumeLayout(false);
            this.PANEL_VIEW_TOOLS.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.PANEL_MESSAGE_WINDOW.ResumeLayout(false);
            this.PANEL_MESSAGE_WINDOW.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.PANEL_VIEW_BLEND.ResumeLayout(false);
            this.PANEL_VIEW_BLEND.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TB_BLENDING_RATIO)).EndInit();
            this.panel_temp.ResumeLayout(false);
            this.TAB_MENU.ResumeLayout(false);
            this.page_main.ResumeLayout(false);
            this.page_setting.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.TAB_FIGURE.ResumeLayout(false);
            this.rcPairHorizontal.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.rcPairVertical.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            this.rcPairDiagonal.ResumeLayout(false);
            this.panel19.ResumeLayout(false);
            this.panel21.ResumeLayout(false);
            this.panel21.PerformLayout();
            this.circle.ResumeLayout(false);
            this.panel22.ResumeLayout(false);
            this.panel24.ResumeLayout(false);
            this.panel24.PerformLayout();
            this.Ol.ResumeLayout(false);
            this.panel28.ResumeLayout(false);
            this.panel28.PerformLayout();
            this.panel23.ResumeLayout(false);
            this.panel23.PerformLayout();
            this.ptrn.ResumeLayout(false);
            this.panel17.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PIC_PTRN)).EndInit();
            this.panel25.ResumeLayout(false);
            this.panel26.ResumeLayout(false);
            this.panel27.ResumeLayout(false);
            this.panel27.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TB_FIGURE_CTRL_SCALE)).EndInit();
            this.panel29.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel30.ResumeLayout(false);
            this.panel31.ResumeLayout(false);
            this.panel32.ResumeLayout(false);
            this.panel33.ResumeLayout(false);
            this.page_param.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel20.ResumeLayout(false);
            this.panel20.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PANEL_VIEW_TOOLS;
        private System.Windows.Forms.Button BTN_VIEW_IMAGE_LOAD;
        private System.Windows.Forms.Button BTN_VIEW_IMAGE_SAVE;
        private System.Windows.Forms.Button BTN_VIEW_OVERLAY_MAG_ORG;
        private System.Windows.Forms.Button BTN_VIEW_MAG_PLUS;
        private System.Windows.Forms.Button BTN_VIEW_MAG_MINUS;
        private System.Windows.Forms.Button BTN_VIEW_SET_OVERLAY;
        private System.Windows.Forms.Button BTN_VIEW_OVERLAY_CLEAR;
        private System.Windows.Forms.Button BTN_VIEW_PANNING;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LB_VIEW_ZOOM_ORIGIN;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox TXT_INFO_IMAGE_AVG;
        private System.Windows.Forms.TextBox TXT_INFO_IMAGE_DIFF;
        private System.Windows.Forms.TextBox TXT_INFO_PIXEL_Y;
        private System.Windows.Forms.TextBox TXT_INFO_IMAGE_MAX;
        private System.Windows.Forms.TextBox TXT_INFO_PIXEL_X;
        private System.Windows.Forms.TextBox TXT_INFO_IMAGE_MIN;
        private System.Windows.Forms.TextBox TXT_INFO_IMAGE_Y;
        private System.Windows.Forms.TextBox TXT_INFO_IMAGE_X;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.RichTextBox msg;
        private UC_Graph.penelGraph uc_graph_global;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PANEL_MESSAGE_WINDOW;
        
        private System.Windows.Forms.ListView LV_PARAMETER;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button BTN_UPDATE_PARAM_FIGURES;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button BTN_RECIPE_LOAD;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button BTN_RECIPE_SAVE;
        private System.Windows.Forms.TextBox TXT_PATH_DUMP;
        private System.Windows.Forms.TextBox TXT_PATH_RECIPE;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TXT_PATH_RECP_FILE;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button BTN_SELECT_VIEW1;
        private System.Windows.Forms.Button SELECT_VIEW2;
        private CD_View.Viewer imageView2;
        private System.Windows.Forms.Label LB_CAM_INDEX;
        private System.Windows.Forms.Panel PANEL_VIEW_BLEND;
        private System.Windows.Forms.Panel panel_temp;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TrackBar TB_BLENDING_RATIO;
        private System.Windows.Forms.Label LB_BLEND_VALUE;
        private System.Windows.Forms.CheckBox CHK_BLEND;
        private System.Windows.Forms.Button BTN_MEASURE;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Button BTN_UPDATE_PARAMETER;
        private System.Windows.Forms.Button BTN_PTRN_MATCH;
        private System.Windows.Forms.Button BTN_PTRN_TEACHING_LOAD;
        private System.Windows.Forms.TextBox TXT_PTRN_PATH;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Button BTN_SET_RELATIVE_POSITION;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox TXT_PTRN_FILE_NAME;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.CheckBox CHK_MEASURE_VIEW_ONLY;
        private System.Windows.Forms.ListView LV_FILE_LIST;
        private System.Windows.Forms.ColumnHeader INDEX;
        private System.Windows.Forms.ColumnHeader FILES;
        private System.Windows.Forms.CheckBox CHK_MEASURE_DUMP;
        private System.Windows.Forms.TabControl TAB_MENU;
        private System.Windows.Forms.TabPage page_main;
        private System.Windows.Forms.TabPage page_setting;
        private System.Windows.Forms.TabPage page_param;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.TabControl TAB_FIGURE;
        private System.Windows.Forms.TabPage rcPairHorizontal;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Button BTN_HOR_ADD;
        private System.Windows.Forms.Button BTN_HOR_COPY;
        private System.Windows.Forms.Button BTN_HOR_MODIFY;
        private System.Windows.Forms.Button BTN_HOR_REMOVE;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TXT_RCH_H;
        private System.Windows.Forms.TextBox TXT_RCH_W;
        private System.Windows.Forms.ListView LV_PAIR_HOR;
        private System.Windows.Forms.Label LB_RCH_H;
        private System.Windows.Forms.Label LB_RCH_W;
        private System.Windows.Forms.TabPage rcPairVertical;
        private System.Windows.Forms.TextBox TXT_RCV_H;
        private System.Windows.Forms.TextBox TXT_RCV_W;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Button BTN_VER_COPY;
        private System.Windows.Forms.Button BTN_VER_ADD;
        private System.Windows.Forms.Button BTN_VER_MODIFY;
        private System.Windows.Forms.Button BTN_VER_REMOVE;
        private System.Windows.Forms.TextBox TXT_PARAM_VER_NICK;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListView LV_PAIR_VER;
        private System.Windows.Forms.TabPage rcPairDiagonal;
        private System.Windows.Forms.TextBox TXT_RCD_H;
        private System.Windows.Forms.TextBox TXT_RCD_W;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Button BTN_DIG_COPY;
        private System.Windows.Forms.Button BTN_DIG_ADD;
        private System.Windows.Forms.Button BTN_DIG_MODIFY;
        private System.Windows.Forms.Button BTN_DIG_REMOVE;
        private System.Windows.Forms.Button BTN_DIG_ANGLE_DW;
        private System.Windows.Forms.Button BTN_DIG_ANGLE_UP;
        private System.Windows.Forms.TextBox TXT_PARAM_DIG_ANGLE;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ListView LV_PAIR_DIG;
        private System.Windows.Forms.TabPage circle;
        private System.Windows.Forms.TextBox TXT_CIRCLE_H;
        private System.Windows.Forms.TextBox TXT_CIRCLE_W;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.Button BTN_CIR_ADD;
        private System.Windows.Forms.Button BTN_CIR_COPY;
        private System.Windows.Forms.Button BTN_CIR_MODIFY;
        private System.Windows.Forms.Button BTN_CIR_REMOVE;
        private System.Windows.Forms.TextBox TXT_PARAM_CIR_NICK;
        private System.Windows.Forms.Panel panel24;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.ListView LV_PAIR_CIR;
        private System.Windows.Forms.TabPage ptrn;
        private System.Windows.Forms.PictureBox PIC_PTRN;
        private System.Windows.Forms.ListView LV_PTRN;
        private System.Windows.Forms.ColumnHeader IDX;
        private System.Windows.Forms.ColumnHeader FIELS;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BTN_TEACH_PTRN;
        private System.Windows.Forms.Button BTN_ROI_ADD;
        private System.Windows.Forms.Button BTN_ROI_REMOVE_ALL;
        private System.Windows.Forms.Button BTN_SAVE_REGION;
        private System.Windows.Forms.Panel panel25;
        private System.Windows.Forms.Panel panel26;
        private System.Windows.Forms.Panel panel27;
        private System.Windows.Forms.TextBox TXT_FIGURE_CONTROL_SCALE;
        private System.Windows.Forms.TrackBar TB_FIGURE_CTRL_SCALE;
        private System.Windows.Forms.Label label87;
        private System.Windows.Forms.RadioButton RDO_ROI_SIZE;
        private System.Windows.Forms.RadioButton RDO_ROI_POSITION;
        private System.Windows.Forms.RadioButton RDO_ROI_GAP;
        private System.Windows.Forms.Panel panel29;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton RDO_GRAPH_FST_TYPE_REAL;
        private System.Windows.Forms.RadioButton RDO_GRAPH_FST_TYPE_HISTOGRAM;
        private System.Windows.Forms.RadioButton RDO_GRAPH_FST_TYPE_PROJECTION_V;
        private System.Windows.Forms.RadioButton RDO_GRAPH_FST_TYPE_PROJECTION_H;
        private System.Windows.Forms.CheckBox CHK_GRAPH_MASTER_DRAW_BAR;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RDO_GRAPH_SCD_TYPE_PROJECTION_V;
        private System.Windows.Forms.RadioButton RDO_GRAPH_SCD_TYPE_PROJECTION_H;
        private System.Windows.Forms.CheckBox CHK_GRAPH_SLAVE_DRAW_BAR;
        private System.Windows.Forms.RadioButton RDO_GRAPH_SCD_TYPE_REAL;
        private System.Windows.Forms.RadioButton RDO_GRAPH_SCD_TYPE_HISTOGRAM;
        private System.Windows.Forms.Panel panel30;
        private UC_Graph.penelGraph UC_GRAPH_MASTER;
        private System.Windows.Forms.Panel panel31;
        private UC_Graph.penelGraph UC_GRAPH_SLAVE;
        private System.Windows.Forms.Panel panel32;
        private System.Windows.Forms.Panel panel33;
        private System.Windows.Forms.Button BTN_ROI_DIR_LFT;
        private System.Windows.Forms.Button BTN_ROI_DIR_TOP;
        private System.Windows.Forms.Button BTN_ROI_DIR_RHT;
        private System.Windows.Forms.Button BTN_ROI_DIR_BTM;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.TextBox TXT_PARAM_HOR_NICK;
        private System.Windows.Forms.TextBox TXT_PARAM_DIG_NICK;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button BTN_UPDATE_FIGURE_LIST;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Button BTN_DRAW_FIGURE;
        private ParameterSetting.Parameter UC_PARAMETER;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Panel panel20;
        private CD_View.Viewer imageView1;
        private System.Windows.Forms.TextBox TXT_PTRN_ACC_RATIO;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Button BTN_VIEW_SAVE_OVERLAY;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.TabPage Ol;
        private System.Windows.Forms.Panel panel28;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.TextBox TXT_OVL_IN_H;
        private System.Windows.Forms.TextBox TXT_OVL_IN_W;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox TXT_PARAM_OVL_NICK;
        private System.Windows.Forms.ListView LV_PAIR_OVL;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.Button BTN_OL_ADD;
        private System.Windows.Forms.Button BTN_OL_COPY;
        private System.Windows.Forms.Button BTN_OL_REMOVE;
        private System.Windows.Forms.RadioButton RDO_ROI_ASYM;
        private System.Windows.Forms.RadioButton RDO_ROI_OVL_EX;
        private System.Windows.Forms.RadioButton RDO_ROI_OVL_IN;
        private System.Windows.Forms.RadioButton RDO_ROI_OVL_ENTIRE;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.TextBox TXT_OVL_EX_H;
        private System.Windows.Forms.TextBox TXT_OVL_EX_W;
        private System.Windows.Forms.Button button6;

    }
}

