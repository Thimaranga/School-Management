namespace AnyStore.UI
{
    partial class frmUniversityDashboard
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
            this.AdminToolStripMenuItem = new System.Windows.Forms.MenuStrip();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnladminfooter = new System.Windows.Forms.Panel();
            this.lbladminfooter = new System.Windows.Forms.Label();
            this.AdminToolStripMenuItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnladminfooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdminToolStripMenuItem
            // 
            this.AdminToolStripMenuItem.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.AdminToolStripMenuItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.categoryToolStripMenuItem,
            this.productsToolStripMenuItem,
            this.inventoryToolStripMenuItem});
            this.AdminToolStripMenuItem.Location = new System.Drawing.Point(0, 0);
            this.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem";
            this.AdminToolStripMenuItem.Size = new System.Drawing.Size(1467, 28);
            this.AdminToolStripMenuItem.TabIndex = 2;
            this.AdminToolStripMenuItem.Text = "menuStrip1";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.usersToolStripMenuItem.Text = "lecturers";
            // 
            // categoryToolStripMenuItem
            // 
            this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            this.categoryToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.categoryToolStripMenuItem.Text = "Attendence";
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.productsToolStripMenuItem.Text = "Time Tables";
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.inventoryToolStripMenuItem.Text = "Halls";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::AnyStore.Properties.Resources._19276;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(877, 519);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(0, 54);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1467, 544);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // pnladminfooter
            // 
            this.pnladminfooter.AccessibleName = "";
            this.pnladminfooter.BackColor = System.Drawing.Color.Teal;
            this.pnladminfooter.Controls.Add(this.lbladminfooter);
            this.pnladminfooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnladminfooter.Location = new System.Drawing.Point(0, 633);
            this.pnladminfooter.Name = "pnladminfooter";
            this.pnladminfooter.Size = new System.Drawing.Size(1467, 42);
            this.pnladminfooter.TabIndex = 20;
            this.pnladminfooter.Tag = "";
            // 
            // lbladminfooter
            // 
            this.lbladminfooter.AutoSize = true;
            this.lbladminfooter.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladminfooter.ForeColor = System.Drawing.Color.White;
            this.lbladminfooter.Location = new System.Drawing.Point(849, 0);
            this.lbladminfooter.Name = "lbladminfooter";
            this.lbladminfooter.Size = new System.Drawing.Size(279, 36);
            this.lbladminfooter.TabIndex = 0;
            this.lbladminfooter.Text = "P A Labs Presents";
            // 
            // frmUniversityDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 675);
            this.Controls.Add(this.pnladminfooter);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.AdminToolStripMenuItem);
            this.Name = "frmUniversityDashboard";
            this.Text = "frmUniversityDashboard";
            this.Load += new System.EventHandler(this.FrmUniversityDashboard_Load);
            this.AdminToolStripMenuItem.ResumeLayout(false);
            this.AdminToolStripMenuItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnladminfooter.ResumeLayout(false);
            this.pnladminfooter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip AdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel pnladminfooter;
        private System.Windows.Forms.Label lbladminfooter;
    }
}