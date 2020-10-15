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
using MySql.Data.MySqlClient;

namespace AnyStore.UI
{
    public partial class frmUsers : Form
    {
        string f_name = "";
        public frmUsers(string namef)
        {
            InitializeComponent();
            f_name = namef;
        }
        userBLL u = new userBLL();
        userDAL dal = new userDAL();
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            selectTeacherOrClasses adminre = new selectTeacherOrClasses(f_name);
            adminre.FormClosed += new FormClosedEventHandler(splach_scr);
            adminre.Show();
        }
        private void splach_scr(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            u.id = Convert.ToInt32(textId.Text);
            u.first_name = textFirstName.Text;
            u.last_name = textLastName.Text;
            u.email = textEmail.Text;
            u.username = textUserName.Text;
            u.password = textPassword.Text;
            u.contact = textContact.Text;
            u.address = textAddress.Text;
            u.gender = comboGender.Text;
            u.subject = comboSubject.Text;
            u.grade = comboGrade.Text;
            u.classs = comboClass.Text;
            u.user_type = comboUserType.Text;
            u.added_date = DateTime.Now;
            u.added_by = 1;

            bool success = dal.Insert(u);
            if(success==true)
            {
                MessageBox.Show("User Successfully Inserted");
                clear();

            }
            else
            {
                MessageBox.Show("Failed to Add User.Try Again.");
            }
            DataTable dt = dal.Select();
            dgvusers.DataSource = dt;
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            dgvusers.DataSource = dt;
        }
        private void clear()
        {
            textId.Text = "";
            textFirstName.Text = "";
            textLastName.Text = "";
            textEmail.Text = "";
            textUserName.Text = "";
            textPassword.Text = "";
            textContact.Text = "";
            textAddress.Text = "";
            comboGender.Text = "";
            comboSubject.Text = "";
            comboGrade.Text = "";
            comboClass.Text = "";
            comboUserType.Text = "";
        }

        private void dgvusers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            textId.Text = dgvusers.Rows[rowIndex].Cells[0].Value.ToString();
            textFirstName.Text = dgvusers.Rows[rowIndex].Cells[1].Value.ToString();
            textLastName.Text = dgvusers.Rows[rowIndex].Cells[2].Value.ToString();
            textEmail.Text = dgvusers.Rows[rowIndex].Cells[3].Value.ToString();
            textUserName.Text = dgvusers.Rows[rowIndex].Cells[4].Value.ToString();
            textPassword.Text = dgvusers.Rows[rowIndex].Cells[5].Value.ToString();
            textContact.Text = dgvusers.Rows[rowIndex].Cells[6].Value.ToString();
            textAddress.Text = dgvusers.Rows[rowIndex].Cells[7].Value.ToString();
            comboGender.Text = dgvusers.Rows[rowIndex].Cells[8].Value.ToString();
            comboSubject.Text = dgvusers.Rows[rowIndex].Cells[9].Value.ToString();
            comboGrade.Text = dgvusers.Rows[rowIndex].Cells[10].Value.ToString();
            comboClass.Text = dgvusers.Rows[rowIndex].Cells[11].Value.ToString();
            comboUserType.Text = dgvusers.Rows[rowIndex].Cells[12].Value.ToString();


            textId.ReadOnly = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            u.id = Convert.ToInt32(textId.Text);
            u.first_name = textFirstName.Text;
            u.last_name = textLastName.Text;
            u.email = textEmail.Text;
            u.username = textUserName.Text;
            u.password = textPassword.Text;
            u.contact = textContact.Text;
            u.address = textAddress.Text;
            u.gender = comboGender.Text;
            u.subject = comboSubject.Text;
            u.grade = comboGrade.Text;
            u.classs = comboClass.Text;
            u.user_type = comboUserType.Text;
            u.added_date = DateTime.Now;
            u.added_by = 1;

            bool success = dal.Update(u);
            if (success == true)
            {
                MessageBox.Show("User Successfully Updated");
                clear();

            }
            else
            {
                MessageBox.Show("Failed to Update User.Try Again.");
            }
            DataTable dt = dal.Select();
            dgvusers.DataSource = dt;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            u.id = Convert.ToInt32(textId.Text);

            bool success = dal.Delete(u);
            if(success==true)
            {
                MessageBox.Show("User successfully Removed");
                clear();
            }
            else
            {
                MessageBox.Show("User failed to Remove.Try Again.");
            }
            DataTable dt = dal.Select();
            dgvusers.DataSource = dt;
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            string keywords = textSearch.Text;
            if(keywords!=null)
            {
                DataTable dt = dal.Search(keywords);
                dgvusers.DataSource = dt;
            }
            else
            {
                DataTable dt = dal.Select();
                dgvusers.DataSource = dt;
            }
        }

        private void textId_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvusers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
