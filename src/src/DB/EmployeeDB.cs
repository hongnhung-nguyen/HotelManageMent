using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using src.BUS;
using Oracle.DataAccess.Client;
namespace src.BUS
{
    class EmployeeDB
    {

        public static EmployeeBUS LayTTNhanVien()
        {
            OracleConnection conn = Connection.GetDBConnection();
            conn.Open();
            string query = $"select * from HOTEL_PUBLIC.NHANVIEN A WHERE A.MAKH = '{Connection.username}'";
            OracleCommand command = new OracleCommand(query, conn);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                return new EmployeeBUS(
                    reader["MANV"].ToString(),
                    reader["TENNV"].ToString(),
                    reader["PHAI"].ToString(),
                    reader["NGAYSINH"].ToString(),
                    reader["DIACHI"].ToString(),
                    reader["SODT"].ToString(),
                    reader["EMAIL"].ToString(),
                    reader["VAITRO"].ToString(),
                    reader["CCCD"].ToString()
                    );
            }
            conn.Close();
            return new EmployeeBUS();
        }
    }
}