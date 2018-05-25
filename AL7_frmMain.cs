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
    public partial class AL7_frmMain : Form
    {
        //Имя файла настроек
        public string XMLFileName = "Settings.Xml";

        //Задержка перед стартом анимации 100 = 1 секунде если брать в расщет интервал 10
        const int DelayStart = 150;

        //Интерал таймера 1000 = 1 секунда. Каждые 10 милисекунд
        const int cTick = 10;

        //Переменная содержащие количество пройденных тиков через заданный интервал таймера
        string Tick;

        //Переменная индекса анимации
        byte idxAnim;

        //Папка с расположением KAM Remake
        string PathKMR;

        //Возможное имя файла KAM Remake
        string FNKMR = "KaM_Remake.exe";

        //Переменная класса с настройкми
        AL7_Class_Settings Settings = new AL7_Class_Settings();

        //Запись настроек в файл
        public void WriteXml()
        {
            XmlSerializer ser = new XmlSerializer(typeof(AL7_Class_Settings));
            TextWriter writer = new StreamWriter(XMLFileName);
            ser.Serialize(writer, Settings);
            writer.Close();
        }

        //Чтение настроек из файла
        public void ReadXml()
        {
            if (File.Exists(XMLFileName))
            {
                XmlSerializer ser = new XmlSerializer(typeof(AL7_Class_Settings));
                TextReader reader = new StreamReader(XMLFileName);
                Settings = ser.Deserialize(reader) as AL7_Class_Settings;
                reader.Close();
            }
            else { }
        }

        //Воспроизведение звука WAV
        void PlaySE(string aFileName)
        {
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = aFileName;
            sp.LoadAsync();
            sp.Play();
        }

        //Получение новой версии KAM Remake из сайта
        string GetNewVersionKMR()
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

            var text = doc.QuerySelector(".entry-content > p:nth-child(5) > strong");

            return text.TextContent.Substring(text.TextContent.ToLower().IndexOf("kam remake ") + 11, 5);
        }

        //Метод установки KAM Remake
        void InstallKMR(bool aAutoInstall)
        {
            System.Diagnostics.Process processInstallerKMR = new System.Diagnostics.Process();
            //processInstallerKMR
        }

        Button btnStartGameProcess;

        //Запуск игры
        void StartGame(string aFileNameGame, string aArguments = "")
        {
            System.Diagnostics.Process processStartGame = new System.Diagnostics.Process()
            {
                StartInfo = new System.Diagnostics.ProcessStartInfo()
                {
                    FileName = aFileNameGame,
                    Arguments = aArguments,
                    CreateNoWindow = true,
                    UseShellExecute = true,
                    WindowStyle = System.Diagnostics.ProcessWindowStyle.Maximized,
                    WorkingDirectory = Path.GetDirectoryName(aFileNameGame)
                },
                EnableRaisingEvents = true
            };

            processStartGame.Exited += processStartGame_Exited;

            btnStartGameProcess.Enabled = false;

            processStartGame.Start();
        }

        //Проверка на то что игра является KAM Remake
        bool CheckFNKMR(string aFileNameKMR)
        {
            return ((File.Exists(aFileNameKMR) == true)
                    && (File.Exists(Path.GetDirectoryName(aFileNameKMR) + @"\KM_TextIDs.inc") == true)
                    && (File.Exists(Path.GetDirectoryName(aFileNameKMR) + @"\libzplay.dll") == true)
                    && (Directory.Exists(Path.GetDirectoryName(aFileNameKMR) + @"\Campaigns") == true)
                    && (Directory.Exists(Path.GetDirectoryName(aFileNameKMR) + @"\data") == true));
        }

        //Проверка на наличия лицензия игры и по воззможности получения папки с игрой
        bool CheckLcenseKMR(out string outFNKMR)
        {
            var b = false;
            using (var hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32))
            using (var key = hklm.OpenSubKey(@"SOFTWARE\JOYMANIA Entertainment\KnightsandMerchants TPR"))
            {
                b = (key.GetValue("Version") != null) && (key.GetValue("RemakeVersion") != null);

                try
                {
                    outFNKMR = key.GetValue("RemakeDIR").ToString() + @"\" + FNKMR;
                }
                catch
                {
                    outFNKMR = "";
                }
            }
            return b;
        }

        //Получение версии KAM Remake
        string GetVersionKMR()
        {
            var TextVer = "";
            using (var hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32))
            using (var key = hklm.OpenSubKey(@"SOFTWARE\JOYMANIA Entertainment\KnightsandMerchants TPR"))
            {
                try
                {
                    TextVer = key.GetValue("RemakeVersion").ToString();
                }
                catch
                {
                    TextVer = "";
                }
            }

            return TextVer;
        }

        //Получения имени файла KAM Remake
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
                    if (CheckFNKMR(ofdKMR.FileName))
                    {
                        Settings.FileNameKMR = ofdKMR.FileName;
                        return true;
                    }
                    else return false;
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
                btnOtherEditorStart.Enabled = true;
            }
            else
            {
                btnStartKMR.Text = "Установить KAM Remake";
                btnStartKMR.Tag = 0;
                btnOtherEditorStart.Enabled = false;
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
                btnOtherEditorStart.Enabled = false;
            }

            return aBool;
        }

        bool SetPathKMR()
        {
            if (CheckFNKMR(Settings.FileNameKMR) == true)
            {
                ReGameElements(true);
                return true;
            }

            var FileNameKMR = Settings.FileNameKMR;


            if (CheckLcenseKMR(out FileNameKMR) == true)
            {
                lblKMRVer.Text = "Версия KAM Remake: " + GetVersionKMR();
                if (CheckFNKMR(FileNameKMR) == true)
                {
                    Settings.FileNameKMR = FileNameKMR;
                    ReGameElements2(true);
                    return true;
                }
                else
                {
                    var FrmVerGame = new AL7_frmVerGame();
                    if (FrmVerGame.ShowDialog_VerGame("Директория игры не найдена", "У вас лицензия, но папку с игрой найти не удалось!\r\nХотите указать папку с игрой?", "Да", "Нет") == DialogResult.Yes)
                    {
                        if (GetFileNameKMR() == true)
                        {
                            ReGameElements2(true);
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Игра указана неверно!", "Директория игры не найдена", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            ReGameElements2(false);
                            return false;
                        }
                    }
                    else
                    {
                        ReGameElements2(false);
                        return false;
                    }
                }
            }
            else
            {
                var FrmVerGame = new AL7_frmVerGame();
                if (FrmVerGame.ShowDialog_VerGame("Директория игры не найдена", "У нет лицензии!\r\nХотите указать папку с игрой?", "Да", "Нет") == DialogResult.Yes)
                {
                    if (GetFileNameKMR() == true)
                    {
                        lblKMRVer.Text = "Версия KAM Remake: ???";
                        ReGameElements(true);
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Игра указана неверно!", "Директория игры не найдена", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ReGameElements(false);
                        return false;
                    }
                }
                else
                {
                    ReGameElements(false);
                    return false;
                }
            }
        }

        void ReElements()
        {
            pic_1.Image = Image.FromFile(Application.StartupPath + @"\data\img\BG_1.png");
            pic_2.Image = Image.FromFile(Application.StartupPath + @"\data\img\BG_2.png");

            pic_Mask.Image = Image.FromFile(Application.StartupPath + @"\data\img\BG_Mask.png");

            pic.Image = Image.FromFile(Application.StartupPath + @"\data\img\BG.png");
            pic.Parent = pic_Mask;
            pic.Dock = DockStyle.Fill;

            lblKMRVer.Parent = pic;
            lblKMRVer.Width = 620;
            lblKMRVer.Location = new Point(10, 10);

            btnStartKMR.Parent = pic_Mask;
            btnStartKMR.Location = new Point((this.Width / 2) - (btnStartKMR.Width / 2), lblKMRVer.Top + lblKMRVer.Height + 8);
            btnStartKMR.BringToFront();

            btnOtherEditorStart.Parent = pic_Mask;
            btnOtherEditorStart.Location = new Point((this.Width / 2) - (btnStartKMR.Width / 2), btnStartKMR.Top + btnStartKMR.Height + 8);
            btnOtherEditorStart.BringToFront();

            pnlOtherEditor.Parent = pic_Mask;
            pnlOtherEditor.BackgroundImage = Image.FromFile(Application.StartupPath + @"\data\img\BG_Mask.png");
            pnlOtherEditor.Location = new Point((pic.Width / 2) - (pnlOtherEditor.Width / 2), (pic.Height / 2) - (pnlOtherEditor.Height / 2));
            pnlOtherEditor.BringToFront();

            picOtherEditor.Parent = pnlOtherEditor;
            picOtherEditor.Image = Image.FromFile(Application.StartupPath + @"\data\img\Dialogs.png");
            picOtherEditor.Dock = DockStyle.Fill;
        }

        public AL7_frmMain()
        {
            InitializeComponent();

            ReadXml();

            ReElements();

            Tick = "0";
            idxAnim = 0;
            tmrAnim.Interval = cTick;

            if (SetPathKMR() == true)
                PathKMR = Path.GetDirectoryName(Settings.FileNameKMR);

            tmrAnim.Start();
        }


        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            WriteXml();
        }

        

        private void processStartGame_Exited(object sender, EventArgs e)
        {
            BeginInvoke((MethodInvoker)(delegate 
            {
                btnStartGameProcess.Enabled = true;
                btnStartGameProcess = null;
            }));
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
                var frmDownloadProcess = new AL7_frmDownloadProcess();
                if (frmDownloadProcess.ShowDialog_DownloadProcess("Скачивание и установка игры", Settings) == DialogResult.OK)
                {
                    if (SetPathKMR() == true)
                        PathKMR = Path.GetDirectoryName(Settings.FileNameKMR);
                }
                else
                {
                    
                }
            }
            else if((int)btnStartKMR.Tag == 1)
            {
                btnStartGameProcess = btnStartKMR;
                StartGame(Settings.FileNameKMR);
            }
            else if ((int)btnStartKMR.Tag == 2)
            {
                if (SetPathKMR() == true)
                    PathKMR = Path.GetDirectoryName(Settings.FileNameKMR);
            }

        }

        private void btnOtherEditorStart_Click(object sender, EventArgs e)
        {
            PlaySE(Application.StartupPath + @"\data\se\Click.wav");
            pnlOtherEditor.Visible = true;
        }

        private void btnClosePnlOtherEditor_Click(object sender, EventArgs e)
        {
            PlaySE(Application.StartupPath + @"\data\se\Click.wav");
            pnlOtherEditor.Visible = false;
        }
    }
}
