using AnyStore.BLL;
using AnyStore.DAL;
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
    public partial class frmAdminattend : Form
    {
        string uu = "";
        public frmAdminattend(string user_name)
        {
            InitializeComponent();
            uu = user_name;
        }
        userBLL u = new userBLL();
        userDAL dal = new userDAL();

        private void pnl3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAdminDashboard leave = new frmAdminDashboard();
            leave.FormClosed += new FormClosedEventHandler(splach_scr);
            leave.gr_us(uu);
            leave.Show();
        }
        private void splach_scr(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAdminattend_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Selectattend();
            dgvData.DataSource = dt;
            tot_att();
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }
        private void tot_att()
        {
            string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
            SqlConnection mycon = new SqlConnection(myconnstrng);
            string sql = "SELECT * FROM tbl_users";
            SqlCommand cmd = new SqlCommand(sql, mycon);
            SqlDataReader myread;
            mycon.Open();
            myread = cmd.ExecuteReader();
            int u_id = 0;
            string f_name = "";
            string l_name = "";
            
            while(myread.Read())
            {
                u_id =(int) myread.GetValue(0);
                f_name = myread.GetValue(1).ToString();
                l_name = myread.GetValue(2).ToString();

                tot_att_user(u_id, f_name, l_name);
                
            }
        }
        private void tot_att_user(int u_id, string f_name, string l_name)
        {
            string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
            SqlConnection mycon = new SqlConnection(myconnstrng);
            string presnt = "No";
            string sql = "SELECT * FROM totAttend where id='"+u_id+"' and present='"+presnt+"'";
            SqlCommand cmd = new SqlCommand(sql, mycon);
            SqlDataReader myread;
            mycon.Open();
            myread = cmd.ExecuteReader();

            int tot = 0;
            while (myread.Read())
            {
                tot++;
                
            }
            tot_att_user_insert(u_id, f_name, l_name, tot);
           
        }
        private void tot_att_user_insert(int u_id, string f_name, string l_name, int tot)
        {
            string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
            SqlConnection mycon = new SqlConnection(myconnstrng);
            
            string sql = "INSERT INTO printattend (Id,fistName,lastName,totleave) VALUES ('"+u_id+"'"+f_name+"'"+l_name+"'"+tot+"')";
            SqlCommand cmd = new SqlCommand(sql, mycon);
            SqlDataReader myread;
            mycon.Open();
            //myread = cmd.ExecuteReader();
            //myread.Read();

        }

        private void btnRemainder_Click(object sender, EventArgs e)
        {
            tot_att_user_insert(1, "abc", "cd", 12);
        }
    }
}
