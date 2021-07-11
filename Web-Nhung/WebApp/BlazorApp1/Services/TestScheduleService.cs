using BlazorApp1.Data;
using BlazorApp1.Models;
using BlazorApp1.Services.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Services
{
    public class TestScheduleService : ITestScheduleService
    {
        protected readonly ApplicationDbContext _context;

        public TestScheduleService(ApplicationDbContext applicationDbContext)
        {
            this._context = applicationDbContext;
        }
        
        public async Task<TestSchedule> GetTestScheduleByFuncId(int funcId)
        {
            return await _context.TestSchedules.FirstOrDefaultAsync(t => t.FunctionTestingId == funcId);
        }

        public async Task<TestSchedule> UpsertTestSchedule(TestSchedule testSchedule, bool IsOn)
        {
            if (!IsOn && testSchedule != null)
            {
                var deleteItem = await _context.TestSchedules.FirstOrDefaultAsync(t => t.Id == testSchedule.Id && t.FunctionTestingId == testSchedule.FunctionTestingId);
                _context.TestSchedules.Remove(deleteItem);
                await _context.SaveChangesAsync();
            }
            else
            {
                if (testSchedule != null)
                {
                    var existedItem = await _context.TestSchedules.FirstOrDefaultAsync(t => t.Id == testSchedule.Id);
                    if (existedItem == null)
                    {
                        await _context.TestSchedules.AddAsync(testSchedule);
                        await _context.SaveChangesAsync();
                    }
                    else
                    {
                        existedItem.RunTime = testSchedule.RunTime;
                        existedItem.RunType = testSchedule.RunType;
                        await _context.SaveChangesAsync();
                    }
                }
            }
            return testSchedule;
        }
    }
}
