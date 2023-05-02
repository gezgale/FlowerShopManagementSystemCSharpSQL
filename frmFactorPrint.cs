using System;
using Stimulsoft.Report;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FlowerShop
{
    public partial class frmFactorPrint : Form
    {
        public frmFactorPrint()
        {
            InitializeComponent();
        }

        private void frmFactorPrint_Load(object sender, EventArgs e)
        {
            UDF_GetData();
        }

        private void UDF_GetData()
        {
            this.xtblDropFactorsTableAdapter.Fill(this.dataset.xtblDropFactors);
            this.xtblFactorRptTableAdapter.FillByFactorID(this.dataset.xtblFactorRpt, int.Parse(comboBox1.SelectedValue.ToString()));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.xtblFactorRptTableAdapter.FillByFactorID(this.dataset.xtblFactorRpt, int.Parse(comboBox1.SelectedValue.ToString()));
        }

        private void Btn_AddToList_Click(object sender, EventArgs e)
        {
            StiReport Report = new StiReport();
            Report = (StiReport)stiReport1.Clone();
            Report.RegData(this.dataset.xtblFactorRpt);
            Report.Compile();
            Report.Show();
        }
    }
}
