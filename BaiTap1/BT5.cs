using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class BT5 : Form
    {
        public BT5()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_caculate_Click(object sender, EventArgs e)
        {
            uint numA = 0, numB = 0;

            if (!UInt32.TryParse(tb_numA.Text.Trim(), out numA) ||
                !UInt32.TryParse(tb_numB.Text.Trim(), out numB))
            {
                MessageBox.Show("Vui lòng nhập số tự nhiên!");
                return;
            }

            numA = UInt32.Parse(tb_numA.Text);
            numB = UInt32.Parse(tb_numB.Text);

            // Giai thua
            uint factorialA = 1, factorialB = 1;
            uint smaller = Math.Min(numA, numB);

            uint i = 1;
            while (i <= smaller)
            {
                factorialA *= i;
                factorialB *= i;
                i++;
            }
            while (i <= numA)
            {
                factorialA *= i;
                i++;
            }
            while (i <= numB)
            {
                factorialB *= i;
                i++;
            }

            // Tong
            uint sumA = numA * (numA + 1) / 2;
            uint sumB = numB * (numB + 1) / 2;

            // Mu
            double sumPow = 0;
            if (numA < 2) sumPow = numA * numB;
            else
            {
                sumPow = numA * (Math.Pow(numA, numB) - 1) / (numA - 1);
            }
            ;

            tb_result.Text =
                $"A! = {factorialA}{Environment.NewLine}" +
                $"B! = {factorialB}{Environment.NewLine}" +
                $"S1 = 1 + 2 + ... + A = {sumA}{Environment.NewLine}" +
                $"S2 = 1 + 2 + ... + B = {sumB}{Environment.NewLine}" +
                $"S3 = A^1 + A^2 + ... + A^B = {sumPow}";

        }

        private void btn_erase_Click(object sender, EventArgs e)
        {
            tb_numA.Text = String.Empty;
            tb_numB.Text = String.Empty;
            tb_result.Text = String.Empty;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
