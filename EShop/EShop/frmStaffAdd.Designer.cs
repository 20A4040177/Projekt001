﻿namespace EShop
{
    partial class frmStaffAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStaffAdd));
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.cboShift = new System.Windows.Forms.ComboBox();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cboPos = new System.Windows.Forms.ComboBox();
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lbStaffID = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lbPosID = new System.Windows.Forms.Label();
            this.lbShiftID = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbTelephone = new System.Windows.Forms.Label();
            this.lbDOB = new System.Windows.Forms.Label();
            this.lbGender = new System.Windows.Forms.Label();
            this.lbStaffName = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtDOB = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(244, 401);
            this.dtpDOB.MaxDate = new System.DateTime(2020, 6, 4, 16, 25, 28, 0);
            this.dtpDOB.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(197, 20);
            this.dtpDOB.TabIndex = 73;
            this.dtpDOB.Value = new System.DateTime(2020, 6, 4, 0, 0, 0, 0);
            this.dtpDOB.ValueChanged += new System.EventHandler(this.dtpDOB_ValueChanged);
            // 
            // cboShift
            // 
            this.cboShift.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboShift.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboShift.FormattingEnabled = true;
            this.cboShift.Location = new System.Drawing.Point(244, 552);
            this.cboShift.Name = "cboShift";
            this.cboShift.Size = new System.Drawing.Size(196, 21);
            this.cboShift.TabIndex = 71;
            // 
            // cboGender
            // 
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Location = new System.Drawing.Point(245, 300);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(196, 21);
            this.cboGender.TabIndex = 70;
            // 
            // txtStaffName
            // 
            this.txtStaffName.Location = new System.Drawing.Point(245, 250);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(196, 20);
            this.txtStaffName.TabIndex = 59;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 725);
            this.panel1.TabIndex = 56;
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
            // cboPos
            // 
            this.cboPos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboPos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboPos.FormattingEnabled = true;
            this.cboPos.Location = new System.Drawing.Point(244, 602);
            this.cboPos.Name = "cboPos";
            this.cboPos.Size = new System.Drawing.Size(196, 21);
            this.cboPos.TabIndex = 72;
            // 
            // txtStaffID
            // 
            this.txtStaffID.Location = new System.Drawing.Point(245, 200);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.Size = new System.Drawing.Size(196, 20);
            this.txtStaffID.TabIndex = 58;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 725);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(584, 36);
            this.panel2.TabIndex = 57;
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
            this.btnSave.Location = new System.Drawing.Point(284, 0);
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
            this.btnCancel.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.Location = new System.Drawing.Point(384, 0);
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
            this.btnClose.BackColor = System.Drawing.Color.Silver;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.Location = new System.Drawing.Point(484, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 36);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbStaffID
            // 
            this.lbStaffID.AutoSize = true;
            this.lbStaffID.Location = new System.Drawing.Point(181, 200);
            this.lbStaffID.Name = "lbStaffID";
            this.lbStaffID.Size = new System.Drawing.Size(43, 13);
            this.lbStaffID.TabIndex = 62;
            this.lbStaffID.Text = "Staff ID";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(245, 500);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(196, 20);
            this.txtAddress.TabIndex = 61;
            // 
            // lbPosID
            // 
            this.lbPosID.AutoSize = true;
            this.lbPosID.Location = new System.Drawing.Point(182, 602);
            this.lbPosID.Name = "lbPosID";
            this.lbPosID.Size = new System.Drawing.Size(44, 13);
            this.lbPosID.TabIndex = 69;
            this.lbPosID.Text = "Position";
            // 
            // lbShiftID
            // 
            this.lbShiftID.AutoSize = true;
            this.lbShiftID.Location = new System.Drawing.Point(181, 552);
            this.lbShiftID.Name = "lbShiftID";
            this.lbShiftID.Size = new System.Drawing.Size(57, 13);
            this.lbShiftID.TabIndex = 68;
            this.lbShiftID.Text = "Work Shift";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(182, 500);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(45, 13);
            this.lbAddress.TabIndex = 67;
            this.lbAddress.Text = "Address";
            // 
            // lbTelephone
            // 
            this.lbTelephone.AutoSize = true;
            this.lbTelephone.Location = new System.Drawing.Point(182, 450);
            this.lbTelephone.Name = "lbTelephone";
            this.lbTelephone.Size = new System.Drawing.Size(58, 13);
            this.lbTelephone.TabIndex = 66;
            this.lbTelephone.Text = "Telephone";
            // 
            // lbDOB
            // 
            this.lbDOB.AutoSize = true;
            this.lbDOB.Location = new System.Drawing.Point(181, 350);
            this.lbDOB.Name = "lbDOB";
            this.lbDOB.Size = new System.Drawing.Size(30, 13);
            this.lbDOB.TabIndex = 65;
            this.lbDOB.Text = "DOB";
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Location = new System.Drawing.Point(181, 300);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(42, 13);
            this.lbGender.TabIndex = 64;
            this.lbGender.Text = "Gender";
            // 
            // lbStaffName
            // 
            this.lbStaffName.AutoSize = true;
            this.lbStaffName.Location = new System.Drawing.Point(181, 250);
            this.lbStaffName.Name = "lbStaffName";
            this.lbStaffName.Size = new System.Drawing.Size(60, 13);
            this.lbStaffName.TabIndex = 63;
            this.lbStaffName.Text = "Staff Name";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(245, 450);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(196, 20);
            this.txtPhone.TabIndex = 60;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keypress);
            // 
            // txtDOB
            // 
            this.txtDOB.Location = new System.Drawing.Point(244, 350);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(195, 20);
            this.txtDOB.TabIndex = 74;
            // 
            // frmStaffAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 761);
            this.Controls.Add(this.txtDOB);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.cboShift);
            this.Controls.Add(this.cboGender);
            this.Controls.Add(this.txtStaffName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cboPos);
            this.Controls.Add(this.txtStaffID);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbStaffID);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lbPosID);
            this.Controls.Add(this.lbShiftID);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.lbTelephone);
            this.Controls.Add(this.lbDOB);
            this.Controls.Add(this.lbGender);
            this.Controls.Add(this.lbStaffName);
            this.Controls.Add(this.txtPhone);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmStaffAdd";
            this.Text = "Staff";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formclosing);
            this.Load += new System.EventHandler(this.frmStaffAdd_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.ComboBox cboShift;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cboPos;
        public System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbStaffID;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lbPosID;
        private System.Windows.Forms.Label lbShiftID;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbTelephone;
        private System.Windows.Forms.Label lbDOB;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.Label lbStaffName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtDOB;
    }
}