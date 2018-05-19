using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using AngleSharp.Parser.Html;
using System.Net;
using Microsoft.Win32;
using System.Xml.Serialization;
using System.IO;


namespace KAM_Remake_Launcher
{
    public partial class frmMain : Form
    {
        const string KMRSite = "http://www.kamremake.com/download/";

        const int DelayStart = 150;

        const int cTick = 10;

        string Tick;

        byte idxAnim;

        string PathKMR;

        Class_Settings Settings = new Class_Settings();

        //Запись настроек в файл
        public void WriteXml()
        {
            XmlSerializer ser = new XmlSerializer(typeof(Class_Settings));
            TextWriter writer = new StreamWriter(Settings.XMLFileName);
            ser.Serialize(writer, Settings);
            writer.Close();
        }

        //Чтение настроек из файла
        public void ReadXml()
        {
            if (File.Exists(Settings.XMLFileName))
            {
                XmlSerializer ser = new XmlSerializer(typeof(Class_Settings));
                TextReader reader = new StreamReader(Settings.XMLFileName);
                Settings = ser.Deserialize(reader) as Class_Settings;
                reader.Close();
            }
            else { }
        }

        void PlaySE(string aFileName)
        {
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = aFileName;
            sp.LoadAsync();
            sp.Play();
        }

        string GetNewVersionKMR()
        {
            string html;
            using (var webClient = new WebClient())
            {
                webClient.Encoding = Encoding.UTF8;
                webClient.Headers.Add(HttpRequestHeader.UserAgent, ".NET Application");
                html = webClient.DownloadString(KMRSite);
            }
            var parser = new HtmlParser();
            var doc = parser.Parse(html);

            var text = doc.QuerySelector(".entry-content > p:nth-child(5) > strong");

            return text.TextContent.Substring(text.TextContent.ToLower().IndexOf("kam remake ") + 11, 5);
        }

        string GetLinkKMR()
        {
            string html;
            using (var webClient = new WebClient())
            {
                webClient.Encoding = Encoding.UTF8;
                webClient.Headers.Add(HttpRequestHeader.UserAgent, ".NET Application");
                html = webClient.DownloadString(KMRSite);
            }
            var parser = new HtmlParser();
            var doc = parser.Parse(html);
            var Link = doc.QuerySelector(".entry-content > p:nth-child(6) > a.download-button").GetAttribute("href");
            return Link;
        }

        void DownloadKMR()
        {
            WebClient client = new WebClient();
            Uri uri = new Uri(GetLinkKMR());
            client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
            client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
            bprgBar.Value = 0;
            lblCaptionDownloadProcess.Text = "Скачивание игры...";
            client.DownloadFileAsync(uri, Application.StartupPath + @"\data\" + Settings.FNInstallerKMR + ".downloads");
        }

        void InstallKMR(bool aAutoInstall)
        {
            System.Diagnostics.Process processInstallerKMR = new System.Diagnostics.Process();
            //processInstallerKMR
        }

        bool GetVersionKMR(out string oVerKMR)
        {
            var TextVer = "";
            var b = false;
            using (var hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32))
            using (var key = hklm.OpenSubKey(@"SOFTWARE\JOYMANIA Entertainment\KnightsandMerchants TPR"))
            {
                try
                {
                    TextVer = key.GetValue("RemakeVersion").ToString();
                    b = true;
                }
                catch
                {
                    TextVer = "не найдена";
                }
            }
            oVerKMR = TextVer;
            return b;
        }

        bool GetFileNameKMR()
        {
            OpenFileDialog ofdKMR = new OpenFileDialog()
            {
                Title = "Выберите игру \"KAM Remake\" ",
                Filter = "KAM Remake|*.exe",
            };

            if (ofdKMR.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(ofdKMR.FileName))
                {
                    Settings.FileNameKMR = ofdKMR.FileName;
                    return true;
                }
                else return false;
            }
            else return false;
        }

        bool ReGameElements(bool aBool)
        {
            btnStartKMR.Visible = true;

            if (aBool == true)
            {
                PathKMR = Path.GetFullPath(Settings.FileNameKMR);
                btnStartKMR.Text = "Запустить KAM Remake";
                btnStartKMR.Tag = 1;
            }
            else
            {
                btnStartKMR.Text = "Установить KAM Remake";
                btnStartKMR.Tag = 0;
            }

            return aBool;
        }

        bool ReGameElements2(bool aBool)
        {
            if (aBool == true)
            {
                ReGameElements(true);
            }
            else
            {
                btnStartKMR.Visible = true;
                btnStartKMR.Text = "Проверка наличия KAM Remake";
                btnStartKMR.Tag = 2;
            }

            return aBool;
        }

        void SetPathKMR()
        {
            var KMRVer = "";
            frmVerGame VerGame = new frmVerGame();
            if (GetVersionKMR(out KMRVer) == true)
            {
                lblKMRVer.Text = "Версия KAM Remake: " + KMRVer;
                using (var hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32))
                using (var key = hklm.OpenSubKey(@"SOFTWARE\JOYMANIA Entertainment\KnightsandMerchants TPR"))
                {
                    try
                    {
                        Settings.FileNameKMR = key.GetValue("RemakePath").ToString();
                    }
                    catch
                    {
                        Settings.FileNameKMR = Settings.FileNameKMR;
                    }
                }

                if (File.Exists(Settings.FileNameKMR))
                {
                    ReGameElements(true);
                }
                else
                {
                    if (VerGame.ShowDialog_VerGame("Игра \"KAM Remake\" не найдена!", "Версия игры найдена, но папку с игрой найти не удалось! Хотите ли указать путь к игре?\r\nНажмите \"Да\" чтобы открыть диалог выбора игры.", "Да", "Нет") == DialogResult.Yes)
                    {
                        ReGameElements2(GetFileNameKMR());
                    }
                    else
                    {
                        ReGameElements2(false);
                    }
                }
            }
            else
            {
                if (File.Exists(Settings.FileNameKMR))
                {
                    ReGameElements(true);
                    
                    lblKMRVer.Text = "Версия KAM Remake: Неофициальная";
                }
                else
                {
                    if (VerGame.ShowDialog_VerGame("Игра \"KAM Remake\" не найдена!", "Версия игры не найдена! Хотите ли указать путь к игре?\r\nНажмите \"Да\" чтобы открыть диалог выбора игры.", "Да", "Нет") == DialogResult.Yes)
                    {
                        if (ReGameElements(GetFileNameKMR()) == true)
                        {
                            lblKMRVer.Text = "Версия KAM Remake: Неофициальная";
                        }
                        else
                        {
                            lblKMRVer.Text = "Игра не найдена";
                        }
                    }
                    else
                    {
                        ReGameElements(false);
                        lblKMRVer.Text = "Игра не найдена";
                    }
                }
            }
        }

        public frmMain()
        {
            InitializeComponent();

            ReadXml();

            pic.Parent = pic_Mask;
            pic.Dock = DockStyle.Fill;
            lblKMRVer.Parent = pic;
            lblKMRVer.Width = 620;
            lblKMRVer.Location = new Point(10, 10);
            GetLinkKMR();
            btnStartKMR.Parent = pic_Mask;
            btnStartKMR.BringToFront();
            btnStartKMR.Location = new Point((this.Width / 2) - (btnStartKMR.Width / 2), lblKMRVer.Top + lblKMRVer.Height + 8);
            pic_DownloadProcess.Parent = pic;
            pic_DownloadProcess.Location = new Point((this.Width / 2) - (pic_DownloadProcess.Width / 2), (this.Height / 2) - (pic_DownloadProcess.Height / 2));
            pic_DownloadProcess.BringToFront();
            lblCaptionDownloadProcess.Parent = pic_DownloadProcess;
            lblCaptionDownloadProcess.Location = new Point(0, 62);
            lblCaptionDownloadProcess.Text = "Установка завершена";
            bprgBar.Parent = pic_DownloadProcess;
            bprgBar.Location = new Point(0, lblCaptionDownloadProcess.Top + lblCaptionDownloadProcess.Height + 20);
            tlpDownloadProcess.Parent = pic_DownloadProcess;
            tlpDownloadProcess.Dock = DockStyle.Bottom;
            pic_WaitDownloadProcess.Parent = pic_DownloadProcess;
            pic_WaitDownloadProcess.Location = new Point((pic_DownloadProcess.Width / 2) - (pic_WaitDownloadProcess.Width / 2), (pic_DownloadProcess.Height / 2) - (pic_WaitDownloadProcess.Height / 2) + 50);

            Tick = "0";
            idxAnim = 0;
            tmrAnim.Interval = cTick;

            SetPathKMR();

            tmrAnim.Start();
        }


        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            WriteXml();
        }

        private void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            System.IO.File.Move(Application.StartupPath + @"\data\" + Settings.FNInstallerKMR + ".downloads", Application.StartupPath + @"\data\" + Settings.FNInstallerKMR);
            btnInstKMR.Enabled = true;
            //btnAutoInstKMR.Enabled = true;
            bprgBar.Value = 100;
            lblCaptionDownloadProcess.Text = "Скачивание завершено!";
        }

        private void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            bprgBar.Value = e.ProgressPercentage;
        }

        private void tmrAnim_Tick(object sender, EventArgs e)
        {
            Tick = Convert.ToString((Convert.ToInt64(Tick) + 1));

            if (idxAnim == 0)
            {
                PlaySE(Application.StartupPath + @"\data\se\Start.wav");
                idxAnim++;
            }
            else if (idxAnim == 1)
            {
                if (Convert.ToInt64(Tick) % DelayStart == 0)
                    idxAnim++;
            }
            else if (idxAnim == 2)
            {
                if (pic_1.Left > ((-pic_1.Width) + 10))
                    pic_1.Left -= 5;
                else if (pic_1.Left < ((-pic_1.Width) + 10))
                    pic_1.Left = ((-pic_1.Width) + 10);

                if (pic_2.Left < ((pic_2.Width* 2) - 10))
                    pic_2.Left += 5;
                else if (pic_2.Left > ((pic_2.Width * 2) - 10))
                    pic_2.Left = ((pic_2.Width * 2) - 10);

                if ((pic_1.Left == ((-pic_1.Width) + 10)) && (pic_2.Left == (pic_2.Width - 10)))
                    tmrAnim.Stop();
            }
        }

        private void btnStartKMR_Click(object sender, EventArgs e)
        {
            PlaySE(Application.StartupPath + @"\data\se\Click.wav");
            if ((int)btnStartKMR.Tag == 0)
            {
                pic_DownloadProcess.Visible = true;
                DownloadKMR();
                btnStartKMR.Visible = false;
            }

        }

        private void btnInstKMR_Click(object sender, EventArgs e)
        {
            btnInstKMR.Enabled = false;
            btnAutoInstKMR.Enabled = false;
            bprgBar.Value = 0;
            lblCaptionDownloadProcess.Text = "Установка игры...";
            pic_WaitDownloadProcess.Visible = true;
        }
    }
}
