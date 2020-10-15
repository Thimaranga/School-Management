namespace AnyStore.UI
{
    partial class timetableDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(timetableDashboard));
            this.pnl3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbltop = new System.Windows.Forms.Label();
            this.grpAdd = new System.Windows.Forms.GroupBox();
            this.btnTeachersAdd = new System.Windows.Forms.Button();
            this.btnClassesAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTeachersView = new System.Windows.Forms.Button();
            this.btnClassesView = new System.Windows.Forms.Button();
            this.pnl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpAdd.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl3
            // 
            this.pnl3.BackColor = System.Drawing.Color.Gray;
            this.pnl3.Controls.Add(this.pictureBox2);
            this.pnl3.Controls.Add(this.pictureBox1);
            this.pnl3.Controls.Add(this.lbltop);
            this.pnl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl3.Location = new System.Drawing.Point(0, 0);
            this.pnl3.Name = "pnl3";
            this.pnl3.Size = new System.Drawing.Size(1300, 35);
            this.pnl3.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1262, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1498, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lbltop
            // 
            this.lbltop.AutoSize = true;
            this.lbltop.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltop.Location = new System.Drawing.Point(584, 2);
            this.lbltop.Name = "lbltop";
            this.lbltop.Size = new System.Drawing.Size(150, 29);
            this.lbltop.TabIndex = 0;
            this.lbltop.Text = "Time Tables";
            this.lbltop.Click += new System.EventHandler(this.lbltop_Click);
            // 
            // grpAdd
            // 
            this.grpAdd.Controls.Add(this.btnTeachersAdd);
            this.grpAdd.Controls.Add(this.btnClassesAdd);
            this.grpAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAdd.Location = new System.Drawing.Point(12, 82);
            this.grpAdd.Name = "grpAdd";
            this.grpAdd.Size = new System.Drawing.Size(610, 471);
            this.grpAdd.TabIndex = 5;
            this.grpAdd.TabStop = false;
            this.grpAdd.Text = "Add Time Tables";
            // 
            // btnTeachersAdd
            // 
            this.btnTeachersAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeachersAdd.Location = new System.Drawing.Point(101, 300);
            this.btnTeachersAdd.Name = "btnTeachersAdd";
            this.btnTeachersAdd.Size = new System.Drawing.Size(420, 67);
            this.btnTeachersAdd.TabIndex = 1;
            this.btnTeachersAdd.Text = "Teachers Time Tables";
            this.btnTeachersAdd.UseVisualStyleBackColor = true;
            this.btnTeachersAdd.Click += new System.EventHandler(this.btnTeachersAdd_Click);
            // 
            // btnClassesAdd
            // 
            this.btnClassesAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClassesAdd.Location = new System.Drawing.Point(101, 151);
            this.btnClassesAdd.Name = "btnClassesAdd";
            this.btnClassesAdd.Size = new System.Drawing.Size(420, 67);
            this.btnClassesAdd.TabIndex = 0;
            this.btnClassesAdd.Text = "Classes Time Tables";
            this.btnClassesAdd.UseVisualStyleBackColor = true;
            this.btnClassesAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTeachersView);
            this.groupBox1.Controls.Add(this.btnClassesView);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(685, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(610, 471);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "View Time Tables";
            // 
            // btnTeachersView
            // 
            this.btnTeachersView.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeachersView.Location = new System.Drawing.Point(47, 300);
            this.btnTeachersView.Name = "btnTeachersView";
            this.btnTeachersView.Size = new System.Drawing.Size(420, 67);
            this.btnTeachersView.TabIndex = 3;
            this.btnTeachersView.Text = "Teachers Time Tables";
            this.btnTeachersView.UseVisualStyleBackColor = true;
            this.btnTeachersView.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnClassesView
            // 
            this.btnClassesView.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClassesView.Location = new System.Drawing.Point(47, 151);
            this.btnClassesView.Name = "btnClassesView";
            this.btnClassesView.Size = new System.Drawing.Size(420, 67);
            this.btnClassesView.TabIndex = 2;
            this.btnClassesView.Text = "Classes Time Tables";
            this.btnClassesView.UseVisualStyleBackColor = true;
            this.btnClassesView.Click += new System.EventHandler(this.btnClassesView_Click);
            // 
            // timetableDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 603);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpAdd);
            this.Controls.Add(this.pnl3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "timetableDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "timetableDashboard";
            this.pnl3.ResumeLayout(false);
            this.pnl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpAdd.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbltop;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox grpAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTeachersAdd;
        private System.Windows.Forms.Button btnClassesAdd;
        private System.Windows.Forms.Button btnTeachersView;
        private System.Windows.Forms.Button btnClassesView;
    }
}