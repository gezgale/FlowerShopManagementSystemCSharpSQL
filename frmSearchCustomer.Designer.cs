namespace FlowerShop
{
    partial class frmSearchCustomer
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
            this.Grd_Customer = new System.Windows.Forms.DataGridView();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerFamily = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOzviatSH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerTell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerMobail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rdo_CustomerFamily = new System.Windows.Forms.RadioButton();
            this.Rdo_CustomerName = new System.Windows.Forms.RadioButton();
            this.Rdo_CustomerID = new System.Windows.Forms.RadioButton();
            this.Txt_Search = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Btn_SearchCustomer = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Txt_CustomerCode = new System.Windows.Forms.TextBox();
            this.Lbl_CustomerCode = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Customer)).BeginInit();
            this.SuspendLayout();
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
            this.Grd_Customer.Size = new System.Drawing.Size(859, 322);
            this.Grd_Customer.TabIndex = 39;
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
            // Rdo_CustomerFamily
            // 
            this.Rdo_CustomerFamily.AutoSize = true;
            this.Rdo_CustomerFamily.Location = new System.Drawing.Point(412, 388);
            this.Rdo_CustomerFamily.Name = "Rdo_CustomerFamily";
            this.Rdo_CustomerFamily.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Rdo_CustomerFamily.Size = new System.Drawing.Size(90, 18);
            this.Rdo_CustomerFamily.TabIndex = 85;
            this.Rdo_CustomerFamily.Text = "نام خانوادگی";
            this.Rdo_CustomerFamily.UseVisualStyleBackColor = true;
            // 
            // Rdo_CustomerName
            // 
            this.Rdo_CustomerName.AutoSize = true;
            this.Rdo_CustomerName.Location = new System.Drawing.Point(558, 386);
            this.Rdo_CustomerName.Name = "Rdo_CustomerName";
            this.Rdo_CustomerName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Rdo_CustomerName.Size = new System.Drawing.Size(39, 18);
            this.Rdo_CustomerName.TabIndex = 84;
            this.Rdo_CustomerName.Text = "نام";
            this.Rdo_CustomerName.UseVisualStyleBackColor = true;
            // 
            // Rdo_CustomerID
            // 
            this.Rdo_CustomerID.AutoSize = true;
            this.Rdo_CustomerID.Checked = true;
            this.Rdo_CustomerID.Location = new System.Drawing.Point(660, 388);
            this.Rdo_CustomerID.Name = "Rdo_CustomerID";
            this.Rdo_CustomerID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Rdo_CustomerID.Size = new System.Drawing.Size(80, 18);
            this.Rdo_CustomerID.TabIndex = 83;
            this.Rdo_CustomerID.TabStop = true;
            this.Rdo_CustomerID.Text = "کد مشتری";
            this.Rdo_CustomerID.UseVisualStyleBackColor = true;
            // 
            // Txt_Search
            // 
            this.Txt_Search.BackColor = System.Drawing.SystemColors.Info;
            this.Txt_Search.Location = new System.Drawing.Point(392, 360);
            this.Txt_Search.Name = "Txt_Search";
            this.Txt_Search.Size = new System.Drawing.Size(392, 22);
            this.Txt_Search.TabIndex = 82;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(806, 361);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 14);
            this.label5.TabIndex = 81;
            this.label5.Text = "جستجو:";
            // 
            // Btn_SearchCustomer
            // 
            this.Btn_SearchCustomer.Image = global::FlowerShop.Properties.Resources.Search_Sm;
            this.Btn_SearchCustomer.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_SearchCustomer.Location = new System.Drawing.Point(29, 341);
            this.Btn_SearchCustomer.Name = "Btn_SearchCustomer";
            this.Btn_SearchCustomer.Size = new System.Drawing.Size(105, 89);
            this.Btn_SearchCustomer.TabIndex = 86;
            this.Btn_SearchCustomer.Text = "جستجو کردن";
            this.Btn_SearchCustomer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_SearchCustomer.UseVisualStyleBackColor = true;
            this.Btn_SearchCustomer.Click += new System.EventHandler(this.Btn_SearchCustomer_Click);
            // 
            // button3
            // 
            this.button3.Image = global::FlowerShop.Properties.Resources.refresh1001_Sm;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(29, 341);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 89);
            this.button3.TabIndex = 87;
            this.button3.Text = "بازنشانی";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(156, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 25);
            this.button1.TabIndex = 88;
            this.button1.Text = "انتخاب کد مشتری";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Txt_CustomerCode
            // 
            this.Txt_CustomerCode.BackColor = System.Drawing.SystemColors.Info;
            this.Txt_CustomerCode.Location = new System.Drawing.Point(156, 360);
            this.Txt_CustomerCode.Name = "Txt_CustomerCode";
            this.Txt_CustomerCode.ReadOnly = true;
            this.Txt_CustomerCode.Size = new System.Drawing.Size(145, 22);
            this.Txt_CustomerCode.TabIndex = 90;
            // 
            // Lbl_CustomerCode
            // 
            this.Lbl_CustomerCode.AutoSize = true;
            this.Lbl_CustomerCode.Location = new System.Drawing.Point(309, 363);
            this.Lbl_CustomerCode.Name = "Lbl_CustomerCode";
            this.Lbl_CustomerCode.Size = new System.Drawing.Size(66, 14);
            this.Lbl_CustomerCode.TabIndex = 89;
            this.Lbl_CustomerCode.Text = "کد مشتری:";
            // 
            // frmSearchCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 452);
            this.Controls.Add(this.Txt_CustomerCode);
            this.Controls.Add(this.Lbl_CustomerCode);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Btn_SearchCustomer);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Rdo_CustomerFamily);
            this.Controls.Add(this.Rdo_CustomerName);
            this.Controls.Add(this.Rdo_CustomerID);
            this.Controls.Add(this.Txt_Search);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Grd_Customer);
            this.Font = new System.Drawing.Font("Tahoma", 8.228571F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSearchCustomer";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "جستجوی مشتری";
            this.Load += new System.EventHandler(this.frmSearchCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Customer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Grd_Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerFamily;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOzviatSH;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerTell;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerMobail;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerAddress;
        private System.Windows.Forms.RadioButton Rdo_CustomerFamily;
        private System.Windows.Forms.RadioButton Rdo_CustomerName;
        private System.Windows.Forms.RadioButton Rdo_CustomerID;
        private System.Windows.Forms.TextBox Txt_Search;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Btn_SearchCustomer;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox Txt_CustomerCode;
        private System.Windows.Forms.Label Lbl_CustomerCode;
    }
}