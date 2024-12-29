namespace SimpleClinic
{
    partial class frmAddEditUser
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
            this.gBoxUserInfo = new System.Windows.Forms.GroupBox();
            this.rbCustom = new System.Windows.Forms.RadioButton();
            this.rbFullControl = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxUserName = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnShowHidePassword = new System.Windows.Forms.Button();
            this.ctrlEmployeeWithFilter1 = new SimpleClinic.ctrlEmployeeWithFilter();
            this.gBoxUserInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblTitle.Location = new System.Drawing.Point(366, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(0, 38);
            this.lblTitle.TabIndex = 1;
            // 
            // gBoxUserInfo
            // 
            this.gBoxUserInfo.Controls.Add(this.btnShowHidePassword);
            this.gBoxUserInfo.Controls.Add(this.rbCustom);
            this.gBoxUserInfo.Controls.Add(this.rbFullControl);
            this.gBoxUserInfo.Controls.Add(this.label3);
            this.gBoxUserInfo.Controls.Add(this.label2);
            this.gBoxUserInfo.Controls.Add(this.txtBoxPassword);
            this.gBoxUserInfo.Controls.Add(this.label1);
            this.gBoxUserInfo.Controls.Add(this.txtBoxUserName);
            this.gBoxUserInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxUserInfo.Location = new System.Drawing.Point(13, 414);
            this.gBoxUserInfo.Name = "gBoxUserInfo";
            this.gBoxUserInfo.Size = new System.Drawing.Size(841, 100);
            this.gBoxUserInfo.TabIndex = 2;
            this.gBoxUserInfo.TabStop = false;
            this.gBoxUserInfo.Text = "User Info";
            // 
            // rbCustom
            // 
            this.rbCustom.AutoSize = true;
            this.rbCustom.Location = new System.Drawing.Point(596, 29);
            this.rbCustom.Name = "rbCustom";
            this.rbCustom.Size = new System.Drawing.Size(79, 20);
            this.rbCustom.TabIndex = 10;
            this.rbCustom.TabStop = true;
            this.rbCustom.Text = "Custom";
            this.rbCustom.UseVisualStyleBackColor = true;
            this.rbCustom.Click += new System.EventHandler(this.rbCustom_Click);
            // 
            // rbFullControl
            // 
            this.rbFullControl.AutoSize = true;
            this.rbFullControl.Location = new System.Drawing.Point(461, 31);
            this.rbFullControl.Name = "rbFullControl";
            this.rbFullControl.Size = new System.Drawing.Size(106, 20);
            this.rbFullControl.TabIndex = 9;
            this.rbFullControl.TabStop = true;
            this.rbFullControl.Text = "Full Control";
            this.rbFullControl.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Permission Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Location = new System.Drawing.Point(122, 61);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(185, 22);
            this.txtBoxPassword.TabIndex = 7;
            this.txtBoxPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "User Name:";
            // 
            // txtBoxUserName
            // 
            this.txtBoxUserName.Location = new System.Drawing.Point(122, 25);
            this.txtBoxUserName.Name = "txtBoxUserName";
            this.txtBoxUserName.Size = new System.Drawing.Size(185, 22);
            this.txtBoxUserName.TabIndex = 5;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Crimson;
            this.btnClose.Location = new System.Drawing.Point(748, 552);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(106, 35);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSave.Location = new System.Drawing.Point(608, 552);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 35);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnShowHidePassword
            // 
            this.btnShowHidePassword.BackgroundImage = global::SimpleClinic.Properties.Resources.eye;
            this.btnShowHidePassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnShowHidePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowHidePassword.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnShowHidePassword.Location = new System.Drawing.Point(313, 56);
            this.btnShowHidePassword.Name = "btnShowHidePassword";
            this.btnShowHidePassword.Size = new System.Drawing.Size(34, 33);
            this.btnShowHidePassword.TabIndex = 5;
            this.btnShowHidePassword.UseVisualStyleBackColor = true;
            this.btnShowHidePassword.Click += new System.EventHandler(this.btnShowHidePassword_Click);
            // 
            // ctrlEmployeeWithFilter1
            // 
            this.ctrlEmployeeWithFilter1.Location = new System.Drawing.Point(13, 68);
            this.ctrlEmployeeWithFilter1.Name = "ctrlEmployeeWithFilter1";
            this.ctrlEmployeeWithFilter1.Size = new System.Drawing.Size(841, 340);
            this.ctrlEmployeeWithFilter1.TabIndex = 0;
            // 
            // frmAddEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 599);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gBoxUserInfo);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.ctrlEmployeeWithFilter1);
            this.Name = "frmAddEditUser";
            this.Load += new System.EventHandler(this.frmAddEditUser_Load);
            this.gBoxUserInfo.ResumeLayout(false);
            this.gBoxUserInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gBoxUserInfo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.TextBox txtBoxUserName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RadioButton rbCustom;
        private System.Windows.Forms.RadioButton rbFullControl;
        private System.Windows.Forms.Label label3;
        private ctrlEmployeeWithFilter ctrlEmployeeWithFilter1;
        private System.Windows.Forms.Button btnShowHidePassword;
    }
}