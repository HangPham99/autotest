using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Models
{
    public class TestCaseFileContent
    {
        public string Action { get; set; }
        public string Target { get; set; }
        public string Value { get; set; }

        public static TestCaseFileContent FromCsv(string csvLine)
        {
            string[] values = csvLine.Split(',');
            TestCaseFileContent fileContent = new TestCaseFileContent();
            fileContent.Action = Convert.ToString(values[0]);
            fileContent.Target = Convert.ToString(values[1]);
            fileContent.Value = Convert.ToString(values[2]);
            return fileContent;
        }
    }
}
