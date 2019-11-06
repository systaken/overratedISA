using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using ASPFSols;


namespace MembersBO
{
    public class regionBO : GlobalVar
    {
        public string _err;
        public string _code;

        public DataTable selectAll()
        {
            connectionDB();
            DataTable dt = new DataTable();
            string ssql = "";

            ssql = "SELECT * FROM ref_region ORDER BY regionName ASC";
            dt = rs.CreateDataTableFromQry(ssql);
            return dt;
        }

        public bool UpdateRegion(string Regioname, int regionId)
        {
            connectionDB();
            bool rtval = true;
            string ssql = "";
            try
            {
                ssql = "UPDATE ref_region SET regionName= '"+ Regioname + "' WHERE region_id = '"+ regionId +"'";
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

        public bool SaveRegion(string Regioname)
        {
            connectionDB();
            bool rtval = true;
            string ssql = "";
            try
            {
                ssql = "INSERT INTO ref_region(regionName)"
                     + " VALUES('" + Regioname + "')";
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
