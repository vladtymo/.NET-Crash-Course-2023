using _23_ef_base.Data;
using _23_ef_base.Entities;
using Microsoft.EntityFrameworkCore;
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
        public async Task<IEnumerable<Author>> GetAuthors()
        {
            return await context.Authors.ToListAsync();
        }

        public async Task AddBook(Book newBook)
        {
            await context.Books.AddAsync(newBook);
            await context.SaveChangesAsync(); // submit all changes to db
        }

        public async Task<Author?> GetAuthor(int id)
        {
            return await context.Authors.FindAsync(id);
        }
        public async Task DeleteAuthor(int id)
        {
            var item = await context.Authors.FindAsync(id);

            if (item == null) return;

            context.Authors.Remove(item);
            await context.SaveChangesAsync();
        }
        public async Task UpdateAuthor(Author author)
        {
            context.Authors.Update(author);
            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Book>> GetBooksByRating(int? top = null)
        {
            IQueryable<Book> query = context.Books.OrderByDescending(x => x.Rating);

            if (top != null) query = query.Take(top.Value);

            return await query.ToListAsync();
        }
    }
}
