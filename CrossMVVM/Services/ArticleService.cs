using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Common.RestClient;
using CrossMVVM.Models;

namespace CrossMVVM.Services
{
    public class ArticleService
    {
        public readonly RestClient RestClient = RestClient.Default;
        public async Task<List<Article>> GetArticlesAsync()
        {
            await Task.Delay(3);
            return await RestClient.Request<List<Article>>("http://192.168.22.12:9999/articles", HttpMethod.Get);
        }
    }
}
