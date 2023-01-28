// See https://aka.ms/new-console-template for more information
using Decorator;

Console.WriteLine("Hello, World!");

var pizza = new PlainPizza();
var decorPizza = new Mushroom(pizza);
Console.WriteLine("cost: " + decorPizza.GetCost());

var decorPizza2 = new ExtraCheese(new Mushroom(new PlainPizza()));
Console.WriteLine("Cost: ", decorPizza2.GetCost());

Console.ReadKey();
