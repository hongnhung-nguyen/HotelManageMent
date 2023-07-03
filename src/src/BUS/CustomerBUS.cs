using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src
{
    class customerBUS
    {

        public string maKH { get; set; }
        public string fullName { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public string cccd { get; set; }

        public customerBUS()
        {

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