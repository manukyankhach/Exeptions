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

                Arithmetic.Division(x, y);
                Arithmetic.Addition(x, y);
            }
            catch (ArgumentNullException ex)
            {
                logger.Log(logger.CreateLog(ex));
            }
            catch (DivideByZeroException ex)
            {
                logger.Log(logger.CreateLog(ex));
            }
            catch (Exception ex)
            {
                logger.Log(logger.CreateLog(ex));
            }
        }
    }
}
