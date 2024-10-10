using FlexyBox.core.Shared;

namespace FlexyBox.core.Commands.CreateComment
{
    public class UpdatePostCommandHandler : ICommandHandler<UpdatePostCommand, UpdatePostResponse>
    {
        public Task<UpdatePostResponse> Handle(UpdatePostCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
