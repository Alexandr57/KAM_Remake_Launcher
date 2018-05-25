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
    public partial class AL7_frmDownloadProcess : Form
    {
        AL7_Class_Settings Settings;

        //Получение ссылки скачивания KAM Remake из сайта
        public string GetLinkKMR()
        {
            string html;
            using (var webClient = new WebClient())
            {
                webClient.Encoding = Encoding.UTF8;
                webClient.Headers.Add(HttpRequestHeader.UserAgent, ".NET Application");
                html = webClient.DownloadString(Settings.KMRSite);
            }
            var parser = new HtmlParser();
            var doc = parser.Parse(html);
            var Link = doc.QuerySelector(".entry-content > p:nth-child(6) > a.download-button").GetAttribute("href");
            return Link;
        }

        // Метод скачивание KAM Remake
        void DownloadKMR()
        {
            if (System.IO.File.Exists(Application.StartupPath + @"\data\" + Settings.FNInstallerKMR) == true)
            {
                btnInstKMR.Enabled = true;
                //btnAutoInstKMR.Enabled = true;
                bprgBar.Value = 100;
                lblCaptionDownloadProcess.Text = "Скачивание завершено!";
            }
            else
            {
                WebClient client = new WebClient();
                Uri uri = new Uri(GetLinkKMR());
                client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                bprgBar.Value = 0;
                lblCaptionDownloadProcess.Text = "Скачивание игры...";
                if (System.IO.File.Exists(Application.StartupPath + @"\data\" + Settings.FNInstallerKMR + ".downloads") == true)
                    System.IO.File.Delete(Application.StartupPath + @"\data\" + Settings.FNInstallerKMR + ".downloads");
                client.DownloadFileAsync(uri, Application.StartupPath + @"\data\" + Settings.FNInstallerKMR + ".downloads");
            }
        }

        void ReElements()
        {
            pic_DownloadProcess.Image = Image.FromFile(Application.StartupPath + @"\data\img\Dialogs.png");

            lblCaptionDownloadProcess.Parent = pic_DownloadProcess;
            lblCaptionDownloadProcess.Location = new Point(0, 62);
            lblCaptionDownloadProcess.Text = "...";

            bprgBar.BackgroundImage = Image.FromFile(Application.StartupPath + @"\data\img\prgBar.png");
            bprgBar.Parent = pic_DownloadProcess;
            bprgBar.Location = new Point(0, lblCaptionDownloadProcess.Top + lblCaptionDownloadProcess.Height + 20);

            tlpDownloadProcess.Parent = pic_DownloadProcess;
            tlpDownloadProcess.Dock = DockStyle.Bottom;

            pic_WaitDownloadProcess.Parent = pic_DownloadProcess;
            pic_WaitDownloadProcess.Location = new Point((pic_DownloadProcess.Width / 2) - (pic_WaitDownloadProcess.Width / 2), (pic_DownloadProcess.Height / 2) - (pic_WaitDownloadProcess.Height / 2) + 50);
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

        public DialogResult ShowDialog_DownloadProcess(string aCaption, AL7_Class_Settings aSettings)
        {
            this.Text = aCaption;
            Settings = aSettings;
            ReElements();
            DownloadKMR();
            return this.ShowDialog();
        }

        public AL7_frmDownloadProcess()
        {
            InitializeComponent();
        }

        private void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled == false)
            {
                System.IO.File.Move(Application.StartupPath + @"\data\" + Settings.FNInstallerKMR + ".downloads", Application.StartupPath + @"\data\" + Settings.FNInstallerKMR);
                DownloadKMR();
            }
        }

        private void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            bprgBar.Value = e.ProgressPercentage;
        }

        private void processStartInstall_Exited(object sender, EventArgs e)
        {
            BeginInvoke((MethodInvoker)(delegate
            {
                btnInstKMR.Enabled = true;
                //btnAutoInstKMR.Enabled = true;
                this.DialogResult = DialogResult.OK;
            }));
        }

        private void btnInstKMR_Click(object sender, EventArgs e)
        {
            btnInstKMR.Enabled = false;
            btnAutoInstKMR.Enabled = false;
            bprgBar.Value = 0;
            bprgBar.Visible = false;
            lblCaptionDownloadProcess.Text = "Установка игры...";
            pic_WaitDownloadProcess.Visible = true;

            if (System.IO.File.Exists(Application.StartupPath + @"\data\" + Settings.FNInstallerKMR) == true)
                StartInstallKMR(Application.StartupPath + @"\data\" + Settings.FNInstallerKMR);
            else
                this.DialogResult = DialogResult.Cancel;
        }
    }
}
