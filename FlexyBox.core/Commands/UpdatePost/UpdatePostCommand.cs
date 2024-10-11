using FlexyBox.core.Shared;

namespace FlexyBox.core.Commands.CreateComment
{
    public class UpdatePostCommand : ICommand<UpdatePostResponse>
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public byte[] Content { get; set; }
        public List<string> Tags { get; set; }
        public int CategoryId { get; set; }

        public UpdatePostCommand(int postId, string title, byte[] content, List<string> tags, int categoryId)
        {
            PostId = postId;
            Title = title;
            Content = content;
            Tags = tags;
            CategoryId = categoryId;
        }
    }

}
