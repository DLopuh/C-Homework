using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fullName = "Лопухин Дмитрий Михайлович";

            int age = 38;

            string email = "dmitriy.lopukhin@icloud.com";

            float programmingPoint = 99.8f;

            double mathScore = 99.8;

            decimal phisicsPoints = 99.8M;

            Console.WriteLine(fullName);
            Console.WriteLine(age);
            Console.WriteLine(email);
            Console.WriteLine(programmingPoint);
            Console.WriteLine(mathScore);
            Console.WriteLine(phisicsPoints);

            Console.ReadLine();

            decimal sum = (decimal)programmingPoint + (decimal)mathScore + phisicsPoints;

            Console.WriteLine(sum);

            Console.ReadLine();

            decimal averageMark = ((programmingPoint + mathScore + phisicsPoints) / 3);

            Console.WriteLine(averageMark);

            Console.ReadLine();
        }
    }
}
