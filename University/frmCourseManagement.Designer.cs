
namespace University
{
    partial class frmCourseManagement
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
            this.txtCourseCapacity = new System.Windows.Forms.TextBox();
            this.comboTermTitle = new System.Windows.Forms.ComboBox();
            this.comboLessonName = new System.Windows.Forms.ComboBox();
            this.comboTeacherName = new System.Windows.Forms.ComboBox();
            this.lblTerm = new System.Windows.Forms.Label();
            this.lblLesson = new System.Windows.Forms.Label();
            this.lblTeacher = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSaveCourse = new System.Windows.Forms.Button();
            this.btnDeleteCourse = new System.Windows.Forms.Button();
            this.btnEditCourse = new System.Windows.Forms.Button();
            this.btnNewCourse = new System.Windows.Forms.Button();
            this.dgvCourse = new System.Windows.Forms.DataGridView();
            this.dgvCourseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTermTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLessonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTeacherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCourseCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCourseCapacity
            // 
            this.txtCourseCapacity.Enabled = false;
            this.txtCourseCapacity.Location = new System.Drawing.Point(727, 181);
            this.txtCourseCapacity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCourseCapacity.Name = "txtCourseCapacity";
            this.txtCourseCapacity.Size = new System.Drawing.Size(298, 29);
            this.txtCourseCapacity.TabIndex = 1;
            // 
            // comboTermTitle
            // 
            this.comboTermTitle.DisplayMember = "TermTitle";
            this.comboTermTitle.Enabled = false;
            this.comboTermTitle.FormattingEnabled = true;
            this.comboTermTitle.Location = new System.Drawing.Point(727, 28);
            this.comboTermTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboTermTitle.Name = "comboTermTitle";
            this.comboTermTitle.Size = new System.Drawing.Size(298, 31);
            this.comboTermTitle.TabIndex = 0;
            this.comboTermTitle.ValueMember = "ID";
            // 
            // comboLessonName
            // 
            this.comboLessonName.DisplayMember = "Name";
            this.comboLessonName.Enabled = false;
            this.comboLessonName.FormattingEnabled = true;
            this.comboLessonName.Location = new System.Drawing.Point(727, 78);
            this.comboLessonName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboLessonName.Name = "comboLessonName";
            this.comboLessonName.Size = new System.Drawing.Size(298, 31);
            this.comboLessonName.TabIndex = 0;
            this.comboLessonName.ValueMember = "ID";
            // 
            // comboTeacherName
            // 
            this.comboTeacherName.DisplayMember = "FullName";
            this.comboTeacherName.Enabled = false;
            this.comboTeacherName.FormattingEnabled = true;
            this.comboTeacherName.Location = new System.Drawing.Point(727, 131);
            this.comboTeacherName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboTeacherName.Name = "comboTeacherName";
            this.comboTeacherName.Size = new System.Drawing.Size(298, 31);
            this.comboTeacherName.TabIndex = 0;
            this.comboTeacherName.ValueMember = "ID";
            // 
            // lblTerm
            // 
            this.lblTerm.AutoSize = true;
            this.lblTerm.Location = new System.Drawing.Point(1048, 31);
            this.lblTerm.Name = "lblTerm";
            this.lblTerm.Size = new System.Drawing.Size(72, 23);
            this.lblTerm.TabIndex = 2;
            this.lblTerm.Text = "ترم تحصیلی :";
            // 
            // lblLesson
            // 
            this.lblLesson.AutoSize = true;
            this.lblLesson.Location = new System.Drawing.Point(1048, 81);
            this.lblLesson.Name = "lblLesson";
            this.lblLesson.Size = new System.Drawing.Size(40, 23);
            this.lblLesson.TabIndex = 2;
            this.lblLesson.Text = "درس :";
            // 
            // lblTeacher
            // 
            this.lblTeacher.AutoSize = true;
            this.lblTeacher.Location = new System.Drawing.Point(1048, 134);
            this.lblTeacher.Name = "lblTeacher";
            this.lblTeacher.Size = new System.Drawing.Size(46, 23);
            this.lblTeacher.TabIndex = 2;
            this.lblTeacher.Text = "مدرس :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1048, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "ظرفیت ثبت نام :";
            // 
            // btnSaveCourse
            // 
            this.btnSaveCourse.Enabled = false;
            this.btnSaveCourse.Font = new System.Drawing.Font("B Nazanin", 11.25F);
            this.btnSaveCourse.Location = new System.Drawing.Point(70, 125);
            this.btnSaveCourse.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSaveCourse.Name = "btnSaveCourse";
            this.btnSaveCourse.Size = new System.Drawing.Size(355, 40);
            this.btnSaveCourse.TabIndex = 48;
            this.btnSaveCourse.Text = "ذخیره";
            this.btnSaveCourse.UseVisualStyleBackColor = true;
            this.btnSaveCourse.Click += new System.EventHandler(this.btnSaveCourse_Click);
            // 
            // btnDeleteCourse
            // 
            this.btnDeleteCourse.Font = new System.Drawing.Font("B Nazanin", 11.25F);
            this.btnDeleteCourse.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteCourse.Location = new System.Drawing.Point(70, 73);
            this.btnDeleteCourse.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDeleteCourse.Name = "btnDeleteCourse";
            this.btnDeleteCourse.Size = new System.Drawing.Size(112, 40);
            this.btnDeleteCourse.TabIndex = 49;
            this.btnDeleteCourse.Text = "حذف";
            this.btnDeleteCourse.UseVisualStyleBackColor = true;
            this.btnDeleteCourse.Click += new System.EventHandler(this.btnDeleteCourse_Click);
            // 
            // btnEditCourse
            // 
            this.btnEditCourse.Font = new System.Drawing.Font("B Nazanin", 11.25F);
            this.btnEditCourse.ForeColor = System.Drawing.Color.Black;
            this.btnEditCourse.Location = new System.Drawing.Point(192, 73);
            this.btnEditCourse.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEditCourse.Name = "btnEditCourse";
            this.btnEditCourse.Size = new System.Drawing.Size(112, 40);
            this.btnEditCourse.TabIndex = 50;
            this.btnEditCourse.Text = "ویرایش";
            this.btnEditCourse.UseVisualStyleBackColor = true;
            this.btnEditCourse.Click += new System.EventHandler(this.btnEditCourse_Click);
            // 
            // btnNewCourse
            // 
            this.btnNewCourse.Font = new System.Drawing.Font("B Nazanin", 11.25F);
            this.btnNewCourse.ForeColor = System.Drawing.Color.Green;
            this.btnNewCourse.Location = new System.Drawing.Point(313, 73);
            this.btnNewCourse.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNewCourse.Name = "btnNewCourse";
            this.btnNewCourse.Size = new System.Drawing.Size(112, 40);
            this.btnNewCourse.TabIndex = 51;
            this.btnNewCourse.Text = "جدید";
            this.btnNewCourse.UseVisualStyleBackColor = true;
            this.btnNewCourse.Click += new System.EventHandler(this.btnNewCourse_Click);
            // 
            // dgvCourse
            // 
            this.dgvCourse.AllowUserToAddRows = false;
            this.dgvCourse.AllowUserToDeleteRows = false;
            this.dgvCourse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvCourseID,
            this.dgvTermTitle,
            this.dgvLessonName,
            this.dgvTeacherName,
            this.dgvCourseCapacity});
            this.dgvCourse.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvCourse.Location = new System.Drawing.Point(0, 241);
            this.dgvCourse.Name = "dgvCourse";
            this.dgvCourse.ReadOnly = true;
            this.dgvCourse.Size = new System.Drawing.Size(1234, 397);
            this.dgvCourse.TabIndex = 52;
            this.dgvCourse.SelectionChanged += new System.EventHandler(this.dgvCourse_SelectionChanged);
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
            this.dgvTermTitle.HeaderText = "ترم تحصیلی";
            this.dgvTermTitle.Name = "dgvTermTitle";
            this.dgvTermTitle.ReadOnly = true;
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
            this.dgvCourseCapacity.HeaderText = "ظرفیت ثبت نام";
            this.dgvCourseCapacity.Name = "dgvCourseCapacity";
            this.dgvCourseCapacity.ReadOnly = true;
            // 
            // frmCourseManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 638);
            this.Controls.Add(this.dgvCourse);
            this.Controls.Add(this.btnSaveCourse);
            this.Controls.Add(this.btnDeleteCourse);
            this.Controls.Add(this.btnEditCourse);
            this.Controls.Add(this.btnNewCourse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTeacher);
            this.Controls.Add(this.lblLesson);
            this.Controls.Add(this.lblTerm);
            this.Controls.Add(this.txtCourseCapacity);
            this.Controls.Add(this.comboTeacherName);
            this.Controls.Add(this.comboLessonName);
            this.Controls.Add(this.comboTermTitle);
            this.Font = new System.Drawing.Font("B Nazanin", 11F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmCourseManagement";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مدیریت دوره ها";
            this.Load += new System.EventHandler(this.frmCourseManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboTermTitle;
        private System.Windows.Forms.ComboBox comboLessonName;
        private System.Windows.Forms.ComboBox comboTeacherName;
        private System.Windows.Forms.Label lblTerm;
        private System.Windows.Forms.Label lblLesson;
        private System.Windows.Forms.Label lblTeacher;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSaveCourse;
        private System.Windows.Forms.Button btnDeleteCourse;
        private System.Windows.Forms.Button btnEditCourse;
        private System.Windows.Forms.Button btnNewCourse;
        private System.Windows.Forms.DataGridView dgvCourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCourseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTermTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvLessonName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTeacherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCourseCapacity;
        private System.Windows.Forms.TextBox txtCourseCapacity;
    }
}