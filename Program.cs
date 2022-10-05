// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7_10
{
    class Program
    {
        public static void Kvadrat(double a, double b, double c)
        {
            double D = (a * a - 4 * a * c);
            if (D > 0)
            {
                double x1 = (-b + Math.Sqrt(D) / 2 * a);
                double x2 = (-b - Math.Sqrt(D) / 2 * a);
                Console.WriteLine($"x1={x1}, x2={x2}");
            }
            else if (D == 0)
            {
                double x1 = (-b + Math.Sqrt(D) / 2 * a);
                Console.WriteLine($"x1={x1}");

            }
            else
            {
                Console.WriteLine("Корней нет");
            }
        }

        
      
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1, решение квадратного уравнения");
            Console.WriteLine("Введите коэффиценты a,b,c");
            double ko1 = double.Parse(Console.ReadLine());
            double ko2 = double.Parse(Console.ReadLine());
            double ko3 = double.Parse(Console.ReadLine());
            Kvadrat(ko1, ko2, ko3);
            Console.WriteLine();
            Console.WriteLine("Задание 2, рандомный массив");
        }
    }
}
