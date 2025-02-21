// Мельник Денис 238

using S4.HseCarShop.Models.HandCar;
using S4.HseCarShop.Services.Abstractions;

namespace S4.HseCarShop.Services.HandCars;

internal sealed class HandEngineFactory : IEngineFactory<HandEngine, HandEngineParams>
{
    public HandEngine CreateEngine(HandEngineParams engineParams)
    {
        return new HandEngine(engineParams.GripsType);
    }
}
