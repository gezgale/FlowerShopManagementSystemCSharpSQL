using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Linq.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FlowerShop
{
    public partial class frmEditUsers : Form
    {
        public frmEditUsers()
        {
            InitializeComponent();
        }


        private void UDF_ClearTextBox()
        {
            Txt_UseID.Clear();
            Txt_UserName.Clear();
            Txt_Password.Clear();
            Txt_Name.Clear();
            Txt_Family.Clear();
            Txt_Tell.Clear();
            Txt_Mobail.Clear();
            Chb_BanBit.Checked = false;
        }

        private void UDF_CmbFill()
        {
            LSC_RestuRantDataContext db = new LSC_RestuRantDataContext();
            var Query1 = from Row in db.tblUserTypes
                         orderby Row.UserTypeID descending
                         where Row.UserTypeID != 3
                         select new
                         {
                             Row.UserTypeID,
                             Row.UsersTypeDescription
                         };

            Cmb_UserType.DisplayMember = "UsersTypeDescription";
            Cmb_UserType.ValueMember = "UserTypeID";

            Cmb_UserType.DataSource = Query1;
        }


        private void UDF_GrdFill()
        {
            LSC_RestuRantDataContext db = new LSC_RestuRantDataContext();
            if (int.Parse(Class_GlobalVar.Str_LogedUserTypeID) == 1)
            {
                var Query = from Row in db.tblUsers
                            orderby Row.UsersID descending
                            where Row.UserTypeID != 3
                            select new
                                {
                                    Row.UsersID,
                                    Row.UsersName,
                                    Row.UsersPass,
                                    Row.UserFName,
                                    Row.UsersSName,
                                    Row.tblUserType.UsersTypeDescription,
                                    Row.UserTell,
                                    Row.UserMobail,
                                    Row.UserBanBit
                                };
                dataGridView1.DataSource = Query;
            }
            else
            {
                var Query = from Row in db.tblUsers
                            orderby Row.UsersID descending
                            where Row.UsersID == int.Parse(Class_GlobalVar.Str_LogedUserID)
                            select new
                            {
                                Row.UsersID,
                                Row.UsersName,
                                Row.UsersPass,
                                Row.UserFName,
                                Row.UsersSName,
                                Row.tblUserType.UsersTypeDescription,
                                Row.UserTell,
                                Row.UserMobail,
                                Row.UserBanBit
                            };
                dataGridView1.DataSource = Query;
                Cmb_UserType.Enabled = false;
                btnAdd.Enabled = false;
                Btn_Delete.Enabled = false;
                Btn_Search.Enabled = false;
            }
        }



        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (Txt_UserName.Text == "" || Txt_Password.Text == "" || Txt_Name.Text == "" || Txt_Family.Text == "" || Txt_Tell.Text == "" || Txt_Mobail.Text == "")
            {
                MessageBox.Show("ورود موارد خواسته شده الزامی می باشد");
                return;
            }

            LSC_RestuRantDataContext db = new LSC_RestuRantDataContext();
            try
            {
                tblUser user = db.tblUsers.Single(n => n.UsersName.Trim() == Txt_UserName.Text.Trim());
                MessageBox.Show("نام کاربری وارد شده تکراری می باشد");
            }
            catch
            {
                tblUser user = new tblUser();
                user.UsersName = Txt_UserName.Text.Trim();
                user.UsersPass = Txt_Password.Text.Trim();
                user.UserFName = Txt_Name.Text.Trim();
                user.UsersSName = Txt_Family.Text.Trim();
                user.UserTypeID = int.Parse(Cmb_UserType.SelectedValue.ToString());
                user.UserTell = Txt_Tell.Text.Trim();
                user.UserMobail = Txt_Mobail.Text.Trim();
                user.UserBanBit = Chb_BanBit.Checked;

                db.tblUsers.InsertOnSubmit(user);
                db.SubmitChanges();

                UDF_GrdFill();
                UDF_CmbFill();

                btnAdd.BringToFront();
                Btn_Save.SendToBack();
                UDF_ClearTextBox();

                MessageBox.Show("رکورد جدید درج گردید.");
            }

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            Txt_UseID.Text = String.Empty;
            Txt_UserName.Text = String.Empty;
            Txt_Password.Text = String.Empty;
            Txt_Name.Text = String.Empty;
            Txt_Family.Text = String.Empty;
            Txt_Tell.Text = String.Empty;
            Txt_Mobail.Text = String.Empty;
            Chb_BanBit.Checked = false;

            btnAdd.SendToBack();
            Btn_Save.BringToFront();
            UDF_ClearTextBox();
            MessageBox.Show("لطفا اطلاعات را وارد نمایید");

        }

        private void Cmb_UserType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmEditUsers_Load(object sender, EventArgs e)
        {
            Class_tblLogs LogReg = new Class_tblLogs(this.Text + " فعال گردید.");
            LogReg.UDF_SaveLogToDb();
            UDF_CmbFill();
            UDF_GrdFill();
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            if (Txt_UseID.Text == "")
            {
                MessageBox.Show("لطفا کاربر مورد نظر را انتخاب فرمائید.");
                return;
            }

            DialogResult dr = MessageBox.Show("آیا نسبت به عمل حذف رکورد اطمینان دارید", "اخطار حذف", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                LSC_RestuRantDataContext db = new LSC_RestuRantDataContext();

                tblUser user = db.tblUsers.Single(n => n.UsersID == int.Parse(Txt_UseID.Text.Trim()));

                Class_tblLogs LogReg = new Class_tblLogs(this.Text + " رکورد " + Txt_UseID.Text.Trim() + " -ID= " + Txt_UseID.Text.Trim() + "حذف");
                LogReg.UDF_SaveLogToDb();

                db.tblUsers.DeleteOnSubmit(user);
                db.SubmitChanges();

                UDF_ClearTextBox();
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
                        Boolean Bln_Chk;
                        Txt_UseID.Text = dataGridView1.Rows[int.Parse(dataGridView1.SelectedCells[i].RowIndex.ToString())].Cells[0].Value.ToString();
                        Txt_UserName.Text = dataGridView1.Rows[int.Parse(dataGridView1.SelectedCells[i].RowIndex.ToString())].Cells[1].Value.ToString();
                        Txt_Password.Text = dataGridView1.Rows[int.Parse(dataGridView1.SelectedCells[i].RowIndex.ToString())].Cells[2].Value.ToString();
                        Txt_Name.Text = dataGridView1.Rows[int.Parse(dataGridView1.SelectedCells[i].RowIndex.ToString())].Cells[3].Value.ToString();
                        Txt_Family.Text = dataGridView1.Rows[int.Parse(dataGridView1.SelectedCells[i].RowIndex.ToString())].Cells[4].Value.ToString();
                        Txt_Tell.Text = dataGridView1.Rows[int.Parse(dataGridView1.SelectedCells[i].RowIndex.ToString())].Cells[6].Value.ToString();
                        Txt_Mobail.Text = dataGridView1.Rows[int.Parse(dataGridView1.SelectedCells[i].RowIndex.ToString())].Cells[7].Value.ToString();
                        Bln_Chk = Boolean.Parse(dataGridView1.Rows[int.Parse(dataGridView1.SelectedCells[i].RowIndex.ToString())].Cells[8].Value.ToString());

                        if (Bln_Chk == true)
                        {
                            Chb_BanBit.Checked = true;
                        }
                        else if (Bln_Chk == false)
                        {
                            Chb_BanBit.Checked = false;
                        }
                    }
                    UDF_SelectCmbValue(int.Parse(Txt_UseID.Text.Trim()));
                }
            }
        }

        private void UDF_SelectCmbValue(int int_UserID)
        {
            LSC_RestuRantDataContext db = new LSC_RestuRantDataContext();
            tblUser user = db.tblUsers.Single(n => n.UsersID == int_UserID);
            Cmb_UserType.SelectedValue = user.UserTypeID;
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            if (Txt_UseID.Text == "")
            {
                MessageBox.Show("لطفا کاربر مورد نظر را انتخاب فرمائید.");
                return;
            }
            if (Cmb_UserType.Text == "")
            {
                MessageBox.Show("انتخاب نوع کاربر الزامی می باشد");
                return;
            }

            DialogResult dr = MessageBox.Show("آیا نسبت به عمل ویرایش رکورد اطمینان دارید", "اخطار ویرایش", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                LSC_RestuRantDataContext db = new LSC_RestuRantDataContext();
                tblUser user = db.tblUsers.Single(n => n.UsersID == int.Parse(Txt_UseID.Text.Trim()));

                user.UsersName = Txt_UserName.Text.Trim();
                user.UsersPass = Txt_Password.Text.Trim();
                user.UserFName = Txt_Name.Text.Trim();
                user.UsersSName = Txt_Family.Text.Trim();
                user.UserTypeID = int.Parse(Cmb_UserType.SelectedValue.ToString());
                user.UserTell = Txt_Tell.Text.Trim();
                user.UserMobail = Txt_Mobail.Text.Trim();
                user.UserBanBit = Chb_BanBit.Checked;

                db.SubmitChanges();
                Class_tblLogs LogReg = new Class_tblLogs(this.Text + " رکورد " + Txt_UserName.Text.Trim() + " -ID= " + Txt_UseID.Text.Trim() + "ویرایش");
                LogReg.UDF_SaveLogToDb();

                UDF_ClearTextBox();
                UDF_CmbFill();
                UDF_GrdFill();
            }
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            if (Txt_Search.Text == "")
            {
                MessageBox.Show("لطفا فیلد جستجو را وارد نمائید.");
                return;
            }

            if (Rdo_UserID.Checked == true)
            {

                LSC_RestuRantDataContext db = new LSC_RestuRantDataContext();
                var Query = from Row in db.tblUsers
                            where Row.UsersID == int.Parse(Txt_Search.Text.Trim())
                            select new
                            {
                                Row.UsersID,
                                Row.UsersName,
                                Row.UsersPass,
                                Row.UserFName,
                                Row.UsersSName,
                                Row.tblUserType.UsersTypeDescription,
                                Row.UserTell,
                                Row.UserMobail,
                                Row.UserBanBit
                            };
                dataGridView1.DataSource = Query;
                Class_tblLogs LogReg = new Class_tblLogs(this.Text + " - عملیات جستجو");
                LogReg.UDF_SaveLogToDb();
                if (Query.Count() <= 0)
                {
                    Txt_Search.Text = "";
                    Btn_Save.BringToFront();
                    Btn_Search.SendToBack();
                    MessageBox.Show("رکوردی یافته نشد");
                }
            }
            else if (Rdo_UserName.Checked == true)
            {
                LSC_RestuRantDataContext db = new LSC_RestuRantDataContext();
                var Query = from Row in db.tblUsers
                            where SqlMethods.Like(Row.UsersName, "%" + Txt_Search.Text.Trim() + "%")
                            select new
                            {
                                Row.UsersID,
                                Row.UsersName,
                                Row.UsersPass,
                                Row.UserFName,
                                Row.UsersSName,
                                Row.tblUserType.UsersTypeDescription,
                                Row.UserTell,
                                Row.UserMobail,
                                Row.UserBanBit
                            };
                dataGridView1.DataSource = Query;
                Class_tblLogs LogReg = new Class_tblLogs(this.Text + " - عملیات جستجو");
                LogReg.UDF_SaveLogToDb();
                if (Query.Count() <= 0)
                {
                    Txt_Search.Text = "";
                    Btn_Save.BringToFront();
                    Btn_Search.SendToBack();
                    MessageBox.Show("رکوردی یافته نشد");
                }
            }
            else if (Rdo_Family.Checked == true)
            {
                LSC_RestuRantDataContext db = new LSC_RestuRantDataContext();
                var Query = from Row in db.tblUsers
                            where SqlMethods.Like(Row.UsersSName, "%" + Txt_Search.Text.Trim() + "%")
                            select new
                            {
                                Row.UsersID,
                                Row.UsersName,
                                Row.UsersPass,
                                Row.UserFName,
                                Row.UsersSName,
                                Row.tblUserType.UsersTypeDescription,
                                Row.UserTell,
                                Row.UserMobail,
                                Row.UserBanBit
                            };
                dataGridView1.DataSource = Query;
                Class_tblLogs LogReg = new Class_tblLogs(this.Text + " - عملیات جستجو");
                LogReg.UDF_SaveLogToDb();
                if (Query.Count() <= 0)
                {
                    Txt_Search.Text = "";
                    Btn_Save.BringToFront();
                    Btn_Search.SendToBack();
                    MessageBox.Show("رکوردی یافته نشد");
                }
            }
        }

        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            UDF_GrdFill();
            UDF_CmbFill();
            Btn_Refresh.SendToBack();
            Btn_Search.BringToFront();
            UDF_ClearTextBox();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
