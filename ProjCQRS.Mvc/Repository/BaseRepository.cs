namespace ProjCQRS.Mvc.Repository
{
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Text;
    using System.Threading.Tasks;
    using ProjCQRS.Mvc.Repository.IRepository;
    using Newtonsoft.Json;

    public class BaseRepository<T> : IBaseRepository<T>
        where T : class
    {
        private readonly IHttpClientFactory clientFactory;

        public BaseRepository(IHttpClientFactory clientFactory)
        {
            this.clientFactory = clientFactory;
        }

        public async Task<T> CreateAsync(string url, T obj)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, url);
            if (obj != null)
            {
                request.Content = new StringContent(JsonConvert.SerializeObject(obj), Encoding.UTF8, "application/json");
            }
            else
            {
                return null;
            }

            var client = this.clientFactory.CreateClient();
            HttpResponseMessage response = await client.SendAsync(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<T>(jsonString);
            }

            return null;
        }

        public async Task<bool> DeleteAsync(string url, int Id)
        {
            var request = new HttpRequestMessage(HttpMethod.Delete, url +Id);
            var client = this.clientFactory.CreateClient();
            HttpResponseMessage response = await client.SendAsync(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<bool>(jsonString);
            }

            return false;
        }

        public async Task<ICollection<T>> GetAllAsync(string url, string filter = "")
        {
            var request = new HttpRequestMessage(HttpMethod.Get, url + filter);
            var client = this.clientFactory.CreateClient();
            HttpResponseMessage response = await client.SendAsync(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<ICollection<T>>(jsonString);
            }

            return null;
        }

        public async Task<T> GetAsync(string url, int Id)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, url + Id);
            var client = this.clientFactory.CreateClient();
            HttpResponseMessage response = await client.SendAsync(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<T>(jsonString);
            }

            return null;
        }

        public async Task<T> UpdateAsync(string url, T obj)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, url);
            if (obj != null)
            {
                request.Content = new StringContent(JsonConvert.SerializeObject(obj), Encoding.UTF8, "application/json");
            }
            else
            {
                return null;
            }

            var client = this.clientFactory.CreateClient();
            HttpResponseMessage response = await client.SendAsync(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<T>(jsonString);
            }

            return null;
        }
    }
}
