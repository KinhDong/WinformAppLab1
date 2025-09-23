namespace BaiTap1
{
    public partial class BT1 : Form
    {
        public BT1()
        {
            InitializeComponent();
        }

        private void tb_sum_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = 0, num2 = 0;
            bool s1 = Int32.TryParse(tb_num1.Text.Trim(), out num1);
            bool s2 = Int32.TryParse(tb_num2.Text.Trim(), out num2);

            if (!s1 || !s2)
            {
                MessageBox.Show("Vui lòng nhập số nguyên!");
            }

            else
            {
                num1 = Int32.Parse(tb_num1.Text.Trim());
            num2 = Int32.Parse(tb_num2.Text.Trim());
            int sum = num1 + num2;
            tb_sum.Text = sum.ToString();
            }
        }
    }
}
