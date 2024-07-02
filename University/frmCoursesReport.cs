using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using University.DataLayer;

namespace University
{
    public partial class frmCoursesReport : Form
    {   
        LessonsRepository LessonsRepo;
        CoursesRepository CoursesRepo;
        TeachersRepository TeachersRepo;
        TermsRepository TermsRepo;
        public frmCoursesReport()
        {
            LessonsRepo = new LessonsRepository();
            CoursesRepo = new CoursesRepository();
            TeachersRepo = new TeachersRepository();
            TermsRepo = new TermsRepository();
            InitializeComponent();
        }

        private void frmCoursesReport_Load(object sender, EventArgs e)
        {
            dgvReport.AutoGenerateColumns = false;
            comboLessonName.DataSource = LessonsRepo.GetLessons();
            comboTeacherName.DataSource = TeachersRepo.GetTeachers();
            comboTermTitle.DataSource = TermsRepo.GetTerm();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int? TermID = null;
            int? LessonID = null;
            int? TeacherID = null;
            if (comboTermTitle.SelectedValue != DBNull.Value)
                TermID = Convert.ToInt32(comboTermTitle.SelectedValue);
            if (comboLessonName.SelectedValue != DBNull.Value)
                LessonID = Convert.ToInt32(comboLessonName.SelectedValue);
            if (comboTeacherName.SelectedValue != DBNull.Value)
                TeacherID = Convert.ToInt32(comboTeacherName.SelectedValue);
            dgvReport.DataSource = CoursesRepo.Search(TermID,LessonID,TeacherID);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //ReportViewer reportViewer = new ReportViewer("CourseReport");
            //reportViewer.LessonID = Convert.ToInt32(comboLessonName.SelectedValue);
            //reportViewer.TermID = Convert.ToInt32(comboTermTitle.SelectedValue);
            //reportViewer.TeacherID = Convert.ToInt32(comboTeacherName.SelectedValue);
            //reportViewer.Show();
        }
    }
}
