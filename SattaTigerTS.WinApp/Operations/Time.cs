using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SattaTigerTS.WinApp.Operations
{
    public partial class Time
    {

        //zamanı integer olarak dönüştürür
        public static void packTime()
        {
            object tm = 0;
            Global.uApp.PackDate(DateTime.Now.Hour,DateTime.Now.Minute,DateTime.Now.Second,ref tm);
        }

        public static void packDate()
        {
            object dt = 0;
            Global.uApp.PackDate(DateTime.Now.Day,DateTime.Now.Month,DateTime.Now.Year,ref dt);
        }
    }
}
