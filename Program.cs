using System;

namespace FourthHomeWork
{

    class Switch
    {
        public static void Main()
        {

        Start:

            {
                Console.WriteLine("1.Цикл, который принимает на вход два числа(A и B) и возводит число A в натуральную степень B");
                Console.WriteLine("2.Программа, которая принимает на вход число и выдаёт сумму цифр в числе");
                Console.WriteLine("3.Программа, которая задаёт массив из 8 элементов и выводит их на экран");
                Console.Write("Выбери номер задания:");
                if (TryGetUserInput(out int value))
                {
                    switch (value)
                    {
                        case 1: Task25.Task25Main(); goto Start;
                        case 2: Task27.Task27Main(); goto Start;
                        case 3: Task29.Task29Main(); goto Start;
                        default: Console.WriteLine("Извини, такой задачи нет :(. Попробуй еще раз!"); goto Start;
                    }
                }
                Console.WriteLine("Введи число, а не буквы :)");
                goto Start;

            }

        }

        private static bool IsString(string input)
        {
            return !int.TryParse(input, out _);
        }

        private static bool TryGetUserInput(out int value)
        {
            string input = Console.ReadLine();
            if (IsString(input))
            {
                value = 0;
                return false;
            }

            else
            {
                value = int.Parse(input);
                return true;
            }
        }
    }



    class Task25
    {
        public static void Task25Main()
        {
            double result = Math.Pow(GetFirstNumber(), GetSecondNumber());
            Console.WriteLine($"Answer: {result}");
            Console.ReadKey();
        }

        private static int GetFirstNumber()
        {
            Console.WriteLine("Input first number: ");
            return int.Parse(Console.ReadLine());
        }

        private static int GetSecondNumber()
        {
            Console.WriteLine("Input second number: ");
            return int.Parse(Console.ReadLine());
        }
    }

    class Task27
    {
        public static void Task27Main()
        {
            Console.Write("Enter the value: ");
            int value = int.Parse(Console.ReadLine());
            Console.WriteLine($"Сумма всех цифр равна: {GetSumOfDigits(value)}");
            Console.ReadKey();
        }

        private static int GetSumOfDigits(int input)
        {
            int sum = 0;
            while (input != 0)
            {
                input = Math.DivRem(input, 10, out int result);
                sum += result;
            }
            return sum;
        }

    }
    class Task29
    {
        public static void Task29Main()
        {
            Console.WriteLine("Введи 8 значений: ");
            int[] Array = new int[8];
            for (int i = 0; i < 8; i++)
            {
                Array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine($"{i + 1} элемент массива: {Array[i]}");
            }
            Console.ReadLine();
        }
    }


}




