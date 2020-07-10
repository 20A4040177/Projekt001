namespace EShop
{
    partial class frmReItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReItem));
            this.cboInvoiceID = new System.Windows.Forms.ComboBox();
            this.cboReason = new System.Windows.Forms.ComboBox();
            this.dgvItem = new System.Windows.Forms.DataGridView();
            this.cboItem = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlCategoryTitle = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.nbrQuantity = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).BeginInit();
            this.pnlCategoryTitle.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbrQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // cboInvoiceID
            // 
            this.cboInvoiceID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboInvoiceID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboInvoiceID.FormattingEnabled = true;
            this.cboInvoiceID.Location = new System.Drawing.Point(259, 498);
            this.cboInvoiceID.Name = "cboInvoiceID";
            this.cboInvoiceID.Size = new System.Drawing.Size(168, 21);
            this.cboInvoiceID.TabIndex = 0;
            this.cboInvoiceID.SelectedIndexChanged += new System.EventHandler(this.cboInvoiceID_SelectedIndexChanged);
            // 
            // cboReason
            // 
            this.cboReason.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboReason.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboReason.FormattingEnabled = true;
            this.cboReason.Location = new System.Drawing.Point(71, 498);
            this.cboReason.Name = "cboReason";
            this.cboReason.Size = new System.Drawing.Size(168, 21);
            this.cboReason.TabIndex = 1;
            // 
            // dgvItem
            // 
            this.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItem.Location = new System.Drawing.Point(71, 163);
            this.dgvItem.Name = "dgvItem";
            this.dgvItem.Size = new System.Drawing.Size(756, 276);
            this.dgvItem.TabIndex = 2;
            // 
            // cboItem
            // 
            this.cboItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboItem.FormattingEnabled = true;
            this.cboItem.Location = new System.Drawing.Point(458, 498);
            this.cboItem.Name = "cboItem";
            this.cboItem.Size = new System.Drawing.Size(168, 21);
            this.cboItem.TabIndex = 3;
            this.cboItem.SelectedIndexChanged += new System.EventHandler(this.cboItem_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 545);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Invoice ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 545);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Reason for returning";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(458, 545);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Item";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(664, 545);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Quantity";
            // 
            // pnlCategoryTitle
            // 
            this.pnlCategoryTitle.BackColor = System.Drawing.Color.MediumTurquoise;
            this.pnlCategoryTitle.Controls.Add(this.btnHome);
            this.pnlCategoryTitle.Controls.Add(this.label5);
            this.pnlCategoryTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCategoryTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlCategoryTitle.Name = "pnlCategoryTitle";
            this.pnlCategoryTitle.Size = new System.Drawing.Size(1014, 50);
            this.pnlCategoryTitle.TabIndex = 9;
            // 
            // btnHome
            // 
            this.btnHome.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(964, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(50, 50);
            this.btnHome.TabIndex = 2;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 31);
            this.label5.TabIndex = 0;
            this.label5.Text = "Returned Items";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 651);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1014, 30);
            this.panel2.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Gold;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(264, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 30);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(414, 0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(150, 30);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.IndianRed;
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(564, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 30);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(714, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 30);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Silver;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(864, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 30);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // nbrQuantity
            // 
            this.nbrQuantity.Location = new System.Drawing.Point(667, 499);
            this.nbrQuantity.Name = "nbrQuantity";
            this.nbrQuantity.Size = new System.Drawing.Size(160, 20);
            this.nbrQuantity.TabIndex = 11;
            // 
            // frmReItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 681);
            this.Controls.Add(this.nbrQuantity);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlCategoryTitle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboItem);
            this.Controls.Add(this.dgvItem);
            this.Controls.Add(this.cboReason);
            this.Controls.Add(this.cboInvoiceID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReItem";
            this.Text = "frmReItem";
            this.Load += new System.EventHandler(this.frmReItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).EndInit();
            this.pnlCategoryTitle.ResumeLayout(false);
            this.pnlCategoryTitle.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nbrQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboInvoiceID;
        private System.Windows.Forms.ComboBox cboReason;
        private System.Windows.Forms.DataGridView dgvItem;
        private System.Windows.Forms.ComboBox cboItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlCategoryTitle;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.NumericUpDown nbrQuantity;
    }
}