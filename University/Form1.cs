using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using University.DataLayer;

namespace University
{
    public partial class frmMain : Form
    {
        ButtonState Flag;
        StudentsRepository studentRepo;
        TeachersRepository teachersRepo;
        LessonsRepository lessonsRepo;
        ClassesRepository classesRepo;
        TermsRepository termsRepo;
        SessionsTimeRepository sessionsTimeRepo;

        enum ButtonState
        {
            None = 1,
            Add = 2,
            Update = 3
        }
        public frmMain()
        {
            teachersRepo = new TeachersRepository();
            studentRepo = new StudentsRepository();
            lessonsRepo = new LessonsRepository();
            classesRepo = new ClassesRepository();
            termsRepo = new TermsRepository();
            sessionsTimeRepo = new SessionsTimeRepository();
            Flag = ButtonState.None;
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            dgvStudents.AutoGenerateColumns = false;
            dgvTeachers.AutoGenerateColumns = false;
            dgvLessons.AutoGenerateColumns = false;
            dgvClassses.AutoGenerateColumns = false;
            dgvTerms.AutoGenerateColumns = false;
            dgvSessionTime.AutoGenerateColumns = false;
            dgvStudents.DataSource = studentRepo.GetAll();
            dgvTeachers.DataSource = teachersRepo.GetAll();
            dgvLessons.DataSource = lessonsRepo.GetAll();
            dgvClassses.DataSource = classesRepo.GetAll();
            dgvTerms.DataSource = termsRepo.GetAll();
            dgvSessionTime.DataSource = sessionsTimeRepo.GetAll();
            

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (Flag == ButtonState.None)
            {
                Flag = ButtonState.Add;
                dgvStudents.ClearSelection();
                Emptytxt();
                txtEnable();
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                btnNewLesson.ForeColor = Color.Black;
                btnNew.Text = "انصراف";
            }
            else
            {
                Flag = ButtonState.None;
                Emptytxt();
                txtFalse();
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
                btnNewLesson.ForeColor = Color.Green;
                btnNew.Text = "جدید";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFullName.Text))
            {
                MessageBox.Show("لطفا نام را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txtNationalCode.Text))
            {
                MessageBox.Show("لطفا کدملی را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtNationalCode.Text.Length != 10)
            {
                MessageBox.Show("طول کد ملی وارد شده صحیح نیست", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtPhoneNumber.Text))
            {
                MessageBox.Show("لطفا شماره تلفن را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtPhoneNumber.Text.Length != 11)
            {
                MessageBox.Show("طول شماره وارد شده صحیح نیست", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (string.IsNullOrEmpty(txtFatherName.Text))
            {
                MessageBox.Show("لطفا نام پدر را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int? birthdateValue = null;
            if (!string.IsNullOrEmpty(txtBirthDate.Text))
            {
                birthdateValue = Convert.ToInt32(txtBirthDate.Text);
            }
            if (Flag == ButtonState.Add)
            {
                studentRepo.Add(txtFullName.Text, txtNationalCode.Text, txtFatherName.Text, txtPhoneNumber.Text, birthdateValue, txtAddress.Text);
                txtFalse();
                Emptytxt();
                dgvStudents.DataSource = studentRepo.GetAll();
                Flag = ButtonState.None;
                btnDelete.Enabled = true;
                btnEdit.Enabled = true;
                btnNew.Text = "جدید";
            }
            else if (Flag == ButtonState.Update)
            {
                int studentId = Convert.ToInt32(dgvStudents.CurrentRow.Cells["dgvId"].Value);
                studentRepo.Update(studentId, txtFullName.Text, txtNationalCode.Text, txtFatherName.Text, txtPhoneNumber.Text, birthdateValue, txtAddress.Text);
                txtFalse();
                btnNew.Enabled = true;
                btnDelete.Enabled = true;
                Emptytxt();
                dgvStudents.DataSource = studentRepo.GetAll();
                Flag = ButtonState.None;
                btnEdit.Text = "ویرایش";
            }
        }


        private void txtFalse()
        {
            EnableAllTabs();
            txtAddress.Enabled = false;
            txtBirthDate.Enabled = false;
            txtFatherName.Enabled = false;
            txtFullName.Enabled = false;
            txtNationalCode.Enabled = false;
            txtPhoneNumber.Enabled = false;
            txtBirthDate.Enabled = false;
            dgvStudents.Enabled = true;
            btnSave.Enabled = false;


        }
        private void txtFalseTeachers()
        {
            EnableAllTabs();
            rdbMan.Enabled = false;
            rdbWoman.Enabled = false;
            txtTeacherAddress.Enabled = false;
            txtTeacherBirthDate.Enabled = false;
            txtTeacherFatherName.Enabled = false;
            txtTeacherFullName.Enabled = false;
            txtTeacherNationalCode.Enabled = false;
            txtTeacherPhoneNumber.Enabled = false;
            txtTeacherBirthDate.Enabled = false;
            dgvTeachers.Enabled = true;
            btnSaveTeachers.Enabled = false;
        }
        private void txtFalseLessons()
        {
            EnableAllTabs();
            dgvLessons.Enabled = true;
            txtLessonName.Enabled = false;
            btnSaveLesson.Enabled = false;
        }
        private void txtFalseClasses()
        {
            EnableAllTabs();
            dgvClassses.Enabled = true;
            txtClassCapacity.Enabled = false;
            txtClassName.Enabled = false;
            btnSaveClass.Enabled = false;
        }
        private void txtFalseTerms()
        {
            EnableAllTabs();
            dgvTerms.Enabled = true;
            txtTermTitle.Enabled = false;
            txtTermStartDate.Enabled = false;
            txtTermEndDate.Enabled = false;
            btnSaveTerm.Enabled = false;
        }
        private void txtFalseSessionTime()
        {
            EnableAllTabs();
            dgvSessionTime.Enabled = true;
            txtSessionStartTime.Enabled = false;
            txtSessionEndTime.Enabled = false;
            btnSaveSessiontime.Enabled = false;
        }
        private void txtEnable()
        {
            DisableOtherTabs();
            txtAddress.Enabled = true;
            txtBirthDate.Enabled = true;
            txtFatherName.Enabled = true;
            txtFullName.Enabled = true;
            txtNationalCode.Enabled = true;
            txtPhoneNumber.Enabled = true;
            txtBirthDate.Enabled = true;
            dgvStudents.Enabled = false;
            btnSave.Enabled = true;
        }
        private void txtEnableTeachers()
        {
            DisableOtherTabs();
            rdbMan.Enabled = true;
            rdbWoman.Enabled = true;
            dgvTeachers.Enabled = false;
            txtTeacherAddress.Enabled = true;
            txtTeacherBirthDate.Enabled = true;
            txtTeacherFatherName.Enabled = true;
            txtTeacherFullName.Enabled = true;
            txtTeacherNationalCode.Enabled = true;
            txtTeacherPhoneNumber.Enabled = true;
            txtTeacherBirthDate.Enabled = true;
            btnSaveTeachers.Enabled = true;
        }
        private void txtEnableLessons()
        {
            DisableOtherTabs();
            dgvLessons.Enabled = false;
            txtLessonName.Enabled = true;
            btnSaveLesson.Enabled = true;
        }
        private void txtEnableClasses()
        {
            DisableOtherTabs();
            dgvClassses.Enabled = false;
            txtClassCapacity.Enabled = true;
            txtClassName.Enabled = true;
            btnSaveClass.Enabled = true;
        }
        private void txtEnableTerms()
        {
            DisableOtherTabs();
            dgvTerms.Enabled = false;
            txtTermTitle.Enabled = true;
            txtTermStartDate.Enabled = true;
            txtTermEndDate.Enabled = true;
            btnSaveTerm.Enabled = true;
        }
        private void txtEnableSessionTime()
        {
            DisableOtherTabs();
            dgvSessionTime.Enabled = false;
            txtSessionStartTime.Enabled = true;
            txtSessionEndTime.Enabled = true;
            btnSaveSessiontime.Enabled = true;
        }
        private void Emptytxt()
        {
            txtFullName.Text = "";
            txtNationalCode.Text = "";
            txtPhoneNumber.Text = "";
            txtFatherName.Text = "";
            txtBirthDate.Text = "";
            txtAddress.Text = "";
            txtBirthDate.Text = "";
        }
        private void EmptytxtTeachers()
        {
            txtTeacherFullName.Text = "";
            txtTeacherNationalCode.Text = "";
            txtTeacherPhoneNumber.Text = "";
            txtTeacherFatherName.Text = "";
            txtTeacherBirthDate.Text = "";
            txtTeacherAddress.Text = "";
            txtTeacherBirthDate.Text = "";
        }
        private void EmptytxtClasses()
        {
            txtClassCapacity.Text = "";
            txtClassName.Text = "";
        }
        private void EmptytxtTerms()
        {
            txtTermTitle.Text = "";
            txtTermStartDate.Text = "";
            txtTermEndDate.Text = "";
        }
        private void EmptytxtSessionTime()
        {
            txtSessionStartTime.Text = "";
            txtSessionEndTime.Text = "";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvStudents.CurrentRow == null || dgvStudents.SelectedRows.Count == 0)
            {
                MessageBox.Show("ردیفی انتخاب نشده است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Flag == ButtonState.None)
            {
                Flag = ButtonState.Update;
                txtEnable();
                btnDelete.Enabled = false;
                btnNew.Enabled = false;
                btnEdit.Text = "انصراف";
            }
            else
            {
                Flag = ButtonState.None;
                txtFalse();
                btnNew.Enabled = true;
                btnDelete.Enabled = true;
                btnEdit.Text = "ویرایش";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string name = Convert.ToString(dgvStudents.CurrentRow.Cells["dgvFullName"].Value);
            int studentId = Convert.ToInt32(dgvStudents.CurrentRow.Cells["dgvId"].Value);
            if (dgvStudents.CurrentRow == null || dgvStudents.SelectedRows.Count == 0)
            {
                MessageBox.Show("ردیفی انتخاب نشده است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (studentRepo.CanDelete(studentId))
            {
                MessageBox.Show("شما مجاز به حذف این دانشجو نیستید. ابتدا دوره های ثبت نام شده را حذف کنید، سپس مجددا تلاش کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                return;
            }
            // int studentId = Convert.ToInt32(dgvStudents.CurrentCell.OwningRow.Cells["dgvId"].Value);
            if (MessageBox.Show($"آیا از حذف {name} اطمینان دارید؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                studentRepo.Delete(studentId);
                dgvStudents.DataSource = studentRepo.GetAll();
            }

        }

        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvStudents_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvStudents.CurrentRow != null)
            {
                string FullName = Convert.ToString(dgvStudents.CurrentRow.Cells["dgvFullName"].Value);
                string NationalCode = Convert.ToString(dgvStudents.CurrentRow.Cells["dgvNationalCode"].Value);
                string FatherName = Convert.ToString(dgvStudents.CurrentRow.Cells["dgvFatherName"].Value);
                string BirthDate = Convert.ToString(dgvStudents.CurrentRow.Cells["dgvBirthDate"].Value);
                string PhoneNumber = Convert.ToString(dgvStudents.CurrentRow.Cells["dgvPhoneNumber"].Value);
                string Address = Convert.ToString(dgvStudents.CurrentRow.Cells["dgvAddress"].Value);
                txtFullName.Text = FullName;
                txtNationalCode.Text = NationalCode;
                txtFatherName.Text = FatherName;
                txtBirthDate.Text = BirthDate;
                txtPhoneNumber.Text = PhoneNumber;
                txtAddress.Text = Address;
                txtBirthDate.Text = BirthDate;
            }

        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void txtBirthDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void txtNationalCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void btnSaveTeachers_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTeacherFullName.Text))
            {
                MessageBox.Show("لطفا نام را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txtTeacherNationalCode.Text))
            {
                MessageBox.Show("لطفا کدملی را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtTeacherNationalCode.Text.Length != 10)
            {
                MessageBox.Show("طول کد ملی وارد شده صحیح نیست", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtTeacherPhoneNumber.Text))
            {
                MessageBox.Show("لطفا شماره تلفن را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtTeacherPhoneNumber.Text.Length != 11)
            {
                MessageBox.Show("طول شماره وارد شده صحیح نیست", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (string.IsNullOrEmpty(txtTeacherFatherName.Text))
            {
                MessageBox.Show("لطفا نام پدر را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtTeacherBirthDate.Text))
            {
                MessageBox.Show("لطفا تاریخ تولد را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtTeacherBirthDate.Text.Length != 8)
            {
                MessageBox.Show("طول تاریخ تولد صحیح نیست", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!rdbMan.Checked && !rdbWoman.Checked)
            {
                MessageBox.Show("جنسیت انتخاب نشده است");
                return;
            }
            bool GenderStatus = rdbMan.Checked;

            if (Flag == ButtonState.Add)
            {
                teachersRepo.Add(txtTeacherFullName.Text, txtTeacherNationalCode.Text, GenderStatus, txtTeacherFatherName.Text, txtTeacherPhoneNumber.Text, Convert.ToInt32(txtTeacherBirthDate.Text), txtTeacherAddress.Text);
                txtFalseTeachers();
                EmptytxtTeachers();
                btnDeleteTeacher.Enabled = true;
                btnEditTeacher.Enabled = true;
                dgvTeachers.DataSource = teachersRepo.GetAll();
                btnNewTeacher.Text = "جدید";
                Flag = ButtonState.None;
            }
            else if (Flag == ButtonState.Update)
            {
                int teacherId = Convert.ToInt32(dgvTeachers.CurrentRow.Cells["dgvTeachersID"].Value);
                teachersRepo.Update(teacherId, txtTeacherFullName.Text, txtTeacherNationalCode.Text, GenderStatus, txtTeacherFatherName.Text, txtTeacherPhoneNumber.Text, Convert.ToInt32(txtTeacherBirthDate.Text), txtTeacherAddress.Text);
                txtFalseTeachers();
                EmptytxtTeachers();
                btnNewTeacher.Enabled = true;
                btnDeleteTeacher.Enabled = true;
                dgvTeachers.DataSource = teachersRepo.GetAll();
                btnEditTeacher.Text = "ویرایش";
                Flag = ButtonState.None;
            }
        }

        private void btnNewTeacher_Click(object sender, EventArgs e)
        {
            if (Flag == ButtonState.None)
            {
                Flag = ButtonState.Add;
                dgvTeachers.ClearSelection();
                EmptytxtTeachers();
                txtEnableTeachers();
                btnEditTeacher.Enabled = false;
                btnDeleteTeacher.Enabled = false;
                btnNewTeacher.ForeColor = Color.Black;
                btnNewTeacher.Text = "انصراف";
            }
            else
            {
                Flag = ButtonState.None;
                EmptytxtTeachers();
                txtFalseTeachers();
                btnEditTeacher.Enabled = true;
                btnDeleteTeacher.Enabled = true;
                btnNewTeacher.ForeColor = Color.Green;
                btnNewTeacher.Text = "جدید";
            }
        }

        private void btnDeleteTeacher_Click(object sender, EventArgs e)
        {
            string name;
            int teacherId;
            if (dgvTeachers.CurrentRow == null || dgvTeachers.SelectedRows.Count == 0)
            {
                MessageBox.Show("ردیفی انتخاب نشده است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                name = Convert.ToString(dgvTeachers.CurrentRow.Cells["dgvTeachersFullName"].Value);
                teacherId = Convert.ToInt32(dgvTeachers.CurrentRow.Cells["dgvTeachersID"].Value);

            }
            if (teachersRepo.CanDelete(teacherId))
            {
                MessageBox.Show("شما مجاز به حذف این مدرس نیستید. ابتدا دوره های مربوطه را حذف کنید، سپس مجددا تلاش کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error,MessageBoxDefaultButton.Button1,MessageBoxOptions.RightAlign);
                return;
            }
           
            if (MessageBox.Show($"آیا از حذف {name} اطمینان دارید؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                teachersRepo.Delete(teacherId);
                dgvTeachers.DataSource = teachersRepo.GetAll();
            }
        }

        private void btnEditTeacher_Click(object sender, EventArgs e)
        {
            if (dgvTeachers.CurrentRow == null || dgvTeachers.SelectedRows.Count == 0)
            {
                MessageBox.Show("ردیفی انتخاب نشده است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Flag == ButtonState.None)
            {
                Flag = ButtonState.Update;
                txtEnableTeachers();
                btnDeleteTeacher.Enabled = false;
                btnNewTeacher.Enabled = false;
                btnEditTeacher.Text = "انصراف";
            }
            else
            {
                Flag = ButtonState.None;
                txtFalseTeachers();
                btnNewTeacher.Enabled = true;
                btnDeleteTeacher.Enabled = true;
                btnEditTeacher.Text = "ویرایش";
            }
        }

        private void txtTeacherNationalCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void txtTeacherPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void txtTeacherBirthDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }
        private void dgvTeachers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTeachers.CurrentRow != null)
            {
                string FullName = Convert.ToString(dgvTeachers.CurrentRow.Cells["dgvTeachersFullName"].Value);
                string NationalCode = Convert.ToString(dgvTeachers.CurrentRow.Cells["dgvTeachersNationalCode"].Value);
                string FatherName = Convert.ToString(dgvTeachers.CurrentRow.Cells["dgvTeachersFatherName"].Value);
                string BirthDate = Convert.ToString(dgvTeachers.CurrentRow.Cells["dgvTeachersBirthDate"].Value);
                string PhoneNumber = Convert.ToString(dgvTeachers.CurrentRow.Cells["dgvTeachersPhoneNumber"].Value);
                string Address = Convert.ToString(dgvTeachers.CurrentRow.Cells["dgvTeachersAddress"].Value);
                bool GenderStatus = Convert.ToBoolean(dgvTeachers.CurrentRow.Cells["dgvGenderCode"].Value);
                if (GenderStatus == false)
                {
                    rdbWoman.Checked = true;
                }
                else rdbMan.Checked = true;

                txtTeacherFullName.Text = FullName;
                txtTeacherNationalCode.Text = NationalCode;
                txtTeacherFatherName.Text = FatherName;
                txtTeacherBirthDate.Text = BirthDate;
                txtTeacherPhoneNumber.Text = PhoneNumber;
                txtTeacherAddress.Text = Address;
                txtTeacherBirthDate.Text = BirthDate;
            }
        }
        //End OF Teachers Section
        //Begin OF Lesson Section
        private void btnNewLesson_Click(object sender, EventArgs e)
        {
            if (Flag == ButtonState.None)
            {
                Flag = ButtonState.Add;
                dgvLessons.ClearSelection();
                txtLessonName.Text = "";
                txtEnableLessons();
                btnEditLesson.Enabled = false;
                btnDeleteLesson.Enabled = false;
                btnNewLesson.ForeColor = Color.Black;
                btnNewLesson.Text = "انصراف";
            }
            else
            {
                Flag = ButtonState.None;
                txtLessonName.Text = "";
                txtFalseLessons();
                btnEditLesson.Enabled = true;
                btnDeleteLesson.Enabled = true;
                btnNewLesson.ForeColor = Color.Green;
                btnNewLesson.Text = "جدید";
            }
        }

        private void btnEditLesson_Click(object sender, EventArgs e)
        {
            if (dgvLessons.CurrentRow == null || dgvLessons.SelectedRows.Count == 0)
            {
                MessageBox.Show("ردیفی انتخاب نشده است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Flag == ButtonState.None)
            {
                Flag = ButtonState.Update;
                txtEnableLessons();
                btnDeleteLesson.Enabled = false;
                btnNewLesson.Enabled = false;
                btnEditLesson.Text = "انصراف";
            }
            else
            {
                Flag = ButtonState.None;
                txtFalseLessons();
                btnDeleteLesson.Enabled = true;
                btnNewLesson.Enabled = true;
                btnEditLesson.Text = "ویرایش";
            }
        }

        private void btnDeleteLesson_Click(object sender, EventArgs e)
        {
            string name;
            int lessonId;
            if (dgvLessons.CurrentRow == null || dgvLessons.SelectedRows.Count == 0)
            {
                MessageBox.Show("ردیفی انتخاب نشده است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }else
            {
                name = Convert.ToString(dgvLessons.CurrentRow.Cells["dgvLessonName"].Value);
                lessonId = Convert.ToInt32(dgvLessons.CurrentRow.Cells["dgvLessonId"].Value);
            }
            if (lessonsRepo.CanDelete(lessonId))
            {
                MessageBox.Show("شما مجاز به حذف این درس نیستید. ابتدا دوره های مربوطه را حذف کنید، سپس مجددا تلاش کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show($"آیا از حذف {name} اطمینان دارید؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                lessonsRepo.Delete(lessonId);
                dgvLessons.DataSource = lessonsRepo.GetAll();
            }
        }

        private void btnSaveLesson_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLessonName.Text))
            {
                MessageBox.Show("لطفا نام درس را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtLessonName.Text.Length > 50)
            {
                MessageBox.Show("شما بیش از 50 کاراکتر وارد کرده اید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Flag == ButtonState.Add)
            {
                lessonsRepo.Add(txtLessonName.Text);
                txtFalseLessons();
                txtLessonName.Text = "";
                btnDeleteLesson.Enabled = true;
                btnEditLesson.Enabled = true;
                dgvLessons.DataSource = lessonsRepo.GetAll();
                btnNewLesson.Text = "جدید";
                Flag = ButtonState.None;
            }
            else if (Flag == ButtonState.Update)
            {
                int lessonId = Convert.ToInt32(dgvLessons.CurrentRow.Cells["dgvLessonID"].Value);
                lessonsRepo.Update(lessonId, txtLessonName.Text);
                txtFalseLessons();
                txtLessonName.Text = "";
                btnDeleteLesson.Enabled = true;
                btnNewLesson.Enabled = true;
                dgvLessons.DataSource = lessonsRepo.GetAll();
                btnEditLesson.Text = "ویرایش";
                Flag = ButtonState.None;
            }

        }

        private void dgvLessons_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLessons.CurrentRow != null)
            {
                string LessonName = Convert.ToString(dgvLessons.CurrentRow.Cells["dgvLessonName"].Value);
                txtLessonName.Text = LessonName;
            }
        }
        //End Of Lessons Section
        //Begin Of ClassesSection
        private void btnNewClass_Click(object sender, EventArgs e)
        {
            if (Flag == ButtonState.None)
            {
                Flag = ButtonState.Add;
                dgvClassses.ClearSelection();
                EmptytxtClasses();
                txtEnableClasses();
                btnEditClass.Enabled = false;
                btnDeleteClass.Enabled = false;
                btnNewClass.ForeColor = Color.Black;
                btnNewClass.Text = "انصراف";
            }
            else
            {
                Flag = ButtonState.None;
                EmptytxtClasses();
                txtFalseClasses();
                btnEditClass.Enabled = true;
                btnDeleteClass.Enabled = true;
                btnNewClass.ForeColor = Color.Green;
                btnNewClass.Text = "جدید";
            }
        }

        private void btnEditClass_Click(object sender, EventArgs e)
        {
            if (dgvClassses.CurrentRow == null || dgvClassses.SelectedRows.Count == 0)
            {
                MessageBox.Show("ردیفی انتخاب نشده است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Flag == ButtonState.None)
            {
                Flag = ButtonState.Update;
                txtEnableClasses();
                btnDeleteClass.Enabled = false;
                btnNewClass.Enabled = false;
                btnEditClass.Text = "انصراف";
            }
            else
            {
                Flag = ButtonState.None;
                txtFalseClasses();
                btnNewClass.Enabled = true;
                btnDeleteClass.Enabled = true;
                btnEditClass.Text = "ویرایش";
            }
        }

        private void btnDeleteClass_Click(object sender, EventArgs e)
        {
            string name = Convert.ToString(dgvClassses.CurrentRow.Cells["dgvClassName"].Value);
            int classId = Convert.ToInt32(dgvClassses.CurrentRow.Cells["dgvClassId"].Value);
            if (dgvClassses.CurrentRow == null || dgvClassses.SelectedRows.Count == 0)
            {
                MessageBox.Show("ردیفی انتخاب نشده است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (classesRepo.CanDelete(classId))
            {
                MessageBox.Show("شما مجاز به حذف این کلاس نیستید. ابتدا جلسات مربوطه را حذف کنید، سپس مجددا تلاش کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show($"آیا از حذف {name} اطمینان دارید؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                classesRepo.Delete(classId);
                dgvClassses.DataSource = classesRepo.GetAll();
            }
        }

        private void btnSaveClass_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtClassName.Text))
            {
                MessageBox.Show("لطفا نام کلاس را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtClassName.Text.Length > 50)
            {
                MessageBox.Show("شما بیش از 50 کاراکتر وارد کرده اید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Flag == ButtonState.Add)
            {

                classesRepo.Add(txtClassName.Text, Convert.ToByte(txtClassCapacity.Text));
                txtFalseClasses();
                EmptytxtClasses();
                dgvClassses.DataSource = classesRepo.GetAll();
                btnEditClass.Enabled = true;
                btnDeleteClass.Enabled = true;
                btnNewClass.Text = "جدید";
                Flag = ButtonState.None;
            }
            else if (Flag == ButtonState.Update)
            {
                int ClassId = Convert.ToInt32(dgvClassses.CurrentRow.Cells["dgvClassId"].Value);
                classesRepo.Update(ClassId, txtClassName.Text, Convert.ToByte(txtClassCapacity.Text));
                txtFalseClasses();
                EmptytxtClasses();
                btnDeleteClass.Enabled = true;
                btnNewClass.Enabled = true;
                dgvClassses.DataSource = classesRepo.GetAll();
                btnEditClass.Text = "ویرایش";
                Flag = ButtonState.None;
            }

        }

        private void btnNewTerm_Click(object sender, EventArgs e)
        {
            if (Flag == ButtonState.None)
            {
                Flag = ButtonState.Add;
                dgvTerms.ClearSelection();
                EmptytxtTerms();
                txtEnableTerms();
                btnEditTerm.Enabled = false;
                btnDeleteTerm.Enabled = false;
                btnNewTerm.ForeColor = Color.Black;
                btnNewTerm.Text = "انصراف";
            }
            else
            {
                Flag = ButtonState.None;
                EmptytxtTerms();
                txtFalseTerms();
                btnEditTerm.Enabled = true;
                btnDeleteTerm.Enabled = true;
                btnNewTerm.ForeColor = Color.Green;
                dgvTerms.ClearSelection();
                btnNewTerm.Text = "جدید";
            }

        }

        private void btnEditTerm_Click(object sender, EventArgs e)
        {
            if (dgvTerms.CurrentRow == null || dgvTerms.SelectedRows.Count == 0)
            {
                MessageBox.Show("ردیفی انتخاب نشده است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Flag == ButtonState.None)
            {
                Flag = ButtonState.Update;
                txtEnableTerms();
                btnDeleteTerm.Enabled = false;
                btnNewTerm.Enabled = false;
                btnEditTerm.ForeColor = Color.Black;
                btnEditTerm.Text = "انصراف";
            }
            else
            {
                Flag = ButtonState.None;
                txtFalseTerms();
                btnNewTerm.Enabled = true;
                btnDeleteTerm.Enabled = true;
                btnEditTerm.ForeColor = Color.Green;
                btnEditTerm.Text = "ویرایش";
            }
        }

        private void btnDeleteTerm_Click(object sender, EventArgs e)
        {
            string name = Convert.ToString(dgvTerms.CurrentRow.Cells["dgvTermTitle"].Value);
            int termId = Convert.ToInt32(dgvTerms.CurrentRow.Cells["dgvTermId"].Value);
            if (dgvTerms.CurrentRow == null || dgvTerms.SelectedRows.Count == 0)
            {
                MessageBox.Show("ردیفی انتخاب نشده است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(termsRepo.CanDelete(termId))
            {
                MessageBox.Show("شما مجاز به حذف این ترم نیستید. ابتدا دوره های مربوطه را حذف کنید، سپس مجددا تلاش کنید","خطا", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show($"آیا از حذف {name} اطمینان دارید؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                termsRepo.Delete(termId);
                dgvTerms.DataSource = termsRepo.GetAll();
            }
        }

        private void btnSaveTerm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTermTitle.Text))
            {
                MessageBox.Show("لطفا نام ترم را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtTermTitle.Text.Length > 50)
            {
                MessageBox.Show("شما بیش از 50 کاراکتر وارد کرده اید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtTermStartDate.Text))
            {
                MessageBox.Show("لطفا تاریخ شروع ترم را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtTermStartDate.Text.Length != 8)
            {
                MessageBox.Show("طول تاریخ وارد شده میبایست 8 کاراکتر باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtTermEndDate.Text))
            {
                MessageBox.Show("لطفا تاریخ پایان ترم را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtTermEndDate.Text.Length != 8)
            {
                MessageBox.Show("طول تاریخ وارد شده میبایست 8 کاراکتر باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Flag == ButtonState.Add)
            {

                termsRepo.Add(txtTermTitle.Text, Convert.ToInt32(txtTermStartDate.Text), Convert.ToInt32(txtTermEndDate.Text));
                txtFalseTerms();
                txtTermTitle.Text = "";
                dgvTerms.DataSource = termsRepo.GetAll();
                btnEditTerm.Enabled = true;
                btnDeleteTerm.Enabled = true;
                btnNewTerm.Text = "جدید";
                Flag = ButtonState.None;
            }
            else if (Flag == ButtonState.Update)
            {
                int termId = Convert.ToInt32(dgvTerms.CurrentRow.Cells["dgvTermID"].Value);
                termsRepo.Update(termId, txtTermTitle.Text, Convert.ToInt32(txtTermStartDate.Text), Convert.ToInt32(txtTermEndDate.Text));
                txtFalseTerms();
                txtTermTitle.Text = "";
                btnDeleteTerm.Enabled = true;
                btnNewTerm.Enabled = true;
                dgvTerms.DataSource = termsRepo.GetAll();
                btnEditTerm.Text = "ویرایش";
                Flag = ButtonState.None;
            }

        }

        private void dgvTerms_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTerms.CurrentRow != null)
            {
                string TermTitle = Convert.ToString(dgvTerms.CurrentRow.Cells["dgvTermTitle"].Value);
                string TermStartDate = Convert.ToString(dgvTerms.CurrentRow.Cells["dgvTermStartDate"].Value);
                string TermEndDate = Convert.ToString(dgvTerms.CurrentRow.Cells["dgvTermEndDate"].Value);
                txtTermTitle.Text = TermTitle;
                txtTermStartDate.Text = TermStartDate;
                txtTermEndDate.Text = TermEndDate;
            }
        }

        private void dgvClassses_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvClassses.CurrentRow != null)
            {
                string ClassName = Convert.ToString(dgvClassses.CurrentRow.Cells["dgvClassName"].Value);
                string ClassCapacity = Convert.ToString(dgvClassses.CurrentRow.Cells["dgvClassCapacity"].Value);
                txtClassName.Text = ClassName;
                txtClassCapacity.Text = ClassCapacity;
            }
        }

        private void btnNewSessionTime_Click(object sender, EventArgs e)
        {
            if (Flag == ButtonState.None)
            {
                Flag = ButtonState.Add;
                dgvSessionTime.ClearSelection();
                EmptytxtSessionTime();
                txtEnableSessionTime();
                btnEditSessionTime.Enabled = false;
                btnDeleteSessionTime.Enabled = false;
                btnNewSessionTime.ForeColor = Color.Black;
                btnNewSessionTime.Text = "انصراف";
            }
            else
            {
                Flag = ButtonState.None;
                EmptytxtSessionTime();
                txtFalseSessionTime();
                btnEditSessionTime.Enabled = true;
                btnDeleteSessionTime.Enabled = true;
                btnNewSessionTime.ForeColor = Color.Green;
                btnNewSessionTime.Text = "جدید";
            }
        }
        private void btnEditSessionTime_Click(object sender, EventArgs e)
        {

            if (dgvSessionTime.CurrentRow == null || dgvSessionTime.SelectedRows.Count == 0)
            {
                MessageBox.Show("ردیفی انتخاب نشده است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Flag == ButtonState.None)
            {
                Flag = ButtonState.Update;
                LessonsTab.Enabled = false;
                txtEnableSessionTime();
                btnDeleteSessionTime.Enabled = false;
                btnNewSessionTime.Enabled = false;
                btnEditSessionTime.Text = "انصراف";
            }
            else
            {
                Flag = ButtonState.None;
                txtFalseSessionTime();
                btnNewSessionTime.Enabled = true;
                btnDeleteSessionTime.Enabled = true;
                btnEditSessionTime.Text = "ویرایش";
            }
        }

        private void btnDeleteSessionTime_Click(object sender, EventArgs e)
        {
            string StartTime;
            string EndTime;
            int sessionTimeId;
            if (dgvSessionTime.CurrentRow == null || dgvSessionTime.SelectedRows.Count == 0)
            {
                MessageBox.Show("ردیفی انتخاب نشده است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                StartTime = Convert.ToString(dgvSessionTime.CurrentRow.Cells["dgvSessionStartTime"].Value);
                EndTime = Convert.ToString(dgvSessionTime.CurrentRow.Cells["dgvSessionEndTime"].Value);
                sessionTimeId = Convert.ToInt32(dgvSessionTime.CurrentRow.Cells["dgvSessiontimeID"].Value);
            }
            if (sessionsTimeRepo.CanDelete(sessionTimeId))
            {
                MessageBox.Show("شما مجاز به حذف این ساعت نمیباشید. ابتدا جلسه مربوطه را حذف کنید، سپس مجددا تلاش کنید","خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            if (MessageBox.Show($"آیا از حذف {EndTime} - {StartTime} اطمینان دارید؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                sessionsTimeRepo.Delete(sessionTimeId);
                dgvSessionTime.DataSource = sessionsTimeRepo.GetAll();
            }
        }

        private void btnSaveSessiontime_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSessionStartTime.Text))
            {
                MessageBox.Show("لطفا زمان شروع جلسه را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtSessionEndTime.Text.Length != 5)
            {
                MessageBox.Show("طول تاریخ وارد شده میبایست 5 کاراکتر باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtSessionEndTime.Text))
            {
                MessageBox.Show("لطفا زمان پایان جلسه را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtSessionEndTime.Text.Length != 5)
            {
                MessageBox.Show("طول تاریخ وارد شده میبایست 5 کاراکتر باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Flag == ButtonState.Add)
            {
                sessionsTimeRepo.Add(txtSessionStartTime.Text, txtSessionEndTime.Text);
                txtFalseSessionTime();
                txtTermTitle.Text = "";
                dgvSessionTime.DataSource = sessionsTimeRepo.GetAll();
                btnEditSessionTime.Enabled = true;
                btnDeleteSessionTime.Enabled = true;
                btnNewSessionTime.Text = "جدید";
                Flag = ButtonState.None;
            }
            else if (Flag == ButtonState.Update)
            {
                int SessionTimeId = Convert.ToInt32(dgvSessionTime.CurrentRow.Cells["dgvSessiontimeID"].Value);
                sessionsTimeRepo.Update(SessionTimeId, txtSessionStartTime.Text, txtSessionEndTime.Text);
                txtSessionEndTime.Enabled = false;
                txtFalseSessionTime();
                EmptytxtSessionTime();
                btnDeleteSessionTime.Enabled = true;
                btnNewSessionTime.Enabled = true;
                dgvSessionTime.DataSource = sessionsTimeRepo.GetAll();
                btnEditSessionTime.Text = "ویرایش";
                Flag = ButtonState.None;
            }

        }

        private void dgvSessionTime_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSessionTime.CurrentRow != null)
            {
                string StartTime = Convert.ToString(dgvSessionTime.CurrentRow.Cells["dgvSessionStartTime"].Value);
                string EndTime = Convert.ToString(dgvSessionTime.CurrentRow.Cells["dgvSessionEndTime"].Value);
                txtSessionStartTime.Text = StartTime;
                txtSessionEndTime.Text = EndTime;
            }
        }

        private void tabCourseManagement_Click(object sender, EventArgs e)
        {
            frmCourseManagement frm = new frmCourseManagement();
            frm.Show();
        }

        private void tabSessionManagement_Click(object sender, EventArgs e)
        {
            frmSessionManagement frm = new frmSessionManagement();
            frm.Show();
        }

        private void tabRegister_Click(object sender, EventArgs e)
        {
            frmRegister frm = new frmRegister();
            frm.Show();
        }

        private void txtClassCapacity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void CoursesReportTab_Click(object sender, EventArgs e)
        {
            frmCoursesReport frm = new frmCoursesReport();
            frm.Show();
        }

        private void CoursesReportTab_Click_1(object sender, EventArgs e)
        {
            frmCoursesReport frm = new frmCoursesReport();
            frm.Show();
        }

        private void TermsReportTab_Click(object sender, EventArgs e)
        {
            frmTermsReport frm = new frmTermsReport();
            frm.Show();
        }

        private void SelectionTabs_Selecting(object sender, TabControlCancelEventArgs e)
        {

        }
        private void EnableAllTabs()
        {
            foreach (TabPage tab in SelectionTabs.TabPages)
            {
                tab.Enabled = true;
            }
        }
        private void DisableOtherTabs()
        {
            foreach (TabPage tab in SelectionTabs.TabPages)
            {
                if (SelectionTabs.SelectedTab != tab)
                    tab.Enabled = false;
            }
        }
    }
}

