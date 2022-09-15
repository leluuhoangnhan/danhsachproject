using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DoAn_CongNgheNet_QuanLiDuAnBDS.Model
{
    class DB_QLDA
    {
        public SqlConnection conn;

        public DB_QLDA()
        {
            conn = new SqlConnection("Data Source = LELUUHOANGNHAN; Initial Catalog = DB_QLDA; User ID = sa; Password = 1321");
        }

        public void Open()
        {
            conn.Open();
        }

        public void Close()
        {
            conn.Close();
        }

        public bool checkConnect()
        {
            if(conn.State == ConnectionState.Open)
            {
                return true;
            }
            return false;
        }

    }
}
