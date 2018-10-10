using MyClass;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace ConfigurationFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = ConfigurationManager.AppSettings["SiteUrl"];
            Console.WriteLine(url);

            Class1 element = new Class1();
            element.WriteSomething();
        }
    }
}
