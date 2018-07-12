using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ionic.Zip;
namespace KAM_Remake_Launcher
{
    public partial class AL7_frmManageCampaigns : Form
    {
        AL7_Class_Additional Additional;

        void CreateArchiveСampaign(string aFileName, string aDirectoryСampaign)
        {
            new System.Threading.Thread(() => {
                using (ZipFile zip = new ZipFile())
                {
                    zip.CompressionLevel = Ionic.Zlib.CompressionLevel.BestCompression;
                    zip.SaveProgress += zipProgressSave;

                    zip.AddDirectoryByName(System.IO.Path.GetFileName(aDirectoryСampaign));
                    zip.AddDirectory(aDirectoryСampaign, System.IO.Path.GetFileName(aDirectoryСampaign));
                    zip.Save(aFileName);
                }
            }).Start();
        }

        void ExtractArchiveСampaign(string aDirectoryСampaigns, string aFileName)
        {
            new System.Threading.Thread(() => {
                using (ZipFile zip = new ZipFile(aFileName))
                {
                    zip.ExtractProgress += zipProgressExtract;

                    zip.ExtractAll(aDirectoryСampaigns);
                }
            }).Start();
        }

        public void ShowMyDialog(string aCaption, in AL7_Class_Additional aAdditional)
        {
            this.ShowInTaskbar = false;
            this.Text = aCaption;
            lblCaption.Text = aCaption;
            Additional = aAdditional;
            this.ShowDialog();
        }

        public AL7_frmManageCampaigns()
        {
            InitializeComponent();
        }

        private void zipProgressSave(object sender, SaveProgressEventArgs e)
        {

            BeginInvoke((MethodInvoker)(delegate
            {
                if (e.EventType == ZipProgressEventType.Saving_AfterWriteEntry)
                {
                    bprgBar.Value = e.EntriesSaved * 100 / e.EntriesTotal;
                }
                else if (e.EventType == ZipProgressEventType.Saving_Completed)
                {
                    bprgBar.Value = 0;
                }
            }));
            
        }

        private void zipProgressExtract(object sender, ExtractProgressEventArgs e)
        {
            BeginInvoke((MethodInvoker)(delegate
            {
                if (e.EventType == ZipProgressEventType.Extracting_AfterExtractEntry)
                {
                    if (e.EntriesExtracted < e.EntriesTotal)
                        bprgBar.Value = e.EntriesExtracted * 100 / e.EntriesTotal;
                    else
                        bprgBar.Value = 0;
                }

            }));
        }

        private void btnZipCampaigns_Click(object sender, EventArgs e)
        {
            Additional.PlaySE(Additional.FNseClick);
            System.IO.DirectoryInfo Dir = new System.IO.DirectoryInfo(Additional.PathKMR + Additional.KMRLauncher.DirCampaign);
            var DirCampaigns = Dir.GetDirectories();

            var frmList = new AL7_frmList();

            var GetDIRCampaign = "";

            if (frmList.ShowMyDialog("Выбор кампании", DirCampaigns, out GetDIRCampaign) == DialogResult.OK)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog()
                {
                    Title = "Введите имя архива",
                    Filter = "ZIP Архив|*.zip"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    bprgBar.Value = 0;
                    CreateArchiveСampaign(saveFileDialog.FileName, GetDIRCampaign);
                }
            }
        }

        private void btnExtractCampaigns_Click(object sender, EventArgs e)
        {
            Additional.PlaySE(Additional.FNseClick);
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog()
            {
                Description = "Выберите папку куда установить кампанию",
                ShowNewFolderButton = false
            };

            folderBrowserDialog.SelectedPath = Additional.PathKMR + Additional.KMRLauncher.DirCampaign;

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog()
                {
                    Title = "Выберите архив с кампанией",
                    Filter = "ZIP Архив|*.zip"
                };

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    bprgBar.Value = 0;
                    ExtractArchiveСampaign(folderBrowserDialog.SelectedPath, openFileDialog.FileName);
                }
            }
        }

        private void AL7_frmManageCampaigns_Shown(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(Application.StartupPath + @"\data\img\BG_Mask.png");

            pic.Dock = DockStyle.Fill;
            pic.Image = Image.FromFile(Application.StartupPath + @"\data\img\Dialogs.png");

            lblCaption.Parent = pic;
            lblCaption.Location = new Point((pic.Width / 2) - (lblCaption.Width / 2), 65);

            btnExtractCampaigns.Location = new Point((this.Width / 2) - (btnExtractCampaigns.Width / 2), lblCaption.Top + lblCaption.Height + 8);

            btnZipCampaigns.Location = new Point((this.Width / 2) - (btnZipCampaigns.Width / 2), btnExtractCampaigns.Top + btnExtractCampaigns.Height + 8);

            btnClose.Location = new Point((this.Width / 2) - (btnClose.Width / 2), this.Height - btnClose.Height - 12);

            bprgBar.Value = 0;
            bprgBar.Parent = pic;
            bprgBar.Location = new Point((pic.Width / 2) - (lblCaption.Width / 2), btnClose.Top - btnClose.Height - 8);
        }
    }
}
