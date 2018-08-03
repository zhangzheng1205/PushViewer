using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushViewer
{
    class SqlQuery
    {
        #region 使用されているBeaconのminorのリストを作成
        public string GetMinorList()
        {
            string query = "SELECT minor ";
            query += "FROM MemberBeacon ";
            query += "LEFT JOIN Member ";
            query += "ON MemberBeacon.MemberID = Member.ID ";
            query += "WHERE Grade != '卒業' ";

            return query;
        }
        #endregion

        #region 消費電力を取得
        public string GetEnergy(string ApplianceID)
        {
            string query = "SELECT TOP 1 CEILING(Energy*60) ";
            query += "FROM PowerLog ";
            query += "WHERE Date > dateadd(MINUTE, -10, GETDATE()) ";
            query += "AND ApplianceID = " + ApplianceID + " ";
            query += "ORDER BY Date DESC ";

            return query;
        }
        #endregion

        #region 受信回数を取得
        public string GetCount(string minor, string address)
        {
            string query = "SELECT COUNT(*) ";
            query += "FROM (SELECT FORMAT(Date,'yyyy/MM/dd HH:mm:ss') AS Date ";
            query += "FROM RawBeaconLog ";
            query += "WHERE Date > dateadd(SECOND, -30, GETDATE()) "; // 過去30秒間の受信回数
            query += "AND minor = " + minor + " ";
            query += "AND BluetoothMacAddress = '" + address + "' ";
            query += "AND RSSI > -100 ";
            query += "GROUP BY FORMAT(Date,'yyyy/MM/dd HH:mm:ss')) PerSec ";

            //string query = "SELECT COUNT(*) ";
            //query += "FROM RawBeaconLog ";
            //query += "WHERE Date > dateadd(SECOND, -30, GETDATE()) "; // 過去30秒間の受信回数
            //query += "AND minor = " + minor + " ";
            //query += "AND BluetoothMacAddress = '" + address + "' ";
            //query += "AND RSSI > -100 ";

            return query;
        }
        #endregion

    }
}
