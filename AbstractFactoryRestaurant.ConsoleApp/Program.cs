using AbstractFactoryRestaurant.ConsoleApp;
using AbstractFactoryRestaurant.ConsoleApp.ConcreateFactory;

class Program
{
    static void Main()
    {
        // Italian Restaurant
        var italianRestaurant = new Kitchen(new ItalianCuisineFactory());
        italianRestaurant.OrderMeal();

        // American Diner
        var americanDiner = new Kitchen(new AmericanCuisineFactory());
        americanDiner.OrderMeal();
    }
}