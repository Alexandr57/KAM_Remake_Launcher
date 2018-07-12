using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Media;
using AngleSharp.Parser.Html;
using System.Net;
using Microsoft.Win32;

namespace KAM_Remake_Launcher
{
    public class AL7_Class_Additional
    {
        /// <summary>
        /// Дополнительный класс
        /// </summary>
        public AL7_Class_Additional(string aPath)
        {
            FNseClick = aPath + @"\data\se\Click.wav";
            FNseStart = aPath + @"\data\se\Start.wav";

            XMLFileNameSettings = aPath + @"\Settings.Xml";
            XMLFileNameKMRLauncher = aPath + @"\KAM_Remake_Launcher.Xml";
            Settings = new AL7_Class_Settings();
            KMRLauncher = new AL7_Class_KMRLauncher();
            ReadXmlKMRLauncher();
            ReadXmlSettings();
        }

        /// <summary>
        /// Освобождение ресурсов дополнительного класса
        /// </summary>
        ~AL7_Class_Additional()
        {
            WriteXmlKMRLauncher();
            WriteXmlSettings();
        }

        /// <summary>
        /// Запись настроек в файл XML
        /// </summary>
        public void WriteXmlSettings()
        {
            XmlSerializer ser = new XmlSerializer(typeof(AL7_Class_Settings));
            TextWriter writer = new StreamWriter(XMLFileNameSettings);
            ser.Serialize(writer, Settings);
            writer.Close();
        }

        /// <summary>
        /// Чтение настроек из файла XML
        /// </summary>
        public void ReadXmlSettings()
        {
            if (File.Exists(XMLFileNameSettings))
            {
                XmlSerializer ser = new XmlSerializer(typeof(AL7_Class_Settings));
                TextReader reader = new StreamReader(XMLFileNameSettings);
                Settings = ser.Deserialize(reader) as AL7_Class_Settings;
                reader.Close();
            }
            else { }
        }

        /// <summary>
        /// Запись надстроек в файл XML
        /// </summary>
        public void WriteXmlKMRLauncher()
        {
            XmlSerializer ser = new XmlSerializer(typeof(AL7_Class_KMRLauncher));
            TextWriter writer = new StreamWriter(XMLFileNameKMRLauncher);
            ser.Serialize(writer, KMRLauncher);
            writer.Close();
        }

        /// <summary>
        /// Чтение надстроек из файла XML
        /// </summary>
        public void ReadXmlKMRLauncher()
        {
            if (File.Exists(XMLFileNameSettings))
            {
                XmlSerializer ser = new XmlSerializer(typeof(AL7_Class_KMRLauncher));
                TextReader reader = new StreamReader(XMLFileNameKMRLauncher);
                KMRLauncher = ser.Deserialize(reader) as AL7_Class_KMRLauncher;
                reader.Close();
            }
            else { }
        }

        /// <summary>
        /// Воспроизведение звука WAV
        /// </summary>
        /// <param name="aFileName">Имя звукового файла</param>
        public void PlaySE(string aFileName)
        {
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = aFileName;
            sp.LoadAsync();
            sp.Play();
        }

        /// <summary>
        /// Получение новой версии KAM Remake из сайта
        /// </summary>
        /// <returns>Возвращает версию игры с сайта</returns>
        public string GetNewVersionKMR()
        {
            string html;
            using (var webClient = new WebClient())
            {
                webClient.Encoding = Encoding.UTF8;
                webClient.Headers.Add(HttpRequestHeader.UserAgent, ".NET Application");
                html = webClient.DownloadString(KMRLauncher.KMRSite);
            }
            var parser = new HtmlParser();
            var doc = parser.Parse(html);

            var text = doc.QuerySelector(".entry-content > p:nth-child(5) > strong");

            return text.TextContent.Substring(text.TextContent.ToLower().IndexOf("kam remake ") + 11, text.TextContent.ToLower().IndexOf(" ", text.TextContent.ToLower().IndexOf("kam remake ") + 11) - (text.TextContent.ToLower().IndexOf("kam remake ") + 11));
        }

        /// <summary>
        /// Проверка на то что игра является KAM Remake
        /// </summary>
        /// <param name="aFileNameKMR">Имя файла KMR</param>
        /// <returns></returns>
        public bool CheckFNKMR(string aFileNameKMR)
        {
            return ((File.Exists(aFileNameKMR) == true)
                    && (File.Exists(Path.GetDirectoryName(aFileNameKMR) + @"\KM_TextIDs.inc") == true)
                    && (File.Exists(Path.GetDirectoryName(aFileNameKMR) + @"\libzplay.dll") == true)
                    && (Directory.Exists(Path.GetDirectoryName(aFileNameKMR) + @"\Campaigns") == true)
                    && (Directory.Exists(Path.GetDirectoryName(aFileNameKMR) + @"\data") == true));
        }

        /// <summary>
        /// Проверка на наличия лицензии игры и по воззможности получения папки с игрой
        /// </summary>
        /// <param name="outFNKMR">Возвращает имя файла игры или пустую строку</param>
        /// <returns>Возвращает истину если лицензия найдена</returns>
        public bool CheckLcenseKMR(out string outFNKMR)
        {
            var b = false;
            using (var hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32))
            using (var key = hklm.OpenSubKey(@"SOFTWARE\JOYMANIA Entertainment\KnightsandMerchants TPR"))
            {
                b = (key != null) && (key.GetValue("Version") != null) && (key.GetValue("RemakeVersion") != null);

                try
                {
                    outFNKMR = key.GetValue("RemakeDIR").ToString() + KMRLauncher.FNKMR;
                }
                catch
                {
                    outFNKMR = "";
                }
            }
            return b;
        }

        /// <summary>
        /// Получение версии KAM Remake из реестра
        /// </summary>
        /// <returns>Возвращает версию если найдена</returns>
        public string GetVersionKMR()
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
                    TextVer = "???";
                }
            }

            return TextVer;
        }

        /// <summary>
        /// Получение оригинальной игры из реестра
        /// </summary>
        /// <returns>Возвращает истину если оригинальная игра найдена</returns>
        public bool GetFileNameKAM()
        {
            var b = false;
            using (var hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32))
            using (var key = hklm.OpenSubKey(@"SOFTWARE\JOYMANIA Entertainment\KnightsandMerchants TPR"))
            {
                try
                {
                    Settings.FileNameKAM = key.GetValue("DIR").ToString() + KMRLauncher.FNKAM;
                    b = true;
                }
                catch
                {
                    Settings.FileNameKAM = "";
                }

            }
            return b;
        }

        /// <summary>
        /// Имя файла сохраняемых параметров
        /// </summary>
        public string XMLFileNameSettings { get; set; }

        /// <summary>
        /// Класс с сохраняемыми параметрами
        /// </summary>
        public AL7_Class_Settings Settings { get; set; }

        /// <summary>
        /// Имя файла с надстройками
        /// </summary>
        public string XMLFileNameKMRLauncher { get; set; }

        /// <summary>
        /// Класс с надстройками
        /// </summary>
        public AL7_Class_KMRLauncher KMRLauncher { get; set; }

        /// <summary>
        /// Папка с расположением KAM Remake
        /// </summary>
        public string PathKMR { get; set; }

        /// <summary>
        /// Имя файла звука клика
        /// </summary>
        public string FNseClick { get; set; }

        /// <summary>
        /// Имя файла звука старта
        /// </summary>
        public string FNseStart { get; set; }

    }
}
