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
   public class ClassesRepository
    {
        private SqlConnection con;
        public ClassesRepository()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString);

        }
        public void Add(string ClassName,byte Capacity)
        {
            con.Open();
            string qry = "INSERT INTO Classes (Name,Capacity) Values(@Name,@Capacity)";
            try
            {
                using (SqlCommand cmd = new SqlCommand(qry, con))
                {
                    cmd.Parameters.AddWithValue("@Name", ClassName);
                    cmd.Parameters.AddWithValue("@Capacity", Capacity);
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
            string qry = "Delete From Classes Where ID = @id";
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
        public DataTable GetAll()
        {
            DataTable dt = new DataTable();
            con.Open();
            string qry = "Select * From Classes";
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
        public void Update(int id, string Name,byte Capacity)
        {
            con.Open();
            string qry = "Update Classes SET Name=@Name,Capacity=@Capacity Where ID=@id";
            try
            {
                using (SqlCommand cmd = new SqlCommand(qry, con))
                {
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.Parameters.AddWithValue("@Name", Name);
                    cmd.Parameters.AddWithValue("@Capacity", Capacity);
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
        public bool CanDelete(int ClassID)
        {
            bool ClassExists = false;
            try
            {
                con.Open();
                string qry = @"
                    SELECT COUNT(ClassID) AS CountClass
                    FROM dbo.Sessions
                    WHERE ClassID=@ClassID";
                using (SqlCommand cmd = new SqlCommand(qry, con))
                {
                    cmd.Parameters.AddWithValue("@ClassID", ClassID);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    ClassExists = count != 0;
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
            return ClassExists;
        }
    }
}
