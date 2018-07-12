using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KAM_Remake_Launcher
{
    public class AL7_Class_KMRLauncher
    {
        public AL7_Class_KMRLauncher()
        {
            FNKAM = @"\KM_TPR.exe";
            FNKMR = @"\KaM_Remake.exe";

            FNInstallerKMR = "Install KAM Remake.exe";
            FNUpdateKMR = "Update KAM Remake.exe";
            KMRSite = "http://www.kamremake.com/download/";
            FNCampaignBuilder = @"\CampaignBuilder.exe";
            FNScriptValidator = @"\ScriptValidator.exe";
            FNTranslationManager = @"\TranslationManager.exe";

            DirCampaign = @"\Campaigns";
        }

        /// <summary>
        /// Имя файла оригинальной игры KAM
        /// </summary>
        public string FNKAM { get; set; }

        /// <summary>
        /// Имя файла ремейка игры KAM - Remake или KMR
        /// </summary>
        public string FNKMR { get; set; }

        /// <summary>
        /// Имя инсталятора KAM Remake при скачивании
        /// </summary>
        public string FNInstallerKMR { get; set; }

        /// <summary>
        /// Имя Обновления KAM Remake при скачивании
        /// </summary>
        public string FNUpdateKMR { get; set; }

        /// <summary>
        /// Сайт игры KAM Remake
        /// </summary>
        public string KMRSite { get; set; }

        /// <summary>
        /// Имя файла утилиты CampaignBuilder
        /// </summary>
        public string FNCampaignBuilder { get; set; }

        /// <summary>
        /// Имя файла утилиты ScriptValidator
        /// </summary>
        public string FNScriptValidator { get; set; }

        /// <summary>
        /// Имя файла утилиты TranslationManage
        /// </summary>
        public string FNTranslationManager { get; set; }

        /// <summary>
        /// Имя папки с кампаниями
        /// </summary>
        public string DirCampaign { get; set; }
    }
}
