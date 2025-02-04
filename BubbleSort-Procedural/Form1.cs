namespace BubbleSort_Procedural
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            int[] numbers = {5, 6, 4, 3, 9, 2, 1};
            int[] sorted = BubbleSort(numbers);

            listBox1.DataSource = sorted;
        }

        private int[] BubbleSort(int[] numbers)
        {
            for (int i = numbers.Length - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }

            return numbers;
        }
    }


}
