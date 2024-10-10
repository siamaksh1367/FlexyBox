using FlexyBox.core.Shared;

namespace FlexyBox.core.Queries.GetCategories
{
    public record GetCategoriesQuery() : IQuery<IEnumerable<GetCategoriesResponse>>
    {
    }

}
