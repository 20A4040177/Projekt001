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
    public partial class frmSupplier : Form
    {
        DataTable tblGridView;
        public frmSupplier()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSupplier_Load(object sender, EventArgs e)
        {
            loadDataGridView();
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnDelete.Enabled = false;
            txtSupplierID.Enabled = false;
            txtSupplierName.Enabled = false;
            txtSupplierAdd.Enabled = false;
            txtSupplierTel.Enabled = false;
            txtSupplierID.MaxLength = 15;
            txtSupplierName.MaxLength = 50;
            txtSupplierAdd.MaxLength = 50;
            txtSupplierTel.MaxLength = 11;
            loadDataGridView();
            txtSupplierID.Text = dgvSupplier.CurrentRow.Cells["SupplierID"].Value.ToString();
            txtSupplierName.Text = dgvSupplier.CurrentRow.Cells["SupplierName"].Value.ToString();
            txtSupplierAdd.Text = dgvSupplier.CurrentRow.Cells["SupplierAdd"].Value.ToString();
            txtSupplierTel.Text = dgvSupplier.CurrentRow.Cells["SupplierTel"].Value.ToString();
            

        }
        private void loadDataGridView()
        {
            string selectSQL;
            selectSQL = " select * from tblSupplier";
            tblGridView = Functions.getDataToTable(selectSQL);
            dgvSupplier.DataSource = tblGridView;
            dgvSupplier.Columns[0].HeaderText = "Supplier ID";
            dgvSupplier.Columns[1].HeaderText = "Name";
            dgvSupplier.Columns[2].HeaderText = "Address";
            dgvSupplier.Columns[3].HeaderText = "Phone Number";


            dgvSupplier.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvSupplier.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvSupplier.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvSupplier.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvSupplier.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvSupplier.AllowUserToAddRows = false;



        }
        private void resetValue()
        {
            txtSupplierID.Text = "";
            txtSupplierName.Text = "";
            txtSupplierTel.Text = "";
            txtSupplierAdd.Text = "";

        }

        private void cellclick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnAdd.Enabled == false || btnEdit.Enabled == false)
            {
                MessageBox.Show("Not in data view mode", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtSupplierID.Text = dgvSupplier.CurrentRow.Cells["SupplierID"].Value.ToString();
            txtSupplierName.Text = dgvSupplier.CurrentRow.Cells["SupplierName"].Value.ToString();
            txtSupplierAdd.Text = dgvSupplier.CurrentRow.Cells["SupplierAdd"].Value.ToString();
            txtSupplierTel.Text = dgvSupplier.CurrentRow.Cells["SupplierTel"].Value.ToString();
            btnDelete.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            resetValue();
            txtSupplierID.Text = Functions.CreateKey("SUP");
            txtSupplierName.Enabled = true;
            txtSupplierAdd.Enabled = true;
            txtSupplierTel.Enabled = true;
            txtSupplierID.Focus();
            btnEdit.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnDelete.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtSupplierID.Text.Length == 0)
            {
                MessageBox.Show("No record has been chosen", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtSupplierName.Enabled = true;
            txtSupplierAdd.Enabled = true;
            txtSupplierTel.Enabled = true;
            txtSupplierName.Focus();
            btnAdd.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnDelete.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string deleteSQL;
            deleteSQL = "delete tblSupplier where SupplierID='" + txtSupplierID.Text.Trim() + "'";
            if (dgvSupplier.Rows.Count == 0)
            {
                MessageBox.Show("No record has been chosen", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Do you want to delete this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Functions.deleteSQL(deleteSQL);
                loadDataGridView();
                resetValue();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string selectSQL;
            string insertSQL;
            string updateSQL;
            insertSQL = "insert into tblSupplier values('" + txtSupplierID.Text.Trim() + "','" + txtSupplierName.Text.Trim() + "','" + txtSupplierAdd.Text.Trim() +"','"+txtSupplierTel.Text.Trim()+ "')";
            if (btnEdit.Enabled == false)
            {
                if (txtSupplierID.Text.Trim().Length == 0)
                {
                    MessageBox.Show("You need to enter the Supplier ID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSupplierID.Focus();
                    return;
                }
                if (txtSupplierName.Text.Trim().Length == 0)
                {
                    MessageBox.Show("You need to enter the Supplier name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSupplierName.Focus();
                    return;
                }
                if (txtSupplierAdd.Text.Trim().Length == 0)
                {
                    MessageBox.Show("You need to enter the Supplier address", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSupplierAdd.Focus();
                    return;
                }
                if (txtSupplierTel.Text.Trim().Length == 0)
                {
                    MessageBox.Show("You need to enter the Supplier phone number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSupplierTel.Focus();
                    return;
                }

                selectSQL = "select * from tblSupplier where SupplierID='" + txtSupplierID.Text.Trim() + "'";
                if (Functions.checkID(selectSQL) == true)
                {
                    MessageBox.Show("ID already exists", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSupplierID.Focus();
                    txtSupplierID.Text = "";
                    return;
                }
                else Functions.modifySQL(insertSQL);
            }
            else if (btnEdit.Enabled == true)
            {
                updateSQL = "update tblSupplier set SupplierName='" + txtSupplierName.Text.Trim() + "', SupplierAdd='" + txtSupplierAdd.Text.Trim() + "', SupplierTel='" + txtSupplierTel.Text.Trim() + "' where SupplierID='" + txtSupplierID.Text.Trim() + "'";
                Functions.modifySQL(updateSQL);
            }
            MessageBox.Show("Record saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadDataGridView();
            btnCancel.Enabled = false;
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnSave.Enabled = false;
            txtSupplierID.Enabled = false;
            txtSupplierName.Enabled = false;
            txtSupplierAdd.Enabled = false;
            txtSupplierTel.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            resetValue();
            btnCancel.Enabled = false;
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnSave.Enabled = false;
            txtSupplierID.Enabled = false;
            txtSupplierName.Enabled = false;
            txtSupplierAdd.Enabled = false;
            txtSupplierTel.Enabled = false;
        }

        private void txtSupplierTel_TextChanged(object sender, EventArgs e)
        {
            if (btnEdit.Enabled == false)
            {
                txtSupplierID.Text = "SUP" + txtSupplierTel.Text;
            }
        }

        private void keypress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
        
            {
                e.Handled = true;
            }
        }
    }
}
