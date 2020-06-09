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
    public partial class frmStatStaff : Form
    {
        DataTable tblGridView;
        public frmStatStaff()
        {
            InitializeComponent();
        }

        private void frmStatStaff_Load(object sender, EventArgs e)
        {
            txtStaffName.Enabled = false;
            Functions.fillComboBox("select StaffID from tblStaff", cboStaffID, "StaffID", "StaffID");
            cboStaffID.SelectedIndex = -1;
        }

        private void cboStaffID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboStaffID.SelectedIndex != -1)
            {
                txtStaffName.Text = Functions.getFieldValues("select StaffName from tblStaff where StaffID='" + cboStaffID.SelectedValue.ToString() + "'");
            }
            else txtStaffName.Text = "";
        }
        private void loadDataGridView()
        {
            string selectSQL;
            selectSQL = "select  top 3 ItemName, tblSaleInvoiceDetail.ItemID,sum(tblSaleInvoiceDetail.Quantity) as Total from tblItemList inner join tblSaleInvoiceDetail on tblItemList.ItemID=tblSaleInvoiceDetail.ItemID inner join tblSaleInvoice on tblSaleInvoiceDetail.InvoiceID=tblSaleInvoice.InvoiceID where StaffID='" + cboStaffID.SelectedValue.ToString() + "' group by tblSaleInvoiceDetail.ItemID,ItemName";
            tblGridView = Functions.getDataToTable(selectSQL);
            dgvProduct.DataSource = tblGridView;
            dgvProduct.Columns[0].HeaderText = "Item ID";
            dgvProduct.Columns[1].HeaderText = "Item Name";
            dgvProduct.Columns[2].HeaderText = "Sold Quantity";
            dgvProduct.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvProduct.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvProduct.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvProduct.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvProduct.AllowUserToAddRows = false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cboStaffID.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Staff", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                cboStaffID.Focus();
                return;
            }
            else loadDataGridView();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
