namespace EShop
{
    partial class frmSaleInvoiceDetail_old
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSaleInvoiceDetail_old));
            this.lbTotalPrice = new System.Windows.Forms.Label();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.lbDiscount = new System.Windows.Forms.Label();
            this.lbItemID = new System.Windows.Forms.Label();
            this.lbImInvoiceID = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtItemID = new System.Windows.Forms.TextBox();
            this.txtImInvoiceID = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvSaleInvoiceDetail = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleInvoiceDetail)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTotalPrice
            // 
            this.lbTotalPrice.AutoSize = true;
            this.lbTotalPrice.Location = new System.Drawing.Point(325, 359);
            this.lbTotalPrice.Name = "lbTotalPrice";
            this.lbTotalPrice.Size = new System.Drawing.Size(58, 13);
            this.lbTotalPrice.TabIndex = 28;
            this.lbTotalPrice.Text = "Total Price";
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Location = new System.Drawing.Point(39, 359);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(46, 13);
            this.lbQuantity.TabIndex = 25;
            this.lbQuantity.Text = "Quantity";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.SteelBlue;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(584, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 36);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Exit";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(383, 359);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(159, 20);
            this.txtTotalPrice.TabIndex = 29;
            // 
            // lbDiscount
            // 
            this.lbDiscount.AutoSize = true;
            this.lbDiscount.Location = new System.Drawing.Point(325, 309);
            this.lbDiscount.Name = "lbDiscount";
            this.lbDiscount.Size = new System.Drawing.Size(49, 13);
            this.lbDiscount.TabIndex = 27;
            this.lbDiscount.Text = "Discount";
            // 
            // lbItemID
            // 
            this.lbItemID.AutoSize = true;
            this.lbItemID.Location = new System.Drawing.Point(39, 309);
            this.lbItemID.Name = "lbItemID";
            this.lbItemID.Size = new System.Drawing.Size(41, 13);
            this.lbItemID.TabIndex = 24;
            this.lbItemID.Text = "Item ID";
            // 
            // lbImInvoiceID
            // 
            this.lbImInvoiceID.AutoSize = true;
            this.lbImInvoiceID.Location = new System.Drawing.Point(35, 256);
            this.lbImInvoiceID.Name = "lbImInvoiceID";
            this.lbImInvoiceID.Size = new System.Drawing.Size(56, 13);
            this.lbImInvoiceID.TabIndex = 23;
            this.lbImInvoiceID.Text = "Invoice ID";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(91, 359);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(159, 20);
            this.txtQuantity.TabIndex = 22;
            // 
            // txtItemID
            // 
            this.txtItemID.Location = new System.Drawing.Point(91, 309);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.Size = new System.Drawing.Size(159, 20);
            this.txtItemID.TabIndex = 21;
            // 
            // txtImInvoiceID
            // 
            this.txtImInvoiceID.Location = new System.Drawing.Point(91, 256);
            this.txtImInvoiceID.Name = "txtImInvoiceID";
            this.txtImInvoiceID.Size = new System.Drawing.Size(159, 20);
            this.txtImInvoiceID.TabIndex = 20;
            this.txtImInvoiceID.TextChanged += new System.EventHandler(this.txtImInvoiceID_TextChanged);
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(384, 309);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(159, 20);
            this.txtDiscount.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 725);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(684, 36);
            this.panel2.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dgvSaleInvoiceDetail
            // 
            this.dgvSaleInvoiceDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSaleInvoiceDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaleInvoiceDetail.Location = new System.Drawing.Point(42, 412);
            this.dgvSaleInvoiceDetail.Margin = new System.Windows.Forms.Padding(0);
            this.dgvSaleInvoiceDetail.Name = "dgvSaleInvoiceDetail";
            this.dgvSaleInvoiceDetail.Size = new System.Drawing.Size(600, 220);
            this.dgvSaleInvoiceDetail.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 100);
            this.panel1.TabIndex = 15;
            // 
            // frmSaleInvoiceDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 761);
            this.Controls.Add(this.lbTotalPrice);
            this.Controls.Add(this.lbQuantity);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.lbDiscount);
            this.Controls.Add(this.lbItemID);
            this.Controls.Add(this.lbImInvoiceID);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtItemID);
            this.Controls.Add(this.txtImInvoiceID);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvSaleInvoiceDetail);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSaleInvoiceDetail";
            this.Text = "Sale Details";
            this.Load += new System.EventHandler(this.frmSaleInvoiceDetail_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleInvoiceDetail)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTotalPrice;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Label lbDiscount;
        private System.Windows.Forms.Label lbItemID;
        private System.Windows.Forms.Label lbImInvoiceID;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtItemID;
        private System.Windows.Forms.TextBox txtImInvoiceID;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvSaleInvoiceDetail;
        private System.Windows.Forms.Panel panel1;
    }
}