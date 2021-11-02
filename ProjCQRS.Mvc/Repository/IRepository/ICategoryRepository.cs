namespace ProjCQRS.Mvc.Repository.IRepository
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using ProjCQRS.Mvc.Models;

    public interface ICategoryRepository: IBaseRepository<Category>
    {
    //    public Task<ICollection<Category>> GetCategoriesCqrs(string url);
    //    public Task<Category> GetCategoryCqrs(string url, int Id);
    //    public Task<Category> AddCategoryCqrs(string url, Category entity);
    //    public Task<Category> UpdateCategoryCqrs(string url, Category entity);
    //    public Task<bool> DeleteCategoryCqrs(string url, int Id);
    }
}

