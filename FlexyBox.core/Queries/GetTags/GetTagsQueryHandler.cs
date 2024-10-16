using AutoMapper;
using FlexyBox.core.Shared;
using FlexyBox.dal.Generic;

namespace FlexyBox.core.Queries.GetTags
{
    public class GetTagsQueryHandler : IQueryHandler<GetTagsQuery, IEnumerable<GetTagResponse>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetTagsQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<IEnumerable<GetTagResponse>> Handle(GetTagsQuery request, CancellationToken cancellationToken)
        {
            var tags = await _unitOfWork.Tags.GetAllAsync();
            return _mapper.Map<IEnumerable<GetTagResponse>>(tags);
        }
    }
}
