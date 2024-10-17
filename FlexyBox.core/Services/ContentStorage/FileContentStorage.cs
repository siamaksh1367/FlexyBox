namespace FlexyBox.core.Services.ContentStorage
{
    public class FileContentStorage : IContentStorage
    {
        private readonly string _storagePath;

        public FileContentStorage()
        {
            _storagePath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).FullName, "volume", "content");
            if (!Directory.Exists(_storagePath))
            {
                Directory.CreateDirectory(_storagePath);
            }
        }

        public async Task AddImageByIdAsync(byte[] imageData, Guid identifier)
        {
            var filePath = Path.Combine(_storagePath, $"{identifier}.png");
            await File.WriteAllBytesAsync(filePath, imageData);
        }

        public async Task AddStringByIdAsync(string content, Guid identifier)
        {
            var filePath = Path.Combine(_storagePath, $"{identifier}.txt");
            await File.WriteAllTextAsync(filePath, content);
        }

        public async Task<string> GetFileByIdAsync(Guid identifier)
        {
            var filePath = Path.Combine(_storagePath, $"{identifier}.txt");
            return await File.ReadAllTextAsync(filePath);
        }

        public async Task<byte[]> GetImageByIdAsync(Guid identifier)
        {
            var filePath = Path.Combine(_storagePath, $"{identifier}.png");
            return File.Exists(filePath) ? await File.ReadAllBytesAsync(filePath) : null;
        }
    }
}
