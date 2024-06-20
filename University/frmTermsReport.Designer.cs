
namespace University
{
    partial class frmTermsReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboTermTitle = new System.Windows.Forms.ComboBox();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.dgvTermTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCourseCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRegisterCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("B Nazanin", 11.25F);
            this.btnSubmit.Location = new System.Drawing.Point(176, 111);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(355, 51);
            this.btnSubmit.TabIndex = 66;
            this.btnSubmit.Text = "جستجو";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(753, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 23);
            this.label1.TabIndex = 65;
            this.label1.Text = "ترم :";
            // 
            // comboTermTitle
            // 
            this.comboTermTitle.DisplayMember = "TermTitle";
            this.comboTermTitle.FormattingEnabled = true;
            this.comboTermTitle.Location = new System.Drawing.Point(432, 32);
            this.comboTermTitle.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.comboTermTitle.Name = "comboTermTitle";
            this.comboTermTitle.Size = new System.Drawing.Size(298, 31);
            this.comboTermTitle.TabIndex = 64;
            this.comboTermTitle.ValueMember = "ID";
            // 
            // dgvReport
            // 
            this.dgvReport.AllowUserToAddRows = false;
            this.dgvReport.AllowUserToDeleteRows = false;
            this.dgvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvTermTitle,
            this.dgvStartDate,
            this.dgvEndDate,
            this.dgvCourseCount,
            this.dgvRegisterCount});
            this.dgvReport.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvReport.Location = new System.Drawing.Point(0, 187);
            this.dgvReport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.ReadOnly = true;
            this.dgvReport.Size = new System.Drawing.Size(1249, 451);
            this.dgvReport.TabIndex = 63;
            // 
            // dgvTermTitle
            // 
            this.dgvTermTitle.DataPropertyName = "TermTitle";
            this.dgvTermTitle.HeaderText = "عنوان ترم";
            this.dgvTermTitle.Name = "dgvTermTitle";
            this.dgvTermTitle.ReadOnly = true;
            // 
            // dgvStartDate
            // 
            this.dgvStartDate.DataPropertyName = "StartDate";
            dataGridViewCellStyle1.Format = "0000/00/00";
            this.dgvStartDate.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStartDate.HeaderText = "تاریخ شروع";
            this.dgvStartDate.Name = "dgvStartDate";
            this.dgvStartDate.ReadOnly = true;
            // 
            // dgvEndDate
            // 
            this.dgvEndDate.DataPropertyName = "EndDate";
            dataGridViewCellStyle2.Format = "0000/00/00";
            this.dgvEndDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEndDate.HeaderText = "تاریخ پایان";
            this.dgvEndDate.Name = "dgvEndDate";
            this.dgvEndDate.ReadOnly = true;
            // 
            // dgvCourseCount
            // 
            this.dgvCourseCount.DataPropertyName = "CourseCount";
            this.dgvCourseCount.HeaderText = "تعداد دوره های ترم";
            this.dgvCourseCount.Name = "dgvCourseCount";
            this.dgvCourseCount.ReadOnly = true;
            // 
            // dgvRegisterCount
            // 
            this.dgvRegisterCount.DataPropertyName = "RegisterCount";
            this.dgvRegisterCount.HeaderText = "تعداد ثبت نام  در ترم";
            this.dgvRegisterCount.Name = "dgvRegisterCount";
            this.dgvRegisterCount.ReadOnly = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("B Nazanin", 11.25F);
            this.btnPrint.Location = new System.Drawing.Point(675, 111);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(355, 51);
            this.btnPrint.TabIndex = 67;
            this.btnPrint.Text = "چاپ";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmTermsReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 638);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboTermTitle);
            this.Controls.Add(this.dgvReport);
            this.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmTermsReport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "گزارش ترم های تحصیلی";
            this.Load += new System.EventHandler(this.frmTermsReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboTermTitle;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTermTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCourseCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvRegisterCount;
        private System.Windows.Forms.Button btnPrint;
    }
}