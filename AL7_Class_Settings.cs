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
            
            FileNameKAM = "";
            FileNameKMR = "";

            DelayStart = 150;
            cTick = 10;
        }

        public string FileNameKAM;
        public string FileNameKMR;

        /// <summary>
        /// Задержка перед стартом анимации 100 = 1 секунде если брать в расщет интервал 10
        /// </summary>
        public int DelayStart = 150;

        /// <summary>
        /// Интерал таймера 1000 = 1 секунда. Каждые 10 милисекунд
        /// </summary>
        public int cTick = 10;
    }
}
