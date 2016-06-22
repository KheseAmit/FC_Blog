using System.Threading.Tasks;
using FastcodeinxBlog.Core.Database;

namespace FastcodeinxBlog.Core.Commands
{
    public class AddCommandHandler<T> : ICommandHandler<AddCommand<T>> where T : FastcodeinxBlog.Core.Entities.EntityBase
    {
        private readonly IRepository repository;

        public AddCommandHandler(IRepository repository)
        {
            this.repository = repository;
        }

        public async Task HandleAsync(AddCommand<T> command)
        {
            this.repository.Set<T>().Add(command.Entity);
            await this.repository.SaveChangesAsync();
        }
    }
}
