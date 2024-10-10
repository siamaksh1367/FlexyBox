using FlexyBox.core.Shared;

namespace FlexyBox.core.Commands.UpdateTag
{
    public sealed class UpdateTagCommandHandler : ICommandHandler<UpdateTagCommand, UpdateTagResponse>
    {
        public Task<UpdateTagResponse> Handle(UpdateTagCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }

}
