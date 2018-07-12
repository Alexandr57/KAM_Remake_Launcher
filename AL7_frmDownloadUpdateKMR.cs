using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AngleSharp.Parser.Html;
using System.Net;

namespace KAM_Remake_Launcher
{
    public partial class AL7_frmDownloadUpdateKMR : Form
    {
        AL7_Class_Additional Additional;

        //Получение ссылки скачивания KAM Remake из сайта
        public string GetLinkKMR(bool aLinkUpdate = false)
        {
            string html;
            using (var webClient = new WebClient())
            {
                webClient.Encoding = Encoding.UTF8;
                webClient.Headers.Add(HttpRequestHeader.UserAgent, ".NET Application");
                html = webClient.DownloadString(Additional.KMRLauncher.KMRSite);
            }
            var parser = new HtmlParser();
            var doc = parser.Parse(html);
            var Link = "";
            if (aLinkUpdate)
                Link = doc.QuerySelector(".entry-content > table > tbody > tr:nth-child(2) > td:nth-child(4) > a").GetAttribute("href");
            else
                Link = doc.QuerySelector(".entry-content > table > tbody > tr:nth-child(1) > td:nth-child(4) > a").GetAttribute("href");
            return Link;
        }

        /// <summary>
        /// Метод скачивание полной версии KAM Remake
        /// </summary>
        void DownloadKMR()
        {
            if (System.IO.File.Exists(Application.StartupPath + @"\data\" + Additional.KMRLauncher.FNInstallerKMR) == true)
            {
                btnInstUpdKMR.Enabled = true;
                //btnAutoInstKMR.Enabled = true;
                bprgBar.Value = 100;
                lblCaptionDownloadProcess.Text = "Скачивание завершено!";
            }
            else
            {
                var client = new WebClient();
                var uri = new Uri(GetLinkKMR());
                client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileInstaller_Completed);
                client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgress_Changed);
                bprgBar.Value = 0;
                lblCaptionDownloadProcess.Text = "Скачивание игры...";
                client.DownloadFileAsync(uri, Application.StartupPath + @"\data\" + Additional.KMRLauncher.FNInstallerKMR + ".downloads");
            }
        }

        /// <summary>
        /// Метод скачивания обновления для KAM Remake
        /// </summary>
        void UpdateKMR()
        {
            if (System.IO.File.Exists(Application.StartupPath + @"\data\" + Additional.KMRLauncher.FNUpdateKMR) == true)
            {
                btnInstUpdKMR.Enabled = true;
                //btnAutoInstKMR.Enabled = true;
                bprgBar.Value = 100;
                lblCaptionDownloadProcess.Text = "Скачивание завершено!";
            }
            else
            {
                var client = new WebClient();
                var uri = new Uri(GetLinkKMR(true));
                client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileUpdater_Completed);
                client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgress_Changed);
                bprgBar.Value = 0;
                lblCaptionDownloadProcess.Text = "Обновления игры...";
                client.DownloadFileAsync(uri, Application.StartupPath + @"\data\" + Additional.KMRLauncher.FNUpdateKMR + ".downloads");
            }
        }

        void ReElements()
        {
            
            lblCaptionDownloadProcess.Text = "...";
        }

        void StartInstallKMR(string aFileNameGame)
        {
            System.Diagnostics.Process processStartInstall = new System.Diagnostics.Process()
            {
                StartInfo = new System.Diagnostics.ProcessStartInfo()
                {
                    FileName = aFileNameGame,
                    CreateNoWindow = true,
                    UseShellExecute = true,
                    WorkingDirectory = System.IO.Path.GetDirectoryName(aFileNameGame)
                },
                EnableRaisingEvents = true
            };

            processStartInstall.Exited += processStartInstall_Exited;

            processStartInstall.Start();
        }

        public DialogResult ShowMyDialog(string aCaption, in AL7_Class_Additional aAdditional, bool aUpdate = false)
        {
            this.ShowInTaskbar = false;
            this.Text = aCaption;
            lblCaption.Text = aCaption;
            Additional = aAdditional;
            ReElements();
            btnInstUpdKMR.Tag = aUpdate;
            if (aUpdate == true)
                UpdateKMR();
            else
                DownloadKMR();

            return this.ShowDialog();
        }

        public AL7_frmDownloadUpdateKMR()
        {
            InitializeComponent();
        }

        private void client_DownloadFileInstaller_Completed(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                var MessageBox = new AL7_frmMessageBox();
                if (MessageBox.ShowMyDialog("Скачка игры", "Произошла ошибка при скачке!\r\nХотите попробовать снова?", "Да", "Нет") == DialogResult.Yes)
                {
                    System.IO.File.Delete(Application.StartupPath + @"\data\" + Additional.KMRLauncher.FNInstallerKMR + ".downloads");
                    DownloadKMR();
                }
                else
                {
                    MessageBox.Dispose();
                    this.DialogResult = DialogResult.Cancel;
                }
            }
            else
            {
                if (e.Cancelled == true)
                {
                    var MessageBox = new AL7_frmMessageBox();
                    MessageBox.ShowMyDialog("Скачка игры", "Скачка была отменена!");
                    MessageBox.Dispose();
                }
                else
                {
                    System.IO.File.Move(Application.StartupPath + @"\data\" + Additional.KMRLauncher.FNInstallerKMR + ".downloads", Application.StartupPath + @"\data\" + Additional.KMRLauncher.FNInstallerKMR);
                    DownloadKMR();
                }
            }
        }

        private void client_DownloadFileUpdater_Completed(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                var MessageBox = new AL7_frmMessageBox();
                if (MessageBox.ShowMyDialog("Скачка обновления игры", "Произошла ошибка при скачке!\r\nХотите попробовать снова?", "Да", "Нет") == DialogResult.Yes)
                {
                    System.IO.File.Delete(Application.StartupPath + @"\data\" + Additional.KMRLauncher.FNUpdateKMR + ".downloads");
                    UpdateKMR();
                }
                else
                {
                    MessageBox.Dispose();
                    this.DialogResult = DialogResult.Cancel;
                }
            }
            else
            {
                if (e.Cancelled == true)
                {
                    var MessageBox = new AL7_frmMessageBox();
                    MessageBox.ShowMyDialog("Скачка обновления игры", "Скачка была отменена!");
                    MessageBox.Dispose();
                }
                else
                {
                    System.IO.File.Move(Application.StartupPath + @"\data\" + Additional.KMRLauncher.FNUpdateKMR + ".downloads", Application.StartupPath + @"\data\" + Additional.KMRLauncher.FNUpdateKMR);
                    UpdateKMR();
                }
            }
        }

        private void client_DownloadProgress_Changed(object sender, DownloadProgressChangedEventArgs e)
        {
            bprgBar.Value = e.ProgressPercentage;
        }

        private void processStartInstall_Exited(object sender, EventArgs e)
        {
            BeginInvoke((MethodInvoker)(delegate
            {
                btnInstUpdKMR.Enabled = true;
                //btnAutoInstKMR.Enabled = true;
                this.DialogResult = DialogResult.OK;
            }));
        }

        private void btnInstUpdKMR_Click(object sender, EventArgs e)
        {
            Additional.PlaySE(Additional.FNseClick);
            btnInstUpdKMR.Enabled = false;
            btnAutoInstUpdKMR.Enabled = false;
            bprgBar.Value = 0;
            bprgBar.Visible = false;
            pic_WaitDownloadProcess.Visible = true;

            if (Convert.ToBoolean(btnInstUpdKMR.Tag) == true)
            {
                lblCaptionDownloadProcess.Text = "Обновления игры...";
                if (System.IO.File.Exists(Application.StartupPath + @"\data\" + Additional.KMRLauncher.FNUpdateKMR) == true)
                    StartInstallKMR(Application.StartupPath + @"\data\" + Additional.KMRLauncher.FNUpdateKMR);
                else
                    this.DialogResult = DialogResult.Cancel;
            }
            else
            {
                lblCaptionDownloadProcess.Text = "Установка игры...";
                if (System.IO.File.Exists(Application.StartupPath + @"\data\" + Additional.KMRLauncher.FNInstallerKMR) == true)
                    StartInstallKMR(Application.StartupPath + @"\data\" + Additional.KMRLauncher.FNInstallerKMR);
                else
                    this.DialogResult = DialogResult.Cancel;
            }
        }

        private void AL7_frmDownloadProcess_Shown(object sender, EventArgs e)
        {

            pic_DownloadProcess.Image = Image.FromFile(Application.StartupPath + @"\data\img\Dialogs.png");

            lblCaption.Parent = pic_DownloadProcess;
            lblCaption.Location = new Point((pic_DownloadProcess.Width / 2) - (lblCaption.Width / 2), 65);

            lblCaptionDownloadProcess.Parent = pic_DownloadProcess;
            lblCaptionDownloadProcess.Location = new Point((pic_DownloadProcess.Width / 2) - (lblCaptionDownloadProcess.Width / 2), lblCaption.Top + lblCaption.Height + 8);

            bprgBar.BackgroundImage = Image.FromFile(Application.StartupPath + @"\data\img\prgBar.png");
            bprgBar.Parent = pic_DownloadProcess;
            bprgBar.Location = new Point((pic_DownloadProcess.Width / 2) - (bprgBar.Width / 2), lblCaptionDownloadProcess.Top + lblCaptionDownloadProcess.Height + 20);

            tlpDownloadProcess.Parent = pic_DownloadProcess;
            tlpDownloadProcess.Dock = DockStyle.Bottom;

            pic_WaitDownloadProcess.Parent = pic_DownloadProcess;
            pic_WaitDownloadProcess.Location = new Point((pic_DownloadProcess.Width / 2) - (pic_WaitDownloadProcess.Width / 2), (pic_DownloadProcess.Height / 2) - (pic_WaitDownloadProcess.Height / 2) + 50);
        }
    }
}
