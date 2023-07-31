using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using src.BUS;
using src.DB;
namespace src
{
    class EmployeeBUS
    {
        public string maNV { get; set; }
        public string fullName { get; set; }
        public string sex { get; set; }
        public string birthDay { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string role { get; set; }
        public string cccd { get; set; }

        public EmployeeBUS()
        {

        }

        public EmployeeBUS(string maNV,string fullName,string sex,string birthDay,string address, string phone,string email,string role, string cccd)
        {
            this.maNV = maNV;
            this.fullName = fullName;
            this.sex = sex;
            this.birthDay = birthDay;
            this.address = address;
            this.phone = phone;
            this.email = email;
            this.role = role;
            this.cccd = cccd;
        }
        public static EmployeeBUS LayTTNhanVien()
        {
            return EmployeeDB.LayTTNhanVien();
        }

    }
}

//MANV VARCHAR2(10),
//    TENNV VARCHAR2(50),
//    PHAI VARCHAR2(10),
//    NGAYSINH DATE,
//    DIACHI       VARCHAR2(100),
//    SODT VARCHAR2(20),
//    EMAIL VARCHAR2(100),
//    VAITRO NVARCHAR2(20), 
//    CCCD VARCHAR2(12) , 