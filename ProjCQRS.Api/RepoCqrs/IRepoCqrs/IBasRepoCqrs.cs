namespace ProjCQRS.Api.RepoCqrs.IRepoCqrs
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using System.Threading.Tasks;

    public interface IBasRepoCqrs<T> where T :class, new()
    {
        Task<ICollection<T>> GetListAsync(Expression<Func<T, bool>> filter = null);

        Task<T> Get(Expression<Func<T, bool>> filter = null);

        Task<T> AddAsync(T entity);

        Task<T> UpdateAsync(T entity);

        Task<bool> DeleteAsync(int Id);
    }
}
