using Domain.Models;
using Repository.Repositories;
using Repository.Repositories.Interfaces;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepo;

        public OrderService()
        {
            _orderRepo = new OrderRepository();
        }
        public async Task CreateAsync(Order data)
        {
            await _orderRepo.CreateAsync(data);
            await _orderRepo.Commit();
        }

        public Task DeleteFromDbAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Order>> GetAllAsync()
        {
            return await _orderRepo.GetAllAsync();
        }

        public Task<List<Order>> GetAllByAdminAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<Order>> GetAllWithConditionAsync(Expression<Func<Order, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<Order> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Order>> GetByIdByAdminAsync()
        {
            throw new NotImplementedException();
        }

        public Task SoftDeleteAsync(Order data)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Order data)
        {
            throw new NotImplementedException();
        }
    }
}
