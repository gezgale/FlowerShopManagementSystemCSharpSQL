using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FlowerShop
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            Class_tblLogs LogReg = new Class_tblLogs(this.Text + " فعال گردید.");
            LogReg.UDF_SaveLogToDb();
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Class_tblLogs LogReg = new Class_tblLogs(this.Text + " بسته شد.");
            LogReg.UDF_SaveLogToDb();
            Application.Exit(); 
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            Class_tblUsers LogInUsr = new Class_tblUsers(Txt_UserName.Text.Trim(), Txt_Password.Text.Trim());
            if (LogInUsr.UDF_LoginUser() == true)
            {
                Txt_UserName.Text = String.Empty;
                Txt_Password.Text = String.Empty;
                this.Hide();
                Class_tblLogs LogReg = new Class_tblLogs(this.Text + " ورود به سیستم انجام شد.");
                LogReg.UDF_SaveLogToDb();
                frmMainMdi frm = new frmMainMdi();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("نام کاربری و یا کلمه عبور صحیح نمی باشند.");
            }
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            Class_tblLogs LogReg = new Class_tblLogs(this.Text + " درخواست ورود لغو شد.");
            LogReg.UDF_SaveLogToDb();
            Application.Exit();
        }

        private void Txt_UserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (Txt_UserName.Text != "" && Txt_Password.Text != "")
            {
                if (int.Parse(e.KeyValue.ToString()) == 13)
                {
                    Btn_Login.PerformClick();
                }
            }
        }

        private void Txt_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (Txt_UserName.Text != "" && Txt_Password.Text != "")
            {
                if (int.Parse(e.KeyValue.ToString()) == 13)
                {
                    Btn_Login.PerformClick();
                }
            }
        }
    }
}
