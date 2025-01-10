namespace SimpleClinic
{
    partial class ctrlDoctorInfo
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
            this.lbl2 = new System.Windows.Forms.Label();
            this.lblDoctorID = new System.Windows.Forms.Label();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblSpecialization = new System.Windows.Forms.Label();
            this.linkLblEmployeeInfo = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(17, 24);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(66, 16);
            this.lbl2.TabIndex = 8;
            this.lbl2.Text = "Doctor ID:";
            // 
            // lblDoctorID
            // 
            this.lblDoctorID.AutoSize = true;
            this.lblDoctorID.Location = new System.Drawing.Point(147, 24);
            this.lblDoctorID.Name = "lblDoctorID";
            this.lblDoctorID.Size = new System.Drawing.Size(0, 16);
            this.lblDoctorID.TabIndex = 9;
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Location = new System.Drawing.Point(147, 86);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(0, 16);
            this.lblEmployeeID.TabIndex = 11;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(249, 24);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(94, 16);
            this.lbl1.TabIndex = 12;
            this.lbl1.Text = "Specialization:";
            // 
            // lblSpecialization
            // 
            this.lblSpecialization.AutoSize = true;
            this.lblSpecialization.Location = new System.Drawing.Point(372, 24);
            this.lblSpecialization.Name = "lblSpecialization";
            this.lblSpecialization.Size = new System.Drawing.Size(0, 16);
            this.lblSpecialization.TabIndex = 13;
            // 
            // linkLblEmployeeInfo
            // 
            this.linkLblEmployeeInfo.AutoSize = true;
            this.linkLblEmployeeInfo.Location = new System.Drawing.Point(249, 86);
            this.linkLblEmployeeInfo.Name = "linkLblEmployeeInfo";
            this.linkLblEmployeeInfo.Size = new System.Drawing.Size(180, 16);
            this.linkLblEmployeeInfo.TabIndex = 14;
            this.linkLblEmployeeInfo.TabStop = true;
            this.linkLblEmployeeInfo.Text = "Show Employee Informations";
            this.linkLblEmployeeInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblEmployeeInfo_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Employee ID:";
            // 
            // ctrlDoctorInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.linkLblEmployeeInfo);
            this.Controls.Add(this.lblSpecialization);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lblEmployeeID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblDoctorID);
            this.Controls.Add(this.lbl2);
            this.Name = "ctrlDoctorInfo";
            this.Size = new System.Drawing.Size(701, 125);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lblDoctorID;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblSpecialization;
        private System.Windows.Forms.LinkLabel linkLblEmployeeInfo;
        private System.Windows.Forms.Label label4;
    }
}
