namespace EShop
{
    partial class frmItemListDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItemListDetail));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtItemID = new System.Windows.Forms.TextBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtImUnitPrice = new System.Windows.Forms.TextBox();
            this.txtSaleUnitPrice = new System.Windows.Forms.TextBox();
            this.txtWarranty = new System.Windows.Forms.TextBox();
            this.lbItemID = new System.Windows.Forms.Label();
            this.lbItemName = new System.Windows.Forms.Label();
            this.lbCatID = new System.Windows.Forms.Label();
            this.lbTypeID = new System.Windows.Forms.Label();
            this.lbUnitID = new System.Windows.Forms.Label();
            this.lbMatID = new System.Windows.Forms.Label();
            this.lbCountryID = new System.Windows.Forms.Label();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.lbImPrice = new System.Windows.Forms.Label();
            this.lbSalePrice = new System.Windows.Forms.Label();
            this.lbWarTime = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.lbNote = new System.Windows.Forms.Label();
            this.ptbImage = new System.Windows.Forms.PictureBox();
            this.lbImage = new System.Windows.Forms.Label();
            this.cboCatID = new System.Windows.Forms.ComboBox();
            this.cboTypeID = new System.Windows.Forms.ComboBox();
            this.cboUnitID = new System.Windows.Forms.ComboBox();
            this.cboMatID = new System.Windows.Forms.ComboBox();
            this.cboCountryID = new System.Windows.Forms.ComboBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 761);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(100, 725);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(484, 36);
            this.panel2.TabIndex = 1;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.IndianRed;
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.Location = new System.Drawing.Point(84, 0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 36);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(184, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 36);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.Location = new System.Drawing.Point(284, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 36);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.BurlyWood;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.Location = new System.Drawing.Point(384, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 36);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtItemID
            // 
            this.txtItemID.Location = new System.Drawing.Point(257, 50);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.Size = new System.Drawing.Size(160, 20);
            this.txtItemID.TabIndex = 2;
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(257, 100);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(160, 20);
            this.txtItemName.TabIndex = 3;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(257, 400);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(160, 20);
            this.txtQuantity.TabIndex = 9;
            // 
            // txtImUnitPrice
            // 
            this.txtImUnitPrice.Location = new System.Drawing.Point(257, 450);
            this.txtImUnitPrice.Name = "txtImUnitPrice";
            this.txtImUnitPrice.Size = new System.Drawing.Size(160, 20);
            this.txtImUnitPrice.TabIndex = 10;
            // 
            // txtSaleUnitPrice
            // 
            this.txtSaleUnitPrice.Location = new System.Drawing.Point(257, 500);
            this.txtSaleUnitPrice.Name = "txtSaleUnitPrice";
            this.txtSaleUnitPrice.Size = new System.Drawing.Size(160, 20);
            this.txtSaleUnitPrice.TabIndex = 11;
            // 
            // txtWarranty
            // 
            this.txtWarranty.Location = new System.Drawing.Point(257, 550);
            this.txtWarranty.Name = "txtWarranty";
            this.txtWarranty.Size = new System.Drawing.Size(160, 20);
            this.txtWarranty.TabIndex = 12;
            this.txtWarranty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWarranty_keypress);
            // 
            // lbItemID
            // 
            this.lbItemID.AutoSize = true;
            this.lbItemID.Location = new System.Drawing.Point(181, 50);
            this.lbItemID.Name = "lbItemID";
            this.lbItemID.Size = new System.Drawing.Size(41, 13);
            this.lbItemID.TabIndex = 13;
            this.lbItemID.Text = "Item ID";
            // 
            // lbItemName
            // 
            this.lbItemName.AutoSize = true;
            this.lbItemName.Location = new System.Drawing.Point(181, 100);
            this.lbItemName.Name = "lbItemName";
            this.lbItemName.Size = new System.Drawing.Size(58, 13);
            this.lbItemName.TabIndex = 14;
            this.lbItemName.Text = "Item Name";
            // 
            // lbCatID
            // 
            this.lbCatID.AutoSize = true;
            this.lbCatID.Location = new System.Drawing.Point(181, 150);
            this.lbCatID.Name = "lbCatID";
            this.lbCatID.Size = new System.Drawing.Size(49, 13);
            this.lbCatID.TabIndex = 15;
            this.lbCatID.Text = "Category";
            // 
            // lbTypeID
            // 
            this.lbTypeID.AutoSize = true;
            this.lbTypeID.Location = new System.Drawing.Point(181, 200);
            this.lbTypeID.Name = "lbTypeID";
            this.lbTypeID.Size = new System.Drawing.Size(34, 13);
            this.lbTypeID.TabIndex = 16;
            this.lbTypeID.Text = "Type ";
            // 
            // lbUnitID
            // 
            this.lbUnitID.AutoSize = true;
            this.lbUnitID.Location = new System.Drawing.Point(181, 250);
            this.lbUnitID.Name = "lbUnitID";
            this.lbUnitID.Size = new System.Drawing.Size(26, 13);
            this.lbUnitID.TabIndex = 17;
            this.lbUnitID.Text = "Unit";
            // 
            // lbMatID
            // 
            this.lbMatID.AutoSize = true;
            this.lbMatID.Location = new System.Drawing.Point(181, 300);
            this.lbMatID.Name = "lbMatID";
            this.lbMatID.Size = new System.Drawing.Size(44, 13);
            this.lbMatID.TabIndex = 18;
            this.lbMatID.Text = "Material";
            // 
            // lbCountryID
            // 
            this.lbCountryID.AutoSize = true;
            this.lbCountryID.Location = new System.Drawing.Point(181, 350);
            this.lbCountryID.Name = "lbCountryID";
            this.lbCountryID.Size = new System.Drawing.Size(43, 13);
            this.lbCountryID.TabIndex = 19;
            this.lbCountryID.Text = "Country";
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Location = new System.Drawing.Point(181, 400);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(46, 13);
            this.lbQuantity.TabIndex = 20;
            this.lbQuantity.Text = "Quantity";
            // 
            // lbImPrice
            // 
            this.lbImPrice.AutoSize = true;
            this.lbImPrice.Location = new System.Drawing.Point(181, 450);
            this.lbImPrice.Name = "lbImPrice";
            this.lbImPrice.Size = new System.Drawing.Size(63, 13);
            this.lbImPrice.TabIndex = 21;
            this.lbImPrice.Text = "Import Price";
            // 
            // lbSalePrice
            // 
            this.lbSalePrice.AutoSize = true;
            this.lbSalePrice.Location = new System.Drawing.Point(181, 500);
            this.lbSalePrice.Name = "lbSalePrice";
            this.lbSalePrice.Size = new System.Drawing.Size(65, 13);
            this.lbSalePrice.TabIndex = 22;
            this.lbSalePrice.Text = "Selling Price";
            // 
            // lbWarTime
            // 
            this.lbWarTime.AutoSize = true;
            this.lbWarTime.Location = new System.Drawing.Point(181, 550);
            this.lbWarTime.Name = "lbWarTime";
            this.lbWarTime.Size = new System.Drawing.Size(50, 13);
            this.lbWarTime.TabIndex = 23;
            this.lbWarTime.Text = "Warranty";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(257, 600);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(240, 81);
            this.txtNote.TabIndex = 24;
            this.txtNote.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
            // 
            // lbNote
            // 
            this.lbNote.AutoSize = true;
            this.lbNote.Location = new System.Drawing.Point(181, 600);
            this.lbNote.Name = "lbNote";
            this.lbNote.Size = new System.Drawing.Size(30, 13);
            this.lbNote.TabIndex = 25;
            this.lbNote.Text = "Note";
            // 
            // ptbImage
            // 
            this.ptbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbImage.Location = new System.Drawing.Point(423, 50);
            this.ptbImage.Name = "ptbImage";
            this.ptbImage.Size = new System.Drawing.Size(150, 171);
            this.ptbImage.TabIndex = 26;
            this.ptbImage.TabStop = false;
            this.ptbImage.Click += new System.EventHandler(this.ptbImage_Click);
            // 
            // lbImage
            // 
            this.lbImage.AutoSize = true;
            this.lbImage.Location = new System.Drawing.Point(481, 250);
            this.lbImage.Name = "lbImage";
            this.lbImage.Size = new System.Drawing.Size(36, 13);
            this.lbImage.TabIndex = 27;
            this.lbImage.Text = "Image";
            // 
            // cboCatID
            // 
            this.cboCatID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboCatID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboCatID.FormattingEnabled = true;
            this.cboCatID.Location = new System.Drawing.Point(257, 150);
            this.cboCatID.Name = "cboCatID";
            this.cboCatID.Size = new System.Drawing.Size(160, 21);
            this.cboCatID.TabIndex = 28;
            // 
            // cboTypeID
            // 
            this.cboTypeID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboTypeID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboTypeID.FormattingEnabled = true;
            this.cboTypeID.Location = new System.Drawing.Point(257, 200);
            this.cboTypeID.Name = "cboTypeID";
            this.cboTypeID.Size = new System.Drawing.Size(160, 21);
            this.cboTypeID.TabIndex = 29;
            // 
            // cboUnitID
            // 
            this.cboUnitID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboUnitID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboUnitID.FormattingEnabled = true;
            this.cboUnitID.Location = new System.Drawing.Point(257, 250);
            this.cboUnitID.Name = "cboUnitID";
            this.cboUnitID.Size = new System.Drawing.Size(160, 21);
            this.cboUnitID.TabIndex = 30;
            // 
            // cboMatID
            // 
            this.cboMatID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboMatID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboMatID.FormattingEnabled = true;
            this.cboMatID.Location = new System.Drawing.Point(257, 300);
            this.cboMatID.Name = "cboMatID";
            this.cboMatID.Size = new System.Drawing.Size(160, 21);
            this.cboMatID.TabIndex = 31;
            // 
            // cboCountryID
            // 
            this.cboCountryID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboCountryID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboCountryID.FormattingEnabled = true;
            this.cboCountryID.Location = new System.Drawing.Point(257, 350);
            this.cboCountryID.Name = "cboCountryID";
            this.cboCountryID.Size = new System.Drawing.Size(160, 21);
            this.cboCountryID.TabIndex = 32;
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnSelect.FlatAppearance.BorderSize = 0;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Location = new System.Drawing.Point(423, 198);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(150, 23);
            this.btnSelect.TabIndex = 33;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // frmItemListDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 761);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.cboCountryID);
            this.Controls.Add(this.cboMatID);
            this.Controls.Add(this.cboUnitID);
            this.Controls.Add(this.cboTypeID);
            this.Controls.Add(this.cboCatID);
            this.Controls.Add(this.lbImage);
            this.Controls.Add(this.ptbImage);
            this.Controls.Add(this.lbNote);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.lbWarTime);
            this.Controls.Add(this.lbSalePrice);
            this.Controls.Add(this.lbImPrice);
            this.Controls.Add(this.lbQuantity);
            this.Controls.Add(this.lbCountryID);
            this.Controls.Add(this.lbMatID);
            this.Controls.Add(this.lbUnitID);
            this.Controls.Add(this.lbTypeID);
            this.Controls.Add(this.lbCatID);
            this.Controls.Add(this.lbItemName);
            this.Controls.Add(this.lbItemID);
            this.Controls.Add(this.txtWarranty);
            this.Controls.Add(this.txtSaleUnitPrice);
            this.Controls.Add(this.txtImUnitPrice);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.txtItemID);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmItemListDetail";
            this.Text = "Item Details";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formclosing);
            this.Load += new System.EventHandler(this.frmItemListDetail_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbItemID;
        private System.Windows.Forms.Label lbItemName;
        private System.Windows.Forms.Label lbCatID;
        private System.Windows.Forms.Label lbTypeID;
        private System.Windows.Forms.Label lbUnitID;
        private System.Windows.Forms.Label lbMatID;
        private System.Windows.Forms.Label lbCountryID;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.Label lbImPrice;
        private System.Windows.Forms.Label lbSalePrice;
        private System.Windows.Forms.Label lbWarTime;
        private System.Windows.Forms.Label lbNote;
        private System.Windows.Forms.Label lbImage;
        public System.Windows.Forms.TextBox txtItemID;
        public System.Windows.Forms.TextBox txtItemName;
        public System.Windows.Forms.TextBox txtQuantity;
        public System.Windows.Forms.TextBox txtImUnitPrice;
        public System.Windows.Forms.TextBox txtSaleUnitPrice;
        public System.Windows.Forms.TextBox txtWarranty;
        public System.Windows.Forms.TextBox txtNote;
        public System.Windows.Forms.PictureBox ptbImage;
        public System.Windows.Forms.ComboBox cboCatID;
        public System.Windows.Forms.ComboBox cboTypeID;
        public System.Windows.Forms.ComboBox cboUnitID;
        public System.Windows.Forms.ComboBox cboMatID;
        public System.Windows.Forms.ComboBox cboCountryID;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnEdit;
    }
}