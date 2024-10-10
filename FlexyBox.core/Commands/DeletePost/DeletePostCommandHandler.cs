using FlexyBox.core.Shared;

namespace FlexyBox.core.Commands.DeletePost
{
    public class DeletePostCommandHandler : ICommandHandler<DeletePostCommand, DeletePostResponse>
    {
        public Task<DeletePostResponse> Handle(DeletePostCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
