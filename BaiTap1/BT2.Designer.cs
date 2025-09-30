namespace Lab1
{
    partial class BT2
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
            tb_num1 = new TextBox();
            tb_num2 = new TextBox();
            tb_num3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            lb_num3 = new Label();
            btn_search = new Button();
            btn_delete = new Button();
            btn_exit = new Button();
            label3 = new Label();
            label4 = new Label();
            tb_max = new TextBox();
            tb_min = new TextBox();
            SuspendLayout();
            // 
            // tb_num1
            // 
            tb_num1.Location = new Point(131, 86);
            tb_num1.Name = "tb_num1";
            tb_num1.Size = new Size(73, 31);
            tb_num1.TabIndex = 0;
            // 
            // tb_num2
            // 
            tb_num2.Location = new Point(376, 86);
            tb_num2.Name = "tb_num2";
            tb_num2.Size = new Size(80, 31);
            tb_num2.TabIndex = 1;
            // 
            // tb_num3
            // 
            tb_num3.Location = new Point(699, 86);
            tb_num3.Name = "tb_num3";
            tb_num3.Size = new Size(89, 31);
            tb_num3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 89);
            label1.Name = "label1";
            label1.Size = new Size(105, 25);
            label1.TabIndex = 3;
            label1.Text = "Số thứ nhất";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(268, 89);
            label2.Name = "label2";
            label2.Size = new Size(93, 25);
            label2.TabIndex = 4;
            label2.Text = "Số thứ hai";
            // 
            // lb_num3
            // 
            lb_num3.AutoSize = true;
            lb_num3.Location = new Point(585, 89);
            lb_num3.Name = "lb_num3";
            lb_num3.Size = new Size(90, 25);
            lb_num3.TabIndex = 5;
            lb_num3.Text = "Số thứ ba";
            // 
            // btn_search
            // 
            btn_search.Location = new Point(75, 210);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(112, 34);
            btn_search.TabIndex = 6;
            btn_search.Text = "Tìm";
            btn_search.UseVisualStyleBackColor = true;
            btn_search.Click += btn_search_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(357, 210);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(112, 34);
            btn_delete.TabIndex = 7;
            btn_delete.Text = "Xóa";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_exit
            // 
            btn_exit.Location = new Point(636, 210);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(112, 34);
            btn_exit.TabIndex = 8;
            btn_exit.Text = "Thoát";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 353);
            label3.Name = "label3";
            label3.Size = new Size(103, 25);
            label3.TabIndex = 9;
            label3.Text = "Số lớn nhất";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(422, 353);
            label4.Name = "label4";
            label4.Size = new Size(109, 25);
            label4.TabIndex = 10;
            label4.Text = "Số nhỏ nhất";
            // 
            // tb_max
            // 
            tb_max.Location = new Point(131, 350);
            tb_max.Name = "tb_max";
            tb_max.ReadOnly = true;
            tb_max.Size = new Size(150, 31);
            tb_max.TabIndex = 11;
            // 
            // tb_min
            // 
            tb_min.Location = new Point(537, 350);
            tb_min.Name = "tb_min";
            tb_min.ReadOnly = true;
            tb_min.Size = new Size(150, 31);
            tb_min.TabIndex = 12;
            // 
            // BT2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 450);
            Controls.Add(tb_min);
            Controls.Add(tb_max);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btn_exit);
            Controls.Add(btn_delete);
            Controls.Add(btn_search);
            Controls.Add(lb_num3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tb_num3);
            Controls.Add(tb_num2);
            Controls.Add(tb_num1);
            Name = "BT2";
            Text = "Bài 2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_num1;
        private TextBox tb_num2;
        private TextBox tb_num3;
        private Label label1;
        private Label label2;
        private Label lb_num3;
        private Button btn_search;
        private Button btn_delete;
        private Button btn_exit;
        private Label label3;
        private Label label4;
        private TextBox tb_max;
        private TextBox tb_min;
    }
}
