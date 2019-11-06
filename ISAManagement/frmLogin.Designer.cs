namespace ISAManagement
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.lblmsg = new System.Windows.Forms.Label();
            this.lblgid = new System.Windows.Forms.Label();
            this.lbluseid = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnlgin = new System.Windows.Forms.Button();
            this.txtpwd = new System.Windows.Forms.TextBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblmsg
            // 
            this.lblmsg.AutoSize = true;
            this.lblmsg.BackColor = System.Drawing.Color.Transparent;
            this.lblmsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmsg.ForeColor = System.Drawing.Color.Red;
            this.lblmsg.Location = new System.Drawing.Point(190, 16);
            this.lblmsg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(0, 20);
            this.lblmsg.TabIndex = 17;
            this.lblmsg.Visible = false;
            // 
            // lblgid
            // 
            this.lblgid.AutoSize = true;
            this.lblgid.BackColor = System.Drawing.Color.Transparent;
            this.lblgid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgid.Location = new System.Drawing.Point(222, 158);
            this.lblgid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblgid.Name = "lblgid";
            this.lblgid.Size = new System.Drawing.Size(0, 20);
            this.lblgid.TabIndex = 16;
            this.lblgid.Visible = false;
            // 
            // lbluseid
            // 
            this.lbluseid.AutoSize = true;
            this.lbluseid.BackColor = System.Drawing.Color.Transparent;
            this.lbluseid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluseid.Location = new System.Drawing.Point(206, 138);
            this.lbluseid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbluseid.Name = "lbluseid";
            this.lbluseid.Size = new System.Drawing.Size(0, 20);
            this.lbluseid.TabIndex = 15;
            this.lbluseid.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(190, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Username";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 162);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // btnlgin
            // 
            this.btnlgin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlgin.Image = ((System.Drawing.Image)(resources.GetObject("btnlgin.Image")));
            this.btnlgin.Location = new System.Drawing.Point(365, 124);
            this.btnlgin.Margin = new System.Windows.Forms.Padding(4);
            this.btnlgin.Name = "btnlgin";
            this.btnlgin.Size = new System.Drawing.Size(100, 34);
            this.btnlgin.TabIndex = 13;
            this.btnlgin.Text = "Login";
            this.btnlgin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnlgin.UseVisualStyleBackColor = true;
            this.btnlgin.Click += new System.EventHandler(this.btnlgin_Click);
            // 
            // txtpwd
            // 
            this.txtpwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpwd.Location = new System.Drawing.Point(293, 84);
            this.txtpwd.Margin = new System.Windows.Forms.Padding(4);
            this.txtpwd.Name = "txtpwd";
            this.txtpwd.PasswordChar = '*';
            this.txtpwd.Size = new System.Drawing.Size(171, 26);
            this.txtpwd.TabIndex = 12;
            // 
            // txtuser
            // 
            this.txtuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser.Location = new System.Drawing.Point(293, 45);
            this.txtuser.Margin = new System.Windows.Forms.Padding(4);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(171, 26);
            this.txtuser.TabIndex = 11;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 187);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.lblgid);
            this.Controls.Add(this.lbluseid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnlgin);
            this.Controls.Add(this.txtpwd);
            this.Controls.Add(this.txtuser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblmsg;
        public System.Windows.Forms.Label lblgid;
        public System.Windows.Forms.Label lbluseid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnlgin;
        private System.Windows.Forms.TextBox txtpwd;
        private System.Windows.Forms.TextBox txtuser;
    }
}