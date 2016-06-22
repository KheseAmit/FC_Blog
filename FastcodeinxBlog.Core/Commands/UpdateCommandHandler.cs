using System.Threading.Tasks;
using FastcodeinxBlog.Core.Database;

namespace FastcodeinxBlog.Core.Commands
{
    public class UpdateCommandHandler<T> : ICommandHandler<UpdateCommand<T>> where T : FastcodeinxBlog.Core.Entities.EntityBase
    {
        private readonly IRepository repository;

        public UpdateCommandHandler(IRepository repository)
        {
            this.repository = repository;
        }

        public async Task HandleAsync(UpdateCommand<T> command)
        {
            var entry = this.repository.Entry(command.Entity);

            if (entry.State == System.Data.Entity.EntityState.Detached)
            {
                this.repository.Set<T>().Attach(command.Entity);
            }

            entry.State = System.Data.Entity.EntityState.Modified;

            await this.repository.SaveChangesAsync();
        }
    }
}
