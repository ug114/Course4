using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace Logs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var logger = LogManager.GetCurrentClassLogger();
            logger.Info("Приложение запущено");

            try
            {
                throw new Exception("Ошибка");
            }
            catch (Exception e)
            {
                logger.Error(e, "Ошибка");
            }
        }
    }
}
