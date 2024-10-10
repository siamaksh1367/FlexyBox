using FlexyBox.core.Shared;
using FlexyBox.dal.Generic;

namespace FlexyBox.core.Commands.DeleteCategory
{
    public sealed class DeleteCategoryCommandHandler : ICommandHandler<DeleteCategoryCommand, int>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteCategoryCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<int> Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
        {
            var category = await _unitOfWork.Categories.GetAsync(request.Id);
            _unitOfWork.Categories.Remove(category);
            await _unitOfWork.CompleteAsync();
            return request.Id;
        }
    }

}
