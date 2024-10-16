using AutoMapper;
using FlexyBox.core.Services.ContentStorage;
using FlexyBox.core.Shared;
using FlexyBox.dal.Generic;

namespace FlexyBox.core.Queries.GetPost
{
    public sealed class GetPostQueryHandler : IQueryHandler<GetPostQuery, GetPostResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IContentStorage _contentStorage;

        public GetPostQueryHandler(IUnitOfWork unitOfWork, IMapper mapper, IContentStorage contentStorage)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _contentStorage = contentStorage;
        }

        public async Task<GetPostResponse> Handle(GetPostQuery request, CancellationToken cancellationToken)
        {
            var post = await _unitOfWork.Posts.GetPostWithDetails(request.Id);
            var response = _mapper.Map<GetPostResponse>(post);
            response.Content = await _contentStorage.GetFileByIdAsync(response.ContentKey);
            response.Image = await _contentStorage.GetImageByIdAsync(response.ContentKey);
            return response;
        }
    }
}
