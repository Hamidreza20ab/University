
namespace University
{
    partial class frmSessionManagement
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
            this.dgvCourses = new System.Windows.Forms.DataGridView();
            this.dgvCourseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTermTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTermId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLessonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTeacherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSessions = new System.Windows.Forms.DataGridView();
            this.dgvSessionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvClassID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSessionTimeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDayOfWeekID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDayOfWeek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSessionTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSaveSession = new System.Windows.Forms.Button();
            this.btnDeleteSession = new System.Windows.Forms.Button();
            this.btnEditSession = new System.Windows.Forms.Button();
            this.btnNewSession = new System.Windows.Forms.Button();
            this.lblTeacher = new System.Windows.Forms.Label();
            this.lblLesson = new System.Windows.Forms.Label();
            this.lblTerm = new System.Windows.Forms.Label();
            this.comboClass = new System.Windows.Forms.ComboBox();
            this.comboSessionTime = new System.Windows.Forms.ComboBox();
            this.comboDayOfWeek = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSessions)).BeginInit();
            this.SuspendLayout();
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
            this.dgvTeacherName});
            this.dgvCourses.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvCourses.Location = new System.Drawing.Point(706, 0);
            this.dgvCourses.Name = "dgvCourses";
            this.dgvCourses.ReadOnly = true;
            this.dgvCourses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCourses.Size = new System.Drawing.Size(525, 655);
            this.dgvCourses.TabIndex = 0;
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
            // dgvSessions
            // 
            this.dgvSessions.AllowUserToAddRows = false;
            this.dgvSessions.AllowUserToDeleteRows = false;
            this.dgvSessions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSessions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvSessionID,
            this.dgvClassID,
            this.dgvSessionTimeID,
            this.dgvDayOfWeekID,
            this.dgvDayOfWeek,
            this.dgvSessionTime,
            this.dgvClassName});
            this.dgvSessions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvSessions.Location = new System.Drawing.Point(0, 378);
            this.dgvSessions.Name = "dgvSessions";
            this.dgvSessions.ReadOnly = true;
            this.dgvSessions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSessions.Size = new System.Drawing.Size(706, 277);
            this.dgvSessions.TabIndex = 1;
            this.dgvSessions.SelectionChanged += new System.EventHandler(this.dgvSessions_SelectionChanged);
            // 
            // dgvSessionID
            // 
            this.dgvSessionID.DataPropertyName = "ID";
            this.dgvSessionID.HeaderText = "ID";
            this.dgvSessionID.Name = "dgvSessionID";
            this.dgvSessionID.ReadOnly = true;
            this.dgvSessionID.Visible = false;
            // 
            // dgvClassID
            // 
            this.dgvClassID.DataPropertyName = "ClassID";
            this.dgvClassID.HeaderText = "ClassID";
            this.dgvClassID.Name = "dgvClassID";
            this.dgvClassID.ReadOnly = true;
            this.dgvClassID.Visible = false;
            // 
            // dgvSessionTimeID
            // 
            this.dgvSessionTimeID.DataPropertyName = "SessionTimeID";
            this.dgvSessionTimeID.HeaderText = "SessionTimeID";
            this.dgvSessionTimeID.Name = "dgvSessionTimeID";
            this.dgvSessionTimeID.ReadOnly = true;
            this.dgvSessionTimeID.Visible = false;
            // 
            // dgvDayOfWeekID
            // 
            this.dgvDayOfWeekID.DataPropertyName = "DayOfWeek";
            this.dgvDayOfWeekID.HeaderText = "DayOfWeekID";
            this.dgvDayOfWeekID.Name = "dgvDayOfWeekID";
            this.dgvDayOfWeekID.ReadOnly = true;
            this.dgvDayOfWeekID.Visible = false;
            // 
            // dgvDayOfWeek
            // 
            this.dgvDayOfWeek.DataPropertyName = "DayOfWeekstr";
            this.dgvDayOfWeek.HeaderText = "روز هفته";
            this.dgvDayOfWeek.Name = "dgvDayOfWeek";
            this.dgvDayOfWeek.ReadOnly = true;
            // 
            // dgvSessionTime
            // 
            this.dgvSessionTime.DataPropertyName = "ClassTime";
            this.dgvSessionTime.HeaderText = "ساعت";
            this.dgvSessionTime.Name = "dgvSessionTime";
            this.dgvSessionTime.ReadOnly = true;
            // 
            // dgvClassName
            // 
            this.dgvClassName.DataPropertyName = "ClassName";
            this.dgvClassName.HeaderText = "کلاس";
            this.dgvClassName.Name = "dgvClassName";
            this.dgvClassName.ReadOnly = true;
            // 
            // btnSaveSession
            // 
            this.btnSaveSession.Enabled = false;
            this.btnSaveSession.Font = new System.Drawing.Font("B Nazanin", 11.25F);
            this.btnSaveSession.Location = new System.Drawing.Point(200, 258);
            this.btnSaveSession.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSaveSession.Name = "btnSaveSession";
            this.btnSaveSession.Size = new System.Drawing.Size(355, 40);
            this.btnSaveSession.TabIndex = 58;
            this.btnSaveSession.Text = "ذخیره";
            this.btnSaveSession.UseVisualStyleBackColor = true;
            this.btnSaveSession.Click += new System.EventHandler(this.btnSaveSession_Click);
            // 
            // btnDeleteSession
            // 
            this.btnDeleteSession.Font = new System.Drawing.Font("B Nazanin", 11.25F);
            this.btnDeleteSession.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteSession.Location = new System.Drawing.Point(200, 206);
            this.btnDeleteSession.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDeleteSession.Name = "btnDeleteSession";
            this.btnDeleteSession.Size = new System.Drawing.Size(112, 40);
            this.btnDeleteSession.TabIndex = 59;
            this.btnDeleteSession.Text = "حذف";
            this.btnDeleteSession.UseVisualStyleBackColor = true;
            this.btnDeleteSession.Click += new System.EventHandler(this.btnDeleteSession_Click);
            // 
            // btnEditSession
            // 
            this.btnEditSession.Font = new System.Drawing.Font("B Nazanin", 11.25F);
            this.btnEditSession.ForeColor = System.Drawing.Color.Black;
            this.btnEditSession.Location = new System.Drawing.Point(322, 206);
            this.btnEditSession.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEditSession.Name = "btnEditSession";
            this.btnEditSession.Size = new System.Drawing.Size(112, 40);
            this.btnEditSession.TabIndex = 60;
            this.btnEditSession.Text = "ویرایش";
            this.btnEditSession.UseVisualStyleBackColor = true;
            this.btnEditSession.Click += new System.EventHandler(this.btnEditSession_Click);
            // 
            // btnNewSession
            // 
            this.btnNewSession.Font = new System.Drawing.Font("B Nazanin", 11.25F);
            this.btnNewSession.ForeColor = System.Drawing.Color.Green;
            this.btnNewSession.Location = new System.Drawing.Point(443, 206);
            this.btnNewSession.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNewSession.Name = "btnNewSession";
            this.btnNewSession.Size = new System.Drawing.Size(112, 40);
            this.btnNewSession.TabIndex = 61;
            this.btnNewSession.Text = "جدید";
            this.btnNewSession.UseVisualStyleBackColor = true;
            this.btnNewSession.Click += new System.EventHandler(this.btnNewSession_Click);
            // 
            // lblTeacher
            // 
            this.lblTeacher.AutoSize = true;
            this.lblTeacher.Location = new System.Drawing.Point(521, 131);
            this.lblTeacher.Name = "lblTeacher";
            this.lblTeacher.Size = new System.Drawing.Size(44, 23);
            this.lblTeacher.TabIndex = 55;
            this.lblTeacher.Text = "کلاس :";
            // 
            // lblLesson
            // 
            this.lblLesson.AutoSize = true;
            this.lblLesson.Location = new System.Drawing.Point(521, 78);
            this.lblLesson.Name = "lblLesson";
            this.lblLesson.Size = new System.Drawing.Size(44, 23);
            this.lblLesson.TabIndex = 56;
            this.lblLesson.Text = "ساعت :";
            // 
            // lblTerm
            // 
            this.lblTerm.AutoSize = true;
            this.lblTerm.Location = new System.Drawing.Point(521, 28);
            this.lblTerm.Name = "lblTerm";
            this.lblTerm.Size = new System.Drawing.Size(57, 23);
            this.lblTerm.TabIndex = 57;
            this.lblTerm.Text = "روز هفته :";
            // 
            // comboClass
            // 
            this.comboClass.DisplayMember = "Name";
            this.comboClass.Enabled = false;
            this.comboClass.FormattingEnabled = true;
            this.comboClass.Location = new System.Drawing.Point(200, 128);
            this.comboClass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboClass.Name = "comboClass";
            this.comboClass.Size = new System.Drawing.Size(298, 31);
            this.comboClass.TabIndex = 52;
            this.comboClass.ValueMember = "ID";
            // 
            // comboSessionTime
            // 
            this.comboSessionTime.DisplayMember = "SessionTime";
            this.comboSessionTime.Enabled = false;
            this.comboSessionTime.FormattingEnabled = true;
            this.comboSessionTime.Location = new System.Drawing.Point(200, 75);
            this.comboSessionTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboSessionTime.Name = "comboSessionTime";
            this.comboSessionTime.Size = new System.Drawing.Size(298, 31);
            this.comboSessionTime.TabIndex = 53;
            this.comboSessionTime.ValueMember = "ID";
            // 
            // comboDayOfWeek
            // 
            this.comboDayOfWeek.DisplayMember = "DayOfWeek";
            this.comboDayOfWeek.Enabled = false;
            this.comboDayOfWeek.FormattingEnabled = true;
            this.comboDayOfWeek.Items.AddRange(new object[] {
            "شنبه",
            "یکشنبه",
            "دوشنبه",
            "سه شنبه",
            "چهارشنبه",
            "پنج شنبه",
            "جمعه"});
            this.comboDayOfWeek.Location = new System.Drawing.Point(200, 25);
            this.comboDayOfWeek.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboDayOfWeek.Name = "comboDayOfWeek";
            this.comboDayOfWeek.Size = new System.Drawing.Size(298, 31);
            this.comboDayOfWeek.TabIndex = 54;
            this.comboDayOfWeek.ValueMember = "ID";
            // 
            // frmSessionManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 655);
            this.Controls.Add(this.btnSaveSession);
            this.Controls.Add(this.btnDeleteSession);
            this.Controls.Add(this.btnEditSession);
            this.Controls.Add(this.btnNewSession);
            this.Controls.Add(this.lblTeacher);
            this.Controls.Add(this.lblLesson);
            this.Controls.Add(this.lblTerm);
            this.Controls.Add(this.comboClass);
            this.Controls.Add(this.comboSessionTime);
            this.Controls.Add(this.comboDayOfWeek);
            this.Controls.Add(this.dgvSessions);
            this.Controls.Add(this.dgvCourses);
            this.Font = new System.Drawing.Font("B Nazanin", 11F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmSessionManagement";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مدیریت جلسات";
            this.Load += new System.EventHandler(this.frmSessionManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSessions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCourses;
        private System.Windows.Forms.DataGridView dgvSessions;
        private System.Windows.Forms.Button btnSaveSession;
        private System.Windows.Forms.Button btnDeleteSession;
        private System.Windows.Forms.Button btnEditSession;
        private System.Windows.Forms.Button btnNewSession;
        private System.Windows.Forms.Label lblTeacher;
        private System.Windows.Forms.Label lblLesson;
        private System.Windows.Forms.Label lblTerm;
        private System.Windows.Forms.ComboBox comboClass;
        private System.Windows.Forms.ComboBox comboSessionTime;
        private System.Windows.Forms.ComboBox comboDayOfWeek;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSessionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvClassID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSessionTimeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDayOfWeekID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDayOfWeek;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSessionTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCourseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTermTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTermId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvLessonName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTeacherName;
    }
}