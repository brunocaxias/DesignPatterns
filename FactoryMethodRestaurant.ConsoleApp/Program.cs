using FactoryMethodRestaurant.ConsoleApp.BaseFactory.FactorySubclasses;
using FactoryMethodRestaurant.ConsoleApp.BaseFactory;
using FactoryMethodRestaurant.ConsoleApp.Enums;

class Program
{
    static void Main()
    {
        // Initialize stations with specific dish types
        Kitchen margheritaKitchen = new PizzaStation(PizzaType.MARGHERITA);
        Kitchen penneKitchen = new PastaStation(PastaType.PENNE);
        Kitchen veggieBurgerKitchen = new BurgerStation(BurgerType.VEGGIEBURGER);

        Console.WriteLine("=== Pizza Station (Margherita) ===");
        margheritaKitchen.Serve();

        Console.WriteLine("\n=== Pasta Station (Penne) ===");
        penneKitchen.Serve();

        Console.WriteLine("\n=== Burger Station (Veggie) ===");
        veggieBurgerKitchen.Serve();
    }
}