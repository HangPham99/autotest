using BlazorApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Services.Interface
{
    public interface IProjectDetailService
    {
        Task<IEnumerable<ProjectDetail>> GetAllProject();
        Task<IEnumerable<ProjectDetail>> GetAllFunctionByProjectId(int projectId);
        Task<ProjectDetail> AddFunction(ProjectDetail newFunction);
        Task<ProjectDetail> UpdateFunction(ProjectDetail updatedFunction);
        Task<ProjectDetail> GetProjectDetailById(int id);
        Task<bool> DeleteFunction(int funcId);
    }
}
