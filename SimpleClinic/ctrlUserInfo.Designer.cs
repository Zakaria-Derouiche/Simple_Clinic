namespace SimpleClinic
{
    partial class ctrlUserInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.linkLblEmployeeInfo = new System.Windows.Forms.LinkLabel();
            this.linkLblUserPermissions = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "User ID:";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point(133, 11);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(0, 16);
            this.lblUserID.TabIndex = 1;
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Location = new System.Drawing.Point(133, 73);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(0, 16);
            this.lblEmployeeID.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Employee ID:";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(358, 11);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(0, 16);
            this.lblUserName.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(235, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "User Name:";
            // 
            // linkLblEmployeeInfo
            // 
            this.linkLblEmployeeInfo.AutoSize = true;
            this.linkLblEmployeeInfo.Location = new System.Drawing.Point(489, 73);
            this.linkLblEmployeeInfo.Name = "linkLblEmployeeInfo";
            this.linkLblEmployeeInfo.Size = new System.Drawing.Size(180, 16);
            this.linkLblEmployeeInfo.TabIndex = 6;
            this.linkLblEmployeeInfo.TabStop = true;
            this.linkLblEmployeeInfo.Text = "Show Employee Informations";
            this.linkLblEmployeeInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblEmployeeInfo_LinkClicked);
            // 
            // linkLblUserPermissions
            // 
            this.linkLblUserPermissions.AutoSize = true;
            this.linkLblUserPermissions.Location = new System.Drawing.Point(235, 73);
            this.linkLblUserPermissions.Name = "linkLblUserPermissions";
            this.linkLblUserPermissions.Size = new System.Drawing.Size(160, 16);
            this.linkLblUserPermissions.TabIndex = 7;
            this.linkLblUserPermissions.TabStop = true;
            this.linkLblUserPermissions.Text = "Show User Permmissions";
            this.linkLblUserPermissions.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblUserPermissions_LinkClicked);
            // 
            // ctrlUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.linkLblUserPermissions);
            this.Controls.Add(this.linkLblEmployeeInfo);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblEmployeeID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.label1);
            this.Name = "ctrlUserInfo";
            this.Size = new System.Drawing.Size(759, 126);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.LinkLabel linkLblEmployeeInfo;
        private System.Windows.Forms.LinkLabel linkLblUserPermissions;
    }
}
