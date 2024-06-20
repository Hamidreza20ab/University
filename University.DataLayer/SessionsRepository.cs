using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University.DataLayer
{
    public class SessionsRepository
    {
        private SqlConnection con;
        public SessionsRepository()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString);

        }
        public void Add(int CourseID, int ClassID, int DayOfWeek, int SessionTimeID)
        {
            con.Open();
            string qry = "INSERT INTO Sessions (CourseID,ClassID,DayOfWeek,SessionTimeID) VALUES(@CourseID,@ClassID,@DayOfWeek,@SessionTimeID)";
            try
            {
                using (SqlCommand cmd = new SqlCommand(qry, con))
                {
                    cmd.Parameters.AddWithValue("@CourseID", CourseID);
                    cmd.Parameters.AddWithValue("@ClassID", ClassID);
                    cmd.Parameters.AddWithValue("@DayOfWeek", DayOfWeek);
                    cmd.Parameters.AddWithValue("@SessionTimeID", SessionTimeID);
                    cmd.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }


        }

        public void Delete(int id)
        {
            con.Open();
            string qry = "DELETE FROM Sessions WHERE ID = @id";
            try
            {
                using (SqlCommand cmd = new SqlCommand(qry, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }
        public DataTable GetAll(int CourseID)
        {
            DataTable dt = new DataTable();

            con.Open();
            string qry = @"SELECT StartTime +N'تا'+EndTime AS ClassTime,Classes.Name AS ClassName,DayOfWeek,SessionTimeID,ClassID,Sessions.ID,
                           CASE 
                           WHEN DayOfWeek=1 THEN N'شنبه'
                           WHEN DayOfWeek=2 THEN N'یک شنبه'
                           WHEN DayOfWeek=3 THEN N'دو شنبه'
                           WHEN DayOfWeek=4 THEN N'سه شنبه'
                           WHEN DayOfWeek=5 THEN N'چهارشنبه'
                           WHEN DayOfWeek=6 THEN N'پنج شنبه'
                           WHEN DayOfWeek=7 THEN N'جمعه'
                           END AS DayOfWeekstr
                           FROM dbo.Sessions INNER JOIN dbo.SessionsTime ON Sessions.SessionTimeID = dbo.SessionsTime.ID
                           INNER JOIN dbo.Classes ON dbo.Sessions.ClassID = Classes.ID Where CourseID=@CourseID";
            try
            {
                using (SqlCommand cmd = new SqlCommand(qry, con))
                {
                    cmd.Parameters.AddWithValue("@CourseID", CourseID);
                    dt.Load(cmd.ExecuteReader());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();

            }
            return dt;
        }
        public DataTable GetTime()
        {
            DataTable dt = new DataTable();
            con.Open();
            string qry = "Select StartTime + N'تا' +EndTime AS SessionTime, ID From SessionsTime";

            try
            {
                using (SqlCommand cmd = new SqlCommand(qry, con))
                {
                    dt.Load(cmd.ExecuteReader());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return dt;
        }
        
        public bool IsValidSession(int ClassIdentity, int TermIdentity, int SessionTimeIdentity)
        {
            bool SessionNotExists = false;
            try
            {
                con.Open();
                string qry = @"
                SELECT COUNT(*) AS ISValid
                FROM dbo.Sessions S INNER JOIN dbo.Courses C ON S.CourseID = c.ID
                INNER JOIN dbo.Terms T ON T.ID = C.TermID
                INNER JOIN dbo.Classes ON Classes.ID = S.ClassID
                INNER JOIN dbo.SessionsTime ON SessionsTime.ID = S.SessionTimeID
                WHERE S.ClassID = @ClassId AND S.SessionTimeID = @SessionTimeId AND C.TermID = @TermId";
                using (SqlCommand cmd = new SqlCommand(qry, con))
                {
                    cmd.Parameters.AddWithValue("@ClassId", ClassIdentity);
                    cmd.Parameters.AddWithValue("@TermId", TermIdentity);
                    cmd.Parameters.AddWithValue("@SessionTimeId", SessionTimeIdentity);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    SessionNotExists = count == 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                con.Close();
            }
            return SessionNotExists;
        }
        public DataTable GetClass()
        {
            DataTable dt = new DataTable();
            con.Open();
            string qry = "Select Name, ID From Classes";

            try
            {
                using (SqlCommand cmd = new SqlCommand(qry, con))
                {
                    dt.Load(cmd.ExecuteReader());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return dt;
        }
        public void Update(int SessionID,int CourseID, int ClassID, int DayOfWeek, int SessionTimeID)
        {
            con.Open();
            string qry = "Update Sessions Set CourseID=@CourseID, ClassID=@ClassID, DayOfWeek=@DayOfWeek, SessionTimeID=@SessionTimeID Where ID=@SessionID";

            try
            {
                using (SqlCommand cmd = new SqlCommand(qry, con))
                {
                    cmd.Parameters.AddWithValue("@CourseID", CourseID);
                    cmd.Parameters.AddWithValue("@ClassID", ClassID);
                    cmd.Parameters.AddWithValue("@DayOfWeek", DayOfWeek);
                    cmd.Parameters.AddWithValue("@SessionTimeID", SessionTimeID);
                    cmd.Parameters.AddWithValue("@SessionID", SessionID);
                    cmd.ExecuteNonQuery();
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }



        }
    }
}
