// Мельник Денис 238

using S4.HseCarShop.Models.Abstractions;

namespace S4.HseCarShop.Services.Abstractions;

internal interface ICarStorage : ICarProvider
{
    void AddCar(ICar car);

    void AddCars(IEnumerable<ICar> cars);

    void AddCar<TCar, TParams>(ICarFactory<TCar, TParams> carFactory, TParams carParams)
        where TCar : class, ICar
        where TParams : struct;
}
