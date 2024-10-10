namespace FlexyBox.core.Shared
{
    public record DeleteCommand : ICommand<int>
    {
        public int Id { get; set; }
    }
}
