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
    public partial class frmAddImInvoice : Form
    {
        DataTable tblGridView;
        
        public frmAddImInvoice()
        {
            InitializeComponent();
        }

        private void btnNewItem_Click(object sender, EventArgs e)
        {
            frmItemListDetail ItemDetail = new frmItemListDetail();
            ItemDetail.hideEditButton();
            ItemDetail.ShowDialog();
            btnRefresh.Enabled = true;
        }

        private void frmAddImInvoice_Load(object sender, EventArgs e)
        {
            string updateSQL;
            updateSQL = "update tblCalc set Quantity=0,Discount=0,UnitPrice=0,TotalPrice=0 where ItemID is not null";
            Functions.modifySQL(updateSQL);
            
            txtInvoiceID.Enabled = false;
            txtInvoiceID.Text = Functions.CreateKey("IM");
            txtDate.Enabled = false;
            txtDate.Text = DateTime.Now.ToString("yyyy/MM/dd");
            txtStaff.Enabled = false;
            Functions.fillComboBox("select StaffID, StaffName from tblStaff", cboStaff, "StaffID", "StaffID");
            //cboStaff.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStaff.SelectedIndex = -1;
            //txtStaff.Text = Functions.getFieldValues("select StaffName from tblStaff where StaffID='" + cboStaff.SelectedValue.ToString().Trim() + "'");
            Functions.fillComboBox("select SupplierID,SupplierName from tblSupplier",cboSupplier,"SupplierID","SupplierID");
            //cboSupplier.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSupplier.SelectedIndex = -1;
            //txtSupplier.Text=Functions.getFieldValues("select SupplierName from tblSupplier where SupplierID='"+cboSupplier.SelectedValue.ToString().Trim()+"'");
            txtSupplier.Enabled=false;
            txtAddress.Enabled = false;
            txtPhone.Enabled = false;
            btnCancelSup.Enabled = false;
            btnSaveSup.Enabled = false;
            //cboItem.DropDownStyle = ComboBoxStyle.DropDownList;
            cboItem.SelectedIndex = -1;
            Functions.fillComboBox("select ItemID, ItemName from tblItemList", cboItem, "ItemID", "ItemID");
            //txtItem.Text = Functions.getFieldValues("select ItemName from tblItemList where ItemID='" + cboItem.SelectedValue.ToString().Trim() + "'");
            txtItem.Enabled = false;
            nbrQuantity.Minimum = 1;
            nbrQuantity.Maximum = 999;
            nbrDiscount.Minimum = 0;
            nbrDiscount.Maximum = 100;
            nbrUnitPrice.Maximum = decimal.MaxValue;
            txtPrice.Text = calcTotalPrice().ToString();
            txtTotalPrice.Text = Functions.getFieldValues("select sum(TotalPrice) from tblCalc where Quantity>0").ToString();
            /*txtTotalPrice.Text = dgvItem.CurrentRow.Cells["TotalPrice"].Value.ToString();
            dgvItem.Rows.Cells["TotalPrice"].Value.ToString();*/
            txtPrice.Enabled = false;
            txtTotalPrice.Enabled = false;
            btnRemove.Enabled = false;
            btnRefresh.Enabled = false;
            btnSave.Enabled = false;
            btnDone.Enabled = false;
            btnCancelDGV.Enabled = false;
            btnRemove.Enabled = false;
            //txtSupplier.Text = "";
            
            
            


           

        }
        private void loadDataGridView()
        {
            string selectSQL;
            selectSQL = " select ItemID,Quantity,UnitPrice,Discount,TotalPrice from tblCalc where Quantity>0";
            tblGridView = Functions.getDataToTable(selectSQL);
            dgvItem.DataSource = tblGridView;
            dgvItem.Columns[0].HeaderText = "Item";
            dgvItem.Columns[1].HeaderText = "Quantity";
            dgvItem.Columns[2].HeaderText = "Unit Price";
            dgvItem.Columns[3].HeaderText = "Discount";
            dgvItem.Columns[4].HeaderText = "Total Price";
           /* dgvItem.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvItem.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvItem.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvItem.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvItem.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;*/
            dgvItem.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvItem.AllowUserToAddRows = false;

            
            
        }
        private void resetValuesSup()
        {
            //cboSupplier.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSupplier.Enabled = true;
            txtSupplier.Enabled = false;
            txtAddress.Enabled=false;
            txtPhone.Enabled=false;
            btnSaveSup.Enabled=false;
            btnCancelSup.Enabled = false;


        }

        private void cboSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSupplier.SelectedIndex != -1)
            {
                txtSupplier.Text = Functions.getFieldValues("select SupplierName from tblSupplier where SupplierID='" + cboSupplier.SelectedValue.ToString().Trim() + "'");
                txtAddress.Text = Functions.getFieldValues("select SupplierAdd from tblSupplier where SupplierID='" + cboSupplier.SelectedValue.ToString().Trim() + "'");
                txtPhone.Text = Functions.getFieldValues("select SupplierTel from tblSupplier where SupplierID='" + cboSupplier.SelectedValue.ToString().Trim() + "'");
            }
            else txtSupplier.Text = "";
        }
              

        private void cboStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboStaff.SelectedIndex != -1)
            {
                txtStaff.Text = Functions.getFieldValues("select StaffName from tblStaff where StaffID='" + cboStaff.SelectedValue.ToString().Trim() + "'");
            }
            else txtStaff.Text = "";
            
        }

        private void btnNewCus_Click(object sender, EventArgs e)
        {
            //cboSupplier.DropDownStyle = ComboBoxStyle.DropDown;
            cboSupplier.Enabled = false;
            cboSupplier.Text = Functions.CreateKey("SUP");
            txtSupplier.Enabled = true;
            txtSupplier.Text = "";
            txtPhone.Enabled = true;
            txtPhone.Text = "";
            txtAddress.Enabled = true;
            txtAddress.Text = "";
            txtSupplier.Focus();
            btnSaveSup.Enabled = true;
            btnCancelSup.Enabled = true;
            txtAddress.MaxLength = 50;
            txtSupplier.MaxLength = 50;
            txtPhone.MaxLength = 11;
            btnNewItem.Enabled = false;
            btnAddItem.Enabled = false;
            cboItem.Enabled = false;
            nbrDiscount.Enabled = false;
            nbrQuantity.Enabled = false;
            nbrUnitPrice.Enabled = false;
            
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            if (txtPhone.Text == "")
            {
                cboSupplier.Text = Functions.CreateKey("SP");
            }
            else cboSupplier.Text = "SP" + txtPhone.Text;
        }

        private void btnCancelSup_Click(object sender, EventArgs e)
        {
            resetValuesSup();
            btnNewItem.Enabled = true;
            btnAddItem.Enabled = true;
            cboSupplier.Text = "";
            cboItem.Enabled = true;
            nbrDiscount.Enabled = true;
            nbrQuantity.Enabled = true;
            nbrUnitPrice.Enabled = true;
        }

        private void btnSaveSup_Click(object sender, EventArgs e)
        {
            if (txtSupplier.Text == "")
            {
                MessageBox.Show("Please enter Supplier Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSupplier.Focus();
                return;
            }
            if(txtPhone.Text=="")
            {
                MessageBox.Show("Please enter Supplier Phone number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPhone.Focus();
                return;
            }
            string selectSQL = "select * from tblSupplier where SupplierID='" + cboSupplier.Text.Trim() + "'";
            if (Functions.checkID(selectSQL) == true)
            {

                cboSupplier.Text = Functions.CreateKey("SP");
            }
            string insertSQL;
            insertSQL = "insert into tblSupplier values('" + cboSupplier.Text.Trim() + "','" + txtSupplier.Text.Trim() + "','" + txtAddress.Text.Trim() + "','" + txtPhone.Text.Trim() + "')";
            Functions.modifySQL(insertSQL);
            Functions.fillComboBox("select SupplierID,SupplierName from tblSupplier", cboSupplier, "SupplierID", "SupplierID");
            cboSupplier.Enabled = true;
            txtSupplier.Enabled = false;
            txtPhone.Enabled = false;
            txtAddress.Enabled = false;
            btnSaveSup.Enabled = false;
            btnNewSup.Enabled = true;
            btnCancelSup.Enabled = false;
            btnNewItem.Enabled = true;
            btnAddItem.Enabled = true;
            cboItem.Enabled = true;
            nbrDiscount.Enabled = true;
            nbrQuantity.Enabled = true;
            nbrUnitPrice.Enabled = true;
        }

        private void cboItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            nbrDiscount.Value = nbrDiscount.Minimum;
            nbrQuantity.Value = nbrQuantity.Minimum;
            nbrUnitPrice.Value = nbrUnitPrice.Minimum;
            if (cboItem.SelectedIndex != -1)
            {
                txtItem.Text = Functions.getFieldValues("select ItemName from tblItemList where ItemID='" + cboItem.SelectedValue.ToString().Trim() + "'");
            }
            else txtItem.Text = "";

            
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Functions.fillComboBox("select ItemID, ItemName from tblItemList", cboItem, "ItemID", "ItemID");
            nbrQuantity.Value=nbrQuantity.Minimum;
            nbrDiscount.Value=nbrDiscount.Minimum;
            nbrUnitPrice.Value=0;
        }
        private double calcTotalPrice()
        {
            double price;
            price = Convert.ToDouble(nbrQuantity.Value * nbrUnitPrice.Value * ((100 - nbrDiscount.Value) / 100));
            return price;
            

        }

        private void nbrUnitPrice_ValueChanged(object sender, EventArgs e)
        {
            txtPrice.Text = calcTotalPrice().ToString();
        }

        private void nbrQuantity_ValueChanged(object sender, EventArgs e)
        {
            txtPrice.Text = calcTotalPrice().ToString();
        }

        private void nbrDiscount_ValueChanged(object sender, EventArgs e)
        {
            txtPrice.Text = calcTotalPrice().ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string insertSQL;
            string updateSQL;
            string selectSQL;
            selectSQL="select * from tblCalc where ItemID='"+cboItem.SelectedValue.ToString().Trim()+"'";
            updateSQL = "update tblCalc set Quantity=" + nbrQuantity.Value + "," + "UnitPrice=" + nbrUnitPrice.Value + "," + "Discount=" + nbrDiscount.Value + "," + "TotalPrice=" + calcTotalPrice() +","+"InvoiceID='"+txtInvoiceID.Text.Trim()+ "' where ItemID='" + cboItem.SelectedValue.ToString().Trim() + "'";

            insertSQL = "insert into tblCalc(ItemID,Quantity,UnitPrice,Discount,TotalPrice,InvoiceID) values('"+cboItem.SelectedValue.ToString().Trim()+"'," + nbrQuantity.Value + "," + nbrUnitPrice.Value + "," + nbrDiscount.Value + "," + calcTotalPrice() +",'"+txtInvoiceID.Text.Trim()+ "')";
            if (Functions.checkID(selectSQL) == true)
            {
                Functions.modifySQL(updateSQL);
            }
            else Functions.modifySQL(insertSQL);
            txtTotalPrice.Text = Functions.getFieldValues("select sum(TotalPrice) from tblCalc where Quantity>0").ToString();
            loadDataGridView();
            btnDone.Enabled = true;
            btnRemove.Enabled = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string currentCellID;
            currentCellID = dgvItem.CurrentRow.Cells["ItemID"].Value.ToString();
            string updateSQL = "update tblCalc set Quantity=0 where ItemID='" + currentCellID + "'";
            Functions.modifySQL(updateSQL);
            loadDataGridView();
            txtTotalPrice.Text = Functions.getFieldValues("select sum(TotalPrice) from tblCalc where Quantity>0").ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (cboSupplier.SelectedIndex==-1&&cboSupplier.Text=="")
            {
                MessageBox.Show("Please select a valid ID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboSupplier.Focus();
                return;
            }
            if (cboStaff.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a valid ID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboStaff.Focus();
                return;
            }
            if (cboItem.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a valid ID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboItem.Focus();
                return;
            }
            if (txtTotalPrice.Text=="")
            {
                MessageBox.Show("No Data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string insertSQL1;
            string insertSQL2;
            insertSQL1="insert into tblImInvoice values('"+txtInvoiceID.Text.Trim()+"','"+cboStaff.SelectedValue.ToString()+"','"+txtDate.Text.Trim()+"','"+cboSupplier.Text+"',"+Convert.ToDouble(txtTotalPrice.Text.Trim())+")";
            insertSQL2 = "insert into tblImInvoiceDetail(InvoiceID,ItemID,Quantity,UnitPrice,Discount,TotalPrice) select InvoiceID,ItemID,Quantity,UnitPrice,Discount,TotalPrice from tblCalc where tblCalc.Quantity>0";
            Functions.modifySQL(insertSQL1);
            Functions.modifySQL(insertSQL2);
            btnSave.Enabled = false;
            cboItem.Enabled = false;
            nbrDiscount.Enabled = false;
            nbrQuantity.Enabled = false;
            nbrUnitPrice.Enabled = false;
            btnRemove.Enabled = false;
            btnDone.Enabled = false;
            
            
        }

        private void dgvItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnRemove.Enabled = true;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            dgvItem.Enabled = false;
            btnSave.Enabled = true;
            btnCancelDGV.Enabled = true;
            btnRemove.Enabled = false;

        }

        private void btnCancelDGV_Click(object sender, EventArgs e)
        {
            dgvItem.Enabled = true;
            btnDone.Enabled = true;
            btnRemove.Enabled = true;
            btnSave.Enabled = false;
        }

        private void txtPhone_keypress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            /*if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }*/
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void formclosing(object sender, FormClosingEventArgs e)
        {
            var window = MessageBox.Show("Do you want to quit?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (window == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                string updateSQL;
                updateSQL = "update tblCalc set Quantity=0,Discount=0,UnitPrice=0,TotalPrice=0 where ItemID is not null";
                Functions.modifySQL(updateSQL);
            }
        }

    }
}
