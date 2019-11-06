using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MembersBO;

namespace ISAManagement.Info
{
    public partial class Studentlists : Form
    {

        MemberInfoBO mem = new MemberInfoBO();
        public string _Memgid;
        public Studentlists()
        {
            InitializeComponent();
        }

        private void Studentlists_Load(object sender, EventArgs e)
        {
            loadInformation();
            this.WindowState = FormWindowState.Maximized;
            if (_Memgid.ToString() == "5")
            {
                toolStripButton1.Visible = true;
                toolStripButton1.Enabled = true;
            }
            else
            {
                toolStripButton1.Visible = false;
                toolStripButton1.Enabled = false;
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            StudentProfileFrm sform = new StudentProfileFrm();
            sform.Show();
            loadInformation();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (this.MemListsV.SelectedItems.Count > 0)
            {
                StudentProfileFrm sform = new StudentProfileFrm();
                sform.Tag = this.MemListsV.SelectedItems[0].Text;
                sform.Show();
            }
        }


        private void loadInformation()
        {
            ListViewItem itm;
            DataTable dt;

            if (this.Tag.ToString() == "Deactivate")
            {
                lbltag.Text = "Deactivate";
            }
            else
            {
                lbltag.Text = "";
            }

            if (lbltag.Text == "")
            {
                toolStripButton1.Visible = true;
                toolStripButton3.Visible = false;
            }
            else
            {
                toolStripButton1.Visible = false;
                toolStripButton3.Visible = true;
            }

            dt = mem.SelectAll();
            this.MemListsV.Items.Clear();
            foreach (DataRow drow in dt.Rows)
            {
                itm = new ListViewItem();
                itm.Text = drow["member_id"].ToString();
                itm.SubItems.Add(drow["student_no"].ToString());
                itm.SubItems.Add(drow["GLevel"].ToString());
                itm.SubItems.Add(drow["section_id"].ToString());
                itm.SubItems.Add(drow["Lastname"].ToString());
                itm.SubItems.Add(drow["FirstName"].ToString());
                itm.SubItems.Add(drow["MiddleInitial"].ToString());
                itm.SubItems.Add(drow["Card_no"].ToString());
                itm.SubItems.Add(drow["iSActive"].ToString());

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
                    itm.Text = drow["member_id"].ToString();
                    itm.SubItems.Add(drow["student_no"].ToString());
                    itm.SubItems.Add(drow["GLevel"].ToString());
                    itm.SubItems.Add(drow["section_id"].ToString());
                    itm.SubItems.Add(drow["Lastname"].ToString());
                    itm.SubItems.Add(drow["FirstName"].ToString());
                    itm.SubItems.Add(drow["MiddleInitial"].ToString());
                    itm.SubItems.Add(drow["Card_no"].ToString());
                    itm.SubItems.Add(drow["iSActive"].ToString());
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

        private void LoadInformation2()
        {
            MemListsV.Items.Clear();
            if (ddLetter.Text != "All" && ddLetter.Text != "")
            {
                ListViewItem itm;
                DataTable dt;
                itm = null;
                dt = mem.SelectByLetters(ddLetter.Text);
                foreach (DataRow drow in dt.Rows)
                {
                    itm = new ListViewItem();
                    itm.Text = drow["member_id"].ToString();
                    itm.SubItems.Add(drow["student_no"].ToString());
                    itm.SubItems.Add(drow["GLevel"].ToString());
                    itm.SubItems.Add(drow["section_id"].ToString());
                    itm.SubItems.Add(drow["Lastname"].ToString());
                    itm.SubItems.Add(drow["FirstName"].ToString());
                    itm.SubItems.Add(drow["MiddleInitial"].ToString());
                    itm.SubItems.Add(drow["Card_no"].ToString());
                    itm.SubItems.Add(drow["iSActive"].ToString());
                    this.MemListsV.Items.Add(itm);
                }
            }
            else
            {
                ListViewItem itm;
                DataTable dt;
                itm = null;
                dt = mem.SelectAll();
                foreach (DataRow drow in dt.Rows)
                {
                    itm = new ListViewItem();
                    itm.Text = drow["member_id"].ToString();
                    itm.SubItems.Add(drow["student_no"].ToString());
                    itm.SubItems.Add(drow["GLevel"].ToString());
                    itm.SubItems.Add(drow["section_id"].ToString());
                    itm.SubItems.Add(drow["Lastname"].ToString());
                    itm.SubItems.Add(drow["FirstName"].ToString());
                    itm.SubItems.Add(drow["MiddleInitial"].ToString());
                    itm.SubItems.Add(drow["Card_no"].ToString());
                    itm.SubItems.Add(drow["iSActive"].ToString());
                    this.MemListsV.Items.Add(itm);
                }
            }
        }

        private void MemListsV_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (MemListsV.Sorting == SortOrder.Ascending)
            {
                MemListsV.Sorting = SortOrder.Descending;
            }
            else
            {
                MemListsV.Sorting = SortOrder.Ascending;
            }
            MemListsV.Sort();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (this.MemListsV.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("This account will activated again.?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (mem.ActivateMember(this.MemListsV.SelectedItems[0].Text) == true)
                    {
                        MessageBox.Show("Member has been deactivated.", "Success");
                        LoadInformation2();
                        MemListsV.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("Failed during process. " + mem._err.ToString(), "Failed");
                    }
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (this.MemListsV.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to deactivate this account?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (mem.DeactivateMember(this.MemListsV.SelectedItems[0].Text) == true)
                    {
                        MessageBox.Show("Member has been deactivated.", "Success");
                        LoadInformation2();
                        MemListsV.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("Failed during process. " + mem._err.ToString(), "Failed");
                    }
                }
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            MemListsV.Refresh();
        }
    }
}
