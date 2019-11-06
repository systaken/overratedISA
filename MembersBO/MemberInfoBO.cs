using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using ASPFSols;

namespace MembersBO
{
    public class MemberInfoBO : GlobalVar
    {
        //register
        public string _err;

        public bool Register(string studetno,string cardno, string fname, string lname, string mname, string GLevel, string section_id, string GuardianName, 
            string bdate, string addr1, string addr2, string addr3, string telno, string faxno, string emailadd, string userid, string todaydate, string gender, string pixUrl = "")
        {
            connectionDB();
            string ssql = "";
            bool rtval = false;
            try
            {
                ssql = "INSERT INTO [ref_members]([student_no],[card_no],[FirstName],[LastName],[MiddleInitial]"
                       + ",[GLevel],[section_id],[GuardianName],[Bdate],[Addr1],[Addr2],[Addr3],[TelNo],[FaxNo],[EmailAdd],[PixUrl],[DateCreated],[CreatedBy],[Gender])"
                       + "VALUES('"+ studetno +"','" + cardno + "','" + fname + "',"
                       + "'" + lname + "','" + mname + "','" + GLevel + "','" + section_id + "','" + GuardianName + "'," 
                       + "'" + bdate + "','" + addr1 + "','" + addr2 + "','" + addr3 + "','" + telno + "','" + faxno + "','" + emailadd + "','" + pixUrl + "',"
                       + " '" + todaydate + "','" + userid + "','" + gender + "')";

                rs.ExecuteSQL(ssql);
                rtval = true;
            }
            catch (Exception ex)
            {
                _err = "System Error Found Please check. " + ex.ToString();
                rtval = false;
            }
            return rtval;
        }


        public bool UpdateMember(string student_no, string cardno, string fname, string lname, string mname, string GLevel, string section_id, string GuardianName,
           string bdate, string addr1, string addr2, string addr3, string telno, string faxno, string emailadd, string userid, string todaydate, string gender, string recordid, string pixUrl = "")
        {
            connectionDB();
            string ssql = "";
            bool rtval = false;
            try
            {
                ssql = "UPDATE ref_members SET FirstName = '" + fname + "', LastName = '" + lname + "', MiddleInitial = '" + mname + "' , GLevel = '" + GLevel + "',"
                       + " section_id = '" + section_id + "',GuardianName = '" + GuardianName + "',"
                       + " Bdate = '" + bdate + "',Addr1 = '" + addr1 + "',Addr2 = '" + addr2 + "',Addr3 = '" + addr3 + "', TelNo = '" + telno + "', Faxno = '" + faxno + "',"
                       + " EmailAdd = '" + emailadd + "', student_no = '" + student_no + "', card_no = '"+ cardno +"' WHERE member_id = '" + recordid + "'";

                rs.ExecuteSQL(ssql);
                rtval = true;
            }
            catch (Exception ex)
            {
                _err = "System Error Found Please check. " + ex.ToString();
                rtval = false;
            }
            return rtval;
        }


        public DataTable DeactiveSelectAll()
        {
            string ssql;
            connectionDB();
            ssql = "SELECT top 1000 * FROM ref_members WHERE isActive = 0 ORDER BY LastName ASC";
            return rs.CreateDataTableFromQry(ssql);
        }

        public DataTable DeactiveSelectByLetters(string letterss)
        {
            string ssql;
            connectionDB();
            ssql = "SELECT * FROM ref_members WHERE LastName LIKE '" + letterss + "%' AND isActive = 0 ORDER BY Lastname DESC";
            return rs.CreateDataTableFromQry(ssql);
        }

        public DataTable DeactiveSelectBysearch(string searchby, string searchitem)
        {
            string ssql;
            connectionDB();
            ssql = "SELECT * FROM ref_members WHERE isActive = 0 AND " + searchby + " LIKE'" + searchitem + "%' ORDER BY " + searchby + " ASC";
            return rs.CreateDataTableFromQry(ssql);
        }

        public DataTable SelectAll()
        {
            string ssql;
            connectionDB();
            ssql = "SELECT top 500 * FROM ref_members where isActive = 1 ORDER BY LastName ASC";
            return rs.CreateDataTableFromQry(ssql);
        }


        public DataTable StudentCard(string cardNo)
        {
            string ssql;
            connectionDB();
            ssql = "SELECT * FROM ref_members WHERE isActive = 1 AND card_no = '"+ cardNo +"'";
            return rs.CreateDataTableFromQry(ssql);
        }

        public bool isCanRegister(int CountStop)
        {
            string ssql;
            bool rtval = false; 
            connectionDB();
            ssql = "SELECT count(member_id) as TotalMember FROM ref_members where iSActive = 1";
            DataTable dt = new DataTable();
            dt = rs.CreateDataTableFromQry(ssql);

            foreach (DataRow drow in dt.Rows)
            {
                if (Convert.ToInt16(drow["TotalMember"]) == CountStop)
                {
                    rtval = false;
                }
                else
                {
                    rtval = true;
                }
            }
            return rtval;   
        }

        public DataTable SelectAllNonLife()
        {
            string ssql;
            connectionDB();
            ssql = "SELECT * FROM ref_members WHERE iSLifeMember = 0";
            return rs.CreateDataTableFromQry(ssql);
        }

        public DataTable SelectByLetters(string letterss)
        {
            string ssql;
            connectionDB();
            ssql = "SELECT * FROM ref_members WHERE LastName LIKE '" + letterss + "%' ORDER BY Lastname DESC";
            return rs.CreateDataTableFromQry(ssql);
        }

        public DataTable SelectBysearch(string searchby, string searchitem)
        {
            string ssql;
            connectionDB();
            ssql = "SELECT * FROM ref_members WHERE " + searchby + " LIKE '" + searchitem + "%' AND iSActive = 1 ORDER BY " + searchby + " ASC";
            return rs.CreateDataTableFromQry(ssql);
        }

        public bool DeactivateMember(string id)
        {
            bool rtval = false;
            connectionDB();
            try
            {
                string ssql = "";
                ssql = "UPDATE ref_members SET iSActive = 0 WHERE member_id = '" + id + "'";
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

        public bool ActivateMember(string id)
        {
            bool rtval = false;
            connectionDB();
            try
            {
                string ssql = "";
                ssql = "UPDATE ref_members SET iSActive = 1 WHERE member_id = '" + id + "'";
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

        public DataTable GetMemberProfile(string memberid)
        {
            string ssql = "";
            connectionDB();
            ssql = "SELECT * FROM ref_members WHERE member_id = '" + memberid + "'";
            return rs.CreateDataTableFromQry(ssql);
        }

        public Int32 GetMemberID(string cardno)
        {
            Int32 rtval = 0;
            connectionDB();
            string ssql;
            DataTable dt = new DataTable();
            ssql = "SELECT member_id FROM ref_members WHERE card_no = '" + cardno + "'";
            dt = rs.CreateDataTableFromQry(ssql);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow drow in dt.Rows)
                {
                    rtval = Convert.ToInt32(drow["member_id"]);
                }
            }
            else
            {
                rtval = 0;
                _err = "No Record Found";
            }
            return rtval;
        }

        public string IsStatus(string memberid)
        {
            string ssql = "";
            string rtval = "";
            connectionDB();
            DataTable dt = new DataTable();
            ssql = "SELECT iSActive, iSLifeMember, member_id FROM ref_members WHERE member_id = '" + memberid + "'";
            dt = rs.CreateDataTableFromQry(ssql);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow drow in dt.Rows)
                {
                    if (drow["iSActive"].ToString() == "True")
                    {
                        if (drow["iSLifeMember"].ToString() == "True")
                        {
                            rtval = "Life";
                        }
                        else
                        {
                            rtval = "Active";
                        }
                    }
                    else
                    {
                        rtval = "Non - Active";
                    }

                }
            }
            else
            {
                rtval = "";
            }
            return rtval;
        }

        public double GetMemberDues(string memberid)
        {
            connectionDB();
            string ssql = "";
            double rtval = 0.00;
            DataTable dt = new DataTable();
            ssql = "SELECT TotalBalance FROM trn_payment where member_id = '" + memberid + "' AND isPaid = 0";
            dt = rs.CreateDataTableFromQry(ssql);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow drow in dt.Rows)
                {
                    if (drow["TotalBalance"].ToString() != "")
                    {
                        rtval = Convert.ToDouble(drow["TotalBalance"].ToString());
                    }
                    else
                    {
                        rtval = 0.00;
                    }
                }
            }
            else
            {
                rtval = 0.00;
            }
            return rtval;
        }

        public bool MemberChangeStatus(string memberid, string status)
        {
            string ssql = "";
            bool rtval = false;
            try
            {
                if (status == "Life")
                {
                    ssql = "UPDATE ref_members SET  iSLifeMember = 1, iSActive = 1 WHERE member_id  = '" + memberid + "'";
                }
                else if (status == "Active")
                {
                    ssql = "UPDATE ref_members SET  iSLifeMember = 0, iSActive = 1 WHERE member_id  = '" + memberid + "'";
                }
                else if (status == "Non - Active")
                {
                    ssql = "UPDATE ref_members SET  iSLifeMember = 0, iSActive = 0 WHERE member_id  = '" + memberid + "'";
                }
                rtval = true;
                rs.ExecuteSQL(ssql);
            }
            catch (Exception ex)
            {
                _err = ex.ToString();
                rtval = false;
            }
            return rtval;
        }

        public Int32 GetMemberID2(string firstname, string lastname, string MI)
        {
            connectionDB();
            Int32 rtval = 0;
            string ssql;
            DataTable dt = new DataTable();
            ssql = "SELECT member_id FROM ref_members WHERE FirstName = '" + firstname + "' AND  LastName = '" + lastname + "' AND MiddleInitial  = '" + MI + "'";
            dt = rs.CreateDataTableFromQry(ssql);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow drow in dt.Rows)
                {
                    rtval = Convert.ToInt32(drow["member_id"]);
                }
            }
            else
            {
                rtval = 0;
                _err = "No Record Found";
            }
            return rtval;
        }
    }
}
