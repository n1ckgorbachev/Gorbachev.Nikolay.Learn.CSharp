using System.Collections.Concurrent;

namespace Gorbachev.Nikolay.Learn.CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Bark();


            /*
            int Operation(int op, int a, int b)
            {
                switch (op)
                {
                    case 1:
                        return a + b;
                    case 2:
                        return a - b;
                    default:
                        return op;
                }
            }

            Console.WriteLine($"Результат операции: {Operation(6, 5,9)}");
            */

            /*
            string a = "5";

            switch (a)
            {
                case "1":
                    Console.WriteLine(1);
                    break;
                case "5":
                    Console.WriteLine(2);
                    goto default;
                case "Y":
                    Console.WriteLine(3);
                    break;
                case "Привет":
                    Console.WriteLine("Привет");
                    break;
                default:
                    Console.WriteLine(10);
                    break;
            }
            */

            /*
            int Fibonacci(int n)
            {
                if (n == 0 || n == 1)
                {
                    return n;
                }
                else
                {
                    return Fibonacci(n - 1) + Fibonacci(n - 2);
                }
            }

            int CycleFibonacci(int n )
            {
                int result = 0;
                int b = 1;
                int tmp;

                for (int i = 0; i < n; i++)
                {
                    tmp = result;
                    result = b;
                    b += tmp;
                }
                return result;
            }

            Console.WriteLine($"Четвертое число Фибаначчи = {CycleFibonacci(4)}");
            */

            /*
            int Factorial (int n)
            {
                if (n == 1)
                {
                    return 1;
                }
                else
                {
                    return n * Factorial(n - 1);
                }
            }
            Console.WriteLine("Введи число:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Факториал числа {number} равен: {Factorial(number)}");
            */

            /*
            void SumAllElements(params int[] numbers)
            {
                int result = 0;

                foreach (int number in numbers)
                {
                    result += number;
                }
                Console.WriteLine(result);
            }

            void SumAllMassive(int[] numbers)
            {
                int result = 0;

                foreach(int number in numbers)
                {
                    result += number;
                }
                Console.WriteLine(result);
            }

            int[] mass = { 1, 2, 3, 4, 5 };
            //SumAllElements(1,3,6,3);
            SumAllMassive (mass);
            SumAllMassive(mass);
            */

            /*
            int Increment(ref int n)
            {
                n++;
                return n;
            }

            int number = 0;
            Console.WriteLine($"До преобразований: {number}");
            Increment(ref number);
            Console.WriteLine($"После преобразований: {number}");
            */

            /*
            string ConvertToText(int number)
            {
                return Convert.ToString(number);
            }

            Console.WriteLine(ConvertToText(34));
            */

            /*
            int[] numbers = { -1, -2, -5, -14, 8, 6, 7, 5 };
            int tempNumber = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        tempNumber = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = tempNumber;
                    }
                }
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($" {numbers[i]}");
            }
            */

            /*
            int numbersLenght = numbers.Length;
            int arrayMiddle = numbersLenght / 2;
            int tempNumber = 0;

            for (int i = 0; i < arrayMiddle; i++)
            {
                tempNumber = numbers[i];
                numbers[i] = numbers[numbersLenght - i - 1];
                numbers[numbersLenght - i - 1] = tempNumber;
            }
            foreach (int i in numbers)
            {
                Console.Write($" {i}");
            }
            */

            /*
            int counter = 0;
            int[] invertedArray = new int[numbers.Length];

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                invertedArray[counter] = numbers[i];
                counter++;
            }

            foreach (int i in invertedArray)
            {
                Console.Write(" " + i);
            }
            */

            /*
            int[] numbers = { -1, -2, -5, -14, 5, 6, 7, 8 };
            int positiveNumbersCount = 0;

            foreach (int number in numbers)
            {
                if (number > 0)
                {
                    positiveNumbersCount++;
                }
            }
            Console.WriteLine(positiveNumbersCount);
            */

            /*
            int[][] matrix = new int[3][];
            matrix[0] = new int[2] { 43, 23 };
            matrix[1] = new int[1] { 4 };
            matrix[2] = new int[4] { 11, 21, 24, 5 };

            foreach (int[] i in matrix)
            {
                foreach (int j in i)
                {
                    Console.Write($"{j}\t");
                }
                Console.WriteLine();
            }
            */

            /*
            int[] numbers = { 1, 2, 3, 4, 5 };

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("__________ \n");


            try
            {
                numbers[^1] = 45;
                foreach (int number in numbers)
                {
                    Console.WriteLine(number);
                }
                Console.WriteLine($"Длина массива: {numbers.Length}");
                Console.WriteLine($"Последний элемент массива: {numbers[^1]}");

                for (int number = 0; number < numbers.Length; number++)
                {
                    numbers[number] = number;
                }
                foreach (int number in numbers)
                {
                    Console.WriteLine(number);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            */

            /*
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }
            */

            /*
            int i = 20;
            for (Console.WriteLine("Стартуем уменьшение"); i > 10; Console.WriteLine("Уменьшили"))
            {
                i--;
                Console.WriteLine(i);
            }
            */

            /*
            System.Int32 age = 0;
            while (age < 10)
            {
                Console.WriteLine(age);
                age++;
            }
            */

            /*
            Console.Write("Введи свое имя: ");
            var name = Console.ReadLine();
            foreach (char symbolInName in name)
            {
                if (!symbolInName.Equals('г'))
                {                    
                    Console.WriteLine(symbolInName);
                }
            }
            */

            /*
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1;  j < 10; j++)
                {
                    Console.Write($"{i * j} \t");
                }
                Console.WriteLine();
            }
            */

            /*
            const short YEARS = 10;
            decimal amount = 1000.31m;

            Console.Write("Введи свое имя: ");
            var name = Console.ReadLine();

            Console.WriteLine($"Ваше имя {name}, вам {YEARS} лет, у тебя {amount} рублей");
            */

            /*
            decimal numberOne = 0.1m;
            decimal numberTwo = 0.2m;
            decimal sum = numberOne + numberTwo;

            sum = sum == 0.4m ? 1.1m : 2.1m;
            Console.WriteLine(sum);
            */

            /*
            if (Convert.ToDecimal(sum) == 0.4m)
            {
                Console.WriteLine("Все ок");
            }
            else if (sum != 0.3m)
            {
                Console.WriteLine("Не ок, получилось " + sum);
            }
            else
            {
                Console.WriteLine("А чо всмысле");
            }
            */

            /*
            void sum(double n1, double n2)
            {
                Console.WriteLine(n1 + n2);
            }
            */

            //sum(numberOne, numberTwo);

        }
    }
}