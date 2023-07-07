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
    public partial class CustomerServicesGUI : Form
    {
        public string MaPhieuDV = "";

        public CustomerServicesGUI()
        {
            InitializeComponent();
        }

        public CustomerServicesGUI(string MaPhieuDV)
        {
            InitializeComponent();
            this.MaPhieuDV = MaPhieuDV;
        }

        public CustomerServicesGUI(customerBUS KH, RoomBUS room)
        {
            InitializeComponent();
        }

        private void CustomerServices_Load(object sender, EventArgs e)
        {
            dataGridView_DichVu.DataSource = ServiceBUS.getlistDV();
            dataGridView_DichVu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            comboBox_DVName.DataSource = ServiceBUS.getListDVName();
            comboBox_DVName.DisplayMember = "TENDV";
        }

        private void dataGridView_DichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_themDV_Click(object sender, EventArgs e)
        {
            string MaDV = ServiceBUS.getMaDVByName(comboBox_DVName.Text.ToString());
            string TenDV = comboBox_DVName.Text.ToString();
            float GiaDV = ServiceBUS.getGiaDVByTenDV(TenDV);

            if(ServiceBUS.insertCTDV(MaPhieuDV, MaDV, GiaDV))
            {
                dataGridView_DV_KhachHang.DataSource = ServiceBUS.getListCTDV(MaPhieuDV);
            }
            else
            {
                MessageBox.Show("Dịch vụ đã được chọn, vui lòng chọn dịch vụ khác !!");
            }

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
