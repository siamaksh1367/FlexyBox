using FlexyBox.core.Shared;
using FlexyBox.dal.Generic;

namespace FlexyBox.core.Queries.GetPostsIncludingDetails
{
    public sealed class GetPostsIncludingDetailsQueryHandler : IQueryHandler<GetPostsIncludingDetailsQuery, GetPostsIncludingDetailsResponse>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetPostsIncludingDetailsQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<GetPostsIncludingDetailsResponse> Handle(GetPostsIncludingDetailsQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
