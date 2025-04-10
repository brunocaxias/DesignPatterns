using BuilderRestaurant.ConsoleApp;
using BuilderRestaurant.ConsoleApp.ConcreteBuilder;
using BuilderRestaurant.ConsoleApp.Director;
using FactoryMethodRestaurant.ConsoleApp.Enums;

class Program
{
    static void Main(string[] args)
    {
        // Create a builder
        var spaghettiBuilder = new SpaghettiBuilder();

        // Create a director (Chef) and assign the builder
        var chef = new Chef(spaghettiBuilder);

        // Standard pasta
        chef.MakeSpaghettiPasta();
        var standardPasta = spaghettiBuilder.GetPasta();
        standardPasta.Display();

        // Spicy pasta (custom build)
        chef.MakeSpicySpaghetti();
        var spicyPasta = spaghettiBuilder.GetPasta();
        spicyPasta.Display();
    }
}