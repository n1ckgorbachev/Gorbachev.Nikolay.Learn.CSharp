using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorbachev.Nikolay.Learn.CSharp
{
    internal class Dog
    {
        private readonly string name;
        private readonly int age;

        public Dog()
        {
            name = "Zosya";
            age = 10;
        }

        public void Bark()
        {
            Console.WriteLine("Woof! Woof!");
        }
    }
}
