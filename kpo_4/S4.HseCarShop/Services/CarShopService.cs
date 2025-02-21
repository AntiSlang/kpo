// Мельник Денис 238

using S4.HseCarShop.Models;
using S4.HseCarShop.Services.Abstractions;

namespace S4.HseCarShop.Services;

internal class CarShopService
{
    private readonly ICarProvider _carProvider;

    private readonly ICustomerProvider _customersProvider;

    private readonly ICarAvailabilityService _availabilityService;

    public CarShopService(
        ICarProvider carProvider,
        ICustomerProvider customersProvider,
        ICarAvailabilityService availabilityService)
    {
        ArgumentNullException.ThrowIfNull(carProvider);
        ArgumentNullException.ThrowIfNull(customersProvider);
        ArgumentNullException.ThrowIfNull(availabilityService);

        _carProvider = carProvider;
        _customersProvider = customersProvider;
        _availabilityService = availabilityService;
        
    }

    public void SellCars()
    {
        var customers = _customersProvider.GetCustomers();

        foreach (var customer in customers)
        {
            if (customer.Car != null)
                continue;

            var availabilityParams = new CarAvailabilityParams
            {
                HandStrength = customer.HandStrength,
                LegStrength = customer.LegStrength,
            };
            var suitableEngineTypes = _availabilityService.GetAvailableCarTypes(availabilityParams);

            if (!suitableEngineTypes.Any())
                continue;

            var car = _carProvider.GetCar(suitableEngineTypes);

            if (car == null)
                continue;

            customer.Car = car;
        }
    }

    private static CarType? DetermineEngineType(Customer customer)
    {
        if (customer.LegStrength > 5)
            return CarType.Pedal;

        if (customer.HandStrength > 5)
            return CarType.Hand;

        return null;
    }
}
