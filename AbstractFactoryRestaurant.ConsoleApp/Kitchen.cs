using AbstractFactoryRestaurant.ConsoleApp.AbstractFactory;
using FactoryMethodRestaurant.ConsoleApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryRestaurant.ConsoleApp;
public class Kitchen
{
    private readonly ICuisineFactory _factory;

    public Kitchen(ICuisineFactory factory) => _factory = factory;

    public void OrderMeal()
    {
        Console.WriteLine("=== Placing Order ===");

        var pizza = _factory.CreatePizza(PizzaType.PEPPERONI);
        pizza.Prepare();
        pizza.Bake();

        var burger = _factory.CreateBurger(BurgerType.CHEESEBURGER);
        burger.Grill();
        burger.Assemble();

        Console.WriteLine("--> Meal ready!\n");
    }
}
