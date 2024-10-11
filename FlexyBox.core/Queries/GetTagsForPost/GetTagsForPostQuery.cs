using FlexyBox.core.Shared;

namespace FlexyBox.core.Queries.GetTagsForPost
{
    public class GetTagsForPostQuery : IQuery<GetTagsForPostResponse>
    {
        public int PostId { get; set; }

        public GetTagsForPostQuery(int postId)
        {
            PostId = postId;
        }
    }

}
