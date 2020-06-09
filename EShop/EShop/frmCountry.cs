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
    public partial class frmCountry : Form
    {
        DataTable tblGridView;
        public frmCountry()
        {
            InitializeComponent();
        }

        private void txtMatID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCountry_Load(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            txtCountryID.Enabled = false;
            txtCountryName.Enabled = false;
            btnDelete.Enabled = false;
            
            txtCountryID.MaxLength = 15;
            txtCountryName.MaxLength = 50;
           
            loadDataGridView();
            txtCountryID.Text = dgvCountry.CurrentRow.Cells["CountryID"].Value.ToString();
            txtCountryName.Text = dgvCountry.CurrentRow.Cells["CountryName"].Value.ToString();
            
            loadDataGridView();

        }
        private void loadDataGridView()
        {
            string selectSQL;
            selectSQL = " select * from tblCountry";
            tblGridView = Functions.getDataToTable(selectSQL);
            dgvCountry.DataSource = tblGridView;
            dgvCountry.Columns[0].HeaderText = "Country ID";
            dgvCountry.Columns[1].HeaderText = "Country Name";
            
            dgvCountry.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCountry.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            
            dgvCountry.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvCountry.AllowUserToAddRows = false;



        }
        private void resetValue()
        {
            txtCountryID.Text = "";
            txtCountryName.Text = "";
            

        }

        private void dgvCountry_cellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnAdd.Enabled == false || btnEdit.Enabled == false)
            {
                MessageBox.Show("Not in data view mode", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtCountryID.Text = dgvCountry.CurrentRow.Cells["CountryID"].Value.ToString();
            txtCountryName.Text = dgvCountry.CurrentRow.Cells["CountryName"].Value.ToString();
            btnDelete.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            resetValue();
            txtCountryID.Enabled = true;
            txtCountryName.Enabled = true;
            
            txtCountryID.Focus();
            btnEdit.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnDelete.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            if (txtCountryID.Text.Length == 0)
            {
                MessageBox.Show("No record has been chosen", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtCountryName.Enabled = true;
            
            txtCountryName.Focus();
            btnAdd.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnDelete.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string deleteSQL;
            deleteSQL = "delete tblCountry where CountryID='" + txtCountryID.Text.Trim() + "'";
            if (dgvCountry.Rows.Count == 0)
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
            insertSQL = "insert into tblCountry values('" + txtCountryID.Text.Trim() + "','" + txtCountryName.Text.Trim() +  "')";
            if (txtCountryID.Enabled == true)
            {
                if (txtCountryID.Text.Trim().Length == 0)
                {
                    MessageBox.Show("You need to enter the Country ID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCountryID.Focus();
                    return;
                }
                if (txtCountryName.Text.Trim().Length == 0)
                {
                    MessageBox.Show("You need to enter the Country name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCountryName.Focus();
                    return;
                }
                selectSQL = "select * from tblCountry where CountryID='" + txtCountryID.Text.Trim() + "'";
                if (Functions.checkID(selectSQL) == true)
                {
                    MessageBox.Show("ID already exists", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCountryID.Focus();
                    txtCountryID.Text = "";
                    return;
                }
                else Functions.modifySQL(insertSQL);
            }
            else if (txtCountryID.Enabled == false)
            {
                updateSQL = "update tblCountry set CountryName='" + txtCountryName.Text.Trim() + "' where CountryID='" + txtCountryID.Text.Trim() + "'";
                Functions.modifySQL(updateSQL);
            }
            MessageBox.Show("Record saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadDataGridView();
            btnCancel.Enabled = false;
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnSave.Enabled = false;
            txtCountryID.Enabled = false;
            txtCountryName.Enabled = false;
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            resetValue();
            btnCancel.Enabled = false;
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnSave.Enabled = false;
            txtCountryID.Enabled = false;
            txtCountryName.Enabled = false;
            
        }
    }
}
