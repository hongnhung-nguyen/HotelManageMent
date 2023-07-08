using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src.DB
{
    class EmployeeDB
    {
        public static int selectMaNV(string manv)
        {
          
            OracleConnection conn = Connection.GetDBConnection();
            conn.Open();
            string query = $"select count(*) from HOTEL_PUBLIC.A_NHANVIEN WHERE MANV='"+ manv+"'";
            OracleCommand command = new OracleCommand(query, conn);
            int result = Convert.ToInt32(command.ExecuteScalar());
            conn.Close();
            return result; 
        }

        public static bool deleteNV(string maNV)
        {
            OracleConnection conn = Connection.GetDBConnection();
            conn.Open();

            string query = $"delete from HOTEL_PUBLIC.A_NHANVIEN WHERE MANV = '{maNV}'";
            OracleCommand command = new OracleCommand(query, conn);
            int result = Convert.ToInt32(command.ExecuteNonQuery());
            conn.Close();
            return result >= 1 ? true : false;
        }

        public static bool updateNV(string MaNV, string diachi, string email, string sdt)
        {
            OracleConnection conn = Connection.GetDBConnection();
            conn.Open();
            string query = $"update HOTEL_PUBLIC.A_NHANVIEN SET DIACHI='{diachi}', SODT='{sdt}', EMAIL='{email}'  WHERE MANV='{MaNV}'";
            OracleCommand command = new OracleCommand(query, conn);
            int result = Convert.ToInt32(command.ExecuteNonQuery());
            conn.Close();
            return result >= 1 ? true : false;
        }

        public static bool insertNV(string MaNV,string tennv,string phai, string ngaysinh, string sdt, string cccd, string email,string vaitro, string diachi , string matkhau )
        {
            OracleConnection conn = Connection.GetDBConnection();
            conn.Open();
            string query = $"insert into HOTEL_PUBLIC.A_NHANVIEN VALUES('{MaNV}','{tennv}', '{phai}',TO_DATE('{ngaysinh}', 'yyyymmdd'),'{sdt}','{cccd}','{email}','{ vaitro}','{diachi}')";
            OracleCommand command = new OracleCommand(query, conn);
            int result = Convert.ToInt32(command.ExecuteNonQuery());
            conn.Close();
            return result >= 1 ? true : false;
        }
    }
}
