using Microsoft.EntityFrameworkCore;

namespace lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Author
        {
            public int AuthorID { get; set; }

            public string Name { get; set; }
            public virtual ICollection<Book> Books { get; set; }
        }

        public class Book
        {
            public int BookID { get; set; }
            public string Title { get; set; }
            public int AuthorID { get; set; }
            public virtual Author Author { get; set; }
        }

        public async Task SaveBookAsync(string authorName, string bookTitle)
        {
            using (var context = new BookstoreContext())
            {
                var author = new Author { Name = authorName };
                var book = new Book { Title = bookTitle, Author = author };
                context.Authors.Add(author);
                context.Books.Add(book);
                await context.SaveChangesAsync();
            }
        }

        public async Task<List<string>> GetBooksAsync()
        {
            using (var context = new BookstoreContext())
            {
                var booksWithAuthors = await context.Books
                    .Include(b => b.Author)
                    .Select(b => $"{b.Title} by {b.Author.Name}")
                    .ToListAsync();
                return booksWithAuthors;
            }
        }

        public async Task UpdateBookAndAuthor(int bookId, string newTitle, string newAuthorName)
        {
            using (var context = new BookstoreContext())
            {
                var book = context.Books.Include(b => b.Author).FirstOrDefault(b => b.BookID == bookId);

                if (book != null)
                {
                    book.Title = newTitle;
                    book.Author.Name = newAuthorName;
                    await context.SaveChangesAsync();
                }
            }
        }

        private async void btnAddBook_Click(object sender, EventArgs e)
        {
            await SaveBookAsync(txtAuthorName.Text, txtBookTitle.Text);
        }

        private async void btnUpdateBook_Click(object sender, EventArgs e)
        {
            int bookId = int.Parse(txtBookID.Text);
            await UpdateBookAndAuthor(bookId, txtBookTitle.Text, txtAuthorName.Text);
            MessageBox.Show("Book and Author updated successfully.");
        }

        private async void btnShowBooks_Click(object sender, EventArgs e)
        {
            var books = await GetBooksAsync();
            listBoxBooks.DataSource = books;
        }
    }
}
