namespace SimpleClinic
{
    partial class ctrlDoctorInfoWithFilter
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
            this.ctrlDoctorInfo1 = new SimpleClinic.ctrlDoctorInfo();
            this.btnFind = new System.Windows.Forms.Button();
            this.comboBoxFilterBy = new System.Windows.Forms.ComboBox();
            this.txtBoxFilterBy = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ctrlDoctorInfo1
            // 
            this.ctrlDoctorInfo1.Location = new System.Drawing.Point(15, 55);
            this.ctrlDoctorInfo1.Name = "ctrlDoctorInfo1";
            this.ctrlDoctorInfo1.Size = new System.Drawing.Size(701, 125);
            this.ctrlDoctorInfo1.TabIndex = 0;
            // 
            // btnFind
            // 
            this.btnFind.ForeColor = System.Drawing.Color.LightSalmon;
            this.btnFind.Location = new System.Drawing.Point(588, 7);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(100, 35);
            this.btnFind.TabIndex = 7;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // comboBoxFilterBy
            // 
            this.comboBoxFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFilterBy.FormattingEnabled = true;
            this.comboBoxFilterBy.Items.AddRange(new object[] {
            "Doctro ID",
            "Employee ID"});
            this.comboBoxFilterBy.Location = new System.Drawing.Point(156, 12);
            this.comboBoxFilterBy.Name = "comboBoxFilterBy";
            this.comboBoxFilterBy.Size = new System.Drawing.Size(165, 24);
            this.comboBoxFilterBy.TabIndex = 6;
            // 
            // txtBoxFilterBy
            // 
            this.txtBoxFilterBy.Location = new System.Drawing.Point(374, 13);
            this.txtBoxFilterBy.MaxLength = 100;
            this.txtBoxFilterBy.Name = "txtBoxFilterBy";
            this.txtBoxFilterBy.Size = new System.Drawing.Size(161, 22);
            this.txtBoxFilterBy.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Filter By:";
            // 
            // ctrlDoctorInfoWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.comboBoxFilterBy);
            this.Controls.Add(this.txtBoxFilterBy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlDoctorInfo1);
            this.Name = "ctrlDoctorInfoWithFilter";
            this.Size = new System.Drawing.Size(756, 190);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlDoctorInfo ctrlDoctorInfo1;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.ComboBox comboBoxFilterBy;
        private System.Windows.Forms.TextBox txtBoxFilterBy;
        private System.Windows.Forms.Label label1;
    }
}
