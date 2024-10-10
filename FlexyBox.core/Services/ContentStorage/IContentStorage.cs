namespace FlexyBox.core.Services.ContentStorage
{
    public interface IContentStorage
    {
        public Task AddFileWithIdAsync(byte[] content, Guid identifier);
        public Task<byte[]> GetFileByNameById(Guid identifier);
    }
}
