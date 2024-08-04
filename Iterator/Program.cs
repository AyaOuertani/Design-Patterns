using Iterator.Books;
using Iterator.ConcreateCollection;
using Iterator.Interface.Collection;
using Iterator.Interface.Iterator;
using Iterator.Interface.Libraries;
using System;

class Program
{
    static void Main(string[] args)
    {
        IBookCollection fictionCollection = new BookCollection();
        fictionCollection.AddBook("Hunger Games", "Suzanne Collins");
        fictionCollection.AddBook("1984", "George Orwell");

        IBookCollection thrillerCollection = new BookCollection();
        thrillerCollection.AddBook("A Good Girl's Guide To Murder", "Holly Jackson");
        thrillerCollection.AddBook("The Woman In The Window", "A. J. Finn");

        IBookCollection scienceFictionCollection = new BookCollection();
        scienceFictionCollection.AddBook("Dune", "Frank Herbert");
        scienceFictionCollection.AddBook("Neuromancer", "William Gibson");

        List<IBookCollection> categoryCollections = new List<IBookCollection>
        {
            fictionCollection,
            thrillerCollection,
            scienceFictionCollection
        };
        Console.WriteLine("Collection Created");
        Library library = new Library(categoryCollections);
        ICollectionIterator collectionIterator = library.CreateIterator();

        Console.WriteLine("Starting iteration...");

        while (collectionIterator.HasNext())
        {
            IBookCollection bookCollection = collectionIterator.Next();
            Console.WriteLine("Iterating over a collection...");

            IBookIterator bookIterator = bookCollection.CreateIterator();

            while (bookIterator.HasNext())
            {
                Console.WriteLine("Iterating over Books...");
                Book book = bookIterator.Next();
                Console.WriteLine($"{book.Title} by {book.Author}");
            }
        }

        Console.WriteLine("Iteration complete.");

    }
}
