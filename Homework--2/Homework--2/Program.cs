using System;

namespace Homework__2
{
    class Program
    {
        static void Main(string[] args)
        {
	    //Задание 2. Написать программу, принимающую на вход строку — набор чисел, разделенных пробелом, и возвращающую число — сумму всех чисел в строке. Ввести данные с клавиатуры и вывести результат на экран.
            Console.Write("Введите набор чисел, раздельнных пробелом: ");
            Console.WriteLine(GetSum(Console.ReadLine()));

            Console.ReadKey();
        }

        static int GetSum(string Input)
        {
            int sum = 0;

            string number = "";
            for(int i = 0; i <= Input.Length; i++)
            {
                if (i == Input.Length || Input[i] == ' ')
                {
                    if(number != "")
                    {
                        sum += Convert.ToInt32(number);
                        number = "";
                    }
                }
                else
                {
                    number += Input[i];
                }
            }
            return sum;
        }
    }
}
