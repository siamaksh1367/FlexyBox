using FlexyBox.core.Shared;

namespace FlexyBox.core.Queries.GetTagsForPost
{
    public sealed class GetTagsForPostQueryHandler() : IQueryHandler<GetTagsForPostQuery, GetTagsForPostResponse>
    {
        public Task<GetTagsForPostResponse> Handle(GetTagsForPostQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
