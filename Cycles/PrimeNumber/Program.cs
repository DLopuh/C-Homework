using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число: ");

            int n = int.Parse(Console.ReadLine());

            if (n > 0)
            {
                int i = 1;

                while (i <= n - 1)
                {
                    i++;

                    if (n % i == 0)
                    {
                        Console.WriteLine($"Число {n} не является простым");
                        Console.ReadLine();
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Число {n} является простым");
                        Console.ReadLine();
                        break;
                    }
                }
            }
        }
    }
}



