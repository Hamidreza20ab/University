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
    public partial class frmCourseManagement : Form
    {
        CoursesRepository courseRepo;
        ButtonState Flag;

        public frmCourseManagement()
        {
            courseRepo = new CoursesRepository();
            Flag = ButtonState.None;
            InitializeComponent();
        }
        enum ButtonState
        {
            None = 1, Add = 2, Update = 3
        }
        private void DisableTxt()
        {
            txtCourseCapacity.Enabled = false;
            comboLessonName.Enabled = false;
            comboTeacherName.Enabled = false;
            comboTermTitle.Enabled = false;
            btnSaveCourse.Enabled = false;
        }
        private void EnableTxt()
        {
            txtCourseCapacity.Enabled = true;
            comboLessonName.Enabled = true;
            comboTeacherName.Enabled = true;
            comboTermTitle.Enabled = true;
            btnSaveCourse.Enabled = true;
        }
        private void EmptyTxt()
        {
            txtCourseCapacity.Text = "";
            comboLessonName.Text = "";
            comboTeacherName.Text = "";
            comboTermTitle.Text = "";
        }
        private void frmCourseManagement_Load(object sender, EventArgs e)
        {
            dgvCourse.AutoGenerateColumns = false;
            dgvCourse.DataSource = courseRepo.GetAll();
            comboTeacherName.DataSource = courseRepo.GetTeacher();
            comboLessonName.DataSource = courseRepo.GetLesson();
            comboTermTitle.DataSource = courseRepo.GetTerm();
        }

        private void btnNewCourse_Click(object sender, EventArgs e)
        {
            if (Flag == ButtonState.None)
            {
                Flag = ButtonState.Add;
                dgvCourse.ClearSelection();
                EmptyTxt();
                EnableTxt();
                btnEditCourse.Enabled = false;
                btnDeleteCourse.Enabled = false;
                btnNewCourse.Text = "انصراف";
            }
            else if (Flag == ButtonState.Add)
            {
                Flag = ButtonState.None;
                EmptyTxt();
                DisableTxt();
                btnEditCourse.Enabled = true;
                btnDeleteCourse.Enabled = true;
                btnNewCourse.Text = "جدید";
            }
        }

        private void btnEditCourse_Click(object sender, EventArgs e)
        {
            if (dgvCourse.CurrentRow == null || dgvCourse.SelectedRows.Count == 0)
            {
                MessageBox.Show("ردیفی انتخاب نشده است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Flag == ButtonState.None)
            {
                Flag = ButtonState.Update;
                EnableTxt();
                btnDeleteCourse.Enabled = false;
                btnNewCourse.Enabled = false;
                btnEditCourse.Text = "انصراف";
            }
            else if (Flag == ButtonState.Update)
            {
                Flag = ButtonState.None;
                DisableTxt();
                btnDeleteCourse.Enabled = true;
                btnNewCourse.Enabled = true;
                btnEditCourse.Text = "ویرایش";
            }
        }

        private void btnDeleteCourse_Click(object sender, EventArgs e)
        {

            string LessonName = Convert.ToString(dgvCourse.CurrentRow.Cells["dgvLessonName"].Value);
            string TeacherName = Convert.ToString(dgvCourse.CurrentRow.Cells["dgvTeacherName"].Value);
            int CourseId = Convert.ToInt32(dgvCourse.CurrentRow.Cells["dgvCourseID"].Value);
            if (courseRepo.CanDelete(CourseId))
            {
                MessageBox.Show("شما مجاز به حذف این دوره نیستید. ابتدا ثبت نام های مربوطه را حذف کنید، سپس مجددا تلاش کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                return;
            }
            if (MessageBox.Show($@"آیا از حذف درس '{LessonName}' با استاد '{TeacherName}' اطمینان دارید؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                courseRepo.Delete(CourseId);
                dgvCourse.DataSource = courseRepo.GetAll();
            }
        }

        private void btnSaveCourse_Click(object sender, EventArgs e)
        {
            if (comboLessonName.Text == "" || comboLessonName.SelectedValue == null)
            {
                MessageBox.Show("لطفا نام درس را وارد کنید", "خطا");
                return;
            }
            if (comboTeacherName.Text == "" || comboTeacherName.SelectedValue == null)
            {
                MessageBox.Show("لطفا نام مدرس را وارد کنید", "خطا");
                return;
            }
            if (comboTermTitle.Text == "" || comboTermTitle.SelectedValue == null)
            {
                MessageBox.Show("لطفا عنوان ترم را وارد کنید", "خطا");
                return;
            }
            if (txtCourseCapacity.Text == "" || txtCourseCapacity.Text == null)
            {
                MessageBox.Show("لطفا ظرفیت دوره را وارد کنید", "خطا");
                return;
            }
            if (Flag == ButtonState.Add)
            {
                if (courseRepo.InsertFilter(Convert.ToInt32(comboTermTitle.SelectedValue), Convert.ToInt32(comboLessonName.SelectedValue), Convert.ToInt32(comboTeacherName.SelectedValue), Convert.ToByte(txtCourseCapacity.Text)))
                {
                    courseRepo.Add(Convert.ToInt32(comboTermTitle.SelectedValue), Convert.ToInt32(comboLessonName.SelectedValue), Convert.ToInt32(comboTeacherName.SelectedValue), Convert.ToByte(txtCourseCapacity.Text));
                    DisableTxt();
                    EmptyTxt();
                    dgvCourse.DataSource = courseRepo.GetAll();
                    btnNewCourse.Text = "جدید";
                    btnEditCourse.Enabled = true;
                    btnDeleteCourse.Enabled = true;
                    Flag = ButtonState.None;
                }
                else
                {
                    MessageBox.Show("این دوره قبلا تعریف شده است");
                    Flag = ButtonState.None;
                }
            }
            else if (Flag == ButtonState.Update)
            {

                int courseId = Convert.ToInt32(dgvCourse.CurrentRow.Cells["dgvCourseID"].Value);
                courseRepo.Update(courseId, Convert.ToInt32(comboTermTitle.SelectedValue), Convert.ToInt32(comboLessonName.SelectedValue), Convert.ToInt32(comboTeacherName.SelectedValue), Convert.ToByte(txtCourseCapacity.Text));
                EmptyTxt();
                DisableTxt();
                btnDeleteCourse.Enabled = true;
                btnNewCourse.Enabled = true;
                dgvCourse.DataSource = courseRepo.GetAll();
                btnEditCourse.Text = "ویرایش";
                Flag = ButtonState.None;
            }

        }

        private void dgvCourse_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCourse.CurrentRow != null)
            {
                string TermTitle = Convert.ToString(dgvCourse.CurrentRow.Cells["dgvTermTitle"].Value);
                string LessonName = Convert.ToString(dgvCourse.CurrentRow.Cells["dgvLessonName"].Value);
                string TeacherName = Convert.ToString(dgvCourse.CurrentRow.Cells["dgvTeacherName"].Value);
                string CourseCapacity = Convert.ToString(dgvCourse.CurrentRow.Cells["dgvCourseCapacity"].Value);

                comboTermTitle.Text = TermTitle;
                comboLessonName.Text = LessonName;
                comboTeacherName.Text = TeacherName;
                txtCourseCapacity.Text = CourseCapacity;
            }

        }
    }

}
