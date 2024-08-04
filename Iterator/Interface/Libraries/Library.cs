using Iterator.ConcreateCollection;
using Iterator.ConcreateIterator;
using Iterator.Interface.Collection;
using Iterator.Interface.Iterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Interface.Libraries
{
    public class Library
    {
        private List<IBookCollection> _categoryCollections;
        public Library(List<IBookCollection> categoryCollections)
        {
            _categoryCollections = categoryCollections;
        }
        public ICollectionIterator CreateIterator()
        {
            return new LibraryIterator(_categoryCollections);
        }
    }
}
