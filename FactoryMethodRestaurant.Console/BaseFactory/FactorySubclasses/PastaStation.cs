using FactoryMethodRestaurant.ConsoleApp.Enums;
using FactoryMethodRestaurant.ConsoleApp.Interfaces;
using FactoryMethodRestaurant.ConsoleApp.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodRestaurant.ConsoleApp.BaseFactory.FactorySubclasses;
public class PastaStation : Kitchen
{
    private readonly PastaType _pastaType;

    public PastaStation(PastaType type) => _pastaType = type;

    public override IDish MakeFood() => new Pasta(_pastaType);
}
