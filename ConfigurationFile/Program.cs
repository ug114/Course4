using MyClass;
using System;
using System.Configuration;

namespace ConfigurationFile
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var url = ConfigurationManager.AppSettings["SiteUrl"];
            Console.WriteLine(url);

            var element = new Class1();
            element.WriteSomething();
        }
    }
}
