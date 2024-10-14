namespace FlexyBox.core.Services.ContentStorage
{
    public interface IContentStorage
    {
        public Task AddFileWithIdAsync(string content, Guid identifier);
        public Task<string> GetFileByNameById(Guid identifier);
    }
}
