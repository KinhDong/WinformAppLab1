using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class BT4 : Form
    {
        public BT4()
        {
            InitializeComponent();
        }

        private void btn_convert_Click(object sender, EventArgs e)
        {
            double foreign = 0;
            if (!double.TryParse(tb_foreign.Text, out foreign))
            {
                MessageBox.Show("Vui lòng nhập số!");
                return;
            }

            if(cb_money.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn loại tiền tệ");
                return;
            }

            foreign = double.Parse(tb_foreign.Text, CultureInfo.InvariantCulture);
            double rate = double.Parse(tb_rate.Text, CultureInfo.InvariantCulture);
            double vnd = foreign * rate;

            tb_vnd.Text = vnd.ToString();
        }

        private void cb_money_SelectedIndexChanged(object sender, EventArgs e)
        {
            string rate = cb_money.SelectedItem.ToString();

            switch (rate)
            {
                case "USD (Đô la Mỹ)":
                    tb_rate.Text = "22.772";
                    break;
                case "EUR (Euro)":
                    tb_rate.Text = "28.132";
                    break;
                case "GBP (Bảng Anh)":
                    tb_rate.Text = "31.538";
                    break;
                case "SGD (Đô la Singapore)":
                    tb_rate.Text = "17.286";
                    break;
                default:
                    tb_rate.Text = "214";
                    break;
            }
        }
    }
}
