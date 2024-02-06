using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Animal
    {
        protected string name;
        protected string color;
        protected int age;

        public string GetName()
        {
            return this.name;
        }
        public void SetName(string n)
        {
            this.name = n;
        }
        public string GetColor()
        {
            return this.color;
        }
        public void SetColor(string n)
        {
            this.color = n;
        }
        public int GetAge()
        {
            return this.age;
        }
        public void SetAge(int n)
        {
            this.age = n;
        }
        public abstract void Eat();
    }
}
