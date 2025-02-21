// Мельник Денис 238

using S4.HseCarShop.Models.HybridCar;
using S4.HseCarShop.Services.Abstractions;

namespace S4.HseCarShop.Services.HybridCars;

internal sealed class HybridEngineFactory : IEngineFactory<HybridEngine, HybridEngineParams>
{
    public HybridEngine CreateEngine(HybridEngineParams engineParams)
    {
        return new HybridEngine(engineParams.GripsType, engineParams.PedalSize);
    }
}