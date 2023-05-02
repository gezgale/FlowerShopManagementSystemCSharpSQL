using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace FlowerShop
{
    public class Class_ShamsiTools
    {
        private String Str_CurrentShamsiDate = String.Empty;

        public Class_ShamsiTools()
        {
        }

        public Class_ShamsiTools(DateTime MiladiDate)
        {
            DateTime Dt_Now = MiladiDate;
            PersianCalendar Per_Calendar = new PersianCalendar();
            Str_CurrentShamsiDate = Per_Calendar.GetYear(Dt_Now).ToString() + "/" + Per_Calendar.GetMonth(Dt_Now).ToString("00") + "/" + Per_Calendar.GetDayOfMonth(Dt_Now).ToString("00");
        }

        public void UDF_GetCurrentShamsiDate()
        {
            DateTime Dt_Now = DateTime.Now;
            PersianCalendar Per_Calendar = new PersianCalendar();
            Str_CurrentShamsiDate = Per_Calendar.GetYear(Dt_Now).ToString() + "/" + Per_Calendar.GetMonth(Dt_Now).ToString("00") + "/" + Per_Calendar.GetDayOfMonth(Dt_Now).ToString("00");
        }

        public String CurrentShmasiDate
        {
            get
            {
                return Str_CurrentShamsiDate;
            }
        }
    }

}
