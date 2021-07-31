using BlazorBlog.Lib.Models;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorBlog.Services
{
    public interface IContentLoader
    {
        HttpClient Http { get; set; }

        Task<ContentModel> GetContentAsync(Guid id);
    }
}