using FlexyBox.core.Shared;

namespace FlexyBox.core.Commands.CreatePost
{
    public sealed class CreatePostCommandHandler() : ICommandHandler<CreatePostCommand, CreatePostResponse>
    {
        public Task<CreatePostResponse> Handle(CreatePostCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
