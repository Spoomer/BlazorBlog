using BlazorBlog.Services;
using BlazorBlog.Lib;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace BlazorBlog;

public class Program
{
    public static async Task Main(string[] args)
    {
        var builder = WebAssemblyHostBuilder.CreateDefault(args);
        builder.RootComponents.Add<App>("#app");

        builder.Services.AddSingleton(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
        builder.Services.AddSingleton<IContentListLoader,ContentListLoader>();
        builder.Services.AddSingleton<IContentLoader, ContentLoader>();
        builder.Services.AddSingleton<MarkdownService>();

        await builder.Build().RunAsync();
    }
}
