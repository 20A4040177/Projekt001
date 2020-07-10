namespace EShop
{
    partial class frmImInvoiceDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImInvoiceDetail));
            this.nbrUnitPrice = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.dgvItem = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtSupplier = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboSupplier = new System.Windows.Forms.ComboBox();
            this.txtStaff = new System.Windows.Forms.TextBox();
            this.cboStaff = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nbrDiscount = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.nbrQuantity = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.cboItem = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtInvoiceID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nbrUnitPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbrDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbrQuantity)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // nbrUnitPrice
            // 
            this.nbrUnitPrice.Location = new System.Drawing.Point(654, 332);
            this.nbrUnitPrice.Name = "nbrUnitPrice";
            this.nbrUnitPrice.Size = new System.Drawing.Size(198, 20);
            this.nbrUnitPrice.TabIndex = 128;
            this.nbrUnitPrice.ValueChanged += new System.EventHandler(this.nbrUnitPrice_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(587, 334);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 127;
            this.label13.Text = "Unit Price";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(884, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 50);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(984, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 50);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1084, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(654, 451);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(198, 20);
            this.txtPrice.TabIndex = 124;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(590, 451);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 123;
            this.label12.Text = "Total Price";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1114, 500);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 122;
            this.label11.Text = "Total Price";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalPrice.Location = new System.Drawing.Point(974, 542);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(198, 20);
            this.txtTotalPrice.TabIndex = 121;
            this.txtTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalPrice.TextChanged += new System.EventHandler(this.txtTotalPrice_TextChanged);
            // 
            // dgvItem
            // 
            this.dgvItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItem.Location = new System.Drawing.Point(932, 146);
            this.dgvItem.Name = "dgvItem";
            this.dgvItem.Size = new System.Drawing.Size(240, 325);
            this.dgvItem.TabIndex = 120;
            this.dgvItem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cellClick);
            this.dgvItem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItem_CellContentClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(290, 334);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 117;
            this.label10.Text = "Phone";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(290, 272);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 116;
            this.label9.Text = "Address";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(358, 334);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(198, 20);
            this.txtPhone.TabIndex = 115;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(358, 272);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(198, 20);
            this.txtAddress.TabIndex = 114;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // txtSupplier
            // 
            this.txtSupplier.Location = new System.Drawing.Point(358, 208);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.Size = new System.Drawing.Size(198, 20);
            this.txtSupplier.TabIndex = 113;
            this.txtSupplier.TextChanged += new System.EventHandler(this.txtSupplier_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(290, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 112;
            this.label8.Text = "Name";
            // 
            // cboSupplier
            // 
            this.cboSupplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboSupplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboSupplier.FormattingEnabled = true;
            this.cboSupplier.Location = new System.Drawing.Point(358, 146);
            this.cboSupplier.Name = "cboSupplier";
            this.cboSupplier.Size = new System.Drawing.Size(198, 21);
            this.cboSupplier.TabIndex = 111;
            this.cboSupplier.SelectedIndexChanged += new System.EventHandler(this.cboSupplier_SelectedIndexChanged);
            // 
            // txtStaff
            // 
            this.txtStaff.Location = new System.Drawing.Point(71, 334);
            this.txtStaff.Name = "txtStaff";
            this.txtStaff.Size = new System.Drawing.Size(198, 20);
            this.txtStaff.TabIndex = 110;
            this.txtStaff.TextChanged += new System.EventHandler(this.txtStaff_TextChanged);
            // 
            // cboStaff
            // 
            this.cboStaff.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboStaff.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboStaff.FormattingEnabled = true;
            this.cboStaff.Location = new System.Drawing.Point(71, 275);
            this.cboStaff.Name = "cboStaff";
            this.cboStaff.Size = new System.Drawing.Size(198, 21);
            this.cboStaff.TabIndex = 109;
            this.cboStaff.SelectedIndexChanged += new System.EventHandler(this.cboStaff_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 108;
            this.label7.Text = "Staff";
            // 
            // nbrDiscount
            // 
            this.nbrDiscount.Location = new System.Drawing.Point(654, 391);
            this.nbrDiscount.Name = "nbrDiscount";
            this.nbrDiscount.Size = new System.Drawing.Size(198, 20);
            this.nbrDiscount.TabIndex = 107;
            this.nbrDiscount.ValueChanged += new System.EventHandler(this.nbrDiscount_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(590, 391);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 106;
            this.label6.Text = "Discount(%)";
            // 
            // nbrQuantity
            // 
            this.nbrQuantity.Location = new System.Drawing.Point(654, 275);
            this.nbrQuantity.Name = "nbrQuantity";
            this.nbrQuantity.Size = new System.Drawing.Size(120, 20);
            this.nbrQuantity.TabIndex = 105;
            this.nbrQuantity.ValueChanged += new System.EventHandler(this.nbrQuantity_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(590, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 104;
            this.label5.Text = "Quantity";
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(654, 208);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(198, 20);
            this.txtItem.TabIndex = 103;
            this.txtItem.TextChanged += new System.EventHandler(this.txtItem_TextChanged);
            // 
            // cboItem
            // 
            this.cboItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboItem.FormattingEnabled = true;
            this.cboItem.Location = new System.Drawing.Point(654, 146);
            this.cboItem.Name = "cboItem";
            this.cboItem.Size = new System.Drawing.Size(198, 21);
            this.cboItem.TabIndex = 102;
            this.cboItem.SelectedIndexChanged += new System.EventHandler(this.cboItem_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(590, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 101;
            this.label4.Text = "Item";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 100;
            this.label3.Text = "Date";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(71, 208);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(198, 20);
            this.txtDate.TabIndex = 99;
            this.txtDate.TextChanged += new System.EventHandler(this.txtDate_TextChanged);
            // 
            // txtInvoiceID
            // 
            this.txtInvoiceID.Location = new System.Drawing.Point(71, 149);
            this.txtInvoiceID.Name = "txtInvoiceID";
            this.txtInvoiceID.Size = new System.Drawing.Size(198, 20);
            this.txtInvoiceID.TabIndex = 98;
            this.txtInvoiceID.TextChanged += new System.EventHandler(this.txtInvoiceID_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 97;
            this.label2.Text = "Supplier";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 96;
            this.label1.Text = "Invoice ID";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 611);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1184, 50);
            this.panel2.TabIndex = 95;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Gold;
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(784, 0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 50);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 100);
            this.panel1.TabIndex = 94;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(777, 490);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(75, 23);
            this.btnAddItem.TabIndex = 129;
            this.btnAddItem.Text = "Add";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Location = new System.Drawing.Point(932, 117);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 130;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // frmImInvoiceDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.nbrUnitPrice);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.dgvItem);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtSupplier);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cboSupplier);
            this.Controls.Add(this.txtStaff);
            this.Controls.Add(this.cboStaff);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nbrDiscount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nbrQuantity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.cboItem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtInvoiceID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmImInvoiceDetail";
            this.Text = "Invoice Details";
            this.Load += new System.EventHandler(this.frmImInvoiceDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nbrUnitPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbrDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbrQuantity)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEdit;
        public System.Windows.Forms.NumericUpDown nbrUnitPrice;
        public System.Windows.Forms.TextBox txtPrice;
        public System.Windows.Forms.TextBox txtTotalPrice;
        public System.Windows.Forms.DataGridView dgvItem;
        public System.Windows.Forms.TextBox txtPhone;
        public System.Windows.Forms.TextBox txtAddress;
        public System.Windows.Forms.TextBox txtSupplier;
        public System.Windows.Forms.ComboBox cboSupplier;
        public System.Windows.Forms.TextBox txtStaff;
        public System.Windows.Forms.ComboBox cboStaff;
        public System.Windows.Forms.NumericUpDown nbrDiscount;
        public System.Windows.Forms.NumericUpDown nbrQuantity;
        public System.Windows.Forms.TextBox txtItem;
        public System.Windows.Forms.ComboBox cboItem;
        public System.Windows.Forms.TextBox txtDate;
        public System.Windows.Forms.TextBox txtInvoiceID;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnRemove;

    }
}