using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BlazorApp1.Services.Interface;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BlazorApp1.Pages
{
    public class DownloadModel : PageModel
    {
        private readonly IFunctionTesting _service;
        private readonly IWebHostEnvironment _env;

        public DownloadModel(IFunctionTesting functionTesting, IWebHostEnvironment env)
        {
            this._service = functionTesting;
            this._env = env;
        }

        public async Task<IActionResult> OnGet(int fileId)
        {
            var downloadFile = await _service.FindById(fileId);

            byte[] fileBytes = System.IO.File.ReadAllBytes(_env.WebRootPath  + downloadFile.FilePath);
            return File(fileBytes, "application/force-download", downloadFile.FileName + ".csv");
        }
    }
}
