// Мельник Денис 238

using S4.HseCarShop.Models.Abstractions;

namespace S4.HseCarShop.Models.HandCar;

internal sealed class HandCar : CarBase
{
    public HandCar(Guid number, HandEngine engine)
        : base(number, engine)
    {
    }
}
