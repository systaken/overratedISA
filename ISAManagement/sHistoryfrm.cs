using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MembersBO;

namespace ISAManagement
{
    public partial class sHistoryfrm : Form
    {

        TimekeepingBO mem = new TimekeepingBO();
        public sHistoryfrm()
        {
            InitializeComponent();
        }

        private void sHistoryfrm_Load(object sender, EventArgs e)
        {
            loadInformation();
        }

        private void loadInformation()
        {
            ListViewItem itm;
            DataTable dt;

            dt = mem.StudentTimeAll();
            this.MemListsV.Items.Clear();
            foreach (DataRow drow in dt.Rows)
            {
                itm = new ListViewItem();
                itm.Text = drow["record_id"].ToString();
                itm.SubItems.Add(drow["student_no"].ToString());
                itm.SubItems.Add(drow["GLevel"].ToString());
                itm.SubItems.Add(drow["sectionName"].ToString());
                itm.SubItems.Add(drow["Lastname"].ToString());
                itm.SubItems.Add(drow["FirstName"].ToString());
                itm.SubItems.Add(drow["MiddleInitial"].ToString());
                itm.SubItems.Add(drow["cardNo"].ToString());
                itm.SubItems.Add(drow["TimePunch"].ToString());
                itm.SubItems.Add(drow["TimeStatus"].ToString());
                this.MemListsV.Items.Add(itm);
                MemListsV.Refresh();
            }
            dt = null;
        }
        private string getSearchby(string searchby)
        {
            string rtval = null;
            if (searchby == "First Name")
            {
                rtval = "Firstname";
            }
            else if (searchby == "Last N" +
                "ame")
            {
                rtval = "Lastname";
            }
            else if (searchby == "Student ID")
            {
                rtval = "student_no";
            }

            return rtval;
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                if (cmbSBy.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a search option", "Warning");
                    return;
                }
                ListViewItem itm;
                DataTable dt;
                itm = null;
                MemListsV.Refresh();
                MemListsV.Items.Clear();
                string srch;
                srch = getSearchby(cmbSBy.Text);
                dt = mem.SelectBysearch(srch, txtSearch.Text);
                this.MemListsV.Items.Clear();

                foreach (DataRow drow in dt.Rows)
                {
                    itm = new ListViewItem();
                    itm.Text = drow["record_id"].ToString();
                    itm.SubItems.Add(drow["student_no"].ToString());
                    itm.SubItems.Add(drow["GLevel"].ToString());
                    itm.SubItems.Add(drow["sectionName"].ToString());
                    itm.SubItems.Add(drow["Lastname"].ToString());
                    itm.SubItems.Add(drow["FirstName"].ToString());
                    itm.SubItems.Add(drow["MiddleInitial"].ToString());
                    itm.SubItems.Add(drow["cardNo"].ToString());
                    itm.SubItems.Add(drow["TimePunch"].ToString());
                    itm.SubItems.Add(drow["TimeStatus"].ToString());

                    this.MemListsV.Items.Add(itm);
                    MemListsV.Refresh();
                }
                dt = null;
            }
            else
            {
                MessageBox.Show("Please select a search item", "Warning");
            }
        }
    }
}
