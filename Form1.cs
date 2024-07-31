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
                    MessageBox.Show("S? b?t ??u ph?i nh? h?n ho?t b?ng k?t thúc");
                    return;
                }

                double sum = 0;
                for (double i = startnum; i <= endnum; i++)
                {
                    sum += i;
                }
                txtTong.Text = sum.ToString();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
