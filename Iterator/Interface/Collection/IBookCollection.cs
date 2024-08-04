using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iterator.Interface.Iterator;
using Iterator.ConcreateIterator;
using Iterator.Books;

namespace Iterator.Interface.Collection
{
    public interface IBookCollection
    {
        public IBookIterator CreateIterator();
        public void AddBook(string title, string auther);
        public void RemoveBook(Book removeBook);
    }
}
