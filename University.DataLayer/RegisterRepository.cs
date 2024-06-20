using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace University.DataLayer
{
    public class RegisterRepository
    {
        private SqlConnection con;
        public RegisterRepository()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString);

        }
        public void Add(int CourseId, int StudentId)
        {
            con.Open();
            string qry = "INSERT INTO Register (CourseID,StudentID) Values(@CourseID,@StudentID)";
            try
            {
                using (SqlCommand cmd = new SqlCommand(qry, con))
                {
                    cmd.Parameters.AddWithValue("@CourseID", CourseId);
                    cmd.Parameters.AddWithValue("@StudentID", StudentId);
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
            string qry = "Delete From Register Where ID = @id";
            try
            {
                using (SqlCommand cmd = new SqlCommand(qry, con))
                {
                    cmd.Parameters.AddWithValue("ID", id);
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
        public bool IsValidRegister(int CourseID, int StudentID)
        {
            bool RegisterNotExists = false;
            try
            {
                con.Open();
                string qry = @"
                                   SELECT Count(*)
                                   FROM dbo.Register r INNER JOIN dbo.Courses c ON r.CourseID = c.ID
                                   INNER JOIN dbo.Students s ON s.ID = r.StudentID
                                   WHERE c.ID = @CourseID AND	s.ID=@StudentID";
                using (SqlCommand cmd = new SqlCommand(qry, con))
                {
                    cmd.Parameters.AddWithValue("@CourseID", CourseID);
                    cmd.Parameters.AddWithValue("@StudentID", StudentID);
                    
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    RegisterNotExists = count == 0;
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
            return RegisterNotExists;
        }
    }
}
