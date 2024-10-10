using FlexyBox.core.Shared;

namespace FlexyBox.core.Queries.GetCommentsForPost
{
    public sealed class GetCommentsForPostQueryHandler : IQueryHandler<GetCommentsForPostQuery, GetCommentsForPostResponse>
    {
        public Task<GetCommentsForPostResponse> Handle(GetCommentsForPostQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
