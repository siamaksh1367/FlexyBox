using FlexyBox.core.Shared;

namespace FlexyBox.core.Queries.GetPostsWithComments
{
    public sealed class GetPostWithCommentsQueryHandler() : IQueryHandler<GetPostWithCommentsQuery, GetPostWithCommentsResponse>
    {
        public Task<GetPostWithCommentsResponse> Handle(GetPostWithCommentsQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }

}
