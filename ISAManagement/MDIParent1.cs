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
    public partial class MDIParent1 : Form
    {

        LoginBO lg = new LoginBO();
        private int childFormNumber = 0;

        public MDIParent1()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //  statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            Info.Studentlists childform = new Info.Studentlists();
            childform.Tag = "Active";
            childform._Memgid = lblgroupid.Text;
            childform.MdiParent = this;
            childform.Show();
        }

        private void MDIParent1_Load(object sender, EventArgs e)
        {
            //if (DateTime.Now >= Convert.ToDateTime( "01/01/2015")) {
            //    MessageBox.Show("Trial is expired", "Warning");
            //    this.Close();
            //}
            this.WindowState = FormWindowState.Maximized;
            frmLogin flogin = new frmLogin();
            this.Hide();
            flogin.ShowDialog();
            lbluserid.Text = flogin.lbluseid.Text;
            lblgroupid.Text = flogin.lblgid.Text;
            if (lbluserid.Text == null || lbluserid.Text == "")
            {
                this.Close();
            }
            else
            {
                this.Show();
                loadingAccess();
            }
        }
        private void disabledcontrols()
        {
            toolStripButton9.Enabled = false;
            toolStripButton13.Enabled = false;
            toolStripSplitButton1.Enabled = false;
            maintenanceToolStripMenuItem.Enabled = false;
            settingsToolStripMenuItem.Enabled = false;

        }
        private void loadingAccess()
        {
            disabledcontrols();
            DataTable dts = new DataTable();
            dts = lg.getAccess(lblgroupid.Text);
            foreach (DataRow drow in dts.Rows)
            {
                if (drow["access_mode"].ToString() == "Members")
                {
                    toolStripButton9.Enabled = true;
                }
                if (drow["access_mode"].ToString() == "Card")
                {
                    toolStripButton13.Enabled = true;
                }
                if (drow["access_mode"].ToString() == "Event")
                {
                    toolStripSplitButton1.Enabled = true;
                }
                if (drow["access_mode"].ToString() == "Maintenance")
                {
                    maintenanceToolStripMenuItem.Enabled = true;
                }
                if (drow["access_mode"].ToString() == "Reports")
                {
                    //toolStripButton15.Enabled = true;
                    settingsToolStripMenuItem.Enabled = true;
                }
            }
        }

        private void userManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Maintenance.frmUserMngt sform = new Maintenance.frmUserMngt();
            sform.MdiParent = this;
            sform.Show();
        }

        private void toolStripSplitButton1_Click(object sender, EventArgs e)
        {
            frmSection sform = new frmSection();
            sform.MdiParent = this;
            sform.Show();
        }

        private void toolStripButton13_Click(object sender, EventArgs e)
        {
            sHistoryfrm sform = new sHistoryfrm();
            sform.MdiParent = this;
            sform.Show();
        }
    }
}
