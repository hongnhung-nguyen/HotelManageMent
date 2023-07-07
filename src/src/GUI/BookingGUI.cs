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
    public partial class BookingGUI : Form
    {
        public string maPhieu { get; set; }
        public BookingGUI()
        {
            InitializeComponent();
        }

        public BookingGUI(string maphong , float giaphong)
        {
            InitializeComponent();
            tx_maphong.Text = maphong;
            tb_giaPhong.Text = giaphong.ToString();
        }

        private void BookingGUI_Load(object sender, EventArgs e)
        {
            dateVao.Text= DateTime.Now.ToString();
            dateRa.Text = DateTime.Now.AddDays(1).ToString();
        }


        private void button_NhanPhong_Click(object sender, EventArgs e)
        {
            
            string MaPhieu = PhieuDatPhongBUS.createMaPhieuDatPhong();
            string MaPhong = tx_maphong.Text.ToString();
            DateTime NgayBD = dateVao.Value;
            DateTime ngayKT = dateRa.Value;
            string MaNV = Connection.username;
            DateTime NgayLap = DateTime.Now;
            string MaKH = customerBUS.getMaKHByCCCD(txCMNN.Text.ToString());
            if(MaKH == "")
            {
                MessageBox.Show("Khách Hàng chưa tồn tại , hãy tạo tài khoản khách hàng trong hệ thống trước khi đặt phòng!");
                return;

            }
            //================================
            decimal giaPhong = decimal.Parse(tb_giaPhong.Text);
            PhieuDatPhongBUS Phieu = new PhieuDatPhongBUS(
                                                            MaPhieu,
                                                            MaPhong,
                                                            NgayBD,
                                                            ngayKT,
                                                            "",
                                                            MaNV,
                                                            NgayLap,
                                                            MaKH,
                                                            giaPhong,
                                                            20 * Convert.ToInt32(tb_giaPhong.Text) / 100,
                                                            0
            );

            if (PhieuDatPhongBUS.insertPDP(Phieu))
            {
                this.maPhieu = MaPhieu;
                MessageBox.Show("Nhận phòng thành công!");
            }

            this.Hide();
        }

        private void button_DichVu_Click(object sender, EventArgs e)
        {
            // tạo 1 phiếu dịch vụ cho khách hàng

            string MaKH = customerBUS.getMaKHByCCCD(txCMNN.Text.ToString());
            string MaPhong = tx_maphong.Text.ToString();
            string maNV = Connection.username;
            string maPhieu = ServiceBUS.TaoMaPhieuDV();


            if (ServiceBUS.TaoPhieuDichvu(MaKH, MaPhong, maNV, maPhieu) != true)
            {
                MessageBox.Show("Tạo Phiếu dịch Vụ bị lỗi, vui lòng kiểm tra lại !");
            }

            this.Hide();
            CustomerServicesGUI cs = new CustomerServicesGUI(maPhieu);
            cs.ShowDialog();
            this.Show();
        }

        // kiểm tra tồn tại khách hàng 
        private void button_CheckTT_KH_Click(object sender, EventArgs e)
        {
            if(customerBUS.checkCustomer(txCMNN.Text.ToString()))
            {
                MessageBox.Show("Khách hàng đã có thông tin trong hệ thống!");
            }    
            else
            {
                DialogResult dialogResult = MessageBox.Show("khách hàng chưa tồn tại trong hệ thống , bạn có muốn tạo khách hàng mới không ?", "Kiểm tra tồn tại ", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string MaKH = customerBUS.createMaKH();
                    string HoTen = txt_tenKH.Text.ToString();
                    string GioiTinh = comboBox_GioTinh.Text.ToString();
                    DateTime NgaySinh = dateTimeNgaySinh.Value;
                    string SDT = textSdt.Text.ToString();
                    string CCCD = txCMNN.Text.ToString();
                    string Email = textBox_Gmail.Text.ToString();
                    string DiaChi = textBox_DiaChi.Text.ToString();

                    customerBUS kh = new customerBUS(MaKH,HoTen,GioiTinh,NgaySinh,SDT,CCCD,Email,DiaChi);
                    if(customerBUS.InsertCustomer(kh))
                        MessageBox.Show("Khách hàng đã được thêm");

                }
                
            }    
        }

        private void txCMNN_TextChanged(object sender, EventArgs e)
        {
            string maKH = customerBUS.getMaKHByCCCD(txCMNN.Text.ToString());
            if (maKH != "")
            {
                customerBUS cus = customerBUS.getCustomer(maKH);
                this.txt_tenKH.Text = cus.HoTen;
                this.dateTimeNgaySinh.Value = cus.NgaySinh;
                this.textBox_Gmail.Text = cus.Email;
                this.textBox_DiaChi.Text = cus.DiaChi;
                this.textSdt.Text = cus.SDT;
            } 
        }
    }
}
