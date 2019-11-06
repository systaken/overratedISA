namespace ISAManagement
{
    partial class frmAddsec
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
            this.btnsubmit = new System.Windows.Forms.Button();
            this.txtsection = new System.Windows.Forms.TextBox();
            this.ddGlevel = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpicker = new System.Windows.Forms.DateTimePicker();
            this.label19 = new System.Windows.Forms.Label();
            this.dtpicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnsubmit
            // 
            this.btnsubmit.Location = new System.Drawing.Point(477, 107);
            this.btnsubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(161, 31);
            this.btnsubmit.TabIndex = 5;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // txtsection
            // 
            this.txtsection.Location = new System.Drawing.Point(154, 62);
            this.txtsection.Margin = new System.Windows.Forms.Padding(4);
            this.txtsection.Name = "txtsection";
            this.txtsection.Size = new System.Drawing.Size(160, 22);
            this.txtsection.TabIndex = 2;
            // 
            // ddGlevel
            // 
            this.ddGlevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddGlevel.FormattingEnabled = true;
            this.ddGlevel.Items.AddRange(new object[] {
            "Cash",
            "CC / Debit",
            "Check",
            "Bank Transfer"});
            this.ddGlevel.Location = new System.Drawing.Point(154, 30);
            this.ddGlevel.Margin = new System.Windows.Forms.Padding(4);
            this.ddGlevel.Name = "ddGlevel";
            this.ddGlevel.Size = new System.Drawing.Size(160, 24);
            this.ddGlevel.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 67);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 33;
            this.label6.Text = "Section";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 31;
            this.label4.Text = "Level";
            // 
            // dtpicker
            // 
            this.dtpicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpicker.Location = new System.Drawing.Point(486, 29);
            this.dtpicker.Margin = new System.Windows.Forms.Padding(4);
            this.dtpicker.Name = "dtpicker";
            this.dtpicker.Size = new System.Drawing.Size(152, 22);
            this.dtpicker.TabIndex = 3;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(379, 32);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(54, 17);
            this.label19.TabIndex = 26;
            this.label19.Text = "Time In";
            // 
            // dtpicker2
            // 
            this.dtpicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpicker2.Location = new System.Drawing.Point(486, 59);
            this.dtpicker2.Margin = new System.Windows.Forms.Padding(4);
            this.dtpicker2.Name = "dtpicker2";
            this.dtpicker2.Size = new System.Drawing.Size(152, 22);
            this.dtpicker2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(379, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 39;
            this.label1.Text = "Time out";
            // 
            // frmAddsec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(678, 167);
            this.Controls.Add(this.dtpicker2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.txtsection);
            this.Controls.Add(this.ddGlevel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpicker);
            this.Controls.Add(this.label19);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddsec";
            this.Text = "Section Detail";
            this.Load += new System.EventHandler(this.frmAddsec_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.TextBox txtsection;
        private System.Windows.Forms.ComboBox ddGlevel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpicker;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DateTimePicker dtpicker2;
        private System.Windows.Forms.Label label1;
    }
}