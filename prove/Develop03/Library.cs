public class Library
{
    private List<Book> _catalog;

    public Library()
    {
        _catalog = new List<Book>();
    }

    public void AddBook(Book book)
    {
        _catalog.Add(book);
    }
}