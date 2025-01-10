namespace SimpleClinic
{
    partial class frmMenu
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
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.peopleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peopleListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientsListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findAnEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeesListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addADoctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findADoctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorsListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appointmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAnAppontmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findAnAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byDoctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appointmentsListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicalRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAMedicalRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicalRecordPerPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicalRecordsListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prescriptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAPrescriptioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findPrescriptionByPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentsListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currntUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.AutoSize = false;
            this.menuStripMain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.peopleToolStripMenuItem,
            this.patientsToolStripMenuItem,
            this.employeesToolStripMenuItem,
            this.doctorsToolStripMenuItem,
            this.appointmentsToolStripMenuItem,
            this.medicalRecordsToolStripMenuItem,
            this.prescriptionsToolStripMenuItem,
            this.paymentsToolStripMenuItem,
            this.usersToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(1327, 50);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // peopleToolStripMenuItem
            // 
            this.peopleToolStripMenuItem.AutoSize = false;
            this.peopleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPersonToolStripMenuItem,
            this.findPersonToolStripMenuItem,
            this.peopleListToolStripMenuItem});
            this.peopleToolStripMenuItem.Name = "peopleToolStripMenuItem";
            this.peopleToolStripMenuItem.Size = new System.Drawing.Size(140, 40);
            this.peopleToolStripMenuItem.Text = "People";
            // 
            // addPersonToolStripMenuItem
            // 
            this.addPersonToolStripMenuItem.Name = "addPersonToolStripMenuItem";
            this.addPersonToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addPersonToolStripMenuItem.Text = "Add A Person";
            this.addPersonToolStripMenuItem.Click += new System.EventHandler(this.addPersonToolStripMenuItem_Click);
            // 
            // findPersonToolStripMenuItem
            // 
            this.findPersonToolStripMenuItem.Name = "findPersonToolStripMenuItem";
            this.findPersonToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.findPersonToolStripMenuItem.Text = "Find A Person";
            this.findPersonToolStripMenuItem.Click += new System.EventHandler(this.findPersonToolStripMenuItem_Click);
            // 
            // peopleListToolStripMenuItem
            // 
            this.peopleListToolStripMenuItem.Name = "peopleListToolStripMenuItem";
            this.peopleListToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.peopleListToolStripMenuItem.Text = "People List";
            this.peopleListToolStripMenuItem.Click += new System.EventHandler(this.peopleListToolStripMenuItem_Click);
            // 
            // patientsToolStripMenuItem
            // 
            this.patientsToolStripMenuItem.AutoSize = false;
            this.patientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPatientToolStripMenuItem,
            this.patientsListToolStripMenuItem,
            this.patientListToolStripMenuItem});
            this.patientsToolStripMenuItem.Name = "patientsToolStripMenuItem";
            this.patientsToolStripMenuItem.Size = new System.Drawing.Size(140, 40);
            this.patientsToolStripMenuItem.Text = "Patients";
            // 
            // addPatientToolStripMenuItem
            // 
            this.addPatientToolStripMenuItem.Name = "addPatientToolStripMenuItem";
            this.addPatientToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addPatientToolStripMenuItem.Text = "Add A Patient";
            this.addPatientToolStripMenuItem.Click += new System.EventHandler(this.addPatientToolStripMenuItem_Click);
            // 
            // patientsListToolStripMenuItem
            // 
            this.patientsListToolStripMenuItem.Name = "patientsListToolStripMenuItem";
            this.patientsListToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.patientsListToolStripMenuItem.Text = "Find A Patient";
            this.patientsListToolStripMenuItem.Click += new System.EventHandler(this.patientsListToolStripMenuItem_Click);
            // 
            // patientListToolStripMenuItem
            // 
            this.patientListToolStripMenuItem.Name = "patientListToolStripMenuItem";
            this.patientListToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.patientListToolStripMenuItem.Text = "Patient List";
            this.patientListToolStripMenuItem.Click += new System.EventHandler(this.patientListToolStripMenuItem_Click);
            // 
            // employeesToolStripMenuItem
            // 
            this.employeesToolStripMenuItem.AutoSize = false;
            this.employeesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEmployeeToolStripMenuItem,
            this.findAnEmployeeToolStripMenuItem,
            this.employeesListToolStripMenuItem});
            this.employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            this.employeesToolStripMenuItem.Size = new System.Drawing.Size(140, 40);
            this.employeesToolStripMenuItem.Text = "Employees";
            // 
            // addEmployeeToolStripMenuItem
            // 
            this.addEmployeeToolStripMenuItem.Name = "addEmployeeToolStripMenuItem";
            this.addEmployeeToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.addEmployeeToolStripMenuItem.Text = "Add An Employee";
            this.addEmployeeToolStripMenuItem.Click += new System.EventHandler(this.addEmployeeToolStripMenuItem_Click);
            // 
            // findAnEmployeeToolStripMenuItem
            // 
            this.findAnEmployeeToolStripMenuItem.Name = "findAnEmployeeToolStripMenuItem";
            this.findAnEmployeeToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.findAnEmployeeToolStripMenuItem.Text = "Find An Employee";
            this.findAnEmployeeToolStripMenuItem.Click += new System.EventHandler(this.findAnEmployeeToolStripMenuItem_Click);
            // 
            // employeesListToolStripMenuItem
            // 
            this.employeesListToolStripMenuItem.Name = "employeesListToolStripMenuItem";
            this.employeesListToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.employeesListToolStripMenuItem.Text = "Employees List";
            this.employeesListToolStripMenuItem.Click += new System.EventHandler(this.employeesListToolStripMenuItem_Click);
            // 
            // doctorsToolStripMenuItem
            // 
            this.doctorsToolStripMenuItem.AutoSize = false;
            this.doctorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addADoctorToolStripMenuItem,
            this.findADoctorToolStripMenuItem,
            this.doctorsListToolStripMenuItem});
            this.doctorsToolStripMenuItem.Name = "doctorsToolStripMenuItem";
            this.doctorsToolStripMenuItem.Size = new System.Drawing.Size(140, 40);
            this.doctorsToolStripMenuItem.Text = "Doctors";
            // 
            // addADoctorToolStripMenuItem
            // 
            this.addADoctorToolStripMenuItem.Name = "addADoctorToolStripMenuItem";
            this.addADoctorToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.addADoctorToolStripMenuItem.Text = "Add A doctor";
            this.addADoctorToolStripMenuItem.Click += new System.EventHandler(this.addADoctorToolStripMenuItem_Click);
            // 
            // findADoctorToolStripMenuItem
            // 
            this.findADoctorToolStripMenuItem.Name = "findADoctorToolStripMenuItem";
            this.findADoctorToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.findADoctorToolStripMenuItem.Text = "Find A doctor";
            this.findADoctorToolStripMenuItem.Click += new System.EventHandler(this.findADoctorToolStripMenuItem_Click);
            // 
            // doctorsListToolStripMenuItem
            // 
            this.doctorsListToolStripMenuItem.Name = "doctorsListToolStripMenuItem";
            this.doctorsListToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.doctorsListToolStripMenuItem.Text = "Doctors List";
            this.doctorsListToolStripMenuItem.Click += new System.EventHandler(this.doctorsListToolStripMenuItem_Click);
            // 
            // appointmentsToolStripMenuItem
            // 
            this.appointmentsToolStripMenuItem.AutoSize = false;
            this.appointmentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAnAppontmentToolStripMenuItem,
            this.findAnAppointmentToolStripMenuItem,
            this.appointmentsListToolStripMenuItem});
            this.appointmentsToolStripMenuItem.Name = "appointmentsToolStripMenuItem";
            this.appointmentsToolStripMenuItem.Size = new System.Drawing.Size(140, 40);
            this.appointmentsToolStripMenuItem.Text = "Appointments";
            // 
            // addAnAppontmentToolStripMenuItem
            // 
            this.addAnAppontmentToolStripMenuItem.Name = "addAnAppontmentToolStripMenuItem";
            this.addAnAppontmentToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.addAnAppontmentToolStripMenuItem.Text = "Add An Appointment";
            this.addAnAppontmentToolStripMenuItem.Click += new System.EventHandler(this.addAnAppontmentToolStripMenuItem_Click);
            // 
            // findAnAppointmentToolStripMenuItem
            // 
            this.findAnAppointmentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.byPatientToolStripMenuItem,
            this.byDoctorToolStripMenuItem});
            this.findAnAppointmentToolStripMenuItem.Name = "findAnAppointmentToolStripMenuItem";
            this.findAnAppointmentToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.findAnAppointmentToolStripMenuItem.Text = "Find An Appointment";
            this.findAnAppointmentToolStripMenuItem.Click += new System.EventHandler(this.findAnAppointmentToolStripMenuItem_Click);
            // 
            // byPatientToolStripMenuItem
            // 
            this.byPatientToolStripMenuItem.Name = "byPatientToolStripMenuItem";
            this.byPatientToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.byPatientToolStripMenuItem.Text = "By Patient";
            // 
            // byDoctorToolStripMenuItem
            // 
            this.byDoctorToolStripMenuItem.Name = "byDoctorToolStripMenuItem";
            this.byDoctorToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.byDoctorToolStripMenuItem.Text = "By Doctor";
            // 
            // appointmentsListToolStripMenuItem
            // 
            this.appointmentsListToolStripMenuItem.Name = "appointmentsListToolStripMenuItem";
            this.appointmentsListToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.appointmentsListToolStripMenuItem.Text = "Appointments List";
            this.appointmentsListToolStripMenuItem.Click += new System.EventHandler(this.appointmentsListToolStripMenuItem_Click);
            // 
            // medicalRecordsToolStripMenuItem
            // 
            this.medicalRecordsToolStripMenuItem.AutoSize = false;
            this.medicalRecordsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAMedicalRecordToolStripMenuItem,
            this.medicalRecordPerPatientToolStripMenuItem,
            this.medicalRecordsListToolStripMenuItem});
            this.medicalRecordsToolStripMenuItem.Name = "medicalRecordsToolStripMenuItem";
            this.medicalRecordsToolStripMenuItem.Size = new System.Drawing.Size(140, 40);
            this.medicalRecordsToolStripMenuItem.Text = "Medical Records";
            // 
            // addAMedicalRecordToolStripMenuItem
            // 
            this.addAMedicalRecordToolStripMenuItem.Name = "addAMedicalRecordToolStripMenuItem";
            this.addAMedicalRecordToolStripMenuItem.Size = new System.Drawing.Size(280, 26);
            this.addAMedicalRecordToolStripMenuItem.Text = "Add A medical Record";
            this.addAMedicalRecordToolStripMenuItem.Click += new System.EventHandler(this.addAMedicalRecordToolStripMenuItem_Click);
            // 
            // medicalRecordPerPatientToolStripMenuItem
            // 
            this.medicalRecordPerPatientToolStripMenuItem.Name = "medicalRecordPerPatientToolStripMenuItem";
            this.medicalRecordPerPatientToolStripMenuItem.Size = new System.Drawing.Size(280, 26);
            this.medicalRecordPerPatientToolStripMenuItem.Text = "Medical Record Per Patient";
            this.medicalRecordPerPatientToolStripMenuItem.Click += new System.EventHandler(this.medicalRecordPerPatientToolStripMenuItem_Click);
            // 
            // medicalRecordsListToolStripMenuItem
            // 
            this.medicalRecordsListToolStripMenuItem.Name = "medicalRecordsListToolStripMenuItem";
            this.medicalRecordsListToolStripMenuItem.Size = new System.Drawing.Size(280, 26);
            this.medicalRecordsListToolStripMenuItem.Text = "Medical Records List";
            this.medicalRecordsListToolStripMenuItem.Click += new System.EventHandler(this.medicalRecordsListToolStripMenuItem_Click);
            // 
            // prescriptionsToolStripMenuItem
            // 
            this.prescriptionsToolStripMenuItem.AutoSize = false;
            this.prescriptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAPrescriptioToolStripMenuItem,
            this.findPrescriptionByPatientToolStripMenuItem});
            this.prescriptionsToolStripMenuItem.Name = "prescriptionsToolStripMenuItem";
            this.prescriptionsToolStripMenuItem.Size = new System.Drawing.Size(140, 40);
            this.prescriptionsToolStripMenuItem.Text = "Prescriptions";
            // 
            // addAPrescriptioToolStripMenuItem
            // 
            this.addAPrescriptioToolStripMenuItem.Name = "addAPrescriptioToolStripMenuItem";
            this.addAPrescriptioToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addAPrescriptioToolStripMenuItem.Text = "Add A Prescription";
            this.addAPrescriptioToolStripMenuItem.Click += new System.EventHandler(this.addAPrescriptioToolStripMenuItem_Click);
            // 
            // findPrescriptionByPatientToolStripMenuItem
            // 
            this.findPrescriptionByPatientToolStripMenuItem.Name = "findPrescriptionByPatientToolStripMenuItem";
            this.findPrescriptionByPatientToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.findPrescriptionByPatientToolStripMenuItem.Text = "Find Prescription";
            this.findPrescriptionByPatientToolStripMenuItem.Click += new System.EventHandler(this.findPrescriptionByPatientToolStripMenuItem_Click);
            // 
            // paymentsToolStripMenuItem
            // 
            this.paymentsToolStripMenuItem.AutoSize = false;
            this.paymentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAPaymentToolStripMenuItem,
            this.paymentsListToolStripMenuItem});
            this.paymentsToolStripMenuItem.Name = "paymentsToolStripMenuItem";
            this.paymentsToolStripMenuItem.Size = new System.Drawing.Size(140, 40);
            this.paymentsToolStripMenuItem.Text = "Payments";
            // 
            // addAPaymentToolStripMenuItem
            // 
            this.addAPaymentToolStripMenuItem.Name = "addAPaymentToolStripMenuItem";
            this.addAPaymentToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.addAPaymentToolStripMenuItem.Text = "Add A Payment";
            this.addAPaymentToolStripMenuItem.Click += new System.EventHandler(this.addAPaymentToolStripMenuItem_Click);
            // 
            // paymentsListToolStripMenuItem
            // 
            this.paymentsListToolStripMenuItem.Name = "paymentsListToolStripMenuItem";
            this.paymentsListToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.paymentsListToolStripMenuItem.Text = "Payments List";
            this.paymentsListToolStripMenuItem.Click += new System.EventHandler(this.paymentsListToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.AutoSize = false;
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserToolStripMenuItem,
            this.findUserToolStripMenuItem,
            this.usersListToolStripMenuItem,
            this.currntUserToolStripMenuItem});
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(140, 40);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.addUserToolStripMenuItem.Text = "Add User";
            // 
            // findUserToolStripMenuItem
            // 
            this.findUserToolStripMenuItem.Name = "findUserToolStripMenuItem";
            this.findUserToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.findUserToolStripMenuItem.Text = "Find User";
            // 
            // usersListToolStripMenuItem
            // 
            this.usersListToolStripMenuItem.Name = "usersListToolStripMenuItem";
            this.usersListToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.usersListToolStripMenuItem.Text = "Users List";
            // 
            // currntUserToolStripMenuItem
            // 
            this.currntUserToolStripMenuItem.Name = "currntUserToolStripMenuItem";
            this.currntUserToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.currntUserToolStripMenuItem.Text = "Currnt User";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.Red;
            this.btnLogOut.Location = new System.Drawing.Point(1130, 380);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(185, 58);
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.menuStripMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem peopleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appointmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicalRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peopleListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientsListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findAnEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeesListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addADoctorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findADoctorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctorsListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAnAppontmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findAnAppointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appointmentsListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prescriptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAPrescriptioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findPrescriptionByPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byDoctorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAMedicalRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicalRecordPerPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicalRecordsListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAPaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentsListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersListToolStripMenuItem;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.ToolStripMenuItem currntUserToolStripMenuItem;
    }
}