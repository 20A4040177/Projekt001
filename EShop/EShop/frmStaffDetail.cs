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
    public partial class frmStaffDetail : Form
    {
        public frmStaffDetail()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void hideEditButtonStaff()
        {
            btnEdit.Visible = false;
        }

        private void txtPhone_keypress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void frmStaffDetail_Load(object sender, EventArgs e)
        {
            btnCancel.Enabled = false;
            btnSave.Enabled = false;

          
            txtStaffID.Enabled = false;
            txtStaffName.Enabled = false;
            txtAddress.Enabled = false;
            txtDOB.Enabled = false;
            txtPhone.Enabled = false;
            cboGender.Enabled = false;
            cboPos.Enabled = false;
            cboShift.Enabled = false;
            dtpDOB.Enabled = false;
            txtStaffName.Text = Functions.getFieldValues("select StaffName from tblStaff where StaffID='" + txtStaffID.Text.Trim() + "'");
            cboGender.Text = Functions.getFieldValues("select Gender from tblStaff where StaffID='" + txtStaffID.Text.Trim() + "'");
            txtDOB.Text = Functions.getFieldValues("select DOB from tblStaff where StaffID='" + txtStaffID.Text.Trim() + "'");
            txtPhone.Text = Functions.getFieldValues("select StaffTel from tblStaff where StaffID='" + txtStaffID.Text.Trim() + "'");
            txtAddress.Text = Functions.getFieldValues("select StaffAdd from tblStaff where StaffID='" + txtStaffID.Text.Trim() + "'");
            cboPos.Text = Functions.getFieldValues("select PosID from tblStaff where StaffID='" + txtStaffID.Text.Trim() + "'");
            cboShift.Text = Functions.getFieldValues("select ShiftID from tblStaff where StaffID='" + txtStaffID.Text.Trim() + "'");

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnCancel.Enabled = true;
            btnSave.Enabled = true;
            txtStaffID.MaxLength = 15;
            txtAddress.MaxLength = 50;
            txtPhone.MaxLength = 11;
            txtStaffName.MaxLength = 50;
            
            txtStaffName.Enabled = true;
            txtAddress.Enabled = true;
            txtPhone.Enabled = true;
            cboGender.Enabled = true;
            cboPos.Enabled = true;
            cboShift.Enabled = true;
            dtpDOB.Enabled = true;
            cboGender.Items.Add("Male");
            cboGender.Items.Add("Female");
            cboGender.Items.Add("Unidentified");
            Functions.fillComboBox("select ShiftID,ShiftName from tblWorkShift",cboShift,"ShiftID","ShiftName");
            Functions.fillComboBox("select PosID,PosName from tblPosition", cboPos, "PosID", "PosName");

            
        }

        private void dtpDOB_ValueChanged(object sender, EventArgs e)
        {
            int yearnow;
            yearnow = DateTime.Now.Year;
            txtDOB.Text = dtpDOB.Value.ToString("yyyy/MM/dd");
            if (yearnow - dtpDOB.Value.Year < 18)
            {
                MessageBox.Show("Please confirm you are at least 18 years old", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtpDOB.Focus();
                
                return;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int yearnow;
            yearnow = DateTime.Now.Year;
            string updateSQL;
            
            if (txtStaffID.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter the Staff ID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtStaffID.Focus();
                return;

            }
            if (txtStaffName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter the Staff name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtStaffName.Focus();
                return;

            }
            if (cboGender.SelectedIndex == -1)
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
            /*if (yearnow - dtpDOB.Value.Year < 18)
            {
                MessageBox.Show("Please confirm you are at least 18 years old", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtpDOB.Focus();
                return;
            }*/
            if (txtPhone.Text.Trim().Length == 0)
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
            updateSQL = "update tblStaff set StaffName='" + txtStaffName.Text.Trim() + "',Gender='" + cboGender.SelectedItem.ToString() + "',DOB='" + txtDOB.Text + "',StaffAdd='" + txtAddress.Text.Trim() + "',StaffTel='" + txtPhone.Text.Trim() + "',ShiftID='" + cboShift.SelectedValue.ToString() + "',PosID='" + cboPos.SelectedValue.ToString() + "' where StaffID='" + txtStaffID.Text.Trim() + "'";
            Functions.modifySQL(updateSQL);
            btnCancel.Enabled = false;
            btnSave.Enabled = false;


            txtStaffID.Enabled = false;
            txtStaffName.Enabled = false;
            txtAddress.Enabled = false;
            txtDOB.Enabled = false;
            txtPhone.Enabled = false;
            cboGender.Enabled = false;
            cboPos.Enabled = false;
            cboShift.Enabled = false;
            dtpDOB.Enabled = false;
            MessageBox.Show("Record saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnCancel.Enabled = false;
            btnSave.Enabled = false;


            txtStaffID.Enabled = false;
            txtStaffName.Enabled = false;
            txtAddress.Enabled = false;
            txtDOB.Enabled = false;
            txtPhone.Enabled = false;
            cboGender.Enabled = false;
            cboPos.Enabled = false;
            cboShift.Enabled = false;
            dtpDOB.Enabled = false;
            txtStaffName.Text = Functions.getFieldValues("select StaffName from tblStaff where StaffID='" + txtStaffID.Text.Trim() + "'");
            cboGender.Text = Functions.getFieldValues("select Gender from tblStaff where StaffID='" + txtStaffID.Text.Trim() + "'");
            txtDOB.Text = Functions.getFieldValues("select DOB from tblStaff where StaffID='" + txtStaffID.Text.Trim() + "'");
            txtPhone.Text = Functions.getFieldValues("select StaffTel from tblStaff where StaffID='" + txtStaffID.Text.Trim() + "'");
            txtAddress.Text = Functions.getFieldValues("select StaffAdd from tblStaff where StaffID='" + txtStaffID.Text.Trim() + "'");
            cboPos.Text = Functions.getFieldValues("select PosID from tblStaff where StaffID='" + txtStaffID.Text.Trim() + "'");
            cboShift.Text = Functions.getFieldValues("select ShiftID from tblStaff where StaffID='" + txtStaffID.Text.Trim() + "'");
        }

        private void formclosing(object sender, FormClosingEventArgs e)
        {
            var window = MessageBox.Show("Do you want to quit?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (window == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
