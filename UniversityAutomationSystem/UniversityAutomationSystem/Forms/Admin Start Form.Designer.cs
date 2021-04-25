namespace UniversityAutomationSystem.Forms
{
    partial class formAdmin
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
            this.buttonCreateTeacher = new System.Windows.Forms.Button();
            this.buttonCreateStudent = new System.Windows.Forms.Button();
            this.deleteTeacher = new System.Windows.Forms.Button();
            this.buttonSignOut = new System.Windows.Forms.Button();
            this.deleteStudent = new System.Windows.Forms.Button();
            this.createOfficeWorker = new System.Windows.Forms.Button();
            this.deleteOfficeWorker = new System.Windows.Forms.Button();
            this.operationState = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCreateTeacher
            // 
            this.buttonCreateTeacher.BackColor = System.Drawing.Color.White;
            this.buttonCreateTeacher.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCreateTeacher.Location = new System.Drawing.Point(13, 27);
            this.buttonCreateTeacher.Name = "buttonCreateTeacher";
            this.buttonCreateTeacher.Size = new System.Drawing.Size(164, 39);
            this.buttonCreateTeacher.TabIndex = 0;
            this.buttonCreateTeacher.Text = "Create a teacher";
            this.buttonCreateTeacher.UseVisualStyleBackColor = false;
            this.buttonCreateTeacher.Click += new System.EventHandler(this.buttonCreateTeacher_Click);
            // 
            // buttonCreateStudent
            // 
            this.buttonCreateStudent.BackColor = System.Drawing.Color.White;
            this.buttonCreateStudent.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCreateStudent.Location = new System.Drawing.Point(505, 28);
            this.buttonCreateStudent.Name = "buttonCreateStudent";
            this.buttonCreateStudent.Size = new System.Drawing.Size(164, 38);
            this.buttonCreateStudent.TabIndex = 1;
            this.buttonCreateStudent.Text = "Create a student";
            this.buttonCreateStudent.UseVisualStyleBackColor = false;
            this.buttonCreateStudent.Click += new System.EventHandler(this.buttonCreateStudent_Click);
            // 
            // deleteTeacher
            // 
            this.deleteTeacher.BackColor = System.Drawing.Color.White;
            this.deleteTeacher.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteTeacher.Location = new System.Drawing.Point(13, 72);
            this.deleteTeacher.Name = "deleteTeacher";
            this.deleteTeacher.Size = new System.Drawing.Size(164, 39);
            this.deleteTeacher.TabIndex = 2;
            this.deleteTeacher.Text = "Delete a teacher";
            this.deleteTeacher.UseVisualStyleBackColor = false;
            this.deleteTeacher.Click += new System.EventHandler(this.deleteTeacher_Click);
            // 
            // buttonSignOut
            // 
            this.buttonSignOut.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonSignOut.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSignOut.ForeColor = System.Drawing.Color.Black;
            this.buttonSignOut.Location = new System.Drawing.Point(575, 269);
            this.buttonSignOut.Name = "buttonSignOut";
            this.buttonSignOut.Size = new System.Drawing.Size(94, 42);
            this.buttonSignOut.TabIndex = 3;
            this.buttonSignOut.Text = "Sign out";
            this.buttonSignOut.UseVisualStyleBackColor = false;
            this.buttonSignOut.Click += new System.EventHandler(this.buttonSignOut_Click);
            // 
            // deleteStudent
            // 
            this.deleteStudent.BackColor = System.Drawing.Color.White;
            this.deleteStudent.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteStudent.Location = new System.Drawing.Point(505, 72);
            this.deleteStudent.Name = "deleteStudent";
            this.deleteStudent.Size = new System.Drawing.Size(164, 39);
            this.deleteStudent.TabIndex = 2;
            this.deleteStudent.Text = "Delete a student";
            this.deleteStudent.UseVisualStyleBackColor = false;
            // 
            // createOfficeWorker
            // 
            this.createOfficeWorker.BackColor = System.Drawing.Color.White;
            this.createOfficeWorker.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createOfficeWorker.Location = new System.Drawing.Point(206, 28);
            this.createOfficeWorker.Name = "createOfficeWorker";
            this.createOfficeWorker.Size = new System.Drawing.Size(269, 38);
            this.createOfficeWorker.TabIndex = 1;
            this.createOfficeWorker.Text = "Create a deans office worker";
            this.createOfficeWorker.UseVisualStyleBackColor = false;
            // 
            // deleteOfficeWorker
            // 
            this.deleteOfficeWorker.BackColor = System.Drawing.Color.White;
            this.deleteOfficeWorker.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteOfficeWorker.Location = new System.Drawing.Point(206, 72);
            this.deleteOfficeWorker.Name = "deleteOfficeWorker";
            this.deleteOfficeWorker.Size = new System.Drawing.Size(269, 39);
            this.deleteOfficeWorker.TabIndex = 2;
            this.deleteOfficeWorker.Text = "Delete a deans office worker";
            this.deleteOfficeWorker.UseVisualStyleBackColor = false;
            // 
            // operationState
            // 
            this.operationState.AutoSize = true;
            this.operationState.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.operationState.Location = new System.Drawing.Point(13, 289);
            this.operationState.Name = "operationState";
            this.operationState.Size = new System.Drawing.Size(283, 22);
            this.operationState.TabIndex = 4;
            this.operationState.Text = "Text about successful operation";
            // 
            // formAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(681, 331);
            this.Controls.Add(this.operationState);
            this.Controls.Add(this.deleteOfficeWorker);
            this.Controls.Add(this.createOfficeWorker);
            this.Controls.Add(this.deleteStudent);
            this.Controls.Add(this.buttonSignOut);
            this.Controls.Add(this.deleteTeacher);
            this.Controls.Add(this.buttonCreateStudent);
            this.Controls.Add(this.buttonCreateTeacher);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "formAdmin";
            this.Text = "AdminForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateTeacher;
        private System.Windows.Forms.Button buttonCreateStudent;
        private System.Windows.Forms.Button deleteTeacher;
        private System.Windows.Forms.Button buttonSignOut;
        private System.Windows.Forms.Button deleteStudent;
        private System.Windows.Forms.Button createOfficeWorker;
        private System.Windows.Forms.Button deleteOfficeWorker;
        private System.Windows.Forms.Label operationState;
    }
}