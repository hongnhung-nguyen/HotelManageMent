using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Oracle.DataAccess.Client;
using Oracle.ManagedDataAccess.Client;

namespace src
{
    public partial class DSKH : Form
    {
        public DSKH()
        {
            InitializeComponent();
            loadData();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void loadData()
        {
            OracleConnection conn = Connection.GetDBConnection();
            conn.Open();
            string query = $"select * from hotel_public.a_khachhang ";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = Dataprovider.Instance.ExecuteQuery(query);
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tukhoa = textBox1.Text;
            try
            {
                OracleConnection conn = Connection.GetDBConnection();
                conn.Open();
                string query = $"select * from HOTEL_PUBLIC.A_KHACHHANG WHERE HOTEN LIKE ('" + tukhoa + "%')";
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.DataSource = Dataprovider.Instance.ExecuteQuery(query);
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error: lỗi xem thông tin khách hàng !");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string trangthai = comboBox1.Text;
            if(trangthai == "Đang thuê")
            {
                OracleConnection conn = Connection.GetDBConnection();
                conn.Open();
                string query = $"SELECT * FROM  HOTEL_PUBLIC.A_KHACHHANG KH , A_PHIEUDATPHONG PDP WHERE KH.MAKH = PDP.MAKH AND PDP.NGAYKT > SYSDATE";
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.DataSource = Dataprovider.Instance.ExecuteQuery(query);
                conn.Close();
            }
            if (trangthai == "Đã thuê")
            {
                OracleConnection conn = Connection.GetDBConnection();
                conn.Open();
                string query = $"SELECT * FROM  HOTEL_PUBLIC.A_KHACHHANG KH , A_PHIEUDATPHONG PDP WHERE KH.MAKH = PDP.MAKH AND PDP.NGAYKT < SYSDATE";
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.DataSource = Dataprovider.Instance.ExecuteQuery(query);
                conn.Close();
            }
        }
    }
}
