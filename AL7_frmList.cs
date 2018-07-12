using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KAM_Remake_Launcher
{
    public partial class AL7_frmList : Form
    {
        System.IO.DirectoryInfo[] ReturnDirNameCampaign;

        public DialogResult ShowMyDialog(string aCaption, in System.IO.DirectoryInfo[] aDirNameCampaigns, out string outDirNameCampaign)
        {
            this.ShowInTaskbar = false;
            this.Text = aCaption;
            lblCaption.Text = aCaption;

            ReturnDirNameCampaign = aDirNameCampaigns;

            if (ReturnDirNameCampaign.Length > 0)
            {
                foreach (var str in ReturnDirNameCampaign)
                    List.Items.Add(str.Name);

                List.SelectedIndex = 0;
            }
            else
            {
                outDirNameCampaign = "";
                return DialogResult.Cancel;
            }

            if (this.ShowDialog() == DialogResult.OK)
            {
                outDirNameCampaign = ReturnDirNameCampaign[List.SelectedIndex].FullName;
                return DialogResult.OK;
            }
            else
            {
                outDirNameCampaign = "";
                return DialogResult.Cancel;
            }
        }

        public AL7_frmList()
        {
            InitializeComponent();
        }

        private void AL7_frmList_Shown(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(Application.StartupPath + @"\data\img\BG_Mask.png");

            pic.Dock = DockStyle.Fill;
            pic.Image = Image.FromFile(Application.StartupPath + @"\data\img\Dialogs.png");

            lblCaption.Parent = pic;
            lblCaption.Location = new Point((pic.Width / 2) - (lblCaption.Width / 2), 65);

            List.Parent = pic;
            List.Location = new Point(8, lblCaption.Top + lblCaption.Height + 8);
            List.Width = pic.Width - 16;
            List.Height = pic.Height - 73 - lblCaption.Height - 8 - flowLayoutPanel.Height - 8;

        }

        private void List_DrawItem(object sender, DrawItemEventArgs e)
        {

        }
    }
}
