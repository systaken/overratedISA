namespace AlternateSolution
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
            this.txtComm = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtToAddress = new System.Windows.Forms.TextBox();
            this.txtBody = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbaud = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtComm
            // 
            this.txtComm.AcceptsReturn = true;
            this.txtComm.Location = new System.Drawing.Point(195, 130);
            this.txtComm.Margin = new System.Windows.Forms.Padding(4);
            this.txtComm.Name = "txtComm";
            this.txtComm.Size = new System.Drawing.Size(228, 22);
            this.txtComm.TabIndex = 20;
            // 
            // Label5
            // 
            this.Label5.Location = new System.Drawing.Point(67, 197);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(87, 20);
            this.Label5.TabIndex = 19;
            this.Label5.Text = "&Body:";
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(67, 166);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(97, 20);
            this.Label4.TabIndex = 18;
            this.Label4.Text = "&ToAddress:";
            // 
            // txtToAddress
            // 
            this.txtToAddress.AcceptsReturn = true;
            this.txtToAddress.Location = new System.Drawing.Point(195, 162);
            this.txtToAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtToAddress.Name = "txtToAddress";
            this.txtToAddress.Size = new System.Drawing.Size(228, 22);
            this.txtToAddress.TabIndex = 15;
            // 
            // txtBody
            // 
            this.txtBody.Location = new System.Drawing.Point(195, 195);
            this.txtBody.Margin = new System.Windows.Forms.Padding(4);
            this.txtBody.Multiline = true;
            this.txtBody.Name = "txtBody";
            this.txtBody.Size = new System.Drawing.Size(228, 86);
            this.txtBody.TabIndex = 16;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(195, 290);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(230, 30);
            this.btnSend.TabIndex = 17;
            this.btnSend.Text = "S&end";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(67, 133);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "COM";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(67, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Baud rate";
            // 
            // txtbaud
            // 
            this.txtbaud.AcceptsReturn = true;
            this.txtbaud.Location = new System.Drawing.Point(195, 100);
            this.txtbaud.Margin = new System.Windows.Forms.Padding(4);
            this.txtbaud.Name = "txtbaud";
            this.txtbaud.Size = new System.Drawing.Size(228, 22);
            this.txtbaud.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 443);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbaud);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtComm);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.txtToAddress);
            this.Controls.Add(this.txtBody);
            this.Controls.Add(this.btnSend);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtComm;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtToAddress;
        internal System.Windows.Forms.TextBox txtBody;
        internal System.Windows.Forms.Button btnSend;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox txtbaud;
    }
}

