using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using Leases.Data.Entities;

namespace Leases.Models
{
    public class PropertyImageDto : PropertyImage
    {
        [Display(Name = "Image")]
        public IFormFile ImageFile { get; set; }
    }
}