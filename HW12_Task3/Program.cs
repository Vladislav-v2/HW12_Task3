using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HW12_Task3
{
    public class Program
    {
        static void Main(string[] arg)
        {
            Console.ReadKey();
        }

        public static double Result(string str)
        {
            Regex r = new Regex(@"-{0,1}\d+");
            MatchCollection m = r.Matches(str);
            List<int> numbers = new List<int>();
            foreach (Match item in m)
            {
                numbers.Add(int.Parse(item.Value));
            }
            double result = 0;
            try
            {
                result = numbers[0] + numbers[1] * numbers[2] /
                   Math.Pow(numbers[3] + numbers[4], numbers[5]);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Divide by zero");
            }
            return result;
        }
    }
}