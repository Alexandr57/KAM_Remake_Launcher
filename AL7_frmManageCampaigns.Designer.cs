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
            this.btnExtractCampaigns = new System.Windows.Forms.Button();
            this.btnZipCampaigns = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.bprgBar = new ProgressBars.Basic.BasicProgressBar();
            this.lblCaption = new System.Windows.Forms.Label();
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
            // btnExtractCampaigns
            // 
            this.btnExtractCampaigns.BackColor = System.Drawing.Color.Transparent;
            this.btnExtractCampaigns.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExtractCampaigns.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExtractCampaigns.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExtractCampaigns.ForeColor = System.Drawing.Color.Yellow;
            this.btnExtractCampaigns.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExtractCampaigns.Location = new System.Drawing.Point(42, 62);
            this.btnExtractCampaigns.Name = "btnExtractCampaigns";
            this.btnExtractCampaigns.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnExtractCampaigns.Size = new System.Drawing.Size(300, 28);
            this.btnExtractCampaigns.TabIndex = 6;
            this.btnExtractCampaigns.Text = "Распоковать кампанию";
            this.btnExtractCampaigns.UseVisualStyleBackColor = false;
            this.btnExtractCampaigns.Click += new System.EventHandler(this.btnExtractCampaigns_Click);
            // 
            // btnZipCampaigns
            // 
            this.btnZipCampaigns.BackColor = System.Drawing.Color.Transparent;
            this.btnZipCampaigns.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZipCampaigns.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnZipCampaigns.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnZipCampaigns.ForeColor = System.Drawing.Color.Yellow;
            this.btnZipCampaigns.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnZipCampaigns.Location = new System.Drawing.Point(42, 96);
            this.btnZipCampaigns.Name = "btnZipCampaigns";
            this.btnZipCampaigns.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnZipCampaigns.Size = new System.Drawing.Size(300, 56);
            this.btnZipCampaigns.TabIndex = 7;
            this.btnZipCampaigns.Text = "Создать архив с кампанией";
            this.btnZipCampaigns.UseVisualStyleBackColor = false;
            this.btnZipCampaigns.Click += new System.EventHandler(this.btnZipCampaigns_Click);
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
            this.btnClose.Size = new System.Drawing.Size(300, 28);
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
            this.bprgBar.Size = new System.Drawing.Size(300, 28);
            this.bprgBar.TabIndex = 13;
            this.bprgBar.TextColor = System.Drawing.Color.White;
            this.bprgBar.Value = 50;
            // 
            // lblCaption
            // 
            this.lblCaption.BackColor = System.Drawing.Color.Transparent;
            this.lblCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCaption.ForeColor = System.Drawing.Color.Yellow;
            this.lblCaption.Location = new System.Drawing.Point(30, 186);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(300, 24);
            this.lblCaption.TabIndex = 17;
            this.lblCaption.Text = "Ошибка. Игра не найдена.";
            this.lblCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AL7_frmManageCampaigns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(360, 397);
            this.ControlBox = false;
            this.Controls.Add(this.lblCaption);
            this.Controls.Add(this.btnZipCampaigns);
            this.Controls.Add(this.btnExtractCampaigns);
            this.Controls.Add(this.bprgBar);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AL7_frmManageCampaigns";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AL7_frmManageCampaigns";
            this.Shown += new System.EventHandler(this.AL7_frmManageCampaigns_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Button btnExtractCampaigns;
        private System.Windows.Forms.Button btnZipCampaigns;
        private System.Windows.Forms.Button btnClose;
        private ProgressBars.Basic.BasicProgressBar bprgBar;
        private System.Windows.Forms.Label lblCaption;
    }
}