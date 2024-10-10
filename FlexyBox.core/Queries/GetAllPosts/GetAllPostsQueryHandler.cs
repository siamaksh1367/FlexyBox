using FlexyBox.core.Shared;

namespace FlexyBox.core.Queries.GetAllPosts
{
    public sealed class GetAllPostsQueryHandler() : IQueryHandler<GetAllPostsQuery, GetAllPostsResponse>
    {
        public Task<GetAllPostsResponse> Handle(GetAllPostsQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }

}
