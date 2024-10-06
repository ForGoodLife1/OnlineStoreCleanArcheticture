using Microsoft.AspNetCore.Http;

namespace OnlineStore.Service.Abstracts
{
    public interface IFileService
    {
        public Task<string> UploadImage(string Location, IFormFile file);
    }
}
