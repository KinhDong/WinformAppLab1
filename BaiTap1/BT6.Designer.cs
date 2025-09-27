namespace Lab1
{
    partial class BT6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            tb_input = new TextBox();
            tb_score = new TextBox();
            groupBox1 = new GroupBox();
            tb_average = new TextBox();
            tb_highest = new TextBox();
            tb_lowest = new TextBox();
            tb_passed = new TextBox();
            tb_failed = new TextBox();
            tb_type = new TextBox();
            btn_caculate = new Button();
            btn_erase = new Button();
            btn_exit = new Button();
            label9 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 77);
            label1.Name = "label1";
            label1.Size = new Size(185, 25);
            label1.TabIndex = 0;
            label1.Text = "Nhập danh sách điểm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 0);
            label2.Name = "label2";
            label2.Size = new Size(139, 25);
            label2.TabIndex = 1;
            label2.Text = "Danh sách điểm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(338, 192);
            label3.Name = "label3";
            label3.Size = new Size(142, 25);
            label3.TabIndex = 2;
            label3.Text = "Điểm trung bình";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(271, 262);
            label4.Name = "label4";
            label4.Size = new Size(122, 25);
            label4.TabIndex = 3;
            label4.Text = "Môn cao nhất";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(541, 335);
            label5.Name = "label5";
            label5.Size = new Size(166, 25);
            label5.TabIndex = 4;
            label5.Text = "Số môn không đậu";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(271, 335);
            label6.Name = "label6";
            label6.Size = new Size(110, 25);
            label6.TabIndex = 5;
            label6.Text = "Số môn đậu";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(395, 419);
            label7.Name = "label7";
            label7.Size = new Size(76, 25);
            label7.TabIndex = 6;
            label7.Text = "Xếp loại";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(557, 262);
            label8.Name = "label8";
            label8.Size = new Size(130, 25);
            label8.TabIndex = 7;
            label8.Text = "Môn thấp nhất";
            // 
            // tb_input
            // 
            tb_input.Location = new Point(228, 74);
            tb_input.Name = "tb_input";
            tb_input.ScrollBars = ScrollBars.Horizontal;
            tb_input.Size = new Size(560, 31);
            tb_input.TabIndex = 8;
            // 
            // tb_score
            // 
            tb_score.Location = new Point(25, 30);
            tb_score.Multiline = true;
            tb_score.Name = "tb_score";
            tb_score.ReadOnly = true;
            tb_score.ScrollBars = ScrollBars.Vertical;
            tb_score.Size = new Size(187, 263);
            tb_score.TabIndex = 9;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tb_score);
            groupBox1.Location = new Point(12, 130);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(240, 320);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            // 
            // tb_average
            // 
            tb_average.Location = new Point(486, 189);
            tb_average.Name = "tb_average";
            tb_average.ReadOnly = true;
            tb_average.Size = new Size(221, 31);
            tb_average.TabIndex = 11;
            // 
            // tb_highest
            // 
            tb_highest.Location = new Point(404, 262);
            tb_highest.Name = "tb_highest";
            tb_highest.ReadOnly = true;
            tb_highest.Size = new Size(87, 31);
            tb_highest.TabIndex = 12;
            // 
            // tb_lowest
            // 
            tb_lowest.Location = new Point(713, 262);
            tb_lowest.Name = "tb_lowest";
            tb_lowest.ReadOnly = true;
            tb_lowest.Size = new Size(78, 31);
            tb_lowest.TabIndex = 13;
            // 
            // tb_passed
            // 
            tb_passed.Location = new Point(404, 332);
            tb_passed.Name = "tb_passed";
            tb_passed.ReadOnly = true;
            tb_passed.Size = new Size(87, 31);
            tb_passed.TabIndex = 14;
            // 
            // tb_failed
            // 
            tb_failed.Location = new Point(713, 332);
            tb_failed.Name = "tb_failed";
            tb_failed.ReadOnly = true;
            tb_failed.Size = new Size(78, 31);
            tb_failed.TabIndex = 15;
            // 
            // tb_type
            // 
            tb_type.Location = new Point(486, 416);
            tb_type.Name = "tb_type";
            tb_type.ReadOnly = true;
            tb_type.Size = new Size(150, 31);
            tb_type.TabIndex = 16;
            // 
            // btn_caculate
            // 
            btn_caculate.Location = new Point(271, 130);
            btn_caculate.Name = "btn_caculate";
            btn_caculate.Size = new Size(112, 34);
            btn_caculate.TabIndex = 17;
            btn_caculate.Text = "Tính";
            btn_caculate.UseVisualStyleBackColor = true;
            btn_caculate.Click += btn_caculate_Click;
            // 
            // btn_erase
            // 
            btn_erase.Location = new Point(475, 130);
            btn_erase.Name = "btn_erase";
            btn_erase.Size = new Size(112, 34);
            btn_erase.TabIndex = 18;
            btn_erase.Text = "Xóa";
            btn_erase.UseVisualStyleBackColor = true;
            btn_erase.Click += btn_erase_Click;
            // 
            // btn_exit
            // 
            btn_exit.Location = new Point(676, 130);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(112, 34);
            btn_exit.TabIndex = 19;
            btn_exit.Text = "Thoát";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 29);
            label9.Name = "label9";
            label9.Size = new Size(433, 25);
            label9.TabIndex = 20;
            label9.Text = "Chỉ nhập các số thực không âm, cách nhau bởi dấu ','";
            // 
            // BT6
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 481);
            Controls.Add(label9);
            Controls.Add(btn_exit);
            Controls.Add(btn_erase);
            Controls.Add(btn_caculate);
            Controls.Add(tb_type);
            Controls.Add(tb_failed);
            Controls.Add(tb_passed);
            Controls.Add(tb_lowest);
            Controls.Add(tb_highest);
            Controls.Add(tb_average);
            Controls.Add(groupBox1);
            Controls.Add(tb_input);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "BT6";
            Text = "Bài 6";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox tb_input;
        private TextBox tb_score;
        private GroupBox groupBox1;
        private TextBox tb_average;
        private TextBox tb_highest;
        private TextBox tb_lowest;
        private TextBox tb_passed;
        private TextBox tb_failed;
        private TextBox tb_type;
        private Button btn_caculate;
        private Button btn_erase;
        private Button btn_exit;
        private Label label9;
    }
}