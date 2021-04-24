using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Models
{
    public class ProjectDetail : BaseModel
    {
        public string FunctionName { get; set; }
        public string Milestones { get; set; }
    }
}
