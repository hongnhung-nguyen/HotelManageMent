using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using src.DB;
namespace src.BUS
{
    //MAPHIEU VARCHAR2(10),
    //MAPHONG VARCHAR2(10),
    //NGAYBD DATE,
    //NGAYKT          DATE,
    //LOAITHANHTOAN NVARCHAR2(20),
    //MANV VARCHAR2(10),
    //NGAYLAP DATE,
    //MAKH            VARCHAR2(10),
    //TONGTIEN DECIMAL(10,0),
    //DATHANHTOAN DECIMAL(10,0),

    class PhieuDatPhongBUS
    {
        public string MaPhieu { get; set; }
        public string MaPhong { get; set; }
        public DateTime NgayBD { get; set; }
        public DateTime NgayKT { get; set; }
        public string LoaiThanhToan { get; set; }
        public string MaNV { get; set; }

        public DateTime NgayLap { get; set; }
        public string MaKH { get; set; }
        public decimal TongTien { get; set; }

        public decimal DaThanhToan { get; set; }

        public int TraPhong { get; set; }

        public PhieuDatPhongBUS()
        {

        }
        public PhieuDatPhongBUS( string MaPhieu,string MaPhong, DateTime NgayBD,DateTime NgayKT, string LoaiThanhToan,string MaNV,DateTime NgayLap, string MaKH ,decimal TongTien ,decimal DaThanhToan, int TraPhong)
        {
            this.MaPhieu = MaPhieu;
            this.MaPhong = MaPhong;
            this.NgayBD = NgayBD;
            this.NgayKT = NgayKT;
            this.LoaiThanhToan = LoaiThanhToan;
            this.MaNV = MaNV;
            this.NgayLap = NgayLap;
            this.MaKH = MaKH;
            this.TongTien = TongTien;
            this.DaThanhToan = DaThanhToan;
            this.TraPhong = TraPhong;
        }

        public PhieuDatPhongBUS(string MaPhieu, string MaPhong, DateTime NgayBD, DateTime NgayKT)
        {
            this.MaPhieu = MaPhieu;
            this.MaPhong = MaPhong;
            this.NgayBD = NgayBD;
            this.NgayKT = NgayKT;
     
        }

        public static string createMaPhieuDatPhong()
        {
            int sum = PhieuDatPhongDB.countPhieuDatPhong()+1;
            return $"PDP0{sum}";
        }


        public static bool insertPDP(PhieuDatPhongBUS pdp)
        {
            if (PhieuDatPhongDB.insertPDP(pdp) > 0)
                return true;
            return false;
        }

        public static PhieuDatPhongBUS getPhieuDatPhongByMaPhong(string maphong)
        {
            return PhieuDatPhongDB.getPhieuDatPhongByMaPhong(maphong);
        }

        public static string getMaKH_DangDatPhong(string maphong)
        {
            return PhieuDatPhongDB.getMaKH_DangDatPhong(maphong);
        }

        public static string getDaThanhToanDangDatPhong(string maphong)
        {
            return PhieuDatPhongDB.getDaThanhToanDangDatPhong(maphong);
        }
    }
}
