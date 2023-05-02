using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlowerShop
{
    class Class_tblUsers
    {
        private String Str_UserName = String.Empty;
        private String Str_UserPass = String.Empty;

        public Class_tblUsers(String Str_UserName, String Str_UserPass)
        {
            this.Str_UserName = Str_UserName;
            this.Str_UserPass = Str_UserPass;
        }

        /// <summary>
        /// از این متد برای ایجاد فضای کاربری و انجام عملیات لاگین استفاده می شود
        /// </summary>
        /// <returns>Boolean</returns>
        public Boolean UDF_LoginUser()
        {
            Boolean Bln_IsLogedIn = Boolean.Parse("false");
            LSC_RestuRantDataContext db = new LSC_RestuRantDataContext();
            try
            {
                tblUser UsrLogin = db.tblUsers.Single(n => n.UsersName.Trim() == this.Str_UserName.Trim() && n.UsersPass.Trim() == this.Str_UserPass.Trim() && n.UserBanBit == false);
                if (UsrLogin.UsersName.Trim() != "")
                {
                    Bln_IsLogedIn = Boolean.Parse("true");
                    Class_GlobalVar.Str_LogedUserID = UsrLogin.UsersID.ToString().Trim();
                    Class_GlobalVar.Str_LogedUserName = UsrLogin.UsersName.ToString().Trim();
                    Class_GlobalVar.Str_LogedUserTypeID = UsrLogin.UserTypeID.ToString().Trim();
                }
                else
                {
                    Bln_IsLogedIn = Boolean.Parse("false");
                }
                return Bln_IsLogedIn;
            }
            catch
            {
                return Bln_IsLogedIn;
            }

        }
    }
}
