namespace ISAManagement.Info
{
    partial class StudentProfileFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentProfileFrm));
            this.lblmeid = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.lblmemid = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtfax = new System.Windows.Forms.TextBox();
            this.txttel = new System.Windows.Forms.TextBox();
            this.txtadd3 = new System.Windows.Forms.TextBox();
            this.txtadd2 = new System.Windows.Forms.TextBox();
            this.txtadd1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtBdate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.txtmid = new System.Windows.Forms.TextBox();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textResponse = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.txtstudentNos = new System.Windows.Forms.TextBox();
            this.txtguardian = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtrfid = new System.Windows.Forms.TextBox();
            this.ddLevel = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ddsection = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lblrecid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblmeid
            // 
            this.lblmeid.AutoSize = true;
            this.lblmeid.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmeid.Location = new System.Drawing.Point(53, 57);
            this.lblmeid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmeid.Name = "lblmeid";
            this.lblmeid.Size = new System.Drawing.Size(89, 19);
            this.lblmeid.TabIndex = 81;
            this.lblmeid.Text = "Student No";
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(719, 563);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 36);
            this.button2.TabIndex = 19;
            this.button2.Text = "Cancel";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnsave
            // 
            this.btnsave.Image = ((System.Drawing.Image)(resources.GetObject("btnsave.Image")));
            this.btnsave.Location = new System.Drawing.Point(588, 563);
            this.btnsave.Margin = new System.Windows.Forms.Padding(4);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(112, 36);
            this.btnsave.TabIndex = 18;
            this.btnsave.Text = "Save";
            this.btnsave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // lblmemid
            // 
            this.lblmemid.AutoSize = true;
            this.lblmemid.Location = new System.Drawing.Point(52, 72);
            this.lblmemid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmemid.Name = "lblmemid";
            this.lblmemid.Size = new System.Drawing.Size(0, 17);
            this.lblmemid.TabIndex = 77;
            this.lblmemid.Visible = false;
            // 
            // cmbGender
            // 
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.ItemHeight = 19;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(217, 153);
            this.cmbGender.Margin = new System.Windows.Forms.Padding(4);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(260, 27);
            this.cmbGender.TabIndex = 76;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(53, 155);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(63, 19);
            this.label17.TabIndex = 75;
            this.label17.Text = "Gender";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(876, 88);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 223);
            this.pictureBox1.TabIndex = 73;
            this.pictureBox1.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(631, 125);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 16);
            this.label13.TabIndex = 71;
            this.label13.Text = "Middle Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(425, 125);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 16);
            this.label12.TabIndex = 70;
            this.label12.Text = "First Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(217, 125);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 16);
            this.label11.TabIndex = 69;
            this.label11.Text = "Last Name";
            // 
            // txtemail
            // 
            this.txtemail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtemail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtemail.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(217, 474);
            this.txtemail.Margin = new System.Windows.Forms.Padding(4);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(260, 27);
            this.txtemail.TabIndex = 15;
            // 
            // txtfax
            // 
            this.txtfax.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtfax.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtfax.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfax.Location = new System.Drawing.Point(588, 435);
            this.txtfax.Margin = new System.Windows.Forms.Padding(4);
            this.txtfax.Name = "txtfax";
            this.txtfax.Size = new System.Drawing.Size(240, 27);
            this.txtfax.TabIndex = 14;
            // 
            // txttel
            // 
            this.txttel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txttel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txttel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttel.Location = new System.Drawing.Point(217, 435);
            this.txttel.Margin = new System.Windows.Forms.Padding(4);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(260, 27);
            this.txttel.TabIndex = 13;
            // 
            // txtadd3
            // 
            this.txtadd3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtadd3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtadd3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtadd3.Location = new System.Drawing.Point(217, 307);
            this.txtadd3.Margin = new System.Windows.Forms.Padding(4);
            this.txtadd3.Name = "txtadd3";
            this.txtadd3.Size = new System.Drawing.Size(607, 27);
            this.txtadd3.TabIndex = 9;
            // 
            // txtadd2
            // 
            this.txtadd2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtadd2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtadd2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtadd2.Location = new System.Drawing.Point(217, 270);
            this.txtadd2.Margin = new System.Windows.Forms.Padding(4);
            this.txtadd2.Name = "txtadd2";
            this.txtadd2.Size = new System.Drawing.Size(607, 27);
            this.txtadd2.TabIndex = 8;
            // 
            // txtadd1
            // 
            this.txtadd1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtadd1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtadd1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtadd1.Location = new System.Drawing.Point(217, 232);
            this.txtadd1.Margin = new System.Windows.Forms.Padding(4);
            this.txtadd1.Name = "txtadd1";
            this.txtadd1.Size = new System.Drawing.Size(607, 27);
            this.txtadd1.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(53, 478);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 19);
            this.label9.TabIndex = 68;
            this.label9.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(493, 439);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 19);
            this.label8.TabIndex = 67;
            this.label8.Text = "Other Nos.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(53, 439);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 19);
            this.label7.TabIndex = 65;
            this.label7.Text = "Tel No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(53, 311);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 19);
            this.label6.TabIndex = 64;
            this.label6.Text = "Address 3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 274);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 19);
            this.label5.TabIndex = 62;
            this.label5.Text = "Address 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 236);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 19);
            this.label4.TabIndex = 61;
            this.label4.Text = "Address 1";
            // 
            // dtBdate
            // 
            this.dtBdate.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtBdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBdate.Location = new System.Drawing.Point(217, 193);
            this.dtBdate.Margin = new System.Windows.Forms.Padding(4);
            this.dtBdate.Name = "dtBdate";
            this.dtBdate.Size = new System.Drawing.Size(260, 27);
            this.dtBdate.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 197);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 19);
            this.label3.TabIndex = 57;
            this.label3.Text = "Birthdate";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.newToolStripButton.Text = "&New";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(24, 24);
            this.saveToolStripButton.Text = "&Save";
            // 
            // txtmid
            // 
            this.txtmid.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtmid.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtmid.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmid.Location = new System.Drawing.Point(635, 93);
            this.txtmid.Margin = new System.Windows.Forms.Padding(4);
            this.txtmid.Name = "txtmid";
            this.txtmid.Size = new System.Drawing.Size(195, 27);
            this.txtmid.TabIndex = 4;
            // 
            // txtfname
            // 
            this.txtfname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtfname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtfname.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfname.Location = new System.Drawing.Point(428, 93);
            this.txtfname.Margin = new System.Windows.Forms.Padding(4);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(195, 27);
            this.txtfname.TabIndex = 3;
            // 
            // txtlname
            // 
            this.txtlname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtlname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtlname.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlname.Location = new System.Drawing.Point(217, 93);
            this.txtlname.Margin = new System.Windows.Forms.Padding(4);
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(195, 27);
            this.txtlname.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 51;
            this.label1.Text = "Name";
            // 
            // textResponse
            // 
            this.textResponse.Location = new System.Drawing.Point(876, 326);
            this.textResponse.Margin = new System.Windows.Forms.Padding(4);
            this.textResponse.Name = "textResponse";
            this.textResponse.Size = new System.Drawing.Size(241, 22);
            this.textResponse.TabIndex = 48;
            this.textResponse.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(951, 381);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 47;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.saveToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1286, 27);
            this.toolStrip1.TabIndex = 46;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.Visible = false;
            // 
            // txtstudentNos
            // 
            this.txtstudentNos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtstudentNos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtstudentNos.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstudentNos.Location = new System.Drawing.Point(217, 54);
            this.txtstudentNos.Margin = new System.Windows.Forms.Padding(4);
            this.txtstudentNos.Name = "txtstudentNos";
            this.txtstudentNos.Size = new System.Drawing.Size(195, 27);
            this.txtstudentNos.TabIndex = 1;
            // 
            // txtguardian
            // 
            this.txtguardian.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtguardian.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtguardian.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtguardian.Location = new System.Drawing.Point(217, 390);
            this.txtguardian.Margin = new System.Windows.Forms.Padding(4);
            this.txtguardian.Name = "txtguardian";
            this.txtguardian.Size = new System.Drawing.Size(613, 27);
            this.txtguardian.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 394);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 19);
            this.label2.TabIndex = 85;
            this.label2.Text = "Guardinan Name";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(53, 517);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 19);
            this.label16.TabIndex = 74;
            this.label16.Text = "RFID";
            // 
            // txtrfid
            // 
            this.txtrfid.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtrfid.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtrfid.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrfid.Location = new System.Drawing.Point(217, 517);
            this.txtrfid.Margin = new System.Windows.Forms.Padding(4);
            this.txtrfid.Name = "txtrfid";
            this.txtrfid.Size = new System.Drawing.Size(260, 27);
            this.txtrfid.TabIndex = 16;
            // 
            // ddLevel
            // 
            this.ddLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddLevel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddLevel.FormattingEnabled = true;
            this.ddLevel.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.ddLevel.Location = new System.Drawing.Point(217, 344);
            this.ddLevel.Margin = new System.Windows.Forms.Padding(4);
            this.ddLevel.Name = "ddLevel";
            this.ddLevel.Size = new System.Drawing.Size(195, 27);
            this.ddLevel.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(53, 348);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 19);
            this.label10.TabIndex = 87;
            this.label10.Text = "Level";
            // 
            // ddsection
            // 
            this.ddsection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddsection.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddsection.FormattingEnabled = true;
            this.ddsection.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.ddsection.Location = new System.Drawing.Point(629, 344);
            this.ddsection.Margin = new System.Windows.Forms.Padding(4);
            this.ddsection.Name = "ddsection";
            this.ddsection.Size = new System.Drawing.Size(195, 27);
            this.ddsection.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(504, 348);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 19);
            this.label14.TabIndex = 89;
            this.label14.Text = "Section";
            // 
            // lblrecid
            // 
            this.lblrecid.AutoSize = true;
            this.lblrecid.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrecid.Location = new System.Drawing.Point(53, 24);
            this.lblrecid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblrecid.Name = "lblrecid";
            this.lblrecid.Size = new System.Drawing.Size(0, 19);
            this.lblrecid.TabIndex = 91;
            this.lblrecid.Visible = false;
            // 
            // StudentProfileFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 664);
            this.Controls.Add(this.lblrecid);
            this.Controls.Add(this.ddsection);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.ddLevel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtrfid);
            this.Controls.Add(this.txtguardian);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtstudentNos);
            this.Controls.Add(this.lblmeid);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.lblmemid);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtfax);
            this.Controls.Add(this.txttel);
            this.Controls.Add(this.txtadd3);
            this.Controls.Add(this.txtadd2);
            this.Controls.Add(this.txtadd1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtBdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtmid);
            this.Controls.Add(this.txtfname);
            this.Controls.Add(this.txtlname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textResponse);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "StudentProfileFrm";
            this.Text = "Student Profile";
            this.Load += new System.EventHandler(this.StudentProfileFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblmeid;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label lblmemid;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtfax;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.TextBox txtadd3;
        private System.Windows.Forms.TextBox txtadd2;
        private System.Windows.Forms.TextBox txtadd1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtBdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.TextBox txtmid;
        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.TextBox txtlname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textResponse;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TextBox txtstudentNos;
        private System.Windows.Forms.TextBox txtguardian;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtrfid;
        private System.Windows.Forms.ComboBox ddLevel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox ddsection;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblrecid;
    }
}