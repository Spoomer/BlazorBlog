using BlazorBlog.Lib.Models;
using Microsoft.AspNetCore.Components.Web;

namespace BlazorBlog.Creator.Pages;

public partial class Index
{
    ContentModel _content = new();
    IndexEntryModel _indexEntryModel = new();
    bool _generated = false;
    void GenerateContentlist()
    {
        _indexEntryModel = new(_content);
        _generated = true;
    }

    void AddLine(KeyboardEventArgs e, ContentPart part)
    {
        if (e.Code == "Enter" || e.Code == "NumpadEnter")
        {
            part.Lines++;
        }
    }

    void AddPart()
    {
        List<ContentPart> tempParts = new(_content.ContentParts.Length + 1);
        tempParts.AddRange(_content.ContentParts);
        ContentPart part = new();
        part.Lines = 2;
        tempParts.Add(part);
        _content.ContentParts = tempParts.ToArray();
    }
}
