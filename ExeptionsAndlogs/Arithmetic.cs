using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeptionsAndlogs
{
    public static class Arithmetic
    {
        public static double Addition(double x, double y)
        {
            double result = x + y;
            return result;
        }
        public static double Subtraction(double x, double y)
        {
            double result = x - y;
            return result;
        }
        public static double Multiplication(double x, double y)
        {
            double result = x * y;
            return result;
        }
        public static int Division(int x, int y)
        {
            int result = x / y;
            return result;
        }
    }
}
