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

namespace ISAManagement.Maintenance
{
    public partial class frmaddUser : Form
    {
        MemberInfoBO mem = new MemberInfoBO();
        regionBO regon = new regionBO();
        LoginBO lg = new LoginBO();
       

        public frmaddUser()
        {
            InitializeComponent();
        }

        private void frmaddUser_Load(object sender, EventArgs e)
        {
            loadGroups();
        }

        private void loadGroups()
        {
            DataTable dts = new DataTable();
            dts = lg.groupings();
            comboBox1.DataSource = dts;
            comboBox1.ValueMember = "group_id";
            comboBox1.DisplayMember = "userLevel";
        }

        private void btnSave_Click(object sender, EventArgs e)
        { 
            if(txtpwd.Text == txtrepass.Text)
            {
                if(lg.addUser(txtuser.Text,txtpwd.Text,txtfname.Text,txtlname.Text,comboBox1.SelectedValue.ToString()) == true)           
                {
                        cleardata();
                        MessageBox.Show("User has been added.","Confirmation"); 
                }
                else
                {
                        MessageBox.Show(lg._err.ToString(),"Failed");
                }
            }
            else
            {
                MessageBox.Show("Password did not match.","Warning"); 
            }
        }

        private void cleardata()
        {
            txtuser.Text = "";
            txtrepass.Text = "";
            txtpwd.Text = "";
            txtlname.Text = "";
            txtfname.Text = "";
            comboBox1.SelectedIndex = -1;

        
        }
    }
}
