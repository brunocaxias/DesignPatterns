using AbstractFactoryRestaurant.ConsoleApp.AbstractProducts;
using FactoryMethodRestaurant.ConsoleApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryRestaurant.ConsoleApp.ConcreateProducts.Italian;
// Italian Pizza
public class ItalianPizza : IPizza
{
    public PizzaType Type { get; }
    public ItalianPizza(PizzaType type) => Type = type;
    public void Prepare() => Console.WriteLine($"Preparing Italian {Type} pizza: Thin crust, fresh basil, olive oil...");
    public void Bake() => Console.WriteLine("Baking at 400°F in a wood-fired oven!");
}
