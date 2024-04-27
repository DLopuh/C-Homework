using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Случайная матрица");

            Console.WriteLine("Введите колличество строк в матрице: ");
            int line = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите колличество столбцов в матрице: ");
            int column = int.Parse(Console.ReadLine());

            int[,] matrix1 = new int[line, column];

            Random random = new Random();

            int sum = 0;

            for (int i = 0; i < matrix1.GetLength(0); i++)
            {

                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    matrix1[i, j] = random.Next(-10, 10);
                    sum += matrix1[i, j];
                    Console.Write($"{matrix1[i, j],3}");

                }
                Console.WriteLine();

            }
            Console.WriteLine($"Сумма всех элементов матрицы: {sum}");
            Console.ReadLine();

            int[,] matrix2 = new int[line, column];
            int[,] matrix3 = new int[line, column];

            for (int i = 0; i < matrix2.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    matrix2[i, j] = random.Next(-10, 10);
                   
                    Console.Write($"{matrix2[i, j],3}");
                }
                Console.WriteLine();
               
            }
            for (int i = 0; i < matrix2.GetLength(0); i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("\n" + "Сумма двух матриц" + "\n");
                }
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    matrix3[i, j] = matrix1[i, j] + matrix2[i, j];

                    Console.Write($"{matrix3[i, j],3}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.ReadLine();

            

           

            
           





        }   

    }
}


