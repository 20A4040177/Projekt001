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
    public partial class frmStatInvoice : Form
    {
        DataTable tblGridView;
        public frmStatInvoice()
        {
            InitializeComponent();
        }

        private void frmStatInvoice_Load(object sender, EventArgs e)
        {
            Functions.fillComboBox("select SupplierID from tblSupplier", cboSupplier, "SupplierID", "SupplierID");
            cboSupplier.SelectedIndex = -1;
            txtSupplier.Enabled = false;
            txtTotalPrice.Enabled = false;
        }

        private void cboSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSupplier.SelectedIndex != -1)
            {
                txtSupplier.Text = Functions.getFieldValues("select SupplierName from tblSupplier where SupplierID='" + cboSupplier.SelectedValue.ToString() + "'");
            }
        }
        private void loadDataGridView()
        {
            string selectSQL;
            selectSQL = "select InvoiceID,TotalPrice from tblImInvoice where SupplierID='" + cboSupplier.SelectedValue.ToString() + "'";
            tblGridView = Functions.getDataToTable(selectSQL);
            dgvInvoice.DataSource = tblGridView;
            dgvInvoice.Columns[0].HeaderText = "Invoice ID";
            dgvInvoice.Columns[1].HeaderText = "Total Price";

            dgvInvoice.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvInvoice.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvInvoice.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvInvoice.AllowUserToAddRows = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cboSupplier.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Supplier", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                cboSupplier.Focus();
                return;
            }
            loadDataGridView();
            txtTotalPrice.Text = Functions.getFieldValues("select  sum(TotalPrice) from tblImInvoice where SupplierID='" + cboSupplier.SelectedValue.ToString() + "'");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
