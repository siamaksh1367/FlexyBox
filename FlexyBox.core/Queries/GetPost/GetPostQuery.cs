using FlexyBox.core.Shared;

namespace FlexyBox.core.Queries.GetPost
{
    public class GetPostQuery : IQuery<GetPostResponse>
    {
        public int Id { get; set; }
    }
}
