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
    public partial class addClassTimetable : Form
    {
        string uu = "";
        public addClassTimetable(string user_name)
        {
            InitializeComponent();
            uu = user_name;

        }

        timetableBLL u = new timetableBLL();
        timetableDAL dal = new timetableDAL();

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string days = comboDay.Text;
            u.Grade = comboGrade.Text;
            u.Division = comboDevision.Text;
            u.p1 = comboP1.Text;
            u.p2 = comboP2.Text;
            u.p3 = comboP3.Text;
            u.p4 = comboP4.Text;
            u.p5 = comboP5.Text;
            u.p6 = comboP6.Text;
            u.p7 = comboP7.Text;
            u.p8 = comboP8.Text;

            if(days=="Monday")
            {
                bool success = dal.InsertToMonday(u);
                if (success == true)
                {
                    MessageBox.Show("User Successfully Inserted");
                    clear();

                }
                else
                {
                    MessageBox.Show("Failed to Add User.Try Again.");
                }
            }
            else if(days=="Tuesday")
            {
                bool success = dal.InsertToTuesday(u);
                if (success == true)
                {
                    MessageBox.Show("User Successfully Inserted");
                    clear();

                }
                else
                {
                    MessageBox.Show("Failed to Add User.Try Again.");
                }
            }
            else if (days == "Wednesday")
            {
                bool success = dal.InsertToWednesday(u);
                if (success == true)
                {
                    MessageBox.Show("User Successfully Inserted");
                    clear();

                }
                else
                {
                    MessageBox.Show("Failed to Add User.Try Again.");
                }
            }
            else if (days == "Thursday")
            {
                bool success = dal.InsertToThursday(u);
                if (success == true)
                {
                    MessageBox.Show("User Successfully Inserted");
                    clear();

                }
                else
                {
                    MessageBox.Show("Failed to Add User.Try Again.");
                }
            }
            else if (days == "Friday")
            {
                bool success = dal.InsertToFriday(u);
                if (success == true)
                {
                    MessageBox.Show("User Successfully Inserted");
                    clear();

                }
                else
                {
                    MessageBox.Show("Failed to Add User.Try Again.");
                }
            }
        }

        private void clear()
        {
            comboGrade.Text = "";
            comboDevision.Text = "";
            comboDay.Text = "";
            comboP1.Text = "";
            comboP2.Text = "";
            comboP3.Text = "";
            comboP4.Text = "";
            comboP5.Text = "";
            comboP6.Text = "";
            comboP7.Text = "";
            comboP8.Text = "";

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
