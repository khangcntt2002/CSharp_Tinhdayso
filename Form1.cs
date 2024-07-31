using System;

namespace CSharp_Tinhdayso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double startnum = double.Parse(input1.Text);
                double endnum = double.Parse(input2.Text);



                if (startnum > endnum)
                {
                    MessageBox.Show("Số bắt đầu phải nhỏ hơn hoặt bằng kết thúc");
                    return;
                }

                double tong = 0;
                double tich = 1;
                double tongsochan = 0;
                double tongsole = 0;
                for (double i = startnum; i <= endnum; i++)
                {
                    tong += i;
                    tich *= i;
                    if (i / 2 == 0)
                    {
                        tongsochan += i;
                    }
                    else
                    {
                        tongsole += i;

                    }
                } 
                // Số khác update
                txtTong.Text = tong.ToString();
                txtTich.Text = tich.ToString();
                txtChan.Text = tongsochan.ToString();
                txtLe.Text = tongsole.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("VUI LÒNG NHẬP SỐ HỢP LỆ:", "LỖI", MessageBoxButtons.OK);

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtTong.Clear();
            txtTich.Clear();
            txtChan.Clear();
            txtLe.Clear();
        }
    }
}
