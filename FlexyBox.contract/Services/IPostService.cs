﻿using FlexyBox.core.Commands.CreatePost;
using FlexyBox.core.Queries.GetPosts;

namespace FlexyBox.contract.Services
{
    public interface IPostService
    {
        HttpRequestBuilder CreatePost(CreatePostCommand createPostCommand);
        HttpRequestBuilder GetPosts(GetPostQuery getPostQuery);
    }

    public class PostService : IPostService
    {
        private const string EndPoint = "api/posts";
        private readonly HttpRequestBuilder _requestBuilder;

        public PostService(HttpRequestBuilder requestBuilder)
        {
            _requestBuilder = requestBuilder;
            _requestBuilder.AssignEndpoint(EndPoint);
        }
        public HttpRequestBuilder CreatePost(CreatePostCommand createPostCommand)
        {

            return _requestBuilder.SetMethod(HttpMethod.Post)
                 .SetJsonContent<CreatePostCommand>(createPostCommand);
        }


        public HttpRequestBuilder GetPosts(GetPostQuery getPostPostQuery)
        {
            _requestBuilder.AssignEndpoint(EndPoint);

            if (getPostPostQuery.TagIds is not null)
            {
                foreach (var TagId in getPostPostQuery.TagIds)
                {
                    _requestBuilder.AddQueryParameter("tagids", TagId.ToString());
                }
            }

            if (getPostPostQuery.CategoryId > 0)
            {
                _requestBuilder.AddQueryParameter("categoryid", getPostPostQuery.CategoryId.ToString());
            }

            if (!string.IsNullOrEmpty(getPostPostQuery.UserId))
            {
                _requestBuilder.AddQueryParameter("userid", getPostPostQuery.UserId);
            }

            _requestBuilder.AddQueryParameter("offset", getPostPostQuery.Offset.ToString());
            _requestBuilder.AddQueryParameter("limit", getPostPostQuery.Limit.ToString());

            return _requestBuilder.SetMethod(HttpMethod.Get);
        }
    }
}
