namespace SimpleClinic
{
    partial class ctrlEmployeeWithFilter
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
            this.gBoxFind = new System.Windows.Forms.GroupBox();
            this.linkLblPersonInfo = new System.Windows.Forms.LinkLabel();
            this.txtBoxFilter = new System.Windows.Forms.TextBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.ctrlEmployeeInfo1 = new SimpleClinic.ctrlEmployeeInfo();
            this.gBoxFind.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxFind
            // 
            this.gBoxFind.Controls.Add(this.ctrlEmployeeInfo1);
            this.gBoxFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxFind.Location = new System.Drawing.Point(12, 53);
            this.gBoxFind.Name = "gBoxFind";
            this.gBoxFind.Size = new System.Drawing.Size(817, 231);
            this.gBoxFind.TabIndex = 1;
            this.gBoxFind.TabStop = false;
            this.gBoxFind.Text = "Employee Info";
            // 
            // linkLblPersonInfo
            // 
            this.linkLblPersonInfo.AutoSize = true;
            this.linkLblPersonInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLblPersonInfo.Location = new System.Drawing.Point(5, 296);
            this.linkLblPersonInfo.Name = "linkLblPersonInfo";
            this.linkLblPersonInfo.Size = new System.Drawing.Size(141, 16);
            this.linkLblPersonInfo.TabIndex = 2;
            this.linkLblPersonInfo.TabStop = true;
            this.linkLblPersonInfo.Text = "See Person Details";
            this.linkLblPersonInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblPersonInfo_LinkClicked);
            // 
            // txtBoxFilter
            // 
            this.txtBoxFilter.Location = new System.Drawing.Point(206, 16);
            this.txtBoxFilter.MaxLength = 10;
            this.txtBoxFilter.Name = "txtBoxFilter";
            this.txtBoxFilter.Size = new System.Drawing.Size(100, 22);
            this.txtBoxFilter.TabIndex = 6;
            this.txtBoxFilter.TextChanged += new System.EventHandler(this.txtBoxFilter_TextChanged);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.Location = new System.Drawing.Point(11, 19);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(171, 16);
            this.lblFilter.TabIndex = 5;
            this.lblFilter.Text = "Enter The Employee ID:";
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ForeColor = System.Drawing.Color.Green;
            this.btnFind.Location = new System.Drawing.Point(340, 7);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(119, 40);
            this.btnFind.TabIndex = 4;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // ctrlEmployeeInfo1
            // 
            this.ctrlEmployeeInfo1.Location = new System.Drawing.Point(10, 21);
            this.ctrlEmployeeInfo1.Name = "ctrlEmployeeInfo1";
            this.ctrlEmployeeInfo1.Size = new System.Drawing.Size(796, 180);
            this.ctrlEmployeeInfo1.TabIndex = 4;
            // 
            // ctrlEmployeeWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtBoxFilter);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.linkLblPersonInfo);
            this.Controls.Add(this.gBoxFind);
            this.Name = "ctrlEmployeeWithFilter";
            this.Size = new System.Drawing.Size(841, 329);
            this.gBoxFind.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gBoxFind;
        private ctrlEmployeeInfo ctrlEmployeeInfo1;
        private System.Windows.Forms.LinkLabel linkLblPersonInfo;
        private System.Windows.Forms.TextBox txtBoxFilter;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Button btnFind;
    }
}
