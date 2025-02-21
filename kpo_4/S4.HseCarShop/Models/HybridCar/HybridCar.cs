// Мельник Денис 238

using S4.HseCarShop.Models.Abstractions;

namespace S4.HseCarShop.Models.HybridCar;

internal sealed class HybridCar : CarBase
{
    public HybridCar(Guid number, IEngine engine)
        : base(number, engine)
    {
    }
}
