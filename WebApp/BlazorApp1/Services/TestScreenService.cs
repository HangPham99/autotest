using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorApp1.Data;
using BlazorApp1.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Services
{
    public class TestScreenService: ITestScreenService
    {
        protected readonly ApplicationDbContext _context;
        public TestScreenService(ApplicationDbContext applicationDbContext)
        {
            this._context = applicationDbContext;
        }

        public IEnumerable<TestScreen> GetAllProject()
        {
            var result = _context.Set<TestScreen>().AsNoTracking();
            return result;
        }

    }
}
