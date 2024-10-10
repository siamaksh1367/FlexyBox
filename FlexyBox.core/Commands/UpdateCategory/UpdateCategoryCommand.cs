using FlexyBox.core.Shared;

namespace FlexyBox.core.Commands.UpdateCategory
{
    public record UpdateCategoryCommand(int Id, string Name, string Description) : ICommand<UpdateCategoryResponse>;

}
