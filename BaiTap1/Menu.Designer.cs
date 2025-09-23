namespace BaiTap1
{
    partial class Menu
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
            btn_bai1 = new Button();
            btn_bai2 = new Button();
            btn_bai3 = new Button();
            btn_bai4 = new Button();
            btn_bai5 = new Button();
            btn_bai6 = new Button();
            SuspendLayout();
            // 
            // btn_bai1
            // 
            btn_bai1.Location = new Point(148, 66);
            btn_bai1.Name = "btn_bai1";
            btn_bai1.Size = new Size(112, 34);
            btn_bai1.TabIndex = 0;
            btn_bai1.Text = "Bài tập 1";
            btn_bai1.UseVisualStyleBackColor = true;
            btn_bai1.Click += button1_Click;
            // 
            // btn_bai2
            // 
            btn_bai2.Location = new Point(529, 66);
            btn_bai2.Name = "btn_bai2";
            btn_bai2.Size = new Size(112, 34);
            btn_bai2.TabIndex = 1;
            btn_bai2.Text = "Bài tập 2";
            btn_bai2.UseVisualStyleBackColor = true;
            btn_bai2.Click += button2_Click;
            // 
            // btn_bai3
            // 
            btn_bai3.Location = new Point(148, 202);
            btn_bai3.Name = "btn_bai3";
            btn_bai3.Size = new Size(112, 34);
            btn_bai3.TabIndex = 2;
            btn_bai3.Text = "Bài tập 3";
            btn_bai3.UseVisualStyleBackColor = true;
            btn_bai3.Click += button3_Click;
            // 
            // btn_bai4
            // 
            btn_bai4.Location = new Point(529, 202);
            btn_bai4.Name = "btn_bai4";
            btn_bai4.Size = new Size(112, 34);
            btn_bai4.TabIndex = 3;
            btn_bai4.Text = "Bài tập 4";
            btn_bai4.UseVisualStyleBackColor = true;
            btn_bai4.Click += button4_Click;
            // 
            // btn_bai5
            // 
            btn_bai5.Location = new Point(148, 340);
            btn_bai5.Name = "btn_bai5";
            btn_bai5.Size = new Size(112, 34);
            btn_bai5.TabIndex = 4;
            btn_bai5.Text = "Bài tập 5";
            btn_bai5.UseVisualStyleBackColor = true;
            btn_bai5.Click += button5_Click;
            // 
            // btn_bai6
            // 
            btn_bai6.Location = new Point(529, 340);
            btn_bai6.Name = "btn_bai6";
            btn_bai6.Size = new Size(112, 34);
            btn_bai6.TabIndex = 5;
            btn_bai6.Text = "Bài tập 6";
            btn_bai6.UseVisualStyleBackColor = true;
            btn_bai6.Click += btn_bai6_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_bai6);
            Controls.Add(btn_bai5);
            Controls.Add(btn_bai4);
            Controls.Add(btn_bai3);
            Controls.Add(btn_bai2);
            Controls.Add(btn_bai1);
            Name = "Menu";
            Text = "Lab1";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_bai1;
        private Button btn_bai2;
        private Button btn_bai3;
        private Button btn_bai4;
        private Button btn_bai5;
        private Button btn_bai6;
    }
}