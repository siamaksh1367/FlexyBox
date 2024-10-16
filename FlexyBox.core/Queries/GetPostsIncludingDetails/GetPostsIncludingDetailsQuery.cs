using FlexyBox.core.Shared;

namespace FlexyBox.core.Queries.GetPostsIncludingDetails
{
    public class GetPostsIncludingDetailsQuery : IQuery<IEnumerable<GetPostsIncludingDetailsResponse>>
    {
        public List<int>? TagIds { get; set; }
        public int CategoryId { get; set; }
        public string? UserId { get; set; }
    }
}
