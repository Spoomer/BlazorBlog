using BlazorBlog.Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Text.Json;

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
            JsonSerializerOptions option = new();
            option.DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull;
            return await Http.GetFromJsonAsync<ContentModel>($"content/{id}.json",options:option) ?? new();
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
