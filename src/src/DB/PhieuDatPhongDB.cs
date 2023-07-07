using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using src.BUS;
namespace src.DB
{
    class PhieuDatPhongDB
    {
        public static int countPhieuDatPhong()
        {
            OracleConnection conn = Connection.GetDBConnection();
            conn.Open();
            string query = $"select count(*) from HOTEL_PUBLIC.A_PHIEUDATPHONG";
            OracleCommand command = new OracleCommand(query, conn);
            int result = Convert.ToInt32(command.ExecuteScalar());
            conn.Close();
            return result;
        }

        public static int insertPDP(PhieuDatPhongBUS  pdp)
        {
            OracleConnection conn = Connection.GetDBConnection();
            conn.Open();

            //TO_DATE('{pdp.NgayBD.ToString().Substring(0, kh.NgaySinh.ToString().Length - 3)}'

            string ngayDB = $"TO_DATE('{pdp.NgayBD.ToString().Substring(0, pdp.NgayBD.ToString().Length - 3)}','dd/mm/yyyy HH:mi:ss')";
            string NgayKT = $"TO_DATE('{pdp.NgayKT.ToString().Substring(0, pdp.NgayKT.ToString().Length - 3)}','dd/mm/yyyy HH:mi:ss')";
            string NgayLap = $"TO_DATE('{pdp.NgayLap.ToString().Substring(0, pdp.NgayLap.ToString().Length - 3)}','dd/mm/yyyy HH:mi:ss')"; ;


            string query = $"insert into HOTEL_PUBLIC.A_PHIEUDATPHONG values('{pdp.MaPhieu}', '{pdp.MaPhong}', {ngayDB}, {NgayKT}, NULL, '{pdp.MaNV}', {NgayLap} ,'{pdp.MaKH}',{pdp.TongTien}, {pdp.DaThanhToan},0)";
            OracleCommand command = new OracleCommand(query, conn);
            int result = Convert.ToInt32(command.ExecuteNonQuery());
            if(result >= 1)
            {
                RoomDB.setRoomStatus(pdp.MaPhong, "Đã đặt");
            }    
            conn.Close();
            return result;
        }
         

      
        public static string getMaKH_DangDatPhong(string maphong)
        {
            OracleConnection conn = Connection.GetDBConnection();
            conn.Open();

            string query = $"SELECT MAKH from HOTEL_PUBLIC.A_PHIEUDATPHONG where MAPHONG = '{maphong}' and TRAPHONG = 0";
            OracleCommand command = new OracleCommand(query, conn);

            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                return (reader["MAKH"].ToString());
            }
            conn.Close();
            return "";

        }

        public static PhieuDatPhongBUS getPhieuDatPhongByMaPhong(string maPhong)
        {
            OracleConnection conn = Connection.GetDBConnection();
            conn.Open();

            string query = $"SELECT MAPHIEU,MAPHONG,NGAYBD,NGAYKT from HOTEL_PUBLIC.A_PHIEUDATPHONG where MAPHONG = '{maPhong}' and TRAPHONG = 0";
            OracleCommand command = new OracleCommand(query, conn);

            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                return new PhieuDatPhongBUS(

                    reader["MAPHIEU"].ToString(),
                    reader["MAPHONG"].ToString(),
                    DateTime.Parse(reader["NGAYBD"].ToString()),
                    DateTime.Parse(reader["NGAYKT"].ToString())
                );
            }
            conn.Close();
            return new PhieuDatPhongBUS();
        }


    }
}
