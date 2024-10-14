using FlexyBox.core.Shared;

namespace FlexyBox.core.Commands.CreateComment
{
    public class UpdatePostCommand : ICommand<UpdatePostResponse>
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public List<string> Tags { get; set; }
        public int CategoryId { get; set; }

        public UpdatePostCommand(int id, string title, string content, List<string> tags, int categoryId)
        {
            Id = id;
            Title = title;
            Content = content;
            Tags = tags;
            CategoryId = categoryId;
        }
    }

}
