using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodRestaurant.ConsoleApp.Interfaces;
public interface IDish
{
    string Name { get; }
    void Serve();
    void Prepare();
}
