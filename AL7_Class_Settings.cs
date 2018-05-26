using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KAM_Remake_Launcher
{
    public class AL7_Class_Settings
    {
        public AL7_Class_Settings()
        {
            //Присваиваем переменным начальные настройки
            FNKAM = "KM_TPR.exe";
            FNKMR = "KaM_Remake.exe";
            FileNameKAM = "";
            FileNameKMR = "";
            FNInstallerKMR = "Install KAM Remake.exe";
            KMRSite = "http://www.kamremake.com/download/";
            FNCampaignBuilder = "CampaignBuilder.exe";
            FNScriptValidator = "ScriptValidator.exe";
            FNTranslationManager = "TranslationManager.exe";

            //Для автоматического инсталирования KAM Remake
            AutoInst_DIR = @"C:\Games\KAM Remake";
        }

        //Возможное имя файла KAM оригинал
        public string FNKAM { get; set; }

        //Возможное имя файла KAM Remake
        public string FNKMR { get; set; }

        //Полное имя файла игры KAM оригинал
        public string FileNameKAM { get; set; }

        //Полное имя файла игры KAM Remake
        public string FileNameKMR { get; set; }

        //Имя инсталятора KAM Remake
        public string FNInstallerKMR { get; set; }

        //Переменная с сайтом KAM Remake
        public string KMRSite { get; set; }

        //Имя CampaignBuilder
        public string FNCampaignBuilder { get; set; }

        //Имя ScriptValidator
        public string FNScriptValidator { get; set; }

        //Имя TranslationManager
        public string FNTranslationManager { get; set; }

        //Для автоматического инсталирования KAM Remake
        //Папка куда будет проинсталирована игра
        public string AutoInst_DIR { get; set; }

    }
}
