namespace FlowerShop
{
    partial class frmMojodi
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
            System.Windows.Forms.Label Lbl_FlowerDes;
            System.Windows.Forms.Label Lbl_Number;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.Btn_Search = new System.Windows.Forms.Button();
            this.Btn_Edit = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Btn_Refresh = new System.Windows.Forms.Button();
            this.Txt_FlowerUnit = new System.Windows.Forms.TextBox();
            this.Cmb_FlowerDes = new System.Windows.Forms.ComboBox();
            this.Txt_FlowerID = new System.Windows.Forms.TextBox();
            this.Txt_Search = new System.Windows.Forms.TextBox();
            this.Grd_Mojodi = new System.Windows.Forms.DataGridView();
            this.Lbl_UnitPrice = new System.Windows.Forms.Label();
            this.Txt_UnitPrice = new System.Windows.Forms.TextBox();
            this.Lbl_Date = new System.Windows.Forms.Label();
            this.Txt_Date = new System.Windows.Forms.TextBox();
            this.Btn_SaveEdit = new System.Windows.Forms.Button();
            this.RowMojodi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlowerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlowerDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnterDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfFlower = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Lbl_FlowerDes = new System.Windows.Forms.Label();
            Lbl_Number = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Mojodi)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_FlowerDes
            // 
            Lbl_FlowerDes.AutoSize = true;
            Lbl_FlowerDes.Location = new System.Drawing.Point(575, 213);
            Lbl_FlowerDes.Name = "Lbl_FlowerDes";
            Lbl_FlowerDes.Size = new System.Drawing.Size(53, 13);
            Lbl_FlowerDes.TabIndex = 43;
            Lbl_FlowerDes.Text = "عنوان گل:";
            // 
            // Lbl_Number
            // 
            Lbl_Number.AutoSize = true;
            Lbl_Number.Location = new System.Drawing.Point(575, 246);
            Lbl_Number.Name = "Lbl_Number";
            Lbl_Number.Size = new System.Drawing.Size(34, 13);
            Lbl_Number.TabIndex = 56;
            Lbl_Number.Text = "تعداد:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(587, 394);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(38, 13);
            label1.TabIndex = 60;
            label1.Text = "کد گل:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(257, 307);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(85, 13);
            label2.TabIndex = 61;
            label2.Text = "جستجوی عنوان:";
            // 
            // Btn_Search
            // 
            this.Btn_Search.Image = global::FlowerShop.Properties.Resources.Search_Sm;
            this.Btn_Search.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Search.Location = new System.Drawing.Point(7, 205);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(90, 83);
            this.Btn_Search.TabIndex = 53;
            this.Btn_Search.Text = "جستجو کردن";
            this.Btn_Search.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Search.UseVisualStyleBackColor = true;
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // Btn_Edit
            // 
            this.Btn_Edit.Image = global::FlowerShop.Properties.Resources.Edit_Btn_Sm;
            this.Btn_Edit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Edit.Location = new System.Drawing.Point(198, 205);
            this.Btn_Edit.Name = "Btn_Edit";
            this.Btn_Edit.Size = new System.Drawing.Size(84, 83);
            this.Btn_Edit.TabIndex = 52;
            this.Btn_Edit.Text = "ویرایش کردن";
            this.Btn_Edit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Edit.UseVisualStyleBackColor = true;
            this.Btn_Edit.Click += new System.EventHandler(this.Btn_Edit_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Image = global::FlowerShop.Properties.Resources.Delete_Btn_Sm;
            this.Btn_Delete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Delete.Location = new System.Drawing.Point(102, 204);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(90, 83);
            this.Btn_Delete.TabIndex = 51;
            this.Btn_Delete.Text = "حذف کردن";
            this.Btn_Delete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Delete.UseVisualStyleBackColor = true;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::FlowerShop.Properties.Resources.Add_Btn_Sm;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdd.Location = new System.Drawing.Point(288, 205);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 83);
            this.btnAdd.TabIndex = 50;
            this.btnAdd.Text = "اضافه کردن";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Btn_Save
            // 
            this.Btn_Save.Image = global::FlowerShop.Properties.Resources.Save_Sma;
            this.Btn_Save.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Save.Location = new System.Drawing.Point(288, 205);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(84, 83);
            this.Btn_Save.TabIndex = 54;
            this.Btn_Save.Text = "ذخیره";
            this.Btn_Save.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Btn_Refresh
            // 
            this.Btn_Refresh.Image = global::FlowerShop.Properties.Resources.refresh1001_Sm;
            this.Btn_Refresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Refresh.Location = new System.Drawing.Point(7, 204);
            this.Btn_Refresh.Name = "Btn_Refresh";
            this.Btn_Refresh.Size = new System.Drawing.Size(90, 83);
            this.Btn_Refresh.TabIndex = 55;
            this.Btn_Refresh.Text = "بازنشانی";
            this.Btn_Refresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Refresh.UseVisualStyleBackColor = true;
            this.Btn_Refresh.Click += new System.EventHandler(this.Btn_Refresh_Click);
            // 
            // Txt_FlowerUnit
            // 
            this.Txt_FlowerUnit.Location = new System.Drawing.Point(399, 246);
            this.Txt_FlowerUnit.Name = "Txt_FlowerUnit";
            this.Txt_FlowerUnit.Size = new System.Drawing.Size(170, 21);
            this.Txt_FlowerUnit.TabIndex = 57;
            // 
            // Cmb_FlowerDes
            // 
            this.Cmb_FlowerDes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_FlowerDes.FormattingEnabled = true;
            this.Cmb_FlowerDes.Location = new System.Drawing.Point(399, 213);
            this.Cmb_FlowerDes.Name = "Cmb_FlowerDes";
            this.Cmb_FlowerDes.Size = new System.Drawing.Size(170, 21);
            this.Cmb_FlowerDes.TabIndex = 58;
            // 
            // Txt_FlowerID
            // 
            this.Txt_FlowerID.Location = new System.Drawing.Point(411, 391);
            this.Txt_FlowerID.Name = "Txt_FlowerID";
            this.Txt_FlowerID.Size = new System.Drawing.Size(170, 21);
            this.Txt_FlowerID.TabIndex = 59;
            // 
            // Txt_Search
            // 
            this.Txt_Search.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.Txt_Search.Location = new System.Drawing.Point(10, 304);
            this.Txt_Search.Name = "Txt_Search";
            this.Txt_Search.Size = new System.Drawing.Size(241, 21);
            this.Txt_Search.TabIndex = 62;
            // 
            // Grd_Mojodi
            // 
            this.Grd_Mojodi.AllowUserToAddRows = false;
            this.Grd_Mojodi.AllowUserToDeleteRows = false;
            this.Grd_Mojodi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grd_Mojodi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RowMojodi,
            this.FlowerID,
            this.FlowerDescription,
            this.EnterDate,
            this.NumberOfFlower,
            this.UnitPrice});
            this.Grd_Mojodi.Dock = System.Windows.Forms.DockStyle.Top;
            this.Grd_Mojodi.Location = new System.Drawing.Point(0, 0);
            this.Grd_Mojodi.Name = "Grd_Mojodi";
            this.Grd_Mojodi.ReadOnly = true;
            this.Grd_Mojodi.Size = new System.Drawing.Size(657, 187);
            this.Grd_Mojodi.TabIndex = 63;
            this.Grd_Mojodi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grd_Mojodi_CellClick);
            // 
            // Lbl_UnitPrice
            // 
            this.Lbl_UnitPrice.AutoSize = true;
            this.Lbl_UnitPrice.Location = new System.Drawing.Point(575, 282);
            this.Lbl_UnitPrice.Name = "Lbl_UnitPrice";
            this.Lbl_UnitPrice.Size = new System.Drawing.Size(61, 13);
            this.Lbl_UnitPrice.TabIndex = 64;
            this.Lbl_UnitPrice.Text = "قیمت واحد:";
            // 
            // Txt_UnitPrice
            // 
            this.Txt_UnitPrice.Location = new System.Drawing.Point(399, 279);
            this.Txt_UnitPrice.Name = "Txt_UnitPrice";
            this.Txt_UnitPrice.Size = new System.Drawing.Size(170, 21);
            this.Txt_UnitPrice.TabIndex = 65;
            // 
            // Lbl_Date
            // 
            this.Lbl_Date.AutoSize = true;
            this.Lbl_Date.Location = new System.Drawing.Point(587, 367);
            this.Lbl_Date.Name = "Lbl_Date";
            this.Lbl_Date.Size = new System.Drawing.Size(54, 13);
            this.Lbl_Date.TabIndex = 66;
            this.Lbl_Date.Text = "تاریخ ورود:";
            // 
            // Txt_Date
            // 
            this.Txt_Date.Location = new System.Drawing.Point(411, 364);
            this.Txt_Date.Name = "Txt_Date";
            this.Txt_Date.Size = new System.Drawing.Size(170, 21);
            this.Txt_Date.TabIndex = 67;
            // 
            // Btn_SaveEdit
            // 
            this.Btn_SaveEdit.Image = global::FlowerShop.Properties.Resources.Save_Sma;
            this.Btn_SaveEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_SaveEdit.Location = new System.Drawing.Point(198, 205);
            this.Btn_SaveEdit.Name = "Btn_SaveEdit";
            this.Btn_SaveEdit.Size = new System.Drawing.Size(84, 83);
            this.Btn_SaveEdit.TabIndex = 68;
            this.Btn_SaveEdit.Text = "ذخیره";
            this.Btn_SaveEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_SaveEdit.UseVisualStyleBackColor = true;
            this.Btn_SaveEdit.Click += new System.EventHandler(this.Btn_SaveEdit_Click);
            // 
            // RowMojodi
            // 
            this.RowMojodi.DataPropertyName = "RowMojodi";
            this.RowMojodi.HeaderText = "شماره ردیف";
            this.RowMojodi.Name = "RowMojodi";
            this.RowMojodi.ReadOnly = true;
            // 
            // FlowerID
            // 
            this.FlowerID.DataPropertyName = "FlowerID";
            this.FlowerID.HeaderText = "کد گل";
            this.FlowerID.Name = "FlowerID";
            this.FlowerID.ReadOnly = true;
            // 
            // FlowerDescription
            // 
            this.FlowerDescription.DataPropertyName = "FlowerDescription";
            this.FlowerDescription.HeaderText = "نام گل";
            this.FlowerDescription.Name = "FlowerDescription";
            this.FlowerDescription.ReadOnly = true;
            // 
            // EnterDate
            // 
            this.EnterDate.DataPropertyName = "EnterDate";
            this.EnterDate.HeaderText = "تاریخ ورود";
            this.EnterDate.Name = "EnterDate";
            this.EnterDate.ReadOnly = true;
            // 
            // NumberOfFlower
            // 
            this.NumberOfFlower.DataPropertyName = "NumberOfFlower";
            this.NumberOfFlower.HeaderText = "تعداد گل";
            this.NumberOfFlower.Name = "NumberOfFlower";
            this.NumberOfFlower.ReadOnly = true;
            // 
            // UnitPrice
            // 
            this.UnitPrice.DataPropertyName = "UnitPrice";
            this.UnitPrice.HeaderText = "قیمت واحد";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            // 
            // frmMojodi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 344);
            this.Controls.Add(this.Btn_SaveEdit);
            this.Controls.Add(this.Txt_Date);
            this.Controls.Add(this.Lbl_Date);
            this.Controls.Add(this.Txt_UnitPrice);
            this.Controls.Add(this.Lbl_UnitPrice);
            this.Controls.Add(this.Grd_Mojodi);
            this.Controls.Add(this.Txt_Search);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.Txt_FlowerID);
            this.Controls.Add(this.Cmb_FlowerDes);
            this.Controls.Add(this.Txt_FlowerUnit);
            this.Controls.Add(Lbl_Number);
            this.Controls.Add(this.Btn_Search);
            this.Controls.Add(this.Btn_Edit);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.Btn_Refresh);
            this.Controls.Add(Lbl_FlowerDes);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMojodi";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "فرم موجودی";
            this.Load += new System.EventHandler(this.frmMojodi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Mojodi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Search;
        private System.Windows.Forms.Button Btn_Edit;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Button Btn_Refresh;
        private System.Windows.Forms.TextBox Txt_FlowerUnit;
        private System.Windows.Forms.ComboBox Cmb_FlowerDes;
        private System.Windows.Forms.TextBox Txt_FlowerID;
        private System.Windows.Forms.TextBox Txt_Search;
        private System.Windows.Forms.DataGridView Grd_Mojodi;
        private System.Windows.Forms.Label Lbl_UnitPrice;
        private System.Windows.Forms.TextBox Txt_UnitPrice;
        private System.Windows.Forms.Label Lbl_Date;
        private System.Windows.Forms.TextBox Txt_Date;
        private System.Windows.Forms.Button Btn_SaveEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowMojodi;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlowerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlowerDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnterDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfFlower;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
    }
}