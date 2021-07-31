using BlazorBlog.Lib.Models;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorBlog.Services
{
    public interface IContentListLoader
    {
        HttpClient Http { get; set; }

        Task<IndexEntryModel[]> GetContentListAsync();
        //Task<bool> SaveContentList(IndexEntryModel[] ContentList);
    }
}