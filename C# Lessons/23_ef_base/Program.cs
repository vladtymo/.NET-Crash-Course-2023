using _23_ef_base.Data;

namespace _23_ef_base
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LibraryDbContext context = new LibraryDbContext();

            // ------------ READ
            var result = context.Authors.ToList();

            Console.WriteLine("----------- Authors:");
            foreach (var item in result)
            {
                Console.WriteLine($"[{item.Id}] - {item.FirstName} {item.LastName}, {item.Country}");
            }

            // get by id
            Console.WriteLine("Enter author id to find:");
            int id = int.Parse(Console.ReadLine());

            var author = context.Authors.Find(id);

            if (author == null) Console.WriteLine("Author with your id not found!");
            else
                Console.WriteLine($"Found author: {author.FirstName} {author.LastName}!");

            // ------------ INSERT
            Console.WriteLine("------- Add New Book");

            Console.Write("Enter book info (title, price, pages, author id):");
            Book newBook = new Book()
            {
                Title = Console.ReadLine(),
                Price = decimal.Parse(Console.ReadLine()),
                Pages = int.Parse(Console.ReadLine()),
                AuthorId = int.Parse(Console.ReadLine()),
            };
            context.Books.Add(newBook);

            // ------------ UPDATE
            if (author != null)
                author.FirstName += " de";

            // ------------ DELETE
            if (author != null)
                context.Authors.Remove(author);

            context.SaveChanges(); // submit all changes to db

            // ---------------------------- LINQ
            var myBooks = context.Books.Where(x => x.Price < 1000).OrderByDescending(x => x.Pages).ToList();

            Console.WriteLine("Found books count: " + myBooks.Count);
        }
    }
}