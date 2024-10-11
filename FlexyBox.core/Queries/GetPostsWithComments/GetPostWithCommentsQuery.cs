using FlexyBox.core.Shared;

namespace FlexyBox.core.Queries.GetPostsWithComments
{
    public class GetPostWithCommentsQuery : IQuery<GetPostWithCommentsResponse>
    {
        public int PostId { get; set; }

        public GetPostWithCommentsQuery(int postId)
        {
            PostId = postId;
        }
    }


}
