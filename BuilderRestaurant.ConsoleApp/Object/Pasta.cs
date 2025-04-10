using FactoryMethodRestaurant.ConsoleApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderRestaurant.ConsoleApp.Object;
public class Pasta
{
    public PastaType PastaType { get; set; }
    public string Sauce { get; set; }
    public string Garnish { get; set; }
    public bool HasCheese { get; set; }
    public bool IsSpicy { get; set; }

    public void Display()
    {
        Console.WriteLine($"Pasta: {PastaType}");
        Console.WriteLine($"Sauce: {Sauce}");
        Console.WriteLine($"Garnish: {Garnish}");
        Console.WriteLine($"Cheese: {(HasCheese ? "Yes" : "No")}");
        Console.WriteLine($"Spicy: {(IsSpicy ? "Yes" : "No")}");
        Console.WriteLine("----------------------");
    }
}
