using AutoMapper;
using FlexyBox.core.Shared;
using FlexyBox.dal.Generic;

namespace FlexyBox.core.Queries.SearchTag
{
    public class GetAllTagQueryHandler : IQueryHandler<GetAllTagsQuery, IEnumerable<GetAllTagsResponse>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllTagQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<IEnumerable<GetAllTagsResponse>> Handle(GetAllTagsQuery request, CancellationToken cancellationToken)
        {
            var tags = await _unitOfWork.Tags.GetAllAsync();
            return _mapper.Map<IEnumerable<GetAllTagsResponse>>(tags);
        }
    }
}
