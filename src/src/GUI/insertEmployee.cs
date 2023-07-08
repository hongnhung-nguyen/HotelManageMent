
using Oracle.ManagedDataAccess.Client;
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
    public partial class insertEmployee : Form
    {
        OracleConnection conn;
        public insertEmployee(OracleConnection connect)
        {
            this.conn = connect;
            InitializeComponent();
            loadData();
        }

        private void insertEmployee_Load(object sender, EventArgs e)
        {

        }
        private void loadData()
        {
            conn.Open();
            string query = $"select * from a_nhanvien ";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = Dataprovider.Instance.ExecuteQuery(query);
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string manv = textBox1.Text;
            string tennv = textBox2.Text;
            string phai = textBox3.Text;
            string sdt = textBox5.Text;
            string cccd = textBox6.Text;
            string email = textBox8.Text;
            string vaitro = textBox7.Text;
            string diachi = textBox9.Text;
            string matkhau = textBox10.Text;
            string day = dateTimePicker1.Value.Date.Day.ToString();
            string month = dateTimePicker1.Value.Date.Month.ToString();
            string year = dateTimePicker1.Value.Date.Year.ToString();
            string ngaysinh =  year +month +day;
            if (BUS.EmployeeBUS.checkMaNV(manv) == false)
            {
                bool status = BUS.EmployeeBUS.inNV(manv, tennv, phai, ngaysinh, sdt, cccd, email, vaitro, diachi, matkhau);
                if (status == true)
                {
                    MessageBox.Show("Thêm thành công");
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
                loadData();
            }
            else
            {
                MessageBox.Show("Mã Nhân viên đã tồn tại");
            }
        }
    }
}
