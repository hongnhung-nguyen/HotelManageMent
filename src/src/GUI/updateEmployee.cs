using dataProvider;
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
    public partial class updateEmployee : Form
    {
        OracleConnection conn;
        public updateEmployee(OracleConnection connect)
        {
            this.conn = connect;
            InitializeComponent();
            loadData();
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
            string diachi = diachiTB.Text;
            string email = emailTB.Text;
            string sdt = sdtTB.Text;
            if (BUS.EmployeeBUS.checkMaNV(manv) == true)
            {
                bool status = BUS.EmployeeBUS.upNV(manv, diachi, sdt, email);
                if (status == true)
                {
                    MessageBox.Show("Cập nhật thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại");
                }
                loadData();
            }
            else
            {
                MessageBox.Show("Mã Nhân viên không đúng");
            }
        }
    }
}
