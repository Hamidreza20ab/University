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
    public class LessonsRepository
    {
        private SqlConnection con;
        public LessonsRepository()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString);

        }
        public void Add(string LessonName)
        {
            con.Open();
            string qry = "INSERT INTO LESSONS (Name) Values(@Name)";
            try
            {
                using (SqlCommand cmd = new SqlCommand(qry, con))
                {
                    cmd.Parameters.AddWithValue("@Name", LessonName);
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
            string qry = "Delete From Lessons Where ID = @id";
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
        public DataTable GetAll()
        {
            DataTable dt = new DataTable();
            con.Open();
            string qry = "Select * From Lessons";
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
        public void Update(int id, string Name)
        {
            con.Open();
            string qry = "Update Lessons SET Name=@Name Where ID=@id";
            try
            {
                using (SqlCommand cmd = new SqlCommand(qry, con))
                {
                    cmd.Parameters.AddWithValue("@Name", Name);
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
        public DataTable GetLessons()
        {
            DataTable dt = new DataTable();
            con.Open();
            string qry = @"Select 0 As ID,N'' AS Name
                            UNION
                            Select ID,Name From Lessons";

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
        public bool CanDelete(int LessonID)
        {
            bool LessonExists = false;
            try
            {
                con.Open();
                string qry = @"
                    SELECT COUNT(Lessons.ID) AS CountLessons
                    FROM dbo.Lessons
                    WHERE Lessons.ID=@LessonID";
                using (SqlCommand cmd = new SqlCommand(qry, con))
                {
                    cmd.Parameters.AddWithValue("@LessonID", LessonID);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    LessonExists = count != 0;
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
            return LessonExists;
        }
    }
}