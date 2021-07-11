using BlazorApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Services.Interface
{
    public interface ITestScheduleService
    {
        public Task<TestSchedule> GetTestScheduleByFuncId(int funcId);
        public Task<TestSchedule> UpsertTestSchedule(TestSchedule testSchedule, bool isOff);
    }
}
