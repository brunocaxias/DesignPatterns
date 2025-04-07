using FactoryMethodRestaurant.ConsoleApp.Enums;
using FactoryMethodRestaurant.ConsoleApp.Interfaces;
using FactoryMethodRestaurant.ConsoleApp.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodRestaurant.ConsoleApp.BaseFactory.FactorySubclasses;
public class BurgerStation : Kitchen
{
    private readonly BurgerType _burgerType;

    public BurgerStation(BurgerType type) => _burgerType = type;

    public override IDish MakeFood() => new Burger(_burgerType);
}
