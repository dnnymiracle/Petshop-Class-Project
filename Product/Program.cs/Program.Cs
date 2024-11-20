using System;
using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Press 1 to add a product");
        Console.WriteLine("Type 'exit' to quit");

        string userInput = Console.ReadLine();

        while (userInput.ToLower() != "exit")
        {
            Console.WriteLine("Press 1 to add a product");
            Console.WriteLine("Type 'exit' to quit");

            if (userInput == "1")
            {
                Console.WriteLine("Choose a product to add (1 for CatFood, 2 for DogLeash):");
                string productChoice = Console.ReadLine();

                if (productChoice == "1")
                {
                    CatFood catFood = new CatFood();

                    Console.Write("Enter Name: ");
                    catFood.Name = Console.ReadLine();

                    Console.Write("Enter Price: ");
                    catFood.Price = decimal.Parse(Console.ReadLine());

                    Console.Write("Enter Quantity: ");
                    catFood.Quantity = int.Parse(Console.ReadLine());

                    Console.Write("Enter Description: ");
                    catFood.Description = Console.ReadLine();

                    Console.Write("Enter Weight (lbs): ");
                    catFood.WeightPounds = double.Parse(Console.ReadLine());

                    Console.Write("Is it Kitten Food? (true/false): ");
                    catFood.KittenFood = bool.Parse(Console.ReadLine());

                    Console.WriteLine("Product Added:");
                    Console.WriteLine(JsonSerializer.Serialize(catFood));
                }
                else if (productChoice == "2")
                {
                    DogLeash dogLeash = new DogLeash();

                    Console.Write("Enter Name: ");
                    dogLeash.Name = Console.ReadLine();

                    Console.Write("Enter Price: ");
                    dogLeash.Price = decimal.Parse(Console.ReadLine());

                    Console.Write("Enter Quantity: ");
                    dogLeash.Quantity = int.Parse(Console.ReadLine());

                    Console.Write("Enter Description: ");
                    dogLeash.Description = Console.ReadLine();

                    Console.Write("Enter Length (inches): ");
                    dogLeash.LengthInches = int.Parse(Console.ReadLine());

                    Console.Write("Enter Material: ");
                    dogLeash.Material = Console.ReadLine();

                    Console.WriteLine("Product Added:");
                    Console.WriteLine(JsonSerializer.Serialize(dogLeash));
                }
                else
                {
                    Console.WriteLine("Invalid choice. Try again.");
                }
            }

            userInput = Console.ReadLine();
        }

        Console.WriteLine("Application exited.");
    }
}