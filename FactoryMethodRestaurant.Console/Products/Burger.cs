using FactoryMethodRestaurant.ConsoleApp.Enums;
using FactoryMethodRestaurant.ConsoleApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodRestaurant.ConsoleApp.Products;
public class Burger : IDish
{
    public BurgerType Type { get; }

    public string Name => "Burger";

    public Burger(BurgerType type) => Type = type;

    public void Prepare() =>
        Console.WriteLine($"Preparing {Type} {Name}: Grilling patty, stacking {Type}-specific ingredients...");

    public void Serve() =>
        Console.WriteLine($"Serving {Type} {Name}: Wrapped and delivered!");
}

