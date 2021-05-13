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
    public class FunctionTestingService: IFunctionTesting
    {
        protected readonly ApplicationDbContext _context;

        public FunctionTestingService (ApplicationDbContext applicationDbContext)
        {
            this._context = applicationDbContext;
        }

        public async Task<IEnumerable<FunctionTesting>> GetAllFunctionByProjectDetailId(int prjDetailId)
        {
            var results = await _context.FunctionTestings.Where(t => t.ProjectDetailId == prjDetailId).ToListAsync();
            return results;
        }

        public IEnumerable<FunctionTesting> GetAllProject()
        {
            var result = _context.Set<FunctionTesting>().AsNoTracking();
            return result;
        }



    }
}
