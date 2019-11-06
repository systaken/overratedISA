using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Configuration;
namespace TimeKeepingApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string expirations = ConfigurationManager.AppSettings["exp"];
            bool isExpired = false;
            if (expirations != "0")
            {
                //check expiration
                //string test = DateTime.Now.ToString("dd/MM/yyyy");
                if (DateTime.Now.ToString("dd/MM/yyyy") == expirations)
                {
                    isExpired = true;
                }
                else
                {
                    isExpired = false;
                }
            }
            else
            {
                isExpired = false;
            }
            if (isExpired == false)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
            else
            {
                MessageBox.Show("System Expired. Please contact administrator", "Warning");
            }
        }
    }
}
