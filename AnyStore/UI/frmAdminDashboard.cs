using AnyStore.BLL;
using AnyStore.DAL;
using AnyStore.UI;
using MySql.Data.MySqlClient;
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
    
    public partial class frmAdminDashboard : Form
    {
        string user_namef = "";
        public frmAdminDashboard()
        {
            InitializeComponent();
            
        }
        forLogingBLL lb = new forLogingBLL();
        forLogingDAL ld = new forLogingDAL();
        bringdata g = new bringdata();

        private void frmAdminDashboard_Load(object sender, EventArgs e)
        {

        }
        public void is_log()
        {
            if(user_namef=="")
            {
                frmLoging ob = new frmLoging();
                {
                    this.Hide();
                    ob.Show();
                }
            }
        }
        public void gett(string user_name)
        {
            user_namef = user_name;
             string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
            
            SqlConnection mycon = new SqlConnection(myconnstrng);
            string sql = "SELECT * FROM tbl_users WHERE username='" + user_name+"'";
            SqlCommand cmd = new SqlCommand(sql, mycon);
            SqlDataReader myread;
            mycon.Open();
            myread = cmd.ExecuteReader();
            myread.Read();
            user_namef = myread.GetValue(1).ToString() + " " + myread.GetValue(2).ToString();
            lblloggedinuser.Text = myread.GetValue(1).ToString()+" "+ myread.GetValue(2).ToString();
            g.id =(int) myread.GetValue(0);
            g.name= myread.GetValue(1).ToString() + " " + myread.GetValue(2).ToString();
        }
        public void gr_us(string uu)
        {
            user_namef = uu;
            lblloggedinuser.Text = uu;
        }

        private void lblfooter_Click(object sender, EventArgs e)
        {

        }

        private void lblheadingname2_Click(object sender, EventArgs e)
        {

        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmAdminDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLoging login = new frmLoging();
            login.Show();
            this.Hide();
            //frmAdminDashboard admin = new frmAdminDashboard();
           
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void CategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Btn_teacher_Click(object sender, EventArgs e)
        {
            selectTeacherOrClasses user = new selectTeacherOrClasses(user_namef);
            user.FormClosed += new FormClosedEventHandler(splach_scr);
            this.Hide();
            user.Show();

        }
        private void splach_scr(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Lblus_Click(object sender, EventArgs e)
        {

        }

        private void Lblloggedinuser_Click(object sender, EventArgs e)
        {
            //lblloggedinuser.Text=lb.first_name
        }

        private void Btn_attendence_Click(object sender, EventArgs e)
        {
            frmAttendence attends = new frmAttendence(user_namef);
            attends.FormClosed += new FormClosedEventHandler(splach_scr);
            this.Hide();
            
            attends.Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            frmLoging log = new frmLoging();
            log.FormClosed += new FormClosedEventHandler(splash_scr);
            this.Hide();
            log.Show();
        }
        private void splash_scr(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pnladminfooter_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_time_Click(object sender, EventArgs e)
        {
            timetableDashboard timeD = new timetableDashboard(user_namef);
            timeD.FormClosed += new FormClosedEventHandler(splach_scr);
            timeD.Show();
            this.Hide();
        }

        private void btn_relief_Click(object sender, EventArgs e)
        {

        }

        private void btn_leaves_Click(object sender, EventArgs e)
        {
            frmAdminattend adminattend = new frmAdminattend(user_namef);
            adminattend.FormClosed += new FormClosedEventHandler(splach_scr);
            this.Hide();
            adminattend.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            user_namef = "";
            is_log();
        }

        private void btn_alerts_Click(object sender, EventArgs e)
        {
            frmAlert al = new frmAlert(user_namef);
            al.FormClosed += new FormClosedEventHandler(splach_scr);
            this.Hide();
            al.Show();
        }
    }
}
