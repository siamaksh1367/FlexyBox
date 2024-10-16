namespace FlexyBox.core.Queries.GetPosts
{
    public class GetPostResponse
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public int CommentsCount { get; set; }
        public List<string> Tags { get; set; }
        public string Category { get; set; }
        public byte[] Image { get; set; }
        public string UserName { get; set; }
    }

}
