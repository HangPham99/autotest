using BlazorApp1.Data;
using BlazorApp1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Services
{
    public class ProjectDetailService: IProjectDetailService
    {
        protected readonly ApplicationDbContext _context;

        public ProjectDetailService(ApplicationDbContext applicationDbContext)
        {
            this._context = applicationDbContext;
        }

        public IEnumerable<ProjectDetail> GetAllProject()
        {
            var result = _context.Set<ProjectDetail>().AsNoTracking();
            return result;
        }
    }
}
