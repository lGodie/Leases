using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using Leases.Data.Entities;

namespace Leases.Models
{
    public class PropertyDto : Property
    {
        public int OwnerId { get; set; }

        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [Display(Name = "Property Type")]
        [Range(1, int.MaxValue, ErrorMessage = "You must select a property type.")]
        public int PropertyTypeId { get; set; }

        public IEnumerable<SelectListItem> PropertyTypes { get; set; }
    }
}