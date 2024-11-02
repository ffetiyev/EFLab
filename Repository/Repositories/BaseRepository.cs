using Domain.Common;
using Microsoft.EntityFrameworkCore;
using Repository.Data;
using Repository.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        private readonly AppDbContext _context;
        private readonly DbSet<T> _table;

        public BaseRepository()
        {
            _context = new AppDbContext();
            _table=_context.Set<T>();

        }

        public async Task Commit()
        {
            await _context.SaveChangesAsync();
        }

        public async Task CreateAsync(T data)
        {
            await _table.AddAsync(data);

        }

        public async Task DeleteFromDbAsync(int id)
        {
            var data = await _table.FirstOrDefaultAsync(x => x.Id == id);
            _table.Remove(data);
            await _context.SaveChangesAsync();


        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _table.ToListAsync();
        }

        public Task<List<T>> GetAllByAdminAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<List<T>> GetAllWithConditionAsync(Expression<Func<T, bool>> predicate)
        {
            return await _table.Where(predicate).ToListAsync();    
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _table.FirstOrDefaultAsync(m => m.Id == id);
        }

        public Task<List<T>> GetByIdByAdminAsync()
        {
            throw new NotImplementedException();
        }

        public Task SoftDeleteAsync(int id)
        {
            
        }

        public async Task UpdateAsync(T data)
        {
            _table.Update(data);
            await _context.SaveChangesAsync();
        }

       
    }
}
