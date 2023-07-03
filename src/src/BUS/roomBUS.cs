using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src.BUS
{
    class roomBUS
    {

        public string maPhong { get; set; }
        public string roomType { get; set; }
        public string roomPrice { get; set; }
        public string status { get; set; }

        public int capacity { get; set; }

        public roomBUS()
        {

        }
    }
}



//--3
//CREATE TABLE A_PHONG(
//    MAPHONG         VARCHAR2(10),
//    LOAIPHONG NVARCHAR2(20),
//    GIA NUMBER(10, 0),
//    TINHTRANG NUMBER(1),
//    SONGUOI INTEGER,
//    CONSTRAINT PK_PHONG PRIMARY KEY(MAPHONG)
//);