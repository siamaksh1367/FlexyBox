using Azure.Storage.Blobs;
using FlexyBox.common;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Text;
using YourNamespace;

namespace FlexyBox.core.Services.ContentStorage
{
    public class ContentBlobStorage : IContentStorage
    {
        private const string BlobContainerName = "content";
        private readonly IOptions<StorageConnectionString> _option;
        private readonly ILogger<ContentBlobStorage> _logger;

        public ContentBlobStorage(IOptions<StorageConnectionString> option, ILogger<ContentBlobStorage> logger)
        {
            _option = option;
            _logger = logger;
        }
        public async Task AddFileWithIdAsync(string content, Guid identifier)
        {
            BlobServiceClient blobServiceClient = new BlobServiceClient(_option.Value.ConnectionString);
            BlobContainerClient containerClient = blobServiceClient.GetBlobContainerClient(BlobContainerName);

            await containerClient.CreateIfNotExistsAsync();

            BlobClient blobClient = containerClient.GetBlobClient(identifier.ToString());

            using (MemoryStream stream = new MemoryStream(content.ToByteArray()))
            {
                await blobClient.UploadAsync(stream, overwrite: true);
            }

            _logger.LogInformation($"File uploaded to {blobClient.Uri}");
        }

        public async Task<string> GetFileByNameById(Guid identifier)
        {
            BlobServiceClient blobServiceClient = new BlobServiceClient(_option.Value.ConnectionString);

            BlobContainerClient containerClient = blobServiceClient.GetBlobContainerClient(BlobContainerName);

            BlobClient blobClient = containerClient.GetBlobClient(identifier.ToString());

            using (MemoryStream memoryStream = new MemoryStream())
            {
                await blobClient.DownloadToAsync(memoryStream);

                memoryStream.Position = 0;

                using (StreamReader reader = new StreamReader(memoryStream, Encoding.UTF8))
                {
                    return await reader.ReadToEndAsync();
                }
            }
        }
    }
}
