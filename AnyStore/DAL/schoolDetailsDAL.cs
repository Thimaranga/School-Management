using AnyStore.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnyStore.DAL
{
    class schoolDetailsDAL
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        #region  Insert Data to attendencetable
        public bool InsertToSchool(schoolDetailsBLL u)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "INSERT INTO schoolDetails(SchoolName,address,province,NoOfGrades,NoOfDivision,NoOfTeachers) VALUES(@schoolName,@address,@province,@NoOfGrades,@NoOfDivision,@NoOfTeachers)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@schoolName", u.schoolName);
                cmd.Parameters.AddWithValue("@address", u.address);
                cmd.Parameters.AddWithValue("@province", u.province);
                cmd.Parameters.AddWithValue("@NoOfGrades", u.NoOfGrades);
                cmd.Parameters.AddWithValue("@NoOfDivision", u.NoOfDivision);
                cmd.Parameters.AddWithValue("@NoOfTeachers", u.NoOfTeachers);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
                return isSuccess;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
    #endregion
    }

}
