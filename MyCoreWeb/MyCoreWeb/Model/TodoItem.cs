using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCoreWeb
{
    public class TodoItem
    {
        [BindNever]
        public string Name { get; set; }
    }
}
