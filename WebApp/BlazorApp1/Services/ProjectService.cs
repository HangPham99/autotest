using BlazorApp1.Commons;
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
    public class ProjectService : IProjectService
    {
        protected readonly ApplicationDbContext _context;

        public ProjectService(ApplicationDbContext applicationDbContext)
        {
            this._context = applicationDbContext;
        }

        public async Task<IEnumerable<Project>> GetAllProject()
        {
            var result = await _context.Projects.ToListAsync();
            return result;
        }

        public async Task<Project> AddProject(Project newProject)
        {
            var existed = await _context.Projects.FirstOrDefaultAsync(t => t.ProjectName == newProject.ProjectName);
            if(existed != null)
            {
                CheckData<Project>.ItemStringExists("Project name", newProject.ProjectName);
            }
            _context.Projects.Add(newProject);
            await _context.SaveChangesAsync();
            return newProject;
        }
    }
}
