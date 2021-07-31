using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorBlog.Lib.Models
{
    public class IndexEntryModel
    {
        public Guid Id { get; set; }
        public string[] Tags { get; set; }
        public string Title { get; set; }
        public string ContentSnippet { get; set; }

        public IndexEntryModel(ContentModel contentModel)
        {
            Id = contentModel.Id;
            Tags = contentModel.Tags;
            Title = contentModel.Title;
            ContentSnippet = contentModel.Content[..30] + "...";
        }
    }
}
