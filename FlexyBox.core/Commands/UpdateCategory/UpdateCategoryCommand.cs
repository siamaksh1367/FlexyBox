using FlexyBox.core.Shared;

namespace FlexyBox.core.Commands.UpdateCategory
{
    public class UpdateCategoryCommand : ICommand<UpdateCategoryResponse>
    {
        public int Id { get; }
        public string Name { get; }
        public string Description { get; }

        // Constructor to initialize properties
        public UpdateCategoryCommand(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }
    }

}
