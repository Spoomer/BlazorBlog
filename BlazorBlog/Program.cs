using BlazorBlog.Lib;
using BlazorBlog.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace BlazorBlog;

public class Program
{
    public static async Task Main(string[] args)
    {
        var builder = WebAssemblyHostBuilder.CreateDefault(args);
        builder.RootComponents.Add<App>("#app");

        builder.Services.AddSingleton(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
        builder.Services.AddSingleton<IContentListLoader, ContentListLoader>();
        builder.Services.AddSingleton<IContentLoader, ContentLoader>();
        builder.Services.AddSingleton<MarkdownService>();
        
        BlogSettings blogSettings = new();
        builder.Configuration.GetSection(nameof(BlogSettings)).Bind(blogSettings);
        builder.Services.AddSingleton(blogSettings);
        
        await builder.Build().RunAsync();
    }
}
