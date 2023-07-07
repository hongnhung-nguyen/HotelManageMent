using src.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace src.GUI
{
    public partial class CheckoutGUI : Form
    {
        public CheckoutGUI()
        {
            InitializeComponent();
        }

        private void CheckoutGUI_Load(object sender, EventArgs e)
        {
            dataGridView_DSDichVu.DataSource = ServiceBUS.getlistDV();
            dataGridView_DSDichVu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button_timphong_Click(object sender, EventArgs e)
        {
            string maPhong = textBoxMaPhong.Text.ToString();
            textBoxMaKH.Text = RoomBUS.GetMaKHByMaPhong(maPhong).ToString();
            textBoxGiaPhong.Text = RoomBUS.GetGiaByMaPhong(maPhong).ToString();
            textBoxLoaiPhong.Text = RoomBUS.GetLoaiPhongByMaPhong(maPhong).ToString() ;
            
            
        }

        private void buttonTinhTien_Click(object sender, EventArgs e)
        {
            string maPhong = textBoxMaPhong.Text.ToString();
            textBoxTienPhong.Text = textBoxGiaPhong.Text;
            textBoxTienDV.Text = ServiceBUS.GetTongTienDichVuByMaPhong(maPhong).ToString();
            textBoxDaThanhToan.Text = PhieuDatPhongBUS.getDaThanhToanDangDatPhong(maPhong).ToString();
            float TongTien = float.Parse(textBoxTienPhong.Text) + float.Parse(textBoxTienDV.Text) - float.Parse(textBoxDaThanhToan.Text);
            textBoxTongTien.Text = TongTien.ToString();
        }
    }
}
