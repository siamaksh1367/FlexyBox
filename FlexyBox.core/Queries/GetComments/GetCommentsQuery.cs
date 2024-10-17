using FlexyBox.core.Shared;

namespace FlexyBox.core.Queries.GetComments
{

    public class GetCommentsQuery : IQuery<IEnumerable<GetCommentResponse>>
    {
        public int PostId { get; set; }
    }
}
