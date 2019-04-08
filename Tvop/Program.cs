using System;

namespace Tvop
{
    class Program
    {
        static void Main()
        {
            var a = GetLength(1);
            var b = GetLength(2);
            var c = GetLength(3);
            if (a + b >= c && a + c >= b && b + c >= a)
            {
                if (a != c && b != c && a != b)
                {
                    Console.WriteLine("Треугольник - разносторонний");
                }
                else if (a == b && a != c || c == b && a != c || a == c && b != c)
                {
                    Console.WriteLine("Треуголник - равнобедренный");
                }
                else
                {
                    Console.WriteLine("Треуголник - равносторонний");
                }
            }
            else
            {
                Console.WriteLine("Невозможно создать треугольник");
            }
        }

        private static int GetLength(int partNumber)
        {
            int result;
            while (true)
            {
                Console.Write("Введите " + partNumber + " сторону: ");
                if (int.TryParse(Console.ReadLine(), out result) && result > 0)
                {
                    break;
                }

                Console.WriteLine("Неверные входные данные");
            }

            return result;
        }
    }
}
