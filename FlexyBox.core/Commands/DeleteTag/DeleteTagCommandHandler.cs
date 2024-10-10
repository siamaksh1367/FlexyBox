using FlexyBox.core.Shared;

namespace FlexyBox.core.Commands.DeleteTag
{
    public sealed class DeleteTagCommandHandler() : ICommandHandler<DeleteTagCommand, DeleteTagResponse>
    {
        public Task<DeleteTagResponse> Handle(DeleteTagCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }

}
