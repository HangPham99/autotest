using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Commons
{
    public class AsyncTask
    {
        public string id { get; set; }
        public string command { get; set; }
        public string csv { get; set; }
        public string report { get; set; }
        public string logs { get; set; }
    }

    public class QueueAsyncTask
    {
        public static AsyncTask selectTask;
        public static Queue<AsyncTask> myQueue1;
    }
}
