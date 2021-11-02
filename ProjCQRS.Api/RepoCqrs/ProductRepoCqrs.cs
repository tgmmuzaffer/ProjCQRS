namespace ProjCQRS.Api.RepoCqrs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Threading.Tasks;
    using ProjCQRS.Api.DataAccess;
    using ProjCQRS.Api.Entity;
    using ProjCQRS.Api.RepoCqrs.IRepoCqrs;
    using Microsoft.EntityFrameworkCore;

    public class ProductRepoCqrs : IProductRepoCqrs
    {
        private readonly ProjCQRSDbContext _dbContext;
        public ProductRepoCqrs(ProjCQRSDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Product> AddAsync(Product entity)
        {
            await _dbContext.Products.AddAsync(entity);
            _dbContext.Entry(entity.Category).State = EntityState.Detached;
            _dbContext.SaveChanges();
            return entity;
        }

        public async Task<bool> DeleteAsync(int Id)
        {
            var entity = await _dbContext.Products.Where(a => a.Id == Id).FirstOrDefaultAsync();
            _dbContext.Products.Remove(entity);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<Product> Get(Expression<Func<Product, bool>> filter = null)
        {
            return filter == null ?
               await _dbContext.Products.Include(c => c.Category).FirstOrDefaultAsync()
               : await _dbContext.Products.Include(c => c.Category).Where(filter).FirstOrDefaultAsync();
        }

        public async Task<ICollection<Product>> GetListAsync(Expression<Func<Product, bool>> filter = null)
        {
            return filter == null ?
                 await _dbContext.Products.Include(c => c.Category).ToListAsync()
                 : await _dbContext.Products.Include(c => c.Category).Where(filter).ToListAsync();

        }

        public async Task<Product> UpdateAsync(Product entity)
        {
            return await Task.Run(() =>
            {
                _dbContext.Products.Update(entity);
                _dbContext.Entry(entity.Category).State = EntityState.Unchanged;
                _dbContext.SaveChanges();
                return entity;
            });

        }
    }
}
