using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Models
{
    public class Project : BaseModel
    {
        public string ProjectName { get; set; }

        public string Link { get; set; }

        public virtual ICollection<ProjectDetail> ProjectDetails { get; set; }
    }
}
