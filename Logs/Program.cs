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
            logger.Info("���������� ��������");

            try
            {
                throw new Exception("������");
            }
            catch (Exception e)
            {
                logger.Error(e, "������");
            }
        }
    }
}
