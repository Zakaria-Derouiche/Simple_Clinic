namespace SimpleClinic
{
    partial class ctrlPersonWithFilter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ctrlPersonInfo1 = new SimpleClinic.ctrlPersonInfo();
            this.gBoxFilter = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxFilterBy = new System.Windows.Forms.TextBox();
            this.comBoxFilterBy = new System.Windows.Forms.ComboBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.gBoxFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlPersonInfo1
            // 
            this.ctrlPersonInfo1.Location = new System.Drawing.Point(14, 68);
            this.ctrlPersonInfo1.Name = "ctrlPersonInfo1";
            this.ctrlPersonInfo1.Size = new System.Drawing.Size(775, 247);
            this.ctrlPersonInfo1.TabIndex = 0;
            // 
            // gBoxFilter
            // 
            this.gBoxFilter.Controls.Add(this.btnFind);
            this.gBoxFilter.Controls.Add(this.txtBoxFilterBy);
            this.gBoxFilter.Controls.Add(this.comBoxFilterBy);
            this.gBoxFilter.Controls.Add(this.label1);
            this.gBoxFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxFilter.Location = new System.Drawing.Point(14, 3);
            this.gBoxFilter.Name = "gBoxFilter";
            this.gBoxFilter.Size = new System.Drawing.Size(641, 50);
            this.gBoxFilter.TabIndex = 1;
            this.gBoxFilter.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search By:";
            // 
            // txtBoxFilterBy
            // 
            this.txtBoxFilterBy.Location = new System.Drawing.Point(277, 15);
            this.txtBoxFilterBy.MaxLength = 100;
            this.txtBoxFilterBy.Name = "txtBoxFilterBy";
            this.txtBoxFilterBy.Size = new System.Drawing.Size(198, 22);
            this.txtBoxFilterBy.TabIndex = 3;
            this.txtBoxFilterBy.TextChanged += new System.EventHandler(this.txtBoxFilterBy_TextChanged);
            this.txtBoxFilterBy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxFilterBy_KeyPress);
            // 
            // comBoxFilterBy
            // 
            this.comBoxFilterBy.FormattingEnabled = true;
            this.comBoxFilterBy.Items.AddRange(new object[] {
            "National Number",
            "Full Name"});
            this.comBoxFilterBy.Location = new System.Drawing.Point(104, 14);
            this.comBoxFilterBy.Name = "comBoxFilterBy";
            this.comBoxFilterBy.Size = new System.Drawing.Size(148, 24);
            this.comBoxFilterBy.TabIndex = 4;
            this.comBoxFilterBy.SelectedIndexChanged += new System.EventHandler(this.comBoxFilterBy_SelectedIndexChanged);
            // 
            // btnFind
            // 
            this.btnFind.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnFind.Location = new System.Drawing.Point(501, 14);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(96, 25);
            this.btnFind.TabIndex = 5;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // ctrlPersonWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gBoxFilter);
            this.Controls.Add(this.ctrlPersonInfo1);
            this.Name = "ctrlPersonWithFilter";
            this.Size = new System.Drawing.Size(802, 332);
            this.Load += new System.EventHandler(this.ctrlPersonWithFilter_Load);
            this.gBoxFilter.ResumeLayout(false);
            this.gBoxFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlPersonInfo ctrlPersonInfo1;
        private System.Windows.Forms.GroupBox gBoxFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxFilterBy;
        private System.Windows.Forms.ComboBox comBoxFilterBy;
        private System.Windows.Forms.Button btnFind;
    }
}
