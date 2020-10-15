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
    public partial class selectTeacherOrClasses : Form
    {
        string uu = "";
        public selectTeacherOrClasses(string user_namef)
        {
            InitializeComponent();
            uu=user_namef;

        }

        private void btnAddTeachers_Click(object sender, EventArgs e)
        {
            frmUsers fu = new frmUsers(uu);
            fu.FormClosed += new FormClosedEventHandler(splach_scr);
            this.Hide();
            fu.Show();
           
        }

        private void btnAddSchool_Click(object sender, EventArgs e)
        {
            frmSchoolDetails sd = new frmSchoolDetails(uu);
            sd.FormClosed += new FormClosedEventHandler(splach_scr);
            this.Hide();
            sd.Show();
           
        }
        private void splach_scr(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdminDashboard adminre = new frmAdminDashboard();
            adminre.FormClosed += new FormClosedEventHandler(splach_scr);
            adminre.gr_us(uu);
            adminre.Show();

        }
    }
}
