using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Books
{
    public class Book
    {
        public string Title { get; private set; }
        public string Author { get; private set; } 
        public Book(string name, string title)
        {
            Title = name;
            Author = title;
        }
        public string BookDetails()
        {
            return $"Book :\nTitle : {Title}\nAuthor : {Author}";
        }
    }
}
