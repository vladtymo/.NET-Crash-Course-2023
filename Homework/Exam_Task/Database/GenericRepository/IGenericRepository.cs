using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Exam_Task.Database.GenericRepository
{
	public interface IGenericRepository<T> where T : class
	{
		DbSet<T> Table { get; }
		Task<string> Create(T entity);
		Task<string> Update(T entity);
		Task<string> Delete(T entity);
		Task<T> GetById(long id);
		Task<T> GetBy(Expression<Func<T, bool>> expression);
		Task<ICollection<T>> GetAll();
		Task<int> SaveChangesAsync();
	}
}
