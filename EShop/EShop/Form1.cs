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
    public partial class frmMainPage : Form
    {
        public frmMainPage()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            pnlSelect.Visible = true;
            movePlnSelect(btnType);
            openChildForm(new frmItemType());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pnlSelect.Visible = true;
            movePlnSelect(btnSaleInvoice);
            openChildForm(new frmSaleInvoice());
        }

        private void plnMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCat_Click(object sender, EventArgs e)
        {
            pnlSelect.Visible = true;
            //pnlDashboard.Visible = false;
            openChildForm(new frmCategory());
            movePlnSelect(btnCat);
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlChildForm.Controls.Add(childForm);
            childForm.BringToFront();
            
            childForm.Show();
        }
        private void openGrandchildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlGrandchildForm.Controls.Add(childForm);
            childForm.BringToFront();

            childForm.Show();
        }
        private void movePlnSelect(Control btn)
        {
            pnlSelect.Top = btn.Top;
            pnlSelect.Height = btn.Height;
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            if (pnlMenu.Width == 250)
            {
                pnlMenu.Width = 50;
            }
            else pnlMenu.Width = 250;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlSelect.Visible = true;
            movePlnSelect(btnItemList);
            openChildForm(new frmItemList());
        }

        private void frmMainPage_Load(object sender, EventArgs e)
        {
            Functions.Connect();
        }

        private void btnUnit_Click(object sender, EventArgs e)
        {
            pnlSelect.Visible = true;
            movePlnSelect(btnUnit);
            openChildForm(new frmUnit());
        }

        private void btnMaterial_Click(object sender, EventArgs e)
        {
            pnlSelect.Visible = true;
            movePlnSelect(btnMaterial);
            openChildForm(new frmMaterial());
        }

        private void btnCountry_Click(object sender, EventArgs e)
        {
            pnlSelect.Visible = true;
            movePlnSelect(btnCountry);
            openChildForm(new frmCountry());
        }
        private void btnCustomer_CLick(object sender, EventArgs e)
        {
            
        }

        private void btnImInvoice_Click(object sender, EventArgs e)
        {
            pnlSelect.Visible = true;
            movePlnSelect(btnImInvoice);
            openChildForm(new frmImInvoice());

        }

        private void btnCustomer_Click_1(object sender, EventArgs e)
        {
            pnlSelect.Visible = true;
            movePlnSelect(btnCustomer);
            openChildForm(new frmCustomer());

        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            pnlSelect.Visible = true;
            movePlnSelect(btnSupplier);
            openChildForm(new frmSupplier());

        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            pnlSelect.Visible = true;
            movePlnSelect(btnStaff);
            openChildForm(new frmStaff());
        }

        private void btnPosition_Click(object sender, EventArgs e)
        {
            pnlSelect.Visible = true;
            movePlnSelect(btnPosition);
            openChildForm(new frmPosition());

        }

        private void btnShift_Click(object sender, EventArgs e)
        {
            pnlSelect.Visible = true;
            movePlnSelect(btnShift);
            openChildForm(new frmShift());

        }

        private void btnShutDown_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {


        }

        private void pnlChildForm_Paint(object sender, PaintEventArgs e)
        {
           
        }
        public void hideSelectPanel()
        {
            pnlSelect.Visible = false;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            openGrandchildForm(new frmStatStaff());
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
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
                Functions.Disconnect();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openGrandchildForm(new frmStatSup());
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            openGrandchildForm(new frmStatRevenue());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openGrandchildForm(new frmStatInvoice());
        }

        private void btnReItem_Click(object sender, EventArgs e)
        {
            pnlSelect.Visible = true;
            movePlnSelect(btnReItem);
            openChildForm(new frmReItem());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openGrandchildForm(new frmStatCustomer());
        }


        

       
    }
}
