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
    public class ProjectDetailService : IProjectDetailService
    {
        protected readonly ApplicationDbContext _context;

        public ProjectDetailService(ApplicationDbContext applicationDbContext)
        {
            this._context = applicationDbContext;
        }

        public async Task<IEnumerable<ProjectDetail>> GetAllProject()
        {
            var result = await _context.ProjectDetails.ToListAsync();
            return result;
        }

        public async Task<ProjectDetail> GetProjectDetailById(int id)
        {
            var result = await _context.ProjectDetails.FirstOrDefaultAsync(t => t.Id == id);
            return result;
        }

        public async Task<ProjectDetail> AddFunction(ProjectDetail newFunction)
        {
            var existed = await _context.ProjectDetails.FirstOrDefaultAsync(t => t.FunctionName == newFunction.FunctionName);
            if (existed != null)
            {
                CheckData<ProjectDetail>.ItemStringExists("Function name", newFunction.FunctionName);
            }
            _context.ProjectDetails.Add(newFunction);
            await _context.SaveChangesAsync();
            return newFunction;
        }

        public async Task<IEnumerable<ProjectDetail>> GetAllFunctionByProjectId(int projectId)
        {
            var results = await _context.ProjectDetails.Where(t => t.ProjectId == projectId).ToListAsync();
            return results;
        }

        public async Task<ProjectDetail> UpdateFunction(ProjectDetail updatedFunction)
        {
            var existed = await _context.ProjectDetails.FirstOrDefaultAsync(t => t.Id == updatedFunction.Id);
            if (existed == null)
            {
                CheckData<ProjectDetail>.ItemNotFound(updatedFunction.Id);
            }

            existed.FunctionName = updatedFunction.FunctionName;
            existed.Milestones = updatedFunction.Milestones;
            existed.ModifiedDate = updatedFunction.ModifiedDate;

            await _context.SaveChangesAsync();
            return existed;
        }

        public async Task<bool> DeleteFunction(int funcId)
        {
            var existed = await _context.ProjectDetails.FirstOrDefaultAsync(t => t.Id == funcId);
            if (existed == null)
            {
                CheckData<ProjectDetail>.ItemNotFound(funcId);
            }

            _context.ProjectDetails.Remove(existed);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}