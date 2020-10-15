namespace AnyStore.UI
{
    partial class frmSchoolDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSchoolDetails));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblProvince = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.RichTextBox();
            this.txtProvince = new System.Windows.Forms.TextBox();
            this.lblGrades = new System.Windows.Forms.Label();
            this.lblDivisions = new System.Windows.Forms.Label();
            this.lblTeachers = new System.Windows.Forms.Label();
            this.txtGrades = new System.Windows.Forms.TextBox();
            this.txtDivisions = new System.Windows.Forms.TextBox();
            this.txtTeachers = new System.Windows.Forms.TextBox();
            this.grpMain = new System.Windows.Forms.GroupBox();
            this.lblDivSub = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.grpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1247, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(12, 55);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(119, 32);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Name : ";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblAddress.Location = new System.Drawing.Point(12, 157);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(151, 32);
            this.lblAddress.TabIndex = 8;
            this.lblAddress.Text = "Address : ";
            // 
            // lblProvince
            // 
            this.lblProvince.AutoSize = true;
            this.lblProvince.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblProvince.Location = new System.Drawing.Point(12, 379);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(159, 32);
            this.lblProvince.TabIndex = 9;
            this.lblProvince.Text = "Province : ";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(172, 55);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(336, 32);
            this.txtName.TabIndex = 10;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(172, 157);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(336, 172);
            this.txtAddress.TabIndex = 11;
            this.txtAddress.Text = "";
            // 
            // txtProvince
            // 
            this.txtProvince.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProvince.Location = new System.Drawing.Point(172, 379);
            this.txtProvince.Multiline = true;
            this.txtProvince.Name = "txtProvince";
            this.txtProvince.Size = new System.Drawing.Size(336, 32);
            this.txtProvince.TabIndex = 12;
            // 
            // lblGrades
            // 
            this.lblGrades.AutoSize = true;
            this.lblGrades.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrades.Location = new System.Drawing.Point(599, 82);
            this.lblGrades.Name = "lblGrades";
            this.lblGrades.Size = new System.Drawing.Size(225, 32);
            this.lblGrades.TabIndex = 13;
            this.lblGrades.Text = "No Of Grades : ";
            // 
            // lblDivisions
            // 
            this.lblDivisions.AutoSize = true;
            this.lblDivisions.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDivisions.Location = new System.Drawing.Point(599, 190);
            this.lblDivisions.Name = "lblDivisions";
            this.lblDivisions.Size = new System.Drawing.Size(250, 32);
            this.lblDivisions.TabIndex = 14;
            this.lblDivisions.Text = "No Of Divisions : ";
            // 
            // lblTeachers
            // 
            this.lblTeachers.AutoSize = true;
            this.lblTeachers.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeachers.Location = new System.Drawing.Point(599, 297);
            this.lblTeachers.Name = "lblTeachers";
            this.lblTeachers.Size = new System.Drawing.Size(252, 32);
            this.lblTeachers.TabIndex = 15;
            this.lblTeachers.Text = "No Of Teachers : ";
            // 
            // txtGrades
            // 
            this.txtGrades.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrades.Location = new System.Drawing.Point(868, 82);
            this.txtGrades.Multiline = true;
            this.txtGrades.Name = "txtGrades";
            this.txtGrades.Size = new System.Drawing.Size(247, 32);
            this.txtGrades.TabIndex = 16;
            // 
            // txtDivisions
            // 
            this.txtDivisions.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDivisions.Location = new System.Drawing.Point(868, 190);
            this.txtDivisions.Multiline = true;
            this.txtDivisions.Name = "txtDivisions";
            this.txtDivisions.Size = new System.Drawing.Size(247, 32);
            this.txtDivisions.TabIndex = 17;
            // 
            // txtTeachers
            // 
            this.txtTeachers.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeachers.Location = new System.Drawing.Point(868, 297);
            this.txtTeachers.Multiline = true;
            this.txtTeachers.Name = "txtTeachers";
            this.txtTeachers.Size = new System.Drawing.Size(247, 32);
            this.txtTeachers.TabIndex = 18;
            // 
            // grpMain
            // 
            this.grpMain.Controls.Add(this.btnAdd);
            this.grpMain.Controls.Add(this.lblDivSub);
            this.grpMain.Controls.Add(this.txtProvince);
            this.grpMain.Controls.Add(this.txtTeachers);
            this.grpMain.Controls.Add(this.lblName);
            this.grpMain.Controls.Add(this.txtDivisions);
            this.grpMain.Controls.Add(this.lblAddress);
            this.grpMain.Controls.Add(this.txtGrades);
            this.grpMain.Controls.Add(this.lblProvince);
            this.grpMain.Controls.Add(this.lblTeachers);
            this.grpMain.Controls.Add(this.txtName);
            this.grpMain.Controls.Add(this.lblDivisions);
            this.grpMain.Controls.Add(this.txtAddress);
            this.grpMain.Controls.Add(this.lblGrades);
            this.grpMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMain.Location = new System.Drawing.Point(77, 52);
            this.grpMain.Name = "grpMain";
            this.grpMain.Size = new System.Drawing.Size(1128, 464);
            this.grpMain.TabIndex = 19;
            this.grpMain.TabStop = false;
            this.grpMain.Text = "School Details";
            // 
            // lblDivSub
            // 
            this.lblDivSub.AutoSize = true;
            this.lblDivSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDivSub.Location = new System.Drawing.Point(601, 222);
            this.lblDivSub.Name = "lblDivSub";
            this.lblDivSub.Size = new System.Drawing.Size(156, 20);
            this.lblDivSub.TabIndex = 20;
            this.lblDivSub.Text = "(For a single grade)";
            this.lblDivSub.Click += new System.EventHandler(this.lblDivSub_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(986, 379);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(129, 45);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmSchoolDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 556);
            this.Controls.Add(this.grpMain);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSchoolDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSchoolDetails";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.grpMain.ResumeLayout(false);
            this.grpMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.RichTextBox txtAddress;
        private System.Windows.Forms.TextBox txtProvince;
        private System.Windows.Forms.Label lblGrades;
        private System.Windows.Forms.Label lblDivisions;
        private System.Windows.Forms.Label lblTeachers;
        private System.Windows.Forms.TextBox txtGrades;
        private System.Windows.Forms.TextBox txtDivisions;
        private System.Windows.Forms.TextBox txtTeachers;
        private System.Windows.Forms.GroupBox grpMain;
        private System.Windows.Forms.Label lblDivSub;
        private System.Windows.Forms.Button btnAdd;
    }
}