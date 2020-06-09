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
    public partial class frmImInvoiceDetail_old : Form
    {
        public frmImInvoiceDetail_old()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmImInvoiceDetail_Load(object sender, EventArgs e)
        {
            txtDiscount.Enabled = false;
            txtImInvoiceID.Enabled = false;
            txtItemID.Enabled = false;
            txtQuantity.Enabled = false;
            txtTotalPrice.Enabled = false;
            txtUnitPrice.Enabled = false;
        }
    }
}
