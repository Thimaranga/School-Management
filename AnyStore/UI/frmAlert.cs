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
    public partial class frmAlert : Form
    {
        string uu = "";
        public frmAlert( string user_name)
        {
            InitializeComponent();
            uu = user_name;
        }
        userBLL u = new userBLL();
        userDAL dal = new userDAL();

        alertBLL ab = new alertBLL();
        alertDAL adal = new alertDAL();

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdminDashboard adminre = new frmAdminDashboard();
            adminre.FormClosed += new FormClosedEventHandler(splach_scr);
            adminre.gr_us(uu);
            adminre.Show();
        }
        private void splach_scr(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAlert_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.SelectNotAll();
            dgvMain.DataSource = dt;
        }

        private void dgvMain_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            //textBox1.Text = dgvMain.Rows[rowIndex].Cells[0].Value.ToString();
            if(txtId.Visible==true)
            {

                txtId.Text = dgvMain.Rows[rowIndex].Cells[0].Value.ToString();
                txtName.Text = dgvMain.Rows[rowIndex].Cells[1].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            txtId.Visible = false;
            label5.Visible = false;
            txtName.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            txtId.Visible = true;
            label5.Visible = true;
            txtName.Visible = true;
        }
        private void clear()
        {
            txtId.Clear();
            txtName.Clear();
            txtTitle.Clear();
            txtDescription.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(txtId.Visible==true)
            {
                ab.id = txtId.Text;
                ab.name = txtName.Text;
                ab.title = txtTitle.Text;
                ab.description = txtDescription.Text;
                ab.show = "no";

                bool success = adal.InsertForAlert(ab);
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
            else
            {
                ab.id ="";
                ab.name = "all";
                ab.title = txtTitle.Text;
                ab.description = txtDescription.Text;
                ab.show = "no";

                bool success = adal.InsertForAlert(ab);
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string keywords = textBox3.Text;
            if (keywords != null)
            {
                DataTable dt = adal.Search(keywords);
                dgvMain.DataSource = dt;
            }
            else
            {
                DataTable dt = adal.Select();
                dgvMain.DataSource = dt;
            }
        }
    }
}
