using FlexyBox.core.Queries.SearchTag;
using FlexyBox.core.Shared;

namespace FlexyBox.core.Commands.CreateTag
{
    public class CreateTagCommand : ICommand<GetTagsResponse>
    {
        public string Name { get; set; }
        public CreateTagCommand(string name)
        {
            Name = name;
        }
    }
}
