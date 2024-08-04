using Iterator.Books;
using Iterator.Interface.Collection;
using Iterator.Interface.Iterator;
using Iterator.ConcreateIterator;
namespace Iterator.ConcreateCollection
{
    public class BookCollection : IBookCollection
    {
        private List<Book> _books = new List<Book>();
        public BookCollection()
        {
            _books = new List<Book>();
        }
        public void AddBook(string title, string auther)
        {
            _books.Add(new Book(title, auther));
            Console.WriteLine( $"Book {title} Added Successfully");
        }
        public void RemoveBook(Book removeBook)
        {
            if (_books.Contains(removeBook))
            {
                _books.Remove(removeBook);
                Console.WriteLine("Remved Successfully");
            }
            else
            {
                Console.WriteLine("Book Not Found !");
            }
        }
        public IBookIterator CreateIterator()
        {
            return new BookIterator(_books);
        }
    }
}
