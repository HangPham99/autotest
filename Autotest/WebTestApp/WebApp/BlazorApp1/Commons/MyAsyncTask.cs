using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.AspNetCore.SignalR;
using MimeKit;
using MimeKit.Text;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Mime;
using System.Threading.Tasks;

namespace BlazorApp1.Commons
{
    public class MyAsyncTask 
    {
        public static IHubContext<ChatHub> _chathub { get; set; }
        public MyAsyncTask(IHubContext<ChatHub> chatHubContext)
        {
            MyAsyncTask._chathub = chatHubContext;
        }
        Action myTask = () =>
        {
            while(true)
            {
                if (QueueAsyncTask.myQueue1.Count > 0)
                {
                    QueueAsyncTask.selectTask = QueueAsyncTask.myQueue1.Dequeue();
                    var startTime = DateTime.UtcNow;
                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                    
                    startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                    startInfo.FileName = "java.exe";
                    startInfo.Arguments = QueueAsyncTask.selectTask.command;
                    process.StartInfo = startInfo;
                    process.Start();
                    ChatHub.SendMessangeToUser(QueueAsyncTask.selectTask.id, "Automation test session is started.");
                    LogFileMonitor monitor = null;
                    monitor = new LogFileMonitor(QueueAsyncTask.selectTask.logs+".log", "\r\n");
                    monitor.OnLine += (s, e) =>
                    {
                        ChatHub.SendMessangeToUser(QueueAsyncTask.selectTask.id, e.Line);
                    };
                    monitor.Start();
                    while (!File.Exists(QueueAsyncTask.selectTask.report))
                    {
                     
                    }
                    ChatHub.SendMessangeToUser(QueueAsyncTask.selectTask.id, "Automation test session is completed.");
                    var endTime = DateTime.UtcNow;
                    monitor.Stop();
                    SendEmail(QueueAsyncTask.selectTask.userMail, QueueAsyncTask.selectTask.FileName, QueueAsyncTask.selectTask.ProjectName, QueueAsyncTask.selectTask.FunctionName, startTime, endTime, QueueAsyncTask.selectTask.report);
                }
            }
        };

        public void startTask()
        {
            QueueAsyncTask.myQueue1 = new Queue<AsyncTask>();
            Task task = new Task(myTask);
            task.Start();
        }

        public static void SendEmail(string destEmail, 
                              string fileName,
                              string pjName,
                              string funcName,
                              DateTime startTime,
                              DateTime endTime,
                              string reportFilePath)
        {
            var mailContents = "All of your test case of file '{0}' had been run throught. Please check the details result below. <br /> Project: {1} <br /> Function: {2} <br /> Testcase File: {0} <br /> Start time: {3} <br /> Complete time: {4} <br /> Total run time: {5} <br />";
            TimeSpan duration = endTime - startTime;
            var durationStr = string.Format("{0:00}h {1:00}m {2:00}s", duration.Hours, duration.Minutes, duration.Seconds);

            var multipart = new Multipart("mixed");
            var readableFilename = fileName.Split('-')[0];
            var textPart = new TextPart(TextFormat.Html)
            {
                Text = string.Format(mailContents, readableFilename + ".csv", pjName, funcName, startTime.ToString(), endTime.ToString(), durationStr),
                ContentTransferEncoding = ContentEncoding.Base64,
            };
            multipart.Add(textPart);

            MemoryStream fileStream = new MemoryStream(File.ReadAllBytes(reportFilePath));
            fileStream.Position = 0;

            var attachmentPart = new MimePart();
            var readableAttachFilename = Path.GetFileName(reportFilePath).Split('-')[0] + ".html";
            attachmentPart.Content = new MimeContent(fileStream);
            attachmentPart.ContentId = readableAttachFilename;
            attachmentPart.ContentTransferEncoding = ContentEncoding.Base64;
            attachmentPart.FileName = readableAttachFilename;
            multipart.Add(attachmentPart);

            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse("testappsend99@gmail.com"));
            email.To.Add(MailboxAddress.Parse(destEmail));
            email.Subject = "Your test had been done";
            email.Body = multipart;
            
            // send email
            using var smtp = new SmtpClient();
            smtp.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
            smtp.Authenticate("testappsend99@gmail.com", @"123QWEasd?!");
            smtp.Send(email); 
            smtp.Disconnect(true);
        }

    }
}
