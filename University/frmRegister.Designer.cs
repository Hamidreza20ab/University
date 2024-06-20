
namespace University
{
    partial class frmRegister
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.dgvStudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRegisterID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvStudentFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvStudentNationalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvStudentPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvStudentBirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDeleteButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvCourses = new System.Windows.Forms.DataGridView();
            this.dgvCourseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTermTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTermId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLessonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTeacherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCourseCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.comboStudentName = new System.Windows.Forms.ComboBox();
            this.btnSaveStudent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStudents
            // 
            this.dgvStudents.AllowUserToAddRows = false;
            this.dgvStudents.AllowUserToDeleteRows = false;
            this.dgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvStudentID,
            this.dgvRegisterID,
            this.dgvStudentFullName,
            this.dgvStudentNationalCode,
            this.dgvStudentPhoneNumber,
            this.dgvStudentBirthDate,
            this.dgvDeleteButton});
            this.dgvStudents.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvStudents.Location = new System.Drawing.Point(0, 327);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.ReadOnly = true;
            this.dgvStudents.Size = new System.Drawing.Size(628, 277);
            this.dgvStudents.TabIndex = 3;
            this.dgvStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudents_CellClick);
            this.dgvStudents.SelectionChanged += new System.EventHandler(this.dgvStudents_SelectionChanged);
            // 
            // dgvStudentID
            // 
            this.dgvStudentID.DataPropertyName = "StudentID";
            this.dgvStudentID.HeaderText = "StudentId";
            this.dgvStudentID.Name = "dgvStudentID";
            this.dgvStudentID.ReadOnly = true;
            this.dgvStudentID.Visible = false;
            // 
            // dgvRegisterID
            // 
            this.dgvRegisterID.DataPropertyName = "RegisterID";
            this.dgvRegisterID.HeaderText = "RegisterID";
            this.dgvRegisterID.Name = "dgvRegisterID";
            this.dgvRegisterID.ReadOnly = true;
            this.dgvRegisterID.Visible = false;
            // 
            // dgvStudentFullName
            // 
            this.dgvStudentFullName.DataPropertyName = "FullName";
            this.dgvStudentFullName.HeaderText = "نام و نام خانوادگی";
            this.dgvStudentFullName.Name = "dgvStudentFullName";
            this.dgvStudentFullName.ReadOnly = true;
            // 
            // dgvStudentNationalCode
            // 
            this.dgvStudentNationalCode.DataPropertyName = "NationalCode";
            this.dgvStudentNationalCode.HeaderText = "کد ملی";
            this.dgvStudentNationalCode.Name = "dgvStudentNationalCode";
            this.dgvStudentNationalCode.ReadOnly = true;
            // 
            // dgvStudentPhoneNumber
            // 
            this.dgvStudentPhoneNumber.DataPropertyName = "PhoneNumber";
            this.dgvStudentPhoneNumber.HeaderText = "شماره تماس";
            this.dgvStudentPhoneNumber.Name = "dgvStudentPhoneNumber";
            this.dgvStudentPhoneNumber.ReadOnly = true;
            // 
            // dgvStudentBirthDate
            // 
            this.dgvStudentBirthDate.DataPropertyName = "BirthDate";
            dataGridViewCellStyle1.Format = "0000/00/00";
            this.dgvStudentBirthDate.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStudentBirthDate.HeaderText = "تاریخ تولد";
            this.dgvStudentBirthDate.Name = "dgvStudentBirthDate";
            this.dgvStudentBirthDate.ReadOnly = true;
            // 
            // dgvDeleteButton
            // 
            this.dgvDeleteButton.HeaderText = "";
            this.dgvDeleteButton.Name = "dgvDeleteButton";
            this.dgvDeleteButton.ReadOnly = true;
            this.dgvDeleteButton.Text = "حذف";
            this.dgvDeleteButton.UseColumnTextForButtonValue = true;
            // 
            // dgvCourses
            // 
            this.dgvCourses.AllowUserToAddRows = false;
            this.dgvCourses.AllowUserToDeleteRows = false;
            this.dgvCourses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvCourseID,
            this.dgvTermTitle,
            this.dgvTermId,
            this.dgvLessonName,
            this.dgvTeacherName,
            this.dgvCourseCapacity});
            this.dgvCourses.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvCourses.Location = new System.Drawing.Point(628, 0);
            this.dgvCourses.Name = "dgvCourses";
            this.dgvCourses.ReadOnly = true;
            this.dgvCourses.Size = new System.Drawing.Size(498, 604);
            this.dgvCourses.TabIndex = 2;
            this.dgvCourses.SelectionChanged += new System.EventHandler(this.dgvCourses_SelectionChanged);
            // 
            // dgvCourseID
            // 
            this.dgvCourseID.DataPropertyName = "CourseID";
            this.dgvCourseID.HeaderText = "شناسه دوره";
            this.dgvCourseID.Name = "dgvCourseID";
            this.dgvCourseID.ReadOnly = true;
            // 
            // dgvTermTitle
            // 
            this.dgvTermTitle.DataPropertyName = "TermTitle";
            this.dgvTermTitle.HeaderText = "ترم";
            this.dgvTermTitle.Name = "dgvTermTitle";
            this.dgvTermTitle.ReadOnly = true;
            // 
            // dgvTermId
            // 
            this.dgvTermId.DataPropertyName = "TermId";
            this.dgvTermId.HeaderText = "TermId";
            this.dgvTermId.Name = "dgvTermId";
            this.dgvTermId.ReadOnly = true;
            this.dgvTermId.Visible = false;
            // 
            // dgvLessonName
            // 
            this.dgvLessonName.DataPropertyName = "LessonName";
            this.dgvLessonName.HeaderText = "درس";
            this.dgvLessonName.Name = "dgvLessonName";
            this.dgvLessonName.ReadOnly = true;
            // 
            // dgvTeacherName
            // 
            this.dgvTeacherName.DataPropertyName = "TeachersName";
            this.dgvTeacherName.HeaderText = "مدرس";
            this.dgvTeacherName.Name = "dgvTeacherName";
            this.dgvTeacherName.ReadOnly = true;
            // 
            // dgvCourseCapacity
            // 
            this.dgvCourseCapacity.DataPropertyName = "CourseCapacity";
            this.dgvCourseCapacity.HeaderText = "ظرفیت دوره";
            this.dgvCourseCapacity.Name = "dgvCourseCapacity";
            this.dgvCourseCapacity.ReadOnly = true;
            this.dgvCourseCapacity.Visible = false;
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(444, 92);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(49, 23);
            this.lblStudentName.TabIndex = 57;
            this.lblStudentName.Text = "دانشجو :";
            // 
            // comboStudentName
            // 
            this.comboStudentName.DisplayMember = "FullName";
            this.comboStudentName.FormattingEnabled = true;
            this.comboStudentName.Location = new System.Drawing.Point(123, 89);
            this.comboStudentName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboStudentName.Name = "comboStudentName";
            this.comboStudentName.Size = new System.Drawing.Size(298, 31);
            this.comboStudentName.TabIndex = 56;
            this.comboStudentName.ValueMember = "ID";
            // 
            // btnSaveStudent
            // 
            this.btnSaveStudent.Font = new System.Drawing.Font("B Nazanin", 11.25F);
            this.btnSaveStudent.Location = new System.Drawing.Point(123, 170);
            this.btnSaveStudent.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSaveStudent.Name = "btnSaveStudent";
            this.btnSaveStudent.Size = new System.Drawing.Size(355, 40);
            this.btnSaveStudent.TabIndex = 59;
            this.btnSaveStudent.Text = "ثبت نام";
            this.btnSaveStudent.UseVisualStyleBackColor = true;
            this.btnSaveStudent.Click += new System.EventHandler(this.btnSaveStudent_Click);
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 604);
            this.Controls.Add(this.btnSaveStudent);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.comboStudentName);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.dgvCourses);
            this.Font = new System.Drawing.Font("B Nazanin", 11F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmRegister";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ثبت نام دانشجویان";
            this.Load += new System.EventHandler(this.frmRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.DataGridView dgvCourses;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.ComboBox comboStudentName;
        private System.Windows.Forms.Button btnSaveStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvStudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvRegisterID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvStudentFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvStudentNationalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvStudentPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvStudentBirthDate;
        private System.Windows.Forms.DataGridViewButtonColumn dgvDeleteButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCourseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTermTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTermId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvLessonName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTeacherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCourseCapacity;
    }
}