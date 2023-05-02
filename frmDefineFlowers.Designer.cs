namespace FlowerShop
{
    partial class frmDefineFlowers
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
            this.Cmb_FlowerCategury = new System.Windows.Forms.ComboBox();
            this.Lbl_FoodCategury = new System.Windows.Forms.Label();
            this.Lbl_FoodUnit = new System.Windows.Forms.Label();
            this.Cmb_FlowerUnit = new System.Windows.Forms.ComboBox();
            this.Txt_FlowerDescription = new System.Windows.Forms.TextBox();
            this.Lbl_FoodDescription = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_FoodID = new System.Windows.Forms.TextBox();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.Btn_Edit = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Btn_Refresh = new System.Windows.Forms.Button();
            this.FlowerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlowerDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlowerCateguryDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlowerUnitDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FlowerID,
            this.FlowerDescription,
            this.FlowerCateguryDescription,
            this.FlowerUnitDescription});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(713, 292);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Cmb_FlowerCategury
            // 
            this.Cmb_FlowerCategury.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_FlowerCategury.FormattingEnabled = true;
            this.Cmb_FlowerCategury.Location = new System.Drawing.Point(390, 360);
            this.Cmb_FlowerCategury.Name = "Cmb_FlowerCategury";
            this.Cmb_FlowerCategury.Size = new System.Drawing.Size(222, 21);
            this.Cmb_FlowerCategury.TabIndex = 3;
            // 
            // Lbl_FoodCategury
            // 
            this.Lbl_FoodCategury.AutoSize = true;
            this.Lbl_FoodCategury.Location = new System.Drawing.Point(632, 363);
            this.Lbl_FoodCategury.Name = "Lbl_FoodCategury";
            this.Lbl_FoodCategury.Size = new System.Drawing.Size(63, 13);
            this.Lbl_FoodCategury.TabIndex = 4;
            this.Lbl_FoodCategury.Text = "دسته بندی:";
            // 
            // Lbl_FoodUnit
            // 
            this.Lbl_FoodUnit.AutoSize = true;
            this.Lbl_FoodUnit.Location = new System.Drawing.Point(622, 336);
            this.Lbl_FoodUnit.Name = "Lbl_FoodUnit";
            this.Lbl_FoodUnit.Size = new System.Drawing.Size(73, 13);
            this.Lbl_FoodUnit.TabIndex = 6;
            this.Lbl_FoodUnit.Text = "واحد شمارش:";
            // 
            // Cmb_FlowerUnit
            // 
            this.Cmb_FlowerUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_FlowerUnit.FormattingEnabled = true;
            this.Cmb_FlowerUnit.Location = new System.Drawing.Point(390, 333);
            this.Cmb_FlowerUnit.Name = "Cmb_FlowerUnit";
            this.Cmb_FlowerUnit.Size = new System.Drawing.Size(222, 21);
            this.Cmb_FlowerUnit.TabIndex = 5;
            this.Cmb_FlowerUnit.SelectedIndexChanged += new System.EventHandler(this.Cmb_FoodUnit_SelectedIndexChanged);
            // 
            // Txt_FlowerDescription
            // 
            this.Txt_FlowerDescription.Location = new System.Drawing.Point(390, 306);
            this.Txt_FlowerDescription.Name = "Txt_FlowerDescription";
            this.Txt_FlowerDescription.Size = new System.Drawing.Size(222, 21);
            this.Txt_FlowerDescription.TabIndex = 7;
            // 
            // Lbl_FoodDescription
            // 
            this.Lbl_FoodDescription.AutoSize = true;
            this.Lbl_FoodDescription.Location = new System.Drawing.Point(658, 309);
            this.Lbl_FoodDescription.Name = "Lbl_FoodDescription";
            this.Lbl_FoodDescription.Size = new System.Drawing.Size(37, 13);
            this.Lbl_FoodDescription.TabIndex = 8;
            this.Lbl_FoodDescription.Text = "عنوان:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(455, 461);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "کد عنوان:";
            // 
            // Txt_FoodID
            // 
            this.Txt_FoodID.Location = new System.Drawing.Point(187, 458);
            this.Txt_FoodID.Name = "Txt_FoodID";
            this.Txt_FoodID.Size = new System.Drawing.Size(222, 21);
            this.Txt_FoodID.TabIndex = 36;
            // 
            // Btn_Search
            // 
            this.Btn_Search.Image = global::FlowerShop.Properties.Resources.Search_Sm;
            this.Btn_Search.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Search.Location = new System.Drawing.Point(12, 299);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(90, 83);
            this.Btn_Search.TabIndex = 33;
            this.Btn_Search.Text = "جستجو کردن";
            this.Btn_Search.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Search.UseVisualStyleBackColor = true;
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // Btn_Edit
            // 
            this.Btn_Edit.Image = global::FlowerShop.Properties.Resources.Edit_Btn_Sm;
            this.Btn_Edit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Edit.Location = new System.Drawing.Point(204, 298);
            this.Btn_Edit.Name = "Btn_Edit";
            this.Btn_Edit.Size = new System.Drawing.Size(90, 83);
            this.Btn_Edit.TabIndex = 32;
            this.Btn_Edit.Text = "ویرایش کردن";
            this.Btn_Edit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Edit.UseVisualStyleBackColor = true;
            this.Btn_Edit.Click += new System.EventHandler(this.Btn_Edit_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Image = global::FlowerShop.Properties.Resources.Delete_Btn_Sm;
            this.Btn_Delete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Delete.Location = new System.Drawing.Point(108, 298);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(90, 83);
            this.Btn_Delete.TabIndex = 31;
            this.Btn_Delete.Text = "حذف کردن";
            this.Btn_Delete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Delete.UseVisualStyleBackColor = true;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::FlowerShop.Properties.Resources.Add_Btn_Sm;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdd.Location = new System.Drawing.Point(300, 299);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 83);
            this.btnAdd.TabIndex = 30;
            this.btnAdd.Text = "اضافه کردن";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Btn_Save
            // 
            this.Btn_Save.Image = global::FlowerShop.Properties.Resources.Save_Sma;
            this.Btn_Save.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Save.Location = new System.Drawing.Point(300, 298);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(84, 83);
            this.Btn_Save.TabIndex = 34;
            this.Btn_Save.Text = "ذخیره";
            this.Btn_Save.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Btn_Refresh
            // 
            this.Btn_Refresh.Image = global::FlowerShop.Properties.Resources.refresh1001_Sm;
            this.Btn_Refresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Refresh.Location = new System.Drawing.Point(13, 298);
            this.Btn_Refresh.Name = "Btn_Refresh";
            this.Btn_Refresh.Size = new System.Drawing.Size(90, 83);
            this.Btn_Refresh.TabIndex = 35;
            this.Btn_Refresh.Text = "بازنشانی";
            this.Btn_Refresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Refresh.UseVisualStyleBackColor = true;
            this.Btn_Refresh.Click += new System.EventHandler(this.Btn_Refresh_Click);
            // 
            // FlowerID
            // 
            this.FlowerID.DataPropertyName = "FlowerID";
            this.FlowerID.HeaderText = "کد";
            this.FlowerID.Name = "FlowerID";
            this.FlowerID.ReadOnly = true;
            // 
            // FlowerDescription
            // 
            this.FlowerDescription.DataPropertyName = "FlowerDescription";
            this.FlowerDescription.HeaderText = "عنوان";
            this.FlowerDescription.Name = "FlowerDescription";
            this.FlowerDescription.ReadOnly = true;
            this.FlowerDescription.Width = 200;
            // 
            // FlowerCateguryDescription
            // 
            this.FlowerCateguryDescription.DataPropertyName = "FlowerCateguryDescription";
            this.FlowerCateguryDescription.HeaderText = "دسته بندی";
            this.FlowerCateguryDescription.Name = "FlowerCateguryDescription";
            this.FlowerCateguryDescription.ReadOnly = true;
            this.FlowerCateguryDescription.Width = 150;
            // 
            // FlowerUnitDescription
            // 
            this.FlowerUnitDescription.DataPropertyName = "FlowerUnitDescription";
            this.FlowerUnitDescription.HeaderText = "واحد شمارش";
            this.FlowerUnitDescription.Name = "FlowerUnitDescription";
            this.FlowerUnitDescription.ReadOnly = true;
            this.FlowerUnitDescription.Width = 150;
            // 
            // frmDefineFlowers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 390);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_FoodID);
            this.Controls.Add(this.Btn_Search);
            this.Controls.Add(this.Btn_Edit);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.Btn_Refresh);
            this.Controls.Add(this.Lbl_FoodDescription);
            this.Controls.Add(this.Txt_FlowerDescription);
            this.Controls.Add(this.Lbl_FoodUnit);
            this.Controls.Add(this.Cmb_FlowerUnit);
            this.Controls.Add(this.Lbl_FoodCategury);
            this.Controls.Add(this.Cmb_FlowerCategury);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDefineFlowers";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "فرم تعریف گل جدید";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDefineFoods_FormClosed);
            this.Load += new System.EventHandler(this.frmDefineFoods_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox Cmb_FlowerCategury;
        private System.Windows.Forms.Label Lbl_FoodCategury;
        private System.Windows.Forms.Label Lbl_FoodUnit;
        private System.Windows.Forms.ComboBox Cmb_FlowerUnit;
        private System.Windows.Forms.TextBox Txt_FlowerDescription;
        private System.Windows.Forms.Label Lbl_FoodDescription;
        private System.Windows.Forms.Button Btn_Search;
        private System.Windows.Forms.Button Btn_Edit;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Button Btn_Refresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_FoodID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlowerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlowerDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlowerCateguryDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlowerUnitDescription;
    }
}