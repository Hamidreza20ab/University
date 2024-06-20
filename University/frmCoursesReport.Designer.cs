
namespace University
{
    partial class frmCoursesReport
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
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.dgvCourseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTermTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLessonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTeacherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCourseCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRegisterCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSessionsCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblTeacherName = new System.Windows.Forms.Label();
            this.comboTeacherName = new System.Windows.Forms.ComboBox();
            this.comboTermTitle = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboLessonName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReport
            // 
            this.dgvReport.AllowUserToAddRows = false;
            this.dgvReport.AllowUserToDeleteRows = false;
            this.dgvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvCourseID,
            this.dgvTermTitle,
            this.dgvLessonName,
            this.dgvTeacherName,
            this.dgvCourseCapacity,
            this.dgvRegisterCount,
            this.dgvSessionsCount});
            this.dgvReport.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvReport.Location = new System.Drawing.Point(0, 170);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.ReadOnly = true;
            this.dgvReport.Size = new System.Drawing.Size(1246, 475);
            this.dgvReport.TabIndex = 4;
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
            this.dgvTermTitle.HeaderText = "عنوان ترم";
            this.dgvTermTitle.Name = "dgvTermTitle";
            this.dgvTermTitle.ReadOnly = true;
            // 
            // dgvLessonName
            // 
            this.dgvLessonName.DataPropertyName = "LessonName";
            this.dgvLessonName.HeaderText = "نام درس";
            this.dgvLessonName.Name = "dgvLessonName";
            this.dgvLessonName.ReadOnly = true;
            // 
            // dgvTeacherName
            // 
            this.dgvTeacherName.DataPropertyName = "TeacherName";
            this.dgvTeacherName.HeaderText = "نام مدرس";
            this.dgvTeacherName.Name = "dgvTeacherName";
            this.dgvTeacherName.ReadOnly = true;
            // 
            // dgvCourseCapacity
            // 
            this.dgvCourseCapacity.DataPropertyName = "CourseCapacity";
            this.dgvCourseCapacity.HeaderText = "ظرفیت ثبت نام دوره";
            this.dgvCourseCapacity.Name = "dgvCourseCapacity";
            this.dgvCourseCapacity.ReadOnly = true;
            // 
            // dgvRegisterCount
            // 
            this.dgvRegisterCount.DataPropertyName = "RegisterCount";
            this.dgvRegisterCount.HeaderText = "تعداد ثبت نام دوره";
            this.dgvRegisterCount.Name = "dgvRegisterCount";
            this.dgvRegisterCount.ReadOnly = true;
            // 
            // dgvSessionsCount
            // 
            this.dgvSessionsCount.DataPropertyName = "SessionsCount";
            this.dgvSessionsCount.HeaderText = "تعداد جلسات دوره";
            this.dgvSessionsCount.Name = "dgvSessionsCount";
            this.dgvSessionsCount.ReadOnly = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("B Nazanin", 11.25F);
            this.btnSubmit.Location = new System.Drawing.Point(219, 111);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(355, 40);
            this.btnSubmit.TabIndex = 62;
            this.btnSubmit.Text = "جستجو";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblTeacherName
            // 
            this.lblTeacherName.AutoSize = true;
            this.lblTeacherName.Location = new System.Drawing.Point(1183, 52);
            this.lblTeacherName.Name = "lblTeacherName";
            this.lblTeacherName.Size = new System.Drawing.Size(57, 23);
            this.lblTeacherName.TabIndex = 61;
            this.lblTeacherName.Text = "نام استاد :";
            // 
            // comboTeacherName
            // 
            this.comboTeacherName.DisplayMember = "FullName";
            this.comboTeacherName.FormattingEnabled = true;
            this.comboTeacherName.Items.AddRange(new object[] {
            ""});
            this.comboTeacherName.Location = new System.Drawing.Point(862, 49);
            this.comboTeacherName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboTeacherName.Name = "comboTeacherName";
            this.comboTeacherName.Size = new System.Drawing.Size(298, 31);
            this.comboTeacherName.TabIndex = 60;
            this.comboTeacherName.ValueMember = "ID";
            // 
            // comboTermTitle
            // 
            this.comboTermTitle.DisplayMember = "TermTitle";
            this.comboTermTitle.FormattingEnabled = true;
            this.comboTermTitle.Location = new System.Drawing.Point(432, 49);
            this.comboTermTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboTermTitle.Name = "comboTermTitle";
            this.comboTermTitle.Size = new System.Drawing.Size(298, 31);
            this.comboTermTitle.TabIndex = 60;
            this.comboTermTitle.ValueMember = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(753, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 23);
            this.label1.TabIndex = 61;
            this.label1.Text = "ترم :";
            // 
            // comboLessonName
            // 
            this.comboLessonName.DisplayMember = "Name";
            this.comboLessonName.FormattingEnabled = true;
            this.comboLessonName.Location = new System.Drawing.Point(24, 49);
            this.comboLessonName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboLessonName.Name = "comboLessonName";
            this.comboLessonName.Size = new System.Drawing.Size(298, 31);
            this.comboLessonName.TabIndex = 60;
            this.comboLessonName.ValueMember = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(345, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 23);
            this.label2.TabIndex = 61;
            this.label2.Text = "درس :";
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("B Nazanin", 11.25F);
            this.btnPrint.Location = new System.Drawing.Point(650, 111);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(355, 40);
            this.btnPrint.TabIndex = 62;
            this.btnPrint.Text = "چاپ";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmCoursesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 645);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTeacherName);
            this.Controls.Add(this.comboLessonName);
            this.Controls.Add(this.comboTermTitle);
            this.Controls.Add(this.comboTeacherName);
            this.Controls.Add(this.dgvReport);
            this.Font = new System.Drawing.Font("B Nazanin", 11F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmCoursesReport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "گزارشات دوره";
            this.Load += new System.EventHandler(this.frmCoursesReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCourseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTermTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvLessonName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTeacherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCourseCapacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvRegisterCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSessionsCount;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblTeacherName;
        private System.Windows.Forms.ComboBox comboTeacherName;
        private System.Windows.Forms.ComboBox comboTermTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboLessonName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPrint;
    }
}