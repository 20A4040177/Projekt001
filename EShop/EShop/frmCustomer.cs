using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EShop
{
    public partial class frmCustomer : Form
    {
        DataTable tblGridView;
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            txtCustomerID.Enabled = false;
            txtCustomerName.Enabled = false;
            txtCustomerAdd.Enabled = false;
            txtCustomerTel.Enabled = false;
            btnCancel.Enabled = false;
            loadDataGridView();

        }
        private void loadDataGridView()
        {
            string selectSQL;
            selectSQL = " select * from tblCustomer";
            tblGridView= Functions.getDataToTable(selectSQL);
            dgvCustomer.DataSource = tblGridView;
            dgvCustomer.Columns[0].HeaderText = "Customer ID";
            dgvCustomer.Columns[1].HeaderText = "Customer Name";
            dgvCustomer.Columns[2].HeaderText = "Address";
            dgvCustomer.Columns[3].HeaderText = "Phone Number";


            dgvCustomer.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCustomer.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCustomer.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCustomer.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvCustomer.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvCustomer.AllowUserToAddRows = false;
            txtCustomerID.MaxLength = 15;
            txtCustomerName.MaxLength = 50;
            txtCustomerAdd.MaxLength = 50;
            txtCustomerTel.MaxLength = 11;



        }
        private void resetValue()
        {
            txtCustomerID.Text = "";
            txtCustomerName.Text = "";
            txtCustomerTel.Text = "";
            txtCustomerAdd.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            resetValue();
            txtCustomerID.Text = Functions.CreateKey("CU");
            btnAdd.Enabled = true;
            txtCustomerName.Enabled = true;
            txtCustomerAdd.Enabled = true;
            txtCustomerTel.Enabled = true;
        }

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnAdd.Enabled == false||btnEdit.Enabled==false)
            {
                MessageBox.Show("Not in data view mode", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCustomerID.Focus();
                return;

            }
            if (tblGridView.Rows.Count == 0)
            {
                MessageBox.Show("No record has been chosen", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtCustomerID.Text = dgvCustomer.CurrentRow.Cells["CustomerID"].Value.ToString();
            txtCustomerName.Text = dgvCustomer.CurrentRow.Cells["CustomerName"].Value.ToString();
            txtCustomerAdd.Text = dgvCustomer.CurrentRow.Cells["CustomerAdd"].Value.ToString();
            txtCustomerTel.Text = dgvCustomer.CurrentRow.Cells["CustomerTel"].Value.ToString();
            btnCancel.Enabled =false;
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
            btnSave.Enabled = false;
           
         


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string selectSQL;
            string insertSQL;
            string updateSQL;
            insertSQL = "insert into tblCustomer values('" + txtCustomerID.Text.Trim() + "','" + txtCustomerName.Text.Trim() + "','" + txtCustomerAdd.Text.Trim() + "','" + txtCustomerTel.Text.Trim() + "')";
            
            if (btnAdd.Enabled == true)
            {
                if (txtCustomerID.Text.Trim().Length == 0)
                {
                    MessageBox.Show("You need to enter the Customer ID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCustomerID.Focus();
                    return;
                }
                if (txtCustomerName.Text.Trim().Length == 0)
                {
                    MessageBox.Show("You need to enter the Customer name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCustomerName.Focus();
                    return;
                }
                selectSQL = "select * from tblCustomer where CustomerID='" + txtCustomerID.Text.Trim() + "'";
                if (Functions.checkID(selectSQL) == true)
                {
                    MessageBox.Show("ID already exists", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCustomerID.Focus();
                    txtCustomerID.Text = "";
                    return;
                }
                else Functions.modifySQL(insertSQL);
            }
            if (btnAdd.Enabled == false)
            {
                updateSQL = "update tblCustomer set CustomerName='" + txtCustomerName.Text.Trim() + "', CustomerAdd='" + txtCustomerAdd.Text.Trim() + "', CustomerTel='" + txtCustomerTel.Text.Trim() + "' where CustomeriD='" + txtCustomerID.Text.Trim() + "'";
                Functions.modifySQL(updateSQL);

            }
            
            loadDataGridView();
            resetValue();
            btnDelete.Enabled = true;
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            txtCustomerID.Enabled = false;




        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnCancel.Enabled = true;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            txtCustomerName.Enabled = true;
            txtCustomerAdd.Enabled = true;
            txtCustomerTel.Enabled = true;
            if (tblGridView.Rows.Count == 0)
            {
                MessageBox.Show("No record has been chosen", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtCustomerID.Text.Length == 0)
            {
                MessageBox.Show("No record has been chosen", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnAdd.Enabled = true;
                btnCancel.Enabled =false;
                btnDelete.Enabled = true;
                btnSave.Enabled = false;
                txtCustomerName.Enabled = false;
                txtCustomerAdd.Enabled = false;
                txtCustomerTel.Enabled = false;
                return;
            }


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnSave.Enabled = false;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnCancel.Enabled = false;
            txtCustomerName.Enabled = false;
            txtCustomerAdd.Enabled = false;
            txtCustomerTel.Enabled = false;
            txtCustomerID.Enabled = false;
            resetValue();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string deleteSQL;
            deleteSQL = "delete tblCustomer where CustomerID='" + txtCustomerID.Text.Trim() + "'";
            if (tblGridView.Rows.Count == 0)
            {
                MessageBox.Show("No record has been chosen", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtCustomerID.Text.Length == 0)
            {
                MessageBox.Show("No record has been chosen", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Do you want to delete this record?","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Functions.deleteSQL(deleteSQL);
                loadDataGridView();
                resetValue();
            }
        }

        private void cellclick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnAdd.Enabled == false||btnEdit.Enabled==false)
            {
                MessageBox.Show("Not in data view mode", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCustomerID.Focus();
                return;

            }
            if (tblGridView.Rows.Count == 0)
            {
                MessageBox.Show("No record has been chosen", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtCustomerID.Text = dgvCustomer.CurrentRow.Cells["CustomerID"].Value.ToString();
            txtCustomerName.Text = dgvCustomer.CurrentRow.Cells["CustomerName"].Value.ToString();
            txtCustomerAdd.Text = dgvCustomer.CurrentRow.Cells["CustomerAdd"].Value.ToString();
            txtCustomerTel.Text = dgvCustomer.CurrentRow.Cells["CustomerTel"].Value.ToString();
            btnCancel.Enabled = false;
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
            btnSave.Enabled = false;
            txtCustomerID.Enabled = false;
        }

        private void txtCustomerTel_TextChanged(object sender, EventArgs e)
        {
            if (btnEdit.Enabled == false)
            {
                if (txtCustomerTel.Text.Trim().Length > 0)
                {
                    txtCustomerID.Text = "CU" + txtCustomerTel.Text;
                }
                else txtCustomerID.Text = Functions.CreateKey("CU");
            }
        }


    }
}
