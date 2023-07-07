using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using src.BUS;
namespace src.DB
{
    class RoomDB
    {
        public static DataTable DB_ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            using (OracleConnection connection = Connection.GetDBConnection())
            {
                connection.Open();
                OracleCommand command = new OracleCommand(query, connection);

                if (parameter != null)
                {
                    command.CommandType = CommandType.StoredProcedure;

                    foreach (string item in parameter)
                    {
                        command.Parameters.Add(new OracleParameter($"{item}", item));
                    }
                }

                OracleDataAdapter adapter = new OracleDataAdapter(command);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }

        public static DataTable getRoomListDB(string tinhTrang, string loaiPhong, float mucGiaMin, float mucGiaMax)
        {
            DataTable result = new DataTable();
            string query = $"select * from HOTEL_PUBLIC.A_PHONG A";// where A.GIA >= {mucGiaMin} and  A.GIA < {mucGiaMax}";//and A.LOAIPHONG = '{loaiPhong}'    A.TINHTRANG = '{tinhTrang}' and
            OracleConnection conn = Connection.GetDBConnection();
            conn.Open();
            OracleCommand command = new OracleCommand(query, conn);
            OracleDataAdapter adapter = new OracleDataAdapter(command);
            adapter.Fill(result);
            conn.Close();
            return result;
        }

        public static DataTable getTTPhongDB()
        {
            string query = "SELECT TINHTRANG from A_PHONG";
            DataTable data = new DataTable();

            using (OracleConnection conn = Connection.GetDBConnection())
            {
                conn.Open();

                using (OracleCommand command = new OracleCommand(query, conn))
                {
                    OracleDataAdapter adapter = new OracleDataAdapter(command);
                    adapter.Fill(data);
                }
            }
            return data;
        }

        public static float GetGiaByMaPhong(string MaPhong)
        {
            OracleConnection conn = Connection.GetDBConnection();
            conn.Open();

            string query = $"select GIA from HOTEL_PUBLIC.A_PHONG A WHERE A.MAPHONG = '{MaPhong}'";
            OracleCommand command = new OracleCommand(query, conn);

            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                return float.Parse(reader["GIA"].ToString());
            }
            conn.Close();
            return 0;

        }

        public static int setRoomStatus(string MaPhong, string status)
        {
            OracleConnection conn = Connection.GetDBConnection();
            conn.Open();
            string query = $"update HOTEL_PUBLIC.A_PHONG A set A.TINHTRANG = '{status}' where MAPHONG = '{MaPhong}'";
            OracleCommand command = new OracleCommand(query, conn);
            int result = Convert.ToInt32(command.ExecuteNonQuery());
            return result;
        }
    }
}
