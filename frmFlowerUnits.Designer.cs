namespace FlowerShop
{
    partial class frmFlowerUnits
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
            System.Windows.Forms.Label LblCategID;
            System.Windows.Forms.Label Lbl_FoodUnit;
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FlowerUnitID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlowerUnitDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Txt_UnitID = new System.Windows.Forms.TextBox();
            this.Txt_AssetUnit = new System.Windows.Forms.TextBox();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.Btn_Edit = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Btn_Refresh = new System.Windows.Forms.Button();
            LblCategID = new System.Windows.Forms.Label();
            Lbl_FoodUnit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblCategID
            // 
            LblCategID.AutoSize = true;
            LblCategID.Location = new System.Drawing.Point(315, 365);
            LblCategID.Name = "LblCategID";
            LblCategID.Size = new System.Drawing.Size(87, 13);
            LblCategID.TabIndex = 43;
            LblCategID.Text = "کد واحد شمارش:";
            // 
            // Lbl_FoodUnit
            // 
            Lbl_FoodUnit.AutoSize = true;
            Lbl_FoodUnit.Location = new System.Drawing.Point(333, 200);
            Lbl_FoodUnit.Name = "Lbl_FoodUnit";
            Lbl_FoodUnit.Size = new System.Drawing.Size(73, 13);
            Lbl_FoodUnit.TabIndex = 41;
            Lbl_FoodUnit.Text = "واحد شمارش:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FlowerUnitID,
            this.FlowerUnitDescription});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(498, 191);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // FlowerUnitID
            // 
            this.FlowerUnitID.DataPropertyName = "FLowerUnitID";
            this.FlowerUnitID.HeaderText = "کد واحد شمارش";
            this.FlowerUnitID.Name = "FlowerUnitID";
            this.FlowerUnitID.ReadOnly = true;
            this.FlowerUnitID.Width = 150;
            // 
            // FlowerUnitDescription
            // 
            this.FlowerUnitDescription.DataPropertyName = "FlowerUnitDescription";
            this.FlowerUnitDescription.HeaderText = "شرح واحد شمارش";
            this.FlowerUnitDescription.Name = "FlowerUnitDescription";
            this.FlowerUnitDescription.ReadOnly = true;
            this.FlowerUnitDescription.Width = 250;
            // 
            // Txt_UnitID
            // 
            this.Txt_UnitID.Location = new System.Drawing.Point(33, 362);
            this.Txt_UnitID.Name = "Txt_UnitID";
            this.Txt_UnitID.Size = new System.Drawing.Size(276, 21);
            this.Txt_UnitID.TabIndex = 42;
            // 
            // Txt_AssetUnit
            // 
            this.Txt_AssetUnit.Location = new System.Drawing.Point(51, 197);
            this.Txt_AssetUnit.Name = "Txt_AssetUnit";
            this.Txt_AssetUnit.Size = new System.Drawing.Size(276, 21);
            this.Txt_AssetUnit.TabIndex = 40;
            // 
            // Btn_Search
            // 
            this.Btn_Search.Image = global::FlowerShop.Properties.Resources.Search_Sm;
            this.Btn_Search.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Search.Location = new System.Drawing.Point(33, 236);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(90, 83);
            this.Btn_Search.TabIndex = 47;
            this.Btn_Search.Text = "جستجو کردن";
            this.Btn_Search.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Search.UseVisualStyleBackColor = true;
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // Btn_Edit
            // 
            this.Btn_Edit.Image = global::FlowerShop.Properties.Resources.Edit_Btn_Sm;
            this.Btn_Edit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Edit.Location = new System.Drawing.Point(224, 236);
            this.Btn_Edit.Name = "Btn_Edit";
            this.Btn_Edit.Size = new System.Drawing.Size(90, 83);
            this.Btn_Edit.TabIndex = 46;
            this.Btn_Edit.Text = "ویرایش کردن";
            this.Btn_Edit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Edit.UseVisualStyleBackColor = true;
            this.Btn_Edit.Click += new System.EventHandler(this.Btn_Edit_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Image = global::FlowerShop.Properties.Resources.Delete_Btn_Sm;
            this.Btn_Delete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Delete.Location = new System.Drawing.Point(128, 236);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(90, 83);
            this.Btn_Delete.TabIndex = 45;
            this.Btn_Delete.Text = "حذف کردن";
            this.Btn_Delete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Delete.UseVisualStyleBackColor = true;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::FlowerShop.Properties.Resources.Add_Btn_Sm;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdd.Location = new System.Drawing.Point(320, 236);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 83);
            this.btnAdd.TabIndex = 44;
            this.btnAdd.Text = "اضافه کردن";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Btn_Save
            // 
            this.Btn_Save.Image = global::FlowerShop.Properties.Resources.Save_Sma;
            this.Btn_Save.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Save.Location = new System.Drawing.Point(320, 236);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(84, 83);
            this.Btn_Save.TabIndex = 48;
            this.Btn_Save.Text = "ذخیره";
            this.Btn_Save.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Btn_Refresh
            // 
            this.Btn_Refresh.Image = global::FlowerShop.Properties.Resources.refresh1001_Sm;
            this.Btn_Refresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Refresh.Location = new System.Drawing.Point(33, 236);
            this.Btn_Refresh.Name = "Btn_Refresh";
            this.Btn_Refresh.Size = new System.Drawing.Size(90, 83);
            this.Btn_Refresh.TabIndex = 49;
            this.Btn_Refresh.Text = "بازنشانی";
            this.Btn_Refresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Refresh.UseVisualStyleBackColor = true;
            this.Btn_Refresh.Click += new System.EventHandler(this.Btn_Refresh_Click);
            // 
            // frmFlowerUnits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 327);
            this.Controls.Add(this.Btn_Search);
            this.Controls.Add(this.Btn_Edit);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.Btn_Refresh);
            this.Controls.Add(LblCategID);
            this.Controls.Add(this.Txt_UnitID);
            this.Controls.Add(Lbl_FoodUnit);
            this.Controls.Add(this.Txt_AssetUnit);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmFlowerUnits";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "فرم واحد شمارش گلها";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmFlowerUnits_FormClosed);
            this.Load += new System.EventHandler(this.frmFlowerUnits_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox Txt_UnitID;
        private System.Windows.Forms.TextBox Txt_AssetUnit;
        private System.Windows.Forms.Button Btn_Search;
        private System.Windows.Forms.Button Btn_Edit;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Button Btn_Refresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlowerUnitID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlowerUnitDescription;
    }
}