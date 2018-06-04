namespace KAM_Remake_Launcher
{
    partial class AL7_frmManageCampaigns
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AL7_frmManageCampaigns));
            this.pic = new System.Windows.Forms.PictureBox();
            this.btnAddCampaigns = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.bprgBar = new ProgressBars.Basic.BasicProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // pic
            // 
            this.pic.Location = new System.Drawing.Point(140, 194);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(100, 50);
            this.pic.TabIndex = 0;
            this.pic.TabStop = false;
            // 
            // btnAddCampaigns
            // 
            this.btnAddCampaigns.BackColor = System.Drawing.Color.Transparent;
            this.btnAddCampaigns.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCampaigns.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddCampaigns.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddCampaigns.ForeColor = System.Drawing.Color.Yellow;
            this.btnAddCampaigns.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCampaigns.Location = new System.Drawing.Point(42, 62);
            this.btnAddCampaigns.Name = "btnAddCampaigns";
            this.btnAddCampaigns.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAddCampaigns.Size = new System.Drawing.Size(274, 28);
            this.btnAddCampaigns.TabIndex = 6;
            this.btnAddCampaigns.Text = "Распоковать кампанию";
            this.btnAddCampaigns.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Yellow;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(42, 96);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(274, 56);
            this.button1.TabIndex = 7;
            this.button1.Text = "Создать архив с кампанией";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.ForeColor = System.Drawing.Color.Yellow;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(42, 346);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnClose.Size = new System.Drawing.Size(274, 28);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // bprgBar
            // 
            this.bprgBar.BackColor = System.Drawing.Color.Transparent;
            this.bprgBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bprgBar.BackgroundImage")));
            this.bprgBar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(21)))), ((int)(((byte)(14)))));
            this.bprgBar.BorderThickness = 4;
            this.bprgBar.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bprgBar.ForeColor = System.Drawing.Color.Lime;
            this.bprgBar.Location = new System.Drawing.Point(42, 312);
            this.bprgBar.Name = "bprgBar";
            this.bprgBar.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.bprgBar.Size = new System.Drawing.Size(274, 28);
            this.bprgBar.TabIndex = 13;
            this.bprgBar.TextColor = System.Drawing.Color.White;
            this.bprgBar.Value = 50;
            // 
            // AL7_frmManageCampaigns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(360, 397);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAddCampaigns);
            this.Controls.Add(this.bprgBar);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AL7_frmManageCampaigns";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AL7_frmManageCampaigns";
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Button btnAddCampaigns;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnClose;
        private ProgressBars.Basic.BasicProgressBar bprgBar;
    }
}