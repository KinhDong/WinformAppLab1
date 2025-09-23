namespace Lab1
{
    partial class BT3
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
            tb_int = new TextBox();
            tb_string = new TextBox();
            btn_read = new Button();
            btn_erase = new Button();
            btn_exit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 77);
            label1.Name = "label1";
            label1.Size = new Size(230, 25);
            label1.TabIndex = 0;
            label1.Text = "Nhập số nguyên từ 0 đến 9";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 223);
            label2.Name = "label2";
            label2.Size = new Size(72, 25);
            label2.TabIndex = 1;
            label2.Text = "Kết quả";
            // 
            // tb_int
            // 
            tb_int.Location = new Point(309, 74);
            tb_int.Name = "tb_int";
            tb_int.Size = new Size(150, 31);
            tb_int.TabIndex = 2;
            // 
            // tb_string
            // 
            tb_string.Location = new Point(49, 263);
            tb_string.Name = "tb_string";
            tb_string.ReadOnly = true;
            tb_string.Size = new Size(150, 31);
            tb_string.TabIndex = 3;
            // 
            // btn_read
            // 
            btn_read.Location = new Point(640, 72);
            btn_read.Name = "btn_read";
            btn_read.Size = new Size(112, 34);
            btn_read.TabIndex = 4;
            btn_read.Text = "Đọc";
            btn_read.UseVisualStyleBackColor = true;
            btn_read.Click += btn_read_Click;
            // 
            // btn_erase
            // 
            btn_erase.Location = new Point(640, 149);
            btn_erase.Name = "btn_erase";
            btn_erase.Size = new Size(112, 34);
            btn_erase.TabIndex = 5;
            btn_erase.Text = "Xóa";
            btn_erase.UseVisualStyleBackColor = true;
            btn_erase.Click += btn_erase_Click;
            // 
            // btn_exit
            // 
            btn_exit.Location = new Point(640, 223);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(112, 34);
            btn_exit.TabIndex = 6;
            btn_exit.Text = "Thoát";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // BT3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_exit);
            Controls.Add(btn_erase);
            Controls.Add(btn_read);
            Controls.Add(tb_string);
            Controls.Add(tb_int);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "BT3";
            Text = "Bài 3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tb_int;
        private TextBox tb_string;
        private Button btn_read;
        private Button btn_erase;
        private Button btn_exit;
    }
}