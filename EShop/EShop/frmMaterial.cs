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
    public partial class frmMaterial : Form
    {
        DataTable tblGridView;
        public frmMaterial()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void resetValue()
        {
            txtMatID.Text = "";
            txtMatName.Text = "";


        }

        private void btnHome_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMaterial_Load(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            txtMatID.Enabled = false;
            txtMatName.Enabled = false;
            btnDelete.Enabled = false;

            txtMatID.MaxLength = 15;
            txtMatName.MaxLength = 50;

            loadDataGridView();
            

            
            loadDataGridView();

        }
        private void loadDataGridView()
        {
            string selectSQL;
            selectSQL = " select * from tblMaterial";
            tblGridView = Functions.getDataToTable(selectSQL);
            dgvMat.DataSource = tblGridView;
            dgvMat.Columns[0].HeaderText = "Material ID";
            dgvMat.Columns[1].HeaderText = "Material Name ";




            dgvMat.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvMat.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;



            dgvMat.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvMat.AllowUserToAddRows = false;



        }

        private void cellclick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnAdd.Enabled == false || btnEdit.Enabled == false)
            {
                MessageBox.Show("Not in data view mode", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMatID.Text = dgvMat.CurrentRow.Cells["MatID"].Value.ToString();
            txtMatName.Text = dgvMat.CurrentRow.Cells["MatName"].Value.ToString();
            btnDelete.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            resetValue();
            txtMatID.Enabled = true;
            txtMatName.Enabled = true;

            txtMatID.Focus();
            btnEdit.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnDelete.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtMatID.Text.Length == 0)
            {
                MessageBox.Show("No record has been chosen", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMatName.Enabled = true;

            txtMatName.Focus();
            btnAdd.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnDelete.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string deleteSQL;
            deleteSQL = "delete tblMaterial where MatID='" + txtMatID.Text.Trim() + "'";
            if (dgvMat.Rows.Count == 0)
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
            insertSQL = "insert into tblMaterial values('" + txtMatID.Text.Trim() + "','" + txtMatName.Text.Trim() + "')";
            if (txtMatID.Enabled == true)
            {
                if (txtMatID.Text.Trim().Length == 0)
                {
                    MessageBox.Show("You need to enter the Material ID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMatID.Focus();
                    return;
                }
                if (txtMatName.Text.Trim().Length == 0)
                {
                    MessageBox.Show("You need to enter the Material name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMatName.Focus();
                    return;
                }
                selectSQL = "select * from tblMaterial where MatID='" + txtMatID.Text.Trim() + "'";
                if (Functions.checkID(selectSQL) == true)
                {
                    MessageBox.Show("ID already exists", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMatID.Focus();
                    txtMatID.Text = "";
                    return;
                }
                else Functions.modifySQL(insertSQL);
            }
            else if (txtMatID.Enabled == false)
            {
                updateSQL = "update tblMaterial set MatName='" + txtMatName.Text.Trim() + "' where MatID='" + txtMatID.Text.Trim() + "'";
                Functions.modifySQL(updateSQL);
            }
            MessageBox.Show("Record saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadDataGridView();
            btnCancel.Enabled = false;
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnSave.Enabled = false;
            txtMatID.Enabled = false;
            txtMatName.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            resetValue();
            btnCancel.Enabled = false;
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnSave.Enabled = false;
            txtMatID.Enabled = false;
            txtMatName.Enabled = false;
        }
    }
}
