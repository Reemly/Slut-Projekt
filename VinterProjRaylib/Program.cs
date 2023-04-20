
playerChef chef = new playerChef();

string place = "shop";

System.Console.WriteLine($"u have ${chef.money} left");
Console.ReadLine();

Console.WriteLine("Please buy the ingredients that you want to cook with");
Console.ReadLine();

Dish d = new Dish();
d.ingredients.Add(new Spice());

string[] choices = {"", "", ""};

foreach (string choice in choices)
{
  Console.WriteLine(choice);
}




// använd en Array(List nu) i Ingredients för att samla alla ingredienser, sedan gör en list i shop som tar
// ut tre ingredienser från Arrayen(list). Sedan samlas ingredienserna du köpt i PlayerChef's Inventory,
// som kan läggas in i CookingPot.