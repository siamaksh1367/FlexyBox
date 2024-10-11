using FlexyBox.core.Shared;

namespace FlexyBox.core.Commands.DeleteComment
{
    public class DeleteCommentCommandHandler : ICommandHandler<DeleteCommentCommand, int>
    {
        public Task<int> Handle(DeleteCommentCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
