using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using src.DB;

namespace src.BUS
{
    public class Room_BUS
    {
        public string MaPhong { get; set; }
        public string LoaiPhong { get; set; }
        public string Gia { get; set; }
        public string TinhTrang { get; set; }
        public string SoNguoi { get; set; }

        public Room_BUS(string MaPhong, string LoaiPhong, string Gia, string TinhTrang, string SoNguoi)
        {
            this.MaPhong = MaPhong;
            this.LoaiPhong = LoaiPhong;
            this.Gia = Gia;
            this.TinhTrang = TinhTrang;
            this.SoNguoi = SoNguoi;
        }

        public Room_BUS()
        {

        }

        public static Room_BUS getTTPhong(string maphong)
        {
            return Room_DB.getTTPhong(maphong);
        }

        public static bool UpdateTTPhong(Room_BUS room)
        {
            if (Room_DB.UpdateTTPhong(room) >= 1)
            {
                return true;
            }
            return false;
        }
    }
}
