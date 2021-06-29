using System;

namespace Homework__4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 4. Написать программу, вычисляющую число Фибоначчи для заданного значения рекурсивным способом.
            Console.Write("Введите число: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Число Фибоначчи: " + Fibonachi(n));
            Console.ReadKey();
        }

        static int Fibonachi(int n)
        {
            return Fibonachi(n, out _);
        }

        static int Fibonachi(int n, out int f1)
        {
            f1 = 0;
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                int f2;// Число Фибоначчи n - 2
                f1 = Fibonachi(n - 1, out f2); // Число Фибоначчи n - 1
                return f1 + f2;
            }
        }
    }
}
