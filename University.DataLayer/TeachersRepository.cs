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
    public class TeachersRepository
    {
        private SqlConnection con;
        public TeachersRepository()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString);

        }
        public void Add(string FullName, string NationalCode, bool Gender, string FatherName, string PhoneNumber, int BirthDate, string Address)
        {
            con.Open();
            string qry = "INSERT INTO Teachers (FullName,NationalCode,Gender,FatherName,PhoneNumber,BirthDate,Address)VALUES (@FullName,@NationalCode,@Gender,@FatherName,@PhoneNumber,@BirthDate,@Address)";
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
                    cmd.Parameters.AddWithValue("@Gender", Gender);
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
            string qry = "DELETE FROM dbo.Teachers WHERE ID = @id";
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
            string qry = @"SELECT ID, FullName, NationalCode, FatherName, PhoneNumber, BirthDate, Address,Gender,
                         CASE
                         WHEN Gender = 1 THEN N'مرد'
                         WHEN Gender = 0 THEN N'زن'
                         END AS GenderPrint
                         FROM Teachers";
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
        public DataTable GetTeachers()
        {
            DataTable dt = new DataTable();
            con.Open();
            string qry = @" Select 0 As ID,N'' AS FullName
                            UNION
                            Select ID,FullName From Teachers";

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
        public void Update(int id, string FullName, string NationalCode, bool Gender, string FatherName, string PhoneNumber, int BirthDate, string Address)
        {
            con.Open();
            string qry = "Update Teachers Set FullName=@FullName, NationalCode=@NationalCode,Gender=@Gender ,FatherName=@FatherName, PhoneNumber=@PhoneNumber, BirthDate=@BirthDate, Address=@Address Where ID = @id";

            try
            {
                using (SqlCommand cmd = new SqlCommand(qry, con))
                {
                    cmd.Parameters.AddWithValue("FullName", FullName);
                    cmd.Parameters.AddWithValue("NationalCode", NationalCode);
                    cmd.Parameters.AddWithValue("FatherName", FatherName);
                    cmd.Parameters.AddWithValue("PhoneNumber", PhoneNumber);
                    cmd.Parameters.AddWithValue("BirthDate", BirthDate);
                    cmd.Parameters.AddWithValue("Address", Address);
                    cmd.Parameters.AddWithValue("ID", id);
                    cmd.Parameters.AddWithValue("Gender", Gender);
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
        public bool CanDelete(int TeacherId)
        {
            bool TeacherExists = false;
            try
            {
                con.Open();
                string qry = @"
                    SELECT COUNT(dbo.Teachers.ID) AS CountTeacher
                    FROM dbo.Teachers
                    WHERE dbo.Teachers.ID = @TeacherId";
                using (SqlCommand cmd = new SqlCommand(qry, con))
                {
                    cmd.Parameters.AddWithValue("@TeacherId", TeacherId);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    TeacherExists = count != 0;
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
            return TeacherExists;
        }

    }
}
