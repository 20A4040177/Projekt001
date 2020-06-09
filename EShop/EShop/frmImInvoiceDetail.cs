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
    public partial class frmImInvoiceDetail : Form
    {
        DataTable tblGridView;
        public frmImInvoiceDetail()
        {
            InitializeComponent();
        }

        private void frmImInvoiceDetail_Load(object sender, EventArgs e)
        {
            txtInvoiceID.Enabled = false;
            txtDate.Enabled = false;
            cboStaff.Enabled = false;
            txtStaff.Enabled = false;
            cboSupplier.Enabled = false;
            txtSupplier.Enabled = false;
            txtAddress.Enabled = false;
            txtPhone.Enabled = false;
            cboItem.Enabled = false;
            txtItem.Enabled = false;
            nbrQuantity.Enabled = false;
            nbrDiscount.Enabled = false;
            nbrUnitPrice.Enabled = false;
            txtTotalPrice.Enabled = false;
            txtPrice.Enabled = false;
            txtDate.Text = Functions.getFieldValues("select ImportDate from tblImInvoice where InvoiceID='" + txtInvoiceID.Text.Trim() + "'");
            cboStaff.Text = Functions.getFieldValues("select StaffID from tblImInvoice where InvoiceID='" + txtInvoiceID.Text.Trim() + "'");
            txtStaff.Text = Functions.getFieldValues("select StaffName from tblStaff where StaffID='" + cboStaff.Text.Trim() + "'");
            cboSupplier.Text = Functions.getFieldValues("select SupplierID from tblImInvoice where InvoiceID='" + txtInvoiceID.Text.Trim() + "'");
            txtSupplier.Text = Functions.getFieldValues("select SupplierName from tblSupplier where SupplierID='" + cboSupplier.Text.Trim() + "'");
            txtAddress.Text = Functions.getFieldValues("select SupplierAdd from tblSupplier where SupplierID='" + cboSupplier.Text.Trim() + "'");
            txtPhone.Text = Functions.getFieldValues("select SupplierTel from tblSupplier where SupplierID='" + cboSupplier.Text.Trim() + "'");
            txtTotalPrice.Text = Functions.getFieldValues("select TotalPrice from tblImInvoice where InvoiceID='" + txtInvoiceID.Text.Trim() + "'");
            loadDataGridView();


        }
        private void loadDataGridView()
        {
            tblGridView = Functions.getDataToTable("Select ItemID,Quantity,UnitPrice,Discount,TotalPrice from tblImInvoiceDetail where InvoiceID='" + txtInvoiceID.Text.Trim() + "'");
            dgvItem.DataSource = tblGridView;
            dgvItem.DataSource = tblGridView;
            dgvItem.Columns[0].HeaderText = "Item ID";
            dgvItem.Columns[1].HeaderText = "Quantity";
            dgvItem.Columns[2].HeaderText = "Unit Price";
            dgvItem.Columns[3].HeaderText = "Discount";
            dgvItem.Columns[4].HeaderText = "Total Price";
            dgvItem.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvItem.AllowUserToAddRows = false;


            /*dgvItem.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvItem.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvItem.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvItem.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvItem.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;*/
        }

        private void txtInvoiceID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboStaff_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtStaff_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSupplier_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboItem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtItem_TextChanged(object sender, EventArgs e)
        {

        }

        private void nbrQuantity_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nbrUnitPrice_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nbrDiscount_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtTotalPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
