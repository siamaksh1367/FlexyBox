using FlexyBox.core.Queries.GetComments;
using FlexyBox.core.Shared;

namespace FlexyBox.core.Commands.CreateComment
{
    public class CreateCommentCommand : ICommand<GetCommentResponse>
    {
        public string Content { get; set; }
        public int PostId { get; set; }

        public CreateCommentCommand(string content, int postId)
        {
            Content = content;
            PostId = postId;
        }
    }
}
