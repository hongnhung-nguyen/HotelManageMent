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
    public partial class DSP : Form
    {
        string maphong = "";
        public DSP()
        {
            
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            maphong = button3.Text;
            Form f = new TTPhong(maphong);
            f.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            maphong = button12.Text;
            Form f = new TTPhong(maphong);
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            maphong = button1.Text;
            Form f = new TTPhong(maphong);
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            maphong = button2.Text;
            Form f = new TTPhong(maphong);
            f.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            maphong = button4.Text;
            Form f = new TTPhong(maphong);
            f.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            maphong = button5.Text;
            Form f = new TTPhong(maphong);
            f.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            maphong = button6.Text;
            Form f = new TTPhong(maphong);
            f.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            maphong = button7.Text;
            Form f = new TTPhong(maphong);
            f.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            maphong = button8.Text;
            Form f = new TTPhong(maphong);
            f.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            maphong = button9.Text;
            Form f = new TTPhong(maphong);
            f.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            maphong = button10.Text;
            Form f = new TTPhong(maphong);
            f.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            maphong = button11.Text;
            Form f = new TTPhong(maphong);
            f.ShowDialog();
        }
    }
}
