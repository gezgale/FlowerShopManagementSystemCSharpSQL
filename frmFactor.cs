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
    public partial class frmFactor : Form
    {
        frmSearchCustomer frm001;
        DataTable FactDt = new DataTable();

        public frmFactor()
        {
            InitializeComponent();
        }

        //درج مقادیر گروه های غذا در گریدویو اول
        private void UDF_GrdCategoryFill()
        {
            LSC_RestuRantDataContext db = new LSC_RestuRantDataContext();
            var Query = from Row in db.tblFlowerCateguries 
                        orderby Row.FlowerCateguryID  ascending 
                        select new
                        {
                            Row.FlowerCateguryID, 
                            Row.FlowerCateguryDescription 
                        };
            Grd_FlowerCategory.DataSource = Query;
        }

        // درج مقادیر غذا در هر گروه با استفاده از گروه کالا در گرید ویوی دوم
        private void UDF_CatID(Decimal Dec_CategoryID)
        { 
            LSC_RestuRantDataContext db = new LSC_RestuRantDataContext();
            var Query = from Row in db.xtblFlowerSelects
                     where Row.FlowerCateguryID == Dec_CategoryID
                        select new
                        {
                            Row.FlowerID,
                            Row.FlowerDescription,
                            Row.UnitPrice
                        };
            DataTable dt = new DataTable();
            dt.Columns.Add("FlowerID", typeof(int));
            dt.Columns.Add("FlowerDescription", typeof(String));
            dt.Columns.Add("FlowerStock", typeof(float));
            dt.Columns.Add("UnitPrice",typeof(decimal));


            foreach (var Row in Query)
            {
                dt.Rows.Add(new Object[] { Row.FlowerID, Row.FlowerDescription, UDF_GetStackRate(Row.FlowerID) , Row.UnitPrice });
            }

            Grd_FlowerDescription.DataSource = dt;
        }

        /// <summary>
        /// جهت دریافت موجودی گل ها
        /// </summary>
        /// <param name="int_FlowerID"></param>
        /// <returns name="int_Stock"></returns>
        private float UDF_GetStackRate(int int_FlowerID)
        {
            float flt_Stock = 0;
            LSC_RestuRantDataContext db = new LSC_RestuRantDataContext();
            try
            {
                xtblMandehGol tblStock = db.xtblMandehGols.Single(n => n.FlowerID == int_FlowerID);
                flt_Stock = float.Parse(tblStock.Mandeh.ToString());
            }
            catch
            {
                flt_Stock = 0;
            }
            return flt_Stock;
        }

        private void Grd_FlowerCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            UDF_TXTFactorClear();
            Int32 selectedCellCount = Grd_FlowerCategory.GetCellCount(DataGridViewElementStates.Selected);

            if (selectedCellCount > 0)
            {
                if (Grd_FlowerCategory.AreAllCellsSelected(true))
                {
                    MessageBox.Show("All cells are selected", "Selected Cells");
                }
                else
                {
                    System.Text.StringBuilder sb = new System.Text.StringBuilder();
                    for (int i = 0; i < selectedCellCount; i++)
                    {
                        Decimal Dec_CategoryID = Decimal.Parse(Grd_FlowerCategory.Rows[int.Parse(Grd_FlowerCategory.SelectedCells[i].RowIndex.ToString())].Cells[0].Value.ToString());
                        UDF_CatID(Dec_CategoryID);
                    }
                }
            }
        }

        private void frmFactor_Load(object sender, EventArgs e)
        {
            Class_tblLogs LogReg = new Class_tblLogs(this.Text + " فعال گردید.");
            LogReg.UDF_SaveLogToDb();
            UDF_GrdCategoryFill();
        }

        //private void PassData(object sender, int number)
        //{
        //    //Sms_Menu.Enabled = (Boolean)sender;
        //    MessageBox.Show(number.ToString());
        //}

        private void Grd_FlowerDescription_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 selectedCellCount = Grd_FlowerDescription.GetCellCount(DataGridViewElementStates.Selected);
            UDF_TXTFactorClear();
            if (selectedCellCount > 0)
            {
                if (Grd_FlowerDescription.AreAllCellsSelected(true))
                {
                    MessageBox.Show("All cells are selected", "Selected Cells");
                }
                else
                {
                    System.Text.StringBuilder sb = new System.Text.StringBuilder();
                    for (int i = 0; i < selectedCellCount; i++)
                    {
                        Txt_FlowerCode.Text = Grd_FlowerDescription.Rows[int.Parse(Grd_FlowerDescription.SelectedCells[i].RowIndex.ToString())].Cells[0].Value.ToString();
                        Txt_FlowerName.Text = Grd_FlowerDescription.Rows[int.Parse(Grd_FlowerDescription.SelectedCells[i].RowIndex.ToString())].Cells[1].Value.ToString();
                        Txt_Stock.Text = Grd_FlowerDescription.Rows[int.Parse(Grd_FlowerDescription.SelectedCells[i].RowIndex.ToString())].Cells[2].Value.ToString();
                        Txt_UnitPrice.Text = Grd_FlowerDescription.Rows[int.Parse(Grd_FlowerDescription.SelectedCells[i].RowIndex.ToString())].Cells[3].Value.ToString();
                        Txt_TedadeDarkhast.Text = Txt_FeeTotal.Text = Txt_Tajhfif.Text = "0";
                        
                    }
                }
            }
        }

        private Decimal UDF_GetFlowerINFO(int int_FlowerID)
        {
            Decimal Dec_FlowerPRice = 0;
            LSC_RestuRantDataContext db = new LSC_RestuRantDataContext();
            
            return Dec_FlowerPRice;
        }

        private void UDF_TXTFactorClear()
        {
            Txt_FlowerCode.Text = "";
            Txt_FlowerName.Text = "";
            Txt_Stock.Text = "";
            Txt_TedadeDarkhast.Text = "";
            Txt_UnitPrice.Text = "";
            Txt_Tajhfif.Text = "";
            Txt_FeeTotal.Text = "";
        }

        private void Txt_TedadeDarkhast_KeyPress(object sender, KeyPressEventArgs e)
        {
            int ascii = Convert.ToInt16(e.KeyChar);
            if (ascii >= 48 && ascii <= 57)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void Txt_Tajhfif_KeyPress(object sender, KeyPressEventArgs e)
        {
            int ascii = Convert.ToInt16(e.KeyChar);
            if (ascii >= 48 && ascii <= 57)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void Txt_UnitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            int ascii = Convert.ToInt16(e.KeyChar);
            if (ascii >= 48 && ascii <= 57)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void Btn_AddToList_Click(object sender, EventArgs e)
        {
            if (Txt_FlowerName.Text == "")
            {
                MessageBox.Show("عنوان غذا انتخاب نشده است");
                return;
            }
            if (Decimal.Parse(Txt_UnitPrice.Text.Trim()) == 0 || Decimal.Parse(Txt_TedadeDarkhast.Text.Trim()) == 0)
            {
                MessageBox.Show("ورود مقدار تعداد الزامی می باشد");
                return;
            }
            if (Decimal.Parse(Txt_TedadeDarkhast.Text.Trim()) > Decimal.Parse(Txt_Stock.Text.Trim()))
            {
                MessageBox.Show("مقدار انتخاب شده بیش از مقدار موجودی می باشد");
                return;
            }

            if (FactDt.Rows.Count <= 0 && FactDt.Columns.Count <= 0)
            {
                FactDt.Columns.Add("FlowerID", typeof(int));
                FactDt.Columns.Add("FlowerName", typeof(string));
                FactDt.Columns.Add("FlowerQuantity", typeof(float));
                FactDt.Columns.Add("FlowerUnitPrice", typeof(Decimal));
                FactDt.Columns.Add("FlowerDiscount", typeof(Decimal));
                FactDt.Columns.Add("FlowerTotalPrice", typeof(Decimal));

                FactDt.Rows.Add(int.Parse(Txt_FlowerCode.Text.Trim()), Txt_FlowerName.Text.Trim(), float.Parse(Txt_TedadeDarkhast.Text.Trim())
                                , Decimal.Parse(Txt_UnitPrice.Text.Trim()) , Decimal.Parse(Txt_Tajhfif.Text.Trim()), Decimal.Parse(Txt_FeeTotal.Text.Trim()));

                Grd_Factor.DataSource = FactDt;
            }
            else
            {
                int int_CntFound = 0;
                float flt_darkhast = 0;
                foreach (DataRow Row in FactDt.Rows)
                {
                    if (int.Parse(Row[0].ToString().Trim()) == int.Parse(Txt_FlowerCode.Text.Trim()))
                    {
                        int_CntFound++;
                        flt_darkhast = float.Parse(Row[2].ToString());
                    }
                }
                if (int_CntFound == 0)// در صورتی که کلای تکراری نباشد در فاکتور درج می شود
                {
                    FactDt.Rows.Add(int.Parse(Txt_FlowerCode.Text.Trim()), Txt_FlowerName.Text.Trim(), Decimal.Parse(Txt_TedadeDarkhast.Text.Trim())
                                   , Decimal.Parse(Txt_UnitPrice.Text.Trim()) , Decimal.Parse(Txt_Tajhfif.Text.Trim()), Decimal.Parse(Txt_FeeTotal.Text.Trim()));
                    Grd_Factor.DataSource = FactDt;
                }
                else
                {// 
                    float flt_Mojoodi2 = UDF_GetStackRate(int.Parse(Txt_FlowerCode.Text.Trim()));
                    //flt_Mojoodi2 += flt_darkhast;
                    if (flt_Mojoodi2 < (flt_darkhast + float.Parse(Txt_TedadeDarkhast.Text.Trim())))
                    {
                        MessageBox.Show("مقدار موجودی کافی نمی باشد");
                    }
                    else
                    {
                        foreach (DataRow Row in FactDt.Rows)// درج اقلام تکراری به لیست به صورت مجموع
                        {
                            if (int.Parse(Row[0].ToString().Trim()) == int.Parse(Txt_FlowerCode.Text.Trim()))
                            {
                                int_CntFound++;
                                float flt_Quantity = float.Parse(Row[2].ToString());
                                flt_Quantity += float.Parse(Txt_TedadeDarkhast.Text.Trim());
                                Decimal Dec_UnitPrice = Decimal.Parse(Row[3].ToString());
                                Decimal Dec_Takhfif = (Decimal.Parse(Row[4].ToString()) + Decimal.Parse(Txt_Tajhfif.Text.Trim()));
                                Decimal Dec_TotalPrice = ((Dec_UnitPrice * Decimal.Parse(flt_Quantity.ToString())) - Dec_Takhfif);

                                Row[2] = flt_Quantity.ToString();
                                Row[3] = Dec_UnitPrice.ToString();
                                Row[4] = Dec_Takhfif.ToString();
                                Row[5] = Dec_TotalPrice.ToString();
                            }
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (frm001 == null || frm001.IsDisposed)
            {
                frm001 = new frmSearchCustomer();
                frm001.passControl = new frmSearchCustomer.PassControl1(PassData);
                frm001.ShowDialog();
            }
            else
            {
                frm001.Dispose();
                frm001 = new frmSearchCustomer();
                frm001.passControl = new frmSearchCustomer.PassControl1(PassData);
                frm001.ShowDialog();
            }
        }

        private void PassData(object sender, int number)
        {
            Boolean Bln_Add_Detail = (Boolean)sender;
            int int_Details_Count = number;
            if (Bln_Add_Detail == true)
            {
                Txt_CustomerCode.Text = number.ToString();
            }
            else
            {
                MessageBox.Show("کد مشتری انتخاب نشده است");
            }
        }

        private void Txt_CustomerCode_TextChanged(object sender, EventArgs e)
        {
            LSC_RestuRantDataContext db = new LSC_RestuRantDataContext();
            try
            {
                tblCustomer tblCmr = db.tblCustomers.Single(n => n.CustomerID == Decimal.Parse(Txt_CustomerCode.Text.Trim()));
                Txt_NameSname.Text = tblCmr.CustomerName + " " + tblCmr.CustomerFamily;
                Txt_Phone.Text = tblCmr.CustomerTell;
                Txt_Mobile.Text = tblCmr.CustomerMobail;
                Txt_Address.Text = tblCmr.CustomerAddress;
            }
            catch
            {
            }
        }

        private void Txt_TedadeDarkhast_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Txt_FeeTotal.Text = ((Decimal.Parse(Txt_TedadeDarkhast.Text.Trim()) * Decimal.Parse(Txt_UnitPrice.Text.Trim())) - Decimal.Parse(Txt_Tajhfif.Text.Trim())).ToString();
            }
            catch
            { }
        }

        private void Txt_UnitPrice_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Txt_FeeTotal.Text = ((Decimal.Parse(Txt_TedadeDarkhast.Text.Trim()) * Decimal.Parse(Txt_UnitPrice.Text.Trim())) - Decimal.Parse(Txt_Tajhfif.Text.Trim())).ToString();
            }
            catch
            { }
        }

        private void Txt_Tajhfif_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Txt_FeeTotal.Text = ((Decimal.Parse(Txt_TedadeDarkhast.Text.Trim()) * Decimal.Parse(Txt_UnitPrice.Text.Trim())) - Decimal.Parse(Txt_Tajhfif.Text.Trim())).ToString();
            }
            catch
            { }
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            Int32 selectedCellCount = Grd_Factor.GetCellCount(DataGridViewElementStates.Selected);
            int int_FlowerID = -5;
            for (int i = 0; i < selectedCellCount; i++)
            {
               int_FlowerID = int.Parse(Grd_Factor.Rows[int.Parse(Grd_Factor.SelectedCells[i].RowIndex.ToString())].Cells[0].Value.ToString());
            }
            if (int_FlowerID == -5)
            {
                MessageBox.Show("آیتمی از فاکتور برای حذف انتخاب نشده است");
                return;
            }
            for (int i = FactDt.Rows.Count - 1; i >= 0; i--)
            {
                DataRow dr = FactDt.Rows[i];
                if (int.Parse(dr["FlowerID"].ToString()) == int_FlowerID)
                {
                    dr.Delete();
                }
            }
            Grd_Factor.DataSource = FactDt;
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            if (Txt_CustomerCode.Text == "")
            {
                MessageBox.Show("لطفا کد مشتری را انتخاب فرمائید");
                return;
            }
            GrPr_Mohasebeh.Enabled = true;
            Grpr_Custumer.Enabled = false;
            Grpr_Factor.Enabled = false;
            Decimal Dec_TotalPrice = 0;
            Decimal Dec_TotalTakhfif = 0;
            foreach (DataRow Row in FactDt.Rows)
            {
                Dec_TotalPrice += Decimal.Parse(Row[5].ToString());
                Dec_TotalTakhfif += Decimal.Parse(Row[4].ToString());
            }

            Lbl_Total_Price.Text = Dec_TotalPrice.ToString() + " ریال ";
            Lbl_Total_Takhfif.Text = Dec_TotalTakhfif.ToString() + " ریال ";
            Lbl_Total_Aglam.Text =  FactDt.Rows.Count.ToString() + " مورد ";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            GrPr_Mohasebeh.Enabled = false;
            Grpr_Custumer.Enabled = true;
            Grpr_Factor.Enabled = true;
            Lbl_Total_Aglam.Text = "0";
            Lbl_Total_Price.Text = "0";
            Lbl_Total_Takhfif.Text = "0";
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            LSC_RestuRantDataContext db = new LSC_RestuRantDataContext();
            tblFactorID tblFact = new tblFactorID();
            Class_ShamsiTools shDate = new Class_ShamsiTools();
            shDate.UDF_GetCurrentShamsiDate();

            tblFact.CustomerID = Decimal.Parse(Txt_CustomerCode.Text.Trim());
            tblFact.FactorShDate = shDate.CurrentShmasiDate;

            db.tblFactorIDs.InsertOnSubmit(tblFact);
            db.SubmitChanges();

            tblFactorDetail tblFID;
            foreach (DataRow Row in FactDt.Rows)
            {
                tblFID = new tblFactorDetail();
                tblFID.FactorID = tblFact.FactorID;
                tblFID.FlowerID = int.Parse(Row[0].ToString());
                tblFID.FlowerQuantity = float.Parse(Row[2].ToString());
                tblFID.UnitPrice = Decimal.Parse(Row[3].ToString());
                tblFID.Takhfif = Decimal.Parse(Row[4].ToString());
                tblFID.TaxRate = Decimal.Parse(Row[5].ToString());

                db.tblFactorDetails.InsertOnSubmit(tblFID);
                db.SubmitChanges();
            }

            Lbl_Total_Aglam.Text = "0";
            Lbl_Total_Price.Text = "0";
            Lbl_Total_Takhfif.Text = "0";
            GrPr_Mohasebeh.Enabled = false;
            Grpr_Custumer.Enabled = true;
            Grpr_Factor.Enabled = true;
            FactDt.Rows.Clear();

            for (int i = FactDt.Rows.Count - 1; i >= 0; i--)
            {
                DataRow dr = FactDt.Rows[i];
                {
                    dr.Delete();
                }
            }

            Grd_Factor.DataSource = FactDt;
            
            MessageBox.Show("کلیه موارد در پایگاه داده درج شدند");
            UDF_TXTFactorClear();
            UDF_TXTCustomerClear();
        }

        private void UDF_TXTCustomerClear()
        {
            Txt_CustomerCode.Text = "";
            Txt_NameSname.Text = "";
            Txt_Phone.Text = "";
            Txt_Mobile.Text = "";
            Txt_Address.Text = "";
        }
    }
}
