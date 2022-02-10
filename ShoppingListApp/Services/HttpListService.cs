using MetaP.ShoppingList.Model;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace MetaP.ShoppingList.Services
{
    public class HttpListService : IListService
    {
        private readonly HttpClient Http;

        public HttpListService(HttpClient http)
        {
            Http = http;
#if DEBUG
            http.BaseAddress = new Uri("https://localhost:44354/api/list/");
#else
            http.BaseAddress = new Uri("https://metap-shopping-list-api.azurewebsites.net/api/list/");
#endif
        }

        public async Task<List> Get(string name)
        {
            List? list = await Http.GetFromJsonAsync<List>(name);
            return list!;
        }

        public async Task Save(List list)
        {
            throw new NotImplementedException();
        }
    }
}
