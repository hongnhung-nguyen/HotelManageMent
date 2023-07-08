using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Oracle.DataAccess.Client;
using Oracle.ManagedDataAccess.Client;
using src.BUS;

namespace src.DB
{
    class Room_DB
    {
        public static Room_BUS getTTPhong(string maphong)
        {
            OracleConnection conn = Connection.GetDBConnection();
            conn.Open();
            string query = $"select * from HOTEL_PUBLIC.A_PHONG A WHERE A.MAPHONG = '{maphong}'";
            OracleCommand command = new OracleCommand(query, conn);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                return new Room_BUS(
                    reader["MAKH"].ToString(),
                    reader["LOAIPHONG"].ToString(),
                    reader["GIA"].ToString(),
                    reader["TINHTRANG"].ToString(),
                    reader["SONGUOI"].ToString()
                    );
            }
            conn.Close();
            return new Room_BUS();
        }

        public static int UpdateTTPhong(Room_BUS room)
        {
            OracleConnection conn = Connection.GetDBConnection();
            conn.Open();
            string orlupdate = $"UPDATE HOTEL_PUBLIC.A_PHONG SET LOAIPHONG = :loaiphong, GIA = :gia, TINHTRANG = :tinhtrang, SONGUOI = :songuoi WHERE MAPHONG = :maphong";
            OracleCommand cmd = new OracleCommand(orlupdate, conn);
            cmd.Parameters.Add(new OracleParameter("loaiphong", room.LoaiPhong));
            cmd.Parameters.Add(new OracleParameter("gia", room.Gia));
            cmd.Parameters.Add(new OracleParameter("tinhtrang", room.TinhTrang));
            cmd.Parameters.Add(new OracleParameter("songuoi", room.SoNguoi));
            cmd.Parameters.Add(new OracleParameter("maphong", room.MaPhong));
            int count = cmd.ExecuteNonQuery();
            return count;
        }
    }
}
