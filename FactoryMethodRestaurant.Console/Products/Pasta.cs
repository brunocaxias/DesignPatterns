using FactoryMethodRestaurant.ConsoleApp.Enums;
using FactoryMethodRestaurant.ConsoleApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodRestaurant.ConsoleApp.Products;
public class Pasta : IDish
{
    public PastaType Type { get; }

    public string Name => "Pasta";

    public Pasta(PastaType type) => Type = type;

    public void Prepare() =>
        Console.WriteLine($"Preparing {Type} {Name}: Boiling {Type}, mixing sauce...");

    public void Serve() =>
        Console.WriteLine($"Serving {Type} {Name}: Plated with garnish!");
}
