public class BookService 
{
    public static List<Book> Books = new List<Book>
    {
        new Book { Id = 1, Title = "1", Author = "1" },
        new Book { Id = 2, Title = "2", Author = "2" },
        new Book { Id = 3, Title = "3", Author = "3" }
    };

    // Get list of books 
    public IEnumerable<Book> GetAllBooks() => Books;

    public void AddBook(Book book) => Books.Add(book);
}