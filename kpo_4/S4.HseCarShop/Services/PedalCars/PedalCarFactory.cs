// Мельник Денис 238

using S4.HseCarShop.Models.PedalCar;
using S4.HseCarShop.Services.Abstractions;

namespace S4.HseCarShop.Services.PedalCars;

internal sealed class PedalCarFactory : ICarFactory<PedalCar, PedalCarParams>
{
    private readonly IEngineFactory<PedalEngine, PedalEngineParams> _engineFactory;

    public PedalCarFactory(IEngineFactory<PedalEngine, PedalEngineParams> engineFactory)
    {
        ArgumentNullException.ThrowIfNull(engineFactory);

        _engineFactory = engineFactory;
    }

    public PedalCar CreateCar(PedalCarParams carParams)
    {
        var engineParams = new PedalEngineParams { PedalSize = carParams.PedalSize };
        var engine = _engineFactory.CreateEngine(engineParams);
        return new PedalCar(number: Guid.NewGuid(), engine);
    }
}
