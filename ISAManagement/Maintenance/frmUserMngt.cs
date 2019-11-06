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
    public partial class frmUserMngt : Form
    {

        MemberInfoBO mem = new MemberInfoBO();
        regionBO regon = new regionBO();
        LoginBO lg = new LoginBO();
      
        public frmUserMngt()
        {
            InitializeComponent();
        }

        private void frmUserMngt_Load(object sender, EventArgs e)
        {
           
            loadUsers();
        }
        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            frmaddUser aduser = new frmaddUser();
            aduser.ShowDialog();
            loadUsers();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (this.MemListsV.SelectedItems.Count > 0)
            {
               //delete
                if (lg.Delete(this.MemListsV.SelectedItems[0].Text) == true)
                {
                    MessageBox.Show("Record has been deleted.","Confirmation");
                    loadUsers();
                }
                else
                {
                    MessageBox.Show(lg._err.ToString(),"Warning"); 
                }
            }
            else
            {
                MessageBox.Show("There is no item selected.", "Warning");
            }
        }

        private void loadUsers()
        {
            DataTable dt = new DataTable();
            ListViewItem itm;
            MemListsV.Items.Clear();
            string isActive;
            dt = lg.loadUsers("1");
           
            foreach (DataRow drow in dt.Rows)
            {

                itm = new ListViewItem();
                itm.Text = drow["user_id"].ToString();
                itm.SubItems.Add(drow["username"].ToString());
                itm.SubItems.Add(drow["password"].ToString());
                itm.SubItems.Add(drow["firstname"].ToString());
                itm.SubItems.Add(drow["lastname"].ToString());
                itm.SubItems.Add(drow["userLevel"].ToString());
                if (drow["isAcive"].ToString() == "True")
                { 
                    isActive = "Active";
                }
                else
                {
                    isActive = "In-Active";
                }

                itm.SubItems.Add(isActive);
                this.MemListsV.Items.Add(itm);
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            loadUsers();
        }
    }
}
