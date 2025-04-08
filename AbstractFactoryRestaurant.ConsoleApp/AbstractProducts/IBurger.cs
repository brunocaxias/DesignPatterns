using FactoryMethodRestaurant.ConsoleApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryRestaurant.ConsoleApp.AbstractProducts;
public interface IBurger
{
    BurgerType Type { get; }
    void Grill();
    void Assemble();
}
