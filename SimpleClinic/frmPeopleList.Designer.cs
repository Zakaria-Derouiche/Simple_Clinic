namespace SimpleClinic
{
    partial class frmPeopleList
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
            this.dgvPeople = new System.Windows.Forms.DataGridView();
            this.cmsPeople = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showPersonInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updatePersonInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletePersontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).BeginInit();
            this.cmsPeople.SuspendLayout();
            this.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(25, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1134, 58);
            this.groupBox1.TabIndex = 6;
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
            this.lblRecordsNumber.Size = new System.Drawing.Size(192, 16);
            this.lblRecordsNumber.TabIndex = 3;
            this.lblRecordsNumber.Text = "People Number Per Page: ";
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
            this.lblTotalRecordNumber.Size = new System.Drawing.Size(168, 16);
            this.lblTotalRecordNumber.TabIndex = 7;
            this.lblTotalRecordNumber.Text = "Total Records Number:";
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
            this.txtBoxPageNumber.Location = new System.Drawing.Point(1081, 19);
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(524, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 46);
            this.label1.TabIndex = 5;
            this.label1.Text = "People List";
            // 
            // dgvPeople
            // 
            this.dgvPeople.AllowUserToAddRows = false;
            this.dgvPeople.AllowUserToDeleteRows = false;
            this.dgvPeople.AllowUserToOrderColumns = true;
            this.dgvPeople.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPeople.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPeople.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeople.ContextMenuStrip = this.cmsPeople;
            this.dgvPeople.Location = new System.Drawing.Point(25, 166);
            this.dgvPeople.Name = "dgvPeople";
            this.dgvPeople.ReadOnly = true;
            this.dgvPeople.RowHeadersWidth = 51;
            this.dgvPeople.RowTemplate.Height = 24;
            this.dgvPeople.Size = new System.Drawing.Size(1239, 257);
            this.dgvPeople.TabIndex = 4;
            // 
            // cmsPeople
            // 
            this.cmsPeople.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsPeople.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPersonInfoToolStripMenuItem,
            this.addPersonToolStripMenuItem,
            this.updatePersonInfoToolStripMenuItem,
            this.deletePersontToolStripMenuItem});
            this.cmsPeople.Name = "cmsPatients";
            this.cmsPeople.Size = new System.Drawing.Size(211, 128);
            // 
            // showPersonInfoToolStripMenuItem
            // 
            this.showPersonInfoToolStripMenuItem.Name = "showPersonInfoToolStripMenuItem";
            this.showPersonInfoToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.showPersonInfoToolStripMenuItem.Text = "Show Person nfo";
            this.showPersonInfoToolStripMenuItem.Click += new System.EventHandler(this.showPersonInfoToolStripMenuItem_Click);
            // 
            // addPersonToolStripMenuItem
            // 
            this.addPersonToolStripMenuItem.Name = "addPersonToolStripMenuItem";
            this.addPersonToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.addPersonToolStripMenuItem.Text = "Add Person";
            this.addPersonToolStripMenuItem.Click += new System.EventHandler(this.addAPersonToolStripMenuItem_Click);
            // 
            // updatePersonInfoToolStripMenuItem
            // 
            this.updatePersonInfoToolStripMenuItem.Name = "updatePersonInfoToolStripMenuItem";
            this.updatePersonInfoToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.updatePersonInfoToolStripMenuItem.Text = "Update Person Info";
            this.updatePersonInfoToolStripMenuItem.Click += new System.EventHandler(this.updatePersonInfoToolStripMenuItem_Click);
            // 
            // deletePersontToolStripMenuItem
            // 
            this.deletePersontToolStripMenuItem.Name = "deletePersontToolStripMenuItem";
            this.deletePersontToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.deletePersontToolStripMenuItem.Text = "Delete Person";
            this.deletePersontToolStripMenuItem.Click += new System.EventHandler(this.deleteAPersontToolStripMenuItem_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(1130, 442);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(134, 35);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmPeopleList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 486);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPeople);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPeopleList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "People List";
            this.Load += new System.EventHandler(this.frmPeopleList_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).EndInit();
            this.cmsPeople.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.DataGridView dgvPeople;
        private System.Windows.Forms.ContextMenuStrip cmsPeople;
        private System.Windows.Forms.ToolStripMenuItem showPersonInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updatePersonInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletePersontToolStripMenuItem;
        private System.Windows.Forms.Button btnClose;
    }
}