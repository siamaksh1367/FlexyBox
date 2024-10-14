using AutoMapper;
using FlexyBox.core.Services.ContentStorage;
using FlexyBox.core.Shared;
using FlexyBox.dal.Generic;
using FlexyBox.dal.Models;

namespace FlexyBox.core.Commands.CreatePost
{
    public sealed class CreatePostCommandHandler : ICommandHandler<CreatePostCommand, CreatePostResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IContentStorage _contentStorage;
        private readonly IMapper _mapper;

        public CreatePostCommandHandler(IUnitOfWork unitOfWork, IContentStorage contentStorage, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _contentStorage = contentStorage;
            _mapper = mapper;
        }
        public async Task<CreatePostResponse> Handle(CreatePostCommand request, CancellationToken cancellationToken)
        {
            var post = _mapper.Map<Post>(request);

            var tags = await _unitOfWork.Tags.GetAllAsync();

            foreach (var tag in tags)
            {
                post.Tags.Add(tag);
            }

            await _contentStorage.AddFileWithIdAsync(request.Content, post.ContentKey);

            var result = await _unitOfWork.Posts.AddAsync(post);

            await _unitOfWork.CompleteAsync();

            var returedPost = _mapper.Map<CreatePostResponse>(result);
            returedPost.Content = request.Content;

            return returedPost;


        }
    }
}
