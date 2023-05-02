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
    public partial class frmDefineCustomer : Form
    {
        public frmDefineCustomer()
        {
            InitializeComponent();
        }
        private void UDF_TextBoxEmpty()
        {
            Txt_CustomerID.Clear();
            Txt_Name.Clear();
            Txt_Family.Clear();
            Txt_Tell.Clear();
            Txt_Mobail.Clear();
            Txt_Address.Clear();
            Chb_IsActive.Checked = false;

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


        private void Btn_DeleteCustomer_Click(object sender, EventArgs e)
        {
            if (Txt_CustomerID.Text == "")
            {
                MessageBox.Show("لطفا مشتری مورد نظر را انتخاب فرمائید.");
                return;
            }

            DialogResult dr = MessageBox.Show("آیا نسبت به عمل حذف رکورد اطمینان دارید", "اخطار حذف", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                LSC_RestuRantDataContext db = new LSC_RestuRantDataContext();

                tblCustomer Customer = db.tblCustomers.Single(n => n.CustomerID == decimal.Parse(Txt_CustomerID.Text.Trim()));

                Class_tblLogs LogReg = new Class_tblLogs(this.Text + " رکورد " + Txt_CustomerID.Text.Trim() + "-ID" + Txt_CustomerID.Text.Trim() + "حذف");
                LogReg.UDF_SaveLogToDb();


                db.tblCustomers.DeleteOnSubmit(Customer);
                db.SubmitChanges();

                UDF_TextBoxEmpty();
                UDF_GrdFill();
            }
        }

        private void frmDefineCustomer_Load(object sender, EventArgs e)
        {
            Class_tblLogs LogReg = new Class_tblLogs(this.Text + " فعال گردید.");
            LogReg.UDF_SaveLogToDb();
            UDF_GrdFill();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Txt_Name.Text = String.Empty;
            Txt_Family.Text = String.Empty;
            Txt_Tell.Text = String.Empty;
            Txt_Mobail.Text = String.Empty;
            Txt_Address.Text = String.Empty;
            btnAdd.SendToBack();
            Btn_Save.BringToFront();
            Txt_Family.Clear();
            MessageBox.Show("لطفا اطلاعات را وارد نمایید");
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (Txt_Name.Text == "" || Txt_Family.Text == "" || Txt_Tell.Text == "" || Txt_Mobail.Text == "" || Txt_Address.Text == "")
            {
                MessageBox.Show("ورود تمامی فیلدها الزامی می باشد");
                return;
            }

            LSC_RestuRantDataContext db = new LSC_RestuRantDataContext();

            try
            {
                tblCustomer Customer1 = db.tblCustomers.Single(n => n.CustomerName.Trim() == Txt_Name.Text.Trim() && n.CustomerFamily.Trim() == Txt_Family.Text.Trim());
                MessageBox.Show("نام و نام خانوادگی تکراری می باشد");
                return;
            }
            catch
            {
            }
            try
            {
                tblCustomer Customer2 = db.tblCustomers.Single(n => n.CustomerMobail.Trim() == Txt_Mobail.Text.Trim());
                MessageBox.Show("شماره تلفن همراه تکراری می باشد");
                return;
            }
            catch
            {
            }

            tblCustomer Customer = new tblCustomer();
            Class_ShamsiTools shamsi = new Class_ShamsiTools();
            shamsi.UDF_GetCurrentShamsiDate();

            Customer.CustomerName = Txt_Name.Text.Trim();
            Customer.CustomerFamily = Txt_Family.Text.Trim();
            Customer.DateOzviatSH = shamsi.CurrentShmasiDate;
            Customer.CustomerTell = Txt_Tell.Text.Trim();
            Customer.CustomerMobail = Txt_Mobail.Text.Trim();
            Customer.CustomerAddress = Txt_Address.Text.Trim();
            Customer.CustomerIsActive = Chb_IsActive.Checked;



            db.tblCustomers.InsertOnSubmit(Customer);
            db.SubmitChanges();

            UDF_GrdFill();

            btnAdd.BringToFront();
            Btn_Save.SendToBack();

            UDF_TextBoxEmpty();

            MessageBox.Show("رکورد جدید درج گردید.");
        }

        private void Grd_Customer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 selectedCellCount =Grd_Customer. GetCellCount(DataGridViewElementStates.Selected);

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
                        Boolean Bln_Check;

                        Txt_CustomerID.Text = Grd_Customer.Rows[int.Parse(Grd_Customer.SelectedCells[i].RowIndex.ToString())].Cells[0].Value.ToString();
                        Txt_Name.Text = Grd_Customer.Rows[int.Parse(Grd_Customer.SelectedCells[i].RowIndex.ToString())].Cells[1].Value.ToString();
                        Txt_Family.Text = Grd_Customer.Rows[int.Parse(Grd_Customer.SelectedCells[i].RowIndex.ToString())].Cells[2].Value.ToString();
                        Txt_Tell.Text = Grd_Customer.Rows[int.Parse(Grd_Customer.SelectedCells[i].RowIndex.ToString())].Cells[4].Value.ToString();
                        Txt_Mobail.Text = Grd_Customer.Rows[int.Parse(Grd_Customer.SelectedCells[i].RowIndex.ToString())].Cells[5].Value.ToString();
                        Txt_Address.Text = Grd_Customer.Rows[int.Parse(Grd_Customer.SelectedCells[i].RowIndex.ToString())].Cells[6].Value.ToString();
                        Bln_Check = Boolean.Parse(Grd_Customer.Rows[int.Parse(Grd_Customer.SelectedCells[i].RowIndex.ToString())].Cells[7].Value.ToString());
                        if (Bln_Check == true)
                        {
                            Chb_IsActive.Checked = true;
                        }
                        else if (Bln_Check == false)
                        {
                            Chb_IsActive.Checked = false;
                        }
                       // MessageBox.Show(Grd_Customer.Rows[int.Parse(Grd_Customer.SelectedCells[i].RowIndex.ToString())].Cells[7].Value.ToString());
                    }
                }
            }
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            if (Txt_CustomerID.Text == "")
            {
                MessageBox.Show("لطفا مشتری مورد نظر را انتخاب کنید");
                return;
            }

            DialogResult dr = MessageBox.Show("آیا نسبت به عمل ویرایش رکورد اطمینان دارید", "اخطار ویرایش", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                LSC_RestuRantDataContext db = new LSC_RestuRantDataContext();
                tblCustomer Customer = db.tblCustomers.Single(n => n.CustomerID == Decimal.Parse(Txt_CustomerID.Text.Trim()));

                Customer.CustomerName = Txt_Name.Text.Trim();
                Customer.CustomerFamily = Txt_Family.Text.Trim();
                Customer.CustomerTell = Txt_Tell.Text.Trim();
                Customer.CustomerMobail = Txt_Mobail.Text.Trim();
                Customer.CustomerAddress = Txt_Address.Text.Trim();
                Customer.CustomerIsActive = Chb_IsActive.Checked;
                db.SubmitChanges();

                Class_tblLogs LogReg = new Class_tblLogs(this.Text + " رکورد " + Txt_Name.Text.Trim() + Txt_Family.Text.Trim() + " -ID= " + Txt_CustomerID.Text.Trim() + "ویرایش");
                LogReg.UDF_SaveLogToDb();
                UDF_GrdFill();
                UDF_TextBoxEmpty();
            }
        }

        private void Btn_SearchCustomer_Click(object sender, EventArgs e)
        {
            if (Txt_Search.Text == "")
            {
                MessageBox.Show("لطفا فیلد جستجو را وارد نمائید.");
                return;
            }

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
               Grd_Customer. DataSource = Query;
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
                            where SqlMethods.Like(Row.CustomerName , "%" +Txt_Search.Text.Trim() + "%")
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
                            where SqlMethods.Like(Row.CustomerFamily , "%" + Txt_Search.Text.Trim() + "%")
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

        private void button3_Click(object sender, EventArgs e)
        {
            UDF_GrdFill();
            button3.SendToBack();
            Btn_SearchCustomer.BringToFront();
        }


    }
}

