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
    public partial class frmStatSup : Form
    {
        DataTable tblGridView;
        public frmStatSup()
        {
            InitializeComponent();
        }

        private void frmStatSup_Load(object sender, EventArgs e)
        {
            cboMonth.Items.Add("1");
            cboMonth.Items.Add("2");
            cboMonth.Items.Add("3");
            cboMonth.Items.Add("4");
            cboMonth.Items.Add("5");
            cboMonth.Items.Add("6");
            cboMonth.Items.Add("7");
            cboMonth.Items.Add("8");
            cboMonth.Items.Add("9");
            cboMonth.Items.Add("10");
            cboMonth.Items.Add("11");
            cboMonth.Items.Add("12");
            Functions.fillComboBox("select distinct year(ImportDate) as Year from tblImInvoice", cboYear, "Year", "Year");
            cboYear.SelectedIndex = -1;
        }
        private void loadDataGridView()
        {
            string selectSQL;
            selectSQL = "select SupplierID,SupplierName from tblSupplier where SupplierID not in (select SupplierID from tblImInvoice where month(ImportDate)=" + Convert.ToInt32(cboMonth.SelectedItem) + " and year(ImportDate)=" + Convert.ToInt32(cboYear.SelectedValue) + ")";
            tblGridView = Functions.getDataToTable(selectSQL);
            dgvSup.DataSource = tblGridView;
            dgvSup.Columns[0].HeaderText = "Supplier ID";
            dgvSup.Columns[1].HeaderText = "Supplier Name";
           
            dgvSup.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvSup.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
           
            dgvSup.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvSup.AllowUserToAddRows = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cboMonth.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a month", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                cboMonth.Focus();
                return;
            }
            if (cboYear.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a year", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                cboYear.Focus();
                return;
            }
            loadDataGridView();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
