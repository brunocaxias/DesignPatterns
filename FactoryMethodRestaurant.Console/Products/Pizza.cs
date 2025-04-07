using FactoryMethodRestaurant.ConsoleApp.Enums;
using FactoryMethodRestaurant.ConsoleApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodRestaurant.ConsoleApp.Products;
public class Pizza : IDish
{
    public PizzaType Type { get; }

    public string Name => "Pizza";

    public Pizza(PizzaType type) => Type = type;

    public void Prepare() =>
        Console.WriteLine($"Preparing {Type} {Name}: Stretching dough, adding {Type}-specific toppings...");

    public void Serve() =>
        Console.WriteLine($"Serving {Type} {Name}: Sliced and ready!");
}
