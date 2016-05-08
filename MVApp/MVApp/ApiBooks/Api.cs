using MVApp.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MVApp.ApiBooks
{
    public static class Api
    {
        public static async Task<List<Book>> GetBooksAsync()
        {
            using (var client = new HttpClient())
            {
                var json = await client.GetStringAsync("http://mvalivros.azurewebsites.net/api/livros");
                var books = JsonConvert.DeserializeObject<List<Book>>(json);

                return books;
            }
        }
    }
}
