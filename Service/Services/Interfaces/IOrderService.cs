using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Interfaces
{
    public interface IOrderService
    {
        public Task CreateAsync(Order data);

        public Task DeleteFromDbAsync(int id);
        public Task<IEnumerable<Order>> GetAllAsync();
        public Task<List<Order>> GetAllByAdminAsync();
        public Task<List<Order>> GetAllWithConditionAsync(Expression<Func<Order, bool>> predicate);
        public Task<Order> GetByIdAsync(int id);
        public Task<List<Order>> GetByIdByAdminAsync();
        public Task SoftDeleteAsync(Order data);
        public Task UpdateAsync(Order data);

    }
}
