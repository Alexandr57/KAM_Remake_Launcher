namespace KAM_Remake_Launcher
{
    partial class AL7_frmDownloadProcess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AL7_frmDownloadProcess));
            this.pic_DownloadProcess = new System.Windows.Forms.PictureBox();
            this.pic_WaitDownloadProcess = new System.Windows.Forms.PictureBox();
            this.tlpDownloadProcess = new System.Windows.Forms.TableLayoutPanel();
            this.btnAutoInstKMR = new System.Windows.Forms.Button();
            this.btnInstKMR = new System.Windows.Forms.Button();
            this.bprgBar = new ProgressBars.Basic.BasicProgressBar();
            this.lblCaptionDownloadProcess = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_DownloadProcess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_WaitDownloadProcess)).BeginInit();
            this.tlpDownloadProcess.SuspendLayout();
            this.SuspendLayout();
            // 
            // pic_DownloadProcess
            // 
            this.pic_DownloadProcess.BackColor = System.Drawing.Color.Transparent;
            this.pic_DownloadProcess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_DownloadProcess.Location = new System.Drawing.Point(0, 0);
            this.pic_DownloadProcess.Name = "pic_DownloadProcess";
            this.pic_DownloadProcess.Size = new System.Drawing.Size(360, 397);
            this.pic_DownloadProcess.TabIndex = 7;
            this.pic_DownloadProcess.TabStop = false;
            // 
            // pic_WaitDownloadProcess
            // 
            this.pic_WaitDownloadProcess.BackColor = System.Drawing.Color.Transparent;
            this.pic_WaitDownloadProcess.Image = ((System.Drawing.Image)(resources.GetObject("pic_WaitDownloadProcess.Image")));
            this.pic_WaitDownloadProcess.Location = new System.Drawing.Point(168, 113);
            this.pic_WaitDownloadProcess.Name = "pic_WaitDownloadProcess";
            this.pic_WaitDownloadProcess.Size = new System.Drawing.Size(192, 192);
            this.pic_WaitDownloadProcess.TabIndex = 14;
            this.pic_WaitDownloadProcess.TabStop = false;
            this.pic_WaitDownloadProcess.Visible = false;
            // 
            // tlpDownloadProcess
            // 
            this.tlpDownloadProcess.BackColor = System.Drawing.Color.Transparent;
            this.tlpDownloadProcess.ColumnCount = 3;
            this.tlpDownloadProcess.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDownloadProcess.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tlpDownloadProcess.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDownloadProcess.Controls.Add(this.btnAutoInstKMR, 2, 0);
            this.tlpDownloadProcess.Controls.Add(this.btnInstKMR, 0, 0);
            this.tlpDownloadProcess.Location = new System.Drawing.Point(0, 60);
            this.tlpDownloadProcess.Margin = new System.Windows.Forms.Padding(0);
            this.tlpDownloadProcess.Name = "tlpDownloadProcess";
            this.tlpDownloadProcess.Padding = new System.Windows.Forms.Padding(8);
            this.tlpDownloadProcess.RowCount = 1;
            this.tlpDownloadProcess.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDownloadProcess.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tlpDownloadProcess.Size = new System.Drawing.Size(360, 50);
            this.tlpDownloadProcess.TabIndex = 13;
            // 
            // btnAutoInstKMR
            // 
            this.btnAutoInstKMR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAutoInstKMR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAutoInstKMR.Enabled = false;
            this.btnAutoInstKMR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAutoInstKMR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAutoInstKMR.ForeColor = System.Drawing.Color.Yellow;
            this.btnAutoInstKMR.Image = ((System.Drawing.Image)(resources.GetObject("btnAutoInstKMR.Image")));
            this.btnAutoInstKMR.Location = new System.Drawing.Point(187, 11);
            this.btnAutoInstKMR.Name = "btnAutoInstKMR";
            this.btnAutoInstKMR.Size = new System.Drawing.Size(162, 28);
            this.btnAutoInstKMR.TabIndex = 11;
            this.btnAutoInstKMR.Text = "Авто установка";
            this.btnAutoInstKMR.UseVisualStyleBackColor = true;
            // 
            // btnInstKMR
            // 
            this.btnInstKMR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInstKMR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInstKMR.Enabled = false;
            this.btnInstKMR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInstKMR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnInstKMR.ForeColor = System.Drawing.Color.Yellow;
            this.btnInstKMR.Image = ((System.Drawing.Image)(resources.GetObject("btnInstKMR.Image")));
            this.btnInstKMR.Location = new System.Drawing.Point(11, 11);
            this.btnInstKMR.Name = "btnInstKMR";
            this.btnInstKMR.Size = new System.Drawing.Size(162, 28);
            this.btnInstKMR.TabIndex = 9;
            this.btnInstKMR.Text = "Ручная установка";
            this.btnInstKMR.UseVisualStyleBackColor = true;
            this.btnInstKMR.Click += new System.EventHandler(this.btnInstKMR_Click);
            // 
            // bprgBar
            // 
            this.bprgBar.BackColor = System.Drawing.Color.Transparent;
            this.bprgBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bprgBar.BackgroundImage")));
            this.bprgBar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(21)))), ((int)(((byte)(14)))));
            this.bprgBar.BorderThickness = 4;
            this.bprgBar.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bprgBar.ForeColor = System.Drawing.Color.Lime;
            this.bprgBar.Location = new System.Drawing.Point(0, 333);
            this.bprgBar.Name = "bprgBar";
            this.bprgBar.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.bprgBar.Size = new System.Drawing.Size(360, 28);
            this.bprgBar.TabIndex = 12;
            this.bprgBar.TextColor = System.Drawing.Color.White;
            this.bprgBar.Value = 50;
            // 
            // lblCaptionDownloadProcess
            // 
            this.lblCaptionDownloadProcess.BackColor = System.Drawing.Color.Transparent;
            this.lblCaptionDownloadProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCaptionDownloadProcess.ForeColor = System.Drawing.Color.Yellow;
            this.lblCaptionDownloadProcess.Location = new System.Drawing.Point(0, 186);
            this.lblCaptionDownloadProcess.Name = "lblCaptionDownloadProcess";
            this.lblCaptionDownloadProcess.Size = new System.Drawing.Size(360, 24);
            this.lblCaptionDownloadProcess.TabIndex = 15;
            this.lblCaptionDownloadProcess.Text = "Идет процесс скачки";
            this.lblCaptionDownloadProcess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AL7_frmDownloadProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(360, 397);
            this.ControlBox = false;
            this.Controls.Add(this.lblCaptionDownloadProcess);
            this.Controls.Add(this.pic_WaitDownloadProcess);
            this.Controls.Add(this.tlpDownloadProcess);
            this.Controls.Add(this.bprgBar);
            this.Controls.Add(this.pic_DownloadProcess);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AL7_frmDownloadProcess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AL7_frmDownloadProcess";
            ((System.ComponentModel.ISupportInitialize)(this.pic_DownloadProcess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_WaitDownloadProcess)).EndInit();
            this.tlpDownloadProcess.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_DownloadProcess;
        private System.Windows.Forms.PictureBox pic_WaitDownloadProcess;
        private System.Windows.Forms.TableLayoutPanel tlpDownloadProcess;
        private System.Windows.Forms.Button btnAutoInstKMR;
        private System.Windows.Forms.Button btnInstKMR;
        private ProgressBars.Basic.BasicProgressBar bprgBar;
        private System.Windows.Forms.Label lblCaptionDownloadProcess;
    }
}