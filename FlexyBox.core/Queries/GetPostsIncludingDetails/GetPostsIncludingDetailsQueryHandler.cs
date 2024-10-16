using AutoMapper;
using FlexyBox.core.Services.ContentStorage;
using FlexyBox.core.Shared;
using FlexyBox.dal.Generic;

namespace FlexyBox.core.Queries.GetPostsIncludingDetails
{
    public sealed class GetPostsIncludingDetailsQueryHandler : IQueryHandler<GetPostsIncludingDetailsQuery, IEnumerable<GetPostsIncludingDetailsResponse>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IContentStorage _contentStorage;

        public GetPostsIncludingDetailsQueryHandler(IUnitOfWork unitOfWork, IMapper mapper, IContentStorage contentStorage)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _contentStorage = contentStorage;
        }

        public async Task<IEnumerable<GetPostsIncludingDetailsResponse>> Handle(GetPostsIncludingDetailsQuery request, CancellationToken cancellationToken)
        {
            var posts = await _unitOfWork.Posts.GetAllPostsIncludingDetailsAsync();
            var responses = new List<GetPostsIncludingDetailsResponse>();
            foreach (var post in posts)
            {
                var response = _mapper.Map<GetPostsIncludingDetailsResponse>(post);
                response.Summary = await _contentStorage.GetFileByIdAsync(post.ContentKey);
                response.Image = await _contentStorage.GetImageByIdAsync(post.ContentKey);
                responses.Add(response);
            }
            return responses;
        }
    }
}
