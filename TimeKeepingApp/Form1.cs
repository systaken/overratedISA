using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MembersBO;
using System.IO.Ports;
using System.Threading;
using System.Configuration;
using AxSms;

namespace TimeKeepingApp
{
    public partial class Form1 : Form
    {
        MemberInfoBO mem = new MemberInfoBO();
        TimekeepingBO tm = new TimekeepingBO();
        SMSBO smb = new SMSBO();
        Config.FrequencyClass fr = new Config.FrequencyClass();

        private AxSms.Gsm objGsm;
        private AxSms.Constants objSmsConstants;
        private AxSms.Constants objConstants;
        public Form1()
        {
            InitializeComponent();
            objGsm = new AxSms.Gsm();
            objSmsConstants = new AxSms.Constants();
            objConstants = new AxSms.Constants();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbldate.Text = DateTime.Now.ToShortDateString();
            string COMMPORT = ConfigurationManager.AppSettings["COMMPORT"];
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text = DateTime.Now.ToLongTimeString();
        }
        private void loadinformation()
        {
            DataTable dt = new DataTable();
            dt = mem.StudentCard(txtcardno.Text);
            foreach (DataRow drow in dt.Rows)
            {
                lblcardno.Text = txtcardno.Text;
                lblstudentname.Text = drow["LastName"] + "," + drow["FirstName"] + " " + drow["MiddleInitial"];
                lblGlevel.Text = drow["GLevel"].ToString();
                tm.TimeEntry(txtcardno.Text, drow["member_id"].ToString(), DateTime.Now.ToString());
                string ensms = SMSMEssager(tm._lstat, DateTime.Now.ToString());
                string contact = drow["TelNo"].ToString();
                if(contact != "")
                {
                    smb.Insert(contact,ensms);
                }
                lblstats.Text = tm._lstat;
            }
        }
        private void txtcardno_Enter(object sender, EventArgs e)
        {
            loadinformation();
            txtcardno.Text = "";
        }
        private void txtcardno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                loadinformation();
                txtcardno.Text = "";
            }
        }

        private string SMSMEssager(string status, string dateentry)
        {
            string mssg = "";
            if (status == "In")
            {
                mssg = "You child has Entered to school premises at " + dateentry +" - St. Blase";
            }
            else
            {
                mssg = "You child has Left the school premises at " + dateentry + " - St. Blase";
            }
            return mssg;
        }

        private void SenMessages()
        {
            DataTable dt = new DataTable();
            dt = smb.Unsent();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    string cons = dr["Sentto"].ToString();
                    string msgs = dr["Message"].ToString();
                    int ids =  Convert.ToInt16(dr["sms_id"]);
                    sendingtext(msgs, cons);
                    smb.MarkAsSent(ids);
                }
            }
        }

        private void sendingtext(string message, string nos)
        {
            try {
                string conRate = ConfigurationManager.AppSettings["cFrequency"];
                int brate = fr.BaudRate(conRate);

                Cursor.Current = Cursors.WaitCursor;
                int subsno = objConstants.TON_NATIONAL;
                string COMMPORT = ConfigurationManager.AppSettings["COMMPORT"];
                string comm = "COM3";
                objGsm.Open(COMMPORT.ToString(), "",  brate);
             
                // Create a new SMS message and configure it for sending.
                AxSms.Message objSms = new AxSms.Message();
                objSms.ToAddress = nos;
                objSms.DataCoding = (int)objSmsConstants.DATACODING_DEFAULT;
                objSms.Body = message;

                // Set the SMS properties from the advanced dialog            
                objSms.BodyFormat = objConstants.BODYFORMAT_TEXT;

                objSms.ToAddressTON = objConstants.TON_NATIONAL;
                objSms.ToAddressNPI = objConstants.NPI_UNKNOWN;
                objSms.RequestDeliveryReport = false;
                objSms.HasUdh = false;

                String strReference = objGsm.SendSms(objSms, objSmsConstants.MULTIPART_ACCEPT, 0);
                ListViewItem item = new ListViewItem(new String[]
                {
                    "n/a", strReference, objSms.ToAddress, "SENT", objSms.Body
                });

                item.Tag = strReference;
                objGsm.Close();
            }
            catch (Exception ex)
            {
                return;
            }
       }

        private void timer2_Tick(object sender, EventArgs e)
        {
            SenMessages();
        }
    }
}
