using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class BT3 : Form
    {
        public BT3()
        {
            InitializeComponent();
        }

        private void btn_read_Click(object sender, EventArgs e)
        {
            int num = 0;

            if (!Int32.TryParse(tb_int.Text.Trim(), out num))
            {
                MessageBox.Show("Nhập sai định dạng");
            }

            else
            {
                num = Int32.Parse(tb_int.Text.Trim());
                switch (num)
                {
                    case 0:
                        tb_string.Text = "Không";
                        break;
                    case 1:
                        tb_string.Text = "Một";
                        break;
                    case 2:
                        tb_string.Text = "Hai";
                        break;
                    case 3:
                        tb_string.Text = "Ba";
                        break;
                    case 4:
                        tb_string.Text = "Bốn";
                        break;
                    case 5:
                        tb_string.Text = "Năm";
                        break;
                    case 6:
                        tb_string.Text = "Sáu";
                        break;
                    case 7:
                        tb_string.Text = "Bảy";
                        break;
                    case 8:
                        tb_string.Text = "Tám";
                        break;
                    case 9:
                        tb_string.Text = "Chín";
                        break;
                    default:
                        MessageBox.Show("Nhập sai định dạng");
                        break;
                }
            }
        }

        private void btn_erase_Click(object sender, EventArgs e)
        {
            tb_int.Text = String.Empty;
            tb_string.Text = String.Empty;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
