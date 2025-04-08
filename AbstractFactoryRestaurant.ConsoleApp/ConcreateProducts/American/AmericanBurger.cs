using AbstractFactoryRestaurant.ConsoleApp.AbstractProducts;
using FactoryMethodRestaurant.ConsoleApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryRestaurant.ConsoleApp.ConcreateProducts.American;
// American Burger
public class AmericanBurger : IBurger
{
    public BurgerType Type { get; }
    public AmericanBurger(BurgerType type) => Type = type;
    public void Grill() => Console.WriteLine($"Grilling {Type} burger: Double patty, crispy bacon, melted cheese...");
    public void Assemble() => Console.WriteLine("Stacking on a brioche bun with pickles and ketchup!");
}
