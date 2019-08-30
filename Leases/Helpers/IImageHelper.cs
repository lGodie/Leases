using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Leases.Helpers
{
    public interface IImageHelper
    {
        Task<string> UploadImageAsync(IFormFile imageFile);
    }
}