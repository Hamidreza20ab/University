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
   public class SessionsTimeRepository
    {
        private SqlConnection con;
        public SessionsTimeRepository()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString);

        }
        public void Add(string StartTime, string EndTime)
        {
            con.Open();
            string qry = "INSERT INTO SessionsTime (StartTime,EndTime) Values(@StartTime,@EndTime)";
            try
            {
                using (SqlCommand cmd = new SqlCommand(qry, con))
                {
                    cmd.Parameters.AddWithValue("@StartTime", StartTime);
                    cmd.Parameters.AddWithValue("@EndTime", EndTime);
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
            string qry = "Delete From SessionsTime Where ID = @id";
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
            string qry = "Select * From SessionsTime";
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
        public void Update(int id, string StartTime, string EndTime)
        {
            con.Open();
            string qry = "Update SessionsTime SET StartTime=@StartTime,EndTime=@EndTime Where ID=@id";
            try
            {
                using (SqlCommand cmd = new SqlCommand(qry, con))
                {
                    cmd.Parameters.AddWithValue("ID", id);
                    cmd.Parameters.AddWithValue("StartTime", StartTime);
                    cmd.Parameters.AddWithValue("EndTime", EndTime);
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
        public bool CanDelete(int SessionTimeID)
        {
            bool SessionTimeExists = false;
            try
            {
                con.Open();
                string qry = @"
                    SELECT COUNT(SessionTimeID) AS CountSessionTime
                    FROM dbo.Sessions
                    WHERE SessionTimeID=@SessionTimeID";
                using (SqlCommand cmd = new SqlCommand(qry, con))
                {
                    cmd.Parameters.AddWithValue("@SessionTimeID", SessionTimeID);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    SessionTimeExists = count != 0;
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
            return SessionTimeExists;
        }
    }
}
