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
    public partial class frmUserAlert : Form
    {
        string user_nam = "";
        int user_i = 0;
        public frmUserAlert( string user_name,int user_id)
        {
            InitializeComponent();
            user_nam = user_name;
            user_i = user_id;


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            frmUserDashboard userre = new frmUserDashboard();
            userre.FormClosed += new FormClosedEventHandler(splach_scr);
            userre.gr_us(user_nam,user_i);
            userre.Show();
        }
        private void splach_scr(object sender, EventArgs e)
        {
            this.Close();
        }

        public void get_Alert(int user_i)
        {
            string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
            string vlue = "no";
            string vlu2 = "all";
            SqlConnection mycon = new SqlConnection(myconnstrng);
            string sql = "SELECT * FROM tblAlert WHERE id='" + user_i + "' and Show='"+vlue+"' or Name='"+vlu2+"'";
            SqlCommand cmd = new SqlCommand(sql, mycon);
            SqlDataReader myread;
            mycon.Open();
            myread = cmd.ExecuteReader();
            int count = 1;
            while(myread.Read())
            {
                richTextBox1.Text += "Alert"+count+" :"+myread.GetValue(3).ToString()+"\n";
                count++;
            }

            
        }

        private void frmUserAlert_Load(object sender, EventArgs e)
        {
            get_Alert(user_i);
        }
    }
}
