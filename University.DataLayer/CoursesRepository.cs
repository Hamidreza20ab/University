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
   public class CoursesRepository
    {

        private SqlConnection con;
        public CoursesRepository()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString);

        }
        public void Add(int TermID, int LessonID, int TeacherID, byte CourseCapacity)
        {
            con.Open();
            string qry = "INSERT INTO Courses (TermID,LessonID,TeacherID,CourseCapacity) Values(@TermID,@LessonID,@TeacherID,@CourseCapacity)";
            try
            {
                using (SqlCommand cmd = new SqlCommand(qry, con))
                {
                    cmd.Parameters.AddWithValue("@TermID", TermID);
                    cmd.Parameters.AddWithValue("@LessonID", LessonID);
                    cmd.Parameters.AddWithValue("@TeacherID", TeacherID);
                    cmd.Parameters.AddWithValue("@CourseCapacity", CourseCapacity);
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
            string qry = "Delete From Courses Where ID = @id";
            try
            {
                using (SqlCommand cmd = new SqlCommand(qry, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }
        public DataTable Search(int? TermId, int? LessonId, int? TeacherId)
        {
            DataTable dt = new DataTable();
            con.Open();
            string qry = @"EXEC CourseReport @TermId,@LessonId,@TeacherId";

            try
            {
                using (SqlCommand cmd = new SqlCommand(qry, con))
                {
                    if (TermId == null)
                        cmd.Parameters.AddWithValue("@TermId", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@TermId", TermId);
                    if (LessonId == null)
                        cmd.Parameters.AddWithValue("@LessonId", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@LessonId", LessonId);
                    if (TeacherId == null)
                        cmd.Parameters.AddWithValue("@TeacherId", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@TeacherId", TeacherId);

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
        public DataTable SearchTerms(int? TermId)
        {
            DataTable dt = new DataTable();
            con.Open();
            string qry = @"EXEC TermsReport @TermId";

            try
            {
                using (SqlCommand cmd = new SqlCommand(qry, con))
                {
                    if (TermId == null)
                        cmd.Parameters.AddWithValue("@TermId", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@TermId", TermId);
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
        public DataTable GetAll()
        {
            DataTable dt = new DataTable();
            con.Open();
            string qry = @"SELECT c.ID AS CourseID,t.TermTitle AS TermTitle,l.Name AS LessonName,Teachers.[FullName] AS TeachersName,c.CourseCapacity AS CourseCapacity,c.TermID AS TermId
                            FROM dbo.Courses c INNER JOIN dbo.Terms t ON c.TermID=t.ID
                            INNER JOIN dbo.Lessons l ON c.LessonID=l.ID 
                            INNER JOIN dbo.Teachers  ON c.TeacherID=dbo.Teachers.ID
";
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
        public DataTable GetTeacher()
        {
            DataTable dt = new DataTable();
            con.Open();
            string qry = "Select ID, FullName From Teachers";

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
        public DataTable GetLesson()
        {
            DataTable dt = new DataTable();
            con.Open();
            string qry = "Select ID, Name From Lessons";

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
        public DataTable GetTerm()
        {
            DataTable dt = new DataTable();
            con.Open();
            string qry = "Select ID, TermTitle From Terms";

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
        public bool InsertFilter(int TermID, int LessonID, int TeacherID, byte CourseCapacity)
        {
            bool courseExists = false;
            try
            {
                con.Open();
                string qry = "SELECT COUNT(*) AS Count FROM Courses WHERE TermID = @TermID AND LessonID = @LessonID AND TeacherID = @TeacherID AND CourseCapacity = @CourseCapacity";
                using (SqlCommand cmd = new SqlCommand(qry, con))
                {
                    cmd.Parameters.AddWithValue("@TermID", TermID);
                    cmd.Parameters.AddWithValue("@LessonID", LessonID);
                    cmd.Parameters.AddWithValue("@TeacherID", TeacherID);
                    cmd.Parameters.AddWithValue("@CourseCapacity", CourseCapacity);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    courseExists = count == 0;
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
            return courseExists;
        }
        public void Update(int CourseID,int TermID, int LessonID, int TeacherID, byte CourseCapacity)
        {
            con.Open();
            string qry = "Update Courses SET TermID=@TermID, LessonID=@LessonID, TeacherID=@TeacherID, CourseCapacity=@CourseCapacity Where ID=@CourseID";
            try
            {
                using (SqlCommand cmd = new SqlCommand(qry, con))
                {
                    cmd.Parameters.AddWithValue("@CourseID", CourseID);
                    cmd.Parameters.AddWithValue("@TermID", TermID);
                    cmd.Parameters.AddWithValue("@LessonID", LessonID);
                    cmd.Parameters.AddWithValue("@TeacherID", TeacherID);
                    cmd.Parameters.AddWithValue("@CourseCapacity", CourseCapacity);
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
        public bool CanDelete(int CourseID)
        {
            bool CourseExists = false;
            try
            {
                con.Open();
                string qry = @"
                    SELECT COUNT(CourseID) AS CourseCount
                    FROM dbo.Register
                    WHERE CourseID =@CourseID";
                using (SqlCommand cmd = new SqlCommand(qry, con))
                {
                    cmd.Parameters.AddWithValue("@CourseID", CourseID);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    CourseExists = count != 0;
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
            return CourseExists;
        }
    }
}
