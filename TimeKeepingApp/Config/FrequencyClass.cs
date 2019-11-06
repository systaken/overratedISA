using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AxSms;

namespace TimeKeepingApp.Config
{
    public class FrequencyClass
    {
        private AxSms.Gsm objGsm = new AxSms.Gsm();
        private AxSms.Constants objSmsConstants = new AxSms.Constants();
        private AxSms.Constants objConstants = new AxSms.Constants();
        public int BaudRate(string configFrate)
        {
            int brate = 0;
            if (configFrate == "110")
            {
                brate = objSmsConstants.GSM_BAUDRATE_110;
            }
            else if (configFrate == "300")
            {
                brate = objSmsConstants.GSM_BAUDRATE_300;
            }
            else if (configFrate == "600")
            {
                brate = objSmsConstants.GSM_BAUDRATE_600;
            }
            else if (configFrate == "1200")
            {
                brate = objSmsConstants.GSM_BAUDRATE_1200;
            }
            else if (configFrate == "2400")
            {
                brate = objSmsConstants.GSM_BAUDRATE_2400;
            }
            else if (configFrate == "4800")
            {
                brate = objSmsConstants.GSM_BAUDRATE_4800;
            }
            else if (configFrate == "9600")
            {
                brate = objSmsConstants.GSM_BAUDRATE_9600;
            }
            else if (configFrate == "14400")
            {
                brate = objSmsConstants.GSM_BAUDRATE_14400;
            }
            else if (configFrate == "19200")
            {
                brate = objSmsConstants.GSM_BAUDRATE_19200;
            }
            else if (configFrate == "38400")
            {
                brate = objSmsConstants.GSM_BAUDRATE_38400;
            }
            else if (configFrate == "56000")
            {
                brate = objSmsConstants.GSM_BAUDRATE_56000;
            }
            else if (configFrate == "57600")
            {
                brate = objSmsConstants.GSM_BAUDRATE_57600;
            }
            else if (configFrate == "64000")
            {
                brate = objSmsConstants.GSM_BAUDRATE_64000;
            }
            else if (configFrate == "115200")
            {
                brate = objSmsConstants.GSM_BAUDRATE_115200;
            }
            else if (configFrate == "128000")
            {
                brate = objSmsConstants.GSM_BAUDRATE_128000;
            }
            else if (configFrate == "230400")
            {
                brate = objSmsConstants.GSM_BAUDRATE_230400;
            }
            else if (configFrate == "256000")
            {
                brate = objSmsConstants.GSM_BAUDRATE_256000;
            }
            else if (configFrate == "460800")
            {
                brate = objSmsConstants.GSM_BAUDRATE_460800;
            }
            else if (configFrate == "921600")
            {
                brate = objSmsConstants.GSM_BAUDRATE_921600;
            }
            else
            {
                brate = 0;
            }
            return brate;
        }
    }
}
