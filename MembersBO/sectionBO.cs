using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using ASPFSols;


namespace MembersBO
{
    public class sectionBO : GlobalVar
    {
        public string _err;
        public string _code;

        public DataTable selectAll()
        {
            connectionDB();
            DataTable dt = new DataTable();
            string ssql = "";

            ssql = "SELECT * FROM ref_section WHERE isActive = 1 ORDER BY GLevel, sectionName ASC";
            dt = rs.CreateDataTableFromQry(ssql);
            return dt;
        }

        public bool Update(string sectionName, string GLevel, DateTime TimeIn, DateTime TimeOut, int section_id)
        {
            connectionDB();
            bool rtval = true;
            string ssql = "";
            try
            {
                ssql = "UPDATE [ref_section] SET [sectionName] = '" + sectionName + "',[GLevel] = '" + GLevel + "',"
                    + "[TimeIn] = '" + TimeIn + "',[TimeOut] =  '" + TimeOut + "' WHERE section_id = '" + section_id + "'";
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

        public bool Save(string sectionName, string GLevel, DateTime TimeIn, DateTime TimeOut)
        {
            connectionDB();
            bool rtval = true;
            string ssql = "";
            try
            {
                ssql = "INSERT INTO [ref_section] ([sectionName],[GLevel],[TimeIn],[TimeOut])"
                    + "VALUES('" + sectionName + "','" + GLevel + "', '" + TimeIn + "','" + TimeOut + "')";
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

        public bool Deactivate(string ids)
        {
            connectionDB();
            bool rtval = true;
            int section_id = Convert.ToInt16(ids);

            string ssql = "";
            try
            {
                ssql = "UPDATE [ref_section] SET isActive = 0 WHERE section_id = '" + section_id + "'";
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
