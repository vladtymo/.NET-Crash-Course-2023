using _23_ef_base.Data;

namespace _23_ef_base
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LibraryManager manager = new LibraryManager(new LibraryDbContext());

            // ------------ READ
            Console.WriteLine("----------- Authors:");
            foreach (var item in manager.GetAuthors())
            {
                Console.WriteLine($"[{item.Id}] - {item.FirstName} {item.LastName}, {item.Country}");
            }

            // get by id
            Console.WriteLine("Enter author id to find:");
            int id = int.Parse(Console.ReadLine());

            var author = manager.GetAuthor(id);

            if (author == null) Console.WriteLine("Author with your id not found!");
            else
                Console.WriteLine($"Found author: {author.FirstName} {author.LastName}!");

            // ------------ INSERT
            Console.WriteLine("------- Add New Book");

            Console.Write("Enter book info (title, price, pages, rating, author id):");
            Book newBook = new Book()
            {
                Title = Console.ReadLine(),
                Price = decimal.Parse(Console.ReadLine()),
                Pages = int.Parse(Console.ReadLine()),
                Rating = float.Parse(Console.ReadLine()),
                AuthorId = int.Parse(Console.ReadLine()),
            };
            manager.AddBook(newBook);

            // ------------ UPDATE
            if (author != null)
                manager.UpdateAuthor(author);

            // ------------ DELETE
            if (author != null)
                manager.DeleteAuthor(author.Id);

            // ---------------------------- LINQ
            var myBooks = manager.GetBooksByRating(3);

            Console.WriteLine("Found books count: " + myBooks.Count());
        }
    }
}