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
    public partial class frmAddsec : Form
    {

        MemberInfoBO mem = new MemberInfoBO();
        regionBO regon = new regionBO();
        sectionBO sec = new sectionBO();
        public frmAddsec()
        {
            InitializeComponent();
        }

        private void frmAddsec_Load(object sender, EventArgs e)
        {
            loadinformation();
        }

        private void loadinformation()
        {
            DataTable dt = new DataTable();
            dt = regon.selectAll();

            ddGlevel.DataSource = dt;
            ddGlevel.DisplayMember = "regionName";
            ddGlevel.ValueMember = "region_id";
            ddGlevel.SelectedIndex = -1;

        }
        private void btnsubmit_Click(object sender, EventArgs e)
        {
            sec.Save(txtsection.Text, ddGlevel.Text, dtpicker.Value, dtpicker2.Value);
            MessageBox.Show("Section has been added ", "Confirmation");
        }
    }
}
