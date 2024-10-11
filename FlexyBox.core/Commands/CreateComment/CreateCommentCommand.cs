using FlexyBox.core.Shared;

namespace FlexyBox.core.Commands.CreateComment
{
    public class CreateCommentCommand : ICommand<CreateCommentResponse>
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
