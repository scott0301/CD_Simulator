namespace CD_View
{
    partial class FormPopup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPopup));
            this.CHK_DRAW_OVERLAY = new System.Windows.Forms.CheckBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.FORM_HEADER = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.BTN_CLOSE = new System.Windows.Forms.Button();
            this.FORM_HEADER.SuspendLayout();
            this.SuspendLayout();
            // 
            // CHK_DRAW_OVERLAY
            // 
            this.CHK_DRAW_OVERLAY.AutoSize = true;
            this.CHK_DRAW_OVERLAY.Location = new System.Drawing.Point(243, 69);
            this.CHK_DRAW_OVERLAY.Name = "CHK_DRAW_OVERLAY";
            this.CHK_DRAW_OVERLAY.Size = new System.Drawing.Size(79, 18);
            this.CHK_DRAW_OVERLAY.TabIndex = 0;
            this.CHK_DRAW_OVERLAY.Text = "Overlay";
            this.CHK_DRAW_OVERLAY.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "measureHor.png");
            this.imageList1.Images.SetKeyName(1, "measureVer.png");
            this.imageList1.Images.SetKeyName(2, "measureDig.png");
            this.imageList1.Images.SetKeyName(3, "measureCir.png");
            this.imageList1.Images.SetKeyName(4, "measureRec.png");
            // 
            // FORM_HEADER
            // 
            this.FORM_HEADER.BackColor = System.Drawing.Color.White;
            this.FORM_HEADER.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FORM_HEADER.Controls.Add(this.label11);
            this.FORM_HEADER.Controls.Add(this.BTN_CLOSE);
            this.FORM_HEADER.ForeColor = System.Drawing.Color.Black;
            this.FORM_HEADER.Location = new System.Drawing.Point(0, 0);
            this.FORM_HEADER.Name = "FORM_HEADER";
            this.FORM_HEADER.Size = new System.Drawing.Size(323, 63);
            this.FORM_HEADER.TabIndex = 15;
            this.FORM_HEADER.Paint += new System.Windows.Forms.PaintEventHandler(this.FORM_HEADER_Paint);
            this.FORM_HEADER.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FORM_HEADER_MouseDown);
            this.FORM_HEADER.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FORM_HEADER_MouseMove);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(9, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 14);
            this.label11.TabIndex = 0;
            this.label11.Text = "Teaching Window";
            // 
            // BTN_CLOSE
            // 
            this.BTN_CLOSE.BackgroundImage = global::CD_View.Properties.Resources.x1;
            this.BTN_CLOSE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_CLOSE.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.BTN_CLOSE.FlatAppearance.BorderSize = 0;
            this.BTN_CLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_CLOSE.ForeColor = System.Drawing.Color.Lime;
            this.BTN_CLOSE.Location = new System.Drawing.Point(271, -1);
            this.BTN_CLOSE.Name = "BTN_CLOSE";
            this.BTN_CLOSE.Size = new System.Drawing.Size(50, 50);
            this.BTN_CLOSE.TabIndex = 1;
            this.BTN_CLOSE.UseVisualStyleBackColor = true;
            this.BTN_CLOSE.Click += new System.EventHandler(this.BTN_TEACHING_FORM_CLOSE_Click);
            // 
            // FormPopup
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(324, 418);
            this.ControlBox = false;
            this.Controls.Add(this.CHK_DRAW_OVERLAY);
            this.Controls.Add(this.FORM_HEADER);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.LimeGreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPopup";
            this.ShowIcon = false;
            this.Text = "Popup";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormPopup_Load);
            this.FORM_HEADER.ResumeLayout(false);
            this.FORM_HEADER.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CHK_DRAW_OVERLAY;
        private System.Windows.Forms.Button BTN_CLOSE;
        private System.Windows.Forms.Panel FORM_HEADER;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ImageList imageList1;
    }
}