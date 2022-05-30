using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeptionsAndlogs
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new Logger();
            try
            {
                int x = 5;
                int y = 0;

                //Console.WriteLine("Please insert the first parameter");
                //double x = Convert.ToDouble(Console.ReadLine());
                //Console.WriteLine("Please insert the second parameter");
                //double y = Convert.ToDouble(Console.ReadLine());
                //Arithmetic.Addition(x, y);
                var xxx = Arithmetic.Division(x, y);
            }
            catch (Exception ex)
            {
                Console.WriteLine("----------------------------");
                logger.Log(logger.CreateLog(ex));
                
            }
        }
    }
}
