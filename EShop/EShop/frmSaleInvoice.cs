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
            loadDataGridView();
        }
        private void loadDataGridView()
        {
            string selectSQL;
            selectSQL = " select * from tblSaleInvoice";
            tblGridView = Functions.getDataToTable(selectSQL);
            dgvSaleInvoice.DataSource = tblGridView;
            dgvSaleInvoice.Columns[0].HeaderText = "Invoice ID";
            dgvSaleInvoice.Columns[1].HeaderText = "Staff ID ";
            dgvSaleInvoice.Columns[2].HeaderText = "Date ";
            dgvSaleInvoice.Columns[3].HeaderText = "Customer ID ";
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
            loadDataGridView();
        }
    }
}
