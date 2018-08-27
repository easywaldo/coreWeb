using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyCoreWeb
{
    public class TodoItem
    {
        [BindNever]
        public string Name { get; set; }

        [Range(30, 1000)]
        public string Description { get; set; }
    }
}
