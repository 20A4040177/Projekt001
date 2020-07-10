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
    public partial class frmUnit : Form
    {
        DataTable tblGridView;
        public frmUnit()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void resetValue()
        {
            txtUnitID.Text = "";
            txtUnitName.Text = "";


        }
        private void frmUnit_Load(object sender, EventArgs e)
        {

            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            txtUnitID.Enabled = false;
            txtUnitName.Enabled = false;
            btnDelete.Enabled = false;

            txtUnitID.MaxLength = 15;
            txtUnitName.MaxLength = 50;

            loadDataGridView();
            
            
        }

        private void loadDataGridView()
        {
            string selectSQL;
            selectSQL = " select * from tblUnit";
            tblGridView = Functions.getDataToTable(selectSQL);
            dgvUnit.DataSource = tblGridView;
            dgvUnit.Columns[0].HeaderText = "Unit ID";
            dgvUnit.Columns[1].HeaderText = "Unit Name";




            dgvUnit.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvUnit.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;



            dgvUnit.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvUnit.AllowUserToAddRows = false;



        }

        private void dgvUnit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cellclick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnAdd.Enabled == false || btnEdit.Enabled == false)
            {
                MessageBox.Show("Not in data view mode", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtUnitID.Text = dgvUnit.CurrentRow.Cells["UnitID"].Value.ToString();
            txtUnitName.Text = dgvUnit.CurrentRow.Cells["UnitName"].Value.ToString();
            btnDelete.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            resetValue();
            txtUnitID.Enabled = true;
            txtUnitName.Enabled = true;

            txtUnitID.Focus();
            btnEdit.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnDelete.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtUnitID.Text.Length == 0)
            {
                MessageBox.Show("No record has been chosen", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtUnitName.Enabled = true;

            txtUnitName.Focus();
            btnAdd.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnDelete.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string deleteSQL;
            deleteSQL = "delete tblUnit where UnitID='" + txtUnitID.Text.Trim() + "'";
            if (dgvUnit.Rows.Count == 0)
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
            insertSQL = "insert into tblUnit values('" + txtUnitID.Text.Trim() + "','" + txtUnitName.Text.Trim() + "')";
            if (txtUnitID.Enabled == true)
            {
                if (txtUnitID.Text.Trim().Length == 0)
                {
                    MessageBox.Show("You need to enter the Unit ID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUnitID.Focus();
                    return;
                }
                if (txtUnitName.Text.Trim().Length == 0)
                {
                    MessageBox.Show("You need to enter the Unit name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUnitName.Focus();
                    return;
                }
                selectSQL = "select * from tblUnit where UnitID='" + txtUnitID.Text.Trim() + "'";
                if (Functions.checkID(selectSQL) == true)
                {
                    MessageBox.Show("ID already exists", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUnitID.Focus();
                    txtUnitID.Text = "";
                    return;
                }
                else Functions.modifySQL(insertSQL);
            }
            else if (txtUnitID.Enabled == false)
            {
                updateSQL = "update tblUnit set UnitName='" + txtUnitName.Text.Trim() + "' where UnitID='" + txtUnitID.Text.Trim() + "'";
                Functions.modifySQL(updateSQL);
            }
            MessageBox.Show("Record saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadDataGridView();
            btnCancel.Enabled = false;
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnSave.Enabled = false;
            txtUnitID.Enabled = false;
            txtUnitName.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            resetValue();
            btnCancel.Enabled = false;
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnSave.Enabled = false;
            txtUnitID.Enabled = false;
            txtUnitName.Enabled = false;
        }

    }
}
