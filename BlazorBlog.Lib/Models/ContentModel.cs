using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorBlog.Lib.Models
{
    public class ContentModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Title { get; set; } = "";
        public string[] Tags { get; set; } = Array.Empty<string>();
        public ContentPart[] ContentParts { get; set; } = Array.Empty<ContentPart>();
    }
}
