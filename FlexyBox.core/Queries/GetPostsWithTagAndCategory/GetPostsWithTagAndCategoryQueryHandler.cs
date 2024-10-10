using FlexyBox.core.Shared;

namespace FlexyBox.core.Queries.GetPostsWithTagAndCategory
{
    public sealed class GetPostsWithTagAndCategoryQueryHandler() : IQueryHandler<GetPostsWithTagAndCategoryQuery, GetPostsWithTagAndCategoryResponse>
    {
        public Task<GetPostsWithTagAndCategoryResponse> Handle(GetPostsWithTagAndCategoryQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }

}
