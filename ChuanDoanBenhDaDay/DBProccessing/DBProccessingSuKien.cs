using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ChuanDoanBenhDaDay.DBProccessing
{
    class DBProccessingSuKien
    {
        DBConnections.DBConnection dataConn = new DBConnections.DBConnection();
        public DataTable showSukien()
        {
            String sql = "Select * from SUKIEN";
            DataTable table = new DataTable();
            table = dataConn.getTable(sql);
            return table;
        }

        public DataTable showLuat()
        {
            String sql = "SELECT * FROM LUAT";
            DataTable table = new DataTable();
            table = dataConn.getTable(sql);
            return table;
        }

        public void InsertSuKien(String maSK, String moTa)
        {
            String sql = "Insert into SUKIEN values ('" + maSK + "', N'" + moTa + "')";
            dataConn.ExceteNonQuery(sql);
        }

        public void UpdateSuKien(String maSK, String moTa)
        {
            String sql = "Update SUKIEN set MoTa=N'" + moTa + "' where MaSK='" + maSK + "'"; 
                
            dataConn.ExceteNonQuery(sql);
        }

        public void DeleteSuKien(String maSK)
        {
            String sql = "Delete SUKIEN where MaSK='" + maSK + "'" ;
            dataConn.ExceteNonQuery(sql);
        }

        public bool CheckMaSuKien(String maSK)
        {
            String sql = "Select * from SUKIEN where MaSK='" + maSK + "'";
            DataTable table = dataConn.getTable(sql);
            if (table.Rows.Count > 0)
                return true;
            else 
                return false;
        }

        public bool check(String maSK)
        {
            DataTable luat = showLuat();
            foreach (DataRow s in luat.Rows)
            {
                String vTrai = s.ItemArray[1].ToString();
                String vPhai = s.ItemArray[2].ToString();
                if (vTrai.Contains(maSK) || vPhai.Contains(maSK))
                {
                    return false;
                }
            }
            return true;
        }

        public string GetMoTaByMaSuKien(string maSK)
        {
            String sql = "SELECT * FROM SUKIEN WHERE MaSK='" + maSK + "'";
            DataTable table = dataConn.getTable(sql);
            if (table.Rows.Count > 0)
            {
                String moTa = table.Rows[0].ItemArray[1].ToString();

                return maSK + ":" + moTa;
            }
            else
            {
                return "";
            }
        }

        public String getMaSK(String suKien)
        {
            String t = suKien.Substring(0, suKien.IndexOf(':'));
            return t;
        }

        public List<String> getAllSuKien()
        {
            List<String> R = new List<string>();
            DataTable table = showSukien();
            foreach (DataRow dt in table.Rows)
            {
                String maSK = dt.ItemArray[0].ToString();
                String moTa = dt.ItemArray[1].ToString();

                String suKien = maSK + ":" + moTa;
                R.Add(suKien);
            }
            return R;
        }
        public DataTable GetDataForDgv_SuKien2(String s)
        {
            string sql = "Select * from SUKIEN where MoTa Like N'%" + s + "%'";
            DataTable table = dataConn.getTable(sql);
            return table;
        }
    }
}
