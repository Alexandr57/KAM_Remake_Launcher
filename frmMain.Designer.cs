namespace KAM_Remake_Launcher
{
    partial class frmMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pic_1 = new System.Windows.Forms.PictureBox();
            this.pic_2 = new System.Windows.Forms.PictureBox();
            this.tmrAnim = new System.Windows.Forms.Timer(this.components);
            this.pic_Mask = new System.Windows.Forms.PictureBox();
            this.pic = new System.Windows.Forms.PictureBox();
            this.lblKMRVer = new System.Windows.Forms.Label();
            this.btnStartKMR = new System.Windows.Forms.Button();
            this.fBD1 = new System.Windows.Forms.FolderBrowserDialog();
            this.pic_DownloadProcess = new System.Windows.Forms.PictureBox();
            this.lblCaptionDownloadProcess = new System.Windows.Forms.Label();
            this.bprgBar = new ProgressBars.Basic.BasicProgressBar();
            this.btnInstKMR = new System.Windows.Forms.Button();
            this.tlpDownloadProcess = new System.Windows.Forms.TableLayoutPanel();
            this.btnAutoInstKMR = new System.Windows.Forms.Button();
            this.pic_WaitDownloadProcess = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Mask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_DownloadProcess)).BeginInit();
            this.tlpDownloadProcess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_WaitDownloadProcess)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_1
            // 
            this.pic_1.Image = ((System.Drawing.Image)(resources.GetObject("pic_1.Image")));
            this.pic_1.Location = new System.Drawing.Point(0, 10);
            this.pic_1.Name = "pic_1";
            this.pic_1.Size = new System.Drawing.Size(320, 460);
            this.pic_1.TabIndex = 0;
            this.pic_1.TabStop = false;
            // 
            // pic_2
            // 
            this.pic_2.Image = ((System.Drawing.Image)(resources.GetObject("pic_2.Image")));
            this.pic_2.Location = new System.Drawing.Point(320, 10);
            this.pic_2.Name = "pic_2";
            this.pic_2.Size = new System.Drawing.Size(320, 460);
            this.pic_2.TabIndex = 1;
            this.pic_2.TabStop = false;
            // 
            // tmrAnim
            // 
            this.tmrAnim.Interval = 1;
            this.tmrAnim.Tick += new System.EventHandler(this.tmrAnim_Tick);
            // 
            // pic_Mask
            // 
            this.pic_Mask.Image = ((System.Drawing.Image)(resources.GetObject("pic_Mask.Image")));
            this.pic_Mask.Location = new System.Drawing.Point(0, 0);
            this.pic_Mask.Name = "pic_Mask";
            this.pic_Mask.Size = new System.Drawing.Size(640, 480);
            this.pic_Mask.TabIndex = 2;
            this.pic_Mask.TabStop = false;
            // 
            // pic
            // 
            this.pic.Image = ((System.Drawing.Image)(resources.GetObject("pic.Image")));
            this.pic.Location = new System.Drawing.Point(0, 0);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(640, 480);
            this.pic.TabIndex = 3;
            this.pic.TabStop = false;
            // 
            // lblKMRVer
            // 
            this.lblKMRVer.BackColor = System.Drawing.Color.Transparent;
            this.lblKMRVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblKMRVer.Location = new System.Drawing.Point(323, 116);
            this.lblKMRVer.Name = "lblKMRVer";
            this.lblKMRVer.Size = new System.Drawing.Size(218, 24);
            this.lblKMRVer.TabIndex = 4;
            this.lblKMRVer.Text = "Версия KAM Remake:";
            this.lblKMRVer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStartKMR
            // 
            this.btnStartKMR.BackColor = System.Drawing.Color.Transparent;
            this.btnStartKMR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartKMR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStartKMR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStartKMR.ForeColor = System.Drawing.Color.Yellow;
            this.btnStartKMR.Image = ((System.Drawing.Image)(resources.GetObject("btnStartKMR.Image")));
            this.btnStartKMR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStartKMR.Location = new System.Drawing.Point(170, 24);
            this.btnStartKMR.Name = "btnStartKMR";
            this.btnStartKMR.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnStartKMR.Size = new System.Drawing.Size(400, 48);
            this.btnStartKMR.TabIndex = 5;
            this.btnStartKMR.Text = "Запустить KAM Remake";
            this.btnStartKMR.UseVisualStyleBackColor = false;
            this.btnStartKMR.Click += new System.EventHandler(this.btnStartKMR_Click);
            // 
            // fBD1
            // 
            this.fBD1.RootFolder = System.Environment.SpecialFolder.ApplicationData;
            this.fBD1.ShowNewFolderButton = false;
            // 
            // pic_DownloadProcess
            // 
            this.pic_DownloadProcess.BackColor = System.Drawing.Color.Transparent;
            this.pic_DownloadProcess.Image = ((System.Drawing.Image)(resources.GetObject("pic_DownloadProcess.Image")));
            this.pic_DownloadProcess.Location = new System.Drawing.Point(139, 46);
            this.pic_DownloadProcess.Name = "pic_DownloadProcess";
            this.pic_DownloadProcess.Size = new System.Drawing.Size(360, 397);
            this.pic_DownloadProcess.TabIndex = 6;
            this.pic_DownloadProcess.TabStop = false;
            this.pic_DownloadProcess.Visible = false;
            // 
            // lblCaptionDownloadProcess
            // 
            this.lblCaptionDownloadProcess.BackColor = System.Drawing.Color.Transparent;
            this.lblCaptionDownloadProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCaptionDownloadProcess.ForeColor = System.Drawing.Color.Yellow;
            this.lblCaptionDownloadProcess.Location = new System.Drawing.Point(140, 228);
            this.lblCaptionDownloadProcess.Name = "lblCaptionDownloadProcess";
            this.lblCaptionDownloadProcess.Size = new System.Drawing.Size(360, 24);
            this.lblCaptionDownloadProcess.TabIndex = 7;
            this.lblCaptionDownloadProcess.Text = "Идет процесс скачки";
            this.lblCaptionDownloadProcess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bprgBar
            // 
            this.bprgBar.BackColor = System.Drawing.Color.Transparent;
            this.bprgBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bprgBar.BackgroundImage")));
            this.bprgBar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(21)))), ((int)(((byte)(14)))));
            this.bprgBar.BorderThickness = 4;
            this.bprgBar.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bprgBar.ForeColor = System.Drawing.Color.Lime;
            this.bprgBar.Location = new System.Drawing.Point(139, 308);
            this.bprgBar.Name = "bprgBar";
            this.bprgBar.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.bprgBar.Size = new System.Drawing.Size(360, 28);
            this.bprgBar.TabIndex = 8;
            this.bprgBar.TextColor = System.Drawing.Color.White;
            this.bprgBar.Value = 50;
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
            // tlpDownloadProcess
            // 
            this.tlpDownloadProcess.BackColor = System.Drawing.Color.Transparent;
            this.tlpDownloadProcess.ColumnCount = 3;
            this.tlpDownloadProcess.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDownloadProcess.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tlpDownloadProcess.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDownloadProcess.Controls.Add(this.btnAutoInstKMR, 2, 0);
            this.tlpDownloadProcess.Controls.Add(this.btnInstKMR, 0, 0);
            this.tlpDownloadProcess.Location = new System.Drawing.Point(139, 161);
            this.tlpDownloadProcess.Margin = new System.Windows.Forms.Padding(0);
            this.tlpDownloadProcess.Name = "tlpDownloadProcess";
            this.tlpDownloadProcess.Padding = new System.Windows.Forms.Padding(8);
            this.tlpDownloadProcess.RowCount = 1;
            this.tlpDownloadProcess.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDownloadProcess.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tlpDownloadProcess.Size = new System.Drawing.Size(360, 50);
            this.tlpDownloadProcess.TabIndex = 10;
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
            // pic_WaitDownloadProcess
            // 
            this.pic_WaitDownloadProcess.BackColor = System.Drawing.Color.Transparent;
            this.pic_WaitDownloadProcess.Image = ((System.Drawing.Image)(resources.GetObject("pic_WaitDownloadProcess.Image")));
            this.pic_WaitDownloadProcess.Location = new System.Drawing.Point(220, 214);
            this.pic_WaitDownloadProcess.Name = "pic_WaitDownloadProcess";
            this.pic_WaitDownloadProcess.Size = new System.Drawing.Size(192, 192);
            this.pic_WaitDownloadProcess.TabIndex = 11;
            this.pic_WaitDownloadProcess.TabStop = false;
            this.pic_WaitDownloadProcess.Visible = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 480);
            this.Controls.Add(this.pic_WaitDownloadProcess);
            this.Controls.Add(this.tlpDownloadProcess);
            this.Controls.Add(this.bprgBar);
            this.Controls.Add(this.lblCaptionDownloadProcess);
            this.Controls.Add(this.pic_DownloadProcess);
            this.Controls.Add(this.btnStartKMR);
            this.Controls.Add(this.lblKMRVer);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.pic_1);
            this.Controls.Add(this.pic_2);
            this.Controls.Add(this.pic_Mask);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pic_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Mask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_DownloadProcess)).EndInit();
            this.tlpDownloadProcess.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_WaitDownloadProcess)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_1;
        private System.Windows.Forms.PictureBox pic_2;
        private System.Windows.Forms.Timer tmrAnim;
        private System.Windows.Forms.PictureBox pic_Mask;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Label lblKMRVer;
        private System.Windows.Forms.Button btnStartKMR;
        private System.Windows.Forms.FolderBrowserDialog fBD1;
        private System.Windows.Forms.PictureBox pic_DownloadProcess;
        private System.Windows.Forms.Label lblCaptionDownloadProcess;
        private ProgressBars.Basic.BasicProgressBar bprgBar;
        private System.Windows.Forms.Button btnInstKMR;
        private System.Windows.Forms.TableLayoutPanel tlpDownloadProcess;
        private System.Windows.Forms.Button btnAutoInstKMR;
        private System.Windows.Forms.PictureBox pic_WaitDownloadProcess;
    }
}

