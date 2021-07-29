using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Models
{
    public class Project : BaseModel
    {
        [Required]
        public string ProjectName { get; set; }

        [Required]
        public string Link { get; set; }

        public virtual ICollection<ProjectDetail> ProjectDetails { get; set; }
    }
}
