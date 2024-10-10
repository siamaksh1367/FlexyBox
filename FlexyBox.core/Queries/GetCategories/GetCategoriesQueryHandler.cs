using FlexyBox.core.Shared;

namespace FlexyBox.core.Queries.GetCategories
{
    public sealed class GetCategoriesQueryHandler() : IQueryHandler<GetCategoriesQuery, GetCategoriesResponse>
    {
        public Task<GetCategoriesResponse> Handle(GetCategoriesQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }

}
