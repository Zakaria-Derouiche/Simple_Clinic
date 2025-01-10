namespace SimpleClinic
{
    partial class ctrlUserInfoWithFilter
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.comboBoxFilterBy = new System.Windows.Forms.ComboBox();
            this.txtBoxFilterBy = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrlUserInfo1 = new SimpleClinic.ctrlUserInfo();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFind);
            this.groupBox1.Controls.Add(this.ctrlUserInfo1);
            this.groupBox1.Controls.Add(this.comboBoxFilterBy);
            this.groupBox1.Controls.Add(this.txtBoxFilterBy);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(862, 205);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnFind
            // 
            this.btnFind.ForeColor = System.Drawing.Color.LightSalmon;
            this.btnFind.Location = new System.Drawing.Point(578, 14);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(100, 35);
            this.btnFind.TabIndex = 3;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // comboBoxFilterBy
            // 
            this.comboBoxFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFilterBy.FormattingEnabled = true;
            this.comboBoxFilterBy.Items.AddRange(new object[] {
            "User ID",
            "User Name",
            "Employee ID",
            ""});
            this.comboBoxFilterBy.Location = new System.Drawing.Point(146, 19);
            this.comboBoxFilterBy.Name = "comboBoxFilterBy";
            this.comboBoxFilterBy.Size = new System.Drawing.Size(165, 24);
            this.comboBoxFilterBy.TabIndex = 2;
            this.comboBoxFilterBy.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilterBy_SelectedIndexChanged);
            // 
            // txtBoxFilterBy
            // 
            this.txtBoxFilterBy.Location = new System.Drawing.Point(364, 20);
            this.txtBoxFilterBy.MaxLength = 100;
            this.txtBoxFilterBy.Name = "txtBoxFilterBy";
            this.txtBoxFilterBy.Size = new System.Drawing.Size(161, 22);
            this.txtBoxFilterBy.TabIndex = 1;
            this.txtBoxFilterBy.TextChanged += new System.EventHandler(this.txtBoxFilterBy_TextChanged);
            this.txtBoxFilterBy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxFilterBy_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filter By:";
            // 
            // ctrlUserInfo1
            // 
            this.ctrlUserInfo1.Location = new System.Drawing.Point(13, 49);
            this.ctrlUserInfo1.Name = "ctrlUserInfo1";
            this.ctrlUserInfo1.Size = new System.Drawing.Size(837, 126);
            this.ctrlUserInfo1.TabIndex = 0;
            // 
            // ctrlUserInfoWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "ctrlUserInfoWithFilter";
            this.Size = new System.Drawing.Size(885, 232);
            this.Load += new System.EventHandler(this.ctrlUserInfoWithFilter_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlUserInfo ctrlUserInfo1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBoxFilterBy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.ComboBox comboBoxFilterBy;
    }
}
