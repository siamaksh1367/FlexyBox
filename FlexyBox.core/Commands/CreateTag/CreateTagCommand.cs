using FlexyBox.core.Shared;

namespace FlexyBox.core.Commands.CreateTag
{
    public class CreateTagCommand : ICommand<CreateTagResponse>
    {
        public string Name { get; set; }
        public CreateTagCommand(string name)
        {
            Name = name;
        }
    }
}
