using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;

namespace AlternateSolution
{
    public partial class Form1 : Form
    {
        SerialPort port = new SerialPort();
        clsSMS objclsSMS = new clsSMS();
        ShortMessageCollection objShortMessageCollection = new ShortMessageCollection();

        public Form1()
        {
            InitializeComponent();
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            this.port = objclsSMS.OpenPort(this.txtComm.Text, Convert.ToInt32(this.txtbaud.Text), 8, 300,300);
            if (this.port != null)
            {
                objclsSMS.sendMsg(this.port, this.txtToAddress.Text, this.txtBody.Text);
            }
            else
            {
                MessageBox.Show("Cannot Connect");
            }
            objclsSMS.ClosePort(this.port);
        }
      
    }
}
