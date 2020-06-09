using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EShop
{
    public partial class frmStatRevenue : Form
    {
        public frmStatRevenue()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cboQuarter.SelectedIndex == -1 || cboQuarter.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a quarter", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                cboQuarter.Focus();
                return;
            }
            if (cboYear.SelectedIndex == -1 )
            {
                MessageBox.Show("Please select a year", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                cboQuarter.Focus();
                return;
            }
            string selectSQL;
            if (cboQuarter.SelectedItem.ToString() == "Q1")
            {
                selectSQL = "select sum(TotalPrice) as Total from tblSaleInvoice where YEAR(SaleDate)=" + Convert.ToInt32(cboYear.SelectedValue) + "and MONTH(SaleDate) between 1 and 3 having Sum(TotalPrice) is not null";
                if (Functions.checkID(selectSQL) == true)
                {
                    txtTotalIncome.Text = Functions.getFieldValues(selectSQL);
                }
                else txtTotalIncome.Text = "0";
            }
            if (cboQuarter.SelectedItem.ToString() == "Q2")
            {
                selectSQL = "select sum(TotalPrice) as Total from tblSaleInvoice where YEAR(SaleDate)=" + Convert.ToInt32(cboYear.SelectedValue) + "and MONTH(SaleDate) between 4 and 6 having Sum(TotalPrice) is not null";
                if (Functions.checkID(selectSQL) == true)
                {
                    txtTotalIncome.Text = Functions.getFieldValues(selectSQL);
                }
                else txtTotalIncome.Text = "0";
            }
            if (cboQuarter.SelectedItem.ToString() == "Q3")
            {
                selectSQL = "select sum(TotalPrice) as Total from tblSaleInvoice where YEAR(SaleDate)=" + Convert.ToInt32(cboYear.SelectedValue) + "and MONTH(SaleDate) between 7 and 9 having Sum(TotalPrice) is not null";
                if (Functions.checkID(selectSQL) == true)
                {
                    txtTotalIncome.Text = Functions.getFieldValues(selectSQL);
                }
                else txtTotalIncome.Text = "0";
            }
            if (cboQuarter.SelectedItem.ToString() == "Q4")
            {
                selectSQL = "select sum(TotalPrice) as Total from tblSaleInvoice where YEAR(SaleDate)=" + Convert.ToInt32(cboYear.SelectedValue) + "and MONTH(SaleDate) between 10 and 12 having Sum(TotalPrice) is not null";
                if (Functions.checkID(selectSQL) == true)
                {
                    txtTotalIncome.Text = Functions.getFieldValues(selectSQL);
                }
                else txtTotalIncome.Text = "0";
            }
            if (cboQuarter.SelectedItem.ToString() == "All")
            {
                selectSQL = "select sum(TotalPrice) as Total from tblSaleInvoice where YEAR(SaleDate)=" + Convert.ToInt32(cboYear.SelectedValue) + "and MONTH(SaleDate) between 1 and 12 having Sum(TotalPrice) is not null";
                if (Functions.checkID(selectSQL) == true)
                {
                    txtTotalIncome.Text = Functions.getFieldValues(selectSQL);
                }
                else txtTotalIncome.Text = "0";
            }
        }

        private void frmStatRevenue_Load(object sender, EventArgs e)
        {
            cboQuarter.Items.Add("--Quarter--");
            cboQuarter.Items.Add("Q1");
            cboQuarter.Items.Add("Q2");
            cboQuarter.Items.Add("Q3");
            cboQuarter.Items.Add("Q4");
            cboQuarter.Items.Add("All");
            cboQuarter.SelectedItem = "--Quarter--";
            Functions.fillComboBox("select distinct year(SaleDate) as Year from tblSaleInvoice", cboYear, "Year", "Year");
            cboYear.SelectedIndex = -1;
            txtTotalIncome.Enabled = false;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
