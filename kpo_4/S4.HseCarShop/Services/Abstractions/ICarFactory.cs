// Мельник Денис 238

using S4.HseCarShop.Models.Abstractions;

namespace S4.HseCarShop.Services.Abstractions;

internal interface ICarFactory<TCar, TCarParams>
    where TCar : ICar
    where TCarParams : struct
{
    TCar CreateCar(TCarParams carParams);
}
