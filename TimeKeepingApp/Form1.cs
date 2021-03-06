﻿using System;
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
using TimeKeepingApp.Config;
using MembersBO.Helpers;
using System.Media;

namespace TimeKeepingApp
{
    public partial class Form1 : Form
    {
        MemberInfoBO mem = new MemberInfoBO();
        TimekeepingBO tm = new TimekeepingBO();
        SMSBO smb = new SMSBO();
        SerialPort port = new SerialPort();
        clsSMS objclsSMS = new clsSMS();
        ShortMessageCollection objShortMessageCollection = new ShortMessageCollection();
        Config.FrequencyClass fr = new Config.FrequencyClass();
        ImageHelper imgH = new ImageHelper();
        private AxSms.Gsm objGsm;
        private AxSms.Constants objSmsConstants;
        private AxSms.Constants objConstants;

        public Form1()
        {
            InitializeComponent();
            objGsm = new AxSms.Gsm();
            objSmsConstants = new AxSms.Constants();
            objConstants = new AxSms.Constants();

            string conRate = ConfigurationManager.AppSettings["cFrequency"];
            string COMMPORT = ConfigurationManager.AppSettings["COMMPORT"];
            int Databits = Convert.ToInt16(ConfigurationManager.AppSettings["cDataBits"]);
            int TimeoutRate = Convert.ToInt16(ConfigurationManager.AppSettings["cTimeoutRate"]);
            int TimeoutWrite = Convert.ToInt16(ConfigurationManager.AppSettings["cWriteTimout"]);
            int brate = fr.BaudRate(conRate);
            objclsSMS.ClosePort(this.port);
            this.port = objclsSMS.OpenPort(COMMPORT, Convert.ToInt32(brate), Databits, TimeoutRate, TimeoutWrite);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbldate.Text = DateTime.Now.ToShortDateString();
            string COMMPORT = ConfigurationManager.AppSettings["COMMPORT"];
            this.WindowState = FormWindowState.Maximized;
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
                playSound();
                lblcardno.Text = txtcardno.Text;
                lblstudentname.Text = drow["LastName"] + "," + drow["FirstName"] + " " + drow["MiddleInitial"];
                lblGlevel.Text = drow["GLevel"].ToString();
                tm.TimeEntry(txtcardno.Text, drow["member_id"].ToString(), DateTime.Now.ToString());
                string ensms = SMSMEssager(tm._lstat, DateTime.Now.ToString());
                string contact = drow["TelNo"].ToString();
                string pix = drow["PixUrl"].ToString();
                if (pix != "")
                {
                    pictureBox2.Image = imgH.ConvertBase64ToImage(pix);
                }
                if (contact != "")
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
                mssg = "You child has Entered to school premises at " + dateentry +" - ISA";
            }
            else
            {
                mssg = "You child has Left the school premises at " + dateentry + " - ISA";
            }
            return mssg;
        }

        private void playSound()
        {

            string cMorning = ConfigurationManager.AppSettings["cGoodMorning"];
            string cAfternoon = ConfigurationManager.AppSettings["cGoodAfternoon"];
            string cEvening = ConfigurationManager.AppSettings["cGoodEvening"];

            if (DateTime.Now.Hour <= 12)
            {
                using (var soundPlayer = new SoundPlayer(cMorning))
                {
                    soundPlayer.Play();
                }
            }
            else if (DateTime.Now.Hour <= 16)
            {
                using (var soundPlayer = new SoundPlayer(cAfternoon))
                {
                    soundPlayer.Play();
                }
            }
            else if (DateTime.Now.Hour <= 20)
            {
                using (var soundPlayer = new SoundPlayer(cEvening))
                {
                    soundPlayer.Play();
                }
            }
        }
    }
}
