namespace KAM_Remake_Launcher
{
    partial class AL7_frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AL7_frmMain));
            this.pic_1 = new System.Windows.Forms.PictureBox();
            this.pic_2 = new System.Windows.Forms.PictureBox();
            this.tmrAnim = new System.Windows.Forms.Timer(this.components);
            this.pic_Mask = new System.Windows.Forms.PictureBox();
            this.pic = new System.Windows.Forms.PictureBox();
            this.lblKMRVer = new System.Windows.Forms.Label();
            this.btnStartKMR = new System.Windows.Forms.Button();
            this.fBD1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnOtherEditorStart = new System.Windows.Forms.Button();
            this.pnlOtherEditor = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.picOtherEditor = new System.Windows.Forms.PictureBox();
            this.btnClosePnlOtherEditor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Mask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.pnlOtherEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOtherEditor)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_1
            // 
            this.pic_1.Location = new System.Drawing.Point(0, 10);
            this.pic_1.Name = "pic_1";
            this.pic_1.Size = new System.Drawing.Size(320, 460);
            this.pic_1.TabIndex = 0;
            this.pic_1.TabStop = false;
            // 
            // pic_2
            // 
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
            // btnOtherEditorStart
            // 
            this.btnOtherEditorStart.BackColor = System.Drawing.Color.Transparent;
            this.btnOtherEditorStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOtherEditorStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOtherEditorStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOtherEditorStart.ForeColor = System.Drawing.Color.Yellow;
            this.btnOtherEditorStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOtherEditorStart.Location = new System.Drawing.Point(170, 104);
            this.btnOtherEditorStart.Name = "btnOtherEditorStart";
            this.btnOtherEditorStart.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnOtherEditorStart.Size = new System.Drawing.Size(400, 48);
            this.btnOtherEditorStart.TabIndex = 12;
            this.btnOtherEditorStart.Text = "Запустить другие редакторы";
            this.btnOtherEditorStart.UseVisualStyleBackColor = false;
            this.btnOtherEditorStart.Click += new System.EventHandler(this.btnOtherEditorStart_Click);
            // 
            // pnlOtherEditor
            // 
            this.pnlOtherEditor.AutoScroll = true;
            this.pnlOtherEditor.BackColor = System.Drawing.Color.Transparent;
            this.pnlOtherEditor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlOtherEditor.Controls.Add(this.btnClosePnlOtherEditor);
            this.pnlOtherEditor.Controls.Add(this.button3);
            this.pnlOtherEditor.Controls.Add(this.button2);
            this.pnlOtherEditor.Controls.Add(this.button1);
            this.pnlOtherEditor.Controls.Add(this.picOtherEditor);
            this.pnlOtherEditor.Location = new System.Drawing.Point(0, 0);
            this.pnlOtherEditor.Name = "pnlOtherEditor";
            this.pnlOtherEditor.Size = new System.Drawing.Size(360, 397);
            this.pnlOtherEditor.TabIndex = 13;
            this.pnlOtherEditor.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Yellow;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(30, 62);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(300, 48);
            this.button1.TabIndex = 6;
            this.button1.Text = "Запустить редактор кампаний";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.Yellow;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(30, 118);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(300, 48);
            this.button2.TabIndex = 7;
            this.button2.Text = "Запустить Script Validator";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.Yellow;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(30, 174);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(300, 48);
            this.button3.TabIndex = 8;
            this.button3.Text = "Запустить Translation Manager";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // picOtherEditor
            // 
            this.picOtherEditor.BackColor = System.Drawing.Color.White;
            this.picOtherEditor.Location = new System.Drawing.Point(12, 228);
            this.picOtherEditor.Name = "picOtherEditor";
            this.picOtherEditor.Size = new System.Drawing.Size(100, 50);
            this.picOtherEditor.TabIndex = 9;
            this.picOtherEditor.TabStop = false;
            // 
            // btnClosePnlOtherEditor
            // 
            this.btnClosePnlOtherEditor.BackColor = System.Drawing.Color.Transparent;
            this.btnClosePnlOtherEditor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClosePnlOtherEditor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClosePnlOtherEditor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClosePnlOtherEditor.ForeColor = System.Drawing.Color.Yellow;
            this.btnClosePnlOtherEditor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClosePnlOtherEditor.Location = new System.Drawing.Point(30, 328);
            this.btnClosePnlOtherEditor.Name = "btnClosePnlOtherEditor";
            this.btnClosePnlOtherEditor.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnClosePnlOtherEditor.Size = new System.Drawing.Size(300, 48);
            this.btnClosePnlOtherEditor.TabIndex = 10;
            this.btnClosePnlOtherEditor.Text = "Закрыть";
            this.btnClosePnlOtherEditor.UseVisualStyleBackColor = false;
            this.btnClosePnlOtherEditor.Click += new System.EventHandler(this.btnClosePnlOtherEditor_Click);
            // 
            // AL7_frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 480);
            this.Controls.Add(this.pnlOtherEditor);
            this.Controls.Add(this.btnOtherEditorStart);
            this.Controls.Add(this.btnStartKMR);
            this.Controls.Add(this.lblKMRVer);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.pic_1);
            this.Controls.Add(this.pic_2);
            this.Controls.Add(this.pic_Mask);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AL7_frmMain";
            this.Text = "Стартер KAM Remake";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pic_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Mask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.pnlOtherEditor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picOtherEditor)).EndInit();
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
        private System.Windows.Forms.Button btnOtherEditorStart;
        private System.Windows.Forms.Panel pnlOtherEditor;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox picOtherEditor;
        private System.Windows.Forms.Button btnClosePnlOtherEditor;
    }
}

