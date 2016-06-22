using System.Linq;
using System.Threading.Tasks;
using FastcodeinxBlog.Core.Database;
using System.Data.Entity;

namespace FastcodeinxBlog.Core.Commands
{
    public class DeleteCommandHandler<T> : ICommandHandler<DeleteCommand<T>> where T : FastcodeinxBlog.Core.Entities.EntityBase
    {
        private readonly IRepository repository;

        public DeleteCommandHandler(IRepository repository)
        {
            this.repository = repository;
        }

        public async Task HandleAsync(DeleteCommand<T> command)
        {
            var entity = await this.repository.Set<T>().SingleOrDefaultAsync(e => e.Id == command.Id);

            if (entity != null)
            {
                this.repository.Set<T>().Remove(entity);
                await this.repository.SaveChangesAsync();
            }
        }
    }
}
