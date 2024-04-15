using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Player,Сколько у вас карт?: ");
           
            int countCards = int.Parse(Console.ReadLine());
            int sum = 0;
            
            for (int i = 1; i <= countCards; i++)
            {
                int result = 0;
                Console.WriteLine("Введите номинал карты");
                string console = Console.ReadLine();

                switch (console)
                {
                    case "6":
                        result = 6;
                        break;

                    case "7":
                        result = 7;
                        break;

                    case "8":
                        result = 8;
                        break;

                    case "9":
                        result = 9;
                        break;

                    case "10":
                        result = 10;
                        break;

                    case "J":
                        result = 10;
                        break;

                    case "Q":
                        result = 10;
                        break;

                    case "K":
                        result = 10;
                        break;

                    case "T":
                        result = 10;
                        break;

                }
                sum += result;

            }
            Console.WriteLine($"Сумма {sum}");
            Console.ReadLine();


            
        }
    }
}
