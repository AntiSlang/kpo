using kpo_2.Models;
using kpo_2.Services.Abstractions;

namespace kpo_2.Services;

public class CarShopService
{
    private readonly ICarProvider _carProvider;
    private readonly ICustomersProvider _customersProvider;
    public CarShopService(ICarProvider carProvider, ICustomersProvider customersProvider)
    {
        ArgumentNullException.ThrowIfNull(carProvider, nameof(carProvider));
        ArgumentNullException.ThrowIfNull(customersProvider, nameof(customersProvider));

        _carProvider = carProvider;
        _customersProvider = customersProvider;
    }

    public void SellCars()
    {
        var customers = _customersProvider.GetCustomers();

        foreach (var customer in customers)
        {
            if (customer.Car != null)
                continue;

            var suitableEngineType = customer.DetermineEngineType();

            if (!suitableEngineType.HasValue)
                continue;

            var car = _carProvider.GetCar(suitableEngineType.Value);

            if (car == null)
                continue;

            customer.Car = car;
        }
    }
}
