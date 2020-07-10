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
            btnAddItem.Enabled = false;
            btnRemove.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            nbrUnitPrice.Maximum=9999999999999999999;
            nbrQuantity.Minimum = 1;
            nbrQuantity.Maximum = 9999;
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
            decimal price;

            price = nbrUnitPrice.Value * nbrQuantity.Value * (100 - nbrDiscount.Value) / 100;
            txtPrice.Text = price.ToString();
        }

        private void nbrUnitPrice_ValueChanged(object sender, EventArgs e)
        {
            decimal price;

            price = nbrUnitPrice.Value * nbrQuantity.Value * (100 - nbrDiscount.Value) / 100;
            txtPrice.Text = price.ToString();
        }

        private void nbrDiscount_ValueChanged(object sender, EventArgs e)
        {
            decimal price;

            price = nbrUnitPrice.Value * nbrQuantity.Value * (100 - nbrDiscount.Value) / 100;
            txtPrice.Text = price.ToString();
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

        private void cellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnEdit.Enabled == true)
            {
                MessageBox.Show("Not in edit mode", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int currentQuan;
            currentQuan = Functions.getFieldValuesInt("select Quantity from tblItemList where ItemID='" + cboItem.Text.Trim() + "'");
            nbrQuantity.Maximum = currentQuan + Convert.ToDecimal(dgvItem.CurrentRow.Cells["Quantity"].Value);
            cboItem.Text = dgvItem.CurrentRow.Cells["ItemID"].Value.ToString();
            txtItem.Text = Functions.getFieldValues("select ItemName from tblItemList where ItemID='" + cboItem.Text.Trim() + "'");
            nbrQuantity.Value = Convert.ToDecimal(dgvItem.CurrentRow.Cells["Quantity"].Value);
            nbrUnitPrice.Value = Functions.getFieldValuesInt("select SaleUnitPrice from tblItemList where ItemID='" + cboItem.Text.Trim() + "'");
            nbrDiscount.Value = Convert.ToDecimal(dgvItem.CurrentRow.Cells["Discount"].Value);
            txtPrice.Text = dgvItem.CurrentRow.Cells["TotalPrice"].Value.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This function is for modifying Invoice info only, for warranty and item related problems, please use Returned Items tab instead", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            btnAddItem.Enabled = true;
            btnRemove.Enabled = true;
            btnEdit.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            nbrQuantity.Enabled = true;
            nbrDiscount.Enabled = true;
            nbrUnitPrice.Enabled = true;
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            string updateSQL;
            updateSQL = "update tblImInvoiceDetail set Quantity=" + nbrQuantity.Value + ",Discount=" + nbrDiscount.Value + ",TotalPrice=" + Convert.ToDouble(txtPrice.Text) + ",UnitPrice="+nbrUnitPrice.Value+" where ItemID='" + cboItem.Text.Trim() + "' and InvoiceID='" + txtInvoiceID.Text.Trim() + "'";
            DialogResult dialogResult = MessageBox.Show("Confirm the change?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Functions.modifySQL(updateSQL);
                loadDataGridView();
                txtTotalPrice.Text = Functions.getFieldValues("select sum(TotalPrice) from tblImInvoiceDetail where InvoiceID='" + txtInvoiceID.Text.Trim() + "'");
            }
            else return;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string deleteSQL;
            deleteSQL = "delete from tblImInvoiceDetail where ItemID='" + cboItem.Text.Trim() + "' and InvoiceID='" + txtInvoiceID.Text.Trim() + "'";
            DialogResult dialogResult = MessageBox.Show("Delete the selected Item?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Functions.deleteSQL(deleteSQL);
                loadDataGridView();
                txtTotalPrice.Text = Functions.getFieldValues("select sum(TotalPrice) from tblImInvoiceDetail where InvoiceID='" + txtInvoiceID.Text.Trim() + "'");
            }
            else return;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string updateSQL;
            updateSQL = "update tblImInvoice set TotalPrice=" + Convert.ToDouble(txtTotalPrice.Text.Trim()) + "where InvoiceID='" + txtInvoiceID.Text.Trim() + "'";
            DialogResult dialogResult = MessageBox.Show("Save the changes?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Functions.modifySQL(updateSQL);
                btnEdit.Enabled = true;
                nbrDiscount.Enabled = false;
                nbrQuantity.Enabled = false;
                btnAddItem.Enabled = false;
                btnRemove.Enabled = false;
                btnSave.Enabled = false;

            }
            else return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
