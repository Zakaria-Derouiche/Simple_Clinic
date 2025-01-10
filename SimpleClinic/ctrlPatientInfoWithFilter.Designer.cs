namespace SimpleClinic
{
    partial class ctrlPatientInfoWithFilter
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
            this.ctrlPatientInfo1 = new SimpleClinic.ctrlPatientInfo();
            this.btnFind = new System.Windows.Forms.Button();
            this.comboBoxFilterBy = new System.Windows.Forms.ComboBox();
            this.txtBoxFilterBy = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ctrlPatientInfo1
            // 
            this.ctrlPatientInfo1.Location = new System.Drawing.Point(16, 68);
            this.ctrlPatientInfo1.Name = "ctrlPatientInfo1";
            this.ctrlPatientInfo1.Size = new System.Drawing.Size(638, 122);
            this.ctrlPatientInfo1.TabIndex = 0;
            // 
            // btnFind
            // 
            this.btnFind.ForeColor = System.Drawing.Color.LightSalmon;
            this.btnFind.Location = new System.Drawing.Point(553, 14);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(100, 35);
            this.btnFind.TabIndex = 11;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // comboBoxFilterBy
            // 
            this.comboBoxFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFilterBy.FormattingEnabled = true;
            this.comboBoxFilterBy.Items.AddRange(new object[] {
            "Patient ID",
            "Person ID"});
            this.comboBoxFilterBy.Location = new System.Drawing.Point(123, 19);
            this.comboBoxFilterBy.Name = "comboBoxFilterBy";
            this.comboBoxFilterBy.Size = new System.Drawing.Size(165, 24);
            this.comboBoxFilterBy.TabIndex = 10;
            this.comboBoxFilterBy.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilterBy_SelectedIndexChanged);
            // 
            // txtBoxFilterBy
            // 
            this.txtBoxFilterBy.Location = new System.Drawing.Point(340, 20);
            this.txtBoxFilterBy.MaxLength = 100;
            this.txtBoxFilterBy.Name = "txtBoxFilterBy";
            this.txtBoxFilterBy.Size = new System.Drawing.Size(161, 22);
            this.txtBoxFilterBy.TabIndex = 9;
            this.txtBoxFilterBy.TextChanged += new System.EventHandler(this.txtBoxFilterBy_TextChanged);
            this.txtBoxFilterBy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxFilterBy_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Filter By:";
            // 
            // ctrlPatientInfoWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.comboBoxFilterBy);
            this.Controls.Add(this.txtBoxFilterBy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlPatientInfo1);
            this.Name = "ctrlPatientInfoWithFilter";
            this.Size = new System.Drawing.Size(674, 212);
            this.Load += new System.EventHandler(this.ctrlPatientInfoWithFilter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlPatientInfo ctrlPatientInfo1;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.ComboBox comboBoxFilterBy;
        private System.Windows.Forms.TextBox txtBoxFilterBy;
        private System.Windows.Forms.Label label1;
    }
}
