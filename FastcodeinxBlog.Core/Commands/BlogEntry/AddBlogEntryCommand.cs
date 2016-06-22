using System.Collections.Generic;
using FastcodeinxBlog.Core.Entities;

namespace FastcodeinxBlog.Core.Commands
{
    public class AddBlogEntryCommand
    {
        public BlogEntry Entity { get; set; }

        public IEnumerable<string> Tags { get; set; }
    }
}
