using BuilderRestaurant.ConsoleApp.Object;
using FactoryMethodRestaurant.ConsoleApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderRestaurant.ConsoleApp.AbstractBuilder;
public interface IBuilder
{
    void SetPastaType(PastaType type);
    void AddSauce(string sauce);
    void AddGarnish(string garnish);
    void AddCheese(bool hasCheese);
    void MakeSpicy(bool isSpicy);
    Pasta GetPasta();
}
