﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Models
{
    public class ProjectDetail : BaseModel
    {
        public string FunctionName { get; set; }

        public string Milestones { get; set; }

        [ForeignKey("Project")]
        public int ProjectId { get; set; }

        public virtual Project Project { get; set; }
        public virtual ICollection<FunctionTesting> FunctionTesting { get; set; }
    }
}
