using MediatR;

namespace FlexyBox.core.Shared
{
    public interface ICommand<out TResponse> : IRequest<TResponse>
    {
    }
}
