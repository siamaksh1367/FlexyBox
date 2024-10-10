using FlexyBox.core.Shared;

namespace FlexyBox.core.Commands.UpdateComment
{
    public class UpdateCommentCommandHandler : ICommandHandler<UpdateCommentCommand, UpdateCommentResponse>
    {
        public Task<UpdateCommentResponse> Handle(UpdateCommentCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }

}
