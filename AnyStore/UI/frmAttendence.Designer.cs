namespace AnyStore.UI
{
    partial class frmAttendence
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAttendence));
            this.lbltop = new System.Windows.Forms.Label();
            this.pnl3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox19 = new System.Windows.Forms.ComboBox();
            this.comboBox20 = new System.Windows.Forms.ComboBox();
            this.comboBox21 = new System.Windows.Forms.ComboBox();
            this.comboBox22 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.lblfName = new System.Windows.Forms.Label();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.lbllName = new System.Windows.Forms.Label();
            this.lblPresent = new System.Windows.Forms.Label();
            this.comboPresent = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.lblGrade = new System.Windows.Forms.Label();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.pnl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltop
            // 
            this.lbltop.AutoSize = true;
            this.lbltop.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltop.Location = new System.Drawing.Point(499, 1);
            this.lbltop.Name = "lbltop";
            this.lbltop.Size = new System.Drawing.Size(134, 29);
            this.lbltop.TabIndex = 0;
            this.lbltop.Text = "Attendence";
            // 
            // pnl3
            // 
            this.pnl3.BackColor = System.Drawing.Color.CadetBlue;
            this.pnl3.Controls.Add(this.pictureBox1);
            this.pnl3.Controls.Add(this.lbltop);
            this.pnl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl3.Location = new System.Drawing.Point(0, 0);
            this.pnl3.Name = "pnl3";
            this.pnl3.Size = new System.Drawing.Size(1316, 35);
            this.pnl3.TabIndex = 2;
            this.pnl3.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl3_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1280, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // comboBox19
            // 
            this.comboBox19.FormattingEnabled = true;
            this.comboBox19.Location = new System.Drawing.Point(1009, 1096);
            this.comboBox19.Name = "comboBox19";
            this.comboBox19.Size = new System.Drawing.Size(149, 24);
            this.comboBox19.TabIndex = 75;
            // 
            // comboBox20
            // 
            this.comboBox20.FormattingEnabled = true;
            this.comboBox20.Location = new System.Drawing.Point(1009, 1066);
            this.comboBox20.Name = "comboBox20";
            this.comboBox20.Size = new System.Drawing.Size(149, 24);
            this.comboBox20.TabIndex = 74;
            // 
            // comboBox21
            // 
            this.comboBox21.FormattingEnabled = true;
            this.comboBox21.Location = new System.Drawing.Point(1009, 1036);
            this.comboBox21.Name = "comboBox21";
            this.comboBox21.Size = new System.Drawing.Size(149, 24);
            this.comboBox21.TabIndex = 73;
            // 
            // comboBox22
            // 
            this.comboBox22.FormattingEnabled = true;
            this.comboBox22.Location = new System.Drawing.Point(1009, 1006);
            this.comboBox22.Name = "comboBox22";
            this.comboBox22.Size = new System.Drawing.Size(149, 24);
            this.comboBox22.TabIndex = 72;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(81, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 31);
            this.label7.TabIndex = 91;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(81, 147);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(146, 31);
            this.label11.TabIndex = 95;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(654, 187);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(185, 31);
            this.label13.TabIndex = 101;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(245, 187);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(378, 31);
            this.label14.TabIndex = 100;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(81, 187);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(146, 31);
            this.label15.TabIndex = 99;
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(654, 227);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(185, 31);
            this.label17.TabIndex = 105;
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(245, 227);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(378, 31);
            this.label18.TabIndex = 104;
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(81, 227);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(146, 31);
            this.label19.TabIndex = 103;
            // 
            // label21
            // 
            this.label21.Location = new System.Drawing.Point(654, 268);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(185, 31);
            this.label21.TabIndex = 109;
            // 
            // label22
            // 
            this.label22.Location = new System.Drawing.Point(245, 268);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(378, 31);
            this.label22.TabIndex = 108;
            // 
            // label23
            // 
            this.label23.Location = new System.Drawing.Point(81, 268);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(146, 31);
            this.label23.TabIndex = 107;
            // 
            // label25
            // 
            this.label25.Location = new System.Drawing.Point(654, 307);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(185, 31);
            this.label25.TabIndex = 113;
            // 
            // label26
            // 
            this.label26.Location = new System.Drawing.Point(245, 307);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(378, 31);
            this.label26.TabIndex = 112;
            // 
            // label27
            // 
            this.label27.Location = new System.Drawing.Point(81, 307);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(146, 31);
            this.label27.TabIndex = 111;
            // 
            // label29
            // 
            this.label29.Location = new System.Drawing.Point(654, 348);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(185, 31);
            this.label29.TabIndex = 117;
            // 
            // label30
            // 
            this.label30.Location = new System.Drawing.Point(245, 348);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(378, 31);
            this.label30.TabIndex = 116;
            // 
            // label31
            // 
            this.label31.Location = new System.Drawing.Point(81, 348);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(146, 31);
            this.label31.TabIndex = 115;
            // 
            // label41
            // 
            this.label41.Location = new System.Drawing.Point(654, 627);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(185, 31);
            this.label41.TabIndex = 145;
            // 
            // label42
            // 
            this.label42.Location = new System.Drawing.Point(245, 627);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(378, 31);
            this.label42.TabIndex = 144;
            // 
            // label43
            // 
            this.label43.Location = new System.Drawing.Point(81, 627);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(146, 31);
            this.label43.TabIndex = 143;
            // 
            // label45
            // 
            this.label45.Location = new System.Drawing.Point(654, 586);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(185, 31);
            this.label45.TabIndex = 141;
            // 
            // label46
            // 
            this.label46.Location = new System.Drawing.Point(245, 586);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(378, 31);
            this.label46.TabIndex = 140;
            // 
            // label47
            // 
            this.label47.Location = new System.Drawing.Point(81, 586);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(146, 31);
            this.label47.TabIndex = 139;
            // 
            // label49
            // 
            this.label49.Location = new System.Drawing.Point(654, 546);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(185, 31);
            this.label49.TabIndex = 137;
            // 
            // label50
            // 
            this.label50.Location = new System.Drawing.Point(245, 546);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(378, 31);
            this.label50.TabIndex = 136;
            // 
            // label51
            // 
            this.label51.Location = new System.Drawing.Point(81, 546);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(146, 31);
            this.label51.TabIndex = 135;
            // 
            // label53
            // 
            this.label53.Location = new System.Drawing.Point(654, 506);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(185, 31);
            this.label53.TabIndex = 133;
            // 
            // label54
            // 
            this.label54.Location = new System.Drawing.Point(245, 506);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(378, 31);
            this.label54.TabIndex = 132;
            // 
            // label55
            // 
            this.label55.Location = new System.Drawing.Point(81, 506);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(146, 31);
            this.label55.TabIndex = 131;
            // 
            // label57
            // 
            this.label57.Location = new System.Drawing.Point(654, 466);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(185, 31);
            this.label57.TabIndex = 129;
            // 
            // label58
            // 
            this.label58.Location = new System.Drawing.Point(245, 466);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(378, 31);
            this.label58.TabIndex = 128;
            // 
            // label59
            // 
            this.label59.Location = new System.Drawing.Point(81, 466);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(146, 31);
            this.label59.TabIndex = 127;
            // 
            // label61
            // 
            this.label61.Location = new System.Drawing.Point(654, 427);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(185, 31);
            this.label61.TabIndex = 125;
            // 
            // label62
            // 
            this.label62.Location = new System.Drawing.Point(245, 427);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(378, 31);
            this.label62.TabIndex = 124;
            // 
            // label63
            // 
            this.label63.Location = new System.Drawing.Point(81, 427);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(146, 31);
            this.label63.TabIndex = 123;
            // 
            // label65
            // 
            this.label65.Location = new System.Drawing.Point(654, 387);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(185, 31);
            this.label65.TabIndex = 121;
            // 
            // label66
            // 
            this.label66.Location = new System.Drawing.Point(245, 387);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(378, 31);
            this.label66.TabIndex = 120;
            // 
            // label67
            // 
            this.label67.Location = new System.Drawing.Point(81, 387);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(146, 31);
            this.label67.TabIndex = 119;
            // 
            // label33
            // 
            this.label33.Location = new System.Drawing.Point(654, 664);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(185, 31);
            this.label33.TabIndex = 149;
            // 
            // label34
            // 
            this.label34.Location = new System.Drawing.Point(245, 664);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(378, 31);
            this.label34.TabIndex = 148;
            // 
            // label35
            // 
            this.label35.Location = new System.Drawing.Point(81, 664);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(146, 31);
            this.label35.TabIndex = 147;
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(26, 59);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.RowTemplate.Height = 24;
            this.dgvData.Size = new System.Drawing.Size(996, 518);
            this.dgvData.TabIndex = 150;
            this.dgvData.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvData_RowHeaderMouseClick);
            // 
            // lblfName
            // 
            this.lblfName.AutoSize = true;
            this.lblfName.Location = new System.Drawing.Point(1046, 220);
            this.lblfName.Name = "lblfName";
            this.lblfName.Size = new System.Drawing.Size(76, 17);
            this.lblfName.TabIndex = 151;
            this.lblfName.Text = "First Name";
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(1144, 217);
            this.txtFname.Name = "txtFname";
            this.txtFname.ReadOnly = true;
            this.txtFname.Size = new System.Drawing.Size(151, 22);
            this.txtFname.TabIndex = 152;
            // 
            // txtLname
            // 
            this.txtLname.Location = new System.Drawing.Point(1144, 269);
            this.txtLname.Name = "txtLname";
            this.txtLname.ReadOnly = true;
            this.txtLname.Size = new System.Drawing.Size(151, 22);
            this.txtLname.TabIndex = 154;
            // 
            // lbllName
            // 
            this.lbllName.AutoSize = true;
            this.lbllName.Location = new System.Drawing.Point(1046, 272);
            this.lbllName.Name = "lbllName";
            this.lbllName.Size = new System.Drawing.Size(76, 17);
            this.lbllName.TabIndex = 153;
            this.lbllName.Text = "Last Name";
            // 
            // lblPresent
            // 
            this.lblPresent.AutoSize = true;
            this.lblPresent.Location = new System.Drawing.Point(1046, 484);
            this.lblPresent.Name = "lblPresent";
            this.lblPresent.Size = new System.Drawing.Size(57, 17);
            this.lblPresent.TabIndex = 155;
            this.lblPresent.Text = "Present";
            // 
            // comboPresent
            // 
            this.comboPresent.FormattingEnabled = true;
            this.comboPresent.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.comboPresent.Location = new System.Drawing.Point(1144, 479);
            this.comboPresent.Name = "comboPresent";
            this.comboPresent.Size = new System.Drawing.Size(151, 24);
            this.comboPresent.TabIndex = 156;
            this.comboPresent.Visible = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(1200, 543);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(95, 34);
            this.btnSubmit.TabIndex = 157;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(1144, 320);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.ReadOnly = true;
            this.txtSubject.Size = new System.Drawing.Size(151, 22);
            this.txtSubject.TabIndex = 159;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(1046, 323);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(55, 17);
            this.lblSubject.TabIndex = 158;
            this.lblSubject.Text = "Subject";
            // 
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(1144, 372);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.ReadOnly = true;
            this.txtGrade.Size = new System.Drawing.Size(151, 22);
            this.txtGrade.TabIndex = 161;
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(1046, 375);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(48, 17);
            this.lblGrade.TabIndex = 160;
            this.lblGrade.Text = "Grade";
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(1144, 428);
            this.txtClass.Name = "txtClass";
            this.txtClass.ReadOnly = true;
            this.txtClass.Size = new System.Drawing.Size(151, 22);
            this.txtClass.TabIndex = 163;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(1046, 431);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(42, 17);
            this.lblClass.TabIndex = 162;
            this.lblClass.Text = "Class";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(1144, 162);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(151, 22);
            this.txtId.TabIndex = 165;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(1046, 165);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 17);
            this.lblId.TabIndex = 164;
            this.lblId.Text = "ID";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(1033, 76);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(262, 42);
            this.btnClear.TabIndex = 166;
            this.btnClear.Text = "Clear Previous Attendence";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmAttendence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 603);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.comboPresent);
            this.Controls.Add(this.lblPresent);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(this.lbllName);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.lblfName);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.label42);
            this.Controls.Add(this.label43);
            this.Controls.Add(this.label45);
            this.Controls.Add(this.label46);
            this.Controls.Add(this.label47);
            this.Controls.Add(this.label49);
            this.Controls.Add(this.label50);
            this.Controls.Add(this.label51);
            this.Controls.Add(this.label53);
            this.Controls.Add(this.label54);
            this.Controls.Add(this.label55);
            this.Controls.Add(this.label57);
            this.Controls.Add(this.label58);
            this.Controls.Add(this.label59);
            this.Controls.Add(this.label61);
            this.Controls.Add(this.label62);
            this.Controls.Add(this.label63);
            this.Controls.Add(this.label65);
            this.Controls.Add(this.label66);
            this.Controls.Add(this.label67);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox19);
            this.Controls.Add(this.comboBox20);
            this.Controls.Add(this.comboBox21);
            this.Controls.Add(this.comboBox22);
            this.Controls.Add(this.pnl3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAttendence";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmAttendence_Load);
            this.pnl3.ResumeLayout(false);
            this.pnl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbltop;
        private System.Windows.Forms.Panel pnl3;
        private System.Windows.Forms.ComboBox comboBox19;
        private System.Windows.Forms.ComboBox comboBox20;
        private System.Windows.Forms.ComboBox comboBox21;
        private System.Windows.Forms.ComboBox comboBox22;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Label lblfName;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.Label lbllName;
        private System.Windows.Forms.Label lblPresent;
        private System.Windows.Forms.ComboBox comboPresent;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnClear;
    }
}