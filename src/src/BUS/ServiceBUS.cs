using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using Oracle.DataAccess.Client;
using System.Text;
using System.Threading.Tasks;
using src.DB;

namespace src.BUS
{
    class ServiceBUS
    {
        public string MaDV { get; set; }
        public string TenDV { get; set; }
        public decimal Gia { get; set; }

        
        public static DataTable getlistDV()
        {
            return ServiceDB.getlistDV();
        }

        public static DataTable getListDVName()
        {
            return ServiceDB.getListDVName();
        }
        public static bool TaoPhieuDichvu(string MaKH, string MaPhong, string MaNV, string maPhieu)
        {
            return ServiceDB.TaoPhieuDichvu(MaKH, MaPhong, MaNV, maPhieu);

        }

        public static string TaoMaPhieuDV()
        {
            int sum = ServiceDB.DemTongPhieuDV();
            return $"PDV{sum + 1}";
        }
         public static string getMaDVByName(string DVname)
        {
            return ServiceDB.GetMaDVByTenDV(DVname);
        }

        public static float getGiaDVByTenDV(string tendv)
        {
            return ServiceDB.GetGiaDVuByTenDV(tendv);
        }

        public static bool insertCTDV(string MaPhieu , string MaDV, float Sotien)
        {
            // kiểm tra tồn tại chi tiết chưa rồi mới thêm 
            if(ServiceDB.DemChiTietDV(MaPhieu,MaDV) == 1)
            {
                return false;
            }    
            return ServiceDB.InsertCTDVu(MaPhieu, MaDV, Sotien);
        }

        public static DataTable getListCTDV(string MaPhieuDV)
        {
            return ServiceDB.getlistCTDV(MaPhieuDV);
        }
        public static DataTable LayDSDV_byMaPhong(string MaPhong)
        {
            return ServiceDB.LayDSDV_byMaPhong(MaPhong);
        }
        public static bool UpdateTongTienPhieuDV(string MaPhieuDV)
        {
            if(ServiceDB.UpdateTongTienPhieuDV(MaPhieuDV) >=1)
            {
                return true;
            }
            return false;
        }

        public static bool DropCTDVu(string MaPhieuDV, string maDV)
        {
            return ServiceDB.DropCTDVu(MaPhieuDV, maDV);
        }
    }

}
