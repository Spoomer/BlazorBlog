using BlazorBlog.Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorBlog.Services
{
    public class ContentLoader : IContentLoader
    {
        public HttpClient Http { get; set; }
        public ContentLoader(HttpClient http)
        {
            Http = http;
        }
        public async Task<ContentModel> GetContentAsync(Guid id)
        {
            return await Http.GetFromJsonAsync<ContentModel>($"content/{id}.json");
        }
        //public async Task<bool> SaveContent(ContentModel content)
        //{
        //    var response = await Http.PostAsJsonAsync<ContentModel>($"content/{content.Id}.json", content);
        //    if (response.IsSuccessStatusCode)
        //    {
        //        return true;
        //    }
        //    else return false;

        //}
    }
}
