using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories.Interfaces
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        public Task CreateAsync(T data);

        public Task DeleteFromDbAsync(int id);
        public Task<IEnumerable<T>> GetAllAsync();
        public Task<List<T>> GetAllByAdminAsync();
        public Task<List<T>> GetAllWithConditionAsync(Expression<Func<T, bool>> predicate);
        public Task<T> GetByIdAsync(int id);
        public Task<List<T>> GetByIdByAdminAsync();
        public Task SoftDeleteAsync(T data);
        public Task UpdateAsync(T data);
        public Task Commit();
        
    }
}
