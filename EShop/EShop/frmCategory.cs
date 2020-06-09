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
    public partial class frmCategory : Form
    {
        DataTable tblGridView;
        public frmCategory()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void frmCategory_Load(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnDelete.Enabled = false;
            txtCatID.Enabled = false;
            txtCatName.Enabled = false;
            txtUsage.Enabled = false;
            txtCatID.MaxLength = 15;
            txtCatName.MaxLength = 50;
            txtUsage.MaxLength = 100;
            loadDataGridView();
            txtCatID.Text = dgvCat.CurrentRow.Cells["CatID"].Value.ToString();
            txtCatName.Text = dgvCat.CurrentRow.Cells["CatName"].Value.ToString();
            txtUsage.Text = dgvCat.CurrentRow.Cells["CatUsage"].Value.ToString();

        }
        private void loadDataGridView()
        {
            string selectSQL;
            selectSQL = " select * from tblCategory";
            tblGridView = Functions.getDataToTable(selectSQL);
            dgvCat.DataSource = tblGridView;
            dgvCat.Columns[0].HeaderText = "Category ID";
            dgvCat.Columns[1].HeaderText = "Category Name";
            dgvCat.Columns[2].HeaderText = "Usage";
            dgvCat.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCat.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCat.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCat.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvCat.AllowUserToAddRows = false;



        }
        private void resetValue()
        {
            txtCatID.Text = "";
            txtCatName.Text = "";
            txtUsage.Text = "";
            
        }

        private void dgvCat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnAdd.Enabled == false || btnEdit.Enabled == false)
            {
                MessageBox.Show("Not in data view mode", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtCatID.Text = dgvCat.CurrentRow.Cells["CatID"].Value.ToString();
            txtCatName.Text = dgvCat.CurrentRow.Cells["CatName"].Value.ToString();
            txtUsage.Text = dgvCat.CurrentRow.Cells["CatUsage"].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            resetValue();
            txtCatID.Enabled = true;
            txtCatName.Enabled = true;
            txtUsage.Enabled = true;
            txtCatID.Focus();
            btnEdit.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnDelete.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtCatID.Text.Length == 0)
            {
                MessageBox.Show("No record has been chosen", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtCatName.Enabled = true;
            txtUsage.Enabled = true;
            txtCatName.Focus();
            btnAdd.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnDelete.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string deleteSQL;
            deleteSQL = "delete tblCategory where CatID='" + txtCatID.Text.Trim() + "'";
            if (dgvCat.Rows.Count == 0)
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
            insertSQL = "insert into tblCategory values('" + txtCatID.Text.Trim() + "','" + txtCatName.Text.Trim() + "','" + txtUsage.Text.Trim() +  "')";
            if (txtCatID.Enabled == true)
            {
                if (txtCatID.Text.Trim().Length == 0)
                {
                    MessageBox.Show("You need to enter the Category ID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCatID.Focus();
                    return;
                }
                if (txtCatName.Text.Trim().Length == 0)
                {
                    MessageBox.Show("You need to enter the Category name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCatName.Focus();
                    return;
                }
                selectSQL = "select * from tblCategory where CatID='" + txtCatID.Text.Trim() + "'";
                if (Functions.checkID(selectSQL) == true)
                {
                    MessageBox.Show("ID already exists", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCatID.Focus();
                    txtCatID.Text = "";
                    return;
                }
                else Functions.modifySQL(insertSQL);
            }
            else if (txtCatID.Enabled == false)
            {
                updateSQL = "update tblCategory set CatName='" + txtCatName.Text.Trim() + "', CatUsage='" + txtUsage.Text.Trim() + "' where CatID='" + txtCatID.Text.Trim() + "'";
                Functions.modifySQL(updateSQL);
            }
            MessageBox.Show("Record saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadDataGridView();
            btnCancel.Enabled = false;
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnSave.Enabled = false;
            txtCatID.Enabled = false;
            txtCatName.Enabled = false;
            txtUsage.Enabled = false;

            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            resetValue();
            btnCancel.Enabled = false;
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnSave.Enabled = false;
            txtCatID.Enabled = false;
            txtCatName.Enabled = false;
            txtUsage.Enabled = false;
        }

        private void dgvCatCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnAdd.Enabled == false || btnEdit.Enabled == false)
            {
                MessageBox.Show("Not in data view mode", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtCatID.Text = dgvCat.CurrentRow.Cells["CatID"].Value.ToString();
            txtCatName.Text = dgvCat.CurrentRow.Cells["CatName"].Value.ToString();
            txtUsage.Text = dgvCat.CurrentRow.Cells["CatUsage"].Value.ToString();
            btnDelete.Enabled = true;
        }

        
    }
}
