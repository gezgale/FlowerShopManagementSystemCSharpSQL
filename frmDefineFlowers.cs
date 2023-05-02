using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.Linq.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace FlowerShop
{
    public partial class frmDefineFlowers : Form
    {
        public frmDefineFlowers()
        {
            InitializeComponent();
        }

        private void frmDefineFoods_Load(object sender, EventArgs e)
        {
            Class_tblLogs LogReg = new Class_tblLogs(this.Text + " فعال گردید.");
            LogReg.UDF_SaveLogToDb();
            UDF_CmbFill();
            UDF_GrdFill();
        }

        private void frmDefineFoods_FormClosed(object sender, FormClosedEventArgs e)
        {
            Class_tblLogs LogReg = new Class_tblLogs(this.Text + " بسته شد.");
            LogReg.UDF_SaveLogToDb();
        }

        private void UDF_CmbFill()
        {
            LSC_RestuRantDataContext db = new LSC_RestuRantDataContext();
            var Query1 = from Row in db.tblFlowerUnits
                        orderby Row.FlowerUnitID descending
                        select new
                        {
                            Row.FlowerUnitID,
                            Row.FlowerUnitDescription
                        };
            var Query2 = from Row in db.tblFlowerCateguries
                         orderby Row.FlowerCateguryID descending
                         select new
                         {
                             Row.FlowerCateguryID,
                             Row.FlowerCateguryDescription
                         };

            Cmb_FlowerUnit.DisplayMember = "FlowerUnitDescription";
            Cmb_FlowerUnit.ValueMember = "FlowerUnitID";

            Cmb_FlowerCategury.DisplayMember = "FlowerCateguryDescription";
            Cmb_FlowerCategury.ValueMember = "FlowerCateguryID";

            Cmb_FlowerUnit.DataSource = Query1;
            Cmb_FlowerCategury.DataSource = Query2;
        }

        private void UDF_GrdFill()
        {
            LSC_RestuRantDataContext db = new LSC_RestuRantDataContext();
            var Query = from Row in db.tblFlowerDescriptions
                         orderby Row.FlowerID descending
                         select new
                         {
                             Row.FlowerID,
                             Row.FlowerDescription,
                             Row.tblFlowerCategury.FlowerCateguryDescription,
                             Row.tblFlowerUnit.FlowerUnitDescription
                         };
            dataGridView1.DataSource = Query;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Txt_FlowerDescription.Text = String.Empty;
            btnAdd.SendToBack();
            Btn_Save.BringToFront();
            Txt_FlowerDescription.Clear();
            MessageBox.Show("لطفا اطلاعات را وارد نمایید");
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (Txt_FlowerDescription.Text == "")
            {
                MessageBox.Show("ورود عنوان الزامی می باشد");
                return;
            }

            LSC_RestuRantDataContext db = new LSC_RestuRantDataContext();

            try
            {
                tblFlowerDescription FlowerDs = db.tblFlowerDescriptions.Single(n => n.FlowerDescription.Trim() == Txt_FlowerDescription.Text.Trim());
                MessageBox.Show("نام  وارد شده تکراری می باشد");
            }
            catch
            {
                tblFlowerDescription FlowerDs = new tblFlowerDescription();

                FlowerDs.FlowerDescription = Txt_FlowerDescription.Text.Trim();
                FlowerDs.FlowerCateguryID = Decimal.Parse(Cmb_FlowerCategury.SelectedValue.ToString());
                FlowerDs.FlowerUnitID = int.Parse(Cmb_FlowerUnit.SelectedValue.ToString());

                db.tblFlowerDescriptions.InsertOnSubmit(FlowerDs);
                db.SubmitChanges();

                UDF_GrdFill();
                UDF_CmbFill();
                btnAdd.BringToFront();
                Btn_Save.SendToBack();
                Txt_FlowerDescription.Clear();
                MessageBox.Show("رکورد جدید درج گردید.");
            }


        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            if (Txt_FlowerDescription.Text == "" || Txt_FoodID.Text == "")
            {
                MessageBox.Show("لطفا عنوان را انتخاب فرمائید.");
                return;
            }
            if (Cmb_FlowerUnit.Text == "" || Cmb_FlowerCategury.Text =="")
            {
                MessageBox.Show("انتخاب دسته بندی و واحد شمارش الزامی می باشد");
                return;
            }

            DialogResult dr = MessageBox.Show("آیا نسبت به عمل ویرایش رکورد اطمینان دارید", "اخطار ویرایش", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                LSC_RestuRantDataContext db = new LSC_RestuRantDataContext();
                tblFlowerDescription FlowerDs = db.tblFlowerDescriptions.Single(n => n.FlowerID == int.Parse(Txt_FoodID.Text.Trim()));

                FlowerDs.FlowerDescription = Txt_FlowerDescription.Text.Trim();
                FlowerDs.FlowerUnitID = int.Parse(Cmb_FlowerUnit.SelectedValue.ToString());
                FlowerDs.FlowerCateguryID = Decimal.Parse(Cmb_FlowerCategury.SelectedValue.ToString());

                db.SubmitChanges();
                Class_tblLogs LogReg = new Class_tblLogs(this.Text + " رکورد " + Txt_FlowerDescription.Text.Trim() + " -ID= " + Txt_FoodID.Text.Trim() + "ویرایش");
                LogReg.UDF_SaveLogToDb();

                Txt_FoodID.Clear();
                Txt_FlowerDescription.Clear();
                UDF_CmbFill();
                UDF_GrdFill();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 selectedCellCount = dataGridView1.GetCellCount(DataGridViewElementStates.Selected);

            if (selectedCellCount > 0)
            {
                if (dataGridView1.AreAllCellsSelected(true))
                {
                    MessageBox.Show("All cells are selected", "Selected Cells");
                }
                else
                {
                    System.Text.StringBuilder sb = new System.Text.StringBuilder();
                    for (int i = 0; i < selectedCellCount; i++)
                    {
                        Txt_FoodID.Text = dataGridView1.Rows[int.Parse(dataGridView1.SelectedCells[i].RowIndex.ToString())].Cells[0].Value.ToString();
                        Txt_FlowerDescription.Text = dataGridView1.Rows[int.Parse(dataGridView1.SelectedCells[i].RowIndex.ToString())].Cells[1].Value.ToString();
                    }
                    UDF_SelectCmbValue(int.Parse(Txt_FoodID.Text.Trim()));
                }
            }
        }

        private void UDF_SelectCmbValue(int int_FlowerUD)
        {
            LSC_RestuRantDataContext db = new LSC_RestuRantDataContext();
            tblFlowerDescription FlowerDs = db.tblFlowerDescriptions.Single(n => n.FlowerID == int_FlowerUD);
            Cmb_FlowerUnit.SelectedValue = FlowerDs.FlowerUnitID;
            Cmb_FlowerCategury.SelectedValue = FlowerDs.FlowerCateguryID;
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            if (Txt_FlowerDescription.Text == "" || Txt_FoodID.Text == "")
            {
                MessageBox.Show("لطفا عنوان را انتخاب فرمائید.");
                return;
            }

            DialogResult dr = MessageBox.Show("آیا نسبت به عمل حذف رکورد اطمینان دارید", "اخطار حذف", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                LSC_RestuRantDataContext db = new LSC_RestuRantDataContext();
                tblFlowerDescription FlowerDs = db.tblFlowerDescriptions.Single(n => n.FlowerID == int.Parse(Txt_FoodID.Text.Trim()));

                Class_tblLogs LogReg = new Class_tblLogs(this.Text + " رکورد " + Txt_FlowerDescription.Text.Trim() + " -ID= " + Txt_FoodID.Text.Trim() + "حذف");
                LogReg.UDF_SaveLogToDb();

                db.tblFlowerDescriptions.DeleteOnSubmit(FlowerDs);
                db.SubmitChanges();

                Txt_FoodID.Clear();
                Txt_FlowerDescription.Clear();
                UDF_CmbFill();
                UDF_GrdFill();
            }
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            if (Txt_FlowerDescription.Text == "")
            {
                MessageBox.Show("لطفا عنوان یا بخشی از عنوان را برای جستجو وارد نمائید.");
                return;
            }
            LSC_RestuRantDataContext db = new LSC_RestuRantDataContext();
            var Query = from Row in db.tblFlowerDescriptions
                       where SqlMethods.Like(Row.FlowerDescription , "%" + Txt_FlowerDescription.Text.Trim() + "%")
                       select new 
                       {
                           Row.FlowerID,
                           Row.FlowerDescription,
                           Row.tblFlowerCategury.FlowerCateguryDescription,
                           Row.tblFlowerUnit.FlowerUnitDescription
                       };
            dataGridView1.DataSource = Query;
            Class_tblLogs LogReg = new Class_tblLogs(this.Text + " - عملیات جستجو");
            LogReg.UDF_SaveLogToDb();
            if (Query.Count() <= 0)
            {
                Txt_FlowerDescription.Text = "";
                Txt_FoodID.Clear();
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
            Txt_FlowerDescription.Clear();
            Txt_FoodID.Clear();
        }

        private void Cmb_FoodUnit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}