using FlexyBox.core.Commands.CreatePost;
using FlexyBox.core.Queries.GetPostsIncludingDetails;

namespace FlexyBox.contract.Services
{
    public interface IPostService
    {
        HttpRequestBuilder CreatePost(CreatePostCommand createPostCommand);
        HttpRequestBuilder GetPostWithAllDetails(int postId);
        HttpRequestBuilder GetPostsIncludingDetails();
        HttpRequestBuilder GetPostsIncludingDetailsWithCriteria(GetPostsIncludingDetailsQuery getPostsIncludingDetailsQuery);
    }

    public class PostService : IPostService
    {
        private readonly HttpRequestBuilder _requestBuilder;

        public PostService(HttpRequestBuilder requestBuilder)
        {
            _requestBuilder = requestBuilder;
            _requestBuilder.AssignEndpoint("api/posts");
        }
        public HttpRequestBuilder CreatePost(CreatePostCommand createPostCommand)
        {

            return _requestBuilder.SetMethod(HttpMethod.Post)
                 .SetJsonContent<CreatePostCommand>(createPostCommand);
        }

        public HttpRequestBuilder GetPostWithAllDetails(int postId)
        {
            return _requestBuilder.SetMethod(HttpMethod.Post)
                 .AppendEndpoint($"/{postId}");
        }

        public HttpRequestBuilder GetPostsIncludingDetails()
        {
            return _requestBuilder.SetMethod(HttpMethod.Get);
        }

        public HttpRequestBuilder GetPostsIncludingDetailsWithCriteria(GetPostsIncludingDetailsQuery getPostsIncludingDetailsQuery)
        {
            if (getPostsIncludingDetailsQuery.TagIds is not null)
            {
                foreach (var TagId in getPostsIncludingDetailsQuery.TagIds)
                    _requestBuilder.AddQueryParameter("tagid", TagId.ToString());
            }
            if (getPostsIncludingDetailsQuery.CategoryId > 0)
            {
                _requestBuilder.AddQueryParameter("categoryid", getPostsIncludingDetailsQuery.CategoryId.ToString());
            }
            if (string.IsNullOrEmpty(getPostsIncludingDetailsQuery.UserId))
            {
                _requestBuilder.AddQueryParameter("userid", getPostsIncludingDetailsQuery.UserId);
            }

            return _requestBuilder.SetMethod(HttpMethod.Get);
        }
    }
}
