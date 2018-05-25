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
            FileNameKMR = "";
            FNInstallerKMR = "Install KAM Remake.exe";
            KMRSite = "http://www.kamremake.com/download/";

            //Для автоматического инсталирования KAM Remake
            AutoInst_DIR = @"C:\Games\KAM Remake";
        }

        //Полное имя файла игры KAM Remake
        public string FileNameKMR { get; set; }

        //Имя инсталятора KAM Remake
        public string FNInstallerKMR { get; set; }

        //Переменная с сайтом KAM Remake
        public string KMRSite { get; set; }


        //Для автоматического инсталирования KAM Remake
        //Папка куда будет проинсталирована игра
        public string AutoInst_DIR { get; set; }

    }
}
