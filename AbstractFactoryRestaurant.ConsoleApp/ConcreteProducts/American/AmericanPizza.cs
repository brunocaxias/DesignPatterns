using AbstractFactoryRestaurant.ConsoleApp.AbstractProducts;
using FactoryMethodRestaurant.ConsoleApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryRestaurant.ConsoleApp.ConcreateProducts.American;
// American Pizza
public class AmericanPizza : IPizza
{
    public PizzaType Type { get; }
    public AmericanPizza(PizzaType type) => Type = type;
    public void Prepare() => Console.WriteLine($"Preparing American {Type} pizza: Thick crust, extra cheese, heavy toppings...");
    public void Bake() => Console.WriteLine("Baking at 375°F in a conveyor oven!");
}

