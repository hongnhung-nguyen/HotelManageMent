using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using src.DB;
using Oracle.ManagedDataAccess.Client;

namespace src
{
    public class KH_BUS
    {
        public string MaKH { get; set; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string SDT { get; set; }
        public string CCCD { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public KH_BUS(string MaKH, string HoTen, string GioiTinh, DateTime NgaySinh, string SDT, string CCCD, string Email, string DiaChi)
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

        public KH_BUS()
        {

        }
    }
}
