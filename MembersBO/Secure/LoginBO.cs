using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using ASPFSols;


namespace MembersBO.Secure
{
    public class LoginBO : GlobalVar
    {
        public string _err;
        public string _userId;
        public string _gId;
        public bool IsAuthenticated(string username, string password)
        {
            connectionDB();
            bool isLogin = false;
            string ssql = "";
            DataTable dts = new DataTable();

            ssql = "SELECT * FROM trn_user WHERE username = '" + username + "' AND isAcive = 1";
            dts = rs.CreateDataTableFromQry(ssql);
            if (dts.Rows.Count > 0)
            {
                foreach (DataRow drow in dts.Rows)
                {
                    if (drow["password"].ToString() == password)
                    {
                        isLogin = true;
                        _gId = drow["group_id"].ToString();
                        _userId = drow["user_id"].ToString();
                    }
                    else
                    {
                        _err = "Password is invalid";
                        isLogin = false;
                    }
                }
            }
            else
            {
                _err = "Username is invalid";
                isLogin = false;
            }
            return isLogin;
        }

        public bool addUser(string uname, string pwd, string fname, string lname, string groupid)
        {
            string ssql = "";
            bool rtval = false;
            connectionDB();
            try
            {
                ssql = "INSERT INTO trn_user(username,password,firstname,lastname,group_id,isAcive)"
                      + " VALUES('" + uname + "','" + pwd + "','" + fname + "','" + lname + "','" + groupid + "','1')";
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

        public DataTable getAccess(string groupid)
        {
            connectionDB();
            string ssql = "";
            DataTable dts = new DataTable();
            ssql = "SELECT * FROM trn_access WHERE group_id = '" + groupid + "'";
            dts = rs.CreateDataTableFromQry(ssql);
            return dts;
        }

        public DataTable loadUsers(string isActive)
        {
            connectionDB();
            string ssql = "";
            DataTable dts = new DataTable();
            ssql = "SELECT * FROM vw_users WHERE isAcive ='" + isActive + "'";
            dts = rs.CreateDataTableFromQry(ssql);
            return dts;
        }

        public DataTable groupings()
        {
            connectionDB();
            string ssql = "";
            DataTable dts = new DataTable();
            ssql = "SELECT * FROM trn_group ORDER BY userLevel ASC";
            dts = rs.CreateDataTableFromQry(ssql);
            return dts;
        }

        public bool Delete(string userid)
        {
            connectionDB();
            bool rtval = false;
            string ssql = "";
            try
            {
                ssql = "UPDATE trn_user SET isAcive = 0 WHERE user_id = '" + userid + "'";
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
