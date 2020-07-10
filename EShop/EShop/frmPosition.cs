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
    public partial class frmPosition : Form
    {
        DataTable tblGridView;
        public frmPosition()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void resetValue()
        {
            txtPosID.Text = "";
            txtPosName.Text = "";


        }

        private void frmPosition_Load(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            txtPosID.Enabled = false;
            txtPosName.Enabled = false;
            btnDelete.Enabled = false;

            txtPosID.MaxLength = 15;
            txtPosName.MaxLength = 50;

            loadDataGridView();
            
           
        }
        private void loadDataGridView()
        {
            string selectSQL;
            selectSQL = " select * from tblPosition";
            tblGridView = Functions.getDataToTable(selectSQL);
            dgvPos.DataSource = tblGridView;
            dgvPos.Columns[0].HeaderText = "Position ID";
            dgvPos.Columns[1].HeaderText = "Position Name ";




            dgvPos.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvPos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;



            dgvPos.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvPos.AllowUserToAddRows = false;



        }

        private void cellclick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnAdd.Enabled == false || btnEdit.Enabled == false)
            {
                MessageBox.Show("Not in data view mode", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtPosID.Text = dgvPos.CurrentRow.Cells["PosID"].Value.ToString();
            txtPosName.Text = dgvPos.CurrentRow.Cells["PosName"].Value.ToString();
            btnDelete.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            resetValue();
            txtPosID.Enabled = true;
            txtPosName.Enabled = true;

            txtPosID.Focus();
            btnEdit.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnDelete.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtPosID.Text.Length == 0)
            {
                MessageBox.Show("No record has been chosen", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtPosName.Enabled = true;

            txtPosName.Focus();
            btnAdd.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnDelete.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string deleteSQL;
            deleteSQL = "delete tblPosition where PosID='" + txtPosID.Text.Trim() + "'";
            if (dgvPos.Rows.Count == 0)
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
            insertSQL = "insert into tblPosition values('" + txtPosID.Text.Trim() + "','" + txtPosName.Text.Trim() + "')";
            if (txtPosID.Enabled == true)
            {
                if (txtPosID.Text.Trim().Length == 0)
                {
                    MessageBox.Show("You need to enter the Position ID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPosID.Focus();
                    return;
                }
                if (txtPosName.Text.Trim().Length == 0)
                {
                    MessageBox.Show("You need to enter the Position name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPosName.Focus();
                    return;
                }
                selectSQL = "select * from tblPosition where PosID='" + txtPosID.Text.Trim() + "'";
                if (Functions.checkID(selectSQL) == true)
                {
                    MessageBox.Show("ID already exists", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPosID.Focus();
                    txtPosID.Text = "";
                    return;
                }
                else Functions.modifySQL(insertSQL);
            }
            else if (txtPosID.Enabled == false)
            {
                updateSQL = "update tblPosition set PosName='" + txtPosName.Text.Trim() + "' where PosID='" + txtPosID.Text.Trim() + "'";
                Functions.modifySQL(updateSQL);
            }
            MessageBox.Show("Record saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadDataGridView();
            btnCancel.Enabled = false;
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnSave.Enabled = false;
            txtPosID.Enabled = false;
            txtPosName.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            resetValue();
            btnCancel.Enabled = false;
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnSave.Enabled = false;
            txtPosID.Enabled = false;
            txtPosName.Enabled = false;
        }
    }
}
