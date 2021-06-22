using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Commons
{
    public static class CheckData<T>
    {
        public static NotFoundObjectResult ItemNotFound(int Id)
        {
            return new NotFoundObjectResult($"ID of {typeof(T).Name} not found : {Id}");
        }

        public static BadRequestObjectResult ItemIntExists(string field, int Id)
        {
            return new BadRequestObjectResult($"{field} of {typeof(T).Name} already exists: {Id}");
        }

        public static BadRequestObjectResult ItemStringExists(string field, string value)
        {
            return new BadRequestObjectResult($"{field} of {typeof(T).Name} already exists: {value}");
        }
    }
}
