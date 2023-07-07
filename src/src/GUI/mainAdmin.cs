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
    public partial class mainAdmin : Form
    {
        bool sidebarExpand;
        private Form father;
        private string username;
        private string password;
        OracleConnection connect;
        
        public mainAdmin(string username, string password, Form father)
        {
            Connection.username = username;
            Connection.password = password;
            OracleConnection conn = Connection.GetDBConnection();
            this.father=father;
            this.username = username;
            this.password = password;
            this.connect = conn;
            InitializeComponent();
        }
        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }
        private Form activeform = null;

        private void openChildForm(Form childForm)
        {
            if (activeform != null)
                activeform.Close();
            activeform = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnChildFormKH.Controls.Add(childForm);
            pnChildFormKH.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            insertEmployee insert = new insertEmployee(this.connect);
            openChildForm(insert);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            updateEmployee update = new updateEmployee(this.connect);
            openChildForm(update);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            deleteEmployee del = new deleteEmployee(this.connect);
            openChildForm(del);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            this.father.Show();
        }

        private void menuButton_Click_1(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }
    }
}

