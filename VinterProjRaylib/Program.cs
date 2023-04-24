using System;
using System.IO;
using System.Collections.Generic;
playerChef chef = new playerChef();

string choice = "shop";

string[] choices = {"1","2","3","4"};

Dish d = new Dish();
d.ingredients.Add(new Spice());
d.ingredients.Add(new Vegetable());
d.ingredients.Add(new Protein());

while (choice != "4")
{
    Console.WriteLine($"u have ${chef.money} left");

    if (choice == "shop")
    {

        Console.WriteLine("Please buy the ingredients that you want to cook with");
        Console.WriteLine("Shop\n 1* Buy Protein?\n 2* Buy Vegetable?\n 3* Buy Spice?\n 4* Complete\n Write here:");
        string choice1 = Console.ReadLine();
        choice1 = choice1.ToLower();

        if (choice1 == "1")
        {
            choice = "Protein";
        }
        if (choice1 == "2")
        {
            choice = "Vegetable";
        }
        if (choice1 == "3")
        {
            choice = "Spice";
        }
        if (choice1 == "4")
        {
            choice = "Complete";
        }
        else if (!choices.Contains(choice1)) // val 1 är den ända som funkar pga av den här, jag vill att alla ska kunna väljas
        {
            choice = "shop";
            Console.WriteLine("please choose one of the shop choices, the corresponding number");
            Console.ReadLine();

        }
  

    }

    if (choice == "Protein")
    {
        Console.WriteLine("you bought a protein for $50");

        choice = "shop";
    }
    if (choice == "Vegetable")
    {
        Console.WriteLine("you bought a Vegetable for $50");

        choice = "shop";
    }
    if (choice == "Spice")
    {
        Console.WriteLine("you bought a Spice for $50");

        choice = "shop";
    }
    if (choice == "Complete")
    {


        choice = "Dish";
        // om du väljer *4* ska dem ingredienserna du köpt samlas och sen så ska Taste på din Dish räknas ut
        //och så får du poäng av Juryn.
    }
}
// string[] choices = {"", "", ""};

// foreach (string choice in choices)
// {
//   Console.WriteLine(choice);
// }
