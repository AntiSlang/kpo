// Мельник Денис 238

using S4.HseCarShop.Models;
using S4.HseCarShop.Models.Abstractions;

namespace S4.HseCarShop.Services.Abstractions;

internal interface ICarProvider
{
    ICar? GetCar(IEnumerable<CarType> carType);
}
