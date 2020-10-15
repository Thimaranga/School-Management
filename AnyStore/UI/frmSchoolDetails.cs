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
    public partial class frmSchoolDetails : Form
    {
        string uu = "";
        public frmSchoolDetails(string f_name)
        {
            InitializeComponent();
            uu = f_name;
        }
        schoolDetailsBLL u = new schoolDetailsBLL();
        schoolDetailsDAL dal = new schoolDetailsDAL();

        private void lblDivSub_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            u.schoolName = txtName.Text;
            u.address = txtAddress.Text;
            u.province = txtProvince.Text;
            u.NoOfGrades = Convert.ToInt32(txtGrades.Text);
            u.NoOfDivision = Convert.ToInt32(txtDivisions.Text);
            u.NoOfTeachers = Convert.ToInt32(txtTeachers.Text);

            bool success = dal.InsertToSchool(u);
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
        private void clear()
        {

            txtName.Text = "";
            txtAddress.Text = "";
            txtProvince.Text = "";
            txtGrades.Text = "";
            txtDivisions.Text = "";
            txtTeachers.Text = "";

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            selectTeacherOrClasses adminre = new selectTeacherOrClasses(uu);
            adminre.FormClosed += new FormClosedEventHandler(splach_scr);
            adminre.Show();
        }
        private void splach_scr(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
