using AnyStore.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnyStore.DAL
{
    class timetableDAL
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        #region  Insert Data to attendencetable
        public bool InsertToMonday(timetableBLL u)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "INSERT INTO Monday(Grade,Division,p1,p2,p3,p4,p5,p6,p7,p8) VALUES(@Grade,@Division,@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Grade", u.Grade);
                cmd.Parameters.AddWithValue("@Division", u.Division);
                cmd.Parameters.AddWithValue("@p1", u.p1);
                cmd.Parameters.AddWithValue("@p2", u.p2);
                cmd.Parameters.AddWithValue("@p3", u.p3);
                cmd.Parameters.AddWithValue("@p4", u.p4);
                cmd.Parameters.AddWithValue("@p5", u.p5);
                cmd.Parameters.AddWithValue("@p6", u.p6);
                cmd.Parameters.AddWithValue("@p7", u.p7);
                cmd.Parameters.AddWithValue("@p8", u.p8);


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

        public bool InsertToTuesday(timetableBLL u)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "INSERT INTO Tuesday(Grade,Division,p1,p2,p3,p4,p5,p6,p7,p8) VALUES(@Grade,@Division,@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Grade", u.Grade);
                cmd.Parameters.AddWithValue("@Division", u.Division);
                cmd.Parameters.AddWithValue("@p1", u.p1);
                cmd.Parameters.AddWithValue("@p2", u.p2);
                cmd.Parameters.AddWithValue("@p3", u.p3);
                cmd.Parameters.AddWithValue("@p4", u.p4);
                cmd.Parameters.AddWithValue("@p5", u.p5);
                cmd.Parameters.AddWithValue("@p6", u.p6);
                cmd.Parameters.AddWithValue("@p7", u.p7);
                cmd.Parameters.AddWithValue("@p8", u.p8);


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

        public bool InsertToWednesday(timetableBLL u)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "INSERT INTO Wednesday(Grade,Division,p1,p2,p3,p4,p5,p6,p7,p8) VALUES(@Grade,@Division,@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Grade", u.Grade);
                cmd.Parameters.AddWithValue("@Division", u.Division);
                cmd.Parameters.AddWithValue("@p1", u.p1);
                cmd.Parameters.AddWithValue("@p2", u.p2);
                cmd.Parameters.AddWithValue("@p3", u.p3);
                cmd.Parameters.AddWithValue("@p4", u.p4);
                cmd.Parameters.AddWithValue("@p5", u.p5);
                cmd.Parameters.AddWithValue("@p6", u.p6);
                cmd.Parameters.AddWithValue("@p7", u.p7);
                cmd.Parameters.AddWithValue("@p8", u.p8);


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

        public bool InsertToThursday(timetableBLL u)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "INSERT INTO Thursday(Grade,Division,p1,p2,p3,p4,p5,p6,p7,p8) VALUES(@Grade,@Division,@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Grade", u.Grade);
                cmd.Parameters.AddWithValue("@Division", u.Division);
                cmd.Parameters.AddWithValue("@p1", u.p1);
                cmd.Parameters.AddWithValue("@p2", u.p2);
                cmd.Parameters.AddWithValue("@p3", u.p3);
                cmd.Parameters.AddWithValue("@p4", u.p4);
                cmd.Parameters.AddWithValue("@p5", u.p5);
                cmd.Parameters.AddWithValue("@p6", u.p6);
                cmd.Parameters.AddWithValue("@p7", u.p7);
                cmd.Parameters.AddWithValue("@p8", u.p8);


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

        public bool InsertToFriday(timetableBLL u)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "INSERT INTO Friday(Grade,Division,p1,p2,p3,p4,p5,p6,p7,p8) VALUES(@Grade,@Division,@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Grade", u.Grade);
                cmd.Parameters.AddWithValue("@Division", u.Division);
                cmd.Parameters.AddWithValue("@p1", u.p1);
                cmd.Parameters.AddWithValue("@p2", u.p2);
                cmd.Parameters.AddWithValue("@p3", u.p3);
                cmd.Parameters.AddWithValue("@p4", u.p4);
                cmd.Parameters.AddWithValue("@p5", u.p5);
                cmd.Parameters.AddWithValue("@p6", u.p6);
                cmd.Parameters.AddWithValue("@p7", u.p7);
                cmd.Parameters.AddWithValue("@p8", u.p8);


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

        #region Select Data from Database
        public DataTable SelectMonday()
        {
            SqlConnection conn = new SqlConnection(myconnstrng);

            DataTable dt = new DataTable();
            try
            {
                String sql = "SELECT * FROM Monday";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public DataTable SelectTuesday()
        {
            SqlConnection conn = new SqlConnection(myconnstrng);

            DataTable dt = new DataTable();
            try
            {
                String sql = "SELECT * FROM Tuesday";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        public DataTable SelectWednesday()
        {
            SqlConnection conn = new SqlConnection(myconnstrng);

            DataTable dt = new DataTable();
            try
            {
                String sql = "SELECT * FROM Wednesday";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        public DataTable SelectThursday()
        {
            SqlConnection conn = new SqlConnection(myconnstrng);

            DataTable dt = new DataTable();
            try
            {
                String sql = "SELECT * FROM Thursday";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        public DataTable SelectFriday()
        {
            SqlConnection conn = new SqlConnection(myconnstrng);

            DataTable dt = new DataTable();
            try
            {
                String sql = "SELECT * FROM Friday";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        #endregion

    }
}
