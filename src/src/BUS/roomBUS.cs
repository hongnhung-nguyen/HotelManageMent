using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using src.DB;
namespace src.BUS
{
    public class RoomBUS
    {

        public string maPhong { get; set; }
        public string LoaiPhong { get; set; }
        public float GiaPhong { get; set; }
        public string TinhTrang { get; set; }

        public int SoNguoi { get; set; }

        public RoomBUS(string maPhongIN, string TinhTrang_IN)
        {
            maPhong = maPhongIN;
            TinhTrang = TinhTrang_IN;
        }
        public RoomBUS()
        {

        }
        public static DataTable getRoomListBUS( string tinhTrang, string loaiPhong , float mucGiaMin, float mucGiaMax)
        {
            DataTable roomList = RoomDB.getRoomListDB(tinhTrang, loaiPhong, mucGiaMin, mucGiaMax);
            return roomList;
        }
        public static DataTable getTTPhong()
        {
            DataTable TTPhong = RoomDB.getTTPhongDB();
            return TTPhong;
        }
        public static float GetGiaByMaPhong(string MaPhong)
        { 
            return RoomDB.GetGiaByMaPhong(MaPhong);
        }

        public static string GetMaKHByMaPhong(string MaPhong)
        {
            return RoomDB.GetMaKHByMaPhong(MaPhong);
        }

        public static string GetLoaiPhongByMaPhong(string MaPhong)
        {
            return RoomDB.GetLoaiPhongByMaPhong(MaPhong);
        }

    }
}



//CREATE TABLE A_PHONG(
//    MAPHONG         VARCHAR2(10),
//    LOAIPHONG NVARCHAR2(20),
//    GIA NUMBER(10, 0),
//    TINHTRANG NVARCHAR2(20),
//    SONGUOI INTEGER,
//    CONSTRAINT PK_PHONG PRIMARY KEY(MAPHONG)
//);
///