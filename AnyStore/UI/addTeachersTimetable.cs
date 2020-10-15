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
    public partial class addTeachersTimetable : Form
    {
        string uu = "";

        public addTeachersTimetable(string user_name)
        {
            InitializeComponent();
            uu = user_name;
        }

        userBLL u = new userBLL();
        userDAL dal = new userDAL();

        timetableTeachersBLL ttb = new timetableTeachersBLL();
        timetableTeachersDAL ttd = new timetableTeachersDAL();


        private void addTeachersTimetable_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.SelectNotAll();
            dgvTeacherTime.DataSource = dt;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
        private void clear()
        {
            txtId.Text = "";
            txtName.Text = "";
            comboDay.Text = "";
            combo1.Text = "";
            combo2.Text = "";
            combo3.Text = "";
            combo4.Text = "";
            combo5.Text = "";
            combo6.Text = "";
            combo7.Text = "";
            combo8.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            comboBox5.Text = "";
            comboBox6.Text = "";
            comboBox7.Text = "";
            comboBox8.Text = "";


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string days = comboDay.Text;
            ttb.id = txtId.Text;
            ttb.name = txtName.Text;
            ttb.p1 = combo1.Text + comboBox8.Text;
            ttb.p2 = combo2.Text + comboBox7.Text;
            ttb.p3 = combo3.Text + comboBox6.Text;
            ttb.p4 = combo4.Text + comboBox5.Text;
            ttb.p5 = combo5.Text + comboBox4.Text;
            ttb.p6 = combo6.Text + comboBox3.Text;
            ttb.p7 = combo7.Text + comboBox2.Text;
            ttb.p8 = combo8.Text + comboBox1.Text;

            if (days == "Monday")
            {
                bool success = ttd.InsertToMonday(ttb);
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
            else if (days == "Tuesday")
            {
                bool success = ttd.InsertToTuesday(ttb);
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
                bool success = ttd.InsertToWednesday(ttb);
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
                bool success = ttd.InsertToThursday(ttb);
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
                bool success = ttd.InsertToFriday(ttb);
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            string keywords = textSearch.Text;
            if (keywords != null)
            {
                DataTable dt = dal.Search(keywords);
                dgvTeacherTime.DataSource = dt;
            }
            else
            {
                DataTable dt = dal.Select();
                dgvTeacherTime.DataSource = dt;
            }
        }

        private void dgvTeacherTime_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtId.Text = dgvTeacherTime.Rows[rowIndex].Cells[0].Value.ToString();
            txtName.Text = dgvTeacherTime.Rows[rowIndex].Cells[1].Value.ToString();
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
