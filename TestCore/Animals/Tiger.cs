using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCore.Animals
{
    public class Tiger : Cat
    {
        public string name;
        public Tiger(string color) : base(color)
        {
            id = "2";
            Console.WriteLine("Tiger created!");
        }

        public void Hunting()
        {
            Console.WriteLine("Start hunting!");
        }
    }
}
