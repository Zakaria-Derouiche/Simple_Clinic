namespace SimpleClinic
{
    partial class frmEmployeeInfo
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
            this.ctrlEmployeeInfo1 = new SimpleClinic.ctrlEmployeeInfo();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.linkLblPersonInfo = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // ctrlEmployeeInfo1
            // 
            this.ctrlEmployeeInfo1.Location = new System.Drawing.Point(12, 70);
            this.ctrlEmployeeInfo1.Name = "ctrlEmployeeInfo1";
            this.ctrlEmployeeInfo1.Size = new System.Drawing.Size(753, 225);
            this.ctrlEmployeeInfo1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(226, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employee Infromations";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Crimson;
            this.btnClose.Location = new System.Drawing.Point(673, 303);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(92, 31);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // linkLblPersonInfo
            // 
            this.linkLblPersonInfo.AutoSize = true;
            this.linkLblPersonInfo.Location = new System.Drawing.Point(12, 310);
            this.linkLblPersonInfo.Name = "linkLblPersonInfo";
            this.linkLblPersonInfo.Size = new System.Drawing.Size(158, 16);
            this.linkLblPersonInfo.TabIndex = 3;
            this.linkLblPersonInfo.TabStop = true;
            this.linkLblPersonInfo.Text = "Show Person Inormations";
            this.linkLblPersonInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblPersonInfo_LinkClicked);
            // 
            // frmEmployeeInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 353);
            this.Controls.Add(this.linkLblPersonInfo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlEmployeeInfo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEmployeeInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEmployeeInfo";
            this.Load += new System.EventHandler(this.frmEmployeeInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlEmployeeInfo ctrlEmployeeInfo1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.LinkLabel linkLblPersonInfo;
    }
}