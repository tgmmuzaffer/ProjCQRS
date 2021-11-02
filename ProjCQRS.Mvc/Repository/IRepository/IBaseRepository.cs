namespace ProjCQRS.Mvc.Repository.IRepository
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IBaseRepository<T> where T : class
    {
        Task<T> GetAsync(string url, int Id);
        Task<ICollection<T>> GetAllAsync(string url, string filter = "");
        Task<T> CreateAsync(string url, T obj);
        Task<T> UpdateAsync(string url, T obj);
        Task<bool> DeleteAsync(string url, int Id);
    }
}
