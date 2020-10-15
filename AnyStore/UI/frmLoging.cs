using AnyStore.BLL;
using AnyStore.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnyStore.UI
{
    public partial class frmLoging : Form
    {
        public frmLoging()
        {
            InitializeComponent();
        }
        loginBLL l = new loginBLL();
        loginDAL dal = new loginDAL();

        forLogingBLL lb = new forLogingBLL();
        forLogingDAL ld = new forLogingDAL();

        

        private void comboUsertype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            l.username = textUsername.Text.Trim();
            l.password = textPassword.Text.Trim();
            l.user_type = comboUsertype.Text.Trim();
            lb.username= textUsername.Text.Trim();
            lb.password= textPassword.Text.Trim();

            


            bool sucess = dal.loginCheck(l);
            if (sucess == true)
            {
                MessageBox.Show("Login Successful");
                switch(l.user_type)
                {
                    case "Admin":
                        {
                            frmAdminDashboard admin = new frmAdminDashboard();
                            admin.gett(textUsername.Text);
                            admin.Show();
                            this.Hide();
                        }
                        break;

                    case "Teacher":
                        {
                            frmUserDashboard user = new frmUserDashboard();
                            user.Show();
                            user.gett(textUsername.Text);
                            this.Hide();
                        }
                        break;
                    default:
                        {
                            MessageBox.Show("Invalid User Type.");
                            

                        }
                        break;
                }
            }
            else
            {
                MessageBox.Show("Login Failed.Try Again");
            }
            
        }
    }
}
