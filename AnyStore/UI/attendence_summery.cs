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
    public partial class attendence_summery : Form
    {
        int user_i = 0;
        string user_name = "";
        public attendence_summery(int user_id,string user_nam)
        {
            InitializeComponent();
            user_i = user_id;
            user_name = user_nam;
            //label1.Text = user_i.ToString();
            get_Alert(user_id);
        }

        userBLL u = new userBLL();
        userDAL dal = new userDAL();

        attendenceBLL y = new attendenceBLL();
        attendenceDAL z = new attendenceDAL();

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void attendence_summery_Load(object sender, EventArgs e)
        {

            
            

        }
        public void get_Alert(int user_i)
        {
            string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
            string no = "No";
            SqlConnection mycon = new SqlConnection(myconnstrng);
            string sql = "SELECT * FROM totAttend WHERE id='" + user_i + "' and present='"+no+"'";
            SqlCommand cmd = new SqlCommand(sql, mycon);
            SqlDataReader myread;
            mycon.Open();
            myread = cmd.ExecuteReader();
            int count_v = 0;
            while(myread.Read())
            {

                txtName.Text = myread.GetValue(2).ToString();
                count_v++;
                txtLea.Text = count_v.ToString();

            }


            
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            frmUserDashboard clt = new frmUserDashboard();
            clt.FormClosed += new FormClosedEventHandler(splach_scr);
            clt.gr_us(user_name,user_i);
            clt.Show();
        }
        private void splach_scr(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
