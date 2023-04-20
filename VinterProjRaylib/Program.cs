using System;
using System.IO;
using System.Collections.Generic;
playerChef chef = new playerChef();

string choice = "shop";



Dish d = new Dish();
d.ingredients.Add(new Spice());
d.ingredients.Add(new Vegetable());
d.ingredients.Add(new Protein());

while (choice != "4")
{
    System.Console.WriteLine($"u have ${chef.money} left");

    if (choice == "shop")
    {

        Console.WriteLine("Please buy the ingredients that you want to cook with");
        Console.ReadLine();
        Console.WriteLine("Shop\n 1* Buy Protein?\n 2* Buy Vegetable?\n 3* Buy Spice?\n 4* Complete dish?");
        Console.ReadLine();
        string choice1 = Console.ReadLine();
        choice1 = choice1.ToLower();

        if (choice1 == "1")
        {
            choice = "Protein";
        }
        else if (choice1 != "1")
        {
            choice = "shop";
            Console.WriteLine("please choose one of the shop choices, the corresponding number");
            Console.ReadLine();

        }

    }

    if (choice == "Protein")
    {
Console.WriteLine("you bought a protein for 50");
Console.ReadLine();
choice = "shop";
    }


}
// string[] choices = {"", "", ""};

// foreach (string choice in choices)
// {
//   Console.WriteLine(choice);
// }
