using FlexyBox.core.Commands.CreateTag;

namespace FlexyBox.contract.Services
{
    public interface ITagService
    {
        HttpRequestBuilder CreateTag(CreateTagCommand createTagCommand);
        HttpRequestBuilder GetAllTags();
    }

    public class TagService : ITagService
    {
        private readonly HttpRequestBuilder _requestBuilder;

        public TagService(HttpRequestBuilder requestBuilder)
        {
            _requestBuilder = requestBuilder;
            _requestBuilder.AssignEndpoint("api/tags");
        }

        public HttpRequestBuilder CreateTag(CreateTagCommand createTagCommand)
        {

            return _requestBuilder.SetMethod(HttpMethod.Post)
                 .SetJsonContent<CreateTagCommand>(createTagCommand);
        }

        public HttpRequestBuilder GetAllTags()
        {
            return _requestBuilder.SetMethod(HttpMethod.Get);
        }
    }

}
