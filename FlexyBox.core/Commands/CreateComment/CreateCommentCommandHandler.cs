using FlexyBox.core.Shared;

namespace FlexyBox.core.Commands.CreateComment
{
    public class CreateCommentCommandHandler : ICommandHandler<CreateCommentCommand, CreateCommentResponse>
    {
        public Task<CreateCommentResponse> Handle(CreateCommentCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }



}
