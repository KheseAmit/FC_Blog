using System.Threading.Tasks;
namespace FastcodeinxBlog.Core.Commands
{
    public interface ICommandHandler<TCommand>
    {
        Task HandleAsync(TCommand command);
    }
}
