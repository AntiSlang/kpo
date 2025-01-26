using kpo_2.Services;
using kpo_2.Models;

namespace kpo_2;

internal class Program
{
    static void Main(string[] args)
    {
        var customerStorage = new CustomersStorage();
        var customers = new[]
        {
            new Customer(name: "Единица", legStrength: 6, handStrength: 4),
            new Customer(name : "Двойка", legStrength : 4, handStrength : 6),
            new Customer(name : "Тройка", legStrength : 4, handStrength : 4),
            new Customer(name : "Четвёрка", legStrength : 6, handStrength : 6),
        };
        foreach (var customer in customers)
        {
            customerStorage.AddCustomer(customer);
        }
        var pedalCarFactory = new PedalCarFactory();
        var handCarFactory = new HandCarFactory();
        var carStorage = new CarStorage();
        carStorage.AddCar(pedalCarFactory, new PedalEngineParams(pedalSize: 2));
        carStorage.AddCar(pedalCarFactory, new PedalEngineParams(pedalSize: 3));
        carStorage.AddCar(handCarFactory, EmptyEngineParams.EmptyEngine);
        carStorage.AddCar(handCarFactory, EmptyEngineParams.EmptyEngine);
        var hseCarShop = new CarShopService(carStorage, customerStorage);
        Console.WriteLine("Покупатели:");
        foreach (var customer in customers)
        {
            Console.WriteLine(customer);
        }
        Console.WriteLine("\nПродажа автомобилей:\n");
        hseCarShop.SellCars();
        Console.WriteLine("Покупатели:");
        foreach (var customer in customers)
        {
            Console.WriteLine(customer);
        }
    }
}
