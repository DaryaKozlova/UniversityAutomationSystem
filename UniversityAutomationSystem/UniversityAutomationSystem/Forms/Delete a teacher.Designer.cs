namespace UniversityAutomationSystem.Forms
{
    partial class Delete_a_teacher
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
            this.comboBoxEmail = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelDepartment = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.buttonFireATeacher = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBoxHireDate = new System.Windows.Forms.MaskedTextBox();
            this.labelFireDate = new System.Windows.Forms.Label();
            this.maskedTextBoxFireDate = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxEmail
            // 
            this.comboBoxEmail.FormattingEnabled = true;
            this.comboBoxEmail.Location = new System.Drawing.Point(276, 42);
            this.comboBoxEmail.Name = "comboBoxEmail";
            this.comboBoxEmail.Size = new System.Drawing.Size(245, 28);
            this.comboBoxEmail.TabIndex = 0;
            this.comboBoxEmail.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(141, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Enabled = false;
            this.textBoxName.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxName.Location = new System.Drawing.Point(132, 115);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new System.Drawing.Size(220, 36);
            this.textBoxName.TabIndex = 1;
            // 
            // labelDepartment
            // 
            this.labelDepartment.AutoSize = true;
            this.labelDepartment.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDepartment.Location = new System.Drawing.Point(473, 104);
            this.labelDepartment.Name = "labelDepartment";
            this.labelDepartment.Size = new System.Drawing.Size(98, 19);
            this.labelDepartment.TabIndex = 2;
            this.labelDepartment.Text = "Department";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Enabled = false;
            this.textBoxEmail.Font = new System.Drawing.Font("MS Reference Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxEmail.Location = new System.Drawing.Point(462, 115);
            this.textBoxEmail.Multiline = true;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.ReadOnly = true;
            this.textBoxEmail.Size = new System.Drawing.Size(220, 36);
            this.textBoxEmail.TabIndex = 1;
            // 
            // buttonFireATeacher
            // 
            this.buttonFireATeacher.Location = new System.Drawing.Point(241, 364);
            this.buttonFireATeacher.Name = "buttonFireATeacher";
            this.buttonFireATeacher.Size = new System.Drawing.Size(298, 51);
            this.buttonFireATeacher.TabIndex = 3;
            this.buttonFireATeacher.Text = "Fire";
            this.buttonFireATeacher.UseVisualStyleBackColor = true;
            this.buttonFireATeacher.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(463, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hire Date";
            // 
            // maskedTextBoxHireDate
            // 
            this.maskedTextBoxHireDate.Enabled = false;
            this.maskedTextBoxHireDate.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maskedTextBoxHireDate.Location = new System.Drawing.Point(547, 180);
            this.maskedTextBoxHireDate.Mask = "00/00/0000";
            this.maskedTextBoxHireDate.Name = "maskedTextBoxHireDate";
            this.maskedTextBoxHireDate.ReadOnly = true;
            this.maskedTextBoxHireDate.Size = new System.Drawing.Size(135, 36);
            this.maskedTextBoxHireDate.TabIndex = 3;
            // 
            // labelFireDate
            // 
            this.labelFireDate.AutoSize = true;
            this.labelFireDate.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFireDate.Location = new System.Drawing.Point(132, 180);
            this.labelFireDate.Name = "labelFireDate";
            this.labelFireDate.Size = new System.Drawing.Size(76, 19);
            this.labelFireDate.TabIndex = 2;
            this.labelFireDate.Text = "Fire Date";
            // 
            // maskedTextBoxFireDate
            // 
            this.maskedTextBoxFireDate.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maskedTextBoxFireDate.Location = new System.Drawing.Point(216, 180);
            this.maskedTextBoxFireDate.Mask = "00/00/0000";
            this.maskedTextBoxFireDate.Name = "maskedTextBoxFireDate";
            this.maskedTextBoxFireDate.Size = new System.Drawing.Size(136, 36);
            this.maskedTextBoxFireDate.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(337, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Search by Email";
            // 
            // Delete_a_teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maskedTextBoxFireDate);
            this.Controls.Add(this.labelFireDate);
            this.Controls.Add(this.maskedTextBoxHireDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelDepartment);
            this.Controls.Add(this.buttonFireATeacher);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.comboBoxEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Delete_a_teacher";
            this.Text = "Delete a teacher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelDepartment;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Button buttonFireATeacher;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxHireDate;
        private System.Windows.Forms.Label labelFireDate;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxFireDate;
        private System.Windows.Forms.Label label3;
    }
}