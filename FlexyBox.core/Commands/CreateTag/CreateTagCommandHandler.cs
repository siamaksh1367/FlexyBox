using FlexyBox.core.Shared;

namespace FlexyBox.core.Commands.CreateTag
{
    public sealed class CreateTagCommandHandler : ICommandHandler<CreateTagCommand, CreateTagResponse>
    {
        public Task<CreateTagResponse> Handle(CreateTagCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }

}
