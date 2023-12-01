using System;
using System.Collections.Generic;

public class VirtualPet
{
    public string Name { get; }
    public int Age { get; }
    private bool isHungry;

    public VirtualPet(string name, int age)
    {
        Name = name;
        Age = age;
        isHungry = false;
    }

    public void Feed()
    {
        Console.WriteLine($"{Name} is eating food.");
        isHungry = false;
    }

    public void Cuddle()
    {
        Console.WriteLine($"{Name} smiles at you!");
    }

    public void CheckIfToiletTime()
    {
        if (isHungry)
        {
            Console.WriteLine($"{Name} have to go to the toilet!");
        }
        else
        {
            Console.WriteLine($"{Name} doesn't have to go to the toilet right now");
        }
    }
}

class Program
{
    static void Main()
    {
        List<VirtualPet> pets = new List<VirtualPet>();

        pets.Add(new VirtualPet("Nusse", 7));
        pets.Add(new VirtualPet("Pikachu", 15));
        pets.Add(new VirtualPet("Hedwig", 10));


        while (true)
        {
            Console.WriteLine("Choose pet:");

            for (int i = 0; i < pets.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {pets[i].Name}");
            }

            Console.WriteLine($"{pets.Count + 1}. Finish");

            int petChoice = int.Parse(Console.ReadLine());

            if (petChoice == pets.Count + 1)
            {
                Console.WriteLine("Thank you for taking care of the pets!");
                return;
            }

            VirtualPet selectedPet = pets[petChoice - 1];

            Console.WriteLine($"{selectedPet.Name} is {selectedPet.Age} years old.");
            Console.WriteLine("1. Give food");
            Console.WriteLine("2. Cuddle");
            Console.WriteLine("3. Check if the pet needs to go to the toilet");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    selectedPet.Feed();
                    break;
                case 2:
                    selectedPet.Cuddle();
                    break;
                case 3: selectedPet.CheckIfToiletTime();
                    break;
                default:
                    Console.WriteLine("Not a valid choice, try again.");
                    break;
            }
        }
    }
}