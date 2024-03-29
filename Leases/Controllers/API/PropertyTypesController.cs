﻿using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Leases.Data;
using Leases.Data.Entities;

namespace Leases.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropertyTypesController : ControllerBase
    {
        private readonly DataContext _context;

        public PropertyTypesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<PropertyType> GetPropertyTypes()
        {
            return _context.PropertyTypes.OrderBy(pt => pt.Name);
        }
    }
}