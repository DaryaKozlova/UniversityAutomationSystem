namespace UniversityAutomationSystem.Forms
{
    partial class FormCreateStudent
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
            this.buttonCancelStudent = new System.Windows.Forms.Button();
            this.buttonAddStudent = new System.Windows.Forms.Button();
            this.textBoxStudentName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DOBmaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxGroup = new System.Windows.Forms.ComboBox();
            this.labelGroup = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EnteringDateLabel = new System.Windows.Forms.Label();
            this.EnteringDatemaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.GraduationDateLabel = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label4Password = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCancelStudent
            // 
            this.buttonCancelStudent.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonCancelStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonCancelStudent.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCancelStudent.ForeColor = System.Drawing.Color.Black;
            this.buttonCancelStudent.Location = new System.Drawing.Point(276, 311);
            this.buttonCancelStudent.Name = "buttonCancelStudent";
            this.buttonCancelStudent.Size = new System.Drawing.Size(96, 41);
            this.buttonCancelStudent.TabIndex = 0;
            this.buttonCancelStudent.Text = "Cancel";
            this.buttonCancelStudent.UseVisualStyleBackColor = false;
            this.buttonCancelStudent.Click += new System.EventHandler(this.buttonCancelStudent_Click);
            // 
            // buttonAddStudent
            // 
            this.buttonAddStudent.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonAddStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonAddStudent.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddStudent.ForeColor = System.Drawing.Color.Black;
            this.buttonAddStudent.Location = new System.Drawing.Point(160, 311);
            this.buttonAddStudent.Name = "buttonAddStudent";
            this.buttonAddStudent.Size = new System.Drawing.Size(96, 41);
            this.buttonAddStudent.TabIndex = 0;
            this.buttonAddStudent.Text = "Add";
            this.buttonAddStudent.UseVisualStyleBackColor = false;
            this.buttonAddStudent.Click += new System.EventHandler(this.buttonAddStudent_Click);
            // 
            // textBoxStudentName
            // 
            this.textBoxStudentName.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxStudentName.Location = new System.Drawing.Point(12, 35);
            this.textBoxStudentName.Multiline = true;
            this.textBoxStudentName.Name = "textBoxStudentName";
            this.textBoxStudentName.Size = new System.Drawing.Size(220, 36);
            this.textBoxStudentName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date Of Birth";
            // 
            // DOBmaskedTextBox
            // 
            this.DOBmaskedTextBox.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DOBmaskedTextBox.Location = new System.Drawing.Point(126, 152);
            this.DOBmaskedTextBox.Mask = "00/00/0000";
            this.DOBmaskedTextBox.Name = "DOBmaskedTextBox";
            this.DOBmaskedTextBox.Size = new System.Drawing.Size(106, 36);
            this.DOBmaskedTextBox.TabIndex = 3;
            this.DOBmaskedTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.DOBmaskedTextBox_MaskInputRejected);
            // 
            // comboBoxGroup
            // 
            this.comboBoxGroup.Font = new System.Drawing.Font("MS Reference Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxGroup.FormattingEnabled = true;
            this.comboBoxGroup.Location = new System.Drawing.Point(12, 214);
            this.comboBoxGroup.Name = "comboBoxGroup";
            this.comboBoxGroup.Size = new System.Drawing.Size(220, 36);
            this.comboBoxGroup.TabIndex = 4;
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelGroup.Location = new System.Drawing.Point(22, 202);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(55, 19);
            this.labelGroup.TabIndex = 2;
            this.labelGroup.Text = "Group";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("MS Reference Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(338, 35);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(220, 36);
            this.textBox2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(349, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // EnteringDateLabel
            // 
            this.EnteringDateLabel.AutoSize = true;
            this.EnteringDateLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EnteringDateLabel.Location = new System.Drawing.Point(338, 163);
            this.EnteringDateLabel.Name = "EnteringDateLabel";
            this.EnteringDateLabel.Size = new System.Drawing.Size(109, 19);
            this.EnteringDateLabel.TabIndex = 2;
            this.EnteringDateLabel.Text = "Entering Date";
            this.EnteringDateLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // EnteringDatemaskedTextBox
            // 
            this.EnteringDatemaskedTextBox.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EnteringDatemaskedTextBox.Location = new System.Drawing.Point(452, 163);
            this.EnteringDatemaskedTextBox.Mask = "00/00/0000";
            this.EnteringDatemaskedTextBox.Name = "EnteringDatemaskedTextBox";
            this.EnteringDatemaskedTextBox.Size = new System.Drawing.Size(106, 36);
            this.EnteringDatemaskedTextBox.TabIndex = 3;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maskedTextBox1.Location = new System.Drawing.Point(456, 225);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(106, 36);
            this.maskedTextBox1.TabIndex = 3;
            // 
            // GraduationDateLabel
            // 
            this.GraduationDateLabel.AutoSize = true;
            this.GraduationDateLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GraduationDateLabel.Location = new System.Drawing.Point(319, 225);
            this.GraduationDateLabel.Name = "GraduationDateLabel";
            this.GraduationDateLabel.Size = new System.Drawing.Size(131, 19);
            this.GraduationDateLabel.TabIndex = 2;
            this.GraduationDateLabel.Text = "Gtaduation Date";
            this.GraduationDateLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("MS Reference Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPassword.Location = new System.Drawing.Point(338, 102);
            this.textBoxPassword.Multiline = true;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(220, 36);
            this.textBoxPassword.TabIndex = 5;
            // 
            // label4Password
            // 
            this.label4Password.AutoSize = true;
            this.label4Password.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4Password.Location = new System.Drawing.Point(349, 92);
            this.label4Password.Name = "label4Password";
            this.label4Password.Size = new System.Drawing.Size(81, 19);
            this.label4Password.TabIndex = 2;
            this.label4Password.Text = "Password";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxLastName.Location = new System.Drawing.Point(12, 102);
            this.textBoxLastName.Multiline = true;
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(220, 36);
            this.textBoxLastName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(21, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Last Name";
            // 
            // FormCreateStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(573, 363);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.label4Password);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.GraduationDateLabel);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.EnteringDatemaskedTextBox);
            this.Controls.Add(this.EnteringDateLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.labelGroup);
            this.Controls.Add(this.comboBoxGroup);
            this.Controls.Add(this.DOBmaskedTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxStudentName);
            this.Controls.Add(this.buttonAddStudent);
            this.Controls.Add(this.buttonCancelStudent);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormCreateStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create a student profile";
            this.Load += new System.EventHandler(this.FormCreateStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonCancelStudent;
        private System.Windows.Forms.Button buttonAddStudent;
        private System.Windows.Forms.TextBox textBoxStudentName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox DOBmaskedTextBox;
        private System.Windows.Forms.ComboBox comboBoxGroup;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label EnteringDateLabel;
        private System.Windows.Forms.MaskedTextBox EnteringDatemaskedTextBox;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label GraduationDateLabel;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label4Password;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label label4;
    }
}