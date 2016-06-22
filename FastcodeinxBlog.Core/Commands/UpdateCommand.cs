namespace FastcodeinxBlog.Core.Commands
{
    public class UpdateCommand<T> where T : FastcodeinxBlog.Core.Entities.EntityBase
    {
        public T Entity { get; set; }
    }
}
