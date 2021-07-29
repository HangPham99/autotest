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
        public string FilePath { get; set; }
        public string FileStatus { get; set; }
        public int ProjectDetailId { get; set; }
    }
} 