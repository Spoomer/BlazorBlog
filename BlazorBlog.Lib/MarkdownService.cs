namespace BlazorBlog.Lib;

public class MarkdownService
{
    public MarkdownPipeline Pipeline { get; set; }

    public MarkdownService()
    {
        var builder = new MarkdownPipelineBuilder();
        Pipeline = builder
                    .UseBootstrap()
                    .Build();
    }
}
