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
    public partial class frmSaleInvoiceDetail : Form
    {
        DataTable tblGridView;
        public frmSaleInvoiceDetail()
        {
            InitializeComponent();
        }

        private void frmSaleInvoiceDetail_Load(object sender, EventArgs e)
        {
            txtInvoiceID.Enabled = false;
            txtDate.Enabled = false;
            cboStaff.Enabled = false;
            txtStaff.Enabled = false;
            cboCustomer.Enabled = false;
            txtCustomer.Enabled = false;
            txtAddress.Enabled = false;
            txtPhone.Enabled = false;
            cboItem.Enabled = false;
            txtItem.Enabled = false;
            nbrQuantity.Enabled = false;
            nbrDiscount.Enabled = false;
            nbrUnitPrice.Enabled = false;
            txtTotalPrice.Enabled = false;
            txtPrice.Enabled = false;
            txtDate.Text = Functions.getFieldValues("select SaleDate from tblSaleInvoice where InvoiceID='" + txtInvoiceID.Text.Trim() + "'");
            cboStaff.Text = Functions.getFieldValues("select StaffID from tblSaleInvoice where InvoiceID='" + txtInvoiceID.Text.Trim() + "'");
            txtStaff.Text = Functions.getFieldValues("select StaffName from tblStaff where StaffID='" + cboStaff.Text.Trim() + "'");
            cboCustomer.Text = Functions.getFieldValues("select CustomerID from tblSaleInvoice where InvoiceID='" + txtInvoiceID.Text.Trim() + "'");
            txtCustomer.Text = Functions.getFieldValues("select CustomerName from tblCustomer where CustomerID='" + cboCustomer.Text.Trim() + "'");
            txtAddress.Text = Functions.getFieldValues("select CustomerAdd from tblCustomer where CustomerID='" + cboCustomer.Text.Trim() + "'");
            txtPhone.Text = Functions.getFieldValues("select CustomerTel from tblCustomer where CustomerID='" + cboCustomer.Text.Trim() + "'");
            txtTotalPrice.Text = Functions.getFieldValues("select TotalPrice from tblSaleInvoice where InvoiceID='" + txtInvoiceID.Text.Trim() + "'");
            loadDataGridView();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void loadDataGridView()
        {
            tblGridView = Functions.getDataToTable("Select ItemID,Quantity,Discount,TotalPrice from tblSaleInvoiceDetail where InvoiceID='" + txtInvoiceID.Text.Trim() + "'");
            dgvItem.DataSource = tblGridView;
            dgvItem.DataSource = tblGridView;
            dgvItem.Columns[0].HeaderText = "Item ID";
            dgvItem.Columns[1].HeaderText = "Quantity";
            
            dgvItem.Columns[2].HeaderText = "Discount";
            dgvItem.Columns[3].HeaderText = "Total Price";
            dgvItem.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvItem.AllowUserToAddRows = false;


            /*dgvItem.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvItem.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvItem.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvItem.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvItem.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;*/
        }
    }
}
