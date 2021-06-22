using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Models
{
    public class Report : BaseModel
    {
        public string ReportName { get; set; }

        [ForeignKey("Project")]
        public int ProjectID { get; set; }

        public virtual Project Project { get; set; }

        [ForeignKey("Function")]
        public int FunctionID { get; set; }

        public virtual FunctionTesting Function { get; set; }

        public string TestcaseID { get; set; }
    }
}
