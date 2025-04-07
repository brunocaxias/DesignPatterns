using FactoryMethodRestaurant.ConsoleApp.Enums;
using FactoryMethodRestaurant.ConsoleApp.Interfaces;
using FactoryMethodRestaurant.ConsoleApp.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodRestaurant.ConsoleApp.BaseFactory.FactorySubclasses;
public class PizzaStation : Kitchen
{
    private readonly PizzaType _pizzaType;

    public PizzaStation(PizzaType type) => _pizzaType = type;

    public override IDish MakeFood() => new Pizza(_pizzaType);
}

