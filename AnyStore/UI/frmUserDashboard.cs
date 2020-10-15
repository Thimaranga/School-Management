using AnyStore.BLL;
using AnyStore.UI;
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

namespace AnyStore
{
    public partial class frmUserDashboard : Form
    {
        string user_namef = "";
        int user_id = 0;
        public frmUserDashboard()
        {
            InitializeComponent();
        }
        bringdata g = new bringdata();
        public void gr_us(string uu,int uid)
        {
            user_namef = uu;
            lblloggedinuser.Text = uu;
            user_id = uid;
        }

        private void frmUserDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLoging log = new frmLoging();
            log.Show();
           // this.Close();
            
            //frmUserDashboard user=new frmUserDashboard();

        }
        public void is_log()
        {
            if (user_namef == "")
            {
                frmLoging ob = new frmLoging();
                {
                    this.Hide();
                    ob.Show();
                }
            }
        }

        private void FrmUserDashboard_Load(object sender, EventArgs e)
        {

        }

        private void Lblloggedinuser_Click(object sender, EventArgs e)
        {

        }

        private void btn_attendence_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_leaves_Click(object sender, EventArgs e)
        {
            attendence_summery ob = new attendence_summery(user_id, user_namef);
            ob.FormClosed += new FormClosedEventHandler(splach_scr);
            this.Hide();
           // ob.get_Alert(user_id);
            ob.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void gett(string user_name)
        {
            string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

            SqlConnection mycon = new SqlConnection(myconnstrng);
            string sql = "SELECT * FROM tbl_users WHERE username='" + user_name + "'";
            SqlCommand cmd = new SqlCommand(sql, mycon);
            SqlDataReader myread;
            mycon.Open();
            myread = cmd.ExecuteReader();
            myread.Read();

            lblloggedinuser.Text = myread.GetValue(1).ToString() + " " + myread.GetValue(2).ToString();
            user_namef = myread.GetValue(1).ToString() + " " + myread.GetValue(2).ToString();
            user_id =(int) myread.GetValue(0);
            g.id = (int)myread.GetValue(0);
            g.name = myread.GetValue(1).ToString() + " " + myread.GetValue(2).ToString();

        }
        private void btn_alerts_Click(object sender, EventArgs e)
        {
            frmUserAlert frm = new frmUserAlert(user_namef, user_id);
            frm.FormClosed += new FormClosedEventHandler(splach_scr);
            this.Hide();
            frm.Show();
        }
        private void splach_scr(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblloggedinuser_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            user_namef = "";
            is_log();
        }

        private void btn_time_Click(object sender, EventArgs e)
        {
            userTimetableDashboard ob = new userTimetableDashboard(user_namef,user_id);
            ob.FormClosed += new FormClosedEventHandler(splach_scr);
            this.Hide();
            ob.Show();
        }
    }
}
