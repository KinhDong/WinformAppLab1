namespace BaiTap1
{
    partial class BT1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tb_num1 = new TextBox();
            tb_num2 = new TextBox();
            tb_sum = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // tb_num1
            // 
            tb_num1.Location = new Point(404, 84);
            tb_num1.Name = "tb_num1";
            tb_num1.Size = new Size(150, 31);
            tb_num1.TabIndex = 0;
            // 
            // tb_num2
            // 
            tb_num2.Location = new Point(404, 174);
            tb_num2.Name = "tb_num2";
            tb_num2.Size = new Size(150, 31);
            tb_num2.TabIndex = 1;
            // 
            // tb_sum
            // 
            tb_sum.Location = new Point(404, 275);
            tb_sum.Name = "tb_sum";
            tb_sum.ReadOnly = true;
            tb_sum.Size = new Size(150, 31);
            tb_sum.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(173, 87);
            label1.Name = "label1";
            label1.Size = new Size(105, 25);
            label1.TabIndex = 3;
            label1.Text = "Số thứ nhất";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(173, 174);
            label2.Name = "label2";
            label2.Size = new Size(93, 25);
            label2.TabIndex = 4;
            label2.Text = "Số thứ hai";
            // 
            // button1
            // 
            button1.Location = new Point(166, 273);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 5;
            button1.Text = "Kết quả";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // BT1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tb_sum);
            Controls.Add(tb_num2);
            Controls.Add(tb_num1);
            Name = "BT1";
            Text = "Bài 1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_num1;
        private TextBox tb_num2;
        private TextBox tb_sum;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}
