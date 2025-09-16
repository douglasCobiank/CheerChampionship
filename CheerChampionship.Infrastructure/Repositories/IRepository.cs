using System.Linq.Expressions;

namespace CheerChampionship.Infrastructure.Repositories
{
    public interface IRepository<T> where T : class
    {
        Task AddAsync(T entity);
        Task EditAsync(T entity);
        Task DeleteAsync(T entity);
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate);
    }
}
