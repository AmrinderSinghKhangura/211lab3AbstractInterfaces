using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Dog2 : IAnimal
    {
        public string Name {  get; set; }
        public string Color { get; set; }
        public string Height { get; set; }
        public int Age { get; set; }
        public Dog2 (string name, string color, string height, int age) 
        {
            this.Name = name;
            this.Color = color;
            this.Height = height;
            this.Age = age;
        }
        public void Eat()
        {
            Console.WriteLine("Dogs eat meat");
        }
        public string Cry()
        {
            return "Woof!";
        }
    }
}
