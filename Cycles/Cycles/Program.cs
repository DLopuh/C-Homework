using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cycles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число");

            int n = int.Parse(Console.ReadLine());
           
            if (n % 2 == 0)
            {
                Console.WriteLine("Число чётное");
                Console.ReadLine();
            }
            else 
            {
                Console.WriteLine("Число не чётное");
                Console.ReadLine();
            }
           
        }

    }

}




















