using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlowerShop
{
    /// <summary>
    /// از این کلاس برای درج رخدادهای برنامه استفاده می شود
    /// </summary>
    class Class_tblLogs
    {
        private String Str_LogDescription = String.Empty;
        public Class_tblLogs(String Str_LogDescription)
        {
            this.Str_LogDescription = Str_LogDescription;
        }

        public void UDF_SaveLogToDb()
        {
            LSC_RestuRantDataContext db = new LSC_RestuRantDataContext();
            tblLog Log = new tblLog();
            if (Class_GlobalVar.Str_LogedUserName == "")
            {
                Log.UsersName = "Guest";
            }
            else
            {
                Log.UsersName = Class_GlobalVar.Str_LogedUserName;
            }
            Log.LogDateTime = DateTime.Now;
            Log.LogDescription = this.Str_LogDescription.Trim();
            db.tblLogs.InsertOnSubmit(Log);
            db.SubmitChanges();
        }
    }
}
