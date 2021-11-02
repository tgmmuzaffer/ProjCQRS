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

    public class CategoryRepoCqrs : ICategoryRepoCqrs
    {
        private readonly ProjCQRSDbContext _dbContext;
        public CategoryRepoCqrs(ProjCQRSDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Category> AddAsync(Category entity)
        {
            await _dbContext.Categories.AddAsync(entity);
            _dbContext.SaveChanges();
            return entity;
        }

        public async Task<bool> DeleteAsync(int Id)
        {
            var entity = await _dbContext.Categories.Where(a => a.Id == Id).FirstOrDefaultAsync();
            _dbContext.Categories.Remove(entity);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<Category> Get(Expression<Func<Category, bool>> filter = null)
        {
            return filter == null ?
              await _dbContext.Categories.Include(p => p.Products).FirstOrDefaultAsync()
               : await _dbContext.Categories.Include(p => p.Products).Where(filter).FirstOrDefaultAsync();
        }

        public async Task<ICollection<Category>> GetListAsync(Expression<Func<Category, bool>> filter = null)
        {
            return filter == null ?
                await _dbContext.Categories.Include(p => p.Products).ToListAsync()
                : await _dbContext.Categories.Include(p => p.Products).Where(filter).ToListAsync();
        }

        public async Task<Category> UpdateAsync(Category entity)
        {
            return await Task.Run(() =>
            {
                _dbContext.Categories.Update(entity);
                _dbContext.SaveChanges();
                return entity;
            });

        }
    }
}
