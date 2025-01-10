namespace SimpleClinic
{
    partial class frmPatientsList
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
            this.dgvPatients = new System.Windows.Forms.DataGridView();
            this.cmsPatients = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showPatientInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPatientHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearchPage = new System.Windows.Forms.Button();
            this.lblTotalPageNumber = new System.Windows.Forms.Label();
            this.lblRecordsNumber = new System.Windows.Forms.Label();
            this.lblPageNumber = new System.Windows.Forms.Label();
            this.lblTotalRecordNumber = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.txtBoxPageNumber = new System.Windows.Forms.TextBox();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).BeginInit();
            this.cmsPatients.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPatients
            // 
            this.dgvPatients.AllowUserToAddRows = false;
            this.dgvPatients.AllowUserToDeleteRows = false;
            this.dgvPatients.AllowUserToOrderColumns = true;
            this.dgvPatients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPatients.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPatients.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatients.ContextMenuStrip = this.cmsPatients;
            this.dgvPatients.Location = new System.Drawing.Point(12, 156);
            this.dgvPatients.Name = "dgvPatients";
            this.dgvPatients.ReadOnly = true;
            this.dgvPatients.RowHeadersWidth = 51;
            this.dgvPatients.RowTemplate.Height = 24;
            this.dgvPatients.Size = new System.Drawing.Size(1135, 257);
            this.dgvPatients.TabIndex = 0;
            // 
            // cmsPatients
            // 
            this.cmsPatients.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsPatients.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPatientInfoToolStripMenuItem,
            this.addAPatientToolStripMenuItem,
            this.deleteAPatientToolStripMenuItem,
            this.showPatientHToolStripMenuItem});
            this.cmsPatients.Name = "cmsPatients";
            this.cmsPatients.Size = new System.Drawing.Size(313, 100);
            // 
            // showPatientInfoToolStripMenuItem
            // 
            this.showPatientInfoToolStripMenuItem.Name = "showPatientInfoToolStripMenuItem";
            this.showPatientInfoToolStripMenuItem.Size = new System.Drawing.Size(312, 24);
            this.showPatientInfoToolStripMenuItem.Text = "Show Patient Info";
            this.showPatientInfoToolStripMenuItem.Click += new System.EventHandler(this.showPartientInfoToolStripMenuItem_Click);
            // 
            // addAPatientToolStripMenuItem
            // 
            this.addAPatientToolStripMenuItem.Name = "addAPatientToolStripMenuItem";
            this.addAPatientToolStripMenuItem.Size = new System.Drawing.Size(312, 24);
            this.addAPatientToolStripMenuItem.Text = "Add A Patient";
            this.addAPatientToolStripMenuItem.Click += new System.EventHandler(this.addAPatientToolStripMenuItem_Click);
            // 
            // deleteAPatientToolStripMenuItem
            // 
            this.deleteAPatientToolStripMenuItem.Name = "deleteAPatientToolStripMenuItem";
            this.deleteAPatientToolStripMenuItem.Size = new System.Drawing.Size(312, 24);
            this.deleteAPatientToolStripMenuItem.Text = "Delete A Patient";
            this.deleteAPatientToolStripMenuItem.Click += new System.EventHandler(this.deleteAPatienttToolStripMenuItem_Click);
            // 
            // showPatientHToolStripMenuItem
            // 
            this.showPatientHToolStripMenuItem.Name = "showPatientHToolStripMenuItem";
            this.showPatientHToolStripMenuItem.Size = new System.Drawing.Size(312, 24);
            this.showPatientHToolStripMenuItem.Text = "Show Patient Appointments History";
            this.showPatientHToolStripMenuItem.Click += new System.EventHandler(this.showPatientHToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(484, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Patients List";
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
            this.groupBox1.Location = new System.Drawing.Point(12, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1134, 58);
            this.groupBox1.TabIndex = 3;
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
            this.lblRecordsNumber.Size = new System.Drawing.Size(202, 16);
            this.lblRecordsNumber.TabIndex = 3;
            this.lblRecordsNumber.Text = "Patients Number Per Page : ";
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
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(1037, 429);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(109, 35);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmPatientsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 476);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPatients);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPatientsList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patients List";
            this.Load += new System.EventHandler(this.frmPatientsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).EndInit();
            this.cmsPatients.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPatients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip cmsPatients;
        private System.Windows.Forms.ToolStripMenuItem showPatientInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPatientHToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPageNumber;
        private System.Windows.Forms.Label lblTotalRecordNumber;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Label lblRecordsNumber;
        private System.Windows.Forms.TextBox txtBoxPageNumber;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblTotalPageNumber;
        private System.Windows.Forms.Button btnSearchPage;
        private System.Windows.Forms.Button btnClose;
    }
}