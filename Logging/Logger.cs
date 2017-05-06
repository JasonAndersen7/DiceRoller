using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Logging
{
    public class Logger
    {
        //verify that the application has access to log to this location
       static string path = @"C:\_log\log.txt";

        public static void LogMessage(string message, string level)
        {
            using (StreamWriter w = File.AppendText(path))
            {
                Log("Test1", w);
                Log("Test2", w);
            }

            using (StreamReader r = File.OpenText(path))
            {
                DumpLog(r);
            }

        }


        public static void Log(string logMessage, TextWriter w)
        {
            w.Write("\r\nLog Entry : ");
            w.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(),
                DateTime.Now.ToLongDateString());
            w.WriteLine("  :");
            w.WriteLine("  :{0}", logMessage);
            w.WriteLine("-------------------------------");
        }


        public static void DumpLog(StreamReader r)
        {
            string line;
            while ((line = r.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }

        }
    }
}
