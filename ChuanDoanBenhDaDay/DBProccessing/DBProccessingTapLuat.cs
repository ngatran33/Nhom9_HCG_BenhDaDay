using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChuanDoanBenhDaDay.DBConnections;

namespace ChuanDoanBenhDaDay.DBProccessing
{
    class DBProccessingTapLuat
    {
        DBConnection dbConn = new DBConnection();

        public DataTable showSuKien()
        {
            String sql = "SELECT * FROM SUKIEN";
            DataTable table = dbConn.getTable(sql);
            return table;
        }
        public DataTable showLuat()
        {
            String sql = "SELECT * FROM LUAT";
            DataTable table = dbConn.getTable(sql);
            return table;
        }

        public void addLuat(String ma, String vt, string vp)
        {
            String sql = "INSERT INTO LUAT VALUES('"+ ma + "', '" + vt + "', '" + vp + "')";
            dbConn.ExceteNonQuery(sql);
        }
        public void updateLuat(String ma, String vt, string vp)
        {
            String sql = "UPDATE LUAT SET VeTrai= '" + vt + 
                "',VePhai= '" + vp + 
                "' WHERE MaLuat= '" + ma + "'";
            dbConn.ExceteNonQuery(sql);
        }
        public Boolean checkMaLuat(String ma)
        {
            String sql = "SELECT * FROM LUAT WHERE MaLuat='"+ma+"'";
            DataTable table = dbConn.getTable(sql);
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool check(String vt, String vp)//true: khong ton tai
        {
            DataTable luat = showLuat();
            foreach(DataRow s in luat.Rows)
            {
                String vtrai = s.ItemArray[1].ToString();
                String vPhai = s.ItemArray[2].ToString();
                if(checkvt(vt, vtrai) && vp.Equals(vPhai))
                {
                    return false;
                }
            }
            return true;
        }
        public bool checkvt(String vt1, String vt2)//true khi bang nhau
        {
            List<String> listVt1 = toArraycheck(vt1);
            List<String> listVt2 = toArraycheck(vt2);
            if(listVt1.Count!= listVt2.Count)
            {
                return false;
            }
            int n= 0;
            foreach(String s in listVt2)
            {
                foreach(String s1 in listVt1)
                {
                    if (s.Equals(s1))
                    {
                        n++;
                    }
                }
            }
            if (n == listVt1.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public List<String> toArraycheck(String vt)
        {
            List<String> listVt = new List<string>();
            int count = vt.Length - vt.Replace("^", "").Length + 1; //Số sự kiện bên vế trái
            for (int i = 0; i < count-1; i++)
            {
                    string t = "";
                    t = vt.Substring(0, vt.IndexOf("^"));
                    vt = vt.Substring(vt.IndexOf("^") + 1);
                    listVt.Add(t);
            }
            listVt.Add(vt);
            return listVt;
        }
                public void deleteLuat(String ma)
        {
            String sql = "DELETE FROM LUAT WHERE MaLuat='" + ma + "'";
            dbConn.ExceteNonQuery(sql);
        }

        public List<String> getAllLuat()
        {
            List<String> R = new List<string>();
            DataTable table = showLuat();
            foreach(DataRow dr in table.Rows)
            {
                String vt = dr.ItemArray[1].ToString();
                String ma = dr.ItemArray[0].ToString();
                String vp = dr.ItemArray[2].ToString();

                String luat = ma + ":" + vt + "->" + vp;
                R.Add(luat);
            }
            return R;
        }

        public String getVPbyML(String ma)
        {
            String sql = "SELECT * FROM LUAT WHERE MaLuat='" + ma + "'";
            DataTable table = dbConn.getTable(sql);
            if (table.Rows.Count > 0)
            {
                return table.Rows[0].ItemArray[2].ToString();
            }
            else
            {
                return "";
            }
        }

        public List<String> toArrayVT(String vt)
        {
            List<String> listVt = new List<string>();
            int count = vt.Length - vt.Replace("^", "").Length +1; //Số sự kiện bên vế trái
            vt = vt.Substring(vt.IndexOf(":") + 1); //Cắt mã luật
            for (int i = 0; i < count; i++)
            {
                if (vt.IndexOf("^") != -1)
                {
                    string t = "";
                    t = vt.Substring(0, vt.IndexOf("^"));
                    vt = vt.Substring(vt.IndexOf("^") + 1);
                    listVt.Add(t);
                }
                else
                {
                    string t = "";
                    t = vt.Substring(0, vt.IndexOf("->"));
                    listVt.Add(t);
                }
            }
            return listVt;
        }

        public String getMaLuat(String luat)
        {
            String t = luat.Substring(0, luat.IndexOf(':'));
            return t;
        }

        public String getLuatbyMaLuat(String ma)
        {
            String sql = "SELECT * FROM LUAT WHERE MaLuat='" + ma + "'";
            DataTable table = dbConn.getTable(sql);
            if (table.Rows.Count > 0)
            {
                String vt = table.Rows[0].ItemArray[1].ToString();
                String vp = table.Rows[0].ItemArray[2].ToString();

                return ma + ":" + vt + "->" + vp;
            }
            else
            {
                return "";
            }
        }
        public String getVpByVt(String vt)
        {
            List<String> R = new List<string>();
            DataTable table = showLuat();
            foreach (DataRow dr in table.Rows)
            {
                String vtrai = dr.ItemArray[1].ToString();
                String ma = dr.ItemArray[0].ToString();
                String vp = dr.ItemArray[2].ToString();

                if (vt.Equals(vtrai))
                {
                    return vp;
                }
            }
            return "";
        }
    }
}
