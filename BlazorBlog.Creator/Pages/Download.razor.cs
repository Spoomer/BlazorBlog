using Microsoft.AspNetCore.Components;
using System.Text.Json;
using Blazor.DownloadFileFast.Interfaces;

namespace BlazorBlog.Creator.Pages;

public partial class Download<T>
{
    [Inject] public IBlazorDownloadFileService? BlazorDownloadFileService { get; set; }
    [Parameter] public T? ToDownload { get; set; }
    [Parameter] public string Filename { get; set; } = "";
    async Task DownloadAsync()
    {
        byte[] file = Array.Empty<byte>();
        // Generate a text file
        if (ToDownload is not null)
        {
            file = System.Text.Encoding.UTF8.GetBytes(JsonSerializer.Serialize<T>(ToDownload));
        }
        if(BlazorDownloadFileService is not null)
            await BlazorDownloadFileService.DownloadFileAsync(Filename, file);
    }
}
