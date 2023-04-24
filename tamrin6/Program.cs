using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tamrin6
{
    internal class Program
    {
        private static int test (int x , int y)
        {
            double result;
            result = (Math.Sqrt(Math.Abs(x))) + (Math.Pow(y, 2));
            Console.WriteLine( result );
            return 0;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(" enter numbers ");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            test (x,y);
        }
    }
}
