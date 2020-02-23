using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISAJobs
{
    public partial class SMSForm : Form
    {
        private ContextMenu trayMenu;
        private SMSSender s = new SMSSender();
        public SMSForm()
        {
            InitializeComponent();
        }

        private void SMSForm_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
            NotifyIcon trayIcon = new NotifyIcon();
            trayIcon.Text = "ISA SMS Monitoring";
            trayIcon.Icon = this.Icon;

            // Add menu to tray icon and show it.
            trayIcon.ContextMenu = trayMenu;
            trayIcon.Visible = true;
            Visible = false; // Hide form window.
            ShowInTaskbar = false; // Remove from taskbar.
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
            label1.Refresh();
            s.SenMessages();
        }
    }
}
