using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Exam_Task.Database.GenericRepository
{
	public class GenericRepository<T> : IGenericRepository<T> where T : class
	{
		private readonly ApplicationDbContext _context;
		public DbSet<T> Table { get; }

		public GenericRepository(ApplicationDbContext context)
		{
			_context = context;
			Table = _context.Set<T>();
		}

		public async Task<string> Create(T entity)
		{
			try
			{
				await Table.AddAsync(entity);
				await _context.SaveChangesAsync();
				return string.Empty;
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}

		public async Task<string> Delete(T entity)
		{
			try
			{
				Table.Remove(entity);
				await _context.SaveChangesAsync();
				return string.Empty;
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}

		public async Task<ICollection<T>> GetAll()
		{
			return await Table.ToListAsync();
		}

		public async Task<T> GetById(long id)
		{
			return await Table.FindAsync(id);
		}

		public async Task<string> Update(T entity)
		{
			try
			{
				Table.Update(entity);
				await _context.SaveChangesAsync();
				return string.Empty;
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
		public async Task<int> SaveChangesAsync()
		{
			return await _context.SaveChangesAsync();
		}
		public async Task<T> GetBy(Expression<Func<T, bool>> expression)
		{
			return await Table.FirstOrDefaultAsync(expression);
		}
	}
}
