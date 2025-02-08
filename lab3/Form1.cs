using System;
using System.Windows.Forms;

namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }

            public virtual string GetInfo()
            {
                return $"{Title} by {Author}";
            }
        }

        public class Magazine : Book
        {
            public int IssueNumber { get; set; }

            public override string GetInfo()
            {
                return $"{Title} - Issue {IssueNumber}";
            }
        }

        public class Ebook : Book
        {
            public string Format { get; set; }

            public override string GetInfo()
            {
                return $"{Title} (eBook - {Format})";
            }
        }

        // Polymorphic function to process books
        private void DisplayBooks(Book[] books)
        {
            listBox1.Items.Clear(); // Assuming you have a ListBox named listBox1
            foreach (var book in books)
            {
                listBox1.Items.Add(book.GetInfo());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Book[] books = new Book[]
            {
                new Book { Title = "C# Basics", Author = "John Doe" },
                new Magazine { Title = "Linus Tech Tips", IssueNumber = 420 },
                new Ebook { Title = "Learn C# in 10 Hours", Author = "BroCode", Format = "PDF" }
            };

            DisplayBooks(books);
        }
    }
}
