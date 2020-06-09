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
    public partial class frmAddSaleInvoice : Form
    {

        //int unitPrice;
        //decimal totalPrice;
        DataTable tblGridView;
        decimal Price;
        decimal totalPrice;
        public frmAddSaleInvoice()
        {
            InitializeComponent();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmAddInvoice_Load(object sender, EventArgs e)
        {
            Functions.fillComboBox("select StaffID, StaffName from tblStaff", cboStaff, "StaffID", "StaffID");
            Functions.fillComboBox("select CustomerID, CustomerName from tblCustomer", cboCustomer, "CustomerID", "CustomerID");
            Functions.fillComboBox("select ItemID,ItemName from tblItemList where Quantity is not null", cboItem, "ItemID", "ItemID");
            txtInvoiceID.Enabled = false;
            txtDate.Enabled = false;
            txtDate.Text = DateTime.Now.ToString("yyyy/MM/dd");
            txtInvoiceID.Text = Functions.CreateKey("SL");
            
            cboStaff.SelectedIndex = -1;
            cboItem.SelectedIndex = -1;
           
            cboCustomer.SelectedIndex = -1;
            txtStaff.Enabled = false;
            txtCustomer.Enabled = false;
            txtAddress.Enabled = false;
            txtPhone.Enabled = false;
            txtItem.Enabled = false;
            txtTotalPrice.Enabled = false;
            txtPrice.Enabled = false;
            btnCancelCus.Enabled = false;
            btnSaveCus.Enabled = false;
            nbrQuantity.Minimum = 1;
            nbrQuantity.Maximum= Functions.getFieldValuesInt("select Quantity from tblItemList where ItemID='" + cboItem.Text.Trim() + "'");
            nbrDiscount.Minimum = 0;
            nbrDiscount.Maximum = 100;
            nbrUnitPrice.Enabled = false;
            nbrUnitPrice.Maximum = Decimal.MaxValue;
            
            nbrUnitPrice.Value= Convert.ToDecimal(Functions.getFieldValuesInt("select SaleUnitPrice from tblItemList where ItemID='" + cboItem.Text.Trim() + "'"));
            if (nbrQuantity.Value == 0)
            {
                btnAddItem.Enabled = false;
            }
            /*if (itemQuantity > 0)
            {
                nbrQuantity.Maximum = itemQuantity;
            }
            else nbrQuantity.Maximum = nbrQuantity.Minimum;*/
            
            //txtItem.Text = Functions.getFieldValues("select ItemName from tblItemList where ItemID='" + cboItem.Text.Trim() + "'");
            //txtStaff.Text = Functions.getFieldValues("select StaffName from tblStaff where StaffID='" + cboStaff.Text.Trim() + "'");
            //txtCustomer.Text = Functions.getFieldValues("select CustomerName from tblCustomer where CustomerID='" + cboCustomer.Text.Trim() + "'");
            //txtAddress.Text = Functions.getFieldValues("select CustomerAdd from  tblCustomer where CustomerID='" + cboCustomer.Text.Trim() + "'");
            //txtPhone.Text = Functions.getFieldValues("select CustomerTel from  tblCustomer where CustomerID='" + cboCustomer.Text.Trim() + "'");
          



        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void cboItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            nbrQuantity.Value = nbrQuantity.Minimum;
            txtItem.Text = Functions.getFieldValues("select ItemName from tblItemList where ItemID='" + cboItem.Text.Trim() + "'");
            nbrQuantity.Maximum = Functions.getFieldValuesInt("select Quantity from tblItemList where ItemID='" + cboItem.Text.Trim() + "'");
            nbrUnitPrice.Maximum = Decimal.MaxValue;
            nbrUnitPrice.Value = Convert.ToDecimal(Functions.getFieldValuesInt("select SaleUnitPrice from tblItemList where ItemID='" + cboItem.Text.Trim() + "'"));
            nbrDiscount.Value = 0;
            txtPrice.Text = "";

            //unitPrice =Functions.getFieldValuesInt("Select SaleUnitPrice from tblItemList where ItemID='" + cboItem.Text.Trim() + "' where SaleUnitPrice is not null");
            /*totalPrice = unitPrice * nbrQuantity.Value * (nbrDiscount.Value / 100);
            txtPrice.Text = totalPrice.ToString();*/
        }

        private void button4_Click(object sender, EventArgs e)
        {
            resetValueCus();
            btnSaveCus.Enabled = true;
            cboCustomer.Enabled = false;
            createCusID();
            txtCustomer.Enabled = true;
            txtAddress.Enabled = true;
            txtPhone.Enabled = true;
            btnCancelCus.Enabled = true;
            txtCustomer.MaxLength = 50;
            txtAddress.MaxLength = 50;
            txtPhone.MaxLength = 11;
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
        private void createCusID()
        {
            if (txtPhone.Text== "")
            {
                cboCustomer.Text =Functions.CreateKey("CU");
            }
            else cboCustomer.Text = "CU" + txtPhone.Text;
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            createCusID();
        }

        private void cboCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCustomer.Text = Functions.getFieldValues("select CustomerName from tblCustomer where CustomerID='" + cboCustomer.Text.Trim() + "'");
            txtAddress.Text = Functions.getFieldValues("select CustomerAdd from  tblCustomer where CustomerID='" + cboCustomer.Text.Trim() + "'");
            txtPhone.Text = Functions.getFieldValues("select CustomerTel from  tblCustomer where CustomerID='" + cboCustomer.Text.Trim() + "'");

        }

        private void cboStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtStaff.Text = Functions.getFieldValues("select StaffName from tblStaff where StaffID='" + cboStaff.Text.Trim() + "'");
        }

        private void nbrQuantity_ValueChanged(object sender, EventArgs e)
        {
            if (nbrQuantity.Value == 0)
            {
                btnAddItem.Enabled = false;
            }
            else btnAddItem.Enabled = true;
            if (nbrQuantity.Value > nbrDiscount.Maximum)
            {
                MessageBox.Show("Please enter a valid number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            Price = nbrUnitPrice.Value* nbrQuantity.Value*((100-nbrDiscount.Value)/100);
            txtPrice.Text = Price.ToString();
            /*totalPrice = unitPrice * nbrQuantity.Value * (nbrDiscount.Value / 100);
            txtPrice.Text = totalPrice.ToString();*/

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (nbrDiscount.Value > nbrDiscount.Maximum)
            {
                MessageBox.Show("Please enter a valid number","Warning",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            if (nbrQuantity.Value == 0)
            {
                MessageBox.Show("Please enter a valid number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string insertSQL;

            insertSQL = "update tblCalc set Quantity=" + nbrQuantity.Value + ",UnitPrice=" + nbrUnitPrice.Value + ",Discount=" + nbrDiscount.Value + ",TotalPrice=" + Price + ",InvoiceID='" + txtInvoiceID.Text.Trim() + "' where ItemID='" + cboItem.SelectedValue.ToString() +"'";
            Functions.modifySQL(insertSQL);

            loadDataGridView();
            txtTotalPrice.Text = Functions.getFieldValues("select sum(TotalPrice) from tblCalc where Quantity>0").ToString();

            




        }
        private void resetValueCus()
        {
            cboCustomer.SelectedIndex = -1;
            txtCustomer.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";
            txtCustomer.Enabled = false;
            txtAddress.Enabled = false;
            txtPhone.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string insertSQL;
            string selectSQL;
            
            if (txtCustomer.Text=="")
            {
                MessageBox.Show("Please enter Customer Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            selectSQL = "select * from tblCustomer where CustomerID='" + cboCustomer.Text.Trim() + "'";
            if (Functions.checkID(selectSQL) == true)
            {
                MessageBox.Show("ID already exists", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }

            insertSQL = "insert into tblCustomer values ('" + cboCustomer.Text.Trim() + "','" + txtCustomer.Text.Trim() + "','" + txtAddress.Text.Trim() + "','" + txtPhone.Text.Trim() + "')";
            Functions.modifySQL(insertSQL);
            btnSaveCus.Enabled = false;
            txtCustomer.Enabled = false;
            txtAddress.Enabled = false;
            txtPhone.Enabled = false;
            
            


        }

        private void btnCancelCus_Click(object sender, EventArgs e)
        {
            resetValueCus();
            cboCustomer.SelectedIndex = -1;
            cboCustomer.Enabled = true;
            btnSaveCus.Enabled = false;
            
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Close();

        }

        private void nbrDiscount_ValueChanged(object sender, EventArgs e)
        {
            /*totalPrice = unitPrice * nbrQuantity.Value * (nbrDiscount.Value / 100);
            txtPrice.Text = totalPrice.ToString();*/
            Price = nbrUnitPrice.Value * nbrQuantity.Value * ((100 - nbrDiscount.Value) / 100);
            txtPrice.Text = Price.ToString();
        }

        private void txtInvoiceID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
           
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
            if (cboCustomer.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a valid ID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboCustomer.Focus();
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
            if (txtTotalPrice.Text == "")
            {
                MessageBox.Show("No Data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string insertSQL1;
            string insertSQL2;
            insertSQL1 = "insert into tblSaleInvoice values('" + txtInvoiceID.Text.Trim() + "','" + cboStaff.SelectedValue.ToString() + "','" + txtDate.Text.Trim() + "','" + cboCustomer.Text + "'," + Convert.ToDouble(txtTotalPrice.Text.Trim()) + ")";
            insertSQL2 = "insert into tblSaleInvoiceDetail(InvoiceID,ItemID,Quantity,Discount,TotalPrice) select InvoiceID,ItemID,Quantity,Discount,TotalPrice from tblCalc where tblCalc.Quantity>0";
            Functions.modifySQL(insertSQL1);
            Functions.modifySQL(insertSQL2);
            btnSave.Enabled = false;
        }

        private void formclosing(object sender, FormClosingEventArgs e)
        {
            var window = MessageBox.Show("Do you want to quit?", "Warning", MessageBoxButtons.YesNo,MessageBoxIcon.Information);
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