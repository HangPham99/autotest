using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
namespace BlazorApp1.Models
{
    public class FunctionTesting : BaseModel
    {
        public string FileName { get; set; }

        [ForeignKey("ProjectDetail")]

        public virtual ProjectDetail ProjectDetail { get; set; }
        public virtual ICollection<TestScreen> TestScreens { get; set; }
    }
} 

