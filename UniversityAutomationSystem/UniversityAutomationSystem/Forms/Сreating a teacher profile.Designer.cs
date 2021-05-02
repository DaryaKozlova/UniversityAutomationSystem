namespace UniversityAutomationSystem.Forms
{
    partial class createTeacherForm
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
            this.buttonAddTeacher = new System.Windows.Forms.Button();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelTeacherEmail = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelTeacherName = new System.Windows.Forms.Label();
            this.labelDOB = new System.Windows.Forms.Label();
            this.DOBmaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxDepartment = new System.Windows.Forms.ComboBox();
            this.labelDepartment = new System.Windows.Forms.Label();
            this.buttonCancelTeacher = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAddTeacher
            // 
            this.buttonAddTeacher.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonAddTeacher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonAddTeacher.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddTeacher.ForeColor = System.Drawing.Color.Black;
            this.buttonAddTeacher.Location = new System.Drawing.Point(189, 298);
            this.buttonAddTeacher.Name = "buttonAddTeacher";
            this.buttonAddTeacher.Size = new System.Drawing.Size(96, 41);
            this.buttonAddTeacher.TabIndex = 0;
            this.buttonAddTeacher.Text = "Add";
            this.buttonAddTeacher.UseVisualStyleBackColor = false;
            this.buttonAddTeacher.Click += new System.EventHandler(this.buttonAddTeacher_Click);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("MS Reference Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxEmail.Location = new System.Drawing.Point(342, 33);
            this.textBoxEmail.Multiline = true;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(220, 36);
            this.textBoxEmail.TabIndex = 1;
            // 
            // labelTeacherEmail
            // 
            this.labelTeacherEmail.AutoSize = true;
            this.labelTeacherEmail.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTeacherEmail.Location = new System.Drawing.Point(353, 22);
            this.labelTeacherEmail.Name = "labelTeacherEmail";
            this.labelTeacherEmail.Size = new System.Drawing.Size(48, 19);
            this.labelTeacherEmail.TabIndex = 2;
            this.labelTeacherEmail.Text = "Email";
            this.labelTeacherEmail.Click += new System.EventHandler(this.labelTeacherEmail_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxName.Location = new System.Drawing.Point(12, 33);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(220, 36);
            this.textBoxName.TabIndex = 1;
            // 
            // labelTeacherName
            // 
            this.labelTeacherName.AutoSize = true;
            this.labelTeacherName.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTeacherName.Location = new System.Drawing.Point(21, 22);
            this.labelTeacherName.Name = "labelTeacherName";
            this.labelTeacherName.Size = new System.Drawing.Size(53, 19);
            this.labelTeacherName.TabIndex = 2;
            this.labelTeacherName.Text = "Name";
            // 
            // labelDOB
            // 
            this.labelDOB.AutoSize = true;
            this.labelDOB.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDOB.Location = new System.Drawing.Point(12, 97);
            this.labelDOB.Name = "labelDOB";
            this.labelDOB.Size = new System.Drawing.Size(105, 19);
            this.labelDOB.TabIndex = 2;
            this.labelDOB.Text = "Date Of Birth";
            // 
            // DOBmaskedTextBox
            // 
            this.DOBmaskedTextBox.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DOBmaskedTextBox.Location = new System.Drawing.Point(126, 97);
            this.DOBmaskedTextBox.Mask = "00/00/0000";
            this.DOBmaskedTextBox.Name = "DOBmaskedTextBox";
            this.DOBmaskedTextBox.Size = new System.Drawing.Size(106, 36);
            this.DOBmaskedTextBox.TabIndex = 3;
            // 
            // comboBoxDepartment
            // 
            this.comboBoxDepartment.Font = new System.Drawing.Font("MS Reference Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxDepartment.FormattingEnabled = true;
            this.comboBoxDepartment.Location = new System.Drawing.Point(12, 164);
            this.comboBoxDepartment.Name = "comboBoxDepartment";
            this.comboBoxDepartment.Size = new System.Drawing.Size(220, 36);
            this.comboBoxDepartment.TabIndex = 4;
            // 
            // labelDepartment
            // 
            this.labelDepartment.AutoSize = true;
            this.labelDepartment.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDepartment.Location = new System.Drawing.Point(22, 152);
            this.labelDepartment.Name = "labelDepartment";
            this.labelDepartment.Size = new System.Drawing.Size(98, 19);
            this.labelDepartment.TabIndex = 2;
            this.labelDepartment.Text = "Department";
            // 
            // buttonCancelTeacher
            // 
            this.buttonCancelTeacher.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonCancelTeacher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonCancelTeacher.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCancelTeacher.ForeColor = System.Drawing.Color.Black;
            this.buttonCancelTeacher.Location = new System.Drawing.Point(305, 298);
            this.buttonCancelTeacher.Name = "buttonCancelTeacher";
            this.buttonCancelTeacher.Size = new System.Drawing.Size(96, 41);
            this.buttonCancelTeacher.TabIndex = 0;
            this.buttonCancelTeacher.Text = "Cancel";
            this.buttonCancelTeacher.UseVisualStyleBackColor = false;
            this.buttonCancelTeacher.Click += new System.EventHandler(this.buttonCancelTeacher_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(345, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hire Date";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maskedTextBox1.Location = new System.Drawing.Point(429, 163);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(101, 36);
            this.maskedTextBox1.TabIndex = 3;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("MS Reference Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPassword.Location = new System.Drawing.Point(342, 98);
            this.textBoxPassword.Multiline = true;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(220, 36);
            this.textBoxPassword.TabIndex = 5;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPassword.Location = new System.Drawing.Point(353, 88);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(81, 19);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Password";
            // 
            // createTeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(573, 361);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancelTeacher);
            this.Controls.Add(this.labelDepartment);
            this.Controls.Add(this.comboBoxDepartment);
            this.Controls.Add(this.DOBmaskedTextBox);
            this.Controls.Add(this.labelDOB);
            this.Controls.Add(this.labelTeacherName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelTeacherEmail);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.buttonAddTeacher);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "createTeacherForm";
            this.Text = "Create a teacher profile";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.createTeacherForm_FormClosed);
            this.Load += new System.EventHandler(this.createTeacherForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Button buttonAddTeacher;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelTeacherEmail;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelTeacherName;
        private System.Windows.Forms.Label labelDOB;
        private System.Windows.Forms.MaskedTextBox DOBmaskedTextBox;
        private System.Windows.Forms.ComboBox comboBoxDepartment;
        private System.Windows.Forms.Label labelDepartment;
        private System.Windows.Forms.Button buttonCancelTeacher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
    }
}