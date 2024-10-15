using FlexyBox.core.Queries.GetTags;
using FlexyBox.core.Shared;
using FlexyBox.dal.Generic;
using FlexyBox.dal.Models;

namespace FlexyBox.core.Commands.CreateTag
{
    public sealed class CreateTagCommandHandler : ICommandHandler<CreateTagCommand, GetTagsResponse>
    {
        private readonly IUnitOfWork _unitOfWork;

        public CreateTagCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<GetTagsResponse> Handle(CreateTagCommand request, CancellationToken cancellationToken)
        {
            var addedTag = await _unitOfWork.Tags.AddAsync(new Tag() { Name = request.Name });
            await _unitOfWork.CompleteAsync();
            var tag = await _unitOfWork.Tags.SingleOrDefaultAsync(x => x.Id == addedTag.Id);
            return new GetTagsResponse() { Id = tag.Id, Name = tag.Name };

        }
    }
}
