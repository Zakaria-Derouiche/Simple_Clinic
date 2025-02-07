namespace SimpleClinic
{
    partial class frmPaymentsList
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
            this.gBoxFilter = new System.Windows.Forms.GroupBox();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.txtBoxFilterBy = new System.Windows.Forms.TextBox();
            this.comBoxFilterBy = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.dgvPayments = new System.Windows.Forms.DataGridView();
            this.cmsPayments = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showPaymentInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gBoxFilter.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).BeginInit();
            this.cmsPayments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gBoxFilter
            // 
            this.gBoxFilter.Controls.Add(this.btnDisplay);
            this.gBoxFilter.Controls.Add(this.txtBoxFilterBy);
            this.gBoxFilter.Controls.Add(this.comBoxFilterBy);
            this.gBoxFilter.Controls.Add(this.label2);
            this.gBoxFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxFilter.Location = new System.Drawing.Point(17, 58);
            this.gBoxFilter.Name = "gBoxFilter";
            this.gBoxFilter.Size = new System.Drawing.Size(904, 50);
            this.gBoxFilter.TabIndex = 14;
            this.gBoxFilter.TabStop = false;
            // 
            // btnDisplay
            // 
            this.btnDisplay.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnDisplay.Location = new System.Drawing.Point(680, 17);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(195, 25);
            this.btnDisplay.TabIndex = 5;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // txtBoxFilterBy
            // 
            this.txtBoxFilterBy.Location = new System.Drawing.Point(401, 17);
            this.txtBoxFilterBy.MaxLength = 100;
            this.txtBoxFilterBy.Name = "txtBoxFilterBy";
            this.txtBoxFilterBy.Size = new System.Drawing.Size(225, 22);
            this.txtBoxFilterBy.TabIndex = 3;
            this.txtBoxFilterBy.TextChanged += new System.EventHandler(this.txtBoxFilterBy_TextChanged);
            this.txtBoxFilterBy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxFilterBy_KeyPress);
            this.txtBoxFilterBy.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxFilterBy_Validating);
            // 
            // comBoxFilterBy
            // 
            this.comBoxFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxFilterBy.FormattingEnabled = true;
            this.comBoxFilterBy.Items.AddRange(new object[] {
            "All",
            "Full Name",
            "National Number",
            "Date"});
            this.comBoxFilterBy.Location = new System.Drawing.Point(129, 15);
            this.comBoxFilterBy.Name = "comBoxFilterBy";
            this.comBoxFilterBy.Size = new System.Drawing.Size(218, 24);
            this.comBoxFilterBy.TabIndex = 4;
            this.comBoxFilterBy.SelectedIndexChanged += new System.EventHandler(this.comBoxFilterBy_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Filter By:";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(1040, 465);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(109, 35);
            this.btnClose.TabIndex = 13;
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
            this.groupBox1.Location = new System.Drawing.Point(17, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1134, 58);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // btnSearchPage
            // 
            this.btnSearchPage.Location = new System.Drawing.Point(931, 17);
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
            this.lblTotalPageNumber.Location = new System.Drawing.Point(206, 22);
            this.lblTotalPageNumber.Name = "lblTotalPageNumber";
            this.lblTotalPageNumber.Size = new System.Drawing.Size(158, 16);
            this.lblTotalPageNumber.TabIndex = 9;
            this.lblTotalPageNumber.Text = "Total Pages Number: ";
            // 
            // lblRecordsNumber
            // 
            this.lblRecordsNumber.AutoSize = true;
            this.lblRecordsNumber.Location = new System.Drawing.Point(391, 22);
            this.lblRecordsNumber.Name = "lblRecordsNumber";
            this.lblRecordsNumber.Size = new System.Drawing.Size(214, 16);
            this.lblRecordsNumber.TabIndex = 3;
            this.lblRecordsNumber.Text = "Payments Number Per Page : ";
            // 
            // lblPageNumber
            // 
            this.lblPageNumber.AutoSize = true;
            this.lblPageNumber.Location = new System.Drawing.Point(743, 22);
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
            this.btnNext.Location = new System.Drawing.Point(846, 17);
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
            this.txtBoxPageNumber.Click += new System.EventHandler(this.btnSearchPage_Click);
            this.txtBoxPageNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxPageNumber_KeyPress);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(658, 17);
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
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(483, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 36);
            this.label1.TabIndex = 11;
            this.label1.Text = "Payments List";
            // 
            // dgvPayments
            // 
            this.dgvPayments.AllowUserToAddRows = false;
            this.dgvPayments.AllowUserToDeleteRows = false;
            this.dgvPayments.AllowUserToOrderColumns = true;
            this.dgvPayments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPayments.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPayments.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayments.ContextMenuStrip = this.cmsPayments;
            this.dgvPayments.Location = new System.Drawing.Point(17, 202);
            this.dgvPayments.Name = "dgvPayments";
            this.dgvPayments.ReadOnly = true;
            this.dgvPayments.RowHeadersWidth = 51;
            this.dgvPayments.RowTemplate.Height = 24;
            this.dgvPayments.Size = new System.Drawing.Size(1135, 257);
            this.dgvPayments.TabIndex = 10;
            // 
            // cmsPayments
            // 
            this.cmsPayments.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsPayments.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPaymentInfoToolStripMenuItem});
            this.cmsPayments.Name = "cmsPatients";
            this.cmsPayments.Size = new System.Drawing.Size(211, 56);
            this.cmsPayments.Click += new System.EventHandler(this.showPaymentInfoToolStripMenuItem_Click);
            // 
            // showPaymentInfoToolStripMenuItem
            // 
            this.showPaymentInfoToolStripMenuItem.Name = "showPaymentInfoToolStripMenuItem";
            this.showPaymentInfoToolStripMenuItem.Size = new System.Drawing.Size(204, 24);
            this.showPaymentInfoToolStripMenuItem.Text = "Show Payment Info";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmPaymentsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 510);
            this.Controls.Add(this.gBoxFilter);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPayments);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPaymentsList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payments List";
            this.Load += new System.EventHandler(this.frmPaymentsList_Load);
            this.gBoxFilter.ResumeLayout(false);
            this.gBoxFilter.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).EndInit();
            this.cmsPayments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxFilter;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.TextBox txtBoxFilterBy;
        private System.Windows.Forms.ComboBox comBoxFilterBy;
        private System.Windows.Forms.Label label2;
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
        private System.Windows.Forms.DataGridView dgvPayments;
        private System.Windows.Forms.ContextMenuStrip cmsPayments;
        private System.Windows.Forms.ToolStripMenuItem showPaymentInfoToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}