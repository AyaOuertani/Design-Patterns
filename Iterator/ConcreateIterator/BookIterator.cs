using Iterator.Books;
using Iterator.Interface.Iterator;

namespace Iterator.ConcreateIterator
{
    public class BookIterator : IBookIterator
    {
        private List<Book> _books;
        private int _position = 0;
        public BookIterator(List<Book> books)
        {
            _books = books;
        }
        public bool HasNext() => _position < _books.Count;
        public Book Next()
        {
            _books[_position].BookDetails();
            return _books[_position++];

        }
    }
}
