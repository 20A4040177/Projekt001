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
    public partial class frmItemListDetail : Form
    {
        string imgPath;
        public frmItemListDetail()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }
        

        private void frmItemListDetail_Load(object sender, EventArgs e)
        {
            txtQuantity.Enabled = false;
            txtImUnitPrice.Enabled = false;
            txtSaleUnitPrice.Enabled = false;
            txtQuantity.Enabled = false;
            ptbImage.SizeMode = PictureBoxSizeMode.StretchImage;
            Functions.fillComboBox("select CatID,CatName from tblCategory", cboCatID, "CatID", "CatName");
            Functions.fillComboBox("select TypeID,TypeName from tblItemType", cboTypeID, "TypeID", "TypeName");
            Functions.fillComboBox("select UnitID,UnitName from tblUnit", cboUnitID, "UnitID", "UnitName");
            Functions.fillComboBox("select MatID,MatName from tblMaterial", cboMatID, "MatID", "MatName");
            Functions.fillComboBox("select CountryID,CountryName from tblCountry", cboCountryID, "CountryID", "CountryName");
            
            
            /*cboCatID.SelectedIndex = -1;
            cboTypeID.SelectedIndex = -1;
            cboUnitID.SelectedIndex = -1;
            cboMatID.SelectedIndex = -1;
            cboCountryID.SelectedIndex = -1;*/
            
            if (btnEdit.Visible == true)
            {
                btnCancel.Enabled = false;
                btnSave.Enabled = false;
                txtItemID.Enabled = false;
                txtItemName.Enabled = false;
                txtWarranty.Enabled = false;
                txtNote.Enabled = false;
                cboCatID.Enabled = false;
                cboCountryID.Enabled = false;
                cboMatID.Enabled = false;
                cboTypeID.Enabled = false;
                cboUnitID.Enabled = false;
                btnSave.Enabled = false;
                btnCancel.Enabled = false;
                btnSelect.Enabled = false;
                imgPath = Functions.getFieldValues("select ItemImage from tblItemList where ItemID='" + txtItemID.Text.Trim() + "'");
                cboCatID.Text=Functions.getFieldValues("select CatName from tblItemList inner join tblCategory on tblCategory.CatID=tblItemList.CatID where ItemID='" + txtItemID.Text.Trim() + "'");
                cboCountryID.Text = Functions.getFieldValues("select CountryName from tblItemList inner join tblCountry on tblCountry.CountryID=tblItemList.CountryID where ItemID='" + txtItemID.Text.Trim() + "'");
                cboMatID.Text = Functions.getFieldValues("select MatName from tblItemList inner join tblMaterial on tblMaterial.MatID=tblItemList.MatID where ItemID='" + txtItemID.Text.Trim() + "'");
                cboTypeID.Text = Functions.getFieldValues("select TypeName from tblItemList inner join tblItemType on tblItemType.TypeID=tblItemList.TypeID where ItemID='" + txtItemID.Text.Trim() + "'");
                cboUnitID.Text = Functions.getFieldValues("select UnitName from tblItemList inner join tblUnit on tblUnit.UnitID=tblItemList.UnitID where ItemID='" + txtItemID.Text.Trim() + "'");

            }
            else
            {
                btnCancel.Enabled = true;
                btnSave.Enabled = true;
                txtItemID.Enabled =true;
                cboCatID.Enabled = true;
                cboCountryID.Enabled = true;
                cboMatID.Enabled = true;
                cboTypeID.Enabled = true;
                cboUnitID.Enabled = true;
                ptbImage.Image = Image.FromFile("D:\\shopImage\\default-thumb.png");
            }
            

        }
        public void hideEditButton()
        {
            btnEdit.Visible = false;
        }
 
    
       
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnCancel.Enabled = true;
            btnSave.Enabled = true;
            txtItemName.Enabled = true;
            cboCatID.Enabled = true;
            cboCountryID.Enabled = true;
            cboMatID.Enabled = true;
            cboTypeID.Enabled = true;
            cboUnitID.Enabled = true;
            txtItemID.Enabled = false;
            txtWarranty.Enabled = true;
            txtNote.Enabled = true;
            btnSelect.Enabled = true;
        }

        private void ptbImage_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string insertSQL;
            
            string selectSQL;
            selectSQL = "select ItemID from tblItemList where ItemID='" + txtItemID.Text.Trim() + "'";
            string updateSQL;
            if (txtWarranty.Text == "")
            {
                MessageBox.Show("You need to enter the Item warranty time", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtWarranty.Focus();
                return;
            }

            if (txtItemID.Enabled==true)
            {
                if (txtItemID.Text == "")
                {
                    MessageBox.Show("You need to enter the Item ID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtItemID.Focus();
                    return;
                }
                if (txtItemName.Text == "")
                {
                    MessageBox.Show("You need to enter the Item name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtItemName.Focus();
                    return;
                }
                if (cboCatID.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a valid ID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboCatID.Focus();
                    return;
                }
                if (cboUnitID.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a valid ID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboUnitID.Focus();
                    return;
                }
                if (cboCountryID.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a valid ID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboCountryID.Focus();
                    return;
                }
                if (cboMatID.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a valid ID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboMatID.Focus();
                    return;
                }
                if (cboTypeID.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a valid ID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboTypeID.Focus();
                    return;
                }
                if (Functions.checkID(selectSQL) == true)
                {
                    MessageBox.Show("ID already exists", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtItemID.Text = "";
                    txtItemID.Focus();
                    return;
                }
                insertSQL = "insert into tblItemList(ItemID,ItemName,CatID,TypeID,UnitID,MatID,CountryID,ItemImage,Warranty) values ('" + txtItemID.Text.Trim() + "','" + txtItemName.Text.Trim() + "','" + cboCatID.SelectedValue.ToString().Trim() + "','" + cboTypeID.SelectedValue.ToString().Trim() + "','" + cboUnitID.SelectedValue.ToString().Trim() + "','" + cboMatID.SelectedValue.ToString().Trim() + "','" + cboCountryID.SelectedValue.ToString().Trim() + "','" + imgPath +"',"+Convert.ToInt32(txtWarranty.Text)+ ")";
                Functions.modifySQL(insertSQL);
                Functions.modifySQL("insert into tblCalc(ItemID) values('" + txtItemID.Text.Trim() + "')");

            }
            if (txtItemID.Enabled == false)
            {
                if (txtItemName.Text == "")
                {
                    MessageBox.Show("Please enter Item name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtItemName.Focus();
                    return;
                }
                if (cboCatID.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a valid ID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboCatID.Focus();
                    return;
                }
                if (cboUnitID.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a valid ID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboUnitID.Focus();
                    return;
                }
                if (cboCountryID.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a valid ID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboCountryID.Focus();
                    return;
                }
                if (cboMatID.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a valid ID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboMatID.Focus();
                    return;
                }
                if (cboTypeID.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a valid ID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboTypeID.Focus();
                    return;
                }
                if (imgPath == "")
                {
                    imgPath = Functions.getFieldValues("select ItemImage from tblItemList where ItemID='" + txtItemID.Text.Trim() + "'");
                }
                
                //updateSQL = "update table tblItemList set ItemName='" + txtItemName.Text.Trim() + "',CatID='" + cboCatID.SelectedValue.ToString().Trim() + "', UnitID='" + cboUnitID.SelectedValue.ToString().Trim() + "',MatID='" + cboMatID.SelectedValue.ToString().Trim() + "',CountryID='" + cboCountryID.SelectedValue.ToString().Trim() + "',TypeID='" + cboTypeID.SelectedValue.ToString().Trim() + "',Quantity=" + txtQuantity.Text + ",ImUnitPrice=" + txtImUnitPrice.Text + ",SaleUnitPrice=" + txtSaleUnitPrice.Text + ",Warranty=" + txtWarranty.Text + "',Note='" + txtNote.Text.Trim() + "',ItemImage='" + imgPath + "' where ItemID='"+txtItemID.Text.Trim()+"'";
                //updateSQL="update table tblItemList set ItemName='"+txtItemName.Text.Trim()+"', CatID='"+cboCatID.SelectedValue.ToString().Trim()+"',TypeID='"+cboTypeID.SelectedValue.ToString().Trim()+"',UnitID='"+cboUnitID.SelectedValue.ToString().Trim()+"',MatID='"+cboMatID.SelectedValue.ToString()+"',CountryID='"+cboCountryID.SelectedValue.ToString()+"',Quantity="+txtQuantity.Text+",ImUnitPrice="+txtImUnitPrice+",SaleUnitPrice="+txtSaleUnitPrice.Text+",Warranty="+txtWarranty+",Note='"+txtNote.Text.Trim()+"',ItemImage='"+imgPath+"' where ItemID='"+txtItemID.Text.Trim()+"'";
                updateSQL = "update tblItemList set ItemName='" + txtItemName.Text.Trim() + "',CatID='" + cboCatID.SelectedValue.ToString().Trim() + "',TypeID='" + cboTypeID.SelectedValue.ToString().Trim() + "',UnitID='" + cboUnitID.SelectedValue.ToString().Trim() + "',MatID='" + cboMatID.SelectedValue.ToString().Trim() + "',CountryID='" + cboCountryID.SelectedValue.ToString()  +"',ItemImage='" + imgPath+ "', Warranty="+Convert.ToInt32(txtWarranty.Text.Trim())+"where ItemID='" + txtItemID.Text.Trim() + "'"; //",ImUnitPrice=" + txtImUnitPrice.Text + ",SaleUnitPrice=" + txtSaleUnitPrice.Text + ",Warranty=" + txtWarranty.Text + ",Note='" + txtNote.Text.Trim() /*+ */ + "' where ItemID='" + txtItemName.Text.Trim() + "'";

                Functions.modifySQL(updateSQL);
                
            }
            btnCancel.Enabled = false;
            btnSave.Enabled = false;
            txtItemID.Enabled = false;
            txtItemName.Enabled = false;
            txtWarranty.Enabled = false;
            txtNote.Enabled = false;
            cboCatID.Enabled = false;
            cboCountryID.Enabled = false;
            cboMatID.Enabled = false;
            cboTypeID.Enabled = false;
            cboUnitID.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnSelect.Enabled = false;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Bitmap(*.bmp)|*.bmp|Gif(*.gif)|*.gif|All files(*.*)|*.*|PNG(*.png)|*.png|JPG(*.jpg)|*.jpg|jpeg(*.jpeg)|*.jpeg";
            dlgOpen.InitialDirectory = "D:\\shopImage";
            dlgOpen.FilterIndex = 3;
            dlgOpen.Title = "Select an image";
            //dlgOpen.CheckFileExists = true;
            //dlgOpen.CheckPathExists = true;
            //dlgOpen.RestoreDirectory = true;


            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {


                imgPath = dlgOpen.FileName;
                ptbImage.Image = Image.FromFile(imgPath);

            }

            else if (dlgOpen.ShowDialog()==DialogResult.Cancel)
            {
                if (btnEdit.Visible == true)
                {
                    imgPath = Functions.getFieldValues("select ItemImage from tblItemList where ItemID='" + txtItemID.Text.Trim() + "'");
                    ptbImage.Image = Image.FromFile(imgPath);
                }
                else if (btnEdit.Visible == false)
                {
                    imgPath = ("D:\\shopImage\\default-thumb.png");
                    ptbImage.Image = Image.FromFile(imgPath);
                }

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            resetValue();
            if (btnEdit.Visible == false) 
            {
                txtItemID.Text = "";
            }
        }
        private void resetValue()
        {
            
            txtItemName.Text = "";
            cboCatID.SelectedIndex = -1;
            cboTypeID.SelectedIndex = -1;
            cboUnitID.SelectedIndex = -1;
            cboMatID.SelectedIndex = -1;
            cboCountryID.SelectedIndex = -1;
            txtWarranty.Text = "";
            txtNote.Text = "";
            btnCancel.Enabled = false;
        }

        private void txtWarranty_keypress(object sender, KeyPressEventArgs e)
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
