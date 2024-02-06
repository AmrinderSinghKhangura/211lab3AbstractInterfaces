using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Cat : Animal
    {
        public Cat(string name, string color, int age) 
        { 
            this.name = name;
            this.color = color;
            this.age = age;
        }
        public override void Eat()
        {
            Console.WriteLine("Cats eat mice");
        }
    }
}
