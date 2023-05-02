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
    public partial class frmMojodi : Form
    {
        public frmMojodi()
        {
            InitializeComponent();
        }

        private void UDF_GrdFill()
        {
            LSC_RestuRantDataContext db = new LSC_RestuRantDataContext();
            var Query = from Row in db.tblMojodis 
                        orderby Row.RowMojodi  descending
                        select new
                        {
                            Row.RowMojodi,
                            Row.FlowerID,
                            Row.tblFlowerDescription.FlowerDescription,
                            Row.EnterDate,
                            Row.NumberOfFlower, 
                            Row.UnitPrice
                        };
            Grd_Mojodi.DataSource = Query;
        }



        private void UDF_CmbFill()
        {
            LSC_RestuRantDataContext db = new LSC_RestuRantDataContext();
            var Query1 = from Row in db.tblFlowerDescriptions 
                         orderby Row.FlowerID descending
                         select new
                         {
                             Row.FlowerID,
                             Row.FlowerDescription 
                         };

            Cmb_FlowerDes.DisplayMember = "FlowerDescription";
            Cmb_FlowerDes.ValueMember = "FlowerID";
            Cmb_FlowerDes.DataSource = Query1;
            
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            Txt_FlowerUnit.Text = String.Empty;
            btnAdd.SendToBack();
            Btn_Save.BringToFront();
            Txt_FlowerUnit.Clear();
            MessageBox.Show("لطفا موجودی غذا را وارد نمایید");
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (Txt_FlowerUnit.Text == "")
            {
                MessageBox.Show("ورود تعداد غذا الزامی می باشد");
                return;
            }

            if (Txt_UnitPrice.Text == "")
            {
                MessageBox.Show("ورود قیمت واحد غذا الزامی می باشد");
                return;
            }

            LSC_RestuRantDataContext db = new LSC_RestuRantDataContext();
            
            Class_ShamsiTools shamsi = new Class_ShamsiTools();
            shamsi.UDF_GetCurrentShamsiDate();
            try
            {
                tblMojodi mojodi = db.tblMojodis.Single(n => n.EnterDate.Trim() == shamsi.CurrentShmasiDate.Trim() && n.FlowerID == int.Parse(Cmb_FlowerDes.SelectedValue.ToString()));
                MessageBox.Show("رکورد وارد شده تکراری می باشد");
            }
            catch
            {
                tblMojodi mojodi = new tblMojodi();
                mojodi.FlowerID = int.Parse(Cmb_FlowerDes.SelectedValue.ToString());
                mojodi.EnterDate = shamsi.CurrentShmasiDate;
                mojodi.NumberOfFlower = float.Parse(Txt_FlowerUnit.Text.Trim());
                mojodi.UnitPrice = decimal.Parse(Txt_UnitPrice.Text.Trim());


                db.tblMojodis.InsertOnSubmit(mojodi);
                db.SubmitChanges();

                UDF_GrdFill();
                UDF_CmbFill();
                btnAdd.BringToFront();
                Btn_Save.SendToBack();
                Txt_FlowerUnit.Clear();
                Txt_UnitPrice.Clear();
                MessageBox.Show("رکورد جدید درج گردید.");
            }
        }

        private void frmMojodi_Load(object sender, EventArgs e)
        {
            Btn_Edit.BringToFront();
            Class_tblLogs LogReg = new Class_tblLogs(this.Text + " فعال گردید.");
            LogReg.UDF_SaveLogToDb();
            UDF_CmbFill();
            UDF_GrdFill();
        }

        private void Grd_Mojodi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 selectedCellCount = Grd_Mojodi. GetCellCount(DataGridViewElementStates.Selected);

            if (selectedCellCount > 0)
            {
                if (Grd_Mojodi.AreAllCellsSelected(true))
                {
                    MessageBox.Show("All cells are selected", "Selected Cells");
                }
                else
                {
                    System.Text.StringBuilder sb = new System.Text.StringBuilder();
                    for (int i = 0; i < selectedCellCount; i++)
                    {
                        Txt_FlowerID.Text = Grd_Mojodi.Rows[int.Parse(Grd_Mojodi.SelectedCells[i].RowIndex.ToString())].Cells[1].Value.ToString();
                        Txt_FlowerUnit.Text = Grd_Mojodi.Rows[int.Parse(Grd_Mojodi.SelectedCells[i].RowIndex.ToString())].Cells[4].Value.ToString();
                        Txt_Date.Text = Grd_Mojodi.Rows[int.Parse(Grd_Mojodi.SelectedCells[i].RowIndex.ToString())].Cells[3].Value.ToString();
                        Txt_UnitPrice.Text = Grd_Mojodi.Rows[int.Parse(Grd_Mojodi.SelectedCells[i].RowIndex.ToString())].Cells[5].Value.ToString();
                        Cmb_FlowerDes.SelectedValue = int.Parse(Grd_Mojodi.Rows[int.Parse(Grd_Mojodi.SelectedCells[i].RowIndex.ToString())].Cells[1].Value.ToString());
                        //MessageBox.Show(Grd_Mojodi.Rows[int.Parse(Grd_Mojodi.SelectedCells[i].RowIndex.ToString())].Cells[1].Value.ToString());
                    }
                    //UDF_SelectCmbValue(int.Parse(Txt_FlowerUnit.Text.Trim()));
                }
            }
        }

        //private void UDF_SelectCmbValue(int int_FlowerUD)
        //{
        //    LSC_RestuRantDataContext db = new LSC_RestuRantDataContext();
        //    tblFlowersDescription FlowerDs = db.tblFlowersDescriptions.Single(n => n.FlowerID == int_FlowerUD);
        //    Cmb_FlowerDes.SelectedValue = FlowerDs.FlowerDescription;
        //}

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            Txt_FlowerUnit.Enabled = false;
            Cmb_FlowerDes.Enabled = false;
            Btn_Edit.SendToBack();
            Btn_SaveEdit.BringToFront();

            if (Txt_UnitPrice.Text == "" || Txt_FlowerUnit.Text == "")
            {
                MessageBox.Show("رکوردی برای ویرایش انتخاب نشده");
            }
         
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            if (Txt_FlowerID.Text == "")
            {
                MessageBox.Show("لطفا عنوان را انتخاب فرمائید.");
                return;
            }

            DialogResult dr = MessageBox.Show("آیا نسبت به عمل حذف رکورد اطمینان دارید", "اخطار حذف", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                LSC_RestuRantDataContext db = new LSC_RestuRantDataContext();
                tblFlowerDescription FlowerDs = db.tblFlowerDescriptions.Single(n => n.FlowerID == int.Parse(Txt_FlowerID.Text.Trim()));

                Class_tblLogs LogReg = new Class_tblLogs(this.Text + " رکورد " + Cmb_FlowerDes.SelectedItem.ToString() + " -ID= " + Txt_FlowerID.Text.Trim() + "حذف");
                LogReg.UDF_SaveLogToDb();

                db.tblFlowerDescriptions.DeleteOnSubmit(FlowerDs);
                db.SubmitChanges();

                Txt_FlowerID.Clear();
                Txt_FlowerUnit.Clear();
                Txt_UnitPrice.Clear();
                UDF_CmbFill();
                UDF_GrdFill();
            }
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            if (Txt_Search.Text == "")
            {
                MessageBox.Show("لطفا عنوان یا بخشی از عنوان را برای جستجو وارد نمائید.");
                return;
            }
            LSC_RestuRantDataContext db = new LSC_RestuRantDataContext();
            var Query = from Row in db.tblMojodis 
                        where SqlMethods.Like(Row.tblFlowerDescription.FlowerDescription , "%" + Txt_Search.Text.Trim() + "%")
                        select new
                        {
                            Row.RowMojodi,
                            Row.FlowerID,
                            Row.tblFlowerDescription.FlowerDescription,
                            Row.EnterDate,
                            Row.NumberOfFlower,
                            Row.UnitPrice
                        };
            Grd_Mojodi.DataSource = Query;
            Class_tblLogs LogReg = new Class_tblLogs(this.Text + " - عملیات جستجو");
            LogReg.UDF_SaveLogToDb();
            if (Query.Count() <= 0)
            {
                Txt_FlowerUnit.Text = "";
                Txt_FlowerID.Clear();
                Txt_UnitPrice.Text = "";
                Btn_Refresh.BringToFront();
                Btn_Search.SendToBack();
                MessageBox.Show("رکوردی یافته نشد");
            }
        }

        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            UDF_GrdFill();
            UDF_CmbFill();
            Btn_Refresh.SendToBack();
            Btn_Search.BringToFront();
            Txt_FlowerUnit.Clear();
            Txt_FlowerID.Clear();
            Txt_UnitPrice.Clear();
        }

        private void Btn_SaveEdit_Click(object sender, EventArgs e)
        {
            if (Txt_FlowerID.Text == "")
            {
                MessageBox.Show("لطفا عنوان یا بخشی از عنوان را انتخاب فرمائید.");
                return;
            }

            if (Txt_UnitPrice.Text == "")
            {
                MessageBox.Show("لطفا عنوان یا بخشی از عنوان را انتخاب فرمائید.");
                return;
            }

            if (Cmb_FlowerDes.Text == "")
            {
                MessageBox.Show("لطفا عنوان یا بخشی از عنوان را انتخاب فرمائید.");
                return;
            }

            DialogResult dr = MessageBox.Show("آیا نسبت به عمل ویرایش رکورد اطمینان دارید", "اخطار ویرایش", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                LSC_RestuRantDataContext db = new LSC_RestuRantDataContext();
                tblMojodi mogodi = db.tblMojodis.Single(n => n.FlowerID == int.Parse(Txt_FlowerID.Text.Trim()) && n.EnterDate == Txt_Date.Text.Trim() && n.NumberOfFlower == Double.Parse(Txt_FlowerUnit.Text.Trim()));
                Class_ShamsiTools shamsi = new Class_ShamsiTools();
                shamsi.UDF_GetCurrentShamsiDate();
                //mogodi.FlowerID = int.Parse(Cmb_FlowerDes.SelectedValue.ToString());
                //mogodi.EnterDate = shamsi.CurrentShmasiDate;
                mogodi.UnitPrice = Decimal.Parse(Txt_UnitPrice.Text.Trim());

                db.SubmitChanges();
                Class_tblLogs LogReg = new Class_tblLogs(this.Text + " رکورد " + Txt_FlowerUnit.Text.Trim() + " -ID= " + Txt_FlowerID.Text.Trim() + "ویرایش");
                LogReg.UDF_SaveLogToDb();

                Txt_FlowerID.Clear();
                Txt_FlowerUnit.Clear();
                Txt_UnitPrice.Clear();
                UDF_CmbFill();
                UDF_GrdFill();

                Cmb_FlowerDes.Enabled = true;
                Txt_FlowerUnit.Enabled = true;
                Txt_UnitPrice.Enabled = true;

                Btn_SaveEdit.SendToBack();
                Btn_Edit.BringToFront();

            }
        }
    }
}
