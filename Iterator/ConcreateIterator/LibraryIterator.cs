using Iterator.Interface.Collection;
using Iterator.Interface.Iterator;

namespace Iterator.ConcreateIterator
{
    public class LibraryIterator : ICollectionIterator
    {
        private List<IBookCollection> _bookCollection;
        private int _index = 0;

        public LibraryIterator(List<IBookCollection> bookCollection)
        {
            _bookCollection = bookCollection;
        }
        public bool HasNext() => _index < _bookCollection.Count;
        public IBookCollection Next()
        {
            return !HasNext() ? throw new InvalidOperationException("No more collections.")
                              : _bookCollection[_index++];
        }
    }
}
