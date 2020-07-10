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
    public partial class frmStatCustomer : Form
    {
        DataTable tblGridView;
        public frmStatCustomer()
        {
            InitializeComponent();
        }

        private void frmStatCustomer_Load(object sender, EventArgs e)
        {
            loadDataGridView();
           
        }
        private void loadDataGridView()
        {
            string selectSQL;
            selectSQL = "select top 3(select sum(TotalPrice)) as TotalPayment, tblCustomer.CustomerID,CustomerName,CustomerTel from tblSaleInvoice inner join tblCustomer on tblSaleInvoice.CustomerID=tblCustomer.CustomerID group by tblCustomer.CustomerID,CustomerName,CustomerTel order by sum(TotalPrice) desc";
            tblGridView = Functions.getDataToTable(selectSQL);
            dgvCustomer.DataSource = tblGridView;
            dgvCustomer.Columns[0].HeaderText = "Total Payment";
            dgvCustomer.Columns[1].HeaderText = "Customer ID";
            dgvCustomer.Columns[2].HeaderText = "Name";
            dgvCustomer.Columns[3].HeaderText = "Phone Number";
            dgvCustomer.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCustomer.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCustomer.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCustomer.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCustomer.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvCustomer.AllowUserToAddRows = false;

        }
        private void loadDataGridView2()
        {
            string selectSQL;
            selectSQL = "select top 3(select sum(tblSaleInvoiceDetail.Quantity)) as TotalQuantity, tblItemList.ItemID,ItemName from tblSaleInvoiceDetail inner join tblSaleInvoice on tblSaleInvoice.InvoiceID=tblSaleInvoiceDetail.InvoiceID inner join tblItemList on tblSaleInvoiceDetail.ItemID=tblItemList.ItemID where CustomerID='" + dgvCustomer.CurrentRow.Cells["CustomerID"].Value.ToString() + "' group by tblItemList.ItemID,ItemName order by TotalQuantity";
            tblGridView = Functions.getDataToTable(selectSQL);
            dgvItem.DataSource = tblGridView;
            dgvItem.Columns[0].HeaderText = "Total Quantity";
            dgvItem.Columns[1].HeaderText = "Item ID";
            dgvItem.Columns[2].HeaderText = "Item Name";
            dgvItem.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvItem.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvItem.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvItem.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvItem.AllowUserToAddRows = false;



        }

        private void cellClick(object sender, DataGridViewCellEventArgs e)
        {
            loadDataGridView2();
        }
    }
}
