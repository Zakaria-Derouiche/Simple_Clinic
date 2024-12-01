namespace SimpleClinic
{
    partial class frmAddEditEmployee
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPersonID = new System.Windows.Forms.Label();
            this.picBoxEmployeeImage = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpHireDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBoxReasonOfLeaving = new System.Windows.Forms.TextBox();
            this.rbResigned = new System.Windows.Forms.RadioButton();
            this.rbFired = new System.Windows.Forms.RadioButton();
            this.linkLblAddImage = new System.Windows.Forms.LinkLabel();
            this.gboxEmployeeInfo = new System.Windows.Forms.GroupBox();
            this.linkLblRemoveImage = new System.Windows.Forms.LinkLabel();
            this.ctrlPersonWithFilter1 = new SimpleClinic.ctrlPersonWithFilter();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxEmployeeImage)).BeginInit();
            this.gboxEmployeeInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblTitle.Location = new System.Drawing.Point(279, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(278, 32);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Add New Employee";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnSave.Location = new System.Drawing.Point(542, 566);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 40);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(706, 566);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 40);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Employee ID:";
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Location = new System.Drawing.Point(255, 21);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(41, 16);
            this.lblEmployeeID.TabIndex = 5;
            this.lblEmployeeID.Text = "[???]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Person ID:";
            // 
            // lblPersonID
            // 
            this.lblPersonID.AutoSize = true;
            this.lblPersonID.Location = new System.Drawing.Point(255, 62);
            this.lblPersonID.Name = "lblPersonID";
            this.lblPersonID.Size = new System.Drawing.Size(41, 16);
            this.lblPersonID.TabIndex = 7;
            this.lblPersonID.Text = "[???]";
            // 
            // picBoxEmployeeImage
            // 
            this.picBoxEmployeeImage.Location = new System.Drawing.Point(16, 21);
            this.picBoxEmployeeImage.Name = "picBoxEmployeeImage";
            this.picBoxEmployeeImage.Size = new System.Drawing.Size(114, 112);
            this.picBoxEmployeeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxEmployeeImage.TabIndex = 9;
            this.picBoxEmployeeImage.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(549, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "End Date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(320, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Hire Date:";
            // 
            // dtpHireDate
            // 
            this.dtpHireDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHireDate.Location = new System.Drawing.Point(418, 18);
            this.dtpHireDate.Name = "dtpHireDate";
            this.dtpHireDate.Size = new System.Drawing.Size(113, 22);
            this.dtpHireDate.TabIndex = 12;
            this.dtpHireDate.EnabledChanged += new System.EventHandler(this.dtpHireDate_EnabledChanged);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(643, 18);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(113, 22);
            this.dtpEndDate.TabIndex = 13;
            this.dtpEndDate.EnabledChanged += new System.EventHandler(this.dtpEndDate_EnabledChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(145, 103);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 16);
            this.label12.TabIndex = 14;
            this.label12.Text = "Type Of Leaving:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(320, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 16);
            this.label10.TabIndex = 16;
            this.label10.Text = "Reason Of Leaving:";
            // 
            // txtBoxReasonOfLeaving
            // 
            this.txtBoxReasonOfLeaving.Location = new System.Drawing.Point(280, 90);
            this.txtBoxReasonOfLeaving.Multiline = true;
            this.txtBoxReasonOfLeaving.Name = "txtBoxReasonOfLeaving";
            this.txtBoxReasonOfLeaving.Size = new System.Drawing.Size(488, 62);
            this.txtBoxReasonOfLeaving.TabIndex = 17;
            // 
            // rbResigned
            // 
            this.rbResigned.AutoSize = true;
            this.rbResigned.Location = new System.Drawing.Point(514, 60);
            this.rbResigned.Name = "rbResigned";
            this.rbResigned.Size = new System.Drawing.Size(95, 20);
            this.rbResigned.TabIndex = 18;
            this.rbResigned.TabStop = true;
            this.rbResigned.Text = "Resigned";
            this.rbResigned.UseVisualStyleBackColor = true;
            // 
            // rbFired
            // 
            this.rbFired.AutoSize = true;
            this.rbFired.Location = new System.Drawing.Point(650, 60);
            this.rbFired.Name = "rbFired";
            this.rbFired.Size = new System.Drawing.Size(64, 20);
            this.rbFired.TabIndex = 19;
            this.rbFired.TabStop = true;
            this.rbFired.Text = "Fired";
            this.rbFired.UseVisualStyleBackColor = true;
            // 
            // linkLblAddImage
            // 
            this.linkLblAddImage.AutoSize = true;
            this.linkLblAddImage.Location = new System.Drawing.Point(4, 136);
            this.linkLblAddImage.Name = "linkLblAddImage";
            this.linkLblAddImage.Size = new System.Drawing.Size(82, 16);
            this.linkLblAddImage.TabIndex = 20;
            this.linkLblAddImage.TabStop = true;
            this.linkLblAddImage.Text = "Add Image";
            this.linkLblAddImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblAddImage_LinkClicked);
            // 
            // gboxEmployeeInfo
            // 
            this.gboxEmployeeInfo.Controls.Add(this.linkLblRemoveImage);
            this.gboxEmployeeInfo.Controls.Add(this.linkLblAddImage);
            this.gboxEmployeeInfo.Controls.Add(this.rbFired);
            this.gboxEmployeeInfo.Controls.Add(this.rbResigned);
            this.gboxEmployeeInfo.Controls.Add(this.txtBoxReasonOfLeaving);
            this.gboxEmployeeInfo.Controls.Add(this.label10);
            this.gboxEmployeeInfo.Controls.Add(this.label12);
            this.gboxEmployeeInfo.Controls.Add(this.dtpEndDate);
            this.gboxEmployeeInfo.Controls.Add(this.dtpHireDate);
            this.gboxEmployeeInfo.Controls.Add(this.label7);
            this.gboxEmployeeInfo.Controls.Add(this.label5);
            this.gboxEmployeeInfo.Controls.Add(this.picBoxEmployeeImage);
            this.gboxEmployeeInfo.Controls.Add(this.lblPersonID);
            this.gboxEmployeeInfo.Controls.Add(this.label3);
            this.gboxEmployeeInfo.Controls.Add(this.lblEmployeeID);
            this.gboxEmployeeInfo.Controls.Add(this.label1);
            this.gboxEmployeeInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxEmployeeInfo.Location = new System.Drawing.Point(10, 393);
            this.gboxEmployeeInfo.Name = "gboxEmployeeInfo";
            this.gboxEmployeeInfo.Size = new System.Drawing.Size(816, 167);
            this.gboxEmployeeInfo.TabIndex = 2;
            this.gboxEmployeeInfo.TabStop = false;
            this.gboxEmployeeInfo.Text = "Employee Info";
            // 
            // linkLblRemoveImage
            // 
            this.linkLblRemoveImage.AutoSize = true;
            this.linkLblRemoveImage.Location = new System.Drawing.Point(92, 136);
            this.linkLblRemoveImage.Name = "linkLblRemoveImage";
            this.linkLblRemoveImage.Size = new System.Drawing.Size(112, 16);
            this.linkLblRemoveImage.TabIndex = 21;
            this.linkLblRemoveImage.TabStop = true;
            this.linkLblRemoveImage.Text = "Remove Image";
            this.linkLblRemoveImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblRemoveImage_LinkClicked);
            // 
            // ctrlPersonWithFilter1
            // 
            this.ctrlPersonWithFilter1.Location = new System.Drawing.Point(17, 55);
            this.ctrlPersonWithFilter1.Name = "ctrlPersonWithFilter1";
            this.ctrlPersonWithFilter1.Size = new System.Drawing.Size(802, 332);
            this.ctrlPersonWithFilter1.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmAddEditEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 618);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gboxEmployeeInfo);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.ctrlPersonWithFilter1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddEditEmployee";
            this.Text = "AddEditEmployee";
            this.Load += new System.EventHandler(this.frmAddEditEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxEmployeeImage)).EndInit();
            this.gboxEmployeeInfo.ResumeLayout(false);
            this.gboxEmployeeInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlPersonWithFilter ctrlPersonWithFilter1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPersonID;
        private System.Windows.Forms.PictureBox picBoxEmployeeImage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpHireDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBoxReasonOfLeaving;
        private System.Windows.Forms.RadioButton rbResigned;
        private System.Windows.Forms.RadioButton rbFired;
        private System.Windows.Forms.LinkLabel linkLblAddImage;
        private System.Windows.Forms.GroupBox gboxEmployeeInfo;
        private System.Windows.Forms.LinkLabel linkLblRemoveImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}