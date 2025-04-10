using BuilderRestaurant.ConsoleApp.AbstractBuilder;
using BuilderRestaurant.ConsoleApp.Object;
using FactoryMethodRestaurant.ConsoleApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderRestaurant.ConsoleApp.ConcreteBuilder;
public class SpaghettiBuilder : IBuilder
{
    private Pasta _pasta = new Pasta();

    public void SetPastaType(PastaType type) => _pasta.PastaType = type;
    public void AddSauce(string sauce) => _pasta.Sauce = sauce;
    public void AddGarnish(string garnish) => _pasta.Garnish = garnish;
    public void AddCheese(bool hasCheese) => _pasta.HasCheese = hasCheese;
    public void MakeSpicy(bool isSpicy) => _pasta.IsSpicy = isSpicy;

    public Pasta GetPasta() => _pasta;
}
