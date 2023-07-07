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
using Oracle.DataAccess.Client;
namespace src.GUI
{
    public partial class MainBookingGUI : Form
    {
        public MainBookingGUI()
        {
            InitializeComponent();
        }
        private void MainBookingGUI_Load(object sender, EventArgs e)
        {
            //loadComboboxTinhTrangPhong();
        }

        private void button_XemChiTiet_Click(object sender, EventArgs e)
        {
            if(textBox_TinhTrang_TTP.Text.ToString() != "Trống")
            {
                string maPhong = textBoxMaPhong.Text.ToString();
                float giaPhong = RoomBUS.GetGiaByMaPhong(maPhong);
                RoomInforGUI rif = new RoomInforGUI(maPhong, giaPhong);
                rif.Show();
            }
            else
            {
                MessageBox.Show("Phòng hiện chưa có thông tin đặt phòng!");
            }
           
        }

        private void buttonDatPhong_Click(object sender, EventArgs e)
        {
            if(textBox_TinhTrang_TTP.Text.ToString() =="Trống")
            {
                string maPhong = textBoxMaPhong.Text.ToString();
                float giaPhong = RoomBUS.GetGiaByMaPhong(maPhong);
                BookingGUI br = new BookingGUI(maPhong, giaPhong);
                br.Show();
            }
            else
            {
                MessageBox.Show("Phòng hiện đã có người đặt, vui lòng chọn phòng khác!");
            }
          
        }

        private void button_XemPhong_Click(object sender, EventArgs e)
        {
            
            string tinhtrang = comboBox_TTPhong.Text.ToString();
            string Loai = comboBox_LoaiPhong.Text.ToString();
            float giaMin = float.Parse(comboBox_GiaMin.Text);
            float max = 0;
            if (comboBox_GiaMax.Text == "")
            {
                max = 100000000000000000;
            }
            else
                max = float.Parse(comboBox_GiaMax.Text);
            dataGridView.DataSource = RoomBUS.getRoomListBUS(tinhtrang, Loai, giaMin, max);
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public void loadComboboxTinhTrangPhong()
        {
       
            comboBox_GiaMax.DataSource = DB.RoomDB.getTTPhongDB();
            comboBox_GiaMax.DisplayMember = "TINHTRANG";
            //comboBox_TTPhong.ValueMember = "TINGTRANG";
        }
        private void comboBox_TTPhong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView.CurrentRow.Selected = true;
                textBoxMaPhong.Text = dataGridView.Rows[e.RowIndex].Cells["MAPHONG"].FormattedValue.ToString();
                textBox_TinhTrang_TTP.Text = dataGridView.Rows[e.RowIndex].Cells["TINHTRANG"].FormattedValue.ToString();
            }
        }

        private void comboBox_LoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}