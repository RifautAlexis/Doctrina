using System.Threading.Tasks;

namespace api_server.Handlers
{
    public interface IHandler<TRequest, TResult>
    {
        Task<TResult> Handle(TRequest request);
    }
}
