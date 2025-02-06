namespace ExponentRecursion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Text = Convert.ToString(Exponent(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text)));
        }

        private int Exponent(int baseNum, int exp)
        {
            if (exp == 0) return 1; // Base case: anything^0 = 1
            return baseNum * Exponent(baseNum, exp - 1);
        }
    }
}
