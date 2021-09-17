using System;

namespace log4netSample
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basic Log4net program...");

            logging log = new logging();
            log.testAlertPopup();

        }
    }
}
