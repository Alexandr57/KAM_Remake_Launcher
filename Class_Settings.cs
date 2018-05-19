using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KAM_Remake_Launcher
{
    public class Class_Settings
    {
        public Class_Settings()
        {
            FileNameKMR = "";
        }

        public string FileNameKMR { get; set; }

        public string FNInstallerKMR = "Install KAM Remake.exe";

        public string XMLFileName = "Settings.Xml";
    }
}
