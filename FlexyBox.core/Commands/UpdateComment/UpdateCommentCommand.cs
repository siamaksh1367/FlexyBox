using FlexyBox.core.Shared;

namespace FlexyBox.core.Commands.UpdateComment
{
    public class UpdateCommentCommand : ICommand<UpdateCommentResponse>
    {
        public int CommentId { get; set; }
        public string UpdatedContent { get; set; }
        public UpdateCommentCommand(int commentId, string updatedContent)
        {
            CommentId = commentId;
            UpdatedContent = updatedContent;
        }
    }

}
