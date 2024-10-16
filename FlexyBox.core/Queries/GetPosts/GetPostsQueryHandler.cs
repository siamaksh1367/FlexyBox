using AutoMapper;
using FlexyBox.common;
using FlexyBox.core.Queries.GetPost;
using FlexyBox.core.Services.ContentStorage;
using FlexyBox.core.Shared;
using FlexyBox.dal.Generic;

namespace FlexyBox.core.Queries.GetPosts
{
    public sealed class GetPostsQueryHandler : IQueryHandler<GetPostsQuery, WithCount<GetPostResponse>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IContentStorage _contentStorage;

        public GetPostsQueryHandler(IUnitOfWork unitOfWork, IMapper mapper, IContentStorage contentStorage)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _contentStorage = contentStorage;
        }

        public async Task<WithCount<GetPostResponse>> Handle(GetPostsQuery request, CancellationToken cancellationToken)
        {
            var posts = await _unitOfWork.Posts.GetPosts(request.TagIds, request.UserId, request.CategoryId, request.Offset, request.Limit);
            var responses = new WithCount<GetPostResponse>();
            responses.Response = new List<GetPostResponse>();
            foreach (var post in posts.Response)
            {
                var response = _mapper.Map<GetPostResponse>(post);
                response.Content = await _contentStorage.GetFileByIdAsync(post.ContentKey);
                response.Image = await _contentStorage.GetImageByIdAsync(post.ContentKey);
                responses.Response.Add(response);
            }
            responses.Count = posts.Count;
            return responses;
        }
    }
}
