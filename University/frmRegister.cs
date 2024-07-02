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
    public partial class frmRegister : Form
    {
        StudentsRepository StudentsRepo;
        CoursesRepository CoursesRepo;
        RegisterRepository RegisterRepo;
        int CourseId;
        int StudentId;
        int RegisterId;

        public frmRegister()
        {
            StudentsRepo = new StudentsRepository();
            CoursesRepo = new CoursesRepository();
            RegisterRepo = new RegisterRepository();
            InitializeComponent();
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            
            dgvCourses.AutoGenerateColumns = false;
            dgvStudents.AutoGenerateColumns = false;
            dgvStudents.DataSource = StudentsRepo.GetStudents(CourseId);
            dgvCourses.DataSource = CoursesRepo.GetAll();
            comboStudentName.DataSource = StudentsRepo.GetStudentName();
            if (dgvCourses.RowCount == 0)
                btnSaveStudent.Enabled = false;
        }

        private void dgvCourses_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCourses.CurrentRow != null) { 
            CourseId = (int)dgvCourses.CurrentRow.Cells["dgvCourseID"].Value;
            dgvStudents.DataSource = StudentsRepo.GetStudents(CourseId);}
        }

        private void btnSaveStudent_Click(object sender, EventArgs e)
        {
            
                int CourseCapacity = Convert.ToInt32(dgvCourses.CurrentRow.Cells["dgvCourseCapacity"].Value);
                int RegisterCount = dgvStudents.Rows.Count;
                if (!RegisterRepo.IsValidRegister(CourseId, (int)comboStudentName.SelectedValue))
                {
                    MessageBox.Show("این دانجشو از قبل در این دوره ثبت نام کرده است");
                    return;
                }
                if (RegisterCount <= CourseCapacity)
                {
                    RegisterRepo.Add(CourseId, Convert.ToInt32(comboStudentName.SelectedValue));
                }
                else
                {
                    MessageBox.Show("ظرفیت دوره تکمیل شده است");
                }
            

            dgvStudents.DataSource = StudentsRepo.GetStudents(CourseId);

        }

        private void dgvStudents_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvStudents.CurrentRow != null) { 
                RegisterId = (int)dgvStudents.CurrentRow.Cells["dgvRegisterID"].Value;
                StudentId = (int)dgvStudents.CurrentRow.Cells["dgvStudentID"].Value;
            }
        }

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvStudents.CurrentCell.OwningColumn == dgvDeleteButton)
            {
                string StudentName = (string)dgvStudents.CurrentRow.Cells["dgvStudentFullName"].Value;
                string CourseName = (string)dgvCourses.CurrentRow.Cells["dgvLessonName"].Value;
                if (MessageBox.Show($@"آیا از حذف ثبت نام دانشجو {StudentName} از دوره {CourseName} مطمئن هستید؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    RegisterRepo.Delete(RegisterId);
                dgvStudents.DataSource = StudentsRepo.GetStudents(CourseId);
            }
        }
    }
}
