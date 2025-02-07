namespace SimpleClinic
{
    partial class frmDoctorList
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
            this.components = new System.ComponentModel.Container();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearchPage = new System.Windows.Forms.Button();
            this.lblTotalPageNumber = new System.Windows.Forms.Label();
            this.lblRecordsNumber = new System.Windows.Forms.Label();
            this.lblPageNumber = new System.Windows.Forms.Label();
            this.lblTotalRecordNumber = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.txtBoxPageNumber = new System.Windows.Forms.TextBox();
            this.btnPrev = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDoctors = new System.Windows.Forms.DataGridView();
            this.cmsDoctors = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDoctorsInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDoctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateDoctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteDoctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctors)).BeginInit();
            this.cmsDoctors.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(1039, 398);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(109, 35);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearchPage);
            this.groupBox1.Controls.Add(this.lblTotalPageNumber);
            this.groupBox1.Controls.Add(this.lblRecordsNumber);
            this.groupBox1.Controls.Add(this.lblPageNumber);
            this.groupBox1.Controls.Add(this.lblTotalRecordNumber);
            this.groupBox1.Controls.Add(this.btnNext);
            this.groupBox1.Controls.Add(this.txtBoxPageNumber);
            this.groupBox1.Controls.Add(this.btnPrev);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1134, 58);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // btnSearchPage
            // 
            this.btnSearchPage.Location = new System.Drawing.Point(942, 17);
            this.btnSearchPage.Name = "btnSearchPage";
            this.btnSearchPage.Size = new System.Drawing.Size(123, 27);
            this.btnSearchPage.TabIndex = 8;
            this.btnSearchPage.Text = "Go To Page";
            this.btnSearchPage.UseVisualStyleBackColor = true;
            this.btnSearchPage.Click += new System.EventHandler(this.btnSearchPage_Click);
            // 
            // lblTotalPageNumber
            // 
            this.lblTotalPageNumber.AutoSize = true;
            this.lblTotalPageNumber.Location = new System.Drawing.Point(221, 22);
            this.lblTotalPageNumber.Name = "lblTotalPageNumber";
            this.lblTotalPageNumber.Size = new System.Drawing.Size(158, 16);
            this.lblTotalPageNumber.TabIndex = 9;
            this.lblTotalPageNumber.Text = "Total Pages Number: ";
            // 
            // lblRecordsNumber
            // 
            this.lblRecordsNumber.AutoSize = true;
            this.lblRecordsNumber.Location = new System.Drawing.Point(421, 22);
            this.lblRecordsNumber.Name = "lblRecordsNumber";
            this.lblRecordsNumber.Size = new System.Drawing.Size(200, 16);
            this.lblRecordsNumber.TabIndex = 3;
            this.lblRecordsNumber.Text = "Doctors Number Per Page : ";
            // 
            // lblPageNumber
            // 
            this.lblPageNumber.AutoSize = true;
            this.lblPageNumber.Location = new System.Drawing.Point(760, 22);
            this.lblPageNumber.Name = "lblPageNumber";
            this.lblPageNumber.Size = new System.Drawing.Size(76, 16);
            this.lblPageNumber.TabIndex = 8;
            this.lblPageNumber.Text = "Page No: ";
            // 
            // lblTotalRecordNumber
            // 
            this.lblTotalRecordNumber.AutoSize = true;
            this.lblTotalRecordNumber.Location = new System.Drawing.Point(7, 22);
            this.lblTotalRecordNumber.Name = "lblTotalRecordNumber";
            this.lblTotalRecordNumber.Size = new System.Drawing.Size(172, 16);
            this.lblTotalRecordNumber.TabIndex = 7;
            this.lblTotalRecordNumber.Text = "Total Records Number: ";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(868, 17);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(58, 27);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = ">>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // txtBoxPageNumber
            // 
            this.txtBoxPageNumber.Location = new System.Drawing.Point(1081, 17);
            this.txtBoxPageNumber.MaxLength = 10;
            this.txtBoxPageNumber.Name = "txtBoxPageNumber";
            this.txtBoxPageNumber.Size = new System.Drawing.Size(45, 22);
            this.txtBoxPageNumber.TabIndex = 2;
            this.txtBoxPageNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxPageNumber_KeyPress);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(674, 17);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(58, 27);
            this.btnPrev.TabIndex = 4;
            this.btnPrev.Text = "<<";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(491, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 36);
            this.label1.TabIndex = 10;
            this.label1.Text = "Doctors List";
            // 
            // dgvDoctors
            // 
            this.dgvDoctors.AllowUserToAddRows = false;
            this.dgvDoctors.AllowUserToDeleteRows = false;
            this.dgvDoctors.AllowUserToOrderColumns = true;
            this.dgvDoctors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDoctors.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDoctors.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoctors.ContextMenuStrip = this.cmsDoctors;
            this.dgvDoctors.Location = new System.Drawing.Point(13, 131);
            this.dgvDoctors.Name = "dgvDoctors";
            this.dgvDoctors.ReadOnly = true;
            this.dgvDoctors.RowHeadersWidth = 51;
            this.dgvDoctors.RowTemplate.Height = 24;
            this.dgvDoctors.Size = new System.Drawing.Size(1135, 257);
            this.dgvDoctors.TabIndex = 9;
            // 
            // cmsDoctors
            // 
            this.cmsDoctors.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsDoctors.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDoctorsInfoToolStripMenuItem,
            this.addDoctorToolStripMenuItem,
            this.UpdateDoctorToolStripMenuItem,
            this.deleteDoctorToolStripMenuItem});
            this.cmsDoctors.Name = "cmsPatients";
            this.cmsDoctors.Size = new System.Drawing.Size(211, 128);
            // 
            // showDoctorsInfoToolStripMenuItem
            // 
            this.showDoctorsInfoToolStripMenuItem.Name = "showDoctorsInfoToolStripMenuItem";
            this.showDoctorsInfoToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.showDoctorsInfoToolStripMenuItem.Text = "Show Doctor Info";
            this.showDoctorsInfoToolStripMenuItem.Click += new System.EventHandler(this.showDoctorInfoToolStripMenuItem_Click);
            // 
            // addDoctorToolStripMenuItem
            // 
            this.addDoctorToolStripMenuItem.Name = "addDoctorToolStripMenuItem";
            this.addDoctorToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.addDoctorToolStripMenuItem.Text = "Add Doctor";
            this.addDoctorToolStripMenuItem.Click += new System.EventHandler(this.addADoctorToolStripMenuItem_Click);
            // 
            // UpdateDoctorToolStripMenuItem
            // 
            this.UpdateDoctorToolStripMenuItem.Name = "UpdateDoctorToolStripMenuItem";
            this.UpdateDoctorToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.UpdateDoctorToolStripMenuItem.Text = "Update Doctor Info";
            this.UpdateDoctorToolStripMenuItem.Click += new System.EventHandler(this.UpdateADoctorToolStripMenuItem_Click);
            // 
            // deleteDoctorToolStripMenuItem
            // 
            this.deleteDoctorToolStripMenuItem.Name = "deleteDoctorToolStripMenuItem";
            this.deleteDoctorToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.deleteDoctorToolStripMenuItem.Text = "Delete Doctor";
            this.deleteDoctorToolStripMenuItem.Click += new System.EventHandler(this.deleteADoctortToolStripMenuItem_Click);
            // 
            // frmDoctorList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 442);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDoctors);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDoctorList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doctor List";
            this.Load += new System.EventHandler(this.frmDoctorList_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctors)).EndInit();
            this.cmsDoctors.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearchPage;
        private System.Windows.Forms.Label lblTotalPageNumber;
        private System.Windows.Forms.Label lblRecordsNumber;
        private System.Windows.Forms.Label lblPageNumber;
        private System.Windows.Forms.Label lblTotalRecordNumber;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox txtBoxPageNumber;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDoctors;
        private System.Windows.Forms.ContextMenuStrip cmsDoctors;
        private System.Windows.Forms.ToolStripMenuItem showDoctorsInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDoctorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UpdateDoctorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteDoctorToolStripMenuItem;
    }
}