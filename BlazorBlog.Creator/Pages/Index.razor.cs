using System.Net.Http;
using BlazorBlog.Lib.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.Web.Virtualization;
using Microsoft.JSInterop;

namespace BlazorBlog.Creator.Pages;

public partial class Index : ComponentBase
{
    ContentModel Content { get; set; } = new();
    IndexEntryModel IndexEntryModel { get; set; } = new();
    bool Generated { get; set; } = false;
    void GenerateContentlist()
    {
        IndexEntryModel = new(Content);
        Generated = true;
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
        List<ContentPart> tempParts = new(Content.ContentParts.Length + 1);
        tempParts.AddRange(Content.ContentParts);
        ContentPart part = new();
        part.Lines = 2;
        tempParts.Add(part);
        Content.ContentParts = tempParts.ToArray();
    }
}
