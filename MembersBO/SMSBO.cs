using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using ASPFSols;



namespace MembersBO
{
    public class SMSBO : GlobalVar
    {
        public string _err;
        public string _code;

        public DataTable Unsent()
        {
            connectionDB();
            DataTable dt = new DataTable();
            string ssql = "";

            ssql = "SELECT * FROM trn_sms WHERE iSSent = 0 ORDER BY sms_id ASC";
            dt = rs.CreateDataTableFromQry(ssql);
            return dt;
        }

        public bool MarkAsSent(int sentId)
        {
            connectionDB();
            bool rtval = true;
            string ssql = "";
            try
            {
                ssql = "UPDATE trn_sms SET iSSent= 1 WHERE sms_id = '" + sentId + "'";
                rs.ExecuteSQL(ssql);
                rtval = true;
            }
            catch (Exception ex)
            {
                _err = ex.ToString();
                rtval = false;
            }
            return rtval;
        }

        public bool Insert(string Sentto, string Msgs)
        {
            connectionDB();
            bool rtval = true;
            string ssql = "";
            try
            {
                ssql = "INSERT INTO trn_sms(Sentto,Message)"
                     + " VALUES('" + Sentto + "','" + Msgs + "')";
                rs.ExecuteSQL(ssql);
                rtval = true;
            }
            catch (Exception ex)
            {
                _err = ex.ToString();
                rtval = false;
            }
            return rtval;
        }
    }
}
