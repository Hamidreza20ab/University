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
    public class TermsRepository
    {
        private SqlConnection con;
        public TermsRepository()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString);

        }
        public void Add(string TermTitle,int StartDate, int EndDate)
        {
            con.Open();
            string qry = "INSERT INTO Terms (TermTitle,StartDate,EndDate) Values(@TermTitle,@StartDate,@EndDate)";
            try
            {
                using (SqlCommand cmd = new SqlCommand(qry, con))
                {
                    cmd.Parameters.AddWithValue("@TermTitle", TermTitle);
                    cmd.Parameters.AddWithValue("@StartDate", StartDate);
                    cmd.Parameters.AddWithValue("@EndDate", EndDate);
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
            string qry = "Delete From Terms Where ID = @id";
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
        public DataTable GetTerm()
        {
            DataTable dt = new DataTable();
            con.Open();
            string qry = @"Select 0 As ID,N'' AS TermTitle
                            UNION
                            Select ID,TermTitle From Terms";

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
        public DataTable GetAll()
        {
            DataTable dt = new DataTable();
            con.Open();
            string qry = "Select * From Terms";
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
        public void Update(int id, string TermTitle, int StartDate, int EndDate)
        {
            con.Open();
            string qry = "Update Terms SET TermTitle=@TermTitle,StartDate=@StartDate,EndDate=@EndDate Where ID=@id";
            try
            {
                using (SqlCommand cmd = new SqlCommand(qry, con))
                {
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.Parameters.AddWithValue("@TermTitle",TermTitle);
                    cmd.Parameters.AddWithValue("@StartDate", StartDate);
                    cmd.Parameters.AddWithValue("@EndDate", EndDate);
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
        public bool CanDelete(int TermID)
        {
            bool TermExists = false;
            try
            {
                con.Open();
                string qry = @"
                    SELECT COUNT(TermID) AS CountTermID 
                    FROM Courses
                    WHERE TermID = @TermID";
                using (SqlCommand cmd = new SqlCommand(qry, con))
                {
                    cmd.Parameters.AddWithValue("@TermID", TermID);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    TermExists = count != 0;
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
            return TermExists;
        }
    }
}
