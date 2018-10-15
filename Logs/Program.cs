using System;
using NLog;

namespace Logs
{
    class Program
    {
        static void Main(string[] args)
        {
            var logger = LogManager.GetCurrentClassLogger();
            logger.Info("Приложение запущено.");

            Console.WriteLine("Введите сегодняшнее число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            try
            {
                if (number <= 0 || number > 31)
                {
                    throw new Exception("Число введено неверно.");
                }
            }
            catch (Exception e)
            {
                logger.Error(e, e.Message);
            }
        }
    }
}
