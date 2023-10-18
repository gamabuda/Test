using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCore.Animals;

namespace TestCore.Animals;
{
    public static class AnimalFactory
    {
        public static Cat CreateCat(string color)
        {
            return new Cat(color);
        }

        public static Tiger CreateTiger(string color)
        {
            return new Tiger(color);
        }
    }
}
