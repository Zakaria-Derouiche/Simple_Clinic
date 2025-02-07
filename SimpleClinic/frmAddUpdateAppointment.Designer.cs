namespace SimpleClinic
{
    partial class frmAddUpdateAppointment
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAppointmentID = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLblMedicalRecordInfo = new System.Windows.Forms.LinkLabel();
            this.lblDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpAppointmentDate = new System.Windows.Forms.DateTimePicker();
            this.comBoxAppointmentStatus = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gBoxPatient = new System.Windows.Forms.GroupBox();
            this.gBoxDoctor = new System.Windows.Forms.GroupBox();
            this.ctrlDoctorInfoWithFilter1 = new SimpleClinic.ctrlDoctorInfoWithFilter();
            this.ctrlPatientInfoWithFilter1 = new SimpleClinic.ctrlPatientInfoWithFilter();
            this.groupBox1.SuspendLayout();
            this.gBoxPatient.SuspendLayout();
            this.gBoxDoctor.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblTitle.Location = new System.Drawing.Point(563, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(0, 42);
            this.lblTitle.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Appointment ID: ";
            // 
            // lblAppointmentID
            // 
            this.lblAppointmentID.AutoSize = true;
            this.lblAppointmentID.Location = new System.Drawing.Point(143, 36);
            this.lblAppointmentID.Name = "lblAppointmentID";
            this.lblAppointmentID.Size = new System.Drawing.Size(0, 16);
            this.lblAppointmentID.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpAppointmentDate);
            this.groupBox1.Controls.Add(this.comBoxAppointmentStatus);
            this.groupBox1.Controls.Add(this.lblAppointmentID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(814, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 274);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Appointment Informations";
            // 
            // linkLblMedicalRecordInfo
            // 
            this.linkLblMedicalRecordInfo.AutoSize = true;
            this.linkLblMedicalRecordInfo.Location = new System.Drawing.Point(862, 359);
            this.linkLblMedicalRecordInfo.Name = "linkLblMedicalRecordInfo";
            this.linkLblMedicalRecordInfo.Size = new System.Drawing.Size(214, 16);
            this.linkLblMedicalRecordInfo.TabIndex = 15;
            this.linkLblMedicalRecordInfo.TabStop = true;
            this.linkLblMedicalRecordInfo.Text = "Show Medical Record Informations";
            this.linkLblMedicalRecordInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblMedicalRecordInfo_LinkClicked);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(19, 176);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(92, 16);
            this.lblDate.TabIndex = 14;
            this.lblDate.Text = "Change Date: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Change Status: ";
            // 
            // dtpAppointmentDate
            // 
            this.dtpAppointmentDate.CustomFormat = "";
            this.dtpAppointmentDate.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpAppointmentDate.Location = new System.Drawing.Point(140, 171);
            this.dtpAppointmentDate.Name = "dtpAppointmentDate";
            this.dtpAppointmentDate.Size = new System.Drawing.Size(154, 22);
            this.dtpAppointmentDate.TabIndex = 12;
            // 
            // comBoxAppointmentStatus
            // 
            this.comBoxAppointmentStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxAppointmentStatus.FormattingEnabled = true;
            this.comBoxAppointmentStatus.Items.AddRange(new object[] {
            "Pending",
            "Confirmed",
            "Completed",
            "Canceled",
            "Rescheduled",
            "No Show"});
            this.comBoxAppointmentStatus.Location = new System.Drawing.Point(140, 102);
            this.comBoxAppointmentStatus.Name = "comBoxAppointmentStatus";
            this.comBoxAppointmentStatus.Size = new System.Drawing.Size(154, 24);
            this.comBoxAppointmentStatus.TabIndex = 11;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(1001, 500);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(123, 35);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnSave.Location = new System.Drawing.Point(814, 500);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(123, 35);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gBoxPatient
            // 
            this.gBoxPatient.Controls.Add(this.ctrlPatientInfoWithFilter1);
            this.gBoxPatient.Location = new System.Drawing.Point(12, 51);
            this.gBoxPatient.Name = "gBoxPatient";
            this.gBoxPatient.Size = new System.Drawing.Size(777, 233);
            this.gBoxPatient.TabIndex = 8;
            this.gBoxPatient.TabStop = false;
            this.gBoxPatient.Text = "Patient Informations";
            // 
            // gBoxDoctor
            // 
            this.gBoxDoctor.Controls.Add(this.ctrlDoctorInfoWithFilter1);
            this.gBoxDoctor.Location = new System.Drawing.Point(12, 290);
            this.gBoxDoctor.Name = "gBoxDoctor";
            this.gBoxDoctor.Size = new System.Drawing.Size(777, 245);
            this.gBoxDoctor.TabIndex = 9;
            this.gBoxDoctor.TabStop = false;
            this.gBoxDoctor.Text = "Doctor Infromations";
            // 
            // ctrlDoctorInfoWithFilter1
            // 
            this.ctrlDoctorInfoWithFilter1.Location = new System.Drawing.Point(10, 30);
            this.ctrlDoctorInfoWithFilter1.Name = "ctrlDoctorInfoWithFilter1";
            this.ctrlDoctorInfoWithFilter1.Size = new System.Drawing.Size(756, 190);
            this.ctrlDoctorInfoWithFilter1.TabIndex = 4;
            // 
            // ctrlPatientInfoWithFilter1
            // 
            this.ctrlPatientInfoWithFilter1.Location = new System.Drawing.Point(10, 21);
            this.ctrlPatientInfoWithFilter1.Name = "ctrlPatientInfoWithFilter1";
            this.ctrlPatientInfoWithFilter1.Size = new System.Drawing.Size(756, 190);
            this.ctrlPatientInfoWithFilter1.TabIndex = 3;
            // 
            // frmAddUpdateAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 547);
            this.Controls.Add(this.linkLblMedicalRecordInfo);
            this.Controls.Add(this.gBoxDoctor);
            this.Controls.Add(this.gBoxPatient);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddUpdateAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Appointment";
            this.Load += new System.EventHandler(this.frmAddUpdateAppointment_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gBoxPatient.ResumeLayout(false);
            this.gBoxDoctor.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private ctrlPatientInfoWithFilter ctrlPatientInfoWithFilter1;
        private ctrlDoctorInfoWithFilter ctrlDoctorInfoWithFilter1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAppointmentID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comBoxAppointmentStatus;
        private System.Windows.Forms.DateTimePicker dtpAppointmentDate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gBoxPatient;
        private System.Windows.Forms.GroupBox gBoxDoctor;
        private System.Windows.Forms.LinkLabel linkLblMedicalRecordInfo;
    }
}