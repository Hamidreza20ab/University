using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace University
{
    public partial class ReportViewer : Form
    {
        private string ReportName;
        public int TermID;
        public int TeacherID;
        public int LessonID;
        public ReportViewer(string reportName)
        {
            ReportName = reportName;

            InitializeComponent();

        }

        private void ReportViewer_Load(object sender, EventArgs e)
        { PersianCalendar pc = new PersianCalendar();
            string DayOfMonth = Convert.ToString(pc.GetDayOfMonth(DateTime.Now));
            string Month = Convert.ToString(pc.GetMonth(DateTime.Now));
            string Year = Convert.ToString(pc.GetYear(DateTime.Now));
            string Hour = Convert.ToString(pc.GetHour(DateTime.Now));
            string Minute = Convert.ToString(pc.GetMinute(DateTime.Now));
            string Second = Convert.ToString(pc.GetSecond(DateTime.Now));
            string PersianDate = $"{Year} / {Month} / {DayOfMonth}";
            string PersianTime = $"{Hour} : {Minute} : {Second}";
            switch (ReportName)
            {
                case "CourseReport":
                    { 
                        ReportDocument reportDocument = new ReportDocument();
                        reportDocument.Load("E:\\Hamid\\Program Training\\University\\University\\Reports\\CourseReport.rpt");
                        reportDocument.SetParameterValue("@TermID",TermID);
                        reportDocument.SetParameterValue("@LessonID",LessonID);
                        reportDocument.SetParameterValue("@TeacherID",TeacherID);
                        reportDocument.SetParameterValue("@PersianDate",PersianDate);
                        reportDocument.SetParameterValue("@PersianTime",PersianTime);
                        ConnectionInfo connectionInfo = new ConnectionInfo();

                        connectionInfo.ServerName = "DEV-ABDI\\INS1";
                        connectionInfo.DatabaseName = "University";
                        connectionInfo.UserID = "sa";
                        connectionInfo.Password = "";
                        
                        foreach (Table table in reportDocument.Database.Tables)
                        {
                            TableLogOnInfo tableLogOnInfo = table.LogOnInfo;
                            tableLogOnInfo.ConnectionInfo = connectionInfo;
                            table.ApplyLogOnInfo(tableLogOnInfo);
                        }
                        
                        crystalReportViewer.ReportSource = reportDocument;
                        break;
                    }
                case "TermsReport":
                    {
                        ReportDocument reportDocument = new ReportDocument();
                        reportDocument.Load("E:\\Hamid\\Program Training\\University\\University\\Reports\\TermsReport.rpt");
                        reportDocument.SetParameterValue("@TermID", TermID);
                        reportDocument.SetParameterValue("@PersianDate", PersianDate);
                        reportDocument.SetParameterValue("@PersianTime", PersianTime);
                        ConnectionInfo connectionInfo = new ConnectionInfo();

                        connectionInfo.ServerName = "DEV-ABDI\\INS1";
                        connectionInfo.DatabaseName = "University";
                        connectionInfo.UserID = "sa";
                        connectionInfo.Password = "";

                        foreach (Table table in reportDocument.Database.Tables)
                        {
                            TableLogOnInfo tableLogOnInfo = table.LogOnInfo;
                            tableLogOnInfo.ConnectionInfo = connectionInfo;
                            table.ApplyLogOnInfo(tableLogOnInfo);
                        }

                        crystalReportViewer.ReportSource = reportDocument;
                    }
                    break;
            }


        }
    }
}
