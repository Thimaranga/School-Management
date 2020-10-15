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
    public partial class showClassTimetable : Form
    {
        string uu = "";
        public showClassTimetable(String usert_name)
        {
            InitializeComponent();
            uu = usert_name;
        }
        timetableBLL u = new timetableBLL();
        timetableDAL dal = new timetableDAL();

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

        private void showClassTimetable_Load(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string days = comboBox1.Text;
            

            if(comboBox1.Text=="Monday")
            {
                DataTable dt = dal.SelectMonday();
                dataGridView1.DataSource = dt;
            }
            else if (comboBox1.Text == "Tuesday")
            {
                DataTable dt = dal.SelectTuesday();
                dataGridView1.DataSource = dt;
            }
            else if (comboBox1.Text == "Wednesday")
            {
                DataTable dt = dal.SelectWednesday();
                dataGridView1.DataSource = dt;
            }
            else if (comboBox1.Text == "Thursday")
            {
                DataTable dt = dal.SelectThursday();
                dataGridView1.DataSource = dt;
            }
            else if (comboBox1.Text == "Friday")
            {
                DataTable dt = dal.SelectFriday();
                dataGridView1.DataSource = dt;
            }
           
        }
    }
}
