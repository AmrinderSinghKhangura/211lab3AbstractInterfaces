using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface IAnimal
    {
        string Name { get; set; }
        string Color { get; set; }
        string Height { get; set; }
        int Age { get; set; }

        public string GetName()
        {
            return this.Name;
        }
        public void SetName(string n)
        {
            this.Name = n;
        }
        public string GetColor()
        {
            return this.Color;
        }
        public void SetColor(string n)
        {
            this.Color = n;
        }
        public string GetHeight()
        {
            return this.Height;
        }
        public void SetHeight(string n)
        {
            this.Height = n;
        }
        public int GetAge()
        {
            return this.Age;
        }
        public void SetAge(int n)
        {
            this.Age = n;
        }

        public abstract void Eat();

        public string Cry();
    }
}

