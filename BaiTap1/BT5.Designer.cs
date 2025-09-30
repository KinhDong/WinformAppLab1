namespace Lab1
{
    partial class BT5
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
            tb_numA = new TextBox();
            tb_numB = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btn_caculate = new Button();
            btn_erase = new Button();
            btn_exit = new Button();
            tb_result = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // tb_numA
            // 
            tb_numA.Location = new Point(205, 48);
            tb_numA.Name = "tb_numA";
            tb_numA.Size = new Size(150, 31);
            tb_numA.TabIndex = 0;
            // 
            // tb_numB
            // 
            tb_numB.Location = new Point(566, 48);
            tb_numB.Name = "tb_numB";
            tb_numB.Size = new Size(150, 31);
            tb_numB.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 51);
            label1.Name = "label1";
            label1.Size = new Size(96, 25);
            label1.TabIndex = 2;
            label1.Text = "Nhập số A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(455, 51);
            label2.Name = "label2";
            label2.Size = new Size(94, 25);
            label2.TabIndex = 3;
            label2.Text = "Nhập số B";
            // 
            // btn_caculate
            // 
            btn_caculate.Location = new Point(106, 125);
            btn_caculate.Name = "btn_caculate";
            btn_caculate.Size = new Size(150, 34);
            btn_caculate.TabIndex = 4;
            btn_caculate.Text = "Tính các giá trị";
            btn_caculate.UseVisualStyleBackColor = true;
            btn_caculate.Click += btn_caculate_Click;
            // 
            // btn_erase
            // 
            btn_erase.Location = new Point(375, 125);
            btn_erase.Name = "btn_erase";
            btn_erase.Size = new Size(112, 34);
            btn_erase.TabIndex = 5;
            btn_erase.Text = "Xóa";
            btn_erase.UseVisualStyleBackColor = true;
            btn_erase.Click += btn_erase_Click;
            // 
            // btn_exit
            // 
            btn_exit.Location = new Point(604, 125);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(112, 34);
            btn_exit.TabIndex = 6;
            btn_exit.Text = "Thoát";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // tb_result
            // 
            tb_result.AllowDrop = true;
            tb_result.ForeColor = SystemColors.HotTrack;
            tb_result.Location = new Point(78, 220);
            tb_result.Multiline = true;
            tb_result.Name = "tb_result";
            tb_result.ReadOnly = true;
            tb_result.Size = new Size(660, 197);
            tb_result.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(78, 192);
            label3.Name = "label3";
            label3.Size = new Size(72, 25);
            label3.TabIndex = 8;
            label3.Text = "Kết quả";
            // 
            // BT5
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(tb_result);
            Controls.Add(btn_exit);
            Controls.Add(btn_erase);
            Controls.Add(btn_caculate);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tb_numB);
            Controls.Add(tb_numA);
            Name = "BT5";
            Text = "Bài 4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_numA;
        private TextBox tb_numB;
        private Label label1;
        private Label label2;
        private Button btn_caculate;
        private Button btn_erase;
        private Button btn_exit;
        private TextBox tb_result;
        private Label label3;
    }
}
