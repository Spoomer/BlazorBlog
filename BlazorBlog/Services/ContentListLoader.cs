using BlazorBlog.Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorBlog.Services
{
    public class ContentListLoader : IContentListLoader
    {
        public HttpClient Http { get; set; }
        public ContentListLoader(HttpClient http)
        {
            Http = http;
        }
        public async Task<IndexEntryModel[]> GetContentListAsync()
        {
            return await Http.GetFromJsonAsync<IndexEntryModel[]>("ContentList.json") ?? Array.Empty<IndexEntryModel>();
        }
        //public async Task<bool> SaveContentList(IndexEntryModel[] ContentList)
        //{
        //    var response = await Http.PostAsJsonAsync<IndexEntryModel[]>("ContentList.json", ContentList);
        //    if (response.IsSuccessStatusCode)
        //    {
        //        return true;
        //    }
        //    else return false;

        //}
    }
}
