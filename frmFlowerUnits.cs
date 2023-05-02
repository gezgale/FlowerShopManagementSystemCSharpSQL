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
    public partial class frmFlowerUnits : Form
    {
        public frmFlowerUnits()
        {
            InitializeComponent();
        }

        private void frmFlowerUnits_Load(object sender, EventArgs e)
        {
            Class_tblLogs LogReg = new Class_tblLogs(this.Text + " فعال گردید.");
            LogReg.UDF_SaveLogToDb();
            UDF_GrdFill();
        }

        private void frmFlowerUnits_FormClosed(object sender, FormClosedEventArgs e)
        {
            Class_tblLogs LogReg = new Class_tblLogs(this.Text + " بسته شد.");
            LogReg.UDF_SaveLogToDb();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Txt_AssetUnit.Text = String.Empty;
            btnAdd.SendToBack();
            Btn_Save.BringToFront();
            MessageBox.Show("لطفا اطلاعات را وارد نمایید");
        }

        private void UDF_GrdFill()
        {
            LSC_RestuRantDataContext db = new LSC_RestuRantDataContext();
            var Query = from Row in db.tblFlowerUnits
                        orderby Row.FlowerUnitID descending
                        select new
                        {
                            Row.FlowerUnitID,
                            Row.FlowerUnitDescription
                        };
            dataGridView1.DataSource = Query;
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (Txt_AssetUnit.Text == "")
            {
                MessageBox.Show("ورود عنوان الزامی می باشد");
                return;
            }
            LSC_RestuRantDataContext db = new LSC_RestuRantDataContext();

            try
            {
                tblFlowerUnit FlowerUnt = db.tblFlowerUnits.Single(n => n.FlowerUnitDescription.Trim() == Txt_AssetUnit.Text.Trim());
                MessageBox.Show("رکورد وارد شده تکراری می باشد");
            }
            catch
            {
                tblFlowerUnit FlowerUnt = new tblFlowerUnit();
                FlowerUnt.FlowerUnitDescription = Txt_AssetUnit.Text.Trim();
                db.tblFlowerUnits.InsertOnSubmit(FlowerUnt);
                db.SubmitChanges();
                UDF_GrdFill();
                Txt_UnitID.Text = "";
                Txt_AssetUnit.Text = "";
                MessageBox.Show("رکورد جدید ثبت شد");
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
                        Txt_UnitID.Text = dataGridView1.Rows[int.Parse(dataGridView1.SelectedCells[i].RowIndex.ToString())].Cells[0].Value.ToString();
                        Txt_AssetUnit.Text = dataGridView1.Rows[int.Parse(dataGridView1.SelectedCells[i].RowIndex.ToString())].Cells[1].Value.ToString();
                    }
                }
            }
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            if (Txt_UnitID.Text == "" || Txt_AssetUnit.Text == "")
            {
                MessageBox.Show("لطفا عنوان را انتخاب");
                return;
            }

            DialogResult dr = MessageBox.Show("آیا نسبت به عمل ویرایش رکورد اطمینان دارید", "اخطار ویرایش", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                LSC_RestuRantDataContext db = new LSC_RestuRantDataContext();
                tblFlowerUnit FlowerUnt = db.tblFlowerUnits.Single(n => n.FlowerUnitID == int.Parse(Txt_UnitID.Text.Trim()));
                FlowerUnt.FlowerUnitDescription = Txt_AssetUnit.Text.Trim();
                db.SubmitChanges();
                Class_tblLogs LogReg = new Class_tblLogs(this.Text + " رکورد " + Txt_AssetUnit.Text.Trim() + " -ID= " + Txt_UnitID.Text.Trim() + "ویرایش");
                LogReg.UDF_SaveLogToDb();
                UDF_GrdFill();
                Txt_UnitID.Text = "";
                Txt_AssetUnit.Text = "";
            }
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            if (Txt_UnitID.Text == "" || Txt_AssetUnit.Text == "")
            {
                MessageBox.Show("لطفا عنوان را انتخاب");
                return;
            }

            DialogResult dr = MessageBox.Show("آیا نسبت به عمل حذف رکورد اطمینان دارید", "اخطار حذف", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                Class_tblLogs LogReg = new Class_tblLogs(this.Text + " رکورد " + Txt_AssetUnit.Text.Trim() + " -ID= " + Txt_UnitID.Text.Trim() + "حذف");
                LogReg.UDF_SaveLogToDb();
                LSC_RestuRantDataContext db = new LSC_RestuRantDataContext();
                tblFlowerUnit FlowerUnt = db.tblFlowerUnits.Single(n => n.FlowerUnitID == int.Parse(Txt_UnitID.Text.Trim()));
                db.tblFlowerUnits.DeleteOnSubmit(FlowerUnt);
                db.SubmitChanges();
                UDF_GrdFill();
            }
            Txt_UnitID.Text = "";
            Txt_AssetUnit.Text = "";
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            if (Txt_AssetUnit.Text == "")
            {
                MessageBox.Show("لطفا عنوان یا بخشی از عنوان را برای جستجو وارد نمائید.");
                return;
            }
            LSC_RestuRantDataContext db = new LSC_RestuRantDataContext();
            var Query = from Row in db.tblFlowerUnits
                        where SqlMethods.Like(Row.FlowerUnitDescription, "%" + Txt_AssetUnit.Text.Trim() + "%")
                        select new
                        {
                            Row.FlowerUnitID,
                            Row.FlowerUnitDescription
                        };
            dataGridView1.DataSource = Query;
            Class_tblLogs LogReg = new Class_tblLogs(this.Text + " - عملیات جستجو");
            LogReg.UDF_SaveLogToDb();
            if (Query.Count() <= 0)
            {
                Txt_AssetUnit.Text = "";
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
