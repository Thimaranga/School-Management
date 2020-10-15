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
    public partial class timetableDashboard : Form
    {
        string uu = "";
        public timetableDashboard( string user_name)
        {
            InitializeComponent();
            uu = user_name;
        }

        private void lbltop_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            addClassTimetable cltb = new addClassTimetable(uu);
            cltb.FormClosed += new FormClosedEventHandler(splach_scr);
            this.Hide();
            cltb.Show();
        }
        private void splach_scr(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            showTeachersTimetable stt = new showTeachersTimetable(uu);
            stt.FormClosed += new FormClosedEventHandler(splach_scr);
            this.Hide();
            stt.Show();
        }

        private void btnTeachersAdd_Click(object sender, EventArgs e)
        {
            addTeachersTimetable thtb = new addTeachersTimetable(uu);
            thtb.FormClosed += new FormClosedEventHandler(splach_scr);
            this.Hide();
            thtb.Show();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAdminDashboard clt = new frmAdminDashboard();
            clt.FormClosed += new FormClosedEventHandler(splach_scr);
            clt.gr_us(uu);
            clt.Show();
        }

        private void btnClassesView_Click(object sender, EventArgs e)
        {
            showClassTimetable clt = new showClassTimetable(uu);
            clt.FormClosed += new FormClosedEventHandler(splach_scr);
            this.Hide();
            clt.Show();
        }
    }
}
