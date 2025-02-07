namespace SimpleClinic
{
    partial class ctrlMedicalRecordInfo
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
            this.lblID = new System.Windows.Forms.Label();
            this.lblAppointmentID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDiagnosis = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.linkLblAppointmentInfo = new System.Windows.Forms.LinkLabel();
            this.linkLblShowPrescriptions = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(124, 13);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(36, 16);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "[???]";
            // 
            // lblAppointmentID
            // 
            this.lblAppointmentID.AutoSize = true;
            this.lblAppointmentID.Location = new System.Drawing.Point(124, 67);
            this.lblAppointmentID.Name = "lblAppointmentID";
            this.lblAppointmentID.Size = new System.Drawing.Size(36, 16);
            this.lblAppointmentID.TabIndex = 3;
            this.lblAppointmentID.Text = "[???]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "AppointmentID: ";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(346, 67);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(36, 16);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "[???]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(248, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Description: ";
            // 
            // lblDiagnosis
            // 
            this.lblDiagnosis.AutoSize = true;
            this.lblDiagnosis.Location = new System.Drawing.Point(346, 13);
            this.lblDiagnosis.Name = "lblDiagnosis";
            this.lblDiagnosis.Size = new System.Drawing.Size(36, 16);
            this.lblDiagnosis.TabIndex = 7;
            this.lblDiagnosis.Text = "[???]";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(248, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Diagnosis";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(124, 121);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(36, 16);
            this.lblDate.TabIndex = 9;
            this.lblDate.Text = "[???]";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 16);
            this.label10.TabIndex = 8;
            this.label10.Text = "Date: ";
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(346, 121);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(36, 16);
            this.lblNotes.TabIndex = 11;
            this.lblNotes.Text = "[???]";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(248, 121);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 16);
            this.label12.TabIndex = 10;
            this.label12.Text = "Notes: ";
            // 
            // linkLblAppointmentInfo
            // 
            this.linkLblAppointmentInfo.AutoSize = true;
            this.linkLblAppointmentInfo.Location = new System.Drawing.Point(14, 162);
            this.linkLblAppointmentInfo.Name = "linkLblAppointmentInfo";
            this.linkLblAppointmentInfo.Size = new System.Drawing.Size(193, 16);
            this.linkLblAppointmentInfo.TabIndex = 12;
            this.linkLblAppointmentInfo.TabStop = true;
            this.linkLblAppointmentInfo.Text = "Show Appointment Informations";
            this.linkLblAppointmentInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblAppointmentInfo_LinkClicked);
            // 
            // linkLblShowPrescriptions
            // 
            this.linkLblShowPrescriptions.AutoSize = true;
            this.linkLblShowPrescriptions.Location = new System.Drawing.Point(346, 162);
            this.linkLblShowPrescriptions.Name = "linkLblShowPrescriptions";
            this.linkLblShowPrescriptions.Size = new System.Drawing.Size(121, 16);
            this.linkLblShowPrescriptions.TabIndex = 13;
            this.linkLblShowPrescriptions.TabStop = true;
            this.linkLblShowPrescriptions.Text = "Show Prescriptions";
            this.linkLblShowPrescriptions.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblShowPrescriptions_LinkClicked);
            // 
            // ctrlMedicalRecordInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.linkLblShowPrescriptions);
            this.Controls.Add(this.linkLblAppointmentInfo);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblDiagnosis);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblAppointmentID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.label1);
            this.Name = "ctrlMedicalRecordInfo";
            this.Size = new System.Drawing.Size(746, 194);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblAppointmentID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDiagnosis;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.LinkLabel linkLblAppointmentInfo;
        private System.Windows.Forms.LinkLabel linkLblShowPrescriptions;
    }
}
