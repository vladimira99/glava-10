using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            double i = 1;
            double a = 0;
           
            for (i=1; i<=49; i++)
            {
                Console.WriteLine("{i} root {i} = Math.Sqrt(i,1/i)} ");
                a = a + Math.Sqrt(i, 1 / i);
            }
            Console.WriteLine(a);
        }
    }
}
