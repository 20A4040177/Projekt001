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
    public partial class frmShift : Form
    {
        DataTable tblGridView;
        public frmShift()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void resetValue()
        {
            txtShiftID.Text = "";
            txtShiftName.Text = "";


        }

        private void frmShift_Load(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            txtShiftID.Enabled = false;
            txtShiftName.Enabled = false;
            btnDelete.Enabled = false;

            txtShiftID.MaxLength = 15;
            txtShiftName.MaxLength = 50;

            loadDataGridView();
            
            
        }
        private void loadDataGridView()
        {
            string selectSQL;
            selectSQL = " select * from tblWorkShift";
            tblGridView = Functions.getDataToTable(selectSQL);
            dgvShift.DataSource = tblGridView;
            dgvShift.Columns[0].HeaderText = "Shift ID";
            dgvShift.Columns[1].HeaderText = "Shift Name ";




            dgvShift.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvShift.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;



            dgvShift.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvShift.AllowUserToAddRows = false;



        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            resetValue();
            txtShiftID.Enabled = true;
            txtShiftName.Enabled = true;

            txtShiftID.Focus();
            btnEdit.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnDelete.Enabled = false;
        }

        private void dgvShift_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cellclick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnAdd.Enabled == false || btnEdit.Enabled == false)
            {
                MessageBox.Show("Not in data view mode", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtShiftID.Text = dgvShift.CurrentRow.Cells["ShiftID"].Value.ToString();
            txtShiftName.Text = dgvShift.CurrentRow.Cells["ShiftName"].Value.ToString();
            btnDelete.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtShiftID.Text.Length == 0)
            {
                MessageBox.Show("No record has been chosen", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtShiftName.Enabled = true;

            txtShiftName.Focus();
            btnAdd.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnDelete.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string deleteSQL;
            deleteSQL = "delete tblWorkShift where ShiftID='" + txtShiftID.Text.Trim() + "'";
            if (dgvShift.Rows.Count == 0)
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
            insertSQL = "insert into tblWorkShift values('" + txtShiftID.Text.Trim() + "','" + txtShiftName.Text.Trim() + "')";
            if (txtShiftID.Enabled == true)
            {
                if (txtShiftID.Text.Trim().Length == 0)
                {
                    MessageBox.Show("You need to enter the Work shift ID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtShiftID.Focus();
                    return;
                }
                if (txtShiftName.Text.Trim().Length == 0)
                {
                    MessageBox.Show("You need to enter the Work shift name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtShiftName.Focus();
                    return;
                }
                selectSQL = "select * from tblWorkShift where ShiftID='" + txtShiftID.Text.Trim() + "'";
                if (Functions.checkID(selectSQL) == true)
                {
                    MessageBox.Show("ID already exists", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtShiftID.Focus();
                    txtShiftID.Text = "";
                    return;
                }
                else Functions.modifySQL(insertSQL);
            }
            else if (txtShiftID.Enabled == false)
            {
                updateSQL = "update tblWorkShift set ShiftName='" + txtShiftName.Text.Trim() + "' where ShiftID='" + txtShiftID.Text.Trim() + "'";
                Functions.modifySQL(updateSQL);
            }
            MessageBox.Show("Record saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadDataGridView();
            btnCancel.Enabled = false;
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnSave.Enabled = false;
            txtShiftID.Enabled = false;
            txtShiftName.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            resetValue();
            btnCancel.Enabled = false;
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnSave.Enabled = false;
            txtShiftID.Enabled = false;
            txtShiftName.Enabled = false;
        }

    }
}
