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
using System.Configuration;
using MembersBO.Helpers;
namespace ISAManagement.Info
{
    public partial class StudentProfileFrm : Form
    {
        MemberInfoBO mem = new MemberInfoBO();
        regionBO regon = new regionBO();
        sectionBO sec = new sectionBO();
        ImageHelper imgH = new ImageHelper();
        public StudentProfileFrm()
        {
            InitializeComponent();
        }

        private bool validateText()
        {
            //bool rtval = false;

            if (txtfname.Text == "" || txtfname.Text == null)
            {
                MessageBox.Show("First name is required", "Validation");
                return false;
            }
            else if (txtlname.Text == "" || txtlname.Text == null)
            {
                MessageBox.Show("Last name is required", "Validation");
                return false;
            }
            else if (txtmid.Text == "" || txtmid.Text == null)
            {
                MessageBox.Show("Middle Initial name is required", "Validation");
                return false;
            }
            else if (txtadd1.Text == "" || txtadd1.Text == null)
            {
                MessageBox.Show("Address 1 is required", "Validation");
                return false;
            }
            else if (txtemail.Text == "" || txtemail.Text == null)
            {
                MessageBox.Show("Email is required", "Validation");
                return false;
            }
            else
            {
                return true;
            }
        }
        private void clear()
        {
            txtadd1.Text = null;
            txtadd2.Text = null;
            txtadd3.Text = null;
            txtemail.Text = null;
            txtfax.Text = null;
            txtfname.Text = null;
            txtlname.Text = null;
            txtmid.Text = null;
            txttel.Text = null;
            textResponse.Text = null;
            lblmeid.Text = null;
            lblmeid.Visible = false;

            //txtchapter.Text = null;
            //lblids.Text = null;
            //lblids.Visible = false;


        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            if (validateText() == false)
            {
                //MessageBox.Show("Please fill out the required value", "Confirmation"); 
            }
            else
            {
                if (saveRecord() == true)
                {
                    if (lblmemid.Text == "Update")
                    {
                        MessageBox.Show("Record has been updated.", "Confirmation");
                        this.Close();
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show("New Member has been added, do you want to add more?", "Confirmation", MessageBoxButtons.OKCancel);
                        if (dialogResult == DialogResult.OK)
                        {
                            //clear all data                
                            clear();
                        }
                        else
                        {
                            this.Close();
                        }
                    }
                }
            }
        }
        private bool saveRecord()
        {
            int stopReg = Convert.ToInt16(ConfigurationManager.AppSettings["cStuds"]);
            bool rtval = false;
            try
            {
                if (lblmemid.Text == null || lblmemid.Text == "")
                {
                    if (mem.isCanRegister(stopReg) == true)
                    {
                        if (mem.Register(txtstudentNos.Text, txtrfid.Text, txtfname.Text, txtlname.Text, txtmid.Text, ddLevel.Text, ddsection.SelectedValue.ToString(), txtguardian.Text,
                            dtBdate.Value.ToShortDateString(), txtadd1.Text, txtadd2.Text, txtadd3.Text, txttel.Text, txtfax.Text, txtemail.Text,
                            "", DateTime.Now.ToShortDateString(), cmbGender.Text, txtencrypt.Text) == true)
                        {
                            rtval = true;
                        }
                        else
                        {
                            rtval = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cannot registered already reach the limit ", "Warning");
                        rtval = false;
                    }

                }
                else if (lblmemid.Text == "Update")
                {
                    if (mem.UpdateMember(txtstudentNos.Text, txtrfid.Text, txtfname.Text, txtlname.Text, txtmid.Text, ddLevel.Text, ddsection.SelectedValue.ToString(), txtguardian.Text,
                        dtBdate.Value.ToShortDateString(), txtadd1.Text, txtadd2.Text, txtadd3.Text, txttel.Text, txtfax.Text, txtemail.Text,
                        "", DateTime.Now.ToShortDateString(), cmbGender.Text, lblrecid.Text,txtencrypt.Text) == true)
                    {
                        rtval = true;
                    }
                    else
                    {
                        rtval = false;
                    }
                }
                else
                {
                    MessageBox.Show("Record cannot be saved " + mem._err.ToString(), "Warning");
                    rtval = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Record will not be save. Please check: " + ex.ToString(), "Warning");
                rtval = false;
            }

            return rtval;
        }

        private void StudentProfileFrm_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = regon.selectAll();

            ddLevel.DataSource = dt;
            ddLevel.DisplayMember = "regionName";
            ddLevel.ValueMember = "region_id";
            ddLevel.SelectedIndex = -1;

            DataTable dt2 = new DataTable();
            dt2 = sec.selectAll();

            ddsection.DataSource = dt2;
            ddsection.DisplayMember = "sectionName";
            ddsection.ValueMember = "section_id";
            ddsection.SelectedIndex = -1;


            if (this.Tag != null)
            {
                LoadProfile(this.Tag.ToString());
            }
        }

        private void LoadProfile(string memberid)
        {
         
            //label16.Visible = false;
            DataTable dt = new DataTable();
            dt = mem.GetMemberProfile(memberid);

            foreach (DataRow drow in dt.Rows)
            {
                txtlname.Text = drow["LastName"].ToString();
                txtfname.Text = drow["FirstName"].ToString();
                txtmid.Text = drow["MiddleInitial"].ToString();
                cmbGender.Text = drow["Gender"].ToString();
                txtadd1.Text = drow["Addr1"].ToString();
                txtadd2.Text = drow["Addr2"].ToString();
                txtadd3.Text = drow["Addr3"].ToString();
                txttel.Text = drow["TelNo"].ToString();
                txtemail.Text = drow["EmailAdd"].ToString();
                txtfax.Text = drow["FaxNo"].ToString();

                lblrecid.Text = drow["member_id"].ToString();
                ddLevel.Text = drow["GLevel"].ToString();
                ddsection.SelectedValue = drow["section_id"];
                txtguardian.Text = drow["GuardianName"].ToString();
                txtrfid.Text = drow["card_no"].ToString();
                txtstudentNos.Text = drow["student_no"].ToString();

                if (drow["PixUrl"].ToString() != "")
                {
                    txtencrypt.Text = drow["PixUrl"].ToString();
                    pictureBox1.Image = imgH.ConvertBase64ToImage(txtencrypt.Text);
                }

                lblmemid.Text = "Update";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\";
            //openFileDialog1.Filter = "(*.jpg)|*.jpg | png (*.png*)|*.png";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    textResponse.Text = openFileDialog1.FileName;
                    //pictureBox1.ImageLocation = textResponse.Text;
                    Bitmap im = new Bitmap(textResponse.Text);
                    txtencrypt.Text = imgH.ConvertImageToBase64(im);
                    pictureBox1.Image = imgH.ConvertBase64ToImage(txtencrypt.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.ToString()}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }
    }
}
