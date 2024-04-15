using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guessnumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите максимальное число диапазона: ");

            int maxRandom = int.Parse(Console.ReadLine());
            string input;
            Random rnd = new Random();
            int random = rnd.Next(0,maxRandom);
            
            Console.WriteLine("Введите число: ");

            while (true)
            {
                input = Console.ReadLine();

                if (input == string.Empty)
                {
                    Console.WriteLine($"Загаданное число: {random}");
                    Console.ReadLine();
                    break;
                }

                int userNumber = int.Parse(input);

                if (userNumber < random)
                {
                    Console.WriteLine("Введеное число меньше загаданного,попробуйте еще раз!");
                }
                else if (userNumber > random)
                {
                    Console.WriteLine("Введеное число больше загаданного,попробуйте еще раз!");
                }
                else 
                {
                    Console.WriteLine("Поздравляю, число угадано!");
                    Console.ReadLine(); 
                    break;
                }

            }
            
        }
    }
}
