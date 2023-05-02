using Stimulsoft;
namespace FlowerShop
{
    partial class frmFactorPrint
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFactorPrint));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.xtblDropFactorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataset = new FlowerShop.dataset();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_AddToList = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.factorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factorShDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameSnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowerDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowerQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.takhfifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xtblFactorRptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.xtblDropFactorsTableAdapter = new FlowerShop.datasetTableAdapters.xtblDropFactorsTableAdapter();
            this.xtblFactorRptTableAdapter = new FlowerShop.datasetTableAdapters.xtblFactorRptTableAdapter();
            this.stiReport1 = new Stimulsoft.Report.StiReport();
            this.stiReportDataSource2 = new Stimulsoft.Report.Design.StiReportDataSource("xtblFactorRptBindingSource", this.xtblFactorRptBindingSource);
            this.stiReportDataSource1 = new Stimulsoft.Report.Design.StiReportDataSource("xtblFactorRptBindingSource", this.xtblFactorRptBindingSource);
            ((System.ComponentModel.ISupportInitialize)(this.xtblDropFactorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtblFactorRptBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.DataSource = this.xtblDropFactorsBindingSource;
            this.comboBox1.DisplayMember = "NameSnameCust";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(54, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(562, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "FactorID";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // xtblDropFactorsBindingSource
            // 
            this.xtblDropFactorsBindingSource.DataMember = "xtblDropFactors";
            this.xtblDropFactorsBindingSource.DataSource = this.dataset;
            // 
            // dataset
            // 
            this.dataset.DataSetName = "dataset";
            this.dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(639, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "شماره فاکتور:";
            // 
            // Btn_AddToList
            // 
            this.Btn_AddToList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_AddToList.Location = new System.Drawing.Point(503, 39);
            this.Btn_AddToList.Name = "Btn_AddToList";
            this.Btn_AddToList.Size = new System.Drawing.Size(113, 28);
            this.Btn_AddToList.TabIndex = 18;
            this.Btn_AddToList.Text = "چاپ فاکتور";
            this.Btn_AddToList.UseVisualStyleBackColor = true;
            this.Btn_AddToList.Click += new System.EventHandler(this.Btn_AddToList_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.factorIDDataGridViewTextBoxColumn,
            this.factorShDateDataGridViewTextBoxColumn,
            this.customerIDDataGridViewTextBoxColumn,
            this.nameSnameDataGridViewTextBoxColumn,
            this.flowerIDDataGridViewTextBoxColumn,
            this.flowerDescriptionDataGridViewTextBoxColumn,
            this.flowerQuantityDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn,
            this.takhfifDataGridViewTextBoxColumn,
            this.taxRateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.xtblFactorRptBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(767, 362);
            this.dataGridView1.TabIndex = 19;
            // 
            // factorIDDataGridViewTextBoxColumn
            // 
            this.factorIDDataGridViewTextBoxColumn.DataPropertyName = "FactorID";
            this.factorIDDataGridViewTextBoxColumn.HeaderText = "FactorID";
            this.factorIDDataGridViewTextBoxColumn.Name = "factorIDDataGridViewTextBoxColumn";
            this.factorIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.factorIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // factorShDateDataGridViewTextBoxColumn
            // 
            this.factorShDateDataGridViewTextBoxColumn.DataPropertyName = "FactorShDate";
            this.factorShDateDataGridViewTextBoxColumn.HeaderText = "تاریخ";
            this.factorShDateDataGridViewTextBoxColumn.Name = "factorShDateDataGridViewTextBoxColumn";
            this.factorShDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameSnameDataGridViewTextBoxColumn
            // 
            this.nameSnameDataGridViewTextBoxColumn.DataPropertyName = "NameSname";
            this.nameSnameDataGridViewTextBoxColumn.HeaderText = "مشتری";
            this.nameSnameDataGridViewTextBoxColumn.Name = "nameSnameDataGridViewTextBoxColumn";
            this.nameSnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // flowerIDDataGridViewTextBoxColumn
            // 
            this.flowerIDDataGridViewTextBoxColumn.DataPropertyName = "FlowerID";
            this.flowerIDDataGridViewTextBoxColumn.HeaderText = "FlowerID";
            this.flowerIDDataGridViewTextBoxColumn.Name = "flowerIDDataGridViewTextBoxColumn";
            this.flowerIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.flowerIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // flowerDescriptionDataGridViewTextBoxColumn
            // 
            this.flowerDescriptionDataGridViewTextBoxColumn.DataPropertyName = "FlowerDescription";
            this.flowerDescriptionDataGridViewTextBoxColumn.HeaderText = "نام گل";
            this.flowerDescriptionDataGridViewTextBoxColumn.Name = "flowerDescriptionDataGridViewTextBoxColumn";
            this.flowerDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // flowerQuantityDataGridViewTextBoxColumn
            // 
            this.flowerQuantityDataGridViewTextBoxColumn.DataPropertyName = "FlowerQuantity";
            this.flowerQuantityDataGridViewTextBoxColumn.HeaderText = "تعداد";
            this.flowerQuantityDataGridViewTextBoxColumn.Name = "flowerQuantityDataGridViewTextBoxColumn";
            this.flowerQuantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.HeaderText = "قیمت واحد";
            this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            this.unitPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // takhfifDataGridViewTextBoxColumn
            // 
            this.takhfifDataGridViewTextBoxColumn.DataPropertyName = "Takhfif";
            this.takhfifDataGridViewTextBoxColumn.HeaderText = "تخفیف";
            this.takhfifDataGridViewTextBoxColumn.Name = "takhfifDataGridViewTextBoxColumn";
            this.takhfifDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // taxRateDataGridViewTextBoxColumn
            // 
            this.taxRateDataGridViewTextBoxColumn.DataPropertyName = "TaxRate";
            this.taxRateDataGridViewTextBoxColumn.HeaderText = "کل";
            this.taxRateDataGridViewTextBoxColumn.Name = "taxRateDataGridViewTextBoxColumn";
            this.taxRateDataGridViewTextBoxColumn.ReadOnly = true;
            this.taxRateDataGridViewTextBoxColumn.Visible = false;
            // 
            // xtblFactorRptBindingSource
            // 
            this.xtblFactorRptBindingSource.DataMember = "xtblFactorRpt";
            this.xtblFactorRptBindingSource.DataSource = this.dataset;
            // 
            // xtblDropFactorsTableAdapter
            // 
            this.xtblDropFactorsTableAdapter.ClearBeforeFill = true;
            // 
            // xtblFactorRptTableAdapter
            // 
            this.xtblFactorRptTableAdapter.ClearBeforeFill = true;
            // 
            // stiReport1
            // 
            this.stiReport1.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.stiReport1.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.stiReport1.ReportAlias = "گزارش";
            this.stiReport1.ReportDataSources.Add(this.stiReportDataSource2);
            this.stiReport1.ReportGuid = "f55ef012248344c9834ce1f3f82cf094";
            this.stiReport1.ReportName = "گزارش";
            this.stiReport1.ReportSource = resources.GetString("stiReport1.ReportSource");
            this.stiReport1.ReportUnit = Stimulsoft.Report.StiReportUnitType.Centimeters;
            this.stiReport1.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            // 
            // stiReportDataSource2
            // 
            this.stiReportDataSource2.Item = this.xtblFactorRptBindingSource;
            this.stiReportDataSource2.Name = "xtblFactorRptBindingSource";
            // 
            // stiReportDataSource1
            // 
            this.stiReportDataSource1.Item = this.xtblFactorRptBindingSource;
            this.stiReportDataSource1.Name = "xtblFactorRptBindingSource";
            // 
            // frmFactorPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 431);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Btn_AddToList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "frmFactorPrint";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "چاپ فاکتور";
            this.Load += new System.EventHandler(this.frmFactorPrint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtblDropFactorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtblFactorRptBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_AddToList;
        private System.Windows.Forms.DataGridView dataGridView1;
        private dataset dataset;
        private System.Windows.Forms.BindingSource xtblDropFactorsBindingSource;
        private datasetTableAdapters.xtblDropFactorsTableAdapter xtblDropFactorsTableAdapter;
        private System.Windows.Forms.BindingSource xtblFactorRptBindingSource;
        private datasetTableAdapters.xtblFactorRptTableAdapter xtblFactorRptTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn factorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn factorShDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameSnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flowerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flowerDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flowerQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn takhfifDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxRateDataGridViewTextBoxColumn;
        private Stimulsoft.Report.StiReport stiReport1;
        private Stimulsoft.Report.Design.StiReportDataSource stiReportDataSource1;
        private Stimulsoft.Report.Design.StiReportDataSource stiReportDataSource2;
        
    }
}