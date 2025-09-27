using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class BT6 : Form
    {
        public BT6()
        {
            InitializeComponent();
        }

        private void btn_caculate_Click(object sender, EventArgs e)
        {        
            string input = tb_input.Text;

            input += ',';
            string temp = "";
            List<float> score = new List<float>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ',')
                {
                    float tempScore = 0;
                    if (!float.TryParse(temp, out tempScore))
                    {
                        MessageBox.Show("Vui lòng nhập đúng định dạng");
                        return;
                    }
                    score.Add(float.Parse(temp, CultureInfo.InvariantCulture));
                    temp = "";
                }

                else temp += input[i];
            }

            string scoreOut = "";
            float sum = 0;
            int highest = 0, lowest = 0;
            int passed = 0, failed = 0;

            for (int i = 0; i < score.Count; i++)
            {
                scoreOut += "Môn " + (i + 1).ToString() + ": " + score[i].ToString() +
                    Environment.NewLine;

                sum += score[i];

                if (score[i] > score[highest]) highest = i;
                if (score[i] < score[lowest]) lowest = i;

                if (score[i] < 5) failed++;
                else passed++;
            }

            float average = sum / score.Count;
            string type;
            if (average >= 8 && score[lowest] >= 6.5) type = "Giỏi";
            else if (average >= 6.5 && score[lowest] >= 5) type = "Khá";
            else if (average >= 5 && score[lowest] >= 3.5) type = "Trung bình";
            else if (average >= 3.5 && score[lowest] >= 2) type = "Yếu";
            else type = "Kém";

            tb_score.Text = scoreOut;
            tb_average.Text = average.ToString();
            tb_highest.Text = "Môn " + (highest + 1).ToString();
            tb_lowest.Text = "Môn " + (lowest + 1).ToString();
            tb_passed.Text = passed.ToString();
            tb_failed.Text = failed.ToString();
            tb_type.Text = type;
        }

        private void btn_erase_Click(object sender, EventArgs e)
        {
            tb_input.Text = String.Empty;
            tb_score.Text = String.Empty;
            tb_average.Text = String.Empty;
            tb_highest.Text = String.Empty;
            tb_lowest.Text = String.Empty;
            tb_passed.Text = String.Empty;
            tb_failed.Text = String.Empty;
            tb_type.Text = String.Empty;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
