using Lab1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BT1 f = new BT1();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BT2 f = new BT2();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BT3 f = new BT3();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BT4 f = new BT4();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BT5 f = new BT5();
            f.Show();
        }

        private void btn_bai6_Click(object sender, EventArgs e)
        {
            BT6 f = new BT6();
            f.Show();
        }
    }
}
