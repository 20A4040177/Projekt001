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
    public partial class frmSaleInvoice : Form
    {
        DataTable tblGridView;
        string invoiceID;
        public frmSaleInvoice()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnViewDetail_Click(object sender, EventArgs e)
        {
            frmSaleInvoiceDetail SaleDetail1 = new frmSaleInvoiceDetail();
            SaleDetail1.txtInvoiceID.Text = dgvSaleInvoice.CurrentRow.Cells["InvoiceID"].Value.ToString();
            SaleDetail1.ShowDialog();
        }

        private void frmSaleInvoice_Load(object sender, EventArgs e)
        {
            loadDataGridView(" select * from tblSaleInvoice");
            cboSearch.Items.Add("Search by");
            cboSearch.Items.Add("Invoice ID");
            cboSearch.Items.Add("Customer");
            cboSearch.Items.Add("Date");
            cboSearch.SelectedItem = "Search by";
            dtpSearch.Visible = false;
            txtSearch.MaxLength = 50;
        }
        private void loadDataGridView(string selectSQL)
        {
            
            
            tblGridView = Functions.getDataToTable(selectSQL);
            dgvSaleInvoice.DataSource = tblGridView;
            dgvSaleInvoice.Columns[0].HeaderText = "Invoice ID";
            dgvSaleInvoice.Columns[1].HeaderText = "Staff ID ";
            dgvSaleInvoice.Columns[2].HeaderText = "Date ";
            dgvSaleInvoice.Columns[3].HeaderText = "Customer ID";
            dgvSaleInvoice.Columns[4].HeaderText = "Total Price";

            dgvSaleInvoice.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvSaleInvoice.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvSaleInvoice.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvSaleInvoice.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvSaleInvoice.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvSaleInvoice.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvSaleInvoice.AllowUserToAddRows = false;



        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddSaleInvoice newInvoice = new frmAddSaleInvoice();
            newInvoice.ShowDialog();
        }

        private void dgvSaleInvoice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadDataGridView( " select * from tblSaleInvoice");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cboSearch.SelectedIndex == -1 || cboSearch.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a search field", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtSearch.Text == "" && cboSearch.SelectedItem.ToString() != "Date")
            {
                MessageBox.Show("Please enter a search value", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSearch.Focus();
                return;
            }
            if (txtSearch.Text.Length < 4 && cboSearch.SelectedItem.ToString() == "Invoice ID")
            {
                MessageBox.Show("Keyword too short, please enter at least 4 characters", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSearch.Focus();
                return;
            }
            if (cboSearch.SelectedItem.ToString() == "Invoice ID")
            {
                if (Functions.checkID("select * from tblSaleInvoice  where InvoiceID='" + txtSearch.Text.Trim() + "'") == true)
                {
                    loadDataGridView("select * from tblSaleInvoice  where InvoiceID='" + txtSearch.Text.Trim() + "'");
                }
                else
                {
                    MessageBox.Show("No record found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

            }
            if (cboSearch.SelectedItem.ToString() == "Customer")
            {
                if (Functions.checkID("select * from tblSaleInvoice inner join tblCustomer on tblSaleInvoice.CustomerID=tblCustomer.CustomerID where CustomerName like'%" + txtSearch.Text.Trim() + "%'") == true)
                {
                    loadDataGridView("select tblSaleInvoice.InvoiceID,StaffID,SaleDate,tblSaleInvoice.CustomerID,tblSaleInvoice.TotalPrice from tblSaleInvoice inner join tblCustomer on tblSaleInvoice.CustomerID=tblCustomer.CustomerID where CustomerName like'%" + txtSearch.Text.Trim() + "%'");
                }
                else
                {
                    MessageBox.Show("No record found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

            }
            if (cboSearch.SelectedItem.ToString() == "Date")
            {
                if (Functions.checkID("select * from tblSaleInvoice where SaleDate ='" + dtpSearch.Value.ToString("yyyy/MM/dd") + "'") == true)
                {
                    loadDataGridView("select * from tblSaleInvoice where SaleDate ='" + dtpSearch.Value.ToString("yyyy/MM/dd") + "'");
                }
                else
                {
                    MessageBox.Show("No record found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

            }
        }

        private void cboSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            if (cboSearch.SelectedItem.ToString() == "Date")
            {
                dtpSearch.Visible = true;
                txtSearch.Enabled = false;
            }
            else
            {
                dtpSearch.Visible = false;
                txtSearch.Enabled = true;
            }
        }

        private void dtpSearch_ValueChanged(object sender, EventArgs e)
        {
            txtSearch.Text = dtpSearch.Value.ToString("yyyy/MM/dd");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string deleteSQL1;
            string deleteSQL2;
            deleteSQL1 = "delete from tblSaleInvoiceDetail where InvoiceID='" + invoiceID + "'";
            deleteSQL2 = "delete from tblSaleInvoice where InvoiceID='" + invoiceID + "'";
            if (invoiceID == "")
            {
                MessageBox.Show("Please choose a record", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dlgResult;
            dlgResult = MessageBox.Show("Delete this record?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlgResult == DialogResult.Yes)
            {
                Functions.deleteSQL(deleteSQL1);
                Functions.deleteSQL(deleteSQL2);
                loadDataGridView(" select * from tblSaleInvoice");
            }
        }

        private void cellClick(object sender, DataGridViewCellEventArgs e)
        {
            invoiceID = dgvSaleInvoice.CurrentRow.Cells["InvoiceID"].Value.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }
    }
}
