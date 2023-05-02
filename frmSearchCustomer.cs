using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FlowerShop
{
    public partial class frmSearchCustomer : Form
    {
        public delegate void PassControl1(object sender, int num1);
        public PassControl1 passControl;
        private frmFactor frm002 = new frmFactor();

        public frmSearchCustomer()
        {
            InitializeComponent();
        }

        private void Btn_SearchCustomer_Click(object sender, EventArgs e)
        {
            if (Txt_Search.Text == "")
            {
                MessageBox.Show("لطفا فیلد جستجو را وارد نمائید.");
                return;
            }
            try
            {
                if (Rdo_CustomerID.Checked == true)
                {

                    LSC_RestuRantDataContext db = new LSC_RestuRantDataContext();
                    var Query = from Row in db.tblCustomers
                                where Row.CustomerID == Decimal.Parse(Txt_Search.Text.Trim())
                                select new
                                {
                                    Row.CustomerID,
                                    Row.CustomerName,
                                    Row.CustomerFamily,
                                    Row.DateOzviatSH,
                                    Row.CustomerTell,
                                    Row.CustomerMobail,
                                    Row.CustomerAddress,
                                    Row.CustomerIsActive
                                };
                    Grd_Customer.DataSource = Query;
                    Class_tblLogs LogReg = new Class_tblLogs(this.Text + " - عملیات جستجو");
                    LogReg.UDF_SaveLogToDb();
                    if (Query.Count() <= 0)
                    {
                        Txt_Search.Text = "";
                        button3.BringToFront();
                        Btn_SearchCustomer.SendToBack();
                        MessageBox.Show("رکوردی یافته نشد");
                    }
                }
                else if (Rdo_CustomerName.Checked == true)
                {
                    LSC_RestuRantDataContext db = new LSC_RestuRantDataContext();
                    var Query = from Row in db.tblCustomers
                                where SqlMethods.Like(Row.CustomerName, "%" + Txt_Search.Text.Trim() + "%")
                                select new
                                {
                                    Row.CustomerID,
                                    Row.CustomerName,
                                    Row.CustomerFamily,
                                    Row.DateOzviatSH,
                                    Row.CustomerTell,
                                    Row.CustomerMobail,
                                    Row.CustomerAddress,
                                    Row.CustomerIsActive
                                };
                    Grd_Customer.DataSource = Query;
                    Class_tblLogs LogReg = new Class_tblLogs(this.Text + " - عملیات جستجو");
                    LogReg.UDF_SaveLogToDb();
                    if (Query.Count() <= 0)
                    {
                        Txt_Search.Text = "";
                        button3.BringToFront();
                        Btn_SearchCustomer.SendToBack();
                        MessageBox.Show("رکوردی یافته نشد");
                    }
                }
                else if (Rdo_CustomerFamily.Checked == true)
                {
                    LSC_RestuRantDataContext db = new LSC_RestuRantDataContext();
                    var Query = from Row in db.tblCustomers
                                where SqlMethods.Like(Row.CustomerFamily, "%" + Txt_Search.Text.Trim() + "%")
                                select new
                                {
                                    Row.CustomerID,
                                    Row.CustomerName,
                                    Row.CustomerFamily,
                                    Row.DateOzviatSH,
                                    Row.CustomerTell,
                                    Row.CustomerMobail,
                                    Row.CustomerAddress,
                                    Row.CustomerIsActive
                                };
                    Grd_Customer.DataSource = Query;
                    Class_tblLogs LogReg = new Class_tblLogs(this.Text + " - عملیات جستجو");
                    LogReg.UDF_SaveLogToDb();
                    if (Query.Count() <= 0)
                    {
                        Txt_Search.Text = "";
                        button3.BringToFront();
                        Btn_SearchCustomer.SendToBack();
                        MessageBox.Show("رکوردی یافته نشد");
                    }
                }
            }
            catch
            {
                MessageBox.Show("اشکالی درعملیات جستجو پیش آمده است. دوباره سعی کنید");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //UDF_GrdFill();
            button3.SendToBack();
            Btn_SearchCustomer.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Txt_CustomerCode.Text != "")
            {
                if (passControl != null)
                {
                    passControl(true, int.Parse(Txt_CustomerCode.Text.Trim()));
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("کد مشتری انتخاب نشده است");
            }
        }

        private void UDF_GrdFill()
        {
            LSC_RestuRantDataContext db = new LSC_RestuRantDataContext();
            var Query = from Row in db.tblCustomers
                        orderby Row.CustomerID descending
                        select new
                        {
                            Row.CustomerID,
                            Row.CustomerName,
                            Row.CustomerFamily,
                            Row.DateOzviatSH,
                            Row.CustomerTell,
                            Row.CustomerMobail,
                            Row.CustomerAddress,
                            Row.CustomerIsActive
                        };
            Grd_Customer.DataSource = Query;
        }

        private void Grd_Customer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Txt_CustomerCode.Text = "";
            Int32 selectedCellCount = Grd_Customer.GetCellCount(DataGridViewElementStates.Selected);

            if (selectedCellCount > 0)
            {
                if (Grd_Customer.AreAllCellsSelected(true))
                {
                    MessageBox.Show("All cells are selected", "Selected Cells");
                }
                else
                {
                    System.Text.StringBuilder sb = new System.Text.StringBuilder();
                    for (int i = 0; i < selectedCellCount; i++)
                    {
                        Txt_CustomerCode.Text = Grd_Customer.Rows[int.Parse(Grd_Customer.SelectedCells[i].RowIndex.ToString())].Cells[0].Value.ToString();
                    }
                }
            }
        }

        private void frmSearchCustomer_Load(object sender, EventArgs e)
        {
            UDF_GrdFill();
        }
    }
}
