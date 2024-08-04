using Iterator.Interface.Collection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Interface.Iterator
{
    public interface ICollectionIterator
    {
        public bool HasNext();
        public IBookCollection Next();
    }
}
