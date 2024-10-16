using FlexyBox.core.Queries.GetTags;
using FlexyBox.core.Shared;

namespace FlexyBox.core.Commands.CreateTag
{
    public class CreateTagCommand : ICommand<GetTagResponse>
    {
        public string Name { get; set; }
        public CreateTagCommand(string name)
        {
            Name = name;
        }
    }
}
