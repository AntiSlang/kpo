// Мельник Денис 238

using S4.HseCarShop.Models.PedalCar;
using S4.HseCarShop.Services.Abstractions;

namespace S4.HseCarShop.Services.PedalCars;

internal sealed class PedalEngineFactory : IEngineFactory<PedalEngine, PedalEngineParams>
{
    public PedalEngine CreateEngine(PedalEngineParams engineParams)
    {
        return new PedalEngine(engineParams.PedalSize);
    }
}

