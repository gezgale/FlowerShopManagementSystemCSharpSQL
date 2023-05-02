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
    public partial class frmMainMdi : Form
    {
        frmFlowerCategury frm2;
        frmFlowerUnits frm3;
        frmDefineFlowers frm4;
        frmDefineCustomer frm5;
        frmEditUsers frm6;
        frmFactor frm7;
        frmMojodi frm8;
        frmCalculator frm9;
        frmFactorPrint frm10;


        public frmMainMdi()
        {
            InitializeComponent();
        }

        private void frmMainMdi_Load(object sender, EventArgs e)
        {
            Class_tblLogs LogReg = new Class_tblLogs(this.Text + " فعال گردید.");
            LogReg.UDF_SaveLogToDb();
            toolStripStatusLabel.Text = "وارد شده با : " + Class_GlobalVar.Str_LogedUserName.Trim();
        }

        private void frmMainMdi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Class_tblLogs LogReg = new Class_tblLogs(this.Text + " بسته شد.");
            LogReg.UDF_SaveLogToDb();
            Application.Exit();
        }

        private void Mnu_File_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

 

        private void Mnu_File_FoodCategu_Click(object sender, EventArgs e)
        {
            if (frm2 == null || frm2.IsDisposed)
            {
                frm2 = new frmFlowerCategury();
                frm2.MdiParent = this;
                frm2.Show();
            }
            else
            {
                frm2.Activate();
            }
        }

        private void Mnu_File_FoodUnit_Click(object sender, EventArgs e)
        {
            if (frm3 == null || frm3.IsDisposed)
            {
                frm3 = new frmFlowerUnits();
                frm3.MdiParent = this;
                frm3.Show();
            }
            else
            {
                frm3.Activate();
            }
        }

        private void Mnu_File_FoodDef_Click(object sender, EventArgs e)
        {
            if (frm4 == null || frm4.IsDisposed)
            {
                frm4 = new frmDefineFlowers();
                frm4.MdiParent = this;
                frm4.Show();
            }
            else
            {
                frm4.Activate();
            }
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm5 == null || frm5.IsDisposed)
            {
                frm5 = new frmDefineCustomer();
                frm5.MdiParent = this;
                frm5.Show();
            }
            else
            {
                frm5.Activate();
            }
        }

        private void mnuSecurity_DefineUsers_Click(object sender, EventArgs e)
        {

                if (frm6 == null || frm6.IsDisposed)
                {
                    frm6 = new frmEditUsers();
                    frm6.MdiParent = this;
                    frm6.Show();
                }
                else
                {
                    frm6.Activate();
                }
            
        }

        private void Mnu_File_Factor_Click(object sender, EventArgs e)
        {
            if (frm7 == null || frm7.IsDisposed)
            {
                frm7 = new frmFactor();
                frm7.MdiParent = this;
                frm7.Show();
            }
            else
            {
                frm7.Activate();
            }
        }

        private void Mnu_File_InsertFood_Click(object sender, EventArgs e)
        {
            if (frm8 == null || frm8.IsDisposed)
            {
                frm8 = new frmMojodi();
                frm8.MdiParent = this;
                frm8.Show();
            }
            else
            {
                frm8.Activate();
            }
        }

        private void Mnu_Help_About_Click(object sender, EventArgs e)
        {
            MessageBox.Show("برنامه گُلفروشی - نسخه 1");
        }

        private void Mnu_Help_Calculator_Click(object sender, EventArgs e)
        {
            if (frm9 == null || frm9.IsDisposed)
            {
                frm9 = new frmCalculator();
                frm9.MdiParent = this;
                frm9.Show();
            }
            else
            {
                frm9.Activate();
            }
        }

        private void chpFactorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm10 == null || frm10.IsDisposed)
            {
                frm10 = new frmFactorPrint();
                frm10.MdiParent = this;
                frm10.Show();
            }
            else
            {
                frm10.Activate();
            }
        }
    }
}

