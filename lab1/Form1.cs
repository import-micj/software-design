namespace lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int[] ProceduralSort(int[] numbers)
        {
            Array.Sort(numbers);
            return numbers;
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            int[] numbers = { 5, 4, 3, 2, 1 };
            int[] sorted_numbers = ProceduralSort(numbers);

            listBoxResults.DataSource = sorted_numbers;
        }


    }
}
