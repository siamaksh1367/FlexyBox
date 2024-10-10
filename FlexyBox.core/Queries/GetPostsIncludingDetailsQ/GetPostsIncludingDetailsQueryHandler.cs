using FlexyBox.core.Shared;
using FlexyBox.dal.Generic;

namespace FlexyBox.core.Queries.GetPostsIncludingDetailsQ
{
    public sealed class GetPostsIncludingDetailsQueryHandler : IQueryHandler<GetPostsIncludingDetails, GetPostsIncludingDetailsResponse>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetPostsIncludingDetailsQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<GetPostsIncludingDetailsResponse> Handle(GetPostsIncludingDetails request, CancellationToken cancellationToken)
        {
            var result = await _unitOfWork.Posts.GetAllPostsIncludingDetailsAsync();

        }
    }

}
