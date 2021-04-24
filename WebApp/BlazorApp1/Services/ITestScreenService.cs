using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorApp1.Models;

namespace BlazorApp1.Services
{
    public interface ITestScreenService
    {
        public IEnumerable<TestScreen> GetAllProject();
    }
}
