using FlexyBox.core.Shared;

namespace FlexyBox.core.Queries.GetPostWithCategories
{
    public class GetPostWithCategoriesQuery : IQuery<GetPostWithCategoriesResponse>
    {
        public int CategoryId { get; set; }

        public GetPostWithCategoriesQuery(int categoryId)
        {
            CategoryId = categoryId;
        }
    }


}
