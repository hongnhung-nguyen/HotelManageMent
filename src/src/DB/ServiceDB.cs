using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using Oracle.DataAccess.Client;
using System.Text;
using System.Threading.Tasks;
using src.BUS;
namespace src.DB
{
    class ServiceDB
    {
        public static DataTable getlistDV()
        {
            string query = "SELECT * from HOTEL_PUBLIC.A_DICHVU";
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

        public static DataTable getlistCTDV( string MaPhieuDV)
        {
            string query = $"SELECT * from HOTEL_PUBLIC.A_CHITIETPHIEUDV A, HOTEL_PUBLIC.A_PHIEUDV B where A.MAPHIEU = B.MAPHIEU AND B.TINHTRANG = 'Chưa thanh toán' AND  B.MAPHIEU = '{MaPhieuDV}'";
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

        public static bool DropCTDVu(string MaPhieu, string MaDV)
        {
            OracleConnection conn = Connection.GetDBConnection();
            conn.Open();

            string query = $"delete from HOTEL_PUBLIC.A_CHITIETPHIEUDV WHERE MAPHIEU = '{MaPhieu}' AND MADV = '{MaDV}'";
            OracleCommand command = new OracleCommand(query, conn);
            int result = Convert.ToInt32(command.ExecuteNonQuery());
            conn.Close();
            return result >= 1 ? true : false;
        }

        public static bool InsertCTDVu(string MaPhieu, string MaDV,float sotien)
        {
            OracleConnection conn = Connection.GetDBConnection();
            conn.Open();
            string query = $"insert into HOTEL_PUBLIC.A_CHITIETPHIEUDV values('{MaPhieu}','{MaDV}',{sotien})";
            OracleCommand command = new OracleCommand(query, conn);
            int result = Convert.ToInt32(command.ExecuteNonQuery());
            conn.Close();
            return result >= 1 ? true : false;
        }


        public static DataTable getListDVName()
        {
            string query = $"SELECT TENDV from HOTEL_PUBLIC.A_DICHVU";// where TENDV = '{DVname}'";
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
        public static string GetMaDVByTenDV(string TenDV)
        {
            OracleConnection conn = Connection.GetDBConnection();
            conn.Open();

            string query = $"SELECT MADV from HOTEL_PUBLIC.A_DICHVU where TENDV = '{TenDV}'";
            OracleCommand command = new OracleCommand(query, conn);

            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                return (reader["MADV"].ToString());
            }
            conn.Close();
            return "";

        }

        public static float GetGiaDVuByTenDV(string TenDV)
        {
            OracleConnection conn = Connection.GetDBConnection();
            conn.Open();

            string query = $"SELECT GIA from HOTEL_PUBLIC.A_DICHVU where TENDV = '{TenDV}'";
            OracleCommand command = new OracleCommand(query, conn);

            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                return float.Parse(reader["GIA"].ToString());
            }
            conn.Close();
            return 0;

        }

        public static float GetTongTienDichVuByMaPhong(string MaPhong)
        {
            OracleConnection conn = Connection.GetDBConnection();
            conn.Open();

            string query = $"SELECT TONGTIEN from HOTEL_PUBLIC.A_PHIEUDV where MAPHONG = '{MaPhong}'";
            OracleCommand command = new OracleCommand(query, conn);

            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                return float.Parse(reader["TONGTIEN"].ToString());
            }
            conn.Close();
            return 0;

        }




        public static int DemTongPhieuDV()
        {
            OracleConnection conn = Connection.GetDBConnection();
            conn.Open();
            string query = $"select count(*) from HOTEL_PUBLIC.A_PHIEUDV";
            OracleCommand command = new OracleCommand(query, conn);
            int result = Convert.ToInt32(command.ExecuteScalar());
            conn.Close();
            return result;
        }

        public static int DemChiTietDV(string MaPhieu, string MaDV)
        {
            OracleConnection conn = Connection.GetDBConnection();
            conn.Open();
            string query = $"select count(*) from HOTEL_PUBLIC.A_CHITIETPHIEUDV where MAPHIEU = '{MaPhieu}' and MADV = '{MaDV}'";
            OracleCommand command = new OracleCommand(query, conn);
            int result = Convert.ToInt32(command.ExecuteScalar());
            conn.Close();
            return result;
        }



        //    MAPHIEU VARCHAR2(10),
        //TONGTIEN DECIMAL(10,0),
        //MANV VARCHAR2(10),
        //NGAYLAP DATE,
        //MAKH        VARCHAR2(10),
        //MAPHONG VARCHAR2(10),
        //TINHTRANG NVARCHAR2(50),--tình trạng phiếu đã thanh toán hay chưa
        public static bool TaoPhieuDichvu(string MaKH, string MaPhong, string MaNV, string maPhieu)
        {
            OracleConnection conn = Connection.GetDBConnection();
            conn.Open();
            
            string query = $"INSERT INTO HOTEL_PUBLIC.A_PHIEUDV VALUES ('{maPhieu}',0,'{MaNV}',TO_DATE('{DateTime.Now.ToString().Substring(0, DateTime.Now.ToString().Length - 3)}', 'dd/mm/yyyy HH:mi:ss'),'{MaKH}', '{MaPhong}','Chưa thanh toán')";
            OracleCommand command = new OracleCommand(query, conn);
            int result = Convert.ToInt32(command.ExecuteNonQuery());
            conn.Close();
            return result >= 1 ? true : false;
        }



        public static DataTable LayDSDV_byMaPhong(string MaPhong)
        {
            string query = $"SELECT C.*,B.TENDV FROM HOTEL_PUBLIC.A_PHIEUDV A, HOTEL_PUBLIC.A_DICHVU B , HOTEL_PUBLIC.A_CHITIETPHIEUDV C WHERE A.MAPHIEU = C.MAPHIEU AND B.MADV = C.MADV AND A.MAPHONG = '{MaPhong}' AND A.TINHTRANG = 'Chưa thanh toán'";

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
        
    }
}
