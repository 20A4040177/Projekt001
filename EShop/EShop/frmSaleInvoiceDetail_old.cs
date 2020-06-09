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
    public partial class frmSaleInvoiceDetail_old : Form
    {
        public frmSaleInvoiceDetail_old()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAddSaleInvoice newInvoice = new frmAddSaleInvoice();

            newInvoice.ShowDialog();
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void txtImInvoiceID_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmSaleInvoiceDetail_Load(object sender, EventArgs e)
        {
            txtImInvoiceID.Enabled = false;
            txtDiscount.Enabled = false;
            txtItemID.Enabled = false;
            txtQuantity.Enabled = false;
            txtTotalPrice.Enabled = false;
        }
    }
}
