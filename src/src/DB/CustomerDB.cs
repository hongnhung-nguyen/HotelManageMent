﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
namespace src.DB
{
    class CustomerDB
    {
        public static int checkCustomer(string cccd)
        {
            OracleConnection conn = Connection.GetDBConnection();
            conn.Open();
            string query = $"select count(*) from HOTEL_PUBLIC.A_KHACHHANG A WHERE A.CCCD = '{cccd}'";
            OracleCommand command = new OracleCommand(query, conn);
            int result = Convert.ToInt32(command.ExecuteScalar());
            conn.Close();
            return result;
        }

        public static int countCustomer()
        {
            OracleConnection conn = Connection.GetDBConnection();
            conn.Open();
            string query = $"select count(*) from HOTEL_PUBLIC.A_KHACHHANG";
            OracleCommand command = new OracleCommand(query, conn);
            int result = Convert.ToInt32(command.ExecuteScalar());
            conn.Close();
            return result;
        }


        public static string getMaKHByCCCD(string cccd)
        {
            OracleConnection conn = Connection.GetDBConnection();
            conn.Open();
            string query = $"select A.MAKH from HOTEL_PUBLIC.A_KHACHHANG A WHERE A.CCCD = '{cccd}'";
            OracleCommand command = new OracleCommand(query, conn);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                return (reader["MAKH"].ToString());
            }
            conn.Close();
            return "";
        }

        public static int InsertCustomer(customerBUS kh)
        {
            OracleConnection conn = Connection.GetDBConnection();
            conn.Open();
            string query = $"INSERT INTO HOTEL_PUBLIC.A_KHACHHANG VALUES ('{kh.MaKH}','{kh.HoTen}','{kh.GioiTinh}',TO_DATE('{kh.NgaySinh.ToString().Substring(0, kh.NgaySinh.ToString().Length - 3)}', 'dd/mm/yyyy HH:mi:ss'),'{kh.SDT}', '{kh.CCCD}','{kh.Email}', '{kh.DiaChi}')";
            OracleCommand command = new OracleCommand(query, conn);
            int result = Convert.ToInt32(command.ExecuteNonQuery());
            conn.Close();
            return result;
        }

        //MAKH VARCHAR2(10),
        //HOTEN NVARCHAR2(50),
        //GIOITINH NVARCHAR2(10),
        //NGAYSINH DATE,
        //SDT         VARCHAR2(20),
        //CCCD VARCHAR2(12) ,
        //EMAIL VARCHAR2(100),
        //DIACHI NVARCHAR2(100),

        //public customerBUS(string MaKH, string HoTen, string GioiTinh, DateTime NgaySinh, string SDT, string CCCD, string Email, string DiaChi)
        //{
        //    this.MaKH = MaKH;
        //    this.HoTen = HoTen;
        //    this.GioiTinh = GioiTinh;
        //    this.NgaySinh = NgaySinh;
        //    this.SDT = SDT;
        //    this.CCCD = CCCD;
        //    this.Email = Email;
        //    this.DiaChi = DiaChi;
        //}



        public static customerBUS getCustomer(string MaKH)
        {
            OracleConnection conn = Connection.GetDBConnection();
            conn.Open();
            string query = $"select * from HOTEL_PUBLIC.A_KHACHHANG A WHERE A.MAKH = '{MaKH}'";
            OracleCommand command = new OracleCommand(query, conn);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                return new customerBUS(
                    reader["MAKH"].ToString(),
                    reader["HOTEN"].ToString(),
                    reader["GIOITINH"].ToString(),
                    DateTime.Parse(reader["NGAYSINH"].ToString()),
                    reader["SDT"].ToString(),
                    reader["CCCD"].ToString(),
                    reader["EMAIL"].ToString(),
                    reader["DIACHI"].ToString()
                    );
            }
            conn.Close();
            return new customerBUS();
        }
    }
}
