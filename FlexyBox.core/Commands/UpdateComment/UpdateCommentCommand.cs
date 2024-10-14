using FlexyBox.core.Shared;

namespace FlexyBox.core.Commands.UpdateComment
{
    public class UpdateCommentCommand : ICommand<UpdateCommentResponse>
    {
        public int Id { get; set; }
        public string UpdatedContent { get; set; }
        public UpdateCommentCommand(int id, string updatedContent)
        {
            Id = id;
            UpdatedContent = updatedContent;
        }
    }

}
