using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subsequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Введите длину последовательности: ");

            int count = int.Parse(Console.ReadLine());

            int maxValue = int.MaxValue;

            for (int j = 1; j <= count; j++)
            {
                Console.WriteLine("Введите целые числа: ");

                int value = int.Parse(Console.ReadLine());

                if (maxValue > value)
                {
                    maxValue = value;
                }
            }
            Console.WriteLine($"Наименьшее число: {maxValue}");
            Console.ReadLine();
            


           



        }
    }
}
