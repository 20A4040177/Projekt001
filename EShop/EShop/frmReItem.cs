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
    public partial class frmReItem : Form
    {
        DataTable tblGridView;
        string itemName;
        public frmReItem()
        {
            InitializeComponent();
        }

        private void frmReItem_Load(object sender, EventArgs e)
        {
            loadDataGridView();
            cboReason.Enabled = false;
            cboItem.Enabled = false;
            nbrQuantity.Enabled = false;
            cboInvoiceID.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            cboReason.Items.Add("Select a reason");
            cboReason.Items.Add("Truc trac ky thuat");
            cboReason.Items.Add("Khong hoat dong");
            cboReason.Items.Add("Hoat dong khong binh thuong");
            cboReason.Items.Add("Thua/Thieu linh kien");
            
            cboReason.SelectedItem = "Select a reason";
            Functions.fillComboBox("select InvoiceID from tblSaleInvoice", cboInvoiceID,"InvoiceID","InvoiceID");
           
            
            nbrQuantity.Minimum = 1;
            



        }
        private void loadDataGridView()
        {
            string selectSQL;
            selectSQL = "select * from tblReItem";
            tblGridView = Functions.getDataToTable(selectSQL);
            dgvItem.DataSource = tblGridView;
            dgvItem.Columns[0].HeaderText = "Item ID";
            dgvItem.Columns[1].HeaderText = "Name";
            dgvItem.Columns[2].HeaderText = "Quantity";
            dgvItem.Columns[3].HeaderText = "Date";
            dgvItem.Columns[4].HeaderText = "Description";
            dgvItem.Columns[5].HeaderText = "Invoice ID";
            dgvItem.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvItem.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvItem.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvItem.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvItem.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvItem.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvItem.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvItem.AllowUserToAddRows = false;


        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cboItem.Enabled = true;
            cboInvoiceID.Enabled = true;
            cboReason.Enabled = true;
            nbrQuantity.Enabled = true;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnAdd.Enabled = false;

        }

        private void cboInvoiceID_SelectedIndexChanged(object sender, EventArgs e)
        {
            Functions.fillComboBox("select ItemID from tblSaleInvoiceDetail where InvoiceID='" + cboInvoiceID.SelectedValue.ToString() + "'", cboItem, "ItemID", "ItemID");
           
        }

        private void cboItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            nbrQuantity.Maximum = Functions.getFieldValuesInt("select Quantity from tblSaleInvoiceDetail where ItemID='" + cboItem.SelectedValue.ToString() + "'");
            itemName = Functions.getFieldValues("select ItemName from tblItemList where ItemID='" + cboItem.SelectedValue.ToString() + "'");
            nbrQuantity.Maximum = Functions.getFieldValuesInt("select Quantity from tblSaleInvoiceDetail where ItemID='" + cboItem.SelectedValue.ToString() + "'");
            itemName = Functions.getFieldValues("select ItemName from tblItemList where ItemID='" + cboItem.SelectedValue.ToString() + "'");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string insertSQL;
            insertSQL = "insert into tblReItem values('" + cboItem.SelectedValue.ToString() + "','" + itemName + "'," + nbrQuantity.Value + ",'" + DateTime.Now.ToString("yyyy/MM/dd") + "','" + cboReason.SelectedItem.ToString() + "','" + cboInvoiceID.SelectedValue.ToString() + "')";
            if (cboReason.SelectedIndex == 0 || cboReason.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a reason", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboReason.Focus();
                return;
            }
            if (cboInvoiceID.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an Invoice", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboInvoiceID.Focus();
                return;
            }
            if (cboItem.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an Item", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboItem.Focus();
                return;
            }
            Functions.modifySQL(insertSQL);
            loadDataGridView();
            btnAdd.Enabled = true;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cboReason.Enabled = false;
            cboItem.Enabled = false;
            nbrQuantity.Enabled = false;
            cboInvoiceID.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnAdd.Enabled = true;
            cboReason.SelectedIndex = 0;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string deleteSQL;
            if (dgvItem.SelectedRows.Count==0)
            {
                MessageBox.Show("No record has been chosen", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            deleteSQL = "delete from tblReItem where ItemID='" + dgvItem.CurrentRow.Cells["ItemID"].Value.ToString() + "' and InvoiceID='" + dgvItem.CurrentRow.Cells["InvoiceID"].Value.ToString() + "'";
            if (tblGridView.Rows.Count == 0)
            {
                MessageBox.Show("No record has been chosen", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            if (MessageBox.Show("Do you want to delete this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Functions.deleteSQL(deleteSQL);
                loadDataGridView();
               
            }
            
        }
    }
}
