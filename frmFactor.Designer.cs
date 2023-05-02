namespace FlowerShop
{
    partial class frmFactor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Grd_FlowerCategory = new System.Windows.Forms.DataGridView();
            this.FlowerCateguryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlowerCateguryDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grd_FlowerDescription = new System.Windows.Forms.DataGridView();
            this.FlowerDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlowerStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlowerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grd_Factor = new System.Windows.Forms.DataGridView();
            this.FlowerID1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlowerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlowerQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlowerUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlowerDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlowerTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grpr_Custumer = new System.Windows.Forms.GroupBox();
            this.Txt_Address = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_Phone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Mobile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_NameSname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_CustomerCode = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Lbl_CustomerCode = new System.Windows.Forms.Label();
            this.Grpr_Factor = new System.Windows.Forms.GroupBox();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Btn_AddToList = new System.Windows.Forms.Button();
            this.Txt_Tajhfif = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Txt_FeeTotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Txt_UnitPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Txt_TedadeDarkhast = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Txt_Stock = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_FlowerName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_FlowerCode = new System.Windows.Forms.TextBox();
            this.Lbl_FCode = new System.Windows.Forms.Label();
            this.GrPr_Mohasebeh = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Lbl_Total_Takhfif = new System.Windows.Forms.Label();
            this.Lbl_Takhfif = new System.Windows.Forms.Label();
            this.Lbl_Total_Aglam = new System.Windows.Forms.Label();
            this.Lbl_Aglame_Factor = new System.Windows.Forms.Label();
            this.Lbl_Total_Price = new System.Windows.Forms.Label();
            this.Lbl_TOtal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_FlowerCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_FlowerDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Factor)).BeginInit();
            this.Grpr_Custumer.SuspendLayout();
            this.Grpr_Factor.SuspendLayout();
            this.GrPr_Mohasebeh.SuspendLayout();
            this.SuspendLayout();
            // 
            // Grd_FlowerCategory
            // 
            this.Grd_FlowerCategory.AllowUserToAddRows = false;
            this.Grd_FlowerCategory.AllowUserToDeleteRows = false;
            this.Grd_FlowerCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Grd_FlowerCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grd_FlowerCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FlowerCateguryID,
            this.FlowerCateguryDescription});
            this.Grd_FlowerCategory.Location = new System.Drawing.Point(675, 1);
            this.Grd_FlowerCategory.Name = "Grd_FlowerCategory";
            this.Grd_FlowerCategory.ReadOnly = true;
            this.Grd_FlowerCategory.Size = new System.Drawing.Size(315, 212);
            this.Grd_FlowerCategory.TabIndex = 0;
            this.Grd_FlowerCategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grd_FlowerCategory_CellClick);
            // 
            // FlowerCateguryID
            // 
            this.FlowerCateguryID.DataPropertyName = "FlowerCateguryID";
            this.FlowerCateguryID.HeaderText = "ردیف";
            this.FlowerCateguryID.Name = "FlowerCateguryID";
            this.FlowerCateguryID.ReadOnly = true;
            this.FlowerCateguryID.Visible = false;
            this.FlowerCateguryID.Width = 150;
            // 
            // FlowerCateguryDescription
            // 
            this.FlowerCateguryDescription.DataPropertyName = "FlowerCateguryDescription";
            this.FlowerCateguryDescription.HeaderText = "دسته بندی";
            this.FlowerCateguryDescription.Name = "FlowerCateguryDescription";
            this.FlowerCateguryDescription.ReadOnly = true;
            this.FlowerCateguryDescription.Width = 150;
            // 
            // Grd_FlowerDescription
            // 
            this.Grd_FlowerDescription.AllowUserToAddRows = false;
            this.Grd_FlowerDescription.AllowUserToDeleteRows = false;
            this.Grd_FlowerDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Grd_FlowerDescription.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grd_FlowerDescription.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FlowerDescription,
            this.FlowerStock,
            this.FlowerID,
            this.UnitPrice});
            this.Grd_FlowerDescription.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grd_FlowerDescription.DefaultCellStyle = dataGridViewCellStyle1;
            this.Grd_FlowerDescription.Location = new System.Drawing.Point(675, 212);
            this.Grd_FlowerDescription.Name = "Grd_FlowerDescription";
            this.Grd_FlowerDescription.ReadOnly = true;
            this.Grd_FlowerDescription.Size = new System.Drawing.Size(315, 404);
            this.Grd_FlowerDescription.TabIndex = 1;
            this.Grd_FlowerDescription.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grd_FlowerDescription_CellClick);
            // 
            // FlowerDescription
            // 
            this.FlowerDescription.DataPropertyName = "FLowerDescription";
            this.FlowerDescription.HeaderText = "نام گل";
            this.FlowerDescription.Name = "FlowerDescription";
            this.FlowerDescription.ReadOnly = true;
            // 
            // FlowerStock
            // 
            this.FlowerStock.DataPropertyName = "FlowerStock";
            this.FlowerStock.HeaderText = "موجودی";
            this.FlowerStock.Name = "FlowerStock";
            this.FlowerStock.ReadOnly = true;
            this.FlowerStock.Width = 60;
            // 
            // FlowerID
            // 
            this.FlowerID.DataPropertyName = "FlowerID";
            this.FlowerID.HeaderText = "کد گل";
            this.FlowerID.Name = "FlowerID";
            this.FlowerID.ReadOnly = true;
            this.FlowerID.Visible = false;
            this.FlowerID.Width = 70;
            // 
            // UnitPrice
            // 
            this.UnitPrice.DataPropertyName = "UnitPrice";
            this.UnitPrice.HeaderText = "قیمت واحد";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            // 
            // Grd_Factor
            // 
            this.Grd_Factor.AllowUserToAddRows = false;
            this.Grd_Factor.AllowUserToDeleteRows = false;
            this.Grd_Factor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grd_Factor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FlowerID1,
            this.FlowerName,
            this.FlowerQuantity,
            this.FlowerUnitPrice,
            this.FlowerDiscount,
            this.FlowerTotalPrice});
            this.Grd_Factor.Location = new System.Drawing.Point(10, 24);
            this.Grd_Factor.Name = "Grd_Factor";
            this.Grd_Factor.ReadOnly = true;
            this.Grd_Factor.Size = new System.Drawing.Size(642, 241);
            this.Grd_Factor.TabIndex = 2;
            // 
            // FlowerID1
            // 
            this.FlowerID1.DataPropertyName = "FlowerID";
            this.FlowerID1.HeaderText = "کد گل";
            this.FlowerID1.Name = "FlowerID1";
            this.FlowerID1.ReadOnly = true;
            // 
            // FlowerName
            // 
            this.FlowerName.DataPropertyName = "FlowerName";
            this.FlowerName.HeaderText = "نام گل";
            this.FlowerName.Name = "FlowerName";
            this.FlowerName.ReadOnly = true;
            // 
            // FlowerQuantity
            // 
            this.FlowerQuantity.DataPropertyName = "FlowerQuantity";
            this.FlowerQuantity.HeaderText = "تعداد";
            this.FlowerQuantity.Name = "FlowerQuantity";
            this.FlowerQuantity.ReadOnly = true;
            // 
            // FlowerUnitPrice
            // 
            this.FlowerUnitPrice.DataPropertyName = "FlowerUnitPrice";
            this.FlowerUnitPrice.HeaderText = "قیمت واحد";
            this.FlowerUnitPrice.Name = "FlowerUnitPrice";
            this.FlowerUnitPrice.ReadOnly = true;
            // 
            // FlowerDiscount
            // 
            this.FlowerDiscount.DataPropertyName = "FlowerDiscount";
            this.FlowerDiscount.HeaderText = "تخفیف";
            this.FlowerDiscount.Name = "FlowerDiscount";
            this.FlowerDiscount.ReadOnly = true;
            // 
            // FlowerTotalPrice
            // 
            this.FlowerTotalPrice.DataPropertyName = "FlowerTotalPrice";
            this.FlowerTotalPrice.HeaderText = "قیمت کل";
            this.FlowerTotalPrice.Name = "FlowerTotalPrice";
            this.FlowerTotalPrice.ReadOnly = true;
            // 
            // Grpr_Custumer
            // 
            this.Grpr_Custumer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Grpr_Custumer.Controls.Add(this.Txt_Address);
            this.Grpr_Custumer.Controls.Add(this.label4);
            this.Grpr_Custumer.Controls.Add(this.Txt_Phone);
            this.Grpr_Custumer.Controls.Add(this.label3);
            this.Grpr_Custumer.Controls.Add(this.Txt_Mobile);
            this.Grpr_Custumer.Controls.Add(this.label2);
            this.Grpr_Custumer.Controls.Add(this.Txt_NameSname);
            this.Grpr_Custumer.Controls.Add(this.label1);
            this.Grpr_Custumer.Controls.Add(this.Txt_CustomerCode);
            this.Grpr_Custumer.Controls.Add(this.button1);
            this.Grpr_Custumer.Controls.Add(this.Lbl_CustomerCode);
            this.Grpr_Custumer.Location = new System.Drawing.Point(4, -1);
            this.Grpr_Custumer.Name = "Grpr_Custumer";
            this.Grpr_Custumer.Size = new System.Drawing.Size(665, 104);
            this.Grpr_Custumer.TabIndex = 3;
            this.Grpr_Custumer.TabStop = false;
            this.Grpr_Custumer.Text = "اطلاعات مشتری";
            // 
            // Txt_Address
            // 
            this.Txt_Address.BackColor = System.Drawing.SystemColors.Info;
            this.Txt_Address.Location = new System.Drawing.Point(8, 73);
            this.Txt_Address.Name = "Txt_Address";
            this.Txt_Address.ReadOnly = true;
            this.Txt_Address.Size = new System.Drawing.Size(565, 21);
            this.Txt_Address.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(612, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "آدرس:";
            // 
            // Txt_Phone
            // 
            this.Txt_Phone.BackColor = System.Drawing.SystemColors.Info;
            this.Txt_Phone.Location = new System.Drawing.Point(369, 45);
            this.Txt_Phone.Name = "Txt_Phone";
            this.Txt_Phone.ReadOnly = true;
            this.Txt_Phone.Size = new System.Drawing.Size(204, 21);
            this.Txt_Phone.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(576, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "شماره تلفن:";
            // 
            // Txt_Mobile
            // 
            this.Txt_Mobile.BackColor = System.Drawing.SystemColors.Info;
            this.Txt_Mobile.Location = new System.Drawing.Point(8, 45);
            this.Txt_Mobile.Name = "Txt_Mobile";
            this.Txt_Mobile.ReadOnly = true;
            this.Txt_Mobile.Size = new System.Drawing.Size(236, 21);
            this.Txt_Mobile.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "تلفن همراه:";
            // 
            // Txt_NameSname
            // 
            this.Txt_NameSname.BackColor = System.Drawing.SystemColors.Info;
            this.Txt_NameSname.Location = new System.Drawing.Point(8, 17);
            this.Txt_NameSname.Name = "Txt_NameSname";
            this.Txt_NameSname.ReadOnly = true;
            this.Txt_NameSname.Size = new System.Drawing.Size(236, 21);
            this.Txt_NameSname.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "نام و نام خانوادگی:";
            // 
            // Txt_CustomerCode
            // 
            this.Txt_CustomerCode.BackColor = System.Drawing.SystemColors.Info;
            this.Txt_CustomerCode.Location = new System.Drawing.Point(369, 17);
            this.Txt_CustomerCode.Name = "Txt_CustomerCode";
            this.Txt_CustomerCode.Size = new System.Drawing.Size(100, 21);
            this.Txt_CustomerCode.TabIndex = 2;
            this.Txt_CustomerCode.TextChanged += new System.EventHandler(this.Txt_CustomerCode_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(553, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "انتخاب مشتری";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Lbl_CustomerCode
            // 
            this.Lbl_CustomerCode.AutoSize = true;
            this.Lbl_CustomerCode.Location = new System.Drawing.Point(475, 20);
            this.Lbl_CustomerCode.Name = "Lbl_CustomerCode";
            this.Lbl_CustomerCode.Size = new System.Drawing.Size(62, 13);
            this.Lbl_CustomerCode.TabIndex = 0;
            this.Lbl_CustomerCode.Text = "کد مشتری:";
            // 
            // Grpr_Factor
            // 
            this.Grpr_Factor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Grpr_Factor.Controls.Add(this.Btn_Close);
            this.Grpr_Factor.Controls.Add(this.Btn_Delete);
            this.Grpr_Factor.Controls.Add(this.Btn_AddToList);
            this.Grpr_Factor.Controls.Add(this.Txt_Tajhfif);
            this.Grpr_Factor.Controls.Add(this.label10);
            this.Grpr_Factor.Controls.Add(this.Txt_FeeTotal);
            this.Grpr_Factor.Controls.Add(this.label9);
            this.Grpr_Factor.Controls.Add(this.Txt_UnitPrice);
            this.Grpr_Factor.Controls.Add(this.label8);
            this.Grpr_Factor.Controls.Add(this.Txt_TedadeDarkhast);
            this.Grpr_Factor.Controls.Add(this.label7);
            this.Grpr_Factor.Controls.Add(this.Txt_Stock);
            this.Grpr_Factor.Controls.Add(this.label6);
            this.Grpr_Factor.Controls.Add(this.Txt_FlowerName);
            this.Grpr_Factor.Controls.Add(this.label5);
            this.Grpr_Factor.Controls.Add(this.Txt_FlowerCode);
            this.Grpr_Factor.Controls.Add(this.Lbl_FCode);
            this.Grpr_Factor.Controls.Add(this.Grd_Factor);
            this.Grpr_Factor.Location = new System.Drawing.Point(4, 105);
            this.Grpr_Factor.Name = "Grpr_Factor";
            this.Grpr_Factor.Size = new System.Drawing.Size(665, 380);
            this.Grpr_Factor.TabIndex = 4;
            this.Grpr_Factor.TabStop = false;
            this.Grpr_Factor.Text = "جزئیات فاکتور";
            // 
            // Btn_Close
            // 
            this.Btn_Close.Location = new System.Drawing.Point(170, 346);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(113, 28);
            this.Btn_Close.TabIndex = 20;
            this.Btn_Close.Text = "محاسبه فاکتور";
            this.Btn_Close.UseVisualStyleBackColor = true;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Location = new System.Drawing.Point(289, 346);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(113, 28);
            this.Btn_Delete.TabIndex = 19;
            this.Btn_Delete.Text = "حذف از لیست";
            this.Btn_Delete.UseVisualStyleBackColor = true;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // Btn_AddToList
            // 
            this.Btn_AddToList.Location = new System.Drawing.Point(408, 346);
            this.Btn_AddToList.Name = "Btn_AddToList";
            this.Btn_AddToList.Size = new System.Drawing.Size(113, 28);
            this.Btn_AddToList.TabIndex = 17;
            this.Btn_AddToList.Text = "درج در فاکتور";
            this.Btn_AddToList.UseVisualStyleBackColor = true;
            this.Btn_AddToList.Click += new System.EventHandler(this.Btn_AddToList_Click);
            // 
            // Txt_Tajhfif
            // 
            this.Txt_Tajhfif.Location = new System.Drawing.Point(250, 318);
            this.Txt_Tajhfif.Name = "Txt_Tajhfif";
            this.Txt_Tajhfif.Size = new System.Drawing.Size(120, 21);
            this.Txt_Tajhfif.TabIndex = 16;
            this.Txt_Tajhfif.Text = "0";
            this.Txt_Tajhfif.TextChanged += new System.EventHandler(this.Txt_Tajhfif_TextChanged);
            this.Txt_Tajhfif.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Tajhfif_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(379, 321);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "تخفیف:";
            // 
            // Txt_FeeTotal
            // 
            this.Txt_FeeTotal.BackColor = System.Drawing.SystemColors.Info;
            this.Txt_FeeTotal.Location = new System.Drawing.Point(10, 318);
            this.Txt_FeeTotal.Name = "Txt_FeeTotal";
            this.Txt_FeeTotal.ReadOnly = true;
            this.Txt_FeeTotal.Size = new System.Drawing.Size(153, 21);
            this.Txt_FeeTotal.TabIndex = 14;
            this.Txt_FeeTotal.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(172, 321);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "قیمت کل:";
            // 
            // Txt_UnitPrice
            // 
            this.Txt_UnitPrice.BackColor = System.Drawing.Color.White;
            this.Txt_UnitPrice.Location = new System.Drawing.Point(453, 318);
            this.Txt_UnitPrice.Name = "Txt_UnitPrice";
            this.Txt_UnitPrice.Size = new System.Drawing.Size(120, 21);
            this.Txt_UnitPrice.TabIndex = 12;
            this.Txt_UnitPrice.Text = "0";
            this.Txt_UnitPrice.TextChanged += new System.EventHandler(this.Txt_UnitPrice_TextChanged);
            this.Txt_UnitPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_UnitPrice_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(582, 321);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "قیمت واحد:";
            // 
            // Txt_TedadeDarkhast
            // 
            this.Txt_TedadeDarkhast.Location = new System.Drawing.Point(10, 288);
            this.Txt_TedadeDarkhast.Name = "Txt_TedadeDarkhast";
            this.Txt_TedadeDarkhast.Size = new System.Drawing.Size(76, 21);
            this.Txt_TedadeDarkhast.TabIndex = 10;
            this.Txt_TedadeDarkhast.Text = "0";
            this.Txt_TedadeDarkhast.TextChanged += new System.EventHandler(this.Txt_TedadeDarkhast_TextChanged);
            this.Txt_TedadeDarkhast.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_TedadeDarkhast_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(92, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "تعداد درخواستی:";
            // 
            // Txt_Stock
            // 
            this.Txt_Stock.BackColor = System.Drawing.SystemColors.Info;
            this.Txt_Stock.Location = new System.Drawing.Point(207, 288);
            this.Txt_Stock.Name = "Txt_Stock";
            this.Txt_Stock.ReadOnly = true;
            this.Txt_Stock.Size = new System.Drawing.Size(76, 21);
            this.Txt_Stock.TabIndex = 8;
            this.Txt_Stock.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(289, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "موجودی:";
            // 
            // Txt_FlowerName
            // 
            this.Txt_FlowerName.BackColor = System.Drawing.SystemColors.Info;
            this.Txt_FlowerName.Location = new System.Drawing.Point(353, 288);
            this.Txt_FlowerName.Name = "Txt_FlowerName";
            this.Txt_FlowerName.ReadOnly = true;
            this.Txt_FlowerName.Size = new System.Drawing.Size(116, 21);
            this.Txt_FlowerName.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(478, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "نام:";
            // 
            // Txt_FlowerCode
            // 
            this.Txt_FlowerCode.BackColor = System.Drawing.SystemColors.Info;
            this.Txt_FlowerCode.Location = new System.Drawing.Point(537, 288);
            this.Txt_FlowerCode.Name = "Txt_FlowerCode";
            this.Txt_FlowerCode.ReadOnly = true;
            this.Txt_FlowerCode.Size = new System.Drawing.Size(64, 21);
            this.Txt_FlowerCode.TabIndex = 4;
            this.Txt_FlowerCode.Text = "0";
            // 
            // Lbl_FCode
            // 
            this.Lbl_FCode.AutoSize = true;
            this.Lbl_FCode.Location = new System.Drawing.Point(607, 291);
            this.Lbl_FCode.Name = "Lbl_FCode";
            this.Lbl_FCode.Size = new System.Drawing.Size(22, 13);
            this.Lbl_FCode.TabIndex = 3;
            this.Lbl_FCode.Text = "کد:";
            // 
            // GrPr_Mohasebeh
            // 
            this.GrPr_Mohasebeh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrPr_Mohasebeh.Controls.Add(this.btnAdd);
            this.GrPr_Mohasebeh.Controls.Add(this.Btn_Save);
            this.GrPr_Mohasebeh.Controls.Add(this.Lbl_Total_Takhfif);
            this.GrPr_Mohasebeh.Controls.Add(this.Lbl_Takhfif);
            this.GrPr_Mohasebeh.Controls.Add(this.Lbl_Total_Aglam);
            this.GrPr_Mohasebeh.Controls.Add(this.Lbl_Aglame_Factor);
            this.GrPr_Mohasebeh.Controls.Add(this.Lbl_Total_Price);
            this.GrPr_Mohasebeh.Controls.Add(this.Lbl_TOtal);
            this.GrPr_Mohasebeh.Enabled = false;
            this.GrPr_Mohasebeh.Location = new System.Drawing.Point(4, 491);
            this.GrPr_Mohasebeh.Name = "GrPr_Mohasebeh";
            this.GrPr_Mohasebeh.Size = new System.Drawing.Size(665, 117);
            this.GrPr_Mohasebeh.TabIndex = 5;
            this.GrPr_Mohasebeh.TabStop = false;
            this.GrPr_Mohasebeh.Text = "محاسبه فاکتور";
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::FlowerShop.Properties.Resources.Add_Btn_Sm;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdd.Location = new System.Drawing.Point(10, 16);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(119, 83);
            this.btnAdd.TabIndex = 70;
            this.btnAdd.Text = "اضافه کردن مجدد";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Btn_Save
            // 
            this.Btn_Save.Image = global::FlowerShop.Properties.Resources.Save_Sma;
            this.Btn_Save.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Save.Location = new System.Drawing.Point(135, 16);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(113, 83);
            this.Btn_Save.TabIndex = 71;
            this.Btn_Save.Text = "ثبت نهایی فاکتور";
            this.Btn_Save.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Lbl_Total_Takhfif
            // 
            this.Lbl_Total_Takhfif.AutoSize = true;
            this.Lbl_Total_Takhfif.Location = new System.Drawing.Point(379, 81);
            this.Lbl_Total_Takhfif.Name = "Lbl_Total_Takhfif";
            this.Lbl_Total_Takhfif.Size = new System.Drawing.Size(13, 13);
            this.Lbl_Total_Takhfif.TabIndex = 5;
            this.Lbl_Total_Takhfif.Text = "0";
            // 
            // Lbl_Takhfif
            // 
            this.Lbl_Takhfif.AutoSize = true;
            this.Lbl_Takhfif.Location = new System.Drawing.Point(567, 81);
            this.Lbl_Takhfif.Name = "Lbl_Takhfif";
            this.Lbl_Takhfif.Size = new System.Drawing.Size(57, 13);
            this.Lbl_Takhfif.TabIndex = 4;
            this.Lbl_Takhfif.Text = "کل تخفیف:";
            // 
            // Lbl_Total_Aglam
            // 
            this.Lbl_Total_Aglam.AutoSize = true;
            this.Lbl_Total_Aglam.Location = new System.Drawing.Point(379, 54);
            this.Lbl_Total_Aglam.Name = "Lbl_Total_Aglam";
            this.Lbl_Total_Aglam.Size = new System.Drawing.Size(13, 13);
            this.Lbl_Total_Aglam.TabIndex = 3;
            this.Lbl_Total_Aglam.Text = "0";
            // 
            // Lbl_Aglame_Factor
            // 
            this.Lbl_Aglame_Factor.AutoSize = true;
            this.Lbl_Aglame_Factor.Location = new System.Drawing.Point(535, 54);
            this.Lbl_Aglame_Factor.Name = "Lbl_Aglame_Factor";
            this.Lbl_Aglame_Factor.Size = new System.Drawing.Size(89, 13);
            this.Lbl_Aglame_Factor.TabIndex = 2;
            this.Lbl_Aglame_Factor.Text = "تعداد اقلام فاکتور:";
            // 
            // Lbl_Total_Price
            // 
            this.Lbl_Total_Price.AutoSize = true;
            this.Lbl_Total_Price.Location = new System.Drawing.Point(379, 28);
            this.Lbl_Total_Price.Name = "Lbl_Total_Price";
            this.Lbl_Total_Price.Size = new System.Drawing.Size(13, 13);
            this.Lbl_Total_Price.TabIndex = 1;
            this.Lbl_Total_Price.Text = "0";
            // 
            // Lbl_TOtal
            // 
            this.Lbl_TOtal.AutoSize = true;
            this.Lbl_TOtal.Location = new System.Drawing.Point(518, 28);
            this.Lbl_TOtal.Name = "Lbl_TOtal";
            this.Lbl_TOtal.Size = new System.Drawing.Size(105, 13);
            this.Lbl_TOtal.TabIndex = 0;
            this.Lbl_TOtal.Text = "کل مبلغ قابل پرداخت:";
            // 
            // frmFactor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 615);
            this.Controls.Add(this.GrPr_Mohasebeh);
            this.Controls.Add(this.Grpr_Factor);
            this.Controls.Add(this.Grpr_Custumer);
            this.Controls.Add(this.Grd_FlowerDescription);
            this.Controls.Add(this.Grd_FlowerCategory);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "frmFactor";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "فرم فاکتور";
            this.Load += new System.EventHandler(this.frmFactor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grd_FlowerCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_FlowerDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Factor)).EndInit();
            this.Grpr_Custumer.ResumeLayout(false);
            this.Grpr_Custumer.PerformLayout();
            this.Grpr_Factor.ResumeLayout(false);
            this.Grpr_Factor.PerformLayout();
            this.GrPr_Mohasebeh.ResumeLayout(false);
            this.GrPr_Mohasebeh.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Grd_FlowerCategory;
        private System.Windows.Forms.DataGridView Grd_FlowerDescription;
        private System.Windows.Forms.DataGridView Grd_Factor;
        private System.Windows.Forms.GroupBox Grpr_Custumer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Lbl_CustomerCode;
        private System.Windows.Forms.TextBox Txt_NameSname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Address;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_Phone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Mobile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox Grpr_Factor;
        private System.Windows.Forms.TextBox Txt_FlowerCode;
        private System.Windows.Forms.Label Lbl_FCode;
        private System.Windows.Forms.TextBox Txt_Stock;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txt_FlowerName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_UnitPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Txt_TedadeDarkhast;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Txt_FeeTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Txt_Tajhfif;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button Btn_AddToList;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.Button Btn_Close;
        public System.Windows.Forms.TextBox Txt_CustomerCode;
        private System.Windows.Forms.GroupBox GrPr_Mohasebeh;
        private System.Windows.Forms.Label Lbl_Total_Price;
        private System.Windows.Forms.Label Lbl_TOtal;
        private System.Windows.Forms.Label Lbl_Total_Takhfif;
        private System.Windows.Forms.Label Lbl_Takhfif;
        private System.Windows.Forms.Label Lbl_Total_Aglam;
        private System.Windows.Forms.Label Lbl_Aglame_Factor;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlowerCateguryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlowerCateguryDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlowerID1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlowerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlowerQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlowerUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlowerDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlowerTotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlowerDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlowerStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlowerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
    }
}