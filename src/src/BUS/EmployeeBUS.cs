using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src.BUS
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

        public static bool checkMaNV(string manv)
        {
            return (DB.EmployeeDB.selectMaNV(manv) > 0);
            
        }
        public static bool delNV(string manv)
        {
            return (DB.EmployeeDB.deleteNV(manv));
           

        }
        public static bool upNV(string manv, string diachi, string sdt, string email)
        {
            return (DB.EmployeeDB.updateNV(manv, diachi, sdt, email)); 
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