using AbstractFactoryRestaurant.ConsoleApp.AbstractProducts;
using FactoryMethodRestaurant.ConsoleApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryRestaurant.ConsoleApp.ConcreateProducts.Italian;
// Italian Pasta
public class ItalianPasta : IPasta
{
    public PastaType Type { get; }
    public ItalianPasta(PastaType type) => Type = type;
    public void Cook() => Console.WriteLine($"Cooking {Type} pasta al dente with handmade sauce...");
    public void Plate() => Console.WriteLine("Plating with a sprinkle of Parmigiano-Reggiano!");
}
