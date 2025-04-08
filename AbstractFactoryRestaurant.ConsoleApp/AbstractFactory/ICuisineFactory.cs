using AbstractFactoryRestaurant.ConsoleApp.AbstractProducts;
using FactoryMethodRestaurant.ConsoleApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryRestaurant.ConsoleApp.AbstractFactory;
public interface ICuisineFactory
{
    IPizza CreatePizza(PizzaType type);
    IPasta CreatePasta(PastaType type);
    IBurger CreateBurger(BurgerType type);
}
