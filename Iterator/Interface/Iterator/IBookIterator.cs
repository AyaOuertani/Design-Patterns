using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iterator.Books;

namespace Iterator.Interface.Iterator
{
    public interface IBookIterator
    {
        public bool HasNext();
        public Book Next();
    }
}
