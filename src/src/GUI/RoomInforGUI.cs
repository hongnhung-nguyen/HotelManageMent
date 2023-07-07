using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using src.BUS;
namespace src.GUI
{
    public partial class RoomInforGUI : Form
    {
        public RoomInforGUI()
        {
            InitializeComponent();
        }
        public RoomInforGUI(string maPhong ,float giaPhong)
        {
            InitializeComponent();
            tx_maphong.Text = maPhong;
            tb_giaPhong.Text = giaPhong.ToString();
            PhieuDatPhongBUS pdp = PhieuDatPhongBUS.getPhieuDatPhongByMaPhong(maPhong);
            string MaKH = PhieuDatPhongBUS.getMaKH_DangDatPhong(maPhong);
            customerBUS KH = customerBUS.getCustomer(MaKH);

            dateVao.Value = pdp.NgayBD;
            dateRa.Value = pdp.NgayKT;
            tenKH.Text = KH.HoTen;
            txCMNN.Text = KH.CCCD;
            textBox_Gmail.Text = KH.Email;
            textBox_DiaChi.Text = KH.DiaChi;
            textSdt.Text = KH.SDT;

            // mã phòng => lấy ra phiếu đặt phòng
            //          => mã khách hàng 
            // lấy mã phiếu đặt phòng (maKH,


            // lấy danh sách dịch vụ của khách hàng (theo mã phòng , chưa thanh toán )
            dataGridView_DVu.DataSource = ServiceBUS.LayDSDV_byMaPhong(maPhong);
        }
        public RoomInforGUI(DateTime NgayVao,  DateTime NgayRa, customerBUS KH)
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void RoomInfor_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView_DVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}