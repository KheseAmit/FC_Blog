namespace FastcodeinxBlog.Core.Commands
{
    public class AddCommand<T> where T : FastcodeinxBlog.Core.Entities.EntityBase
    {
        public T Entity { get; set; }
    }
}
