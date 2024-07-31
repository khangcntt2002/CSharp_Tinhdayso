namespace CSharp_Tinhdayso
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtTinhToan = new Button();
            label7 = new Label();
            label8 = new Label();
            input1 = new TextBox();
            txtTong = new TextBox();
            txtTich = new TextBox();
            txtChan = new TextBox();
            txtLe = new TextBox();
            input2 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 9);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(207, 33);
            label1.TabIndex = 0;
            label1.Text = "Giới hạn dãy số:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Yellow;
            label2.Location = new Point(15, 71);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(106, 33);
            label2.TabIndex = 0;
            label2.Text = "Kết quả";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(84, 136);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(174, 33);
            label3.TabIndex = 0;
            label3.Text = "Tổng Các Số:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(95, 203);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(162, 33);
            label4.TabIndex = 0;
            label4.Text = "Tích Các Số:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 259);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(242, 33);
            label5.TabIndex = 0;
            label5.Text = "Tổng Các Số Chẵn:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(49, 317);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(209, 33);
            label6.TabIndex = 0;
            label6.Text = "Tổng Các Số Lẻ:";
            // 
            // txtTinhToan
            // 
            txtTinhToan.BackColor = Color.Cyan;
            txtTinhToan.Location = new Point(584, 136);
            txtTinhToan.Name = "txtTinhToan";
            txtTinhToan.Size = new Size(178, 100);
            txtTinhToan.TabIndex = 1;
            txtTinhToan.Text = "Tính";
            txtTinhToan.UseVisualStyleBackColor = false;
            txtTinhToan.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(231, 9);
            label7.Name = "label7";
            label7.Size = new Size(98, 33);
            label7.TabIndex = 2;
            label7.Text = "Số BĐ:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(513, 9);
            label8.Name = "label8";
            label8.Size = new Size(95, 33);
            label8.TabIndex = 2;
            label8.Text = "Số KT:";
            // 
            // input1
            // 
            input1.BackColor = Color.DarkOrange;
            input1.Location = new Point(321, 6);
            input1.Name = "input1";
            input1.Size = new Size(172, 40);
            input1.TabIndex = 3;
            // 
            // txtTong
            // 
            txtTong.BackColor = Color.FromArgb(255, 255, 192);
            txtTong.Location = new Point(267, 136);
            txtTong.Name = "txtTong";
            txtTong.Size = new Size(226, 40);
            txtTong.TabIndex = 3;
            // 
            // txtTich
            // 
            txtTich.BackColor = Color.FromArgb(255, 255, 192);
            txtTich.Location = new Point(267, 201);
            txtTich.Name = "txtTich";
            txtTich.Size = new Size(226, 40);
            txtTich.TabIndex = 3;
            // 
            // txtChan
            // 
            txtChan.BackColor = Color.FromArgb(255, 255, 192);
            txtChan.Location = new Point(267, 259);
            txtChan.Name = "txtChan";
            txtChan.Size = new Size(226, 40);
            txtChan.TabIndex = 3;
            // 
            // txtLe
            // 
            txtLe.BackColor = Color.FromArgb(255, 255, 192);
            txtLe.Location = new Point(267, 317);
            txtLe.Name = "txtLe";
            txtLe.Size = new Size(226, 40);
            txtLe.TabIndex = 3;
            // 
            // input2
            // 
            input2.BackColor = Color.DarkOrange;
            input2.Location = new Point(601, 6);
            input2.Name = "input2";
            input2.Size = new Size(172, 40);
            input2.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(584, 291);
            button1.Name = "button1";
            button1.Size = new Size(178, 66);
            button1.TabIndex = 4;
            button1.Text = "Tính Tiếp";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 128);
            ClientSize = new Size(801, 464);
            Controls.Add(button1);
            Controls.Add(txtLe);
            Controls.Add(txtChan);
            Controls.Add(txtTich);
            Controls.Add(txtTong);
            Controls.Add(input2);
            Controls.Add(input1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtTinhToan);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Tahoma", 20F);
            Margin = new Padding(6, 7, 6, 7);
            Name = "Form1";
            Text = "Bảng Cửu Chương";
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
        private Button txtTinhToan;
        private Label label7;
        private Label label8;
        private TextBox input1;
        private TextBox txtTong;
        private TextBox txtTich;
        private TextBox txtChan;
        private TextBox txtLe;
        private TextBox input2;
        private Button button1;
    }
}
