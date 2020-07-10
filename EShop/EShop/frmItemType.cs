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
    public partial class frmItemType : Form
    {
        DataTable tblGridView;
        public frmItemType()
        {
            InitializeComponent();
        }

        private void txtCatID_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbTypeID_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmItemType_Load(object sender, EventArgs e)
        {
            loadDataGridView();
            dgvType.ClearSelection();
            txtTypeID.Enabled = false;
            txtTypeName.Enabled = false;
            cboCatID.Enabled = false;
            
            btnDelete.Enabled = false;
            btnCancel.Enabled = false;
            btnSave.Enabled = false;
            txtTypeID.MaxLength = 15;
            txtTypeName.MaxLength = 50;
            


            
        }
        private void loadDataGridView()
        {
            string selectSQL;
            selectSQL = " select * from tblItemType";
            tblGridView = Functions.getDataToTable(selectSQL);
            dgvType.DataSource = tblGridView;
            dgvType.Columns[0].HeaderText = "Type ID";
            dgvType.Columns[1].HeaderText = "Type Name ";
            dgvType.Columns[2].HeaderText = "Category ID";
            


            dgvType.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvType.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvType.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            dgvType.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvType.AllowUserToAddRows = false;



        }
        private void resetValue()
        {
            txtTypeName.Text = "";
            txtTypeID.Text = "";
            cboCatID.SelectedIndex = -1;
        }

        private void cellclick(object sender, DataGridViewCellEventArgs e)
        {
            btnDelete.Enabled = true;
            txtTypeID.Text = dgvType.CurrentRow.Cells["TypeID"].Value.ToString();
            txtTypeName.Text = dgvType.CurrentRow.Cells["TypeName"].Value.ToString();
            cboCatID.Text = dgvType.CurrentRow.Cells["CatID"].Value.ToString();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtTypeID.Enabled = true;
            txtTypeName.Enabled = true;
            cboCatID.Enabled = true;
            resetValue();
            btnEdit.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            Functions.fillComboBox("select CatID,CatName from tblCategory", cboCatID, "CatID", "CatName");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtTypeID.Text.Length == 0)
            {
                MessageBox.Show("No record has been chosen", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtTypeName.Enabled = true;
            cboCatID.Enabled = true;
            Functions.fillComboBox("select CatID,CatName from tblCategory", cboCatID, "CatID", "CatName");
            btnSave.Enabled = true;
            btnCancel.Enabled = true;


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string deleteSQL;
            deleteSQL = "delete tblItemType where TypeID='" + txtTypeID.Text.Trim() + "'";
            if (dgvType.Rows.Count == 0)
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
            
            if (txtTypeID.Enabled == true)
            {
                if (txtTypeID.Text.Trim().Length == 0)
                {
                    MessageBox.Show("You need to enter the Type ID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTypeID.Focus();
                    return;
                }
                if (txtTypeName.Text.Trim().Length == 0)
                {
                    MessageBox.Show("You need to enter the Type name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTypeName.Focus();
                    return;
                }
                if (cboCatID.SelectedIndex==-1)
                {
                    MessageBox.Show("You need to select a Category", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else insertSQL = "insert into tblItemType values('" + txtTypeID.Text.Trim() + "','" + txtTypeName.Text.Trim() + "','" + cboCatID.SelectedValue.ToString().Trim() + "')";
                selectSQL = "select * from tblItemType where TypeID='" + txtTypeID.Text.Trim() + "'";
                if (Functions.checkID(selectSQL) == true)
                {
                    MessageBox.Show("ID already exists", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTypeID.Focus();
                    txtTypeID.Text = "";
                    return;
                }
                else Functions.modifySQL(insertSQL);
            }
            else if (txtTypeID.Enabled == false)
            {
                if (cboCatID.SelectedIndex == -1)
                {
                    MessageBox.Show("You need to select a Category", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                updateSQL = "update tblItemType set TypeName='" + txtTypeName.Text.Trim() + "', CatID='" + cboCatID.SelectedValue.ToString().Trim() + "' where TypeID='" + txtTypeID.Text.Trim() + "'";
                Functions.modifySQL(updateSQL);
            }
            MessageBox.Show("Record saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadDataGridView();
            btnCancel.Enabled = false;
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnSave.Enabled = false;
            txtTypeID.Enabled = false;
            txtTypeName.Enabled = false;
            cboCatID.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            resetValue();
            btnCancel.Enabled = false;
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnSave.Enabled = false;
            txtTypeID.Enabled = false;
            txtTypeName.Enabled = false;
            cboCatID.Enabled = false;
        }

    }
}
