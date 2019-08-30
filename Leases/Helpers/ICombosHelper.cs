    
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Leases.Helpers
{
     public interface ICombosHelper
    {
        IEnumerable<SelectListItem> GetComboPropertyTypes();

        IEnumerable<SelectListItem> GetComboLessees();
    }
}