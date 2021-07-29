using BlazorApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Services.Interface
{
    public interface IFunctionTesting
    {
        public IEnumerable<FunctionTesting> GetAllProject();
        public Task<IEnumerable<FunctionTesting>> GetAllFunctionByProjectDetailId(int prjDetailId);
        Task<FunctionTesting> AddFunction(FunctionTesting newFunc);
        Task<FunctionTesting> FindById(int id);
        Task Delete(int id);
    }
}
