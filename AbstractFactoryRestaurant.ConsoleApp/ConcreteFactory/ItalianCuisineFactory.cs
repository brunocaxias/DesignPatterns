using AbstractFactoryRestaurant.ConsoleApp.AbstractFactory;
using AbstractFactoryRestaurant.ConsoleApp.AbstractProducts;
using AbstractFactoryRestaurant.ConsoleApp.ConcreateProducts.Italian;
using FactoryMethodRestaurant.ConsoleApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryRestaurant.ConsoleApp.ConcreateFactory;
public class ItalianCuisineFactory : ICuisineFactory
{
    public IPizza CreatePizza(PizzaType type) => new ItalianPizza(type);
    public IPasta CreatePasta(PastaType type) => new ItalianPasta(type);
    public IBurger CreateBurger(BurgerType type) => throw new NotImplementedException();
}
