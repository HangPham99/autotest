using BlazorApp1.Commons;
using BlazorApp1.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace BlazorApp1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilesaveController : ControllerBase
    {
        // POST: HomeController/Create
        public static IHubContext<ChatHub> SChatHub { get; set; }
        private readonly IWebHostEnvironment env;
        private readonly ILogger<FilesaveController> logger;
        public IHubContext<ChatHub> _chathub { get; }
        public ApplicationDbContext _mycontext { get; }
        private static Random random = new Random();

        public FilesaveController(IWebHostEnvironment env,
                                  ILogger<FilesaveController> logger,
                                  IHubContext<ChatHub> chatHubContext,
                                  ApplicationDbContext mycontext
                                 )
        {
            this.env = env;
            this.logger = logger;
            this._chathub = chatHubContext;
            FilesaveController.SChatHub = chatHubContext;
            this._mycontext = mycontext;
        }

        private string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        [HttpPost]
        public async Task<ActionResult<IList<UploadResult>>> PostFile([FromForm] string userid,
                                                                      [FromForm] IEnumerable<IFormFile> files)
        {
            var maxAllowedFiles = 3;
            long maxFileSize = 1024 * 1024 * 15;
            var filesProcessed = 0;
            var resourcePath = new Uri($"{Request.Scheme}://{Request.Host}/");
            List<UploadResult> uploadResults = new List<UploadResult>();

            foreach (var file in files)
            {
                var uploadResult = new UploadResult();
                string trustedFileNameForFileStorage;
                var untrustedFileName = file.FileName;
                uploadResult.FileName = untrustedFileName;
                var trustedFileNameForDisplay =
                    WebUtility.HtmlEncode(untrustedFileName);


                if (filesProcessed < maxAllowedFiles)
                {
                    if (file.Length == 0)
                    {
                        logger.LogInformation("{FileName} length is 0 (Err: 1)",
                            trustedFileNameForDisplay);
                        uploadResult.ErrorCode = 1;
                    }
                    else if (file.Length > maxFileSize)
                    {
                        logger.LogInformation("{FileName} of {Length} bytes is " +
                            "larger than the limit of {Limit} bytes (Err: 2)",
                            trustedFileNameForDisplay, file.Length, maxFileSize);
                        uploadResult.ErrorCode = 2;
                    }
                    else
                    {
                        try
                        {
                            trustedFileNameForFileStorage = RandomString(10) ;

                            var path = Path.Combine(env.ContentRootPath,
                                env.EnvironmentName, "unsafe_uploads",
                                trustedFileNameForFileStorage + ".csv");

                            var javaex = Path.Combine(env.ContentRootPath,
                                env.EnvironmentName, "add",
                                "test1.jar");

                            var reports = Path.Combine(env.ContentRootPath,
                               env.EnvironmentName, "add",
                               "report","report_"+trustedFileNameForFileStorage+".html");

                            var logs = Path.Combine(env.ContentRootPath,
                             env.EnvironmentName, "add",
                             "logs", "logs_" + trustedFileNameForFileStorage);

                            await using FileStream fs = new (path, FileMode.Create);
                            await file.CopyToAsync(fs);

                            logger.LogInformation("{FileName} saved at {Path}",
                                trustedFileNameForDisplay, path);

                            AsyncTask async = new AsyncTask();
                            string text = "-jar "
                               + String.Format(@"""{0}""", javaex)
                               + " "
                               + String.Format(@"""{0}""", path)
                               + " "
                               + String.Format(@"""{0}""", reports)
                               + " "
                               + String.Format(@"""{0}""", logs)
                            ;
                            async.command = text;
                            async.csv = path;
                            async.report = reports;
                            async.logs = logs;
                            async.id = userid;
                            QueueAsyncTask.myQueue1.Enqueue(async);
                            uploadResult.Uploaded = true;
                            uploadResult.StoredFileName = trustedFileNameForFileStorage;
                           
                        }
                        catch (Exception ex)
                        {
                            logger.LogError("{FileName} error on upload (Err: 3): {Message}",
                                trustedFileNameForDisplay, ex.Message);
                            uploadResult.ErrorCode = 3;
                        }
                    }

                    filesProcessed++;
                }
                else
                {
                    logger.LogInformation("{FileName} not uploaded because the " +
                        "request exceeded the allowed {Count} of files (Err: 4)",
                        trustedFileNameForDisplay, maxAllowedFiles);
                    uploadResult.ErrorCode = 4;
                }

                uploadResults.Add(uploadResult);
            }

            return new CreatedResult(resourcePath, uploadResults);
        }

        [HttpPost("runtest")]
        public async Task<string> RunTest([FromForm] string userid,
                                  [FromForm] string testcaseFilePath)
        {
            var guid = Guid.NewGuid();
            var envPath = Path.Combine(this.env.ContentRootPath, "Development", "add");
            var testRunCommandFormat = @"-jar ""{0}"" ""{1}"" ""{2}"" ""{3}""";

            var javaex = Path.Combine(envPath,
                                      "test1.jar");

            var reports = Path.Combine(envPath,
                                       "report", 
                                       "report_" + guid.ToString() + ".html");

            var logs = Path.Combine(envPath,
                                    "logs", 
                                    "logs_" + guid.ToString());

            AsyncTask async = new AsyncTask()
            {
                command = String.Format(testRunCommandFormat, javaex, testcaseFilePath, reports, logs),
                csv = testcaseFilePath,
                report = reports,
                logs = logs,
                id = userid
            };

            QueueAsyncTask.myQueue1.Enqueue(async);
            return reports;
        }
    }
}
