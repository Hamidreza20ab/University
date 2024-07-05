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
    public partial class frmSessionManagement : Form
    {
        CoursesRepository courseRepo;
        SessionsRepository sessionsRepo;
        enum ButtonState
        {
            None = 1, Add = 2, Update = 3
        }
        ButtonState Flag;
        int CourseId;
        public frmSessionManagement()
        {
            Flag = ButtonState.None;
            sessionsRepo = new SessionsRepository();
            courseRepo = new CoursesRepository();
            InitializeComponent();
        }

        private void frmSessionManagement_Load(object sender, EventArgs e)
        {
            dgvSessions.AutoGenerateColumns = false;
            dgvCourses.AutoGenerateColumns = false;
            dgvCourses.DataSource = courseRepo.GetAll();
            dgvSessions.DataSource = sessionsRepo.GetAll(CourseId);
            comboSessionTime.DataSource = sessionsRepo.GetTime();
            comboClass.DataSource = sessionsRepo.GetClass();
        }

        private void dgvCourses_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCourses.CurrentRow != null)
            {
                CourseId = (int)dgvCourses.CurrentRow.Cells["dgvCourseID"].Value;
                dgvSessions.DataSource = sessionsRepo.GetAll(CourseId);
            }
        }
        private void DisableTxt()
        {
            dgvSessions.Enabled = true;
            dgvCourses.Enabled = true;
            comboClass.Enabled = false;
            comboDayOfWeek.Enabled = false;
            comboSessionTime.Enabled = false;
            btnSaveSession.Enabled = false;
        }
        private void EnableTxt()
        {
            dgvSessions.Enabled = false;
            dgvCourses.Enabled = false;
            comboClass.Enabled = true;
            comboDayOfWeek.Enabled = true;
            comboSessionTime.Enabled = true;
            btnSaveSession.Enabled = true;
        }
        private void EmptyTxt()
        {
            comboClass.Text = "";
            comboDayOfWeek.Text = "";
            comboSessionTime.Text = "";
        }

        private void btnNewSession_Click(object sender, EventArgs e)
        {
            if (Flag == ButtonState.None)
            {
                Flag = ButtonState.Add;
                EmptyTxt();
                EnableTxt();
                btnEditSession.Enabled = false;
                btnDeleteSession.Enabled = false;
                btnNewSession.Text = "انصراف";
            }
            else
          if (Flag == ButtonState.Add)
            {
                Flag = ButtonState.None;
                EmptyTxt();
                DisableTxt();
                btnEditSession.Enabled = true;
                btnDeleteSession.Enabled = true;
                btnNewSession.Text = "جدید";
            }
        }

        private void btnEditSession_Click(object sender, EventArgs e)
        {
            if (dgvSessions.CurrentRow == null)
            {
                MessageBox.Show("ردیفی انتخاب نشده است");
                return;
            }
            if (Flag == ButtonState.None)
            {
                Flag = ButtonState.Update;
                EnableTxt();
                btnDeleteSession.Enabled = false;
                btnNewSession.Enabled = false;
                btnEditSession.Text = "انصراف";
            }
            else
             if (Flag == ButtonState.Update)
            {
                Flag = ButtonState.None;
                DisableTxt();
                btnDeleteSession.Enabled = true;
                btnNewSession.Enabled = true;
                btnEditSession.Text = "ویرایش";
            }
        }

        private void btnDeleteSession_Click(object sender, EventArgs e)
        {
            if (dgvSessions.CurrentRow == null)
            {
                MessageBox.Show("ردیفی انتخاب نشده است");
                return;
            }
            string DayOfWeek = Convert.ToString(dgvSessions.CurrentRow.Cells["dgvDayOfWeek"].Value);
            string SessionTime = Convert.ToString(dgvSessions.CurrentRow.Cells["dgvSessionTime"].Value);
            string ClassName = Convert.ToString(dgvSessions.CurrentRow.Cells["dgvClassName"].Value);
            int SessionId = Convert.ToInt32(dgvSessions.CurrentRow.Cells["dgvSessionID"].Value);

            if (MessageBox.Show($@"آیا از حذف جلسه در روز '{DayOfWeek}' در ساعت '{SessionTime}' در کلاس '{ClassName}' اطمینان دارید؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                sessionsRepo.Delete(SessionId);
                dgvSessions.DataSource = sessionsRepo.GetAll(CourseId);
            }
        }

        private void dgvSessions_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSessions.CurrentRow != null)
            {
                string ClassName = Convert.ToString(dgvSessions.CurrentRow.Cells["dgvClassName"].Value);
                string SessionTime = Convert.ToString(dgvSessions.CurrentRow.Cells["dgvSessionTime"].Value);
                int dayofweek = Convert.ToInt32(dgvSessions.CurrentRow.Cells["dgvDayOfWeekID"].Value);
                comboClass.Text = ClassName;
                comboSessionTime.Text = SessionTime;
                comboDayOfWeek.SelectedIndex = dayofweek - 1;
            }
        }

        private void btnSaveSession_Click(object sender, EventArgs e)
        {
            if (comboClass.Text == "" || comboClass.SelectedValue == null)
            {
                MessageBox.Show("لطفا نام کلاس را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboDayOfWeek.Text == "" || comboDayOfWeek.SelectedIndex==null)
            {
                MessageBox.Show("لطفا روز هفته را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboSessionTime.Text == "" || comboSessionTime.SelectedValue == null)
            {
                MessageBox.Show("لطفا زمان جلسه را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dgvCourses.CurrentRow == null || dgvCourses.SelectedRows.Count == 0) {
                MessageBox.Show("دوره ای وجود ندارد. ابتدا یک دوره تعریف کنید");
                return;
            }
            int ClassIdentity = Convert.ToInt32(comboClass.SelectedValue);
            // int DayOfWeekIdentity =Convert.ToInt32( comboDayOfWeek.SelectedIndex+1);
            int SessionTimeIdentity = Convert.ToInt32(comboSessionTime.SelectedValue);
            int TermId = Convert.ToInt32(dgvCourses.CurrentRow.Cells["dgvTermId"].Value);
            if (!sessionsRepo.IsValidSession(ClassIdentity, TermId, SessionTimeIdentity))
            {
                MessageBox.Show("کلاس در این ساعت پر است");
                return;
            }
            int CourseId = Convert.ToInt32(dgvCourses.CurrentRow.Cells["dgvCourseID"].Value);
            if (Flag == ButtonState.Add)
            {
                sessionsRepo.Add(CourseId, Convert.ToInt32(comboClass.SelectedValue), comboDayOfWeek.SelectedIndex + 1, Convert.ToInt32(comboSessionTime.SelectedValue));
                DisableTxt();
                EmptyTxt();
                dgvSessions.DataSource = sessionsRepo.GetAll(CourseId);
                string DayOfWeekName = Convert.ToString(dgvSessions.CurrentRow.Cells["dgvDayOfWeek"].Value);
                comboDayOfWeek.Text = DayOfWeekName;
                btnDeleteSession.Enabled = true;
                btnEditSession.Enabled = true;
                btnNewSession.Text = "جدید";
                Flag = ButtonState.None;
            }
            else if (Flag == ButtonState.Update)
            {
                int SessionTimeId = Convert.ToInt32(dgvSessions.CurrentRow.Cells["dgvSessionTimeID"].Value);
                int ClassId = Convert.ToInt32(dgvSessions.CurrentRow.Cells["dgvClassID"].Value);
                int SessionId = Convert.ToInt32(dgvSessions.CurrentRow.Cells["dgvSessionID"].Value);
                sessionsRepo.Update(SessionId, CourseId, ClassId, comboDayOfWeek.SelectedIndex + 1, SessionTimeId);
                EnableTxt();
                EmptyTxt();
                btnDeleteSession.Enabled = true;
                btnNewSession.Enabled = true;
                dgvSessions.DataSource = sessionsRepo.GetAll(CourseId);
                btnEditSession.Text = "ویرایش";
                Flag = ButtonState.None;
            }
        }
    }
}
