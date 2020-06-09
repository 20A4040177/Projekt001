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
    public partial class frmStaffAdd : Form
    {
        int yearnow;
        
        
        public frmStaffAdd()
        {
            InitializeComponent();
        }

        private void keypress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
        
            {
                e.Handled = true;
            }
        }

        private void dtpDOB_ValueChanged(object sender, EventArgs e)
        {
            txtDOB.Text = dtpDOB.Value.ToString("yyyy/MM/dd");
            yearnow = DateTime.Now.Year;
            
        }

        private void frmStaffAdd_Load(object sender, EventArgs e)
        {
            txtDOB.Enabled = false;
            txtStaffID.MaxLength = 15;
            txtStaffName.MaxLength = 50;
            txtPhone.MaxLength = 11;
            txtAddress.MaxLength = 50;
            cboGender.Items.Add("Male");
            cboGender.Items.Add("Female");
            cboGender.Items.Add("Unidentified");
            cboGender.SelectedItem = "Unidentified";
            Functions.fillComboBox("select  ShiftID,ShiftName from tblWorkShift", cboShift, "ShiftID", "ShiftName");
            Functions.fillComboBox("select  PosID,PosName from tblPosition", cboPos, "PosID", "PosName");
            cboShift.SelectedIndex = -1;
            cboPos.SelectedIndex = -1;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string selectSQL;
            string insertSQL;
            if (txtStaffID.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter the Staff ID","Warning",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtStaffID.Focus();
                return;

            }
            if (txtStaffName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter the Staff name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtStaffName.Focus();
                return;

            }
            if (cboGender.SelectedIndex==-1)
            {
                MessageBox.Show("Please select your gender", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboGender.Focus();
                return;

            }
            if (txtDOB.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please validate your age", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtpDOB.Focus();
                return;

            }
            if (yearnow - dtpDOB.Value.Year < 18)
            {
                MessageBox.Show("Please confirm you are at least 18 years old", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtpDOB.Focus();
                return;
            }
            if (txtPhone.Text.Trim().Length==0)
            {
                MessageBox.Show("Please enter your phone number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPhone.Focus();
                return;

            }
            if (txtAddress.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter your Address", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAddress.Focus();
                return;

            }
            if (cboShift.SelectedIndex == -1)
            {
                MessageBox.Show("Please select your work shift", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboShift.Focus();
                return;

            }
            if (cboPos.SelectedIndex == -1)
            {
                MessageBox.Show("Please select your gender", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboPos.Focus();
                return;

            }
            selectSQL = "select * from tblStaff where StaffID='" + txtStaffID + "'";
            if (Functions.checkID(selectSQL) == true)
            {
                MessageBox.Show("ID already exists", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtStaffID.Focus();
                txtStaffID.Text = "";
                return;
            }
            insertSQL = "insert into tblStaff values('" + txtStaffID.Text.Trim() + "','" + txtStaffName.Text.Trim() + "','" + cboGender.SelectedItem.ToString() + "','" + dtpDOB.Value.ToString("yyyy/MM/dd") + "','" + txtAddress.Text.Trim() + "','" + txtPhone.Text.Trim() + "','" + cboShift.SelectedValue.ToString() + "','" + cboPos.SelectedValue.ToString() + "')";
            Functions.modifySQL(insertSQL);
            MessageBox.Show("Record saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            txtStaffID.Enabled = false;
            txtStaffName.Enabled = false;
            txtAddress.Enabled = false;
            txtPhone.Enabled = false;
            cboGender.Enabled = false;
            cboPos.Enabled = false;
            cboShift.Enabled = false;
            dtpDOB.Enabled = false;




        }
        private void resetValue()
        {
            txtStaffID.Text = "";
            txtStaffName.Text = "";
            txtAddress.Text = "";
            txtDOB.Text = "";
            txtPhone.Text = "";
            cboPos.SelectedIndex = -1;
            cboShift.SelectedIndex = -1;
            cboGender.SelectedItem = "Unidentified";

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            resetValue();
            txtStaffID.Focus();
        }

        private void formclosing(object sender, FormClosingEventArgs e)
        {
            var window = MessageBox.Show("Do you want to quit?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (window == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
