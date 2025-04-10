using AbstractFactoryRestaurant.ConsoleApp.AbstractFactory;
using AbstractFactoryRestaurant.ConsoleApp.AbstractProducts;
using AbstractFactoryRestaurant.ConsoleApp.ConcreateProducts.American;
using FactoryMethodRestaurant.ConsoleApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryRestaurant.ConsoleApp.ConcreateFactory;
public class AmericanCuisineFactory : ICuisineFactory
{
    public IPizza CreatePizza(PizzaType type) => new AmericanPizza(type);
    public IPasta CreatePasta(PastaType type) => throw new NotImplementedException();
    public IBurger CreateBurger(BurgerType type) => new AmericanBurger(type);
}
