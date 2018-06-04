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
                    zip.CompressionLevel = Ionic.Zlib.CompressionLevel.BestCompression;
                    zip.ExtractProgress += zipProgressExtract;

                    zip.ExtractAll(aDirectoryСampaigns);
                }
            }).Start();
        }

        public void ShowDialog_ManageCampaigns(string aCaption, AL7_Class_Settings aSettings)
        {
            pic.Dock = DockStyle.Fill;
            pic.Image = Image.FromFile(Application.StartupPath + @"\data\img\Dialogs.png");
            bprgBar.Value = 0;

            this.BackgroundImage = Image.FromFile(Application.StartupPath + @"\data\img\BG_Mask.png");
            this.Text = aCaption;
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
                if (e.EventType == ZipProgressEventType.Extracting_AfterExtractAll)
                {
                    if (e.EntriesExtracted < e.EntriesTotal)
                        bprgBar.Value = e.EntriesExtracted * 100 / e.EntriesTotal;
                    else
                        bprgBar.Value = 0;
                }

            }));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog()
            {
                Description = "Выберите папку с кампанией для упаковки",
                ShowNewFolderButton = false
            };
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog()
                {
                    Title = "Введите имя архива",
                    Filter = "ZIP Архив|*.zip"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    bprgBar.Value = 0;
                    CreateArchiveСampaign(saveFileDialog.FileName, folderBrowserDialog.SelectedPath);
                }
            }
        }
    }
}
