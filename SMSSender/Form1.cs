using System;
using System.Threading;
using System.ComponentModel;
using System.IO.Ports;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace SMSSender
{
    public partial class Form1 : Form
    {

        private SerialPort SMSPort;
        private Thread SMSThread;
        private Thread ReadThread;
        public static bool _Continue = false;
        public static bool _ContSMS = false;
        private bool _Wait = false;
        public static bool _ReadPort = false;
        public delegate void SendingEventHandler(bool Done);
        public event SendingEventHandler Sending;
        public delegate void DataReceivedEventHandler(string Message);
        public event DataReceivedEventHandler DataReceived;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public Form1(string COMMPORT)
        {
            InitializeComponent();
            SMSPort = new SerialPort();
            SMSPort.PortName = COMMPORT;
            SMSPort.BaudRate = 9600;
            SMSPort.Parity = Parity.None;
            SMSPort.DataBits = 8;
            SMSPort.StopBits = StopBits.One;
            SMSPort.Handshake = Handshake.RequestToSend;
            SMSPort.DtrEnable = true;
            SMSPort.RtsEnable = true;
            SMSPort.NewLine = System.Environment.NewLine;
            ReadThread = new Thread(new System.Threading.ThreadStart(ReadPort));
        }

        public bool SendSMS(string CellNumber, string SMSMessage)
        {
            string MyMessage = null;
            //Check if Message Length <= 160
            if (SMSMessage.Length <= 160)
                MyMessage = SMSMessage;
            else
                MyMessage = SMSMessage.Substring(0, 160);
            if (SMSPort.IsOpen == true)
            {
                SMSPort.WriteLine("AT+CMGS=" + CellNumber + "r");
                _ContSMS = false;

                SMSPort.WriteLine(
                MyMessage + System.Environment.NewLine + (char)(26));
                _Continue = false;
                if (Sending != null)
                    Sending(false);
            }
            return false;
        }

        private void ReadPort()
        {
            string SerialIn = null;
            byte[] RXBuffer = new byte[SMSPort.ReadBufferSize + 1];
            string SMSMessage = null;
            int Strpos = 0;
            string TmpStr = null;
            while (SMSPort.IsOpen == true)
            {
                if ((SMSPort.BytesToRead != 0) & (SMSPort.IsOpen == true))
                {
                    while (SMSPort.BytesToRead != 0)
                    {
                        SMSPort.Read(RXBuffer, 0, SMSPort.ReadBufferSize);
                        SerialIn =
                            SerialIn + System.Text.Encoding.ASCII.GetString(
                            RXBuffer);
                        if (SerialIn.Contains(">") == true)
                        {
                            _ContSMS = true;
                        }
                        if (SerialIn.Contains("+CMGS:") == true)
                        {
                            _Continue = true;
                            if (Sending != null)
                                Sending(true);
                            _Wait = false;
                            SerialIn = string.Empty;
                            RXBuffer = new byte[SMSPort.ReadBufferSize + 1];
                        }
                    }
                    if (DataReceived != null)
                        DataReceived(SerialIn);
                    SerialIn = string.Empty;
                    RXBuffer = new byte[SMSPort.ReadBufferSize + 1];
                }
            }
        }

        public void Open()
        {
            if (SMSPort.IsOpen == false)
            {
                SMSPort.Open();
                ReadThread.Start();
            }
        }

        public void Close()
        {
            if (SMSPort.IsOpen == true)
            {
                SMSPort.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Form1 SMSEngine = new Form1("COM3");
                SMSEngine.Open();
                SMSEngine.SendSMS(txtnos.Text, txtsms.Text);
                SMSEngine.Close();
                MessageBox.Show("Sent", "Wanring");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Wanring");
            }
        }
    }
}
