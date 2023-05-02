namespace FlowerShop
{
    partial class frmEditUsers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UsersID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsersName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsersPass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserFName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsersSName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsersTypeDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserTell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserMobail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserBanBit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Btn_Edit = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Lbl_FoodDescription = new System.Windows.Forms.Label();
            this.Txt_UserName = new System.Windows.Forms.TextBox();
            this.Lbl_Password = new System.Windows.Forms.Label();
            this.Txt_Password = new System.Windows.Forms.TextBox();
            this.Lbl_Family = new System.Windows.Forms.Label();
            this.Txt_Family = new System.Windows.Forms.TextBox();
            this.Lbl_UserType = new System.Windows.Forms.Label();
            this.Cmb_UserType = new System.Windows.Forms.ComboBox();
            this.Lbl_Tell = new System.Windows.Forms.Label();
            this.Lbl_Mobail = new System.Windows.Forms.Label();
            this.Lbl_BanBit = new System.Windows.Forms.Label();
            this.Txt_Tell = new System.Windows.Forms.TextBox();
            this.Txt_Mobail = new System.Windows.Forms.TextBox();
            this.Chb_BanBit = new System.Windows.Forms.CheckBox();
            this.Lbl_Name = new System.Windows.Forms.Label();
            this.Txt_Name = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_UseID = new System.Windows.Forms.TextBox();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.Btn_Refresh = new System.Windows.Forms.Button();
            this.Rdo_Family = new System.Windows.Forms.RadioButton();
            this.Rdo_UserName = new System.Windows.Forms.RadioButton();
            this.Rdo_UserID = new System.Windows.Forms.RadioButton();
            this.Txt_Search = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UsersID,
            this.UsersName,
            this.UsersPass,
            this.UserFName,
            this.UsersSName,
            this.UsersTypeDescription,
            this.UserTell,
            this.UserMobail,
            this.UserBanBit});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1025, 407);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // UsersID
            // 
            this.UsersID.DataPropertyName = "UsersID";
            this.UsersID.HeaderText = "کد کاربر";
            this.UsersID.Name = "UsersID";
            this.UsersID.ReadOnly = true;
            // 
            // UsersName
            // 
            this.UsersName.DataPropertyName = "UsersName";
            this.UsersName.HeaderText = "نام کاربری";
            this.UsersName.Name = "UsersName";
            this.UsersName.ReadOnly = true;
            // 
            // UsersPass
            // 
            this.UsersPass.DataPropertyName = "UsersPass";
            this.UsersPass.HeaderText = "کلمه عبور";
            this.UsersPass.Name = "UsersPass";
            this.UsersPass.ReadOnly = true;
            // 
            // UserFName
            // 
            this.UserFName.DataPropertyName = "UserFName";
            this.UserFName.HeaderText = "نام";
            this.UserFName.Name = "UserFName";
            this.UserFName.ReadOnly = true;
            // 
            // UsersSName
            // 
            this.UsersSName.DataPropertyName = "UsersSName";
            this.UsersSName.HeaderText = "نام خانوادگی";
            this.UsersSName.Name = "UsersSName";
            this.UsersSName.ReadOnly = true;
            this.UsersSName.Width = 150;
            // 
            // UsersTypeDescription
            // 
            this.UsersTypeDescription.DataPropertyName = "UsersTypeDescription";
            this.UsersTypeDescription.HeaderText = "نوع کاربر";
            this.UsersTypeDescription.Name = "UsersTypeDescription";
            this.UsersTypeDescription.ReadOnly = true;
            this.UsersTypeDescription.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // UserTell
            // 
            this.UserTell.DataPropertyName = "UserTell";
            this.UserTell.HeaderText = "تلفن";
            this.UserTell.Name = "UserTell";
            this.UserTell.ReadOnly = true;
            // 
            // UserMobail
            // 
            this.UserMobail.DataPropertyName = "UserMobail";
            this.UserMobail.HeaderText = "تلفن همراه";
            this.UserMobail.Name = "UserMobail";
            this.UserMobail.ReadOnly = true;
            // 
            // UserBanBit
            // 
            this.UserBanBit.DataPropertyName = "UserBanBit";
            this.UserBanBit.HeaderText = "وضعیت کاربر";
            this.UserBanBit.Name = "UserBanBit";
            this.UserBanBit.ReadOnly = true;
            this.UserBanBit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.UserBanBit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.UserBanBit.Visible = false;
            // 
            // Btn_Edit
            // 
            this.Btn_Edit.Image = global::FlowerShop.Properties.Resources.Edit_Btn_Sm;
            this.Btn_Edit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Edit.Location = new System.Drawing.Point(197, 415);
            this.Btn_Edit.Name = "Btn_Edit";
            this.Btn_Edit.Size = new System.Drawing.Size(90, 83);
            this.Btn_Edit.TabIndex = 50;
            this.Btn_Edit.Text = "ویرایش کردن";
            this.Btn_Edit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Edit.UseVisualStyleBackColor = true;
            this.Btn_Edit.Click += new System.EventHandler(this.Btn_Edit_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Image = global::FlowerShop.Properties.Resources.Delete_Btn_Sm;
            this.Btn_Delete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Delete.Location = new System.Drawing.Point(101, 415);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(90, 83);
            this.Btn_Delete.TabIndex = 49;
            this.Btn_Delete.Text = "حذف کردن";
            this.Btn_Delete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Delete.UseVisualStyleBackColor = true;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // Lbl_FoodDescription
            // 
            this.Lbl_FoodDescription.AutoSize = true;
            this.Lbl_FoodDescription.Location = new System.Drawing.Point(943, 423);
            this.Lbl_FoodDescription.Name = "Lbl_FoodDescription";
            this.Lbl_FoodDescription.Size = new System.Drawing.Size(57, 13);
            this.Lbl_FoodDescription.TabIndex = 53;
            this.Lbl_FoodDescription.Text = "نام کاربری:";
            // 
            // Txt_UserName
            // 
            this.Txt_UserName.Location = new System.Drawing.Point(698, 420);
            this.Txt_UserName.Name = "Txt_UserName";
            this.Txt_UserName.Size = new System.Drawing.Size(222, 21);
            this.Txt_UserName.TabIndex = 52;
            // 
            // Lbl_Password
            // 
            this.Lbl_Password.AutoSize = true;
            this.Lbl_Password.Location = new System.Drawing.Point(944, 451);
            this.Lbl_Password.Name = "Lbl_Password";
            this.Lbl_Password.Size = new System.Drawing.Size(56, 13);
            this.Lbl_Password.TabIndex = 54;
            this.Lbl_Password.Text = "کلمه عبور:";
            // 
            // Txt_Password
            // 
            this.Txt_Password.Location = new System.Drawing.Point(698, 448);
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.PasswordChar = '*';
            this.Txt_Password.Size = new System.Drawing.Size(222, 21);
            this.Txt_Password.TabIndex = 55;
            // 
            // Lbl_Family
            // 
            this.Lbl_Family.AutoSize = true;
            this.Lbl_Family.Location = new System.Drawing.Point(927, 507);
            this.Lbl_Family.Name = "Lbl_Family";
            this.Lbl_Family.Size = new System.Drawing.Size(69, 13);
            this.Lbl_Family.TabIndex = 56;
            this.Lbl_Family.Text = "نام خانوادگی:";
            // 
            // Txt_Family
            // 
            this.Txt_Family.Location = new System.Drawing.Point(699, 504);
            this.Txt_Family.Name = "Txt_Family";
            this.Txt_Family.Size = new System.Drawing.Size(222, 21);
            this.Txt_Family.TabIndex = 57;
            // 
            // Lbl_UserType
            // 
            this.Lbl_UserType.AutoSize = true;
            this.Lbl_UserType.Location = new System.Drawing.Point(632, 424);
            this.Lbl_UserType.Name = "Lbl_UserType";
            this.Lbl_UserType.Size = new System.Drawing.Size(49, 13);
            this.Lbl_UserType.TabIndex = 58;
            this.Lbl_UserType.Text = "نوع کاربر:";
            // 
            // Cmb_UserType
            // 
            this.Cmb_UserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_UserType.FormattingEnabled = true;
            this.Cmb_UserType.Location = new System.Drawing.Point(384, 421);
            this.Cmb_UserType.Name = "Cmb_UserType";
            this.Cmb_UserType.Size = new System.Drawing.Size(222, 21);
            this.Cmb_UserType.TabIndex = 59;
            this.Cmb_UserType.SelectedIndexChanged += new System.EventHandler(this.Cmb_UserType_SelectedIndexChanged);
            // 
            // Lbl_Tell
            // 
            this.Lbl_Tell.AutoSize = true;
            this.Lbl_Tell.Location = new System.Drawing.Point(652, 452);
            this.Lbl_Tell.Name = "Lbl_Tell";
            this.Lbl_Tell.Size = new System.Drawing.Size(32, 13);
            this.Lbl_Tell.TabIndex = 60;
            this.Lbl_Tell.Text = "تلفن:";
            // 
            // Lbl_Mobail
            // 
            this.Lbl_Mobail.AutoSize = true;
            this.Lbl_Mobail.Location = new System.Drawing.Point(617, 481);
            this.Lbl_Mobail.Name = "Lbl_Mobail";
            this.Lbl_Mobail.Size = new System.Drawing.Size(63, 13);
            this.Lbl_Mobail.TabIndex = 61;
            this.Lbl_Mobail.Text = "تلفن همراه:";
            // 
            // Lbl_BanBit
            // 
            this.Lbl_BanBit.AutoSize = true;
            this.Lbl_BanBit.Location = new System.Drawing.Point(615, 507);
            this.Lbl_BanBit.Name = "Lbl_BanBit";
            this.Lbl_BanBit.Size = new System.Drawing.Size(78, 13);
            this.Lbl_BanBit.TabIndex = 62;
            this.Lbl_BanBit.Text = "غیر فعال شدن:";
            // 
            // Txt_Tell
            // 
            this.Txt_Tell.Location = new System.Drawing.Point(384, 449);
            this.Txt_Tell.Name = "Txt_Tell";
            this.Txt_Tell.Size = new System.Drawing.Size(222, 21);
            this.Txt_Tell.TabIndex = 63;
            // 
            // Txt_Mobail
            // 
            this.Txt_Mobail.Location = new System.Drawing.Point(384, 478);
            this.Txt_Mobail.Name = "Txt_Mobail";
            this.Txt_Mobail.Size = new System.Drawing.Size(222, 21);
            this.Txt_Mobail.TabIndex = 64;
            // 
            // Chb_BanBit
            // 
            this.Chb_BanBit.AutoSize = true;
            this.Chb_BanBit.Location = new System.Drawing.Point(591, 509);
            this.Chb_BanBit.Name = "Chb_BanBit";
            this.Chb_BanBit.Size = new System.Drawing.Size(15, 14);
            this.Chb_BanBit.TabIndex = 65;
            this.Chb_BanBit.UseVisualStyleBackColor = true;
            // 
            // Lbl_Name
            // 
            this.Lbl_Name.AutoSize = true;
            this.Lbl_Name.Location = new System.Drawing.Point(982, 478);
            this.Lbl_Name.Name = "Lbl_Name";
            this.Lbl_Name.Size = new System.Drawing.Size(24, 13);
            this.Lbl_Name.TabIndex = 66;
            this.Lbl_Name.Text = "نام:";
            // 
            // Txt_Name
            // 
            this.Txt_Name.Location = new System.Drawing.Point(698, 475);
            this.Txt_Name.Name = "Txt_Name";
            this.Txt_Name.Size = new System.Drawing.Size(222, 21);
            this.Txt_Name.TabIndex = 67;
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::FlowerShop.Properties.Resources.Add_Btn_Sm;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdd.Location = new System.Drawing.Point(291, 416);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 83);
            this.btnAdd.TabIndex = 68;
            this.btnAdd.Text = "اضافه کردن";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // Btn_Save
            // 
            this.Btn_Save.Image = global::FlowerShop.Properties.Resources.Save_Sma;
            this.Btn_Save.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Save.Location = new System.Drawing.Point(291, 416);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(84, 83);
            this.Btn_Save.TabIndex = 69;
            this.Btn_Save.Text = "ذخیره";
            this.Btn_Save.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(743, 594);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 70;
            this.label1.Text = "کد کاربر:";
            // 
            // Txt_UseID
            // 
            this.Txt_UseID.Location = new System.Drawing.Point(674, 610);
            this.Txt_UseID.Name = "Txt_UseID";
            this.Txt_UseID.Size = new System.Drawing.Size(222, 21);
            this.Txt_UseID.TabIndex = 71;
            // 
            // Btn_Search
            // 
            this.Btn_Search.Image = global::FlowerShop.Properties.Resources.Search_Sm;
            this.Btn_Search.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Search.Location = new System.Drawing.Point(6, 415);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(90, 83);
            this.Btn_Search.TabIndex = 72;
            this.Btn_Search.Text = "جستجو کردن";
            this.Btn_Search.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Search.UseVisualStyleBackColor = true;
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // Btn_Refresh
            // 
            this.Btn_Refresh.Image = global::FlowerShop.Properties.Resources.refresh1001_Sm;
            this.Btn_Refresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Refresh.Location = new System.Drawing.Point(6, 415);
            this.Btn_Refresh.Name = "Btn_Refresh";
            this.Btn_Refresh.Size = new System.Drawing.Size(90, 83);
            this.Btn_Refresh.TabIndex = 73;
            this.Btn_Refresh.Text = "بازنشانی";
            this.Btn_Refresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Refresh.UseVisualStyleBackColor = true;
            this.Btn_Refresh.Click += new System.EventHandler(this.Btn_Refresh_Click);
            // 
            // Rdo_Family
            // 
            this.Rdo_Family.AutoSize = true;
            this.Rdo_Family.Location = new System.Drawing.Point(12, 535);
            this.Rdo_Family.Name = "Rdo_Family";
            this.Rdo_Family.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Rdo_Family.Size = new System.Drawing.Size(83, 17);
            this.Rdo_Family.TabIndex = 85;
            this.Rdo_Family.TabStop = true;
            this.Rdo_Family.Text = "نام خانوادگی";
            this.Rdo_Family.UseVisualStyleBackColor = true;
            // 
            // Rdo_UserName
            // 
            this.Rdo_UserName.AutoSize = true;
            this.Rdo_UserName.Location = new System.Drawing.Point(147, 535);
            this.Rdo_UserName.Name = "Rdo_UserName";
            this.Rdo_UserName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Rdo_UserName.Size = new System.Drawing.Size(71, 17);
            this.Rdo_UserName.TabIndex = 84;
            this.Rdo_UserName.TabStop = true;
            this.Rdo_UserName.Text = "نام کاربری";
            this.Rdo_UserName.UseVisualStyleBackColor = true;
            // 
            // Rdo_UserID
            // 
            this.Rdo_UserID.AutoSize = true;
            this.Rdo_UserID.Location = new System.Drawing.Point(278, 535);
            this.Rdo_UserID.Name = "Rdo_UserID";
            this.Rdo_UserID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Rdo_UserID.Size = new System.Drawing.Size(59, 17);
            this.Rdo_UserID.TabIndex = 83;
            this.Rdo_UserID.TabStop = true;
            this.Rdo_UserID.Text = "کد کاربر";
            this.Rdo_UserID.UseVisualStyleBackColor = true;
            // 
            // Txt_Search
            // 
            this.Txt_Search.BackColor = System.Drawing.SystemColors.Info;
            this.Txt_Search.Location = new System.Drawing.Point(12, 507);
            this.Txt_Search.Name = "Txt_Search";
            this.Txt_Search.Size = new System.Drawing.Size(308, 21);
            this.Txt_Search.TabIndex = 82;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(326, 510);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 81;
            this.label5.Text = "جستجو:";
            // 
            // frmEditUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 531);
            this.Controls.Add(this.Rdo_Family);
            this.Controls.Add(this.Rdo_UserName);
            this.Controls.Add(this.Rdo_UserID);
            this.Controls.Add(this.Txt_Search);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Btn_Search);
            this.Controls.Add(this.Btn_Refresh);
            this.Controls.Add(this.Txt_UseID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.Txt_Name);
            this.Controls.Add(this.Lbl_Name);
            this.Controls.Add(this.Chb_BanBit);
            this.Controls.Add(this.Txt_Mobail);
            this.Controls.Add(this.Txt_Tell);
            this.Controls.Add(this.Lbl_BanBit);
            this.Controls.Add(this.Lbl_Mobail);
            this.Controls.Add(this.Lbl_Tell);
            this.Controls.Add(this.Cmb_UserType);
            this.Controls.Add(this.Lbl_UserType);
            this.Controls.Add(this.Txt_Family);
            this.Controls.Add(this.Lbl_Family);
            this.Controls.Add(this.Txt_Password);
            this.Controls.Add(this.Lbl_Password);
            this.Controls.Add(this.Lbl_FoodDescription);
            this.Controls.Add(this.Txt_UserName);
            this.Controls.Add(this.Btn_Edit);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmEditUsers";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "فرم ویرایش کاربران";
            this.Load += new System.EventHandler(this.frmEditUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Btn_Edit;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.Label Lbl_FoodDescription;
        private System.Windows.Forms.TextBox Txt_UserName;
        private System.Windows.Forms.Label Lbl_Password;
        private System.Windows.Forms.TextBox Txt_Password;
        private System.Windows.Forms.Label Lbl_Family;
        private System.Windows.Forms.TextBox Txt_Family;
        private System.Windows.Forms.Label Lbl_UserType;
        private System.Windows.Forms.ComboBox Cmb_UserType;
        private System.Windows.Forms.Label Lbl_Tell;
        private System.Windows.Forms.Label Lbl_Mobail;
        private System.Windows.Forms.Label Lbl_BanBit;
        private System.Windows.Forms.TextBox Txt_Tell;
        private System.Windows.Forms.TextBox Txt_Mobail;
        private System.Windows.Forms.CheckBox Chb_BanBit;
        private System.Windows.Forms.Label Lbl_Name;
        private System.Windows.Forms.TextBox Txt_Name;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_UseID;
        private System.Windows.Forms.Button Btn_Search;
        private System.Windows.Forms.Button Btn_Refresh;
        private System.Windows.Forms.RadioButton Rdo_Family;
        private System.Windows.Forms.RadioButton Rdo_UserName;
        private System.Windows.Forms.RadioButton Rdo_UserID;
        private System.Windows.Forms.TextBox Txt_Search;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsersID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsersName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsersPass;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserFName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsersSName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsersTypeDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserTell;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserMobail;
        private System.Windows.Forms.DataGridViewCheckBoxColumn UserBanBit;
    }
}