// See https://aka.ms/new-console-template for more information
using OOP;

Console.WriteLine("Enter number of animals: ");
int number;
List<IAnimal>? animals = int.TryParse(Console.ReadLine(), out number) ? new List<IAnimal>() : null;
if(animals == null)
{
    Console.WriteLine("Error: NaN!");
    return;
}
for(int i = 0; i < number; i++)
{
    Console.WriteLine("Which animal do you want to add (dog: 0, bear:1):");
    int animal = int.Parse(Console.ReadLine());
    if(animal == 0)
    {
        Dog dog = AnimalService.CreateDog();
        animals.Add(dog);
    }
    else if(animal == 1)
    {
        Bear bear = AnimalService.CreateBear();
        animals.Add(bear);
    }
}


Console.WriteLine($"\nTotal animal age is: {AnimalService.CalculateTotalAge(animals)}\n");
Console.WriteLine($"Animals say hi: \n{AnimalService.Talk(animals)}");
Console.WriteLine($"Number of dangerous animals: {AnimalService.CountDangerousAnimals(animals)}");





