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
        private readonly IWebHostEnvironment Environment;
        public DownloadModel(IFunctionTesting functionTesting, IWebHostEnvironment webHostEnvironment)
        {
            this._service = functionTesting;
            this.Environment = webHostEnvironment;
        }
        
        public async Task<IActionResult> OnGet(string fileId)
        {
            if (fileId.Contains("report_"))
            {
                var filePath = Path.Combine(this.Environment.ContentRootPath, "Development", "add", "report", fileId);
                byte[] fileBytes = System.IO.File.ReadAllBytes(filePath);
                return File(fileBytes, "application/force-download", fileId);
            }
            else
            {
                var downloadFile = await _service.FindById(Convert.ToInt32(fileId));
                byte[] fileBytes = System.IO.File.ReadAllBytes(downloadFile.FilePath);
                return File(fileBytes, "application/force-download", downloadFile.FileName);
            }
        }
    }
}
