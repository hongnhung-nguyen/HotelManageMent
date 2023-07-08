using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using src.DB;
using src.BUS;

namespace src
{
    public partial class TTPhong : Form
    {
        DSP DSP;
        string MAPHONG = "";
        public TTPhong(string ma)
        {
            MAPHONG = ma;
            InitializeComponent();
            
            //TTPhong_Load();
            LoadTTP(MAPHONG);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //OracleConnection conn = Connection.GetDBConnection();
            //conn.Open();
            //string orlupdate = $"UPDATE A_PHONG SET LOAIPHONG = :loaiphong, GIA = :gia, TINHTRANG = :tinhtrang, SONGUOI = :songuoi WHERE MAPHONG = :maphong";
            //OracleCommand cmd = new OracleCommand(orlupdate, conn);
            //cmd.Parameters.Add(new OracleParameter("loaiphong", textBox2.Text.Trim()));
            //cmd.Parameters.Add(new OracleParameter("gia", textBox3.Text.Trim()));
            //cmd.Parameters.Add(new OracleParameter("tinhtrang", textBox4.Text.Trim()));
            //cmd.Parameters.Add(new OracleParameter("songuoi", textBox5.Text.Trim()));
            //cmd.Parameters.Add(new OracleParameter("maphong", textBox1.Text.Trim()));
            // int count = cmd.ExecuteNonQuery();
            Room_BUS room = new Room_BUS();
            room.MaPhong = textBox1.Text;
            room.LoaiPhong = textBox2.Text;
            room.Gia = textBox3.Text;
            room.TinhTrang = textBox4.Text;
            room.SoNguoi = textBox5.Text;
            int count = Room_DB.UpdateTTPhong(room);
            if(count > 0)
            {
                MessageBox.Show("Cập nhập thành công");
            }
            else
            {
                MessageBox.Show("Cập nhập thất bại");
            }
        }
       private void LoadTTP(string maphong)
        {
            Oracle.ManagedDataAccess.Client.OracleConnection conn = Connection.GetDBConnection();
            conn.Open();
            textBox1.Text = maphong;
            textBox1.Enabled = false;

            string orlselect1 = $"SELECT LOAIPHONG FroM HOTEL_PUBLIC.A_PHONG WHERE MAPHONG = '" + maphong + "'";
            OracleCommand cmd1 = new OracleCommand(orlselect1, conn);
            textBox2.Text = Convert.ToString(cmd1.ExecuteScalar());

            string orlselect2 = $"SELECT GIA FroM HOTEL_PUBLIC.A_PHONG WHERE MAPHONG = '" + maphong + "' ";
            OracleCommand cmd2 = new OracleCommand(orlselect2, conn);
            textBox3.Text = Convert.ToString(cmd2.ExecuteScalar());

            string orlselect3 = $"SELECT TINHTRANG FroM HOTEL_PUBLIC.A_PHONG WHERE MAPHONG = '" + maphong + "' ";
            OracleCommand cmd3 = new OracleCommand(orlselect3, conn);
            textBox4.Text = Convert.ToString(cmd3.ExecuteScalar());

            string orlselect4 = $"SELECT SONGUOI FroM  HOTEL_PUBLIC.A_PHONG WHERE MAPHONG = '" + maphong + "' ";
            OracleCommand cmd4 = new OracleCommand(orlselect4, conn);
            textBox5.Text = Convert.ToString(cmd4.ExecuteScalar());
            
            conn.Close();
        }
        private void TTPhong_Load()
        {
            
            textBox1.Text = MAPHONG;
            textBox1.Enabled = false;
            
            textBox2.Text = Room_DB.getTTPhong(MAPHONG).LoaiPhong;
            textBox3.Text = Room_DB.getTTPhong(MAPHONG).Gia;
            textBox4.Text = Room_DB.getTTPhong(MAPHONG).TinhTrang;
            textBox5.Text = Room_DB.getTTPhong(MAPHONG).SoNguoi;
        }
    }
}
