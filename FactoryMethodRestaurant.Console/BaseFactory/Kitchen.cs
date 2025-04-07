using FactoryMethodRestaurant.ConsoleApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodRestaurant.ConsoleApp.BaseFactory;
public abstract class Kitchen
{
    // Factory method (to be implemented by stations)
    public abstract IDish MakeFood();

    public void Serve()
    {
        IDish food = MakeFood(); // Delegates dish creation to subclasses
        food.Prepare();
        food.Serve();
    }
}
