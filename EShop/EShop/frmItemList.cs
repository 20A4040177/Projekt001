using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace EShop
{
    public partial class frmItemList : Form
    {
        DataTable tblGridView;
        string imgPath;
        
        
        public frmItemList()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDetailItem_Click(object sender, EventArgs e)
        {
            frmItemListDetail ItemDetails = new frmItemListDetail();
            if (tblGridView.Rows.Count == 0)
            {
                MessageBox.Show("No record has been chosen", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Functions.fillComboBox("select CatID,CatName from tblCategory", ItemDetails.cboCatID, "CatID", "CatName");
            Functions.fillComboBox("select TypeID,TypeName from tblItemType", ItemDetails.cboTypeID, "TypeID", "TypeName");
            Functions.fillComboBox("select UnitID,UnitName from tblUnit", ItemDetails.cboUnitID, "UnitID", "UnitName");
            Functions.fillComboBox("select MatID,MatName from tblMaterial", ItemDetails.cboMatID, "MatID", "MatName");
            Functions.fillComboBox("select CountryID,CountryName from tblCountry",ItemDetails.cboCountryID, "CountryID", "CountryName");
           /* ItemDetails.cboCatID.SelectedIndex = -1;
            ItemDetails.cboTypeID.SelectedIndex = -1;
            ItemDetails.cboUnitID.SelectedIndex = -1;
            ItemDetails.cboMatID.SelectedIndex = -1;
            ItemDetails.cboCountryID.SelectedIndex = -1;*/
            //ItemDetails.cboCatID.SelectedValue = Functions.getFieldValues("select CatID from tblCategory where CatID is null");
           

            ItemDetails.txtItemID.Text = dgvItemList.CurrentRow.Cells["ItemID"].Value.ToString();
            ItemDetails.txtItemName.Text = dgvItemList.CurrentRow.Cells["ItemName"].Value.ToString();
            ItemDetails.txtQuantity.Text = dgvItemList.CurrentRow.Cells["Quantity"].Value.ToString();
            ItemDetails.txtWarranty.Text = dgvItemList.CurrentRow.Cells["Warranty"].Value.ToString();
            ItemDetails.cboCatID.Text = Functions.getFieldValues("select CatID from tblItemList where ItemID='" + ItemDetails.txtItemID.Text.Trim() + "'");
            ItemDetails.cboTypeID.Text = Functions.getFieldValues("select TypeID from tblItemList where ItemID='" + ItemDetails.txtItemID.Text.Trim() + "'");
            ItemDetails.cboUnitID.Text = Functions.getFieldValues("select UnitID from tblItemList where ItemID='" + ItemDetails.txtItemID.Text.Trim() + "'");
            ItemDetails.cboMatID.Text = Functions.getFieldValues("select MatID from tblItemList where ItemID='" + ItemDetails.txtItemID.Text.Trim() + "'");
            ItemDetails.cboCountryID.Text = Functions.getFieldValues("select CountryID from tblItemList where ItemID='" + ItemDetails.txtItemID.Text.Trim() + "'");
            ItemDetails.txtImUnitPrice.Text = Functions.getFieldValues("select ImUnitPrice from tblItemList where ItemID='" + ItemDetails.txtItemID.Text.Trim() + "'");
            ItemDetails.txtSaleUnitPrice.Text = Functions.getFieldValues("select SaleUnitPrice from tblItemList where ItemID='" + ItemDetails.txtItemID.Text.Trim() + "'");
            ItemDetails.txtNote.Text = Functions.getFieldValues("select Note from tblItemList where ItemID='" + ItemDetails.txtItemID.Text.Trim() + "'");
            //ItemDetails.txtImagePath.Text = Functions.getFieldValues("select ItemImage from tblItemList where ItemID='" + ItemDetails.txtItemID.Text.Trim() + "'");
            ItemDetails.ptbImage.SizeMode = PictureBoxSizeMode.StretchImage;
            imgPath = Functions.getFieldValues("select ItemImage from tblItemList where ItemID='" + ItemDetails.txtItemID.Text.Trim() + "'");
            if (imgPath != "")
            {
                ItemDetails.ptbImage.Image = Image.FromFile(imgPath);
            }
            ItemDetails.ShowDialog();


        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            frmItemListDetail ItemAdd = new frmItemListDetail();
            ItemAdd.hideEditButton();
            /*Functions.fillComboBox("select CatID,CatName from tblCategory", ItemAdd.cboCatID, "CatID", "CatName");
            Functions.fillComboBox("select TypeID,TypeName from tblItemType", ItemAdd.cboTypeID, "TypeID", "TypeName");
            Functions.fillComboBox("select UnitID,UnitName from tblUnit", ItemAdd.cboUnitID, "UnitID", "UnitName");
            Functions.fillComboBox("select MatID,MatName from tblMaterial", ItemAdd.cboMatID, "MatID", "MatName");
            Functions.fillComboBox("select CountryID,CountryName from tblCountry", ItemAdd.cboCountryID, "CountryID", "CountryName");*/
            ItemAdd.cboCatID.SelectedIndex = -1;
            ItemAdd.cboTypeID.SelectedIndex = -1;
            ItemAdd.cboUnitID.SelectedIndex = -1;
            ItemAdd.cboMatID.SelectedIndex = -1;
            ItemAdd.cboCountryID.SelectedIndex = -1;

            ItemAdd.ShowDialog();
           
         

            
            
            
        }
        private void loadDataGridView(string selectSQL)
        {
            //string selectSQL;
            //selectSQL = " select ItemID,ItemName,Quantity,Warranty from tblItemList";
            tblGridView = Functions.getDataToTable(selectSQL);
            dgvItemList.DataSource = tblGridView;
            dgvItemList.Columns[0].HeaderText = "Item ID";
            dgvItemList.Columns[1].HeaderText = "Item Name";
            dgvItemList.Columns[2].HeaderText = "Quantity";
            dgvItemList.Columns[3].HeaderText = "Warranty";
            dgvItemList.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvItemList.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvItemList.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvItemList.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvItemList.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvItemList.AllowUserToAddRows = false;



        }
        private void frmItemList_Load(object sender, EventArgs e)
        {
            loadDataGridView("select ItemID,ItemName,Quantity,Warranty from tblItemList");
            cboSearch.Items.Add("Search by");
            cboSearch.Items.Add("Category");
            cboSearch.Items.Add("Type");
            cboSearch.Items.Add("Warranty");
            cboSearch.SelectedItem = "Search by";
        }

        private void dgvItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            string deleteSQL1;
            string deleteSQL2;
            if (dgvItemList.Rows.Count==0)
            {
                MessageBox.Show("No records has been chosen!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            deleteSQL1 = "delete tblItemList where ItemID='" + dgvItemList.CurrentRow.Cells["ItemID"].Value.ToString() + "'";
            deleteSQL2 = "delete tblCalc where ItemID='" + dgvItemList.CurrentRow.Cells["ItemID"].Value.ToString() + "'";
            if (MessageBox.Show("Do you want to delete this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Functions.deleteSQL(deleteSQL2);
                Functions.deleteSQL(deleteSQL1);

                loadDataGridView("select ItemID,ItemName,Quantity,Warranty from tblItemList");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadDataGridView("select ItemID,ItemName,Quantity,Warranty from tblItemList");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cboSearch.SelectedIndex == -1 || cboSearch.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a search field", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtSearch.Text == "")
            {
                MessageBox.Show("Please enter a search value", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cboSearch.SelectedItem.ToString()=="Category")
            {

                if (Functions.checkID("select * from tblCategory where CatName='" + txtSearch.Text.Trim() + "'") == true)
                {
                    if (Functions.checkID("select ItemID,ItemName,Quantity,Warranty from tblItemList inner join tblCategory on tblItemList.CatID=tblCategory.CatID where CatName='" + txtSearch.Text.Trim() + "'") == true)
                    {
                        loadDataGridView("select ItemID,ItemName,Quantity,Warranty from tblItemList inner join tblCategory on tblItemList.CatID=tblCategory.CatID where CatName='" + txtSearch.Text.Trim() + "'");
                    }
                    else
                    {
                        MessageBox.Show("No record found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("No record found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            if (cboSearch.SelectedItem.ToString() == "Type")
            {
                if (Functions.checkID("select * from tblItemType where TypeName='" + txtSearch.Text.Trim() + "'") == true)
                {
                    if (Functions.checkID("select ItemID,ItemName,Quantity,Warranty from tblItemList inner join tblItemType on tblItemList.TypeID=tblItemType.TypeID where TypeName='" + txtSearch.Text.Trim() + "'") == true)
                    {
                        loadDataGridView("select ItemID,ItemName,Quantity,Warranty from tblItemList inner join tblItemType on tblItemList.CatID=tblItemType.CatID where TypeName='" + txtSearch.Text.Trim() + "'");
                    }
                    else
                    {
                        MessageBox.Show("No record found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("No record found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            if (cboSearch.SelectedItem.ToString() == "Warranty")
            {


                if (Functions.checkID("select * from tblItemList where Warranty>='" + txtSearch.Text.Trim() + "'") == true)
                {
                    if (Functions.checkID("select ItemID,ItemName,Quantity,Warranty from tblItemList where Warranty>='" + Convert.ToInt32(txtSearch.Text.Trim()) + "'") == true)
                    {
                        loadDataGridView("select ItemID,ItemName,Quantity,Warranty from tblItemList where Warranty>='" + Convert.ToInt32(txtSearch.Text.Trim()) + "'");
                    }
                    else
                    {
                        MessageBox.Show("No record found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("No record found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_keypress(object sender, KeyPressEventArgs e)
        {
            if (cboSearch.SelectedItem.ToString() == "Warranty")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
                {
                    e.Handled = true;
                }

                // only allow one decimal point
                /*if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                {
                    e.Handled = true;
                }*/
            }
        }

        private void cboSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }
    }
}
