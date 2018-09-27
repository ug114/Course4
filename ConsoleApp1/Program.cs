using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = ConfigurationManager.AppSettings["SiteUrl"];
            Console.WriteLine(url);
        }
    }
}
