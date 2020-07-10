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
    public partial class frmImInvoice : Form
    {
        DataTable tblGridView;
        string invoiceID;
        
        public frmImInvoice()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void btnViewDetail_Click(object sender, EventArgs e)
        {
            frmImInvoiceDetail ImportDetail1 = new frmImInvoiceDetail();
            ImportDetail1.txtInvoiceID.Text = dgvImInvoice.CurrentRow.Cells["InvoiceID"].Value.ToString();
            ImportDetail1.ShowDialog();
            
        }

        private void frmImInvoice_Load(object sender, EventArgs e)
        {
            loadDataGridView(" select * from tblImInvoice");
            cboSearch.Items.Add("Search by");
            cboSearch.Items.Add("Item ID");
            cboSearch.Items.Add("Supplier");
            cboSearch.Items.Add("Date");
            cboSearch.SelectedItem = "Search by";
            dtpSearch.Visible = false;
            txtSearch.MaxLength = 50;
            
            
        }
        private void loadDataGridView(string selectSQL)
        {
            
            //selectSQL = " select * from tblImInvoice";
            tblGridView = Functions.getDataToTable(selectSQL);

            dgvImInvoice.DataSource = tblGridView;
            dgvImInvoice.Columns[0].HeaderText = "Invoice ID";
            dgvImInvoice.Columns[1].HeaderText = "Staff ID ";
            dgvImInvoice.Columns[2].HeaderText = "Date";
            dgvImInvoice.Columns[3].HeaderText = "Supplier ID";
            dgvImInvoice.Columns[4].HeaderText = "Total Price";


            dgvImInvoice.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvImInvoice.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvImInvoice.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvImInvoice.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvImInvoice.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvImInvoice.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvImInvoice.AllowUserToAddRows = false;



        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddImInvoice newImInvoice = new frmAddImInvoice();
            
            newImInvoice.ShowDialog();
        }

        private void dgvImInvoice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cboSearch.SelectedIndex == -1 || cboSearch.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a search field", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtSearch.Text == ""&&cboSearch.SelectedItem.ToString()!="Date")
            {
                MessageBox.Show("Please enter a search value", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSearch.Focus();
                return;
            }
            if (txtSearch.Text.Length<4&&cboSearch.SelectedItem.ToString()=="Supplier")
            {
                MessageBox.Show("Keyword too short, please enter at least 4 characters", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSearch.Focus();
                return;
            }
            if (cboSearch.SelectedItem.ToString() == "Item ID")
            {
                if (Functions.checkID("select * from tblImInvoice inner join tblImInvoiceDetail on tblImInvoice.InvoiceID=tblImInvoiceDetail.InvoiceID where tblImInvoiceDetail.ItemID='" + txtSearch.Text.Trim() + "'") == true)
                {
                    loadDataGridView("select tblImInvoice.InvoiceID,StaffID,ImportDate,SupplierID,tblImInvoice.TotalPrice from tblImInvoice inner join tblImInvoiceDetail on tblImInvoice.InvoiceID=tblImInvoiceDetail.InvoiceID where tblImInvoiceDetail.ItemID='" + txtSearch.Text.Trim() + "'");
                }
                else
                {
                    MessageBox.Show("No record found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

            }
            if (cboSearch.SelectedItem.ToString() == "Supplier")
            {
                if (Functions.checkID("select * from tblImInvoice inner join tblSupplier on tblImInvoice.SupplierID=tblSupplier.SupplierID where SupplierName like'%" + txtSearch.Text.Trim() + "%'") == true)
                {
                    loadDataGridView("select tblImInvoice.InvoiceID,StaffID,ImportDate,tblImInvoice.SupplierID,tblImInvoice.TotalPrice from tblImInvoice inner join tblSupplier on tblImInvoice.SupplierID=tblSupplier.SupplierID where SupplierName like'%" + txtSearch.Text.Trim() + "%'");
                }
                else
                {
                    MessageBox.Show("No record found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

            }
            if (cboSearch.SelectedItem.ToString() == "Date")
            {
                if (Functions.checkID("select * from tblImInvoice where ImportDate ='" + dtpSearch.Value.ToString("yyyy/MM/dd") + "'") == true)
                {
                    loadDataGridView("select * from tblImInvoice where ImportDate ='" + dtpSearch.Value.ToString("yyyy/MM/dd") + "'");
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpSearch_ValueChanged(object sender, EventArgs e)
        {
            txtSearch.Text = dtpSearch.Value.ToString("yyyy/MM/dd");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadDataGridView(" select * from tblImInvoice");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string deleteSQL1;
            string deleteSQL2;
            deleteSQL1 = "delete from tblImInvoiceDetail where InvoiceID='" + invoiceID + "'";
            deleteSQL2 = "delete from tblImInvoice where InvoiceID='" + invoiceID + "'";
            if (invoiceID == "")
            {
                MessageBox.Show("Please choose a record", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                DialogResult dlgResult;
                dlgResult = MessageBox.Show("Delete this record?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlgResult == DialogResult.Yes)
                {
                    Functions.deleteSQL(deleteSQL1);
                    Functions.deleteSQL(deleteSQL2);
                    loadDataGridView(" select * from tblImInvoice");
                }
            }
        }

        private void cellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            invoiceID = dgvImInvoice.CurrentRow.Cells["InvoiceID"].Value.ToString();
        }
    }
}
