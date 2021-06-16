using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
namespace BlazorApp1.Models
{
    public class TestScreen: BaseModel
    {
        public string TestName { get; set; }
        public string Target { get; set; }
        public string Value { get; set; }
        public string Command { get; set; }
        public string Result { get; set; }
        public virtual FunctionTesting FunctionTesting { get; set; }
    }
}
