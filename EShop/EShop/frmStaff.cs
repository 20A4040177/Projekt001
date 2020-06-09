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
    public partial class frmStaff : Form
    {
        DataTable tblGridView;
        public frmStaff()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDetailItem_Click(object sender, EventArgs e)
        {
            frmStaffDetail StaffDetail1 = new frmStaffDetail();
            StaffDetail1.txtStaffID.Text = dgvStaff.CurrentRow.Cells["StaffID"].Value.ToString();
            StaffDetail1.ShowDialog();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            frmStaffAdd StaffAdd = new frmStaffAdd();
            
            StaffAdd.ShowDialog();
            
        }

        private void frmStaff_Load(object sender, EventArgs e)
        {
            loadDataGridView();
        }
        private void loadDataGridView()
        {
            string selectSQL;
            selectSQL = " select StaffID,StaffName,Gender,DOB from tblStaff";
            tblGridView = Functions.getDataToTable(selectSQL);
            dgvStaff.DataSource = tblGridView;
            dgvStaff.Columns[0].HeaderText = "Staff ID";
            dgvStaff.Columns[1].HeaderText = "Name";
            dgvStaff.Columns[2].HeaderText = "Gender";
            dgvStaff.Columns[3].HeaderText = "Date of Birth";


            dgvStaff.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvStaff.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvStaff.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvStaff.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvStaff.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvStaff.AllowUserToAddRows = false;



        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadDataGridView();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string deleteSQL;
            deleteSQL = "delete tblStaff where StaffID='" + dgvStaff.CurrentRow.Cells["StaffID"].Value.ToString() + "'";
            if (dgvStaff.Rows.Count == 0)
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
