using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCore.Animals
{
    public class Cat
    {
        public string color;
        protected string id;

        public Cat(string color)
        {
            id = "1";
            this.color = color;
            Console.WriteLine("Cat created!");
        }

        public void Meow()
        {
            Console.WriteLine("meow!");
        }

        public void Eat()
        {
            Console.WriteLine("eat!");
        }
    }
}
