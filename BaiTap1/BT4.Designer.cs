namespace Lab1
{
    partial class BT4
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
            btn_convert = new Button();
            tb_foreign = new TextBox();
            tb_rate = new TextBox();
            tb_vnd = new TextBox();
            cb_money = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 29);
            label1.Name = "label1";
            label1.Size = new Size(259, 38);
            label1.TabIndex = 0;
            label1.Text = "Chuyển đổi tiền tệ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(112, 123);
            label2.Name = "label2";
            label2.Size = new Size(130, 25);
            label2.TabIndex = 1;
            label2.Text = "Số tiền cần đổi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(150, 282);
            label3.Name = "label3";
            label3.Size = new Size(123, 25);
            label3.TabIndex = 2;
            label3.Text = "Số tiền đã đổi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(150, 359);
            label4.Name = "label4";
            label4.Size = new Size(120, 25);
            label4.TabIndex = 3;
            label4.Text = "Tỉ giá quy đổi";
            // 
            // btn_convert
            // 
            btn_convert.Location = new Point(215, 202);
            btn_convert.Name = "btn_convert";
            btn_convert.Size = new Size(398, 34);
            btn_convert.TabIndex = 4;
            btn_convert.Text = "Chuyển đổi";
            btn_convert.UseVisualStyleBackColor = true;
            btn_convert.Click += btn_convert_Click;
            // 
            // tb_foreign
            // 
            tb_foreign.Location = new Point(271, 120);
            tb_foreign.Name = "tb_foreign";
            tb_foreign.Size = new Size(150, 31);
            tb_foreign.TabIndex = 5;
            // 
            // tb_rate
            // 
            tb_rate.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            tb_rate.Location = new Point(289, 356);
            tb_rate.Name = "tb_rate";
            tb_rate.ReadOnly = true;
            tb_rate.Size = new Size(150, 31);
            tb_rate.TabIndex = 6;
            // 
            // tb_vnd
            // 
            tb_vnd.Location = new Point(289, 279);
            tb_vnd.Name = "tb_vnd";
            tb_vnd.ReadOnly = true;
            tb_vnd.Size = new Size(150, 31);
            tb_vnd.TabIndex = 7;
            // 
            // cb_money
            // 
            cb_money.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_money.FormattingEnabled = true;
            cb_money.Items.AddRange(new object[] { "USD (Đô la Mỹ)", "EUR (Euro)", "GBP (Bảng Anh)", "SGD (Đô la Singapore)", "JPY (Yên)" });
            cb_money.Location = new Point(454, 120);
            cb_money.Name = "cb_money";
            cb_money.Size = new Size(182, 33);
            cb_money.TabIndex = 8;
            cb_money.SelectedIndexChanged += cb_money_SelectedIndexChanged;
            // 
            // BT4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cb_money);
            Controls.Add(tb_vnd);
            Controls.Add(tb_rate);
            Controls.Add(tb_foreign);
            Controls.Add(btn_convert);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "BT4";
            Text = "Bài 4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btn_convert;
        private TextBox tb_foreign;
        private TextBox tb_rate;
        private TextBox tb_vnd;
        private ComboBox cb_money;
    }
}