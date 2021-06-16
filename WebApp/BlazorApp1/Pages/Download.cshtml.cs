using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorApp1.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BlazorApp1.Pages
{
    public class DownloadModel : PageModel
    {
        private readonly IFunctionTesting _service;
        public DownloadModel(IFunctionTesting functionTesting)
        {
            this._service = functionTesting;
        }

        public async Task<IActionResult> OnGet(int fileId)
        {
            var downloadFile = await _service.FindById(fileId);
            byte[] fileBytes = System.IO.File.ReadAllBytes(downloadFile.FilePath);

            return File(fileBytes, "application/force-download", downloadFile.FileName);
        }
    }
}
