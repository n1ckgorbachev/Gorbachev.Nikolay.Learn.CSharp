using System.Collections.Concurrent;

namespace Gorbachev.Nikolay.Learn.CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ConvertToText(int number)
            {
                return Convert.ToString(number);
            }

            Console.WriteLine(ConvertToText(34));

            

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