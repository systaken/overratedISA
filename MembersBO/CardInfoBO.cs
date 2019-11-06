using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using ASPFSols;
namespace MembersBO
{
    public class CardInfoBO : GlobalVar
    {
        public string _err;

        public string getCardNo(string memberid)
        {
            connectionDB();
            string ssql = "";
            string rtval = "";
            DataTable dt = new DataTable();
            ssql = "SELECT card_no FROM ref_members WHERE member_id = '" + memberid + "'";
            dt = rs.CreateDataTableFromQry(ssql);
            foreach (DataRow drow in dt.Rows)
            {
                rtval = drow["card_no"].ToString();
            }
            return rtval;
        }

        public DataTable CardList()
        {
            connectionDB();
            string ssql = "";
            DataTable dts = new DataTable();
            ssql = "SELECT top 500 * FROM ref_card";
            dts = rs.CreateDataTableFromQry(ssql);
            return dts;
        }

        public DataTable GetCardInfo(string cardId)
        {
            connectionDB();
            string ssql = "";
            DataTable dt = new DataTable();
            ssql = "SELECT * FROM ref_card WHERE card_id = '" + cardId + "' ";
            dt = rs.CreateDataTableFromQry(ssql);
            return dt;
        }



        public int getCardId(string memberid, string cardNo)
        {
            connectionDB();
            int rtval = 0;
            string ssql = "";
            DataTable dt = new DataTable();
            ssql = "SELECT * FROM ref_card WHERE cardNo = '" + cardNo + "' AND memberid = '" + memberid + "'";
            dt = rs.CreateDataTableFromQry(ssql);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow drow in dt.Rows)
                {
                    rtval = Convert.ToInt16(drow["card_id"]);
                }
            }
            else
            {
                rtval = 0;
            }
            return rtval;
        }

        public string getCardId(string cardNo)
        {
            connectionDB();
            string rtval = "";
            string ssql = "";
            DataTable dt = new DataTable();
            ssql = "SELECT * FROM ref_card WHERE SerialNos = '" + cardNo + "' AND isIssued = 1 AND iSActive = 1";
            dt = rs.CreateDataTableFromQry(ssql);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow drow in dt.Rows)
                {
                    rtval = drow["cardNo"].ToString();
                }
            }
            else
            {
                rtval = "";
            }
            return rtval;
        }


        public bool CardIncidentEntry(string cardno, string memberid, string remarks, string createdby, string incidentDate, string isActive, string cardid)
        {
            connectionDB();
            bool rtval = false;
            string ssqlups = "";
            int iActive = 0;
            string ssql = "";
            try
            {
                ssql = "INSERT INTO ref_cardIncident(cardNo,member_id,Remarks,incidentDate,dateCreated,CreatedBy)"
                     + " VALUES('" + cardno + "','" + memberid + "','" + remarks + "','" + incidentDate + "','" + DateTime.Now + "','" + createdby + "')";
                rs.ExecuteSQL(ssql);
                if (isActive != "")
                {
                    if (isActive.ToString() == "1")
                    {
                        iActive = 0;
                    }
                    else if (isActive.ToString() == "0")
                    {
                        iActive = 1;
                    }
                    ssqlups = "UPDATE ref_card SET isActive = " + iActive + " WHERE card_id = '" + cardid + "'";
                    rs.ExecuteSQL(ssqlups);
                }
                rtval = true;
            }
            catch (Exception ex)
            {
                rtval = false;
                _err = ex.ToString();
            }
            return rtval;
        }

        public bool reIssueCard(string prevcardno, string newcard, string serialNos, string memberid, string reason, string username)
        {
            connectionDB();
            bool rtval = false;
            string ssql = "";
            try
            {
                ssql = "INSERT INTO trn_reIssueCard(previous_card,New_card,Reason,dateCreated,createdBy,member_id)"
                + " VALUES('" + prevcardno + "','" + newcard + "','" + reason + "','" + DateTime.Now + "','" + username + "','" + memberid + "')";
                rs.ExecuteSQL(ssql);

                ssql = "UPDATE ref_card SET cardNo = '" + newcard + "', SerialNos = '" + serialNos + "' WHERE MemberId = '" + memberid + "' AND cardNo = '" + prevcardno + "'";
                rs.ExecuteSQL(ssql);

                ssql = "UPDATE ref_members SET card_no = '" + newcard + "' WHERE member_id  = '" + memberid + "'";
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

        public DataTable IncidentHistory()
        {
            connectionDB();
            string ssql = "";
            ssql = "SELECT * FROM ref_cardIncident ORDER BY dateCreated DESC";
            return rs.CreateDataTableFromQry(ssql);
        }

        public DataTable IncidentHistory(string datefrom, string dateto)
        {
            string ssql = "";
            string dtrom, dtto;
            dtrom = datefrom + " 00:00:00";
            dtto = dateto + " 23:59:59";
            ssql = "SELECT * FROM ref_cardIncident WHERE incidentDate BETWEEN '" + dtrom + "' AND '" + dtto + "'";
            return rs.CreateDataTableFromQry(ssql);
        }
    }
}
