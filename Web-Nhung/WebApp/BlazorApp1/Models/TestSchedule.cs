using BlazorApp1.Commons;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Models
{
    public class TestSchedule
    {
        [Key]
        public int Id { get; set; }
        public int FunctionTestingId { get; set; }
        public string FilePath { get; set; }
        public string FunctionName { get; set; }
        public string ProjectName { get; set; }
        public string NotifyEmail { get; set; }
        public TimeSpan RunTime { get; set; }
        public ScheduleRunType RunType { get; set; }

    }
}
