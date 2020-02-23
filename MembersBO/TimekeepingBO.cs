using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using ASPFSols;

namespace MembersBO
{
    public class TimekeepingBO : GlobalVar
    {
        public string _err;
        public string _lstat;
        public DataTable StudentTimeAll()
        {
            string ssql;
            connectionDB();
            ssql = "SELECT  * FROM student_time where isActive = 1 ORDER BY LastName ASC";
            return rs.CreateDataTableFromQry(ssql);
        }
        public DataTable SelectBysearch(string searchby, string searchitem)
        {
            string ssql;
            connectionDB();
            ssql = "SELECT * FROM student_time WHERE " + searchby + " LIKE '" + searchitem + "%' AND iSActive = 1 ORDER BY " + searchby + " ASC";
            return rs.CreateDataTableFromQry(ssql);
        }

        public DataTable StudentBycard()
        {
            string ssql;
            connectionDB();
            ssql = "SELECT  * FROM student_time where isActive = 1 ORDER BY LastName ASC";
            return rs.CreateDataTableFromQry(ssql);
        }

        public bool TimeEntry(string cardno, string memberId, string timepunch)
        {
            connectionDB();
            string ssql = "";
            bool rtval = false;
            try
            {
                string timeStats = string.Empty;
                DataTable dt = new DataTable();
                //GET THE LAST RECORD
                string sqlselExists = "SELECT TOP 1 * FROM trn_timekeeping WHERE cardNo = '" + cardno + "' AND studentId = '"+ memberId + "' ORDER BY record_id DESC";
                dt = rs.CreateDataTableFromQry(sqlselExists);
                if(dt.Rows.Count == 0)
                {
                    timeStats = "In";
                }
                foreach (DataRow drow in dt.Rows)
                {
                    if (drow["TimeStatus"].ToString() == "In")
                    {
                        timeStats = "Out";

                    }
                    else
                    {
                        timeStats = "In";
                    }
                }
                ssql = "INSERT INTO trn_timekeeping(studentId, cardNo, TimePunch, TimeStatus)"
                     + " VALUES('"+ memberId +"','"+ cardno +"','"+ timepunch +"','"+ timeStats +"')";
                rs.ExecuteSQL(ssql);
                _lstat = timeStats;
                rtval = true;
            }
            catch (Exception ex)
            {
                _err = "System Error Found Please check. " + ex.ToString();
                rtval = false;
            }
            return rtval;
        }

    }
}
