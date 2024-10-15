using FlexyBox.core.Commands.CreatePost;

namespace FlexyBox.contract.Services
{
    public interface IPostService
    {
        HttpRequestBuilder CreatePost(CreatePostCommand createPostCommand);
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
    }
}
