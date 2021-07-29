using BlazorApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Services.Interface
{
    public interface IProjectService
    {
        Task<IEnumerable<Project>> GetAllProject();
        Task<Project> AddProject(Project newProject);
        Task<Project> UpdateProject(Project updatedProject);
        Task<Project> GetProjectById(int id);
        Task<bool> DeleteProject(int prjId);
    }
}
