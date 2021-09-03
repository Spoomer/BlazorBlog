using System;
using BlazorBlog.Lib.Enums;

namespace BlazorBlog.Lib.Models
{
    public class ContentPart
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Content { get; set; } = "";
        public ContentType Type { get; set; } = ContentType.Empty;
    }
}