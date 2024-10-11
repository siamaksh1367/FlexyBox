using FlexyBox.core.Shared;

namespace FlexyBox.core.Commands.DeleteTag
{
    public sealed class DeleteTagCommandHandler : ICommandHandler<DeleteTagCommand, int>
    {
        public Task<int> Handle(DeleteTagCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }

}
