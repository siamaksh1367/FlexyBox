using FlexyBox.core.Shared;

namespace FlexyBox.core.Commands.UpdateTag
{
    public class UpdateTagCommand : ICommand<UpdateTagResponse>
    {
        public int TagId { get; set; }
        public string TagName { get; set; }

        public UpdateTagCommand(int tagId, string tagName)
        {
            TagId = tagId;
            TagName = tagName;
        }

    }

}
