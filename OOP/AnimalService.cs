using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public static class AnimalService
    {
        public static Dog CreateDog()
        {
            Dog dog = new Dog();
            Console.WriteLine("Enter dogs name:");
            dog.Name = Console.ReadLine();
            Console.WriteLine("Does dog have an owner (if it has put true, else false):");
            bool hasOwner;
            dog.HasOwner = bool.TryParse(Console.ReadLine(), out hasOwner) ? hasOwner : false;
            Console.WriteLine("Is dog dangerous (if it is put true, else false):");
            bool isDangerous;
            dog.IsDangerous = bool.TryParse(Console.ReadLine(), out isDangerous) ? isDangerous : true;
            Console.WriteLine("Enter dogs age:");
            dog.Age = int.Parse(Console.ReadLine());
            return dog;
        }

        public static Bear CreateBear()
        {
            Bear bear = new Bear();
            Console.WriteLine("Enter bears name:");
            bear.Name = Console.ReadLine();
            Console.WriteLine("Enter bears claw strenght:");
            bear.ClawStrenght = int.Parse(Console.ReadLine());
            Console.WriteLine("Is bear dangerous (if it is put true, else false):");
            bool isDangerous;
            bear.IsDangerous = bool.TryParse(Console.ReadLine(), out isDangerous) ? isDangerous : true;
            Console.WriteLine("Enter bears age:");
            bear.Age = int.Parse(Console.ReadLine());
            return bear;
        }

        public static int CalculateTotalAge(List<IAnimal> animals)
        {
            int totalAge = 0;
            foreach (IAnimal animal in animals)
            {
                totalAge += animal.Age;
            }
            return totalAge;
        }
        public static string Talk(List<IAnimal> animals)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Animal animal in animals)
            {
                sb.Append(animal.Speak());
                sb.Append("\n");
            }
            return sb.ToString();
        }
        public static int CountDangerousAnimals(List<IAnimal> animals)
        {
            int count = 0;
            foreach (Animal animal in animals)
            {
                if (animal.IsDangerous == true)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
