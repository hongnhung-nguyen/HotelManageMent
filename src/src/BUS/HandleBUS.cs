using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
namespace src
{
    class handleBUS
    {
        public DataTable LayDuLieu(string sql)
        {
            OracleConnection conn = Connection.GetDBConnection();
            OracleDataAdapter adapter = new OracleDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public int ThucThi(string sql)
        {

            OracleConnection conn = Connection.GetDBConnection();
            OracleCommand cmd = new OracleCommand(sql, conn);
            conn.Open();
            var kq = cmd.ExecuteNonQuery();
            conn.Close();
            return kq;

        }
    }
}
