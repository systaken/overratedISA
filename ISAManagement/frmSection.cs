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


namespace ISAManagement
{
    public partial class frmSection : Form
    {
        MemberInfoBO mem = new MemberInfoBO();
        regionBO regon = new regionBO();
        sectionBO sec = new sectionBO();
        public frmSection()
        {
            InitializeComponent();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            frmAddsec sforms = new frmAddsec();
            sforms.ShowDialog();
            loadInformation();
        }

        private void loadInformation()
        {
            DataTable dt = new DataTable();
            ListViewItem itm;
            MemListsV.Items.Clear();
            dt = sec.selectAll();
            foreach (DataRow drow in dt.Rows)
            {
                itm = new ListViewItem();
                itm.Text = drow["section_id"].ToString();
                itm.SubItems.Add(drow["GLevel"].ToString());
                itm.SubItems.Add(drow["sectionName"].ToString());
                itm.SubItems.Add(drow["TimeIn"].ToString());
                itm.SubItems.Add(drow["TimeOut"].ToString());
                this.MemListsV.Items.Add(itm);
            }
        }

        private void frmSection_Load(object sender, EventArgs e)
        {
            loadInformation();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (this.MemListsV.SelectedItems.Count > 0)
            {
                if (sec.Deactivate(this.MemListsV.SelectedItems[0].Text) == true)
                {
                    MessageBox.Show("Record has been deleted", "Confirmation");
                    loadInformation();
                }
            }
        }
    }
}
