using System;

namespace FastcodeinxBlog.Core.Commands
{
    public class DeleteCommand<T> where T : FastcodeinxBlog.Core.Entities.EntityBase
    {
        public Guid Id { get; set; }
    }
}
