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
    public partial class BT2 : Form
    {
        public BT2()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            double num1 = 0, num2 = 0, num3 = 0;

            if (!double.TryParse(tb_num1.Text, out num1) ||
                !double.TryParse(tb_num2.Text, out num2) ||
                !double.TryParse(tb_num3.Text, out num3))
            {
                MessageBox.Show("Vui lòng nhập số!");
            }

            else
            {
                num1 = double.Parse(tb_num1.Text, CultureInfo.InvariantCulture);
                num2 = double.Parse(tb_num2.Text, CultureInfo.InvariantCulture);
                num3 = double.Parse(tb_num3.Text, CultureInfo.InvariantCulture);

                double max = num1, min = num1;

                if (num2 > max) max = num2;
                if (num2 < min) min = num2;

                if (num3 > max) max = num3;
                if (num3 < min) min = num3;

                tb_max.Text = max.ToString();
                tb_min.Text = min.ToString();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            tb_num1.Text = String.Empty;
            tb_num2.Text = String.Empty;
            tb_num3.Text = String.Empty;
            tb_min.Text = String.Empty;
            tb_max.Text = String.Empty;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_max_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
