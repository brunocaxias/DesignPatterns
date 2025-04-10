using BuilderRestaurant.ConsoleApp.AbstractBuilder;
using FactoryMethodRestaurant.ConsoleApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderRestaurant.ConsoleApp.Director;
public class Chef
{
    private IBuilder _builder;

    public Chef(IBuilder builder)
    {
        _builder = builder;
    }

    public void MakeSpaghettiPasta()
    {
        _builder.SetPastaType(PastaType.SPAGHETTI);
        _builder.AddSauce("Marinara");
        _builder.AddGarnish("Basil");
        _builder.AddCheese(true);
    }

    public void MakeSpicySpaghetti()
    {
        _builder.SetPastaType(PastaType.SPAGHETTI);
        _builder.AddSauce("Marinara");
        _builder.AddGarnish("Basil");
        _builder.AddCheese(true);
        _builder.MakeSpicy(true);
    }

    public void MakePennePasta()
    {
        _builder.SetPastaType(PastaType.PENNE);
        _builder.AddSauce("Alfredo");
        _builder.AddGarnish("Parsley");
        _builder.AddCheese(true);
    }

    public void MakeSpicyPenne()
    {
        _builder.SetPastaType(PastaType.PENNE);
        _builder.AddSauce("Alfredo");
        _builder.AddGarnish("Parsley");
        _builder.AddCheese(true);
        _builder.MakeSpicy(true);
    }
}
