using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Data.Linq.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace FlowerShop
{
    public partial class frmFlowerCategury : Form
    {
        public frmFlowerCategury()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Txt_FlowerCategury.Text = String.Empty;
            btnAdd.SendToBack();
            Btn_Save.BringToFront();
            MessageBox.Show("لطفا اطلاعات را وارد نمایید");
        }

        private void frmFoodCategury_Load(object sender, EventArgs e)
        {
            Class_tblLogs LogReg = new Class_tblLogs(this.Text + " فعال گردید.");
            LogReg.UDF_SaveLogToDb();

            UDF_GrdFill();
        }

        private void UDF_GrdFill()
        {
            LSC_RestuRantDataContext db = new LSC_RestuRantDataContext();
            var Query = from Row in db.tblFlowerCateguries
                        orderby Row.FlowerCateguryID descending
                        select new
                        {
                            Row.FlowerCateguryID,
                            Row.FlowerCateguryDescription
                        };
            dataGridView1.DataSource = Query;
        }

        private void frmFoodCategury_FormClosed(object sender, FormClosedEventArgs e)
        {
            Class_tblLogs LogReg = new Class_tblLogs(this.Text + " بسته شد.");
            LogReg.UDF_SaveLogToDb();
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
                        Txt_CateguryID.Text = dataGridView1.Rows[int.Parse(dataGridView1.SelectedCells[i].RowIndex.ToString())].Cells[0].Value.ToString();
                        Txt_FlowerCategury.Text = dataGridView1.Rows[int.Parse(dataGridView1.SelectedCells[i].RowIndex.ToString())].Cells[1].Value.ToString();
                    }
                }
            }
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (Txt_FlowerCategury.Text == "")
            {
                MessageBox.Show("ورود عنوان الزامی می باشد");
                return;
            }
            else
            {
                LSC_RestuRantDataContext db = new LSC_RestuRantDataContext();
                try
                {
                    tblFlowerCategury FoodCtg = db.tblFlowerCateguries.Single(n => n.FlowerCateguryDescription.Trim() == Txt_FlowerCategury.Text.Trim());
                    MessageBox.Show("رکورد وارد شده تکراری می باشد");
                }
                catch
                {
                    tblFlowerCategury FoodCtg = new tblFlowerCategury();
                    FoodCtg.FlowerCateguryDescription = Txt_FlowerCategury.Text.Trim();
                    db.tblFlowerCateguries.InsertOnSubmit(FoodCtg);
                    db.SubmitChanges();
                    UDF_GrdFill();
                    btnAdd.BringToFront();
                    Btn_Save.SendToBack();
                    MessageBox.Show("رکورد جدید درج گردید.");
                }
            }
            Txt_FlowerCategury.Text = "";
            Txt_CateguryID.Text = "";
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            if (Txt_CateguryID.Text == "" || Txt_FlowerCategury.Text == "")
            {
                MessageBox.Show("لطفا عنوان را انتخاب");
                return;
            }

            DialogResult dr = MessageBox.Show("آیا نسبت به عمل ویرایش رکورد اطمینان دارید", "اخطار ویرایش", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                LSC_RestuRantDataContext db = new LSC_RestuRantDataContext();
                tblFlowerCategury FoodCtg = db.tblFlowerCateguries.Single(n => n.FlowerCateguryID == Decimal.Parse(Txt_CateguryID.Text.Trim()));
                FoodCtg.FlowerCateguryDescription = Txt_FlowerCategury.Text.Trim();
                db.SubmitChanges();
                Class_tblLogs LogReg = new Class_tblLogs(this.Text + " رکورد " + Txt_FlowerCategury.Text.Trim() + " -ID= " + Txt_CateguryID.Text.Trim() + "ویرایش");
                LogReg.UDF_SaveLogToDb();
                UDF_GrdFill();
            }
            Txt_FlowerCategury.Text = "";
            Txt_CateguryID.Text = "";
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            if (Txt_CateguryID.Text == "" || Txt_FlowerCategury.Text == "")
            {
                MessageBox.Show("لطفا عنوان را انتخاب");
                return;
            }

            DialogResult dr = MessageBox.Show("آیا نسبت به عمل حذف رکورد اطمینان دارید", "اخطار حذف", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                LSC_RestuRantDataContext db = new LSC_RestuRantDataContext();
                tblFlowerCategury FoodCtg = db.tblFlowerCateguries.Single(n => n.FlowerCateguryID == Decimal.Parse(Txt_CateguryID.Text.Trim()));
                db.tblFlowerCateguries.DeleteOnSubmit(FoodCtg);
                db.SubmitChanges();
                Class_tblLogs LogReg = new Class_tblLogs(this.Text + " رکورد " + Txt_FlowerCategury.Text.Trim() + " -ID= " + Txt_CateguryID.Text.Trim() + "حذف شد");
                LogReg.UDF_SaveLogToDb();
                UDF_GrdFill();
            }
            Txt_FlowerCategury.Text = "";
            Txt_CateguryID.Text = "";
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            if (Txt_FlowerCategury.Text == "")
            {
                MessageBox.Show("لطفا عنوان یا بخشی از عنوان را برای جستجو وارد نمائید.");
                return;
            }
            LSC_RestuRantDataContext db = new LSC_RestuRantDataContext();
            var Query = from Row in db.tblFlowerCateguries
                       where SqlMethods.Like(Row.FlowerCateguryDescription , "%" + Txt_FlowerCategury.Text.Trim() + "%")
                        select new
                        {
                            Row.FlowerCateguryID,
                            Row.FlowerCateguryDescription
                        };
            dataGridView1.DataSource = Query;
            Class_tblLogs LogReg = new Class_tblLogs(this.Text + " - عملیات جستجو");
            LogReg.UDF_SaveLogToDb();
            if (Query.Count() <= 0)
            {
                Txt_FlowerCategury.Text = "";
                Btn_Refresh.BringToFront();
                Btn_Search.SendToBack();
                MessageBox.Show("رکوردی یافته نشد");
            }
        }

        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            UDF_GrdFill();
            Btn_Refresh.SendToBack();
            Btn_Search.BringToFront();
        }
    }
}
