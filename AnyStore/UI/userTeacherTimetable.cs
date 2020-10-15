using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnyStore.UI
{

    public partial class userTeacherTimetable : Form
    {
        string user_nam = "";
        int user_i = 0;
        public userTeacherTimetable(string uName,int uId)
        {
            InitializeComponent();
            user_nam = uName;
            user_i = uId;
        }

        public void get_data1(int user_i)
        {
            string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
            SqlConnection mycon = new SqlConnection(myconnstrng);
            string sql = "SELECT * FROM TeacherMonday WHERE id='" + user_i + "'";
            SqlCommand cmd = new SqlCommand(sql, mycon);
            SqlDataReader myread;
            mycon.Open();
            myread = cmd.ExecuteReader();
            while(myread.Read())
            {
                txtm1.Text = myread.GetValue(2).ToString();
                txtm2.Text = myread.GetValue(3).ToString();
                txtm3.Text = myread.GetValue(4).ToString();
                txtm4.Text = myread.GetValue(5).ToString();
                txtm5.Text = myread.GetValue(6).ToString();
                txtm6.Text = myread.GetValue(7).ToString();
                txtm7.Text = myread.GetValue(8).ToString();
                txtm8.Text = myread.GetValue(9).ToString();
            }
        }
        public void get_data2(int user_i)
        {
            string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
            SqlConnection mycon = new SqlConnection(myconnstrng);
            string sql = "SELECT * FROM TeacherTuesday WHERE id='" + user_i + "'";
            SqlCommand cmd = new SqlCommand(sql, mycon);
            SqlDataReader myread;
            mycon.Open();
            myread = cmd.ExecuteReader();
            while (myread.Read())
            {
                txttu1.Text = myread.GetValue(2).ToString();
                txttu2.Text = myread.GetValue(3).ToString();
                txttu3.Text = myread.GetValue(4).ToString();
                txttu4.Text = myread.GetValue(5).ToString();
                txttu5.Text = myread.GetValue(6).ToString();
                txttu6.Text = myread.GetValue(7).ToString();
                txttu7.Text = myread.GetValue(8).ToString();
                txttu8.Text = myread.GetValue(9).ToString();
            }
        }
        public void get_data3(int user_i)
        {
            string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
            SqlConnection mycon = new SqlConnection(myconnstrng);
            string sql = "SELECT * FROM TeacherWednesday WHERE id='" + user_i + "'";
            SqlCommand cmd = new SqlCommand(sql, mycon);
            SqlDataReader myread;
            mycon.Open();
            myread = cmd.ExecuteReader();
            while (myread.Read())
            {
                txtw1.Text = myread.GetValue(2).ToString();
                txtw2.Text = myread.GetValue(3).ToString();
                txtw3.Text = myread.GetValue(4).ToString();
                txtw4.Text = myread.GetValue(5).ToString();
                txtw5.Text = myread.GetValue(6).ToString();
                txtw6.Text = myread.GetValue(7).ToString();
                txtw7.Text = myread.GetValue(8).ToString();
                txtw8.Text = myread.GetValue(9).ToString();
            }
        }
        public void get_data4(int user_i)
        {
            string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
            SqlConnection mycon = new SqlConnection(myconnstrng);
            string sql = "SELECT * FROM TeacherThursday WHERE id='" + user_i + "'";
            SqlCommand cmd = new SqlCommand(sql, mycon);
            SqlDataReader myread;
            mycon.Open();
            myread = cmd.ExecuteReader();
            while (myread.Read())
            {
                txtth1.Text = myread.GetValue(2).ToString();
                txtth2.Text = myread.GetValue(3).ToString();
                txtth3.Text = myread.GetValue(4).ToString();
                txtth4.Text = myread.GetValue(5).ToString();
                txtth5.Text = myread.GetValue(6).ToString();
                txtth6.Text = myread.GetValue(7).ToString();
                txtth7.Text = myread.GetValue(8).ToString();
                txtth8.Text = myread.GetValue(9).ToString();
            }
        }
        public void get_data5(int user_i)
        {
            string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
            SqlConnection mycon = new SqlConnection(myconnstrng);
            string sql = "SELECT * FROM TeacherFriday WHERE id='" + user_i + "'";
            SqlCommand cmd = new SqlCommand(sql, mycon);
            SqlDataReader myread;
            mycon.Open();
            myread = cmd.ExecuteReader();
            while (myread.Read())
            {
                txtf1.Text = myread.GetValue(2).ToString();
                txtf2.Text = myread.GetValue(3).ToString();
                txtf3.Text = myread.GetValue(4).ToString();
                txtf4.Text = myread.GetValue(5).ToString();
                txtf5.Text = myread.GetValue(6).ToString();
                txtf6.Text = myread.GetValue(7).ToString();
                txtf7.Text = myread.GetValue(8).ToString();
                txtf8.Text = myread.GetValue(9).ToString();
            }
        }

        private void userTeacherTimetable_Load(object sender, EventArgs e)
        {
            get_data1(user_i);
            get_data2(user_i);
            get_data3(user_i);
            get_data4(user_i);
            get_data5(user_i);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            userTimetableDashboard clt = new userTimetableDashboard(user_nam,user_i);
            clt.FormClosed += new FormClosedEventHandler(splach_scr);
            clt.Show();
        }
        private void splach_scr(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
