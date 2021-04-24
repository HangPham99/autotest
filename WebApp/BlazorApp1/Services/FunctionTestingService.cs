using BlazorApp1.Data;
using BlazorApp1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Services
{
    public class FunctionTestingService: IFunctionTesting
    {
        protected readonly ApplicationDbContext _context;

        public FunctionTestingService (ApplicationDbContext applicationDbContext)
        {
            this._context = applicationDbContext;
        }

        public IEnumerable<FunctionTesting> GetAllProject()
        {
            var result = _context.Set<FunctionTesting>().AsNoTracking();
            return result;
        }

    }
}
