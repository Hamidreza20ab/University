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
    public partial class frmTermsReport : Form
    { CoursesRepository CoursesRepo;
        TermsRepository TermsRepo;
        public frmTermsReport()
        {
            TermsRepo = new TermsRepository();
            CoursesRepo = new CoursesRepository();
            InitializeComponent();
        }

        private void frmTermsReport_Load(object sender, EventArgs e)
        {
            dgvReport.AutoGenerateColumns = false;
            comboTermTitle.DataSource = TermsRepo.GetTerm();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int? TermId = null;
            if (comboTermTitle.SelectedValue != DBNull.Value)
                TermId = Convert.ToInt32(comboTermTitle.SelectedValue);
            dgvReport.DataSource = CoursesRepo.SearchTerms(TermId);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            ReportViewer reportViewer = new ReportViewer("TermsReport");
            reportViewer.TermID = Convert.ToInt32(comboTermTitle.SelectedValue);

            reportViewer.Show();
        }
    }
}
