using FlexyBox.core.Shared;

namespace FlexyBox.core.Queries.GetPostWithCategories
{
    public sealed class GetPostWithCategoriesQueryHandler : IQueryHandler<GetPostWithCategoriesQuery, GetPostWithCategoriesResponse>
    {
        public Task<GetPostWithCategoriesResponse> Handle(GetPostWithCategoriesQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }

}
