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
    public partial class showTeachersTimetable : Form
    {
        string uu = "";
        public showTeachersTimetable(string user_name)
        {
            InitializeComponent();
            uu = user_name;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            timetableDashboard ttdre = new timetableDashboard(uu);
            ttdre.FormClosed += new FormClosedEventHandler(splach_scr);
            ttdre.Show();
        }
        private void splach_scr(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
