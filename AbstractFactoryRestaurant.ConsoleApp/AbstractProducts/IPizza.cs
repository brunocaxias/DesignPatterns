using FactoryMethodRestaurant.ConsoleApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryRestaurant.ConsoleApp.AbstractProducts;
public interface IPizza
{
    PizzaType Type { get; }
    void Prepare();
    void Bake();
}
