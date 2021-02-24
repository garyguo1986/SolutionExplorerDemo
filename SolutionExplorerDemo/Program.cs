using SolutionExplorerDemo.Properties;
using System;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;
/// <summary>
/// 1:Ctrl+K Ctrl+C comment
/// 2:Ctrl+K Ctrl+U uncomment
/// 3:Ctrl+Shift+V select paste
/// </summary>
namespace SolutionExplorerDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Test();
            Console.ReadLine();
        }
        #region Test
        static void Test()
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
            NewTest();
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
            var c = new Customer();
            //c.SayHello2();
            //c.CreateSalesOrder2();
        }

        private static void NewTest()
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
            if(!EventLog.SourceExists("testsource"))
            EventLog.CreateEventSource("testsource","testlog");
            EventLog.WriteEntry("testsource", "testmessage",EventLogEntryType.Error,10);
            Console.WriteLine("SUccess");
        }
        #endregion
    }
}