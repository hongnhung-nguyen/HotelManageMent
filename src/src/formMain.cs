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


namespace src
{
    public partial class formMain : Form
    {
        bool sidebarExpand;
        private Form father;
        private string username;
        private string password;
        OracleConnection connect;
        public formMain(string username, string password, Form father)
        {
            //Oracle.ManagedDataAccess.Client.OracleConnection
            Connection.username = username;
            Connection.password = password;
            OracleConnection conn = Connection.GetDBConnection();
            this.father = father;
            this.username = username;
            this.password = password;
            this.connect = conn;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
            pnChildForm.Controls.Add(childForm);
            pnChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand )
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
                if(sidebar.Width==sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            this.father.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //openChildForm(new GUI.MainBookingGUI());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new DSKH());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new DSP());
        }
    }
}
