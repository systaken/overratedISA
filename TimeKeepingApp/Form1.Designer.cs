namespace TimeKeepingApp
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.lbltime = new System.Windows.Forms.Label();
            this.lblstudentname = new System.Windows.Forms.Label();
            this.txtcardno = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblGlevel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblstats = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblcardno = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1340, 238);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 454);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Card No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(109, 518);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Student Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(109, 386);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(109, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "Date";
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.Location = new System.Drawing.Point(225, 316);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(79, 32);
            this.lbldate.TabIndex = 5;
            this.lbldate.Text = "Date";
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltime.Location = new System.Drawing.Point(229, 386);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(82, 32);
            this.lbltime.TabIndex = 6;
            this.lbltime.Text = "Time";
            // 
            // lblstudentname
            // 
            this.lblstudentname.AutoSize = true;
            this.lblstudentname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstudentname.Location = new System.Drawing.Point(359, 518);
            this.lblstudentname.Name = "lblstudentname";
            this.lblstudentname.Size = new System.Drawing.Size(0, 32);
            this.lblstudentname.TabIndex = 7;
            // 
            // txtcardno
            // 
            this.txtcardno.AllowDrop = true;
            this.txtcardno.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcardno.Location = new System.Drawing.Point(616, 183);
            this.txtcardno.Name = "txtcardno";
            this.txtcardno.Size = new System.Drawing.Size(308, 38);
            this.txtcardno.TabIndex = 8;
            this.txtcardno.Enter += new System.EventHandler(this.txtcardno_Enter);
            this.txtcardno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcardno_KeyPress);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblGlevel
            // 
            this.lblGlevel.AutoSize = true;
            this.lblGlevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGlevel.Location = new System.Drawing.Point(359, 566);
            this.lblGlevel.Name = "lblGlevel";
            this.lblGlevel.Size = new System.Drawing.Size(0, 32);
            this.lblGlevel.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(109, 566);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 32);
            this.label6.TabIndex = 9;
            this.label6.Text = "Level";
            // 
            // lblstats
            // 
            this.lblstats.AutoSize = true;
            this.lblstats.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstats.Location = new System.Drawing.Point(359, 627);
            this.lblstats.Name = "lblstats";
            this.lblstats.Size = new System.Drawing.Size(0, 32);
            this.lblstats.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(109, 627);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 32);
            this.label7.TabIndex = 11;
            this.label7.Text = "Status";
            // 
            // lblcardno
            // 
            this.lblcardno.AutoSize = true;
            this.lblcardno.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcardno.Location = new System.Drawing.Point(359, 454);
            this.lblcardno.Name = "lblcardno";
            this.lblcardno.Size = new System.Drawing.Size(32, 32);
            this.lblcardno.TabIndex = 13;
            this.lblcardno.Text = "0";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 5000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 815);
            this.Controls.Add(this.lblcardno);
            this.Controls.Add(this.lblstats);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblGlevel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblstudentname);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtcardno);
            this.Name = "Form1";
            this.Text = "TimeKeeping";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Label lblstudentname;
        private System.Windows.Forms.TextBox txtcardno;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblGlevel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblstats;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblcardno;
        private System.Windows.Forms.Timer timer2;
    }
}

