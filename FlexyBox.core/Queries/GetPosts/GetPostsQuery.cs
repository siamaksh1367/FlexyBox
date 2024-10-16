using FlexyBox.common;
using FlexyBox.core.Queries.GetPost;
using FlexyBox.core.Shared;

namespace FlexyBox.core.Queries.GetPosts
{
    public class GetPostsQuery : IQuery<WithCount<GetPostResponse>>
    {
        public List<int>? TagIds { get; set; }
        public int CategoryId { get; set; }
        public string? UserId { get; set; }
        public int Offset { get; set; }
        public int Limit { get; set; }
    }
}
