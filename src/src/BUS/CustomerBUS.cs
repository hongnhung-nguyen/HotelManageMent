using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using src.DB;
using Oracle.DataAccess.Client;
namespace src
{
    public class customerBUS
    {
    //    MAKH VARCHAR2(10),
    //HOTEN NVARCHAR2(50),
    //GIOITINH NVARCHAR2(10),
    //NGAYSINH DATE,
    //SDT         VARCHAR2(20),
    //CCCD VARCHAR2(12) ,
    //EMAIL VARCHAR2(100),
    //DIACHI NVARCHAR2(100),
        public string MaKH { get; set; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string SDT { get; set; }
        public string CCCD { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }

        public customerBUS(string MaKH ,string HoTen,string GioiTinh, DateTime NgaySinh ,string SDT,string CCCD, string Email, string DiaChi)
        {
            this.MaKH = MaKH;
            this.HoTen = HoTen;
            this.GioiTinh = GioiTinh;
            this.NgaySinh = NgaySinh;
            this.SDT = SDT;
            this.CCCD = CCCD;
            this.Email = Email;
            this.DiaChi = DiaChi;
        }

        public customerBUS()
        {

        }


        public static bool checkCustomer(string cccd)
        {
            if (CustomerDB.checkCustomer(cccd) < 1)
                return false;
            return true;
        }
        public static string createMaKH()
        { 
            int sum = CustomerDB.countCustomer()+1;
            return $"KH00{sum}";
        }
        public static string getMaKHByCCCD(string cccd)
        {
            return CustomerDB.getMaKHByCCCD(cccd);
        }

        public static bool InsertCustomer(customerBUS kh)
        {
            if(CustomerDB.InsertCustomer(kh)>=1)
            {
                return true;
            }
            return false;
        }
        public static customerBUS getCustomer(string MaKH)
        {
            return CustomerDB.getCustomer(MaKH);
        }



    }
}


//CREATE TABLE A_KHACHHANG(
//    MAKH        VARCHAR2(10),
//    HOTEN NVARCHAR2(50),
//    SDT VARCHAR2(20),
//    CCCD VARCHAR2(12) ,
//    DIACHI NVARCHAR2(100),
//    CONSTRAINT CCCD_KH_UNIQUE UNIQUE(CCCD),
//    CONSTRAINT FK_KHACHHANG PRIMARY KEY (MAKH)
//);