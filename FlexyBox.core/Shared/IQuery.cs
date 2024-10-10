using MediatR;

namespace FlexyBox.core.Shared
{
    public interface IQuery<out TResponse> : IRequest<TResponse>
    {
    }
}
