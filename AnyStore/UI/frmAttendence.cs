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
    public partial class frmAttendence : Form
    {
        string uu = "";
        public frmAttendence(string user_namef)
        {
            InitializeComponent();
            uu = user_namef;
        }
        userBLL u = new userBLL();
        userDAL dal = new userDAL();

        attendenceBLL y = new attendenceBLL();
        attendenceDAL z = new attendenceDAL();


        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAdminDashboard attends = new frmAdminDashboard();
            attends.FormClosed += new FormClosedEventHandler(splach_scr);
            attends.gr_us(uu);
            attends.Show();
        }
            private void splach_scr(object sender, EventArgs e)
            {
                this.Close();
            }

        private void LblNo_Click(object sender, EventArgs e)
        {

        }

        private void SplitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DgvData_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtId.Text = dgvData.Rows[rowIndex].Cells[0].Value.ToString();
            txtFname.Text = dgvData.Rows[rowIndex].Cells[1].Value.ToString();
            txtLname.Text = dgvData.Rows[rowIndex].Cells[2].Value.ToString();
            txtSubject.Text = dgvData.Rows[rowIndex].Cells[9].Value.ToString();
            txtGrade.Text = dgvData.Rows[rowIndex].Cells[10].Value.ToString();
            txtClass.Text = dgvData.Rows[rowIndex].Cells[11].Value.ToString();
        }

        private void FrmAttendence_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            dgvData.DataSource = dt;
        }
        private void clear()
        {
            txtId.Text = "";
            txtFname.Text = "";
            txtLname.Text = "";
            txtSubject.Text = "";
            txtGrade.Text = "";
            txtClass.Text = "";
            comboPresent.Text = "";

        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            y.id = txtId.Text;
            y.first_name = txtFname.Text;
            y.last_name = txtLname.Text;
            y.subject = txtSubject.Text;
            y.grade = txtGrade.Text;
            y.classs = txtClass.Text;
            y.present = comboPresent.Text;
            y.datee = DateTime.Now;

            bool success = z.InsertTo(y);
            bool success2 = z.InsertToAll(y);
            if (success == true && success2==true)
            {
                MessageBox.Show("User Successfully Inserted");
                clear();

            }
            else
            {
                MessageBox.Show("Failed to Add User.Try Again.");
            }
            /*DataTable dt = dal.Select();
            dgvData.DataSource = dt;*/
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            comboPresent. Visible= true;
            bool success = z.Delete(y);
            if(success==true)
            {
                MessageBox.Show("Successfully Removed");
                clear();
            }
            else
            {
                MessageBox.Show("Failed to remove");
            }
        }

        private void pnl3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTeaNo1_Click(object sender, EventArgs e)
        {

        }
    }
}
