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
    public partial class deleteEmployee : Form
    {
        OracleConnection conn;
        public deleteEmployee(OracleConnection connect)
        {
            this.conn = connect;
            InitializeComponent();
            loadData();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
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
    }
}
