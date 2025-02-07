namespace SimpleClinic
{
    partial class ctrlAppointmentInfo
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
            this.lblAppointmentID = new System.Windows.Forms.Label();
            this.lblPatientID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDoctorID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblAppointmentDate = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblAppointmentStatus = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.linkLblPatientInfo = new System.Windows.Forms.LinkLabel();
            this.linkLblDoctorInfo = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Appointment ID:";
            // 
            // lblAppointmentID
            // 
            this.lblAppointmentID.AutoSize = true;
            this.lblAppointmentID.Location = new System.Drawing.Point(131, 15);
            this.lblAppointmentID.Name = "lblAppointmentID";
            this.lblAppointmentID.Size = new System.Drawing.Size(0, 16);
            this.lblAppointmentID.TabIndex = 1;
            // 
            // lblPatientID
            // 
            this.lblPatientID.AutoSize = true;
            this.lblPatientID.Location = new System.Drawing.Point(131, 55);
            this.lblPatientID.Name = "lblPatientID";
            this.lblPatientID.Size = new System.Drawing.Size(0, 16);
            this.lblPatientID.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Patient ID:";
            // 
            // lblDoctorID
            // 
            this.lblDoctorID.AutoSize = true;
            this.lblDoctorID.Location = new System.Drawing.Point(131, 95);
            this.lblDoctorID.Name = "lblDoctorID";
            this.lblDoctorID.Size = new System.Drawing.Size(0, 16);
            this.lblDoctorID.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Doctor ID: ";
            // 
            // lblAppointmentDate
            // 
            this.lblAppointmentDate.AutoSize = true;
            this.lblAppointmentDate.Location = new System.Drawing.Point(460, 15);
            this.lblAppointmentDate.Name = "lblAppointmentDate";
            this.lblAppointmentDate.Size = new System.Drawing.Size(0, 16);
            this.lblAppointmentDate.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(320, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Appointment Date:";
            // 
            // lblAppointmentStatus
            // 
            this.lblAppointmentStatus.AutoSize = true;
            this.lblAppointmentStatus.Location = new System.Drawing.Point(460, 55);
            this.lblAppointmentStatus.Name = "lblAppointmentStatus";
            this.lblAppointmentStatus.Size = new System.Drawing.Size(0, 16);
            this.lblAppointmentStatus.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(320, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 16);
            this.label10.TabIndex = 8;
            this.label10.Text = "Appointment Status";
            // 
            // linkLblPatientInfo
            // 
            this.linkLblPatientInfo.AutoSize = true;
            this.linkLblPatientInfo.Location = new System.Drawing.Point(237, 95);
            this.linkLblPatientInfo.Name = "linkLblPatientInfo";
            this.linkLblPatientInfo.Size = new System.Drawing.Size(108, 16);
            this.linkLblPatientInfo.TabIndex = 10;
            this.linkLblPatientInfo.TabStop = true;
            this.linkLblPatientInfo.Text = "Show Patient Info";
            this.linkLblPatientInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblPatientInfo_LinkClicked);
            // 
            // linkLblDoctorInfo
            // 
            this.linkLblDoctorInfo.AutoSize = true;
            this.linkLblDoctorInfo.Location = new System.Drawing.Point(450, 95);
            this.linkLblDoctorInfo.Name = "linkLblDoctorInfo";
            this.linkLblDoctorInfo.Size = new System.Drawing.Size(107, 16);
            this.linkLblDoctorInfo.TabIndex = 11;
            this.linkLblDoctorInfo.TabStop = true;
            this.linkLblDoctorInfo.Text = "Show Doctor Info";
            this.linkLblDoctorInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblDoctorInfo_LinkClicked);
            // 
            // ctrlAppointmentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.linkLblDoctorInfo);
            this.Controls.Add(this.linkLblPatientInfo);
            this.Controls.Add(this.lblAppointmentStatus);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblAppointmentDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblDoctorID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblPatientID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblAppointmentID);
            this.Controls.Add(this.label1);
            this.Name = "ctrlAppointmentInfo";
            this.Size = new System.Drawing.Size(656, 126);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAppointmentID;
        private System.Windows.Forms.Label lblPatientID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDoctorID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblAppointmentDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblAppointmentStatus;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.LinkLabel linkLblPatientInfo;
        private System.Windows.Forms.LinkLabel linkLblDoctorInfo;
    }
}
