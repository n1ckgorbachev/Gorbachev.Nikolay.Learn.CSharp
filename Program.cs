namespace Gorbachev.Nikolay.Learn.CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
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