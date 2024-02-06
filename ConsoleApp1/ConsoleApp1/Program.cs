namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Part 1
            Console.WriteLine("Dog name: ");
            string dogName = Console.ReadLine();
            Console.WriteLine("Dog color: ");
            string dogC = Console.ReadLine();
            Console.WriteLine("Dog age: ");
            int dogA = int.Parse(Console.ReadLine());
           Dog dog = new Dog(dogName, dogC, dogA);
            Console.WriteLine($"{dog.GetName()} is a {dog.GetColor()} dog that is {dog.GetAge()} years old.");

            Console.WriteLine("Cat name: ");
            string catName = Console.ReadLine();
            Console.WriteLine("Cat color: ");
            string catC = Console.ReadLine();
            Console.WriteLine("Cat age: ");
            int catA = int.Parse(Console.ReadLine());
            Cat cat = new Cat(catName, catC, catA);
            Console.WriteLine($"{cat.GetName()} is a {cat.GetColor()} cat that is {cat.GetAge()} years old.");


            //Part 2
            Console.WriteLine("Dog name: ");
            dogName = Console.ReadLine();
            Console.WriteLine("Dog color: ");
            dogC = Console.ReadLine();
            Console.WriteLine("Dog height: ");
            string dogH = Console.ReadLine();
            Console.WriteLine("Dog age: ");
            dogA = int.Parse(Console.ReadLine());
            Dog2 dog2 = new Dog2(dogName, dogC, dogH, dogA);
            Console.WriteLine($"{dog2.Name} is a {dog2.Color} dog of {dog2.Height} height that is {dog2.Age} years old.");

            Console.WriteLine("Cat name: ");
            catName = Console.ReadLine();
            Console.WriteLine("Cat color: ");
            catC = Console.ReadLine();
            Console.WriteLine("Cat height: ");
            string catH = Console.ReadLine();
            Console.WriteLine("Cat age: ");
            catA = int.Parse(Console.ReadLine());
            Cat2 cat2 = new Cat2(catName, catC, catH, catA);
            Console.WriteLine($"{cat2.Name} is a {cat2.Color} cat of {cat2.Height} height that is {cat2.Age} years old.");

            List<IAnimal> animals = new List<IAnimal>() { dog2, cat2};
            foreach(IAnimal a in animals)
            {
                Console.WriteLine(a.Name);
            }
        }
    }
}
