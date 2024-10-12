using FlexyBox.core.Commands.CreateCategory;
using FlexyBox.core.Commands.DeleteCategory;
using FlexyBox.core.Commands.UpdateCategory;
using FlexyBox.core.Queries.GetCategories;

namespace FlexyBox.contract.Services
{
    public interface ICategoryService
    {
        HttpRequestBuilder CreateCategory(CreateCategoryCommand createCategoryCommand);
        HttpRequestBuilder UpdateCategory(UpdateCategoryCommand updateCategoryCommand);
    }

    public class CategoryService : ICategoryService
    {
        private readonly HttpRequestBuilder _requestBuilder;

        public CategoryService(HttpRequestBuilder requestBuilder)
        {
            _requestBuilder = requestBuilder;
            _requestBuilder.AssignEndpoint("api/categories");
        }
        public HttpRequestBuilder CreateCategory(CreateCategoryCommand createCategoryCommand)
        {
            return _requestBuilder.SetMethod(HttpMethod.Post).SetJsonContent<CreateCategoryCommand>(createCategoryCommand);
        }
        public HttpRequestBuilder UpdateCategory(UpdateCategoryCommand updateCategoryCommand)
        {
            return _requestBuilder.SetMethod(HttpMethod.Put).SetJsonContent<UpdateCategoryCommand>(updateCategoryCommand).AppendEndpoint(updateCategoryCommand.Id.ToString());
        }
        public HttpRequestBuilder DeleteCategory(DeleteCategoryCommand deleteCategoryCommand)
        {
            return _requestBuilder.SetMethod(HttpMethod.Delete).AppendEndpoint(deleteCategoryCommand.Id.ToString());
        }
        public HttpRequestBuilder GetCategories(GetCategoriesQuery getCategoriesQuery)
        {
            return _requestBuilder.SetMethod(HttpMethod.Get).SetJsonContent<GetCategoriesQuery>(getCategoriesQuery);
        }
    }

}
