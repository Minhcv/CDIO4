using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLTHUVIEN
{
    class clsDB
    {
        string conStr = @"Data Source=DESKTOP-530ACSJ\SQLEXPRESS;Initial Catalog=QLTHUVIEN;Integrated Security=True";
        SqlConnection con;
        protected SqlDataAdapter da = null;

        public clsDB()
        {
            con = new SqlConnection(conStr);
        }

        void Open()
        {
            if (con.State != System.Data.ConnectionState.Open)
                con.Open();
        }
        void Close()
        {
            if (con.State == System.Data.ConnectionState.Open)
                con.Close();
        }

        public DataSet getDataset(string sql, object[] paraName = null, object[] paraValue = null)
        {
            SqlCommand cmd = new SqlCommand(sql, con);
            if (paraName != null)
            {
                for (int i = 0; i < paraName.Length; i++)
                    cmd.Parameters.AddWithValue("@" + paraName[i], paraValue[i]);
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public int execNonquery(string sql, object[] paraName, object[] paraValue)
        {
            SqlCommand cmd = new SqlCommand(sql, con);
            if (paraName != null)
            {
                for (int i = 0; i < paraName.Length; i++)
                    cmd.Parameters.AddWithValue("@" + paraName[i], paraValue[i]);
            }
            Open();
            int res = cmd.ExecuteNonQuery();
            Close();
            return res;
        }

        //lấy dataset cho combobox
        public DataSet get_daset(string sql, string tenbang)
        {

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(ds, tenbang);
            return ds;
        }

        //Lay ra du lieu ra table 
        public DataTable TaoBang(String sqlString)
        {
            Open();
            DataTable ds = new DataTable();
            da = new SqlDataAdapter(sqlString, con);
            da.Fill(ds);
            Close();
            return ds;
        }

    }
}
