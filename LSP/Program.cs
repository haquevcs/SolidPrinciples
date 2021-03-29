using better = SolidPriciple.LSP.Better;
using SolidPriciple.LSP.Not_So_Good;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rule : The Liskov Substitution Principle is a Substitutability principle in object-oriented programming Language. This principle states that, if S is a subtype of T, then objects of type T should be replaced with the objects of type S.
            //For example, the father is a teacher whereas his son is a doctor. So here, in this case, the son can’t simply replace his father even though both belong to the same family.


            //Example without using the Liskov Substitution Principle in C#:
            Apple apple = new Orange();
            Console.WriteLine(apple.GetColor());

            //Example Using the Liskov Substitution Principle in C#

            better.Fruit fruit = new better.Orange();
            Console.WriteLine(fruit.GetColor());
            fruit = new better.Apple();
            Console.WriteLine(fruit.GetColor());
        }
    }
}
