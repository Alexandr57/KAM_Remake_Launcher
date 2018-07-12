using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using Microsoft.Win32;
using System.IO;


namespace KAM_Remake_Launcher
{
    public partial class AL7_frmMain : Form
    {
        AL7_Class_Additional Additional;

        /// <summary>
        /// Переменная содержащие количество пройденных тиков через заданный интервал таймера
        /// </summary>
        string Tick;

        /// <summary>
        /// Переменная индекса анимации
        /// </summary>
        byte idxAnim;

        /// <summary>
        /// Переменная запрета запуска 2х программ/игр
        /// </summary>
        bool boolBtnStartGameProcess;

        /// <summary>
        /// Кнопка которая становится неактивной при запуске KAM или KMR
        /// </summary>
        Button btnStartGameProcess;

        /// <summary>
        /// Запуск игры
        /// </summary>
        /// <param name="aFileNameGame">Имя файла запускаемой игры/программы</param>
        /// <param name="aArguments">Параметры запуска</param>
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

            if (boolBtnStartGameProcess == true)
            {
                processStartGame.Exited += processStartGame_Exited;

                btnStartGameProcess.Enabled = false;
            }

            processStartGame.Start();
        }

        /// <summary>
        /// Получения имени файла KAM Remake
        /// </summary>
        /// <returns>Возвращает истину если игра указана и указана верно</returns>
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
                    if (Additional.CheckFNKMR(ofdKMR.FileName))
                    {
                        Additional.Settings.FileNameKMR = ofdKMR.FileName;
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
                btnStartKMR.Text = "Запустить KAM Remake";
                btnStartKMR.Tag = 1;
                btnStartOtherEditor.Enabled = true;
                btnManageCampaigns.Enabled = true;
            }
            else
            {
                btnStartKMR.Text = "Установить KAM Remake";
                btnStartKMR.Tag = 0;
                btnStartOtherEditor.Enabled = false;
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
                btnStartOtherEditor.Enabled = false;
            }

            return aBool;
        }

        bool SetPathKMR()
        {
            btnStartKAM.Enabled = Additional.GetFileNameKAM();

            if (Additional.CheckFNKMR(Additional.Settings.FileNameKMR) == true)
            {
                lblKMRVer.Text = "Версия KAM Remake: " + Additional.GetVersionKMR();
                ReGameElements(true);
                return true;
            }

            var FileNameKMR = Additional.Settings.FileNameKMR;


            if (Additional.CheckLcenseKMR(out FileNameKMR) == true)
            {
                lblKMRVer.Text = "Версия KAM Remake: " + Additional.GetVersionKMR();
                if (Additional.CheckFNKMR(FileNameKMR) == true)
                {
                    Additional.Settings.FileNameKMR = FileNameKMR;
                    ReGameElements2(true);
                    return true;
                }
                else
                {
                    var FrmVerGame = new AL7_frmMessageBox();
                    if (FrmVerGame.ShowMyDialog("Директория игры не найдена", "У вас лицензия, но папку с игрой найти не удалось!\r\nХотите указать папку с игрой?", "Да", "Нет") == DialogResult.Yes)
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
                var FrmVerGame = new AL7_frmMessageBox();
                if (FrmVerGame.ShowMyDialog("Директория игры не найдена", "У вас нет лицензии или игра не установленна!\r\nХотите указать папку с игрой?", "Да", "Нет") == DialogResult.Yes)
                {
                    if (GetFileNameKMR() == true)
                    {
                        lblKMRVer.Text = "Версия KAM Remake: ???";
                        ReGameElements(true);
                        return true;
                    }
                    else
                    {
                        lblKMRVer.Text = "Игра не найдена!";
                        MessageBox.Show("Игра указана неверно!", "Директория игры не найдена", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Environment.Exit(0);
                        ReGameElements(false);
                        return false;
                    }
                }
                else
                {
                    ReGameElements(false);
                    Environment.Exit(0);
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

            btnStartKAM.Parent = pic_Mask;
            btnStartKAM.Location = new Point((this.Width / 2) - (btnStartKAM.Width / 2), lblKMRVer.Top + lblKMRVer.Height + 8);
            btnStartKAM.BringToFront();

            btnStartKMR.Parent = pic_Mask;
            btnStartKMR.Location = new Point((this.Width / 2) - (btnStartKMR.Width / 2), btnStartKAM.Top + btnStartKAM.Height + 8);
            btnStartKMR.BringToFront();

            btnUpdateKMR.Parent = pic_Mask;
            btnUpdateKMR.Location = new Point((this.Width / 2) - (btnUpdateKMR.Width / 2), pic.Height - btnUpdateKMR.Height - 18);
            btnUpdateKMR.BringToFront();

            btnStartOtherEditor.Parent = pic_Mask;
            btnStartOtherEditor.Location = new Point((this.Width / 2) - (btnStartOtherEditor.Width / 2), btnStartKMR.Top + btnStartKMR.Height + 8);
            btnStartOtherEditor.BringToFront();

            btnManageCampaigns.Parent = pic_Mask;
            btnManageCampaigns.Location = new Point((this.Width / 2) - (btnManageCampaigns.Width / 2), btnStartOtherEditor.Top + btnStartOtherEditor.Height + 8);
            btnManageCampaigns.BringToFront();

            pnlOtherEditor.Parent = pic_Mask;
            pnlOtherEditor.BackgroundImage = Image.FromFile(Application.StartupPath + @"\data\img\BG_Mask.png");
            pnlOtherEditor.Size = new Size(360, 397);
            pnlOtherEditor.Location = new Point((pic.Width / 2) - (pnlOtherEditor.Width / 2), (pic.Height / 2) - (pnlOtherEditor.Height / 2));
            pnlOtherEditor.BringToFront();

            picOtherEditor.Parent = pnlOtherEditor;
            picOtherEditor.Image = Image.FromFile(Application.StartupPath + @"\data\img\Dialogs.png");
            picOtherEditor.Dock = DockStyle.Fill;
        }

        public AL7_frmMain()
        {
            InitializeComponent();

            boolBtnStartGameProcess = true;

            Additional = new AL7_Class_Additional(Application.StartupPath);

            ReElements();

            Tick = "0";
            idxAnim = 0;
            tmrAnim.Interval = Additional.Settings.cTick;

            if (SetPathKMR() == true)
                Additional.PathKMR = Path.GetDirectoryName(Additional.Settings.FileNameKMR);

            tmrAnim.Start();
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
                Additional.PlaySE(Additional.FNseStart);
                idxAnim++;
            }
            else if (idxAnim == 1)
            {
                if (Convert.ToInt64(Tick) % Additional.Settings.DelayStart == 0)
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

        private void btnStartKAM_Click(object sender, EventArgs e)
        {
            Additional.PlaySE(Additional.FNseClick);
            boolBtnStartGameProcess = true;
            btnStartGameProcess = btnStartKAM;
            StartGame(Additional.Settings.FileNameKAM);
        }

        private void btnStartKMR_Click(object sender, EventArgs e)
        {
            Additional.PlaySE(Additional.FNseClick);
            if ((int)btnStartKMR.Tag == 0)
            {
                var frmDownloadProcess = new AL7_frmDownloadUpdateKMR();
                if (frmDownloadProcess.ShowMyDialog("Скачивание и установка игры", Additional) == DialogResult.OK)
                {
                    if (SetPathKMR() == true)
                        Additional.PathKMR = Path.GetDirectoryName(Additional.Settings.FileNameKMR);
                }
                else
                {
                    
                }
            }
            else if((int)btnStartKMR.Tag == 1)
            {
                boolBtnStartGameProcess = true;
                btnStartGameProcess = btnStartKMR;
                StartGame(Additional.Settings.FileNameKMR);
            }
            else if ((int)btnStartKMR.Tag == 2)
            {
                if (SetPathKMR() == true)
                    Additional.PathKMR = Path.GetDirectoryName(Additional.Settings.FileNameKMR);
            }

        }

        private void btnUpdateKMR_Click(object sender, EventArgs e)
        {
            Additional.PlaySE(Additional.FNseClick);

            if (Additional.GetNewVersionKMR().ToLower() == Additional.GetVersionKMR().ToLower())
            {
                var FrmMessageBox = new AL7_frmMessageBox();
                FrmMessageBox.ShowMyDialog("Проверка обновления", "У вас последняя версия.\r\nОбновления не требуются!");
            }
            else
            {
                var frmDownloadProcess = new AL7_frmDownloadUpdateKMR();
                if (frmDownloadProcess.ShowMyDialog("Скачивание и установка обновления игры", Additional, true) == DialogResult.OK)
                {
                    if (SetPathKMR() == true)
                        Additional.PathKMR = Path.GetDirectoryName(Additional.Settings.FileNameKMR);
                }
                else
                {
                }
            }
        }

        private void btnOtherEditorStart_Click(object sender, EventArgs e)
        {
            Additional.PlaySE(Additional.FNseClick);
            pnlOtherEditor.Visible = true;
        }

        private void btnStartCampaignBuilder_Click(object sender, EventArgs e)
        {
            Additional.PlaySE(Additional.FNseClick);
            boolBtnStartGameProcess = false;
            StartGame(Additional.PathKMR + Additional.KMRLauncher.FNCampaignBuilder);
        }

        private void btnStartScriptValidator_Click(object sender, EventArgs e)
        {
            Additional.PlaySE(Additional.FNseClick);
            boolBtnStartGameProcess = false;
            StartGame(Additional.PathKMR + Additional.KMRLauncher.FNScriptValidator);
        }

        private void btnStartTranslationManager_Click(object sender, EventArgs e)
        {
            Additional.PlaySE(Additional.FNseClick);
            boolBtnStartGameProcess = false;
            StartGame(Additional.PathKMR + Additional.KMRLauncher.FNTranslationManager);
        }

        private void btnClosePnlOtherEditor_Click(object sender, EventArgs e)
        {
            Additional.PlaySE(Additional.FNseClick);
            pnlOtherEditor.Visible = false;
        }

        private void btnManageCampaigns_Click(object sender, EventArgs e)
        {
            Additional.PlaySE(Additional.FNseClick);
            var FrmManageCampaigns = new AL7_frmManageCampaigns();
            FrmManageCampaigns.ShowMyDialog("Управление кампаниями", Additional);
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Additional = null;
        }
    }
}
