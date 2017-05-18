namespace CD_View
{
    partial class Viewer
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.LB_VIEW_MOUSE_POS_X = new System.Windows.Forms.Label();
            this.LB_VIEW_MOUSE_POS_Y = new System.Windows.Forms.Label();
            this.LB_VIEW_PIXEL_VALUE = new System.Windows.Forms.Label();
            this.PIC_VIEW = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_VIEW)).BeginInit();
            this.SuspendLayout();
            // 
            // LB_VIEW_MOUSE_POS_X
            // 
            this.LB_VIEW_MOUSE_POS_X.AutoSize = true;
            this.LB_VIEW_MOUSE_POS_X.BackColor = System.Drawing.Color.Transparent;
            this.LB_VIEW_MOUSE_POS_X.ForeColor = System.Drawing.Color.LimeGreen;
            this.LB_VIEW_MOUSE_POS_X.Location = new System.Drawing.Point(3, 573);
            this.LB_VIEW_MOUSE_POS_X.Name = "LB_VIEW_MOUSE_POS_X";
            this.LB_VIEW_MOUSE_POS_X.Size = new System.Drawing.Size(25, 14);
            this.LB_VIEW_MOUSE_POS_X.TabIndex = 152;
            this.LB_VIEW_MOUSE_POS_X.Text = "X :";
            // 
            // LB_VIEW_MOUSE_POS_Y
            // 
            this.LB_VIEW_MOUSE_POS_Y.AutoSize = true;
            this.LB_VIEW_MOUSE_POS_Y.BackColor = System.Drawing.Color.Transparent;
            this.LB_VIEW_MOUSE_POS_Y.ForeColor = System.Drawing.Color.LimeGreen;
            this.LB_VIEW_MOUSE_POS_Y.Location = new System.Drawing.Point(79, 573);
            this.LB_VIEW_MOUSE_POS_Y.Name = "LB_VIEW_MOUSE_POS_Y";
            this.LB_VIEW_MOUSE_POS_Y.Size = new System.Drawing.Size(30, 14);
            this.LB_VIEW_MOUSE_POS_Y.TabIndex = 152;
            this.LB_VIEW_MOUSE_POS_Y.Text = "Y : ";
            // 
            // LB_VIEW_PIXEL_VALUE
            // 
            this.LB_VIEW_PIXEL_VALUE.AutoSize = true;
            this.LB_VIEW_PIXEL_VALUE.BackColor = System.Drawing.Color.Transparent;
            this.LB_VIEW_PIXEL_VALUE.ForeColor = System.Drawing.Color.LimeGreen;
            this.LB_VIEW_PIXEL_VALUE.Location = new System.Drawing.Point(153, 573);
            this.LB_VIEW_PIXEL_VALUE.Name = "LB_VIEW_PIXEL_VALUE";
            this.LB_VIEW_PIXEL_VALUE.Size = new System.Drawing.Size(26, 14);
            this.LB_VIEW_PIXEL_VALUE.TabIndex = 152;
            this.LB_VIEW_PIXEL_VALUE.Text = "G :";
            // 
            // PIC_VIEW
            // 
            this.PIC_VIEW.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PIC_VIEW.BackColor = System.Drawing.Color.Black;
            this.PIC_VIEW.Location = new System.Drawing.Point(0, 0);
            this.PIC_VIEW.Margin = new System.Windows.Forms.Padding(0);
            this.PIC_VIEW.Name = "PIC_VIEW";
            this.PIC_VIEW.Size = new System.Drawing.Size(600, 600);
            this.PIC_VIEW.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PIC_VIEW.TabIndex = 149;
            this.PIC_VIEW.TabStop = false;
            this.PIC_VIEW.Paint += new System.Windows.Forms.PaintEventHandler(this.PIC_VIEW_Paint);
            this.PIC_VIEW.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PIC_VIEW_MouseDown);
            this.PIC_VIEW.MouseEnter += new System.EventHandler(this.PIC_VIEW_MouseEnter);
            this.PIC_VIEW.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PIC_VIEW_MouseMove);
            this.PIC_VIEW.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PIC_VIEW_MouseUp);
            // 
            // Viewer
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Controls.Add(this.LB_VIEW_MOUSE_POS_Y);
            this.Controls.Add(this.LB_VIEW_PIXEL_VALUE);
            this.Controls.Add(this.LB_VIEW_MOUSE_POS_X);
            this.Controls.Add(this.PIC_VIEW);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Lime;
            this.Name = "Viewer";
            this.Size = new System.Drawing.Size(600, 600);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Viewer_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Viewer_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.PIC_VIEW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PIC_VIEW;
        private System.Windows.Forms.Label LB_VIEW_MOUSE_POS_X;
        private System.Windows.Forms.Label LB_VIEW_MOUSE_POS_Y;
        private System.Windows.Forms.Label LB_VIEW_PIXEL_VALUE;
    }
}
