using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Exam.EntityFramework.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;

        public GenericRepository(ApplicationDbContext dbContext)
        {
            _context = dbContext;
            Table = _context.Set<T>();
        }

        public DbSet<T> Table { get; }

        public async Task Create(T entity)
        {
            await Table.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(T entity)
        {
            Table.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<T> GetBy(Expression<Func<T, bool>> expression)
        {
            return await Table.FirstOrDefaultAsync(expression);
        }

        public async Task<T> GetById(long id)
        {
            return await Table.FindAsync(id);
        }

        public async Task<bool> Update(T entity)
        {
            try
            {
                Table.Update(entity);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public IQueryable<T> GetAsQueryable(Expression<Func<T, bool>> expression)
        {
            return Table.Where(expression);
        }

        public IQueryable<T> GetAsQueryable()
        {
            return Table.AsNoTracking();
        }
    }
}