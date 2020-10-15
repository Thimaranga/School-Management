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
    class timetableTeachersDAL
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        #region  Insert Data to attendencetable
        public bool InsertToMonday(timetableTeachersBLL u)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "INSERT INTO TeacherMonday(id,name,p1,p2,p3,p4,p5,p6,p7,p8) VALUES(@id,@name,@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", u.id);
                cmd.Parameters.AddWithValue("@name", u.name);
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

        internal bool InsertToTuesday(userBLL u)
        {
            throw new NotImplementedException();
        }

        internal bool InsertToMonday(object u)
        {
            throw new NotImplementedException();
        }

        public bool InsertToTuesday(timetableTeachersBLL u)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "INSERT INTO TeacherTuesday(id,name,p1,p2,p3,p4,p5,p6,p7,p8) VALUES(@id,@name,@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", u.id);
                cmd.Parameters.AddWithValue("@name", u.name);
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
        public bool InsertToWednesday(timetableTeachersBLL u)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "INSERT INTO TeacherWednesday(id,name,p1,p2,p3,p4,p5,p6,p7,p8) VALUES(@id,@name,@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", u.id);
                cmd.Parameters.AddWithValue("@name", u.name);
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
        public bool InsertToThursday(timetableTeachersBLL u)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "INSERT INTO TeacherThursday(id,name,p1,p2,p3,p4,p5,p6,p7,p8) VALUES(@id,@name,@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", u.id);
                cmd.Parameters.AddWithValue("@name", u.name);
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
        public bool InsertToFriday(timetableTeachersBLL u)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "INSERT INTO TeacherFriday(id,name,p1,p2,p3,p4,p5,p6,p7,p8) VALUES(@id,@name,@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", u.id);
                cmd.Parameters.AddWithValue("@name", u.name);
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
    }
}
