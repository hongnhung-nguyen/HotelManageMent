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
using src.BUS;
using src.GUI;

namespace src
{
    public partial class Login : Form
    {
        string username;
        string password;
        string role;
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.White;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.ForeColor = Color.White;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.SelectAll();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            username = textBox1.Text;
            password= textBox2.Text;
            username = username.ToUpper();
            if (username == "HOTEL_PUBLIC")
            {
                role = "DBA";
            }
            else { role = "user"; }

            if (role=="DBA")
            {
                if (userBUS.checkLogin(username, password)==true)
                {
                    mainAdmin dba = new mainAdmin(username,password, this);
                    this.Visible = false;
                    dba.Show();
                }

            }
            else
            {
                if (userBUS.checkLogin(username, password) == true)
                {
                    formMain user = new formMain(username, password, this);
                    this.Visible = false;
                    user.Show();
                }
            }

        }
    }
}
