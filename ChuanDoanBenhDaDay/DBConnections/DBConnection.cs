﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuanDoanBenhDaDay.DBConnections
{
    class DBConnection
    {
        public SqlConnection getConnect()
        {
           // String conString = @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=HCG_NHOMSO9;Integrated Security=True";
            String conString = @"Data Source=DESKTOP-QMBOBJ0\SQLEXPRESS;Initial Catalog=HCG_NHOMSO9;Integrated Security=True";
            SqlConnection conn = new SqlConnection(conString);
            return conn;
        }
        public DataTable getTable(String sql)
        {
            SqlConnection conn = getConnect();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            adapter.Fill(table);
            return table;
        }
        public void ExceteNonQuery(string sql)
        {
            SqlConnection conn = getConnect();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
