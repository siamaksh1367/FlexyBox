using FlexyBox.core.Shared;

namespace FlexyBox.core.Commands.DeleteComment
{
    public class DeleteCommentCommandHandler : ICommandHandler<DeleteCommentCommand, DeleteCommentResponse>
    {
        public Task<DeleteCommentResponse> Handle(DeleteCommentCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
