using BlazorApp1.Data;
using BlazorApp1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Services
{
    public class ProjectService : IProjectService
    {
        protected readonly ApplicationDbContext _context;

        public ProjectService(ApplicationDbContext applicationDbContext)
        {
            this._context = applicationDbContext;
        }

        public IEnumerable<Project> GetAllProject()
        {
            var result = _context.Set<Project>().AsNoTracking();
            return result;
        }
    }
}
