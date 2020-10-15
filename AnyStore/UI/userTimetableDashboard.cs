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
    public partial class userTimetableDashboard : Form
    {
        string uu = "";
        int userId = 0;
        public userTimetableDashboard(string user_name,int uId)
        {
            InitializeComponent();
            uu = user_name;
            userId = uId;
        }

        private void btnClassesView_Click(object sender, EventArgs e)
        {
            userClassTimetable clt = new userClassTimetable(userId,uu);
            clt.FormClosed += new FormClosedEventHandler(splach_scr);
            this.Hide();
            clt.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            frmUserDashboard clt = new frmUserDashboard();
            clt.FormClosed += new FormClosedEventHandler(splach_scr);
            clt.gr_us(uu,userId);
            clt.Show();
        }
        private void splach_scr(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTeachersView_Click(object sender, EventArgs e)
        {
            this.Hide();
            userTeacherTimetable clt = new userTeacherTimetable(uu, userId);
            clt.FormClosed += new FormClosedEventHandler(splach_scr);
            clt.Show();
        }
    }
}
