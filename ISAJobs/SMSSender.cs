using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Threading;
using System.Configuration;
using MembersBO;
using ISAJobs.Config;

namespace ISAJobs
{
    public class SMSSender
    {
        SMSBO smb = new SMSBO();
        SerialPort port = new SerialPort();
        clsSMS objclsSMS = new clsSMS();
        ShortMessageCollection objShortMessageCollection = new ShortMessageCollection();
        Config.FrequencyClass fr = new Config.FrequencyClass();

        public void SenMessages()
        {
            DataTable dt = new DataTable();
            dt = smb.Unsent();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    string cons = dr["Sentto"].ToString();
                    string msgs = dr["Message"].ToString();
                    int ids = Convert.ToInt16(dr["sms_id"]);
                    sendingtext(msgs, cons);
                    smb.MarkAsSent(ids);
                }
            }
        }
        private void sendingtext(string message, string nos)
        {
            string conRate = ConfigurationManager.AppSettings["cFrequency"];
            string COMMPORT = ConfigurationManager.AppSettings["COMMPORT"];
            int Databits = Convert.ToInt16(ConfigurationManager.AppSettings["cDataBits"]);
            int TimeoutRate = Convert.ToInt16(ConfigurationManager.AppSettings["cTimeoutRate"]);
            int TimeoutWrite = Convert.ToInt16(ConfigurationManager.AppSettings["cWriteTimout"]);
            int brate = fr.BaudRate(conRate);
            objclsSMS.ClosePort(this.port);
            this.port = objclsSMS.OpenPort(COMMPORT, Convert.ToInt32(conRate), Databits, TimeoutRate, TimeoutWrite);

            try
            {
                if (this.port != null)
                {
                    objclsSMS.sendMsg(this.port, nos, message);
                }
                else
                {

                }

                this.port.Close();
            }
            catch (Exception ex)
            {
                smb.InsertErrors(ex.ToString(), nos, message);
                return;
            }
        }

    }

   
}
