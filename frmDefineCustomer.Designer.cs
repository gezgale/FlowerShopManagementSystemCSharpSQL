namespace FlowerShop
{
    partial class frmDefineCustomer
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
            this.Chb_IsActive = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_Address = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Mobail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Tell = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Name = new System.Windows.Forms.TextBox();
            this.Lbl_Name = new System.Windows.Forms.Label();
            this.Txt_Family = new System.Windows.Forms.TextBox();
            this.Lbl_Family = new System.Windows.Forms.Label();
            this.Txt_CustomerID = new System.Windows.Forms.TextBox();
            this.Lbl_CustomerID = new System.Windows.Forms.Label();
            this.Grd_Customer = new System.Windows.Forms.DataGridView();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerFamily = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOzviatSH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerTell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerMobail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_Search = new System.Windows.Forms.TextBox();
            this.Rdo_CustomerID = new System.Windows.Forms.RadioButton();
            this.Rdo_CustomerName = new System.Windows.Forms.RadioButton();
            this.Rdo_CustomerFamily = new System.Windows.Forms.RadioButton();
            this.Btn_SearchCustomer = new System.Windows.Forms.Button();
            this.Btn_Edit = new System.Windows.Forms.Button();
            this.Btn_DeleteCustomer = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.Btn_Refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Customer)).BeginInit();
            this.SuspendLayout();
            // 
            // Chb_IsActive
            // 
            this.Chb_IsActive.AutoSize = true;
            this.Chb_IsActive.Location = new System.Drawing.Point(393, 365);
            this.Chb_IsActive.Name = "Chb_IsActive";
            this.Chb_IsActive.Size = new System.Drawing.Size(15, 14);
            this.Chb_IsActive.TabIndex = 72;
            this.Chb_IsActive.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(414, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 71;
            this.label4.Text = "وضعیت فعال:";
            // 
            // Txt_Address
            // 
            this.Txt_Address.Location = new System.Drawing.Point(327, 473);
            this.Txt_Address.Name = "Txt_Address";
            this.Txt_Address.Size = new System.Drawing.Size(401, 22);
            this.Txt_Address.TabIndex = 70;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(774, 476);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 69;
            this.label3.Text = "آدرس:";
            // 
            // Txt_Mobail
            // 
            this.Txt_Mobail.Location = new System.Drawing.Point(506, 446);
            this.Txt_Mobail.Name = "Txt_Mobail";
            this.Txt_Mobail.Size = new System.Drawing.Size(222, 22);
            this.Txt_Mobail.TabIndex = 68;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(743, 450);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 67;
            this.label2.Text = "تلفن همراه:";
            // 
            // Txt_Tell
            // 
            this.Txt_Tell.Location = new System.Drawing.Point(506, 416);
            this.Txt_Tell.Name = "Txt_Tell";
            this.Txt_Tell.Size = new System.Drawing.Size(222, 22);
            this.Txt_Tell.TabIndex = 66;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(778, 422);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 65;
            this.label1.Text = "تلفن:";
            // 
            // Txt_Name
            // 
            this.Txt_Name.Location = new System.Drawing.Point(506, 359);
            this.Txt_Name.Name = "Txt_Name";
            this.Txt_Name.Size = new System.Drawing.Size(222, 22);
            this.Txt_Name.TabIndex = 64;
            // 
            // Lbl_Name
            // 
            this.Lbl_Name.AutoSize = true;
            this.Lbl_Name.Location = new System.Drawing.Point(788, 364);
            this.Lbl_Name.Name = "Lbl_Name";
            this.Lbl_Name.Size = new System.Drawing.Size(29, 16);
            this.Lbl_Name.TabIndex = 63;
            this.Lbl_Name.Text = "نام:";
            // 
            // Txt_Family
            // 
            this.Txt_Family.Location = new System.Drawing.Point(506, 389);
            this.Txt_Family.Name = "Txt_Family";
            this.Txt_Family.Size = new System.Drawing.Size(222, 22);
            this.Txt_Family.TabIndex = 62;
            // 
            // Lbl_Family
            // 
            this.Lbl_Family.AutoSize = true;
            this.Lbl_Family.Location = new System.Drawing.Point(733, 392);
            this.Lbl_Family.Name = "Lbl_Family";
            this.Lbl_Family.Size = new System.Drawing.Size(84, 16);
            this.Lbl_Family.TabIndex = 61;
            this.Lbl_Family.Text = "نام خانوادگی:";
            // 
            // Txt_CustomerID
            // 
            this.Txt_CustomerID.Location = new System.Drawing.Point(344, 540);
            this.Txt_CustomerID.Name = "Txt_CustomerID";
            this.Txt_CustomerID.Size = new System.Drawing.Size(222, 22);
            this.Txt_CustomerID.TabIndex = 53;
            // 
            // Lbl_CustomerID
            // 
            this.Lbl_CustomerID.AutoSize = true;
            this.Lbl_CustomerID.Location = new System.Drawing.Point(572, 543);
            this.Lbl_CustomerID.Name = "Lbl_CustomerID";
            this.Lbl_CustomerID.Size = new System.Drawing.Size(72, 16);
            this.Lbl_CustomerID.TabIndex = 54;
            this.Lbl_CustomerID.Text = "کد مشتری:";
            // 
            // Grd_Customer
            // 
            this.Grd_Customer.AllowUserToAddRows = false;
            this.Grd_Customer.AllowUserToDeleteRows = false;
            this.Grd_Customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grd_Customer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerID,
            this.CustomerName,
            this.CustomerFamily,
            this.DateOzviatSH,
            this.CustomerTell,
            this.CustomerMobail,
            this.CustomerAddress});
            this.Grd_Customer.Dock = System.Windows.Forms.DockStyle.Top;
            this.Grd_Customer.Location = new System.Drawing.Point(0, 0);
            this.Grd_Customer.Name = "Grd_Customer";
            this.Grd_Customer.ReadOnly = true;
            this.Grd_Customer.Size = new System.Drawing.Size(827, 350);
            this.Grd_Customer.TabIndex = 38;
            this.Grd_Customer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grd_Customer_CellClick);
            // 
            // CustomerID
            // 
            this.CustomerID.DataPropertyName = "CustomerID";
            this.CustomerID.HeaderText = "کد مشتری";
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            // 
            // CustomerName
            // 
            this.CustomerName.DataPropertyName = "CustomerName";
            this.CustomerName.HeaderText = "نام مشتری";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            // 
            // CustomerFamily
            // 
            this.CustomerFamily.DataPropertyName = "CustomerFamily";
            this.CustomerFamily.HeaderText = "نام خانوادگی";
            this.CustomerFamily.Name = "CustomerFamily";
            this.CustomerFamily.ReadOnly = true;
            this.CustomerFamily.Width = 150;
            // 
            // DateOzviatSH
            // 
            this.DateOzviatSH.DataPropertyName = "DateOzviatSH";
            this.DateOzviatSH.HeaderText = "تاریخ عضویت";
            this.DateOzviatSH.Name = "DateOzviatSH";
            this.DateOzviatSH.ReadOnly = true;
            this.DateOzviatSH.Width = 150;
            // 
            // CustomerTell
            // 
            this.CustomerTell.DataPropertyName = "CustomerTell";
            this.CustomerTell.HeaderText = "تلفن";
            this.CustomerTell.Name = "CustomerTell";
            this.CustomerTell.ReadOnly = true;
            // 
            // CustomerMobail
            // 
            this.CustomerMobail.DataPropertyName = "CustomerMobail";
            this.CustomerMobail.HeaderText = "تلفن همراه";
            this.CustomerMobail.Name = "CustomerMobail";
            this.CustomerMobail.ReadOnly = true;
            // 
            // CustomerAddress
            // 
            this.CustomerAddress.DataPropertyName = "CustomerAddress";
            this.CustomerAddress.HeaderText = "آدرس";
            this.CustomerAddress.Name = "CustomerAddress";
            this.CustomerAddress.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(257, 450);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 73;
            this.label5.Text = "جستجو:";
            // 
            // Txt_Search
            // 
            this.Txt_Search.BackColor = System.Drawing.SystemColors.Info;
            this.Txt_Search.Location = new System.Drawing.Point(10, 447);
            this.Txt_Search.Name = "Txt_Search";
            this.Txt_Search.Size = new System.Drawing.Size(241, 22);
            this.Txt_Search.TabIndex = 77;
            // 
            // Rdo_CustomerID
            // 
            this.Rdo_CustomerID.AutoSize = true;
            this.Rdo_CustomerID.Location = new System.Drawing.Point(225, 475);
            this.Rdo_CustomerID.Name = "Rdo_CustomerID";
            this.Rdo_CustomerID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Rdo_CustomerID.Size = new System.Drawing.Size(85, 20);
            this.Rdo_CustomerID.TabIndex = 78;
            this.Rdo_CustomerID.TabStop = true;
            this.Rdo_CustomerID.Text = "کد مشتری";
            this.Rdo_CustomerID.UseVisualStyleBackColor = true;
            // 
            // Rdo_CustomerName
            // 
            this.Rdo_CustomerName.AutoSize = true;
            this.Rdo_CustomerName.Location = new System.Drawing.Point(137, 473);
            this.Rdo_CustomerName.Name = "Rdo_CustomerName";
            this.Rdo_CustomerName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Rdo_CustomerName.Size = new System.Drawing.Size(42, 20);
            this.Rdo_CustomerName.TabIndex = 79;
            this.Rdo_CustomerName.TabStop = true;
            this.Rdo_CustomerName.Text = "نام";
            this.Rdo_CustomerName.UseVisualStyleBackColor = true;
            // 
            // Rdo_CustomerFamily
            // 
            this.Rdo_CustomerFamily.AutoSize = true;
            this.Rdo_CustomerFamily.Location = new System.Drawing.Point(12, 475);
            this.Rdo_CustomerFamily.Name = "Rdo_CustomerFamily";
            this.Rdo_CustomerFamily.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Rdo_CustomerFamily.Size = new System.Drawing.Size(97, 20);
            this.Rdo_CustomerFamily.TabIndex = 80;
            this.Rdo_CustomerFamily.TabStop = true;
            this.Rdo_CustomerFamily.Text = "نام خانوادگی";
            this.Rdo_CustomerFamily.UseVisualStyleBackColor = true;
            // 
            // Btn_SearchCustomer
            // 
            this.Btn_SearchCustomer.Image = global::FlowerShop.Properties.Resources.Search_Sm;
            this.Btn_SearchCustomer.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_SearchCustomer.Location = new System.Drawing.Point(7, 357);
            this.Btn_SearchCustomer.Name = "Btn_SearchCustomer";
            this.Btn_SearchCustomer.Size = new System.Drawing.Size(90, 83);
            this.Btn_SearchCustomer.TabIndex = 58;
            this.Btn_SearchCustomer.Text = "جستجو کردن";
            this.Btn_SearchCustomer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_SearchCustomer.UseVisualStyleBackColor = true;
            this.Btn_SearchCustomer.Click += new System.EventHandler(this.Btn_SearchCustomer_Click);
            // 
            // Btn_Edit
            // 
            this.Btn_Edit.Image = global::FlowerShop.Properties.Resources.Edit_Btn_Sm;
            this.Btn_Edit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Edit.Location = new System.Drawing.Point(198, 357);
            this.Btn_Edit.Name = "Btn_Edit";
            this.Btn_Edit.Size = new System.Drawing.Size(90, 83);
            this.Btn_Edit.TabIndex = 57;
            this.Btn_Edit.Text = "ویرایش کردن";
            this.Btn_Edit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Edit.UseVisualStyleBackColor = true;
            this.Btn_Edit.Click += new System.EventHandler(this.Btn_Edit_Click);
            // 
            // Btn_DeleteCustomer
            // 
            this.Btn_DeleteCustomer.Image = global::FlowerShop.Properties.Resources.Delete_Btn_Sm;
            this.Btn_DeleteCustomer.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_DeleteCustomer.Location = new System.Drawing.Point(102, 357);
            this.Btn_DeleteCustomer.Name = "Btn_DeleteCustomer";
            this.Btn_DeleteCustomer.Size = new System.Drawing.Size(90, 83);
            this.Btn_DeleteCustomer.TabIndex = 56;
            this.Btn_DeleteCustomer.Text = "حذف کردن";
            this.Btn_DeleteCustomer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_DeleteCustomer.UseVisualStyleBackColor = true;
            this.Btn_DeleteCustomer.Click += new System.EventHandler(this.Btn_DeleteCustomer_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::FlowerShop.Properties.Resources.Add_Btn_Sm;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdd.Location = new System.Drawing.Point(294, 357);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 83);
            this.btnAdd.TabIndex = 55;
            this.btnAdd.Text = "اضافه کردن";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Btn_Save
            // 
            this.Btn_Save.Image = global::FlowerShop.Properties.Resources.Save_Sma;
            this.Btn_Save.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Save.Location = new System.Drawing.Point(294, 357);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(84, 83);
            this.Btn_Save.TabIndex = 59;
            this.Btn_Save.Text = "ذخیره";
            this.Btn_Save.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // button3
            // 
            this.button3.Image = global::FlowerShop.Properties.Resources.refresh1001_Sm;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(7, 357);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 83);
            this.button3.TabIndex = 60;
            this.button3.Text = "بازنشانی";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Btn_Search
            // 
            this.Btn_Search.Image = global::FlowerShop.Properties.Resources.Search_Sm;
            this.Btn_Search.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Search.Location = new System.Drawing.Point(-192, 190);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(90, 83);
            this.Btn_Search.TabIndex = 48;
            this.Btn_Search.Text = "جستجو کردن";
            this.Btn_Search.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Search.UseVisualStyleBackColor = true;
            // 
            // Btn_Refresh
            // 
            this.Btn_Refresh.Image = global::FlowerShop.Properties.Resources.refresh1001_Sm;
            this.Btn_Refresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Refresh.Location = new System.Drawing.Point(-192, 190);
            this.Btn_Refresh.Name = "Btn_Refresh";
            this.Btn_Refresh.Size = new System.Drawing.Size(90, 83);
            this.Btn_Refresh.TabIndex = 50;
            this.Btn_Refresh.Text = "بازنشانی";
            this.Btn_Refresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Refresh.UseVisualStyleBackColor = true;
            // 
            // frmDefineCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 505);
            this.Controls.Add(this.Rdo_CustomerFamily);
            this.Controls.Add(this.Rdo_CustomerName);
            this.Controls.Add(this.Rdo_CustomerID);
            this.Controls.Add(this.Txt_Search);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Chb_IsActive);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txt_Address);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_Mobail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_Tell);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_Name);
            this.Controls.Add(this.Lbl_Name);
            this.Controls.Add(this.Txt_Family);
            this.Controls.Add(this.Lbl_Family);
            this.Controls.Add(this.Btn_SearchCustomer);
            this.Controls.Add(this.Btn_Edit);
            this.Controls.Add(this.Btn_DeleteCustomer);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Lbl_CustomerID);
            this.Controls.Add(this.Txt_CustomerID);
            this.Controls.Add(this.Btn_Search);
            this.Controls.Add(this.Btn_Refresh);
            this.Controls.Add(this.Grd_Customer);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDefineCustomer";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "فرم تعریف مشتری";
            this.Load += new System.EventHandler(this.frmDefineCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Customer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Chb_IsActive;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_Address;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Mobail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Tell;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Name;
        private System.Windows.Forms.Label Lbl_Name;
        private System.Windows.Forms.TextBox Txt_Family;
        private System.Windows.Forms.Label Lbl_Family;
        private System.Windows.Forms.Button Btn_Refresh;
        private System.Windows.Forms.Button Btn_Search;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button Btn_DeleteCustomer;
        private System.Windows.Forms.Button Btn_Edit;
        private System.Windows.Forms.Button Btn_SearchCustomer;
        private System.Windows.Forms.TextBox Txt_CustomerID;
        private System.Windows.Forms.Label Lbl_CustomerID;
        private System.Windows.Forms.DataGridView Grd_Customer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_Search;
        private System.Windows.Forms.RadioButton Rdo_CustomerID;
        private System.Windows.Forms.RadioButton Rdo_CustomerName;
        private System.Windows.Forms.RadioButton Rdo_CustomerFamily;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerFamily;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOzviatSH;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerTell;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerMobail;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerAddress;

    }
}