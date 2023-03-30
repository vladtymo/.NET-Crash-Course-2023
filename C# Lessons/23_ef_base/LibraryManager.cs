using _23_ef_base.Data;
using _23_ef_base.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_ef_base
{
    internal class LibraryManager
    {
        private readonly LibraryDbContext context;
        public LibraryManager(LibraryDbContext context)
        {
            this.context = context;
        }

        // ----------- public interface -----------
        public IEnumerable<Author> GetAuthors()
        {
            return context.Authors.ToList();
        }

        public void AddBook(Book newBook)
        {
            context.Books.Add(newBook);
            context.SaveChanges(); // submit all changes to db
        }

        public Author? GetAuthor(int id)
        {
            return context.Authors.Find(id);
        }
        public void DeleteAuthor(int id)
        {
            var item = context.Authors.Find(id);

            if (item == null) return;

            context.Authors.Remove(item);
            context.SaveChanges();
        }
        public void UpdateAuthor(Author author)
        {
            context.Authors.Update(author);
            context.SaveChanges();
        }

        public IEnumerable<Book> GetBooksByRating(int? top = null)
        {
            IQueryable<Book> query = context.Books.OrderByDescending(x => x.Rating);

            if (top != null) query = query.Take(top.Value);

            return query.ToList();
        }
    }
}
