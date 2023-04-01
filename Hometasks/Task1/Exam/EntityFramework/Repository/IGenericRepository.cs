using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Exam.EntityFramework.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        DbSet<T> Table { get; }

        public Task Create(T entity);
        public Task Delete(T entity);
        public Task<bool> Update(T entity);

        public Task<T> GetById(long id);
        public Task<T> GetBy(Expression<Func<T, bool>> expression);
        public IQueryable<T> GetAsQueryable();
        public IQueryable<T> GetAsQueryable(Expression<Func<T, bool>> expression);
    }
}