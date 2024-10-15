using AutoMapper;
using FlexyBox.core.Services.ContentStorage;
using FlexyBox.core.Shared;
using FlexyBox.dal.Generic;
using FlexyBox.dal.Models;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace FlexyBox.core.Commands.CreatePost
{
    public sealed class CreatePostCommandHandler : ICommandHandler<CreatePostCommand, CreatePostResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IContentStorage _contentStorage;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CreatePostCommandHandler(IUnitOfWork unitOfWork, IContentStorage contentStorage, IMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            _unitOfWork = unitOfWork;
            _contentStorage = contentStorage;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<CreatePostResponse> Handle(CreatePostCommand request, CancellationToken cancellationToken)
        {
            var post = _mapper.Map<Post>(request);

            post.Tags = new List<Tag>();
            foreach (var tagId in request.Tags)
            {

                var tag = await _unitOfWork.Tags.SingleOrDefaultAsync(x => x.Id == tagId);
                post.Tags.Add(tag);
            }

            var category = await _unitOfWork.Categories.SingleOrDefaultAsync(x => x.Id == request.CategoryId);
            _unitOfWork.Categories.Attach(category);

            post.Category = category;

            var userIdClaim = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier);
            if (userIdClaim != null)
            {
                post.UserId = userIdClaim.Value;
            }
            else
            {
                throw new UnauthorizedAccessException("User is not authenticated.");
            }
            await _contentStorage.AddImageByIdAsync(request.Image, post.ContentKey);
            await _contentStorage.AddStringByIdAsync(request.Content, post.ContentKey);

            var result = await _unitOfWork.Posts.AddAsync(post);

            await _unitOfWork.CompleteAsync();

            var returedPost = _mapper.Map<CreatePostResponse>(result);
            returedPost.Content = request.Content;

            return returedPost;


        }
    }
}
