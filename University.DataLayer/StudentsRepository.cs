using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace University.DataLayer
{
    public class StudentsRepository
    {
        private SqlConnection con;
        public StudentsRepository()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString);

        }
        public void Add(string FullName, string NationalCode, string FatherName, string PhoneNumber, int? BirthDate, string Address)
        {
            con.Open();
            string qry = "INSERT INTO STUDENTS (FullName,NationalCode,FatherName,PhoneNumber,BirthDate,Address)VALUES (@FullName,@NationalCode,@FatherName,@PhoneNumber,@BirthDate,@Address)";
            try
            {
                using (SqlCommand cmd = new SqlCommand(qry, con))
                {
                    cmd.Parameters.AddWithValue("@FullName", FullName);
                    cmd.Parameters.AddWithValue("@NationalCode", NationalCode);
                    cmd.Parameters.AddWithValue("@FatherName", FatherName);
                    cmd.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
                    cmd.Parameters.AddWithValue("@BirthDate", BirthDate);
                    cmd.Parameters.AddWithValue("@Address", Address);
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
            string qry = "DELETE FROM dbo.Students WHERE ID = @id";
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
            finally { con.Close(); }

        }
        public DataTable GetAll()
        {
            DataTable dt = new DataTable();

            con.Open();
            string qry = "SELECT * From Students";
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
        public DataTable GetStudents(int CourseID)
        {
            DataTable dt = new DataTable();

            con.Open();
            string qry = @"SELECT s.FullName AS FullName,s.NationalCode AS	NationalCode,s.PhoneNumber AS PhoneNumber,s.BirthDate AS BirthDate,r.StudentID AS StudentID,r.CourseID AS CourseID,r.ID AS RegisterID
                         FROM dbo.Register r INNER JOIN dbo.Courses c ON r.CourseID = c.ID
                         INNER JOIN dbo.Students s ON s.ID = r.StudentID
                         WHERE c.ID = @CourseID";
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
        public DataTable GetStudentName()
        {
            DataTable dt = new DataTable();
            con.Open();
            string qry = "Select Distinct ID, FullName From Students";

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
        public void Update(int id, string FullName, string NationalCode, string FatherName, string PhoneNumber, int? BirthDate, string Address)
        {
            con.Open();
            string qry = "Update Students Set FullName=@FullName, NationalCode=@NationalCode, FatherName=@FatherName, PhoneNumber=@PhoneNumber, BirthDate=@BirthDate, Address=@Address Where ID = @id";

            try
            {
                using (SqlCommand cmd = new SqlCommand(qry, con))
                {
                    cmd.Parameters.AddWithValue("FullName", FullName);
                    cmd.Parameters.AddWithValue("NationalCode", NationalCode);
                    cmd.Parameters.AddWithValue("FatherName", FatherName);
                    cmd.Parameters.AddWithValue("PhoneNumber", PhoneNumber);
                    if (BirthDate == null)
                    {
                        cmd.Parameters.AddWithValue("BirthDate", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("BirthDate", BirthDate);
                    }

                    cmd.Parameters.AddWithValue("Address", Address);
                    cmd.Parameters.AddWithValue("ID", id);
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
        public bool CanDelete(int StudentID)
        {
            bool StudentExists = false;
            try
            {
                con.Open();
                string qry = @"
                    SELECT COUNT(Students.ID) AS StudentCount
                    FROM dbo.Students
                    WHERE dbo.Students.ID = @StudentID";
                using (SqlCommand cmd = new SqlCommand(qry, con))
                {
                    cmd.Parameters.AddWithValue("@StudentID", StudentID);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    StudentExists = count != 0;
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
            return StudentExists;
        }
    }
}
