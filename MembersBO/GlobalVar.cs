using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ASPFramework;
using System.IO;

//Hide this functions on others because this is the framework property owned by Advanced Solution Provider (jonathan Bacud)
namespace MembersBO
{
    public class GlobalVar
    {

        public ASPFramework.DataLibrary rs; //= new ASPFramework.DataLibrary("Data Source=tcp:s06.winhost.com;Initial Catalog=DB_68694_pice;User ID=DB_68694_pice_user;Password=Shangrila;Integrated Security=False;");
        public void connectionDB(string connectionString)
        {
            rs = new ASPFramework.DataLibrary(connectionString);
        }
        public void connectionDB()
        {
            //if (isExpire() == false)
            //{
            StreamReader rd = new StreamReader("dbcon.ini");
            string constr; //= "Data Source=tcp:s06.winhost.com;Initial Catalog=DB_68694_pice;User ID=DB_68694_pice_user;Password=Shangrila;Integrated Security=False;";
            constr = rd.ReadLine();
            rd.Close();
            rs = new ASPFramework.DataLibrary(constr);
            //}
        }

        private bool isExpire()
        {
            bool rtval = false;
            if (DateTime.Now >= Convert.ToDateTime("09/10/2019 00:00:00"))
            {
                rtval = true;
            }
            else
            {
                rtval = false;
            }
            return rtval;
        }
    }
}
