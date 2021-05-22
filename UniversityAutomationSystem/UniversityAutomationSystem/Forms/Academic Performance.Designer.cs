namespace UniversityAutomationSystem.Forms
{
    partial class Academic_Performance
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
            this.groupSelect = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.subjectSelect = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.assesmentTypeSelect = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonCreateReport = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupSelect
            // 
            this.groupSelect.FormattingEnabled = true;
            this.groupSelect.Location = new System.Drawing.Point(30, 45);
            this.groupSelect.Name = "groupSelect";
            this.groupSelect.Size = new System.Drawing.Size(305, 28);
            this.groupSelect.TabIndex = 0;
            this.groupSelect.SelectionChangeCommitted += new System.EventHandler(this.groupSelect_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(145, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select group";
            // 
            // subjectSelect
            // 
            this.subjectSelect.FormattingEnabled = true;
            this.subjectSelect.Location = new System.Drawing.Point(33, 122);
            this.subjectSelect.Name = "subjectSelect";
            this.subjectSelect.Size = new System.Drawing.Size(302, 28);
            this.subjectSelect.TabIndex = 0;
            this.subjectSelect.SelectionChangeCommitted += new System.EventHandler(this.subjectSelect_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(138, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select subject";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // assesmentTypeSelect
            // 
            this.assesmentTypeSelect.FormattingEnabled = true;
            this.assesmentTypeSelect.Location = new System.Drawing.Point(33, 206);
            this.assesmentTypeSelect.Name = "assesmentTypeSelect";
            this.assesmentTypeSelect.Size = new System.Drawing.Size(302, 28);
            this.assesmentTypeSelect.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(102, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Select assesment type";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(99, 359);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(84, 45);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.id.Visible = false;
            this.id.Width = 125;
            // 
            // studentName
            // 
            this.studentName.HeaderText = "Student Name";
            this.studentName.MinimumWidth = 6;
            this.studentName.Name = "studentName";
            this.studentName.ReadOnly = true;
            this.studentName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.studentName.Width = 125;
            // 
            // grade
            // 
            this.grade.HeaderText = "Grade";
            this.grade.MinimumWidth = 6;
            this.grade.Name = "grade";
            this.grade.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.grade.Width = 125;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.studentName,
            this.grade});
            this.dataGridView1.Location = new System.Drawing.Point(372, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(416, 426);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.Text = "dataGridView1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(145, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Select date";
            // 
            // buttonCreateReport
            // 
            this.buttonCreateReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonCreateReport.Location = new System.Drawing.Point(189, 359);
            this.buttonCreateReport.Name = "buttonCreateReport";
            this.buttonCreateReport.Size = new System.Drawing.Size(146, 45);
            this.buttonCreateReport.TabIndex = 4;
            this.buttonCreateReport.Text = "Create a report";
            this.buttonCreateReport.UseVisualStyleBackColor = false;
            this.buttonCreateReport.Click += new System.EventHandler(this.buttonCreateReport_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(28, 291);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(307, 27);
            this.dateTimePicker.TabIndex = 6;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 45);
            this.button1.TabIndex = 7;
            this.button1.Text = "Reload";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Academic_Performance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.buttonCreateReport);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.assesmentTypeSelect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.subjectSelect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupSelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Academic_Performance";
            this.Text = "Academic Performance";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox groupSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox subjectSelect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox assesmentTypeSelect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn grade;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonCreateReport;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button button1;
    }
}