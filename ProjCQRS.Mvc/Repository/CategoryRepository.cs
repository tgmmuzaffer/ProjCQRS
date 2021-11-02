namespace ProjCQRS.Mvc.Repository
{
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Text;
    using System.Threading.Tasks;
    using ProjCQRS.Mvc.Models;
    using ProjCQRS.Mvc.Repository.IRepository;
    using Newtonsoft.Json;

    public class CategoryRepository:BaseRepository<Category>, ICategoryRepository
    {
        private readonly IHttpClientFactory _clientFactory;
        public CategoryRepository(IHttpClientFactory clientFactory) : base(clientFactory)
        {
            _clientFactory = clientFactory;
        }

        //public async Task<Category> AddCategoryCqrs(string url, Category entity)
        //{
        //    var request = new HttpRequestMessage(HttpMethod.Post, url);
        //    if (entity != null)
        //    {
        //        request.Content = new StringContent(JsonConvert.SerializeObject(entity), Encoding.UTF8, "application/json");
        //    }
        //    else
        //    {
        //        return null;
        //    }

        //    var client =  _clientFactory.CreateClient();
        //    HttpResponseMessage response = await client.SendAsync(request);
        //    if (response.StatusCode == System.Net.HttpStatusCode.OK)
        //    {
        //        var jsonString = await response.Content.ReadAsStringAsync();
        //        return JsonConvert.DeserializeObject<Category>(jsonString);
        //    }

        //    return null;
        //}

        //public async Task<bool> DeleteCategoryCqrs(string url, int Id)
        //{
        //    var request = new HttpRequestMessage(HttpMethod.Delete, url + Id);
        //    var client = _clientFactory.CreateClient();
        //    HttpResponseMessage response = await client.SendAsync(request);
        //    if (response.StatusCode == System.Net.HttpStatusCode.OK)
        //    {
        //        var jsonString = await response.Content.ReadAsStringAsync();
        //        return JsonConvert.DeserializeObject<bool>(jsonString);
        //    }

        //    return false;
        //}

        //public async Task<ICollection<Category>> GetCategoriesCqrs(string url)
        //{
        //    var request = new HttpRequestMessage(HttpMethod.Get, url);
        //    var client = _clientFactory.CreateClient();
        //    HttpResponseMessage response = await client.SendAsync(request);
        //    if (response.StatusCode == System.Net.HttpStatusCode.OK)
        //    {
        //        var jsonString = await response.Content.ReadAsStringAsync();
        //        return JsonConvert.DeserializeObject<ICollection<Category>>(jsonString);
        //    }

        //    return null;
        //}

        //public async Task<Category> GetCategoryCqrs(string url, int Id)
        //{
        //    var request = new HttpRequestMessage(HttpMethod.Get, url+Id);
        //    var client = _clientFactory.CreateClient();
        //    HttpResponseMessage response = await client.SendAsync(request);
        //    if (response.StatusCode == System.Net.HttpStatusCode.OK)
        //    {
        //        var jsonString = await response.Content.ReadAsStringAsync();
        //        return JsonConvert.DeserializeObject<Category>(jsonString);
        //    }

        //    return null;
        //}

        //public async Task<Category> UpdateCategoryCqrs(string url, Category entity)
        //{
        //    var request = new HttpRequestMessage(HttpMethod.Post, url);
        //    if (entity != null)
        //    {
        //        request.Content = new StringContent(JsonConvert.SerializeObject(entity), Encoding.UTF8, "application/json");
        //    }
        //    else
        //    {
        //        return null;
        //    }

        //    var client = _clientFactory.CreateClient();
        //    HttpResponseMessage response = await client.SendAsync(request);
        //    if (response.StatusCode == System.Net.HttpStatusCode.OK)
        //    {
        //        var jsonString = await response.Content.ReadAsStringAsync();
        //        return JsonConvert.DeserializeObject<Category>(jsonString);
        //    }

        //    return null;
        //}
    }
}
