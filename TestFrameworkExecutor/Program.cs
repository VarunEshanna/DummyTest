using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFrameworkExecutor
{
    class Program
    {
        static void Main(string[] args)
        {
            // This should be dynamic
            String value1 = "AdobeCorporateEntityRecords,AdobeContractClassRecords";
            String value2 = "AdobeCorporateEntityRecords";
            String value3 = "AdobeContractClassRecords";

            // If we get values -- Trigger jenkins job 1. If null then job 2

            String path = @"C:\Users\eshanna\Downloads\NUnit.ConsoleRunner.3.8.0\NUnit.ConsoleRunner.3.8.0\tools\";
            String parameters = @"C:\Users\eshanna\source\repos\LegalServices-master\DummyTest\LegalServiceTest\bin\Debug\LegalServiceTest.dll --params=datasets=" + value1;
            string filename = Path.Combine(path, "nunit3-console.exe");
            var proc = System.Diagnostics.Process.Start(filename, parameters);


        }
    }
}
