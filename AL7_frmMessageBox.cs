using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KAM_Remake_Launcher
{
    public partial class AL7_frmMessageBox : Form
    {
        public DialogResult ShowMyDialog(string aCaption, string aText, string aYesBtn, string aNoBtn)
        {
            this.ShowInTaskbar = false;
            this.Text = aCaption;

            lblCaption.Text = aCaption;

            lblText.Text = aText;

            btnOK.Visible = false;

            btnYes.Visible = true;
            btnYes.Text = aYesBtn;

            btnNo.Visible = true;
            btnNo.Text = aNoBtn;

            return ShowDialog();
        }

        public DialogResult ShowMyDialog(string aCaption, string aText)
        {
            this.ShowInTaskbar = false;
            this.Text = aCaption;

            lblCaption.Text = aCaption;

            lblText.Text = aText;

            btnOK.Visible = true;

            btnYes.Visible = false;

            btnNo.Visible = false;

            return ShowDialog();
        }

        public AL7_frmMessageBox()
        {
            InitializeComponent();
        }

        private void AL7MessageBox_Shown(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(Application.StartupPath + @"\data\img\BG_Mask.png");

            pic.Dock = DockStyle.Fill;
            pic.Image = Image.FromFile(Application.StartupPath + @"\data\img\MessageBox.png");

            lblCaption.Parent = pic;
            lblCaption.Location = new Point((pic.Width / 2) - (lblCaption.Width / 2), 85);

            lblText.Parent = pic;
            lblText.Location = new Point((pic.Width / 2) - (lblText.Width / 2), lblCaption.Top + lblCaption.Height + 8);
        }
    }
}
