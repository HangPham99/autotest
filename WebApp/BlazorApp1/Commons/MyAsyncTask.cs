using BlazorApp1.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
                    monitor.Stop();
                }
            }
        };
        public void startTask()
        {
            QueueAsyncTask.myQueue1 = new Queue<AsyncTask>();
            Task task = new Task(myTask);
            task.Start();
        }
    }
}
