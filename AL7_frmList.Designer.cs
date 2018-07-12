namespace KAM_Remake_Launcher
{
    partial class AL7_frmList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AL7_frmList));
            this.lblCaption = new System.Windows.Forms.Label();
            this.pic = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.List = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.flowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCaption
            // 
            this.lblCaption.BackColor = System.Drawing.Color.Transparent;
            this.lblCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCaption.ForeColor = System.Drawing.Color.Yellow;
            this.lblCaption.Location = new System.Drawing.Point(31, 65);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(300, 24);
            this.lblCaption.TabIndex = 18;
            this.lblCaption.Text = "Ошибка. Игра не найдена.";
            this.lblCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pic
            // 
            this.pic.Location = new System.Drawing.Point(197, 229);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(100, 50);
            this.pic.TabIndex = 19;
            this.pic.TabStop = false;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel.Controls.Add(this.btnCancel);
            this.flowLayoutPanel.Controls.Add(this.btnOK);
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 353);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Padding = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.flowLayoutPanel.Size = new System.Drawing.Size(360, 44);
            this.flowLayoutPanel.TabIndex = 20;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(208, 8);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnCancel.Size = new System.Drawing.Size(140, 28);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.Location = new System.Drawing.Point(60, 8);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnOK.Name = "btnOK";
            this.btnOK.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnOK.Size = new System.Drawing.Size(140, 28);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "ОК";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // List
            // 
            this.List.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.List.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.List.FormattingEnabled = true;
            this.List.ItemHeight = 20;
            this.List.Location = new System.Drawing.Point(8, 97);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(120, 222);
            this.List.TabIndex = 21;
            this.List.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.List_DrawItem);
            // 
            // AL7_frmList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(360, 397);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.List);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.lblCaption);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AL7_frmList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AL7_frmListCampaigns";
            this.Shown += new System.EventHandler(this.AL7_frmList_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.flowLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCaption;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ListBox List;
    }
}