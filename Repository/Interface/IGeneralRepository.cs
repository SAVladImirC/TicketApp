using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Linq.Expressions;

namespace Repository.Interface
{
    public interface IGeneralRepository<T> where T : class, new()
    {
        public Task<T?> FindSingle(Expression<Func<T, bool>> expression);

        public Task<List<T>> FindAll(Expression<Func<T, bool>> expression);

        public Task<T> Insert(T entity);

        public Task<T> Update(T entity);

        public Task BatchInsert(IEnumerable<T> entities);

        public Task BatchUpdate(IEnumerable<T> entities);

        public Task<T> Delete(T entity);

        public void BatchDelete(IEnumerable<T> entities);

        public int Count();

        public EntityEntry GetEntry(T entry);
    }
}
