namespace BlazorBlog.Lib.Models;

public class IndexEntryModel
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string[] Tags { get; set; } = Array.Empty<string>();
    public string Title { get; set; } = "";
    public string ContentSnippet { get; set; } = "";
    public IndexEntryModel()
    {

    }
    public IndexEntryModel(ContentModel contentModel)
    {
        Id = contentModel.Id;
        Tags = contentModel.Tags;
        Title = contentModel.Title;
        if (contentModel.ContentParts.Length > 0)
        {
            ContentSnippet = contentModel.ContentParts[0] + "...";
        }

    }
}
