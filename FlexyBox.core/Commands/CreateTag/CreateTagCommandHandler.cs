using FlexyBox.core.Shared;
using FlexyBox.dal.Generic;
using FlexyBox.dal.Models;

namespace FlexyBox.core.Commands.CreateTag
{
    public sealed class CreateTagCommandHandler : ICommandHandler<CreateTagCommand, CreateTagResponse>
    {
        private readonly IUnitOfWork _unitOfWork;

        public CreateTagCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<CreateTagResponse> Handle(CreateTagCommand request, CancellationToken cancellationToken)
        {
            var addedTag = await _unitOfWork.Tags.AddAsync(new Tag() { Name = request.Name });
            await _unitOfWork.CompleteAsync();
            var tag = await _unitOfWork.Tags.SingleOrDefaultAsync(x => x.Id == addedTag.Id);
            return new CreateTagResponse() { Id = tag.Id, Name = tag.Name };

        }
    }
}
