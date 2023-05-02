namespace FlowerShop
{
    partial class frmFlowerCategury
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
            System.Windows.Forms.Label Lbl_FoodCategury;
            System.Windows.Forms.Label LblCategID;
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Txt_FlowerCategury = new System.Windows.Forms.TextBox();
            this.Txt_CateguryID = new System.Windows.Forms.TextBox();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.Btn_Edit = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Btn_Refresh = new System.Windows.Forms.Button();
            this.FlowerCateguryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlowerCateguryDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Lbl_FoodCategury = new System.Windows.Forms.Label();
            LblCategID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_FoodCategury
            // 
            Lbl_FoodCategury.AutoSize = true;
            Lbl_FoodCategury.Location = new System.Drawing.Point(292, 185);
            Lbl_FoodCategury.Name = "Lbl_FoodCategury";
            Lbl_FoodCategury.Size = new System.Drawing.Size(92, 13);
            Lbl_FoodCategury.TabIndex = 31;
            Lbl_FoodCategury.Text = "عنوان دسته بندی:";
            // 
            // LblCategID
            // 
            LblCategID.AutoSize = true;
            LblCategID.Location = new System.Drawing.Point(308, 378);
            LblCategID.Name = "LblCategID";
            LblCategID.Size = new System.Drawing.Size(92, 13);
            LblCategID.TabIndex = 33;
            LblCategID.Text = "عنوان دسته بندی:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FlowerCateguryID,
            this.FlowerCateguryDescription});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(504, 176);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Txt_FlowerCategury
            // 
            this.Txt_FlowerCategury.Location = new System.Drawing.Point(10, 182);
            this.Txt_FlowerCategury.Name = "Txt_FlowerCategury";
            this.Txt_FlowerCategury.Size = new System.Drawing.Size(276, 21);
            this.Txt_FlowerCategury.TabIndex = 30;
            // 
            // Txt_CateguryID
            // 
            this.Txt_CateguryID.Location = new System.Drawing.Point(26, 375);
            this.Txt_CateguryID.Name = "Txt_CateguryID";
            this.Txt_CateguryID.Size = new System.Drawing.Size(276, 21);
            this.Txt_CateguryID.TabIndex = 32;
            // 
            // Btn_Search
            // 
            this.Btn_Search.Image = global::FlowerShop.Properties.Resources.Search_Sm;
            this.Btn_Search.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Search.Location = new System.Drawing.Point(68, 213);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(90, 83);
            this.Btn_Search.TabIndex = 27;
            this.Btn_Search.Text = "جستجو کردن";
            this.Btn_Search.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Search.UseVisualStyleBackColor = true;
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // Btn_Edit
            // 
            this.Btn_Edit.Image = global::FlowerShop.Properties.Resources.Edit_Btn_Sm;
            this.Btn_Edit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Edit.Location = new System.Drawing.Point(260, 213);
            this.Btn_Edit.Name = "Btn_Edit";
            this.Btn_Edit.Size = new System.Drawing.Size(90, 83);
            this.Btn_Edit.TabIndex = 26;
            this.Btn_Edit.Text = "ویرایش کردن";
            this.Btn_Edit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Edit.UseVisualStyleBackColor = true;
            this.Btn_Edit.Click += new System.EventHandler(this.Btn_Edit_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Image = global::FlowerShop.Properties.Resources.Delete_Btn_Sm;
            this.Btn_Delete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Delete.Location = new System.Drawing.Point(164, 213);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(90, 83);
            this.Btn_Delete.TabIndex = 25;
            this.Btn_Delete.Text = "حذف کردن";
            this.Btn_Delete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Delete.UseVisualStyleBackColor = true;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::FlowerShop.Properties.Resources.Add_Btn_Sm;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdd.Location = new System.Drawing.Point(356, 213);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 83);
            this.btnAdd.TabIndex = 24;
            this.btnAdd.Text = "اضافه کردن";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Btn_Save
            // 
            this.Btn_Save.Image = global::FlowerShop.Properties.Resources.Save_Sma;
            this.Btn_Save.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Save.Location = new System.Drawing.Point(356, 213);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(84, 83);
            this.Btn_Save.TabIndex = 28;
            this.Btn_Save.Text = "ذخیره";
            this.Btn_Save.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Btn_Refresh
            // 
            this.Btn_Refresh.Image = global::FlowerShop.Properties.Resources.refresh1001_Sm;
            this.Btn_Refresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Refresh.Location = new System.Drawing.Point(69, 213);
            this.Btn_Refresh.Name = "Btn_Refresh";
            this.Btn_Refresh.Size = new System.Drawing.Size(90, 83);
            this.Btn_Refresh.TabIndex = 29;
            this.Btn_Refresh.Text = "بازنشانی";
            this.Btn_Refresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Refresh.UseVisualStyleBackColor = true;
            this.Btn_Refresh.Click += new System.EventHandler(this.Btn_Refresh_Click);
            // 
            // FlowerCateguryID
            // 
            this.FlowerCateguryID.DataPropertyName = "FlowerCateguryID";
            this.FlowerCateguryID.HeaderText = "کد دسته بندی";
            this.FlowerCateguryID.Name = "FlowerCateguryID";
            this.FlowerCateguryID.ReadOnly = true;
            // 
            // FlowerCateguryDescription
            // 
            this.FlowerCateguryDescription.DataPropertyName = "FlowerCateguryDescription";
            this.FlowerCateguryDescription.HeaderText = "عنوان دسته بندی گل";
            this.FlowerCateguryDescription.Name = "FlowerCateguryDescription";
            this.FlowerCateguryDescription.ReadOnly = true;
            this.FlowerCateguryDescription.Width = 300;
            // 
            // frmFlowerCategury
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 307);
            this.Controls.Add(LblCategID);
            this.Controls.Add(this.Txt_CateguryID);
            this.Controls.Add(Lbl_FoodCategury);
            this.Controls.Add(this.Txt_FlowerCategury);
            this.Controls.Add(this.Btn_Search);
            this.Controls.Add(this.Btn_Edit);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.Btn_Refresh);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmFlowerCategury";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "فرم دسته بندی گل";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmFoodCategury_FormClosed);
            this.Load += new System.EventHandler(this.frmFoodCategury_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Btn_Search;
        private System.Windows.Forms.Button Btn_Edit;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Button Btn_Refresh;
        private System.Windows.Forms.TextBox Txt_FlowerCategury;
        private System.Windows.Forms.TextBox Txt_CateguryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlowerCateguryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlowerCateguryDescription;
    }
}