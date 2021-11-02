namespace ProjCQRS.Mvc.Repository.IRepository
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using ProjCQRS.Mvc.Models;

    public interface IProductRepository: IBaseRepository<Product>
    {
        Task<List<Product>> GetAllWithRangeAsync(string url, int start, int finish);

    }
}
