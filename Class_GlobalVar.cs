using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlowerShop
{
    public static class Class_GlobalVar //set= GlobalClass.GlobalVar = "aliki"; Get= MessageBox.Show(GlobalClass.GlobalVar);
    {
        private static String Str_UserName = String.Empty;
        private static String Str_UserID = String.Empty;
        private static String Str_UserTypeID = String.Empty;

        public static String Str_LogedUserName
        {
            get
            {
                return Str_UserName;
            }
            set
            {
                Str_UserName = value;
            }
        }

        public static String Str_LogedUserID
        {
            get
            {
                return Str_UserID;
            }
            set
            {
                Str_UserID = value;
            }
        }

        public static String Str_LogedUserTypeID
        {
            get
            {
                return Str_UserTypeID;
            }
            set
            {
                Str_UserTypeID = value;
            }
        }

    }
}
