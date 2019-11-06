using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using MembersBO;
using ASPFramework;
using ASPFSols;
using System.IO;
using MembersBO.Secure;


namespace ISAManagement
{
    public partial class frmLogin : Form
    {
        LoginBO lg = new LoginBO();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnlgin_Click(object sender, EventArgs e)
        {
            lbluseid.Text = "5"; // lg._userId;
            lblgid.Text = "5";// lg._gId;
            this.Close();


            //if (lg.IsAuthenticated(txtuser.Text, txtpwd.Text) == true)
            //{
            //    lbluseid.Text = "1"; // lg._userId;
            //    lblgid.Text = "5";// lg._gId;
            //    this.Close();
            //}
            //else
            //{
            //    lblmsg.Text = lg._err.ToString();
            //    lblmsg.Visible = true;
            //}
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
