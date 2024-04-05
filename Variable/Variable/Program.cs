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

            Console.WriteLine("Ф.И.О: " + fullName);
            Console.WriteLine("Возраст: " + age);
            Console.WriteLine("Почта: " + email);
            Console.WriteLine("Баллы по программированию: " + programmingPoint);
            Console.WriteLine("Баллы по математике: " + mathScore);
            Console.WriteLine("Баллы по физике: " + phisicsPoints);

            Console.ReadLine();

            decimal sum = (decimal)programmingPoint + (decimal)mathScore + phisicsPoints;

            Console.WriteLine("Сумма: " + sum);

            Console.ReadLine();

            decimal averageMark = (((decimal)programmingPoint + (decimal)mathScore + phisicsPoints) / 3);

            Console.WriteLine("Средний бал: " + averageMark);

            Console.ReadLine();
        }
    }
}
