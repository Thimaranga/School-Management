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
    public partial class userClassTimetable : Form
    {
        int u_id = 0;
        string uu = "";
        public userClassTimetable(int user_id,string user_name)
        {
            InitializeComponent();
            u_id = user_id;
            uu = user_name;
            get_Time_table(user_id);
        }


        public void get_Time_table(int user_i)
        {
            string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
            
            SqlConnection mycon = new SqlConnection(myconnstrng);
            string sql = "SELECT * FROM tbl_users WHERE id='" + user_i + "'";
            SqlCommand cmd = new SqlCommand(sql, mycon);
            SqlDataReader myread;
            mycon.Open();
            myread = cmd.ExecuteReader();
            string grd = "";
            string divs = "";
            while (myread.Read())
            {
                 grd = myread.GetValue(10).ToString();
                 divs = myread.GetValue(11).ToString();
            }
            Time_table_monday(grd, divs);
            Time_table_tuesday(grd, divs);
            Time_table_wednesday(grd, divs);
            Time_table_thursday(grd, divs);
            Time_table_friday(grd, divs);


        }
        public void Time_table_monday(string grd,string divs)
        {
            string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

            SqlConnection mycon = new SqlConnection(myconnstrng);
            string sql = "SELECT * FROM Monday WHERE Grade='" + grd + "' and Division='" + divs + "'";
            SqlCommand cmd = new SqlCommand(sql, mycon);
            SqlDataReader myread;
            mycon.Open();
            myread = cmd.ExecuteReader();
            while (myread.Read())
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
        public void Time_table_tuesday(string grd, string divs)
        {
            string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

            SqlConnection mycon = new SqlConnection(myconnstrng);
            string sql = "SELECT * FROM Tuesday WHERE Grade='" + grd + "' and Division='" + divs + "'";
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
        public void Time_table_wednesday(string grd, string divs)
        {
            string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

            SqlConnection mycon = new SqlConnection(myconnstrng);
            string sql = "SELECT * FROM Wednesday WHERE Grade='" + grd + "' and Division='" + divs + "'";
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
        public void Time_table_thursday(string grd, string divs)
        {
            string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

            SqlConnection mycon = new SqlConnection(myconnstrng);
            string sql = "SELECT * FROM Thursday WHERE Grade='" + grd + "' and Division='" + divs + "'";
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
        public void Time_table_friday(string grd, string divs)
        {
            string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

            SqlConnection mycon = new SqlConnection(myconnstrng);
            string sql = "SELECT * FROM Friday WHERE Grade='" + grd + "' and Division='" + divs + "'";
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            userTimetableDashboard clt = new userTimetableDashboard(uu,u_id);
            clt.FormClosed += new FormClosedEventHandler(splach_scr);
            //clt.gr_us(user_name);
            clt.Show();
        }
        private void splach_scr(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
